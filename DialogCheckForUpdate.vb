Imports System.Windows.Forms
Imports System.Text
Imports System.Net

Public Class DialogCheckForUpdate

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        bget.FormBgetCommand("-upgrade -" & My.Settings.dMethod & " -force", True, False)
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateClose_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub VersionCheck()
        If Not My.Settings.bgetLocation = "" Then
            Dim addr As String = "https://raw.githubusercontent.com/jahwi/bget/master/bin/version.txt"
            Dim client As WebClient = New WebClient()
            Dim serverVersion As String
            Dim localVersion As String
            Try
                serverVersion = client.DownloadString(addr)
                localVersion = System.IO.File.ReadAllText(My.Settings.bgetLocation & "\bin\version.txt")
                If Not serverVersion = localVersion Then
                    Update_Button.Visible = True
                    Update_Button.Enabled = True
                    UpdateLabel.Text = "Update available" & vbCrLf & vbCrLf & "Current Version: " & serverVersion & vbCrLf & "Your version: " & localVersion _
                        & vbCrLf & vbCrLf & vbCrLf & "Please click update to download the latest version of bget."
                Else
                    UpdateLabel.Text = "No updates available"
                    Update_Button.Visible = False
                    Update_Button.Enabled = False
                End If
            Catch ex As Exception
                Console.WriteLine(ex.ToString)
            End Try

        Else
            msgBox("Please locate BGET first")
        End If

    End Sub

    Private Sub DialogCheckForUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VersionCheck()
    End Sub
End Class
