Imports System.Windows.Forms
Imports System.Text
Imports System.Net

Public Class DialogCheckForUpdate
    Dim _bgetLocal As String
    Dim _bgetRemote As String
    Dim _exeLocal As String
    Dim _exeRemote As String
    Dim _scriptUpdateAvailable As Boolean = False
    Dim _clientUpdateAvailable As Boolean = False

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        If _scriptUpdateAvailable Then
            bget.FormBgetCommand("-upgrade -" & My.Settings.dMethod & " -force", True, False)
        End If
        If _clientUpdateAvailable Then
            'TODO update command
            DownloadUpdate()
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateClose_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CheckForUpdates()
        If My.Settings.bgetLocation <> "" Then
            Dim bgetUpdate As Object = BgetUpdateCheck()
            Dim clientUpdate As Object = ClientUpdateCheck()
            Dim updateAvailable As Boolean = False

            If Not bgetUpdate(0) Then 'no update available for bget script
                If bgetUpdate(1) <> "error" Then _bgetLocal = bgetUpdate(1)
                If bgetUpdate(2) <> "error" Then _bgetRemote = bgetUpdate(2)
            Else 'Update is available
                _bgetLocal = bgetUpdate(1)
                _bgetRemote = bgetUpdate(2)
                _scriptUpdateAvailable = True
            End If
            If Not clientUpdate(0) Then 'no update available for client
                If clientUpdate(1) <> "error" Then _exeLocal = clientUpdate(1)
                If clientUpdate(2) <> "error" Then _exeRemote = clientUpdate(2)
            Else 'Update is available
                _exeLocal = clientUpdate(1)
                _exeRemote = clientUpdate(2)
                _clientUpdateAvailable = True
            End If
            If _scriptUpdateAvailable And _clientUpdateAvailable Then 'both available
                UpdateLabel.Text = "Update available" & vbCrLf & vbCrLf & "Current BGET Version: " & _bgetRemote & vbCrLf & "Your version: " & _bgetLocal _
                   & vbCrLf & vbCrLf & "Current Client version: " & _exeRemote & vbCrLf & "Your version: " & _exeLocal & vbCrLf & vbCrLf & vbCrLf & "Please click update to download the latest version of the bget script and client."
            Else
                If _scriptUpdateAvailable And Not _clientUpdateAvailable Then 'script update available
                    UpdateLabel.Text = "Update available" & vbCrLf & vbCrLf & "Current BGET Version: " & _bgetRemote & vbCrLf & "Your version: " & _bgetLocal _
                                       & vbCrLf & vbCrLf & vbCrLf & "Please click update to download the latest version of the bget script."
                Else
                    If Not _scriptUpdateAvailable And _clientUpdateAvailable Then 'client update available
                        UpdateLabel.Text = "Update available" & vbCrLf & vbCrLf & "Current client Version: " & _exeRemote & vbCrLf & "Your version: " & _exeLocal _
                                           & vbCrLf & vbCrLf & vbCrLf & "Please click update to download the latest version of the bget client."
                    Else 'No updates available
                        UpdateLabel.Text = "Bget is up to date."
                    End If
                End If
            End If

        Else
            MsgBox("Please locate BGET first")
            Me.Close()
        End If
    End Sub


    Private Function ClientUpdateCheck() As Object
        Const address As String = "https://raw.githubusercontent.com/b00st3d/BGET-GUI/master/version.txt"
        Dim localVersion As String = My.Settings.version.Replace(" ", "")
        Dim remoteVersion As String
        Dim update As Object
        Try
            Using client As New WebClient()
                remoteVersion = client.DownloadString(address).Replace(" ", "")
            End Using
        Catch ex As Exception
            remoteVersion = "error"
        End Try
        If localVersion = remoteVersion Then
            update = {False, localVersion, remoteVersion} 'up to date
        Else
            If remoteVersion = "error" Then 'couldn't access remote
                update = {False, localVersion, remoteVersion}
            Else
                update = {True, localVersion, remoteVersion} 'update is available
            End If
        End If
        Return update
    End Function


    Private Function BgetUpdateCheck() As Object
        Const addr As String = "https://raw.githubusercontent.com/jahwi/bget/master/bin/version.txt"
        Dim localVersion As String
        Dim remoteVersion As String
        Dim update As Object = {False, "error", "error"}
        Try
            Dim lines() As String = System.IO.File.ReadAllLines(My.Settings.bgetLocation & "\bin\version.txt")
            localVersion = lines(0).Replace(" ", "")
        Catch ex As Exception
            localVersion = "error"
        End Try

        Try
            Using client As New WebClient
                client.DownloadFile(addr, My.Computer.FileSystem.SpecialDirectories.Temp & "\bgetVer.txt")
            End Using
            Dim lines() As String = System.IO.File.ReadAllLines(My.Computer.FileSystem.SpecialDirectories.Temp & "\bgetVer.txt")
            remoteVersion = lines(0).Replace(" ", "")
        Catch ex As Exception
            remoteVersion = "error"
        End Try

        If localVersion = "error" Or remoteVersion = "error" Then
            update = {False, localVersion, remoteVersion} 'error accessing local or remote file
        Else
            If localVersion = remoteVersion Then
                update = {False, localVersion, remoteVersion} 'no update available
            Else
                If localVersion <> remoteVersion Then
                    update = {True, localVersion, remoteVersion} 'update available
                End If
            End If
        End If
        Return update
    End Function

    Public Function checkUpdates() As Boolean
        CheckForUpdates()
        If _clientUpdateAvailable Or _scriptUpdateAvailable Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub DownloadUpdate()
        Dim addr As String = "https://github.com/b00st3d/BGET-GUI/raw/master/bin/Debug/Bget.exe"
        Dim localAddr As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\bget.exe"
        Dim installPath As String = My.Application.Info.DirectoryPath
        Try
            Using client As New WebClient
                client.DownloadFile(addr, localAddr) 'download to temp
            End Using
            Dim update As New ProcessStartInfo()
            update.Arguments = "/C choice /C Y /N /D Y /T 1 & del """ & Application.ExecutablePath & """ & copy """ & localAddr & """ """ & installPath & """ & start """" """ & Application.ExecutablePath & """"
            update.WindowStyle = ProcessWindowStyle.Hidden
            update.CreateNoWindow = True
            update.FileName = "cmd.exe"
            Process.Start(update)
            Application.Exit()
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            MsgBox("Update failed.  Please check your network settings.")
        End Try
    End Sub

    Private Sub DialogCheckForUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Update_Button.Visible = False
        CheckForUpdates()
        If _clientUpdateAvailable Or _scriptUpdateAvailable Then
            Update_Button.Visible = True
        End If
    End Sub
End Class
