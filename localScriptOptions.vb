Imports System.Windows.Forms

Public Class localScriptOptions
    Dim script As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub



    Private Sub ButtonOpenFolder_Click(sender As Object, e As EventArgs) Handles ButtonOpenFolder.Click
        Process.Start(My.Settings.saveLoc & "\" & script)
    End Sub

    Private Sub ComboBoxOptions_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBoxOptions.KeyPress
        e.Handled = True
    End Sub
    Private Sub localScriptOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        script = Me.Tag
        Me.Text = script & " - Options"
        Label1.Text = "Options available for local script: " & script
        toolTip.SetToolTip(ButtonOpenFolder, "View script folder in explorer")
    End Sub
End Class
