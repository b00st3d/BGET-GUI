Imports System.IO

'TODO build installer

Public Class bget
    ReadOnly _scriptsList As New List(Of Script)
    ReadOnly _localList As New List(Of Script)

    Private Sub Bget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim titlebarHeight As Integer = SystemInformation.CaptionHeight
        Dim borderThickness As Integer = SystemInformation.FrameBorderSize.Width
        mainWindow.Height = Height - titlebarHeight - borderThickness - 39
        mainWindow.Width = Width - 100 - borderThickness - 18
        'if this exe is placed in the bget root directory, then default to use the bget.bat located there.
        If My.Settings.bgetLocation = "" Then
            If My.Computer.FileSystem.FileExists(CurDir() & "\bget.bat") Then
                My.Settings.bgetLocation = CurDir() & "\"
                If My.Settings.saveLoc = "" Then
                    My.Settings.saveLoc = CurDir() & "\scripts"
                End If
            End If
        End If
        toolTip.SetToolTip(methodLabel, UpdateMethodLabel()) 'updates download method label and adds tootip
        UpdateBget()
        If Not My.Settings.bgetLocation = "" Then 'fill server combobox
            Dim result = FormBgetCommand("-list -server -" & My.Settings.dMethod & " -full", False, True)
            DisplayResults(result)
        End If
        If Not My.Settings.saveLoc = "" Then 'fill local combobox
            Dim results = FormBgetCommand("-list -local", False, True)
            LocalResults(results)
        End If
        If My.Settings.bgetLocation = "" Then
            consoleTextBox.Text = "Please download BGET From https://github.com/jahwi/bget/archive/master.zip" & vbCrLf &
                                  vbCrLf &
                                  "If you have already downloaded BGET, please located it in the preferences or by double clicking the red 'NO' under location set."
        ElseIf Not My.Settings.saveLoc = "" Then
            FormBgetCommand("-list -local", True, False)
        End If

        toolTip.SetToolTip(ButtonUpdateAll, "Check for and update local scripts")
        toolTip.SetToolTip(ButtonLocal, "Open scripts folder in explorer")
        toolTip.SetToolTip(buttonLocalScripts, "Reload local scripts")
        toolTip.SetToolTip(buttonPastebin, "Download script from pastebin.com")
        toolTip.SetToolTip(buttonListServer, "Reload scripts available on server")
        toolTip.SetToolTip(ComboBoxScripts, "List of available scripts on server")
        toolTip.SetToolTip(ComboBoxLocal, "List of available scripts downloaded")
    End Sub

    Private Sub LocalResults(result) 'sub to read local scripts into combobox
        _localList.Clear()
        ComboBoxLocal.Items.Clear()
        Dim read As StreamReader
        Try
            read = File.OpenText(result)
            For a = 1 To 7
                read.ReadLine() 'skip the first 10 lines
            Next
            Do Until read.EndOfStream
                Dim line As String = read.ReadLine()
                If Not line = "---------Pastebin Downloads---------------------" Then
                    Dim num As Integer = line.Split(".")(0)
                    Dim myName As String = line.Split(" ")(1)
                    _localList.Add(New Script(num, myName, "no category", "no description", "no author", "no modified"))
                End If
            Loop
            For Each obj As Script In _localList
                ComboBoxLocal.Items.Add(obj.Name)
            Next
            read.Dispose()
            My.Computer.FileSystem.DeleteFile(result)
        Catch ex As Exception
            Console.WriteLine()
        End Try
        ComboBoxLocal.Text = "Local Scripts"
    End Sub

    Private Sub DisplayResults(result) 'sub to read script list into combobox
        _scriptsList.Clear()
        Dim read As StreamReader
        Try
            read = File.OpenText(result)
            For a = 1 To 10
                read.ReadLine() 'skip the first 10 lines
            Next
            Do Until read.EndOfStream
                Dim line As String = read.ReadLine()
                Dim num As Integer = line.Split(".")(0)
                Dim myName As String = (line.Split("|")(0)).Split(".")(1)
                Dim cat As String = (line.Split("|")(1)).Replace(" ", "")
                Dim desc As String = line.Split("|")(2)
                Dim auth As String = line.Split("|")(3)
                Dim modified As String = line.Split("|")(4)

                _scriptsList.Add(New Script(num, myName, cat, desc, auth, modified))
            Loop
            ComboBoxScripts.Items.Clear() 'remove current list
            For Each obj As Script In _scriptsList
                ComboBoxScripts.Items.Add(obj.Name)
            Next
            read.Dispose()
            My.Computer.FileSystem.DeleteFile(result)
        Catch ex As Exception
            Console.WriteLine()
        End Try
    End Sub




    Public Sub UpdateBget()
        If My.Settings.bgetLocation = "" Then
            toolTip.SetToolTip(locationStatusLabel, "Click here to locate Bget.bat")
            locationStatusLabel.Text = "NO"
            locationStatusLabel.ForeColor = Color.Red
        Else
            toolTip.SetToolTip(locationStatusLabel, My.Settings.bgetLocation)
            locationStatusLabel.Text = "YES"
            locationStatusLabel.ForeColor = Color.Green
            FormBgetCommand("-set -scl " & My.Settings.saveLoc, True, True)
        End If
        If Not My.Settings.saveLoc = "" Then
            FormBgetCommand("-set -scl '" & My.Settings.saveLoc & "'", True, True)
        End If
        FormBgetCommand("-set -adl " & My.Settings.adl, True, True)
    End Sub

    Private Function UpdateMethodLabel() As String
        Dim currentMethod = "invalid"
        Select Case My.Settings.dMethod
            Case "usejs"
                currentMethod = "Javascript"
                methodLabel.Text = currentMethod
            Case "useps"
                currentMethod = "Powershell"
                methodLabel.Text = currentMethod
            Case "usevbs"
                currentMethod = "VBS"
                methodLabel.Text = currentMethod
            Case "usebits"
                currentMethod = "BITS"
                methodLabel.Text = currentMethod
            Case "usecurl"
                currentMethod = "Curl"
                methodLabel.Text = currentMethod
        End Select
        Return currentMethod
    End Function

    Public Function FormBgetCommand(myArgument As String, deleteFile As Boolean, suppressOutput As Boolean) As String
        Dim bgetPath As String = My.Settings.bgetLocation
        consoleTextBox.Text = ""
        Dim outputPath As String = My.Computer.FileSystem.SpecialDirectories.Temp
        Dim outputFileName As String = Path.GetRandomFileName()
        Dim fullOutputName As String = Path.Combine(outputPath, outputFileName)
        Dim batchFilePath As String = bgetPath
        Dim batchFileName As String = "bget.bat" & " " & myArgument
        Dim batchFullName As String = Path.Combine(batchFilePath, batchFileName)
        Dim batchLines As New List(Of String)
        batchLines.Add(batchFullName & " > " & fullOutputName)
        ExecuteDosScript(batchLines)
        Try
            Dim batchResult As String = File.ReadAllText(fullOutputName)
            If Not suppressOutput Then
                consoleTextBox.Text = batchResult
            End If
            If deleteFile Then
                My.Computer.FileSystem.DeleteFile(fullOutputName)
                fullOutputName = Nothing
            End If
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try

        Return fullOutputName
    End Function

    Private Sub ExecuteDosScript(batchScriptLines As List(Of String))
        Dim outputString As String = String.Empty
        Using process As New Process
            AddHandler process.OutputDataReceived, Sub(sender As Object, lineOut As DataReceivedEventArgs)
                                                       outputString = outputString & lineOut.Data & vbCrLf
                                                   End Sub
            process.StartInfo.FileName = "cmd"
            process.StartInfo.UseShellExecute = False
            process.StartInfo.CreateNoWindow = True
            process.StartInfo.RedirectStandardInput = True
            process.StartInfo.RedirectStandardOutput = True
            process.StartInfo.RedirectStandardError = True
            consoleTextBox.Text = "Requesting data, Please wait..."
            process.Start()
            process.BeginOutputReadLine()
            Using inputStream As StreamWriter = process.StandardInput
                inputStream.AutoFlush = False
                For Each scriptLine As String In batchScriptLines
                    inputStream.Write(scriptLine & vbCrLf)
                Next
            End Using
            Do
                Application.DoEvents()
            Loop Until process.HasExited
        End Using
        consoleTextBox.Text = ""
    End Sub

    Private Sub LocationStatusLabel_Click(sender As Object, e As EventArgs) Handles locationStatusLabel.DoubleClick
        Dim arg = "bgetLoc"
        optionsDialog.Tag = arg
        If My.Forms.optionsDialog.ShowDialog = DialogResult.OK Then
            toolTip.SetToolTip(methodLabel, UpdateMethodLabel())
            UpdateBget()
            FormBgetCommand("-list -local", True, False)
        End If
    End Sub

    Private Sub methodLabel_Click(sender As Object, e As EventArgs) Handles methodLabel.DoubleClick
        Dim arg = "dMethod"
        optionsDialog.Tag = arg
        If My.Forms.optionsDialog.ShowDialog = DialogResult.OK Then
            toolTip.SetToolTip(methodLabel, UpdateMethodLabel())
            UpdateBget()
            FormBgetCommand("-list -local", True, False)
        End If
    End Sub

    Private Sub PreferencesToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles PreferencesToolStripMenuItem.Click
        If My.Forms.optionsDialog.ShowDialog = DialogResult.OK Then
            toolTip.SetToolTip(methodLabel, UpdateMethodLabel())

            If Not My.Settings.bgetLocation = "" Then
                UpdateBget()
                FormBgetCommand("-list -local", True, False)
            End If
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        My.Forms.DialogAbout.ShowDialog()
    End Sub

    Private Sub DocumentationToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles DocumentationToolStripMenuItem.Click
        My.Forms.helpdoc.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub methodLabel_Click_1(sender As Object, e As EventArgs) Handles methodLabel.Click
    End Sub

    Private Sub ButtonLocal_Click(sender As Object, e As EventArgs) Handles ButtonLocal.Click
        If Not My.Settings.saveLoc = "" Then
            Process.Start(My.Settings.saveLoc)
        Else
            MsgBox("Scripts folder not found")
        End If
    End Sub

    Private Sub ButtonPastebin_Click(sender As Object, e As EventArgs) Handles buttonPastebin.Click
        If Not My.Settings.bgetLocation = "" Then
            Dim pb As String =
                    InputBox(
                        "Please enter the address you would like to download from pastebin" & vbCrLf & vbCrLf &
                        "Only enter the paste code (ie. a8CUqieP)", "Pastebin Download", "")
            If Not pb = "" Then
                Dim lf As String =
                        InputBox(
                            "Please enter the name you want to save this script as" & vbCrLf & vbCrLf &
                            "Title must be one word", "Pastebin Download", "")
                If Not lf = "" Then
                    Try
                        FormBgetCommand("-pastebin -" & My.Settings.dMethod & " " & pb & " " & lf, True, False)
                    Catch ex As Exception
                        MsgBox("Title must be one (1) word without quotes.  Nothing more, nothing less")
                    End Try

                End If
            End If
        End If
    End Sub

    Private Sub ComboBoxLocal_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles ComboBoxLocal.SelectedIndexChanged
        If ComboBoxLocal.SelectedIndex = -1 Then
            ActiveControl = consoleTextBox
            ComboBoxLocal.Text = "Server Scripts"
        End If
        Try
            If Not ComboBoxLocal.SelectedIndex = -1 Then
                Dim script As Object = _localList(ComboBoxLocal.SelectedIndex)
                Dim response As Integer =
                        MsgBox(
                            "Click OK to access more options for the script." & vbCrLf & vbCrLf & "Script name: " &
                            script.name, vbOKCancel, "Local Script Options")
                Dim arg = script.name
                Dim localOptions = New localScriptOptions
                Dim dialogReturn = ""
                Dim filepath = My.Settings.saveLoc & "\" & arg
                If response = 1 Then
                    localOptions.Tag = arg
                    If localOptions.ShowDialog() = DialogResult.OK Then
                        If Not localOptions.ComboBoxOptions.SelectedIndex = -1 Then
                            dialogReturn = localOptions.ComboBoxOptions.SelectedItem.ToString
                            localOptions.Dispose()
                        End If
                    End If
                    If dialogReturn = "Info" Then
                        FormBgetCommand("-info -" & My.Settings.dMethod & " " & arg, True, False)
                    End If
                    If dialogReturn = "Update" Then
                        FormBgetCommand("-update -" & My.Settings.dMethod & " " & arg & " -force", True, False)
                    End If
                    If dialogReturn = "Delete" Then
                        Dim deleteBackout As Integer = MsgBox("Are you sure you want to delete " & arg & "?", vbYesNo,
                                                              "Delete File")
                        If deleteBackout = 6 Then
                            If Directory.Exists(filepath) Then
                                Try
                                    Directory.Delete(filepath, True)
                                Catch ex As Exception
                                    MsgBox("Error deleting file")
                                End Try
                                'ComboBoxLocal.Items.Clear()
                                LocalResults(FormBgetCommand("-list -local", False, False))
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
        For i As Integer = 1 To 7
            System.Windows.Forms.SendKeys.Send("{TAB}") 'send 7 tab keys so lostfocus will fire and return to combobox...I know..I don't care.
        Next

    End Sub

    Private Sub ComboBoxLocal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxLocal.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBoxLocal_LostFocus(sender As Object, e As EventArgs) Handles ComboBoxLocal.LostFocus
        If ComboBoxLocal.Text = "" Then
            ComboBoxLocal.Text = "Server Scripts"
        End If
    End Sub

    Private Sub ComboBoxScripts_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles ComboBoxScripts.SelectedIndexChanged
        Try
            Dim i As Integer = ComboBoxScripts.SelectedIndex
            Dim script As Object = _scriptsList(i)
            Dim msg = "Click OK to download" & vbCrLf & vbCrLf & vbCrLf & "Script Name: " & script.Name & vbCrLf &
                      "Description: " & script.Description & vbCrLf & "Author: " & script.Author & vbCrLf & "Category: " &
                      script.Category & vbCrLf & "Last Modified: " & script.Modified
            Dim downloader As Integer = MsgBox(msg, vbOKCancel, "Download")
            If downloader = 1 Then
                FormBgetCommand("-get -" & My.Settings.dMethod & " " & script.Name, True, False)
                ComboBoxLocal.Items.Clear()
                LocalResults(FormBgetCommand("-list -local", False, False))
            End If
        Catch ex As Exception
            ComboBoxScripts.SelectedIndex = -1
        End Try
    End Sub

    Private Sub ComboBoxScripts_LostFocus(sender As Object, e As EventArgs) Handles ComboBoxScripts.LostFocus
        ComboBoxScripts.Text = "Server Scripts"
    End Sub

    Private Sub ComboBoxScripts_KeyDown(sender As Object, e As KeyPressEventArgs) Handles ComboBoxScripts.KeyPress
        e.Handled = True
    End Sub

    Private Sub buttonListServer_Click(sender As Object, e As EventArgs) Handles buttonListServer.Click
        buttonListServer.Enabled = False 'prevent double click
        If Not My.Settings.bgetLocation = "" Then
            Dim results = FormBgetCommand("-list -server -" & My.Settings.dMethod & " -full", False, True)
            FormBgetCommand("-list -server -" & My.Settings.dMethod, True, False) _
            'display neater data, but store full descriptions in the objects

            DisplayResults(results)
        Else
            MsgBox("Please locate BGET first")
        End If
        buttonListServer.Enabled = True
    End Sub

    Private Sub buttonLocalScripts_Click(sender As Object, e As EventArgs) Handles buttonLocalScripts.Click
        buttonLocalScripts.Enabled = False 'prevent double click
        ComboBoxLocal.Items.Clear()
        If Not My.Settings.bgetLocation = "" Then
            Dim results = FormBgetCommand("-list -local", False, False)
            LocalResults(results)
        Else
            MsgBox("Please locate BGET first")
        End If
        buttonLocalScripts.Enabled = True
    End Sub

    Private Sub ButtonUpdateAll_Click(sender As Object, e As EventArgs) Handles ButtonUpdateAll.Click
        ButtonUpdateAll.Enabled = False 'prevent double click
        If Not My.Settings.bgetLocation = "" Then
            FormBgetCommand("-update -" & My.Settings.dMethod & " -all", True, False)
        End If
        ButtonUpdateAll.Enabled = True
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles CheckForUpdatesToolStripMenuItem.Click
        If DialogCheckForUpdate.ShowDialog() = DialogResult.OK Then
            Dim results = FormBgetCommand("-list -local", False, False)
            LocalResults(results)
        End If

    End Sub

    Private Sub ClearSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearSettingsToolStripMenuItem.Click
        My.Settings.bgetLocation = ""
        My.Settings.saveLoc = ""
        My.Settings.dMethod = "usevbs"
        My.Settings.Save()

        UpdateMethodLabel()
        UpdateBget()
        consoleTextBox.Text = "Please download BGET From https://github.com/jahwi/bget/archive/master.zip" & vbCrLf &
                              vbCrLf &
                              "If you have already downloaded BGET, please located it in the preferences or by double clicking the red 'NO' under location set."
    End Sub
End Class
