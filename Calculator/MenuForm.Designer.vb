<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuForm))
        MenuStrip2 = New MenuStrip()
        menuFile = New ToolStripMenuItem()
        menuitemNew = New ToolStripMenuItem()
        menuitemSave = New ToolStripMenuItem()
        menuitemPrint = New ToolStripMenuItem()
        menuitemExit = New ToolStripMenuItem()
        menuEdit = New ToolStripMenuItem()
        menuitemCut = New ToolStripMenuItem()
        menuitemCopy = New ToolStripMenuItem()
        menuitemPaste = New ToolStripMenuItem()
        menuitemSelectAll = New ToolStripMenuItem()
        menuHelp = New ToolStripMenuItem()
        menuitemUserGuide = New ToolStripMenuItem()
        menuitemAbout = New ToolStripMenuItem()
        menuitemUpdates = New ToolStripMenuItem()
        CalculatorToolStripMenuItem = New ToolStripMenuItem()
        labelWelcome = New Label()
        panelSideMenu = New Panel()
        picCalcu = New PictureBox()
        btnOpen = New Button()
        picLogout = New PictureBox()
        btnLogout = New Button()
        MenuStrip2.SuspendLayout()
        CType(picCalcu, ComponentModel.ISupportInitialize).BeginInit()
        CType(picLogout, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.BackgroundImageLayout = ImageLayout.Stretch
        MenuStrip2.ImageScalingSize = New Size(24, 24)
        MenuStrip2.Items.AddRange(New ToolStripItem() {menuFile, menuEdit, menuHelp, CalculatorToolStripMenuItem})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(800, 33)
        MenuStrip2.TabIndex = 1
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' menuFile
        ' 
        menuFile.DropDownItems.AddRange(New ToolStripItem() {menuitemNew, menuitemSave, menuitemPrint, menuitemExit})
        menuFile.Name = "menuFile"
        menuFile.ShortcutKeys = Keys.Alt Or Keys.F
        menuFile.Size = New Size(54, 29)
        menuFile.Text = "File"
        ' 
        ' menuitemNew
        ' 
        menuitemNew.Name = "menuitemNew"
        menuitemNew.ShortcutKeys = Keys.Control Or Keys.N
        menuitemNew.Size = New Size(270, 34)
        menuitemNew.Text = "New"
        ' 
        ' menuitemSave
        ' 
        menuitemSave.Name = "menuitemSave"
        menuitemSave.ShortcutKeys = Keys.Control Or Keys.S
        menuitemSave.Size = New Size(270, 34)
        menuitemSave.Text = "Save"
        ' 
        ' menuitemPrint
        ' 
        menuitemPrint.Name = "menuitemPrint"
        menuitemPrint.ShortcutKeys = Keys.Control Or Keys.P
        menuitemPrint.Size = New Size(270, 34)
        menuitemPrint.Text = "Print"
        ' 
        ' menuitemExit
        ' 
        menuitemExit.Name = "menuitemExit"
        menuitemExit.ShortcutKeys = Keys.Alt Or Keys.F4
        menuitemExit.Size = New Size(270, 34)
        menuitemExit.Text = "Exit"
        ' 
        ' menuEdit
        ' 
        menuEdit.DropDownItems.AddRange(New ToolStripItem() {menuitemCut, menuitemCopy, menuitemPaste, menuitemSelectAll})
        menuEdit.Name = "menuEdit"
        menuEdit.ShortcutKeys = Keys.Control Or Keys.E
        menuEdit.Size = New Size(58, 29)
        menuEdit.Text = "Edit"
        ' 
        ' menuitemCut
        ' 
        menuitemCut.Name = "menuitemCut"
        menuitemCut.ShortcutKeys = Keys.Control Or Keys.X
        menuitemCut.Size = New Size(270, 34)
        menuitemCut.Text = "Cut"
        ' 
        ' menuitemCopy
        ' 
        menuitemCopy.Name = "menuitemCopy"
        menuitemCopy.ShortcutKeys = Keys.Control Or Keys.C
        menuitemCopy.Size = New Size(270, 34)
        menuitemCopy.Text = "Copy"
        ' 
        ' menuitemPaste
        ' 
        menuitemPaste.Name = "menuitemPaste"
        menuitemPaste.ShortcutKeys = Keys.Control Or Keys.V
        menuitemPaste.Size = New Size(270, 34)
        menuitemPaste.Text = "Paste"
        ' 
        ' menuitemSelectAll
        ' 
        menuitemSelectAll.Name = "menuitemSelectAll"
        menuitemSelectAll.ShortcutKeys = Keys.Control Or Keys.A
        menuitemSelectAll.Size = New Size(270, 34)
        menuitemSelectAll.Text = "Select All"
        ' 
        ' menuHelp
        ' 
        menuHelp.DropDownItems.AddRange(New ToolStripItem() {menuitemUserGuide, menuitemAbout, menuitemUpdates})
        menuHelp.Name = "menuHelp"
        menuHelp.ShortcutKeys = Keys.Control Or Keys.H
        menuHelp.Size = New Size(65, 29)
        menuHelp.Text = "Help"
        ' 
        ' menuitemUserGuide
        ' 
        menuitemUserGuide.Name = "menuitemUserGuide"
        menuitemUserGuide.Size = New Size(270, 34)
        menuitemUserGuide.Text = "User Guide"
        ' 
        ' menuitemAbout
        ' 
        menuitemAbout.Name = "menuitemAbout"
        menuitemAbout.Size = New Size(270, 34)
        menuitemAbout.Text = "About"
        ' 
        ' menuitemUpdates
        ' 
        menuitemUpdates.Name = "menuitemUpdates"
        menuitemUpdates.Size = New Size(270, 34)
        menuitemUpdates.Text = "Check for Updates"
        ' 
        ' CalculatorToolStripMenuItem
        ' 
        CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        CalculatorToolStripMenuItem.Size = New Size(106, 29)
        CalculatorToolStripMenuItem.Text = "Calculator"
        ' 
        ' labelWelcome
        ' 
        labelWelcome.AutoSize = True
        labelWelcome.BackColor = SystemColors.ScrollBar
        labelWelcome.Font = New Font("Tahoma", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelWelcome.ForeColor = SystemColors.ActiveCaptionText
        labelWelcome.Location = New Point(386, 57)
        labelWelcome.Name = "labelWelcome"
        labelWelcome.Size = New Size(219, 48)
        labelWelcome.TabIndex = 10
        labelWelcome.Text = "Welcome!"
        ' 
        ' panelSideMenu
        ' 
        panelSideMenu.BackColor = Color.FromArgb(CByte(71), CByte(73), CByte(115))
        panelSideMenu.Location = New Point(0, 36)
        panelSideMenu.Name = "panelSideMenu"
        panelSideMenu.Size = New Size(199, 426)
        panelSideMenu.TabIndex = 11
        ' 
        ' picCalcu
        ' 
        picCalcu.Image = My.Resources.Resources.accounting1
        picCalcu.Location = New Point(282, 145)
        picCalcu.Name = "picCalcu"
        picCalcu.Size = New Size(205, 146)
        picCalcu.SizeMode = PictureBoxSizeMode.Zoom
        picCalcu.TabIndex = 12
        picCalcu.TabStop = False
        ' 
        ' btnOpen
        ' 
        btnOpen.BackColor = SystemColors.ActiveCaption
        btnOpen.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnOpen.ForeColor = SystemColors.ActiveCaptionText
        btnOpen.Location = New Point(324, 309)
        btnOpen.Name = "btnOpen"
        btnOpen.Size = New Size(135, 60)
        btnOpen.TabIndex = 13
        btnOpen.Text = "Open Calculator"
        btnOpen.UseVisualStyleBackColor = False
        ' 
        ' picLogout
        ' 
        picLogout.Image = CType(resources.GetObject("picLogout.Image"), Image)
        picLogout.Location = New Point(523, 145)
        picLogout.Name = "picLogout"
        picLogout.Size = New Size(205, 146)
        picLogout.SizeMode = PictureBoxSizeMode.Zoom
        picLogout.TabIndex = 14
        picLogout.TabStop = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(255), CByte(71), CByte(76))
        btnLogout.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.Location = New Point(556, 310)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(135, 60)
        btnLogout.TabIndex = 15
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' MenuForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(800, 450)
        Controls.Add(btnLogout)
        Controls.Add(picLogout)
        Controls.Add(btnOpen)
        Controls.Add(picCalcu)
        Controls.Add(labelWelcome)
        Controls.Add(panelSideMenu)
        Controls.Add(MenuStrip2)
        Name = "MenuForm"
        Text = "MenuForm"
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        CType(picCalcu, ComponentModel.ISupportInitialize).EndInit()
        CType(picLogout, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents menuFile As ToolStripMenuItem
    Friend WithEvents menuEdit As ToolStripMenuItem
    Friend WithEvents menuHelp As ToolStripMenuItem
    Friend WithEvents menuitemExit As ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuitemCopy As ToolStripMenuItem
    Friend WithEvents menuitemPaste As ToolStripMenuItem
    Friend WithEvents labelWelcome As Label
    Friend WithEvents panelSideMenu As Panel
    Friend WithEvents picCalcu As PictureBox
    Friend WithEvents btnOpen As Button
    Friend WithEvents picLogout As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents menuitemUserGuide As ToolStripMenuItem
    Friend WithEvents menuitemAbout As ToolStripMenuItem
    Friend WithEvents menuitemNew As ToolStripMenuItem
    Friend WithEvents menuitemUpdates As ToolStripMenuItem
    Friend WithEvents menuitemPrint As ToolStripMenuItem
    Friend WithEvents menuitemCut As ToolStripMenuItem
    Friend WithEvents menuitemSelectAll As ToolStripMenuItem
    Friend WithEvents menuitemSave As ToolStripMenuItem
End Class
