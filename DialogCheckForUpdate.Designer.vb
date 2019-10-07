<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DialogCheckForUpdate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Update_Button = New System.Windows.Forms.Button()
        Me.UpdateClose_Button = New System.Windows.Forms.Button()
        Me.UpdateLabel = New System.Windows.Forms.Label()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Update_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.UpdateClose_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 274)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Update_Button
        '
        Me.Update_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Update_Button.Location = New System.Drawing.Point(3, 3)
        Me.Update_Button.Name = "Update_Button"
        Me.Update_Button.Size = New System.Drawing.Size(67, 23)
        Me.Update_Button.TabIndex = 0
        Me.Update_Button.Text = "Update"
        Me.Update_Button.Visible = False
        '
        'UpdateClose_Button
        '
        Me.UpdateClose_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UpdateClose_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.UpdateClose_Button.Location = New System.Drawing.Point(76, 3)
        Me.UpdateClose_Button.Name = "UpdateClose_Button"
        Me.UpdateClose_Button.Size = New System.Drawing.Size(67, 23)
        Me.UpdateClose_Button.TabIndex = 1
        Me.UpdateClose_Button.Text = "Close"
        '
        'UpdateLabel
        '
        Me.UpdateLabel.Location = New System.Drawing.Point(0, 79)
        Me.UpdateLabel.Name = "UpdateLabel"
        Me.UpdateLabel.Size = New System.Drawing.Size(430, 180)
        Me.UpdateLabel.TabIndex = 1
        Me.UpdateLabel.Text = "Unable to access update server." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please check your internet connection and try " &
    "again."
        '
        'DialogCheckForUpdate
        '
        Me.AcceptButton = Me.Update_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.UpdateClose_Button
        Me.ClientSize = New System.Drawing.Size(435, 315)
        Me.Controls.Add(Me.UpdateLabel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogCheckForUpdate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DialogCheckForUpdate"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Update_Button As System.Windows.Forms.Button
    Friend WithEvents UpdateClose_Button As System.Windows.Forms.Button
    Friend WithEvents UpdateLabel As Label
    Friend WithEvents toolTip As ToolTip
End Class
