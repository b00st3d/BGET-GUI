<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bget
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bget))
        Me.mainWindow = New System.Windows.Forms.Panel()
        Me.ComboBoxLocal = New System.Windows.Forms.ComboBox()
        Me.ComboBoxScripts = New System.Windows.Forms.ComboBox()
        Me.consoleTextBox = New System.Windows.Forms.RichTextBox()
        Me.buttonLocalScripts = New System.Windows.Forms.Button()
        Me.buttonListServer = New System.Windows.Forms.Button()
        Me.methodLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.filePicker = New System.Windows.Forms.OpenFileDialog()
        Me.downLabel = New System.Windows.Forms.Label()
        Me.LocLabel = New System.Windows.Forms.Label()
        Me.locationStatusLabel = New System.Windows.Forms.Label()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonLocal = New System.Windows.Forms.Button()
        Me.buttonPastebin = New System.Windows.Forms.Button()
        Me.ButtonUpdateAll = New System.Windows.Forms.Button()
        Me.bgetImage = New System.Windows.Forms.PictureBox()
        Me.updateLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mainWindow.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.bgetImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainWindow
        '
        Me.mainWindow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainWindow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mainWindow.Controls.Add(Me.ComboBoxLocal)
        Me.mainWindow.Controls.Add(Me.ComboBoxScripts)
        Me.mainWindow.Controls.Add(Me.consoleTextBox)
        Me.mainWindow.Controls.Add(Me.buttonLocalScripts)
        Me.mainWindow.Location = New System.Drawing.Point(106, 25)
        Me.mainWindow.Name = "mainWindow"
        Me.mainWindow.Size = New System.Drawing.Size(667, 532)
        Me.mainWindow.TabIndex = 1
        '
        'ComboBoxLocal
        '
        Me.ComboBoxLocal.FormattingEnabled = True
        Me.ComboBoxLocal.Location = New System.Drawing.Point(3, 488)
        Me.ComboBoxLocal.Name = "ComboBoxLocal"
        Me.ComboBoxLocal.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxLocal.TabIndex = 4
        Me.ComboBoxLocal.Text = "Local Scripts"
        '
        'ComboBoxScripts
        '
        Me.ComboBoxScripts.FormattingEnabled = True
        Me.ComboBoxScripts.Location = New System.Drawing.Point(539, 488)
        Me.ComboBoxScripts.Name = "ComboBoxScripts"
        Me.ComboBoxScripts.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxScripts.TabIndex = 3
        Me.ComboBoxScripts.Text = "Server Scripts"
        '
        'consoleTextBox
        '
        Me.consoleTextBox.DetectUrls = False
        Me.consoleTextBox.Location = New System.Drawing.Point(3, 3)
        Me.consoleTextBox.Name = "consoleTextBox"
        Me.consoleTextBox.ReadOnly = True
        Me.consoleTextBox.Size = New System.Drawing.Size(657, 483)
        Me.consoleTextBox.TabIndex = 0
        Me.consoleTextBox.Text = ""
        '
        'buttonLocalScripts
        '
        Me.buttonLocalScripts.Location = New System.Drawing.Point(2, 511)
        Me.buttonLocalScripts.Name = "buttonLocalScripts"
        Me.buttonLocalScripts.Size = New System.Drawing.Size(122, 23)
        Me.buttonLocalScripts.TabIndex = 1
        Me.buttonLocalScripts.Text = "Reload Local Scripts"
        Me.buttonLocalScripts.UseVisualStyleBackColor = True
        '
        'buttonListServer
        '
        Me.buttonListServer.Location = New System.Drawing.Point(645, 536)
        Me.buttonListServer.Name = "buttonListServer"
        Me.buttonListServer.Size = New System.Drawing.Size(121, 23)
        Me.buttonListServer.TabIndex = 2
        Me.buttonListServer.Text = "Reload Server Scripts"
        Me.buttonListServer.UseVisualStyleBackColor = True
        '
        'methodLabel
        '
        Me.methodLabel.Location = New System.Drawing.Point(3, 144)
        Me.methodLabel.Name = "methodLabel"
        Me.methodLabel.Size = New System.Drawing.Size(100, 13)
        Me.methodLabel.TabIndex = 2
        Me.methodLabel.Text = "Method"
        Me.methodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearSettingsToolStripMenuItem, Me.PreferencesToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ClearSettingsToolStripMenuItem
        '
        Me.ClearSettingsToolStripMenuItem.Name = "ClearSettingsToolStripMenuItem"
        Me.ClearSettingsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ClearSettingsToolStripMenuItem.Text = "Clear Settings"
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.PreferencesToolStripMenuItem.Text = "Preferences"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocumentationToolStripMenuItem, Me.AboutToolStripMenuItem, Me.CheckForUpdatesToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'DocumentationToolStripMenuItem
        '
        Me.DocumentationToolStripMenuItem.Name = "DocumentationToolStripMenuItem"
        Me.DocumentationToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.DocumentationToolStripMenuItem.Text = "Documentation"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for Updates"
        '
        'filePicker
        '
        Me.filePicker.FileName = "Bget.bat"
        '
        'downLabel
        '
        Me.downLabel.Location = New System.Drawing.Point(3, 131)
        Me.downLabel.Name = "downLabel"
        Me.downLabel.Size = New System.Drawing.Size(100, 13)
        Me.downLabel.TabIndex = 7
        Me.downLabel.Text = "Download Method:"
        Me.downLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LocLabel
        '
        Me.LocLabel.Location = New System.Drawing.Point(3, 179)
        Me.LocLabel.Name = "LocLabel"
        Me.LocLabel.Size = New System.Drawing.Size(100, 13)
        Me.LocLabel.TabIndex = 8
        Me.LocLabel.Text = "Location Set"
        Me.LocLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'locationStatusLabel
        '
        Me.locationStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.locationStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.locationStatusLabel.Location = New System.Drawing.Point(3, 192)
        Me.locationStatusLabel.Name = "locationStatusLabel"
        Me.locationStatusLabel.Size = New System.Drawing.Size(100, 13)
        Me.locationStatusLabel.TabIndex = 9
        Me.locationStatusLabel.Text = "No"
        Me.locationStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonLocal
        '
        Me.ButtonLocal.Location = New System.Drawing.Point(2, 214)
        Me.ButtonLocal.Name = "ButtonLocal"
        Me.ButtonLocal.Size = New System.Drawing.Size(103, 35)
        Me.ButtonLocal.TabIndex = 11
        Me.ButtonLocal.Text = "Open Scripts" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Folder"
        Me.ButtonLocal.UseVisualStyleBackColor = True
        '
        'buttonPastebin
        '
        Me.buttonPastebin.Location = New System.Drawing.Point(545, 536)
        Me.buttonPastebin.Name = "buttonPastebin"
        Me.buttonPastebin.Size = New System.Drawing.Size(93, 23)
        Me.buttonPastebin.TabIndex = 4
        Me.buttonPastebin.Text = "Pastebin"
        Me.buttonPastebin.UseVisualStyleBackColor = True
        '
        'ButtonUpdateAll
        '
        Me.ButtonUpdateAll.Location = New System.Drawing.Point(2, 523)
        Me.ButtonUpdateAll.Name = "ButtonUpdateAll"
        Me.ButtonUpdateAll.Size = New System.Drawing.Size(103, 35)
        Me.ButtonUpdateAll.TabIndex = 12
        Me.ButtonUpdateAll.Text = "Update Local Scripts"
        Me.ButtonUpdateAll.UseVisualStyleBackColor = True
        '
        'bgetImage
        '
        Me.bgetImage.Image = Global.Bget.My.Resources.Resources.bget
        Me.bgetImage.Location = New System.Drawing.Point(0, 27)
        Me.bgetImage.Name = "bgetImage"
        Me.bgetImage.Size = New System.Drawing.Size(100, 101)
        Me.bgetImage.TabIndex = 0
        Me.bgetImage.TabStop = False
        '
        'updateLabel
        '
        Me.updateLabel.AutoSize = True
        Me.updateLabel.Location = New System.Drawing.Point(348, 546)
        Me.updateLabel.Name = "updateLabel"
        Me.updateLabel.Size = New System.Drawing.Size(0, 13)
        Me.updateLabel.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 371)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.updateLabel)
        Me.Controls.Add(Me.ButtonUpdateAll)
        Me.Controls.Add(Me.ButtonLocal)
        Me.Controls.Add(Me.buttonPastebin)
        Me.Controls.Add(Me.buttonListServer)
        Me.Controls.Add(Me.locationStatusLabel)
        Me.Controls.Add(Me.LocLabel)
        Me.Controls.Add(Me.downLabel)
        Me.Controls.Add(Me.methodLabel)
        Me.Controls.Add(Me.mainWindow)
        Me.Controls.Add(Me.bgetImage)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(500, 400)
        Me.Name = "bget"
        Me.Text = "Bget"
        Me.mainWindow.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.bgetImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bgetImage As PictureBox
    Friend WithEvents mainWindow As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents consoleTextBox As RichTextBox
    Friend WithEvents PreferencesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents filePicker As OpenFileDialog
    Friend WithEvents methodLabel As Label
    Friend WithEvents downLabel As Label
    Friend WithEvents LocLabel As Label
    Friend WithEvents locationStatusLabel As Label
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents buttonLocalScripts As Button
    Friend WithEvents buttonListServer As Button
    Friend WithEvents ComboBoxScripts As ComboBox
    Friend WithEvents ButtonLocal As Button
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents buttonPastebin As Button
    Friend WithEvents ComboBoxLocal As ComboBox
    Friend WithEvents ButtonUpdateAll As Button
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents updateLabel As Label
    Friend WithEvents ClearSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
End Class
