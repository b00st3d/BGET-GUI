Public Class optionsDialog
    Dim bgetLoc As String = My.Settings.bgetLocation
    Dim saveLoc As String = My.Settings.saveLoc
    Dim dMethod As String = My.Settings.dMethod
    Dim adl As String = My.Settings.adl

    Private Sub OptionsDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim argument As String = Me.Tag
        Dim general As Panel = GeneralPanel
        Dim bget As Panel = DirectoryPanel
        Dim dmethodPanel As Panel = downloadMethod
        general.Visible = True
        bget.Visible = False
        dmethodPanel.Visible = False
        ListBox1.SetSelected(0, True)

        If saveLoc = "" Then
            If bgetLoc <> "" Then
                Dim path As String = IO.Path.GetDirectoryName(bgetLoc) & "\scripts" 'default scripts location in bget folder
                folderPicker.SelectedPath = path
                saveLoc = path
            End If
        End If
        BgetLocationTextBox.Text = bgetLoc
        DownLocationTextbox.Text = saveLoc

        Select Case dMethod
            Case "usejs"
                radioJS.Checked = True
            Case "useps"
                radioPS.Checked = True
            Case "usevbs"
                radioVBS.Checked = True
            Case "usebits"
                radioBits.Checked = True
            Case "usecurl"
                radioCurl.Checked = True
        End Select
        If argument = "dMethod" Then
            general.Visible = False
            bget.Visible = False
            dmethodPanel.Visible = True
            ListBox1.SetSelected(2, True)
        ElseIf argument = "bgetLoc" Then
            general.Visible = False
            bget.Visible = True
            dmethodPanel.Visible = False
            ListBox1.SetSelected(1, True)
        End If

        If adl = "yes" Then
            buttonADL.Text = "YES"
            buttonADL.ForeColor = Color.Green
        Else
            buttonADL.Text = "NO"
            buttonADL.ForeColor = Color.Red
        End If
    End Sub

    Private Sub BgetFileButton_Click(sender As Object, e As EventArgs) Handles bgetFileButton.Click
        Dim result As DialogResult = filePicker.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Dim file As String = filePicker.FileName
            bgetLoc = IO.Path.GetDirectoryName(file) & "\"
            BgetLocationTextBox.Text = file
            If saveLoc = "" Then
                Dim savePath As String = IO.Path.GetDirectoryName(file) & "\scripts" 'default scripts location in bget folder
                DownLocationTextbox.Text = savePath
                folderPicker.SelectedPath = savePath
                saveLoc = savePath
            End If
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim general As Panel = GeneralPanel
        Dim bget As Panel = DirectoryPanel
        Dim dmethodPanel As Panel = downloadMethod


        Select Case ListBox1.SelectedIndex
            Case 0 'general
                general.Visible = True
                bget.Visible = False
                dmethodPanel.Visible = False
            Case 1 'bget location
                general.Visible = False
                bget.Visible = True
                dmethodPanel.Visible = False
            Case 2 'download method
                general.Visible = False
                bget.Visible = False
                dmethodPanel.Visible = True
        End Select
    End Sub

    Private Sub downFileButton_Click(sender As Object, e As EventArgs) Handles downFileButton.Click
        Dim result As DialogResult = folderPicker.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            saveLoc = folderPicker.SelectedPath
            DownLocationTextbox.Text = saveLoc
        End If
    End Sub

    Private Sub radioJS_CheckedChanged(sender As Object, e As EventArgs) Handles radioJS.CheckedChanged
        dMethod = "usejs"
    End Sub

    Private Sub radioPS_CheckedChanged(sender As Object, e As EventArgs) Handles radioPS.CheckedChanged
        dMethod = "useps"
    End Sub

    Private Sub radioVBS_CheckedChanged(sender As Object, e As EventArgs) Handles radioVBS.CheckedChanged
        dMethod = "usevbs"
    End Sub

    Private Sub radioBits_CheckedChanged(sender As Object, e As EventArgs) Handles radioBits.CheckedChanged
        dMethod = "usebits"
    End Sub

    Private Sub radioCurl_CheckedChanged(sender As Object, e As EventArgs) Handles radioCurl.CheckedChanged
        dMethod = "usecurl"
    End Sub


    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles okButton.Click 'save settings
        My.Settings.bgetLocation = bgetLoc
        My.Settings.saveLoc = saveLoc
        My.Settings.dMethod = dMethod
        My.Settings.adl = adl
        My.Settings.Save()
        DialogResult = DialogResult.OK
        Me.Dispose()
        'Me.Close()
    End Sub
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles cancelButtonOptions.Click 'drop settings
        'don't save settings
        Me.Dispose()
    End Sub

    Private Sub TESTBUTTON_Click(sender As Object, e As EventArgs) Handles TESTBUTTON.Click
        bgetLoc = ""
        saveLoc = ""
        dMethod = "usevbs"
        adl = "yes"
    End Sub

    Private Sub buttonADL_Click(sender As Object, e As EventArgs) Handles buttonADL.Click
        If buttonADL.Text = "YES" Then
            buttonADL.Text = "NO"
            buttonADL.ForeColor = Color.Red
            adl = "no"
        Else
            buttonADL.Text = "YES"
            buttonADL.ForeColor = Color.Green
            adl = "yes"
        End If
    End Sub

    Private Sub buttonDownload_Click(sender As Object, e As EventArgs) Handles buttonDownload.Click
        Process.Start("https://github.com/jahwi/bget/archive/master.zip")
    End Sub
End Class