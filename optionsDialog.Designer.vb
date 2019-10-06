<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class optionsDialog
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
        Me.cancelButtonOptions = New System.Windows.Forms.Button()
        Me.okButton = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DirectoryPanel = New System.Windows.Forms.Panel()
        Me.downFileButton = New System.Windows.Forms.Button()
        Me.DownLocationTextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bgetFileButton = New System.Windows.Forms.Button()
        Me.BgetLocationTextBox = New System.Windows.Forms.TextBox()
        Me.LocLabel = New System.Windows.Forms.Label()
        Me.filePicker = New System.Windows.Forms.OpenFileDialog()
        Me.GeneralPanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.buttonADL = New System.Windows.Forms.Button()
        Me.downloadMethod = New System.Windows.Forms.Panel()
        Me.radioCurl = New System.Windows.Forms.RadioButton()
        Me.radioBits = New System.Windows.Forms.RadioButton()
        Me.radioVBS = New System.Windows.Forms.RadioButton()
        Me.radioPS = New System.Windows.Forms.RadioButton()
        Me.radioJS = New System.Windows.Forms.RadioButton()
        Me.SaveLocLabel = New System.Windows.Forms.Label()
        Me.folderPicker = New System.Windows.Forms.FolderBrowserDialog()
        Me.TESTBUTTON = New System.Windows.Forms.Button()
        Me.buttonDownload = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DirectoryPanel.SuspendLayout()
        Me.GeneralPanel.SuspendLayout()
        Me.downloadMethod.SuspendLayout()
        Me.SuspendLayout()
        '
        'cancelButtonOptions
        '
        Me.cancelButtonOptions.Location = New System.Drawing.Point(627, 215)
        Me.cancelButtonOptions.Name = "cancelButtonOptions"
        Me.cancelButtonOptions.Size = New System.Drawing.Size(75, 23)
        Me.cancelButtonOptions.TabIndex = 1
        Me.cancelButtonOptions.Text = "Cancel"
        Me.cancelButtonOptions.UseVisualStyleBackColor = True
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(546, 215)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(75, 23)
        Me.okButton.TabIndex = 0
        Me.okButton.Text = "OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"General", "Default Directory", "Download Method"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(169, 199)
        Me.ListBox1.TabIndex = 2
        '
        'DirectoryPanel
        '
        Me.DirectoryPanel.Controls.Add(Me.downFileButton)
        Me.DirectoryPanel.Controls.Add(Me.DownLocationTextbox)
        Me.DirectoryPanel.Controls.Add(Me.Label1)
        Me.DirectoryPanel.Controls.Add(Me.bgetFileButton)
        Me.DirectoryPanel.Controls.Add(Me.BgetLocationTextBox)
        Me.DirectoryPanel.Controls.Add(Me.LocLabel)
        Me.DirectoryPanel.Location = New System.Drawing.Point(187, 12)
        Me.DirectoryPanel.Name = "DirectoryPanel"
        Me.DirectoryPanel.Size = New System.Drawing.Size(515, 197)
        Me.DirectoryPanel.TabIndex = 3
        '
        'downFileButton
        '
        Me.downFileButton.Location = New System.Drawing.Point(416, 65)
        Me.downFileButton.Name = "downFileButton"
        Me.downFileButton.Size = New System.Drawing.Size(75, 23)
        Me.downFileButton.TabIndex = 5
        Me.downFileButton.Text = "Browse..."
        Me.downFileButton.UseVisualStyleBackColor = True
        '
        'DownLocationTextbox
        '
        Me.DownLocationTextbox.Location = New System.Drawing.Point(6, 67)
        Me.DownLocationTextbox.Name = "DownLocationTextbox"
        Me.DownLocationTextbox.ReadOnly = True
        Me.DownLocationTextbox.Size = New System.Drawing.Size(404, 20)
        Me.DownLocationTextbox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Script Download Location"
        '
        'bgetFileButton
        '
        Me.bgetFileButton.Location = New System.Drawing.Point(416, 26)
        Me.bgetFileButton.Name = "bgetFileButton"
        Me.bgetFileButton.Size = New System.Drawing.Size(75, 23)
        Me.bgetFileButton.TabIndex = 2
        Me.bgetFileButton.Text = "Browse..."
        Me.bgetFileButton.UseVisualStyleBackColor = True
        '
        'BgetLocationTextBox
        '
        Me.BgetLocationTextBox.Location = New System.Drawing.Point(6, 28)
        Me.BgetLocationTextBox.Name = "BgetLocationTextBox"
        Me.BgetLocationTextBox.ReadOnly = True
        Me.BgetLocationTextBox.Size = New System.Drawing.Size(404, 20)
        Me.BgetLocationTextBox.TabIndex = 1
        '
        'LocLabel
        '
        Me.LocLabel.AutoSize = True
        Me.LocLabel.Location = New System.Drawing.Point(3, 12)
        Me.LocLabel.Name = "LocLabel"
        Me.LocLabel.Size = New System.Drawing.Size(103, 13)
        Me.LocLabel.TabIndex = 0
        Me.LocLabel.Text = "Bget Script Location"
        '
        'filePicker
        '
        Me.filePicker.FileName = "Bget.bat"
        '
        'GeneralPanel
        '
        Me.GeneralPanel.Controls.Add(Me.Label3)
        Me.GeneralPanel.Controls.Add(Me.buttonDownload)
        Me.GeneralPanel.Controls.Add(Me.Label2)
        Me.GeneralPanel.Controls.Add(Me.buttonADL)
        Me.GeneralPanel.Location = New System.Drawing.Point(187, 12)
        Me.GeneralPanel.Name = "GeneralPanel"
        Me.GeneralPanel.Size = New System.Drawing.Size(515, 197)
        Me.GeneralPanel.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Auto Delete Temp Files"
        '
        'buttonADL
        '
        Me.buttonADL.ForeColor = System.Drawing.Color.Green
        Me.buttonADL.Location = New System.Drawing.Point(22, 28)
        Me.buttonADL.Name = "buttonADL"
        Me.buttonADL.Size = New System.Drawing.Size(75, 23)
        Me.buttonADL.TabIndex = 1
        Me.buttonADL.Text = "YES"
        Me.buttonADL.UseVisualStyleBackColor = True
        '
        'downloadMethod
        '
        Me.downloadMethod.Controls.Add(Me.radioCurl)
        Me.downloadMethod.Controls.Add(Me.radioBits)
        Me.downloadMethod.Controls.Add(Me.radioVBS)
        Me.downloadMethod.Controls.Add(Me.radioPS)
        Me.downloadMethod.Controls.Add(Me.radioJS)
        Me.downloadMethod.Controls.Add(Me.SaveLocLabel)
        Me.downloadMethod.Location = New System.Drawing.Point(187, 12)
        Me.downloadMethod.Name = "downloadMethod"
        Me.downloadMethod.Size = New System.Drawing.Size(515, 197)
        Me.downloadMethod.TabIndex = 5
        '
        'radioCurl
        '
        Me.radioCurl.AutoSize = True
        Me.radioCurl.Location = New System.Drawing.Point(6, 110)
        Me.radioCurl.Name = "radioCurl"
        Me.radioCurl.Size = New System.Drawing.Size(43, 17)
        Me.radioCurl.TabIndex = 5
        Me.radioCurl.TabStop = True
        Me.radioCurl.Text = "Curl"
        Me.radioCurl.UseVisualStyleBackColor = True
        '
        'radioBits
        '
        Me.radioBits.AutoSize = True
        Me.radioBits.Location = New System.Drawing.Point(6, 90)
        Me.radioBits.Name = "radioBits"
        Me.radioBits.Size = New System.Drawing.Size(49, 17)
        Me.radioBits.TabIndex = 4
        Me.radioBits.TabStop = True
        Me.radioBits.Text = "BITS"
        Me.radioBits.UseVisualStyleBackColor = True
        '
        'radioVBS
        '
        Me.radioVBS.AutoSize = True
        Me.radioVBS.Location = New System.Drawing.Point(6, 70)
        Me.radioVBS.Name = "radioVBS"
        Me.radioVBS.Size = New System.Drawing.Size(46, 17)
        Me.radioVBS.TabIndex = 3
        Me.radioVBS.TabStop = True
        Me.radioVBS.Text = "VBS"
        Me.radioVBS.UseVisualStyleBackColor = True
        '
        'radioPS
        '
        Me.radioPS.AutoSize = True
        Me.radioPS.Location = New System.Drawing.Point(6, 50)
        Me.radioPS.Name = "radioPS"
        Me.radioPS.Size = New System.Drawing.Size(76, 17)
        Me.radioPS.TabIndex = 2
        Me.radioPS.TabStop = True
        Me.radioPS.Text = "Powershell"
        Me.radioPS.UseVisualStyleBackColor = True
        '
        'radioJS
        '
        Me.radioJS.AutoSize = True
        Me.radioJS.Location = New System.Drawing.Point(6, 30)
        Me.radioJS.Name = "radioJS"
        Me.radioJS.Size = New System.Drawing.Size(73, 17)
        Me.radioJS.TabIndex = 1
        Me.radioJS.TabStop = True
        Me.radioJS.Text = "Javascript"
        Me.radioJS.UseVisualStyleBackColor = True
        '
        'SaveLocLabel
        '
        Me.SaveLocLabel.AutoSize = True
        Me.SaveLocLabel.Location = New System.Drawing.Point(3, 12)
        Me.SaveLocLabel.Name = "SaveLocLabel"
        Me.SaveLocLabel.Size = New System.Drawing.Size(94, 13)
        Me.SaveLocLabel.TabIndex = 0
        Me.SaveLocLabel.Text = "Download Method"
        '
        'TESTBUTTON
        '
        Me.TESTBUTTON.Enabled = False
        Me.TESTBUTTON.Location = New System.Drawing.Point(347, 215)
        Me.TESTBUTTON.Name = "TESTBUTTON"
        Me.TESTBUTTON.Size = New System.Drawing.Size(92, 23)
        Me.TESTBUTTON.TabIndex = 6
        Me.TESTBUTTON.Text = "Delete Settings"
        Me.TESTBUTTON.UseVisualStyleBackColor = True
        Me.TESTBUTTON.Visible = False
        '
        'buttonDownload
        '
        Me.buttonDownload.Location = New System.Drawing.Point(22, 57)
        Me.buttonDownload.Name = "buttonDownload"
        Me.buttonDownload.Size = New System.Drawing.Size(75, 23)
        Me.buttonDownload.TabIndex = 3
        Me.buttonDownload.Text = "Download"
        Me.buttonDownload.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(239, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Download the latest version of BGET (.zip format)"
        '
        'optionsDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(714, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.GeneralPanel)
        Me.Controls.Add(Me.DirectoryPanel)
        Me.Controls.Add(Me.TESTBUTTON)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.cancelButtonOptions)
        Me.Controls.Add(Me.downloadMethod)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "optionsDialog"
        Me.Text = "Prefrences"
        Me.DirectoryPanel.ResumeLayout(False)
        Me.DirectoryPanel.PerformLayout()
        Me.GeneralPanel.ResumeLayout(False)
        Me.GeneralPanel.PerformLayout()
        Me.downloadMethod.ResumeLayout(False)
        Me.downloadMethod.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cancelButtonOptions As Button
    Friend WithEvents okButton As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DirectoryPanel As Panel
    Friend WithEvents bgetFileButton As Button
    Friend WithEvents BgetLocationTextBox As TextBox
    Friend WithEvents LocLabel As Label
    Friend WithEvents filePicker As OpenFileDialog
    Friend WithEvents GeneralPanel As Panel
    Friend WithEvents downloadMethod As Panel
    Friend WithEvents SaveLocLabel As Label
    Friend WithEvents downFileButton As Button
    Friend WithEvents DownLocationTextbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents folderPicker As FolderBrowserDialog
    Friend WithEvents TESTBUTTON As Button
    Friend WithEvents radioVBS As RadioButton
    Friend WithEvents radioPS As RadioButton
    Friend WithEvents radioJS As RadioButton
    Friend WithEvents radioCurl As RadioButton
    Friend WithEvents radioBits As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents buttonADL As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents buttonDownload As Button
End Class
