<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelaodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScanModToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScanAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ModID = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ModName = New System.Windows.Forms.ToolStripTextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Status2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusSplit = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CreationDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabCreatures = New System.Windows.Forms.TabPage()
        Me.Creatures = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabEngrams = New System.Windows.Forms.TabPage()
        Me.Engrams = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabItems = New System.Windows.Forms.TabPage()
        Me.Items = New System.Windows.Forms.DataGridView()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabMapSpawns = New System.Windows.Forms.TabPage()
        Me.MapSpawns = New System.Windows.Forms.DataGridView()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabCrates = New System.Windows.Forms.TabPage()
        Me.SupplyCrates = New System.Windows.Forms.DataGridView()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabInventories = New System.Windows.Forms.TabPage()
        Me.Inventories = New System.Windows.Forms.DataGridView()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabGameMaps = New System.Windows.Forms.TabPage()
        Me.GameMaps = New System.Windows.Forms.DataGridView()
        Me.Column21 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabCreatures.SuspendLayout()
        CType(Me.Creatures, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabEngrams.SuspendLayout()
        CType(Me.Engrams, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabItems.SuspendLayout()
        CType(Me.Items, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMapSpawns.SuspendLayout()
        CType(Me.MapSpawns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCrates.SuspendLayout()
        CType(Me.SupplyCrates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabInventories.SuspendLayout()
        CType(Me.Inventories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabGameMaps.SuspendLayout()
        CType(Me.GameMaps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem1, Me.SaveToolStripMenuItem, Me.RelaodToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.OpenToolStripMenuItem.Text = "Open.."
        '
        'SaveToolStripMenuItem1
        '
        Me.SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1"
        Me.SaveToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem1.Size = New System.Drawing.Size(190, 22)
        Me.SaveToolStripMenuItem1.Text = "Save"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.SaveToolStripMenuItem.Text = "Save as.."
        '
        'RelaodToolStripMenuItem
        '
        Me.RelaodToolStripMenuItem.Name = "RelaodToolStripMenuItem"
        Me.RelaodToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RelaodToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.RelaodToolStripMenuItem.Text = "Relaod"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScanModToolStripMenuItem, Me.ScanToolStripMenuItem, Me.ScanAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.EditToolStripMenuItem.Text = "Options"
        '
        'ScanModToolStripMenuItem
        '
        Me.ScanModToolStripMenuItem.Name = "ScanModToolStripMenuItem"
        Me.ScanModToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ScanModToolStripMenuItem.Text = "Scan Folder.."
        '
        'ScanToolStripMenuItem
        '
        Me.ScanToolStripMenuItem.Name = "ScanToolStripMenuItem"
        Me.ScanToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ScanToolStripMenuItem.Text = "Scan Mod.."
        '
        'ScanAllToolStripMenuItem
        '
        Me.ScanAllToolStripMenuItem.Name = "ScanAllToolStripMenuItem"
        Me.ScanAllToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ScanAllToolStripMenuItem.Text = "Scan All.."
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator1, Me.ToolStripButton4, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripSeparator3, Me.ToolStripLabel1, Me.ModID, Me.ToolStripLabel2, Me.ModName})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "New"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Open"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Reload file"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Scan Mod Folder"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripLabel1.Text = "MOD ID:"
        '
        'ModID
        '
        Me.ModID.Name = "ModID"
        Me.ModID.ReadOnly = True
        Me.ModID.Size = New System.Drawing.Size(150, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripLabel2.Text = "Mod Name:"
        '
        'ModName
        '
        Me.ModName.Name = "ModName"
        Me.ModName.Size = New System.Drawing.Size(250, 25)
        Me.ModName.Text = "Def"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status, Me.Status2, Me.ToolStripStatusSplit, Me.ToolStripStatusLabel2, Me.CreationDate})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Status
        '
        Me.Status.AutoSize = False
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(150, 17)
        Me.Status.Text = "Ready"
        Me.Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Status2
        '
        Me.Status2.Name = "Status2"
        Me.Status2.Size = New System.Drawing.Size(121, 17)
        Me.Status2.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusSplit
        '
        Me.ToolStripStatusSplit.Name = "ToolStripStatusSplit"
        Me.ToolStripStatusSplit.Size = New System.Drawing.Size(283, 17)
        Me.ToolStripStatusSplit.Spring = True
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(51, 17)
        Me.ToolStripStatusLabel2.Text = "Created:"
        '
        'CreationDate
        '
        Me.CreationDate.AutoSize = False
        Me.CreationDate.Name = "CreationDate"
        Me.CreationDate.Size = New System.Drawing.Size(180, 17)
        Me.CreationDate.Text = "date"
        Me.CreationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabCreatures)
        Me.TabControl1.Controls.Add(Me.TabEngrams)
        Me.TabControl1.Controls.Add(Me.TabItems)
        Me.TabControl1.Controls.Add(Me.TabMapSpawns)
        Me.TabControl1.Controls.Add(Me.TabCrates)
        Me.TabControl1.Controls.Add(Me.TabInventories)
        Me.TabControl1.Controls.Add(Me.TabGameMaps)
        Me.TabControl1.Location = New System.Drawing.Point(12, 52)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(733, 373)
        Me.TabControl1.TabIndex = 3
        '
        'TabCreatures
        '
        Me.TabCreatures.Controls.Add(Me.Creatures)
        Me.TabCreatures.Location = New System.Drawing.Point(4, 22)
        Me.TabCreatures.Name = "TabCreatures"
        Me.TabCreatures.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCreatures.Size = New System.Drawing.Size(725, 347)
        Me.TabCreatures.TabIndex = 0
        Me.TabCreatures.Text = "Creatures"
        Me.TabCreatures.UseVisualStyleBackColor = True
        '
        'Creatures
        '
        Me.Creatures.AllowUserToAddRows = False
        Me.Creatures.AllowUserToResizeRows = False
        Me.Creatures.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Creatures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Creatures.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.Creatures.Location = New System.Drawing.Point(6, 6)
        Me.Creatures.Name = "Creatures"
        Me.Creatures.Size = New System.Drawing.Size(713, 335)
        Me.Creatures.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "NameTag"
        Me.Column1.MinimumWidth = 30
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "IsSpawnable"
        Me.Column2.MinimumWidth = 30
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 80
        '
        'Column3
        '
        Me.Column3.HeaderText = "IsTameable"
        Me.Column3.MinimumWidth = 30
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.Width = 80
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "ClassName"
        Me.Column4.MinimumWidth = 30
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 85
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Description"
        Me.Column5.MinimumWidth = 30
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 85
        '
        'TabEngrams
        '
        Me.TabEngrams.Controls.Add(Me.Engrams)
        Me.TabEngrams.Location = New System.Drawing.Point(4, 22)
        Me.TabEngrams.Name = "TabEngrams"
        Me.TabEngrams.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEngrams.Size = New System.Drawing.Size(725, 347)
        Me.TabEngrams.TabIndex = 1
        Me.TabEngrams.Text = "Engrams"
        Me.TabEngrams.UseVisualStyleBackColor = True
        '
        'Engrams
        '
        Me.Engrams.AllowUserToAddRows = False
        Me.Engrams.AllowUserToResizeRows = False
        Me.Engrams.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Engrams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Engrams.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.Engrams.Location = New System.Drawing.Point(6, 6)
        Me.Engrams.Name = "Engrams"
        Me.Engrams.Size = New System.Drawing.Size(713, 335)
        Me.Engrams.TabIndex = 0
        '
        'Column6
        '
        DataGridViewCellStyle1.NullValue = "0"
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column6.HeaderText = "Level"
        Me.Column6.MinimumWidth = 30
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 64
        '
        'Column7
        '
        DataGridViewCellStyle2.NullValue = "0"
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column7.HeaderText = "Points"
        Me.Column7.MinimumWidth = 30
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 64
        '
        'Column8
        '
        Me.Column8.HeaderText = "IsTekGram"
        Me.Column8.MinimumWidth = 30
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 80
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "ClassName"
        Me.Column9.MinimumWidth = 30
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 85
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.HeaderText = "Description"
        Me.Column10.MinimumWidth = 30
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 85
        '
        'TabItems
        '
        Me.TabItems.Controls.Add(Me.Items)
        Me.TabItems.Location = New System.Drawing.Point(4, 22)
        Me.TabItems.Name = "TabItems"
        Me.TabItems.Padding = New System.Windows.Forms.Padding(3)
        Me.TabItems.Size = New System.Drawing.Size(725, 347)
        Me.TabItems.TabIndex = 2
        Me.TabItems.Text = "Items"
        Me.TabItems.UseVisualStyleBackColor = True
        '
        'Items
        '
        Me.Items.AllowUserToAddRows = False
        Me.Items.AllowUserToResizeRows = False
        Me.Items.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Items.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column11, Me.Column12, Me.Column13, Me.Column14})
        Me.Items.Location = New System.Drawing.Point(6, 6)
        Me.Items.Name = "Items"
        Me.Items.Size = New System.Drawing.Size(713, 335)
        Me.Items.TabIndex = 0
        '
        'Column11
        '
        Me.Column11.HeaderText = "Category"
        Me.Column11.MinimumWidth = 30
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 150
        '
        'Column12
        '
        Me.Column12.HeaderText = "IsHarvestable"
        Me.Column12.MinimumWidth = 30
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 80
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column13.HeaderText = "ClassName"
        Me.Column13.MinimumWidth = 30
        Me.Column13.Name = "Column13"
        Me.Column13.Width = 85
        '
        'Column14
        '
        Me.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column14.HeaderText = "Description"
        Me.Column14.MinimumWidth = 30
        Me.Column14.Name = "Column14"
        Me.Column14.Width = 85
        '
        'TabMapSpawns
        '
        Me.TabMapSpawns.Controls.Add(Me.MapSpawns)
        Me.TabMapSpawns.Location = New System.Drawing.Point(4, 22)
        Me.TabMapSpawns.Name = "TabMapSpawns"
        Me.TabMapSpawns.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMapSpawns.Size = New System.Drawing.Size(725, 347)
        Me.TabMapSpawns.TabIndex = 3
        Me.TabMapSpawns.Text = "MapSpawners"
        Me.TabMapSpawns.UseVisualStyleBackColor = True
        '
        'MapSpawns
        '
        Me.MapSpawns.AllowUserToAddRows = False
        Me.MapSpawns.AllowUserToResizeRows = False
        Me.MapSpawns.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MapSpawns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MapSpawns.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column15, Me.Column16})
        Me.MapSpawns.Location = New System.Drawing.Point(6, 6)
        Me.MapSpawns.Name = "MapSpawns"
        Me.MapSpawns.Size = New System.Drawing.Size(713, 335)
        Me.MapSpawns.TabIndex = 0
        '
        'Column15
        '
        Me.Column15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column15.HeaderText = "ClassName"
        Me.Column15.MinimumWidth = 30
        Me.Column15.Name = "Column15"
        Me.Column15.Width = 85
        '
        'Column16
        '
        Me.Column16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column16.HeaderText = "Description"
        Me.Column16.MinimumWidth = 30
        Me.Column16.Name = "Column16"
        Me.Column16.Width = 85
        '
        'TabCrates
        '
        Me.TabCrates.Controls.Add(Me.SupplyCrates)
        Me.TabCrates.Location = New System.Drawing.Point(4, 22)
        Me.TabCrates.Name = "TabCrates"
        Me.TabCrates.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCrates.Size = New System.Drawing.Size(725, 347)
        Me.TabCrates.TabIndex = 4
        Me.TabCrates.Text = "SupplyCrates"
        Me.TabCrates.UseVisualStyleBackColor = True
        '
        'SupplyCrates
        '
        Me.SupplyCrates.AllowUserToAddRows = False
        Me.SupplyCrates.AllowUserToResizeRows = False
        Me.SupplyCrates.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SupplyCrates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SupplyCrates.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column17, Me.Column18})
        Me.SupplyCrates.Location = New System.Drawing.Point(6, 6)
        Me.SupplyCrates.Name = "SupplyCrates"
        Me.SupplyCrates.Size = New System.Drawing.Size(713, 335)
        Me.SupplyCrates.TabIndex = 0
        '
        'Column17
        '
        Me.Column17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column17.HeaderText = "ClassName"
        Me.Column17.MinimumWidth = 30
        Me.Column17.Name = "Column17"
        Me.Column17.Width = 85
        '
        'Column18
        '
        Me.Column18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column18.HeaderText = "Description"
        Me.Column18.MinimumWidth = 30
        Me.Column18.Name = "Column18"
        Me.Column18.Width = 85
        '
        'TabInventories
        '
        Me.TabInventories.Controls.Add(Me.Inventories)
        Me.TabInventories.Location = New System.Drawing.Point(4, 22)
        Me.TabInventories.Name = "TabInventories"
        Me.TabInventories.Padding = New System.Windows.Forms.Padding(3)
        Me.TabInventories.Size = New System.Drawing.Size(725, 347)
        Me.TabInventories.TabIndex = 5
        Me.TabInventories.Text = "Inventories"
        Me.TabInventories.UseVisualStyleBackColor = True
        '
        'Inventories
        '
        Me.Inventories.AllowUserToAddRows = False
        Me.Inventories.AllowUserToResizeRows = False
        Me.Inventories.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Inventories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Inventories.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column19, Me.Column20})
        Me.Inventories.Location = New System.Drawing.Point(6, 6)
        Me.Inventories.Name = "Inventories"
        Me.Inventories.Size = New System.Drawing.Size(713, 335)
        Me.Inventories.TabIndex = 0
        '
        'Column19
        '
        Me.Column19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column19.HeaderText = "ClassName"
        Me.Column19.MinimumWidth = 30
        Me.Column19.Name = "Column19"
        Me.Column19.Width = 85
        '
        'Column20
        '
        Me.Column20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column20.HeaderText = "Description"
        Me.Column20.MinimumWidth = 30
        Me.Column20.Name = "Column20"
        Me.Column20.Width = 85
        '
        'TabGameMaps
        '
        Me.TabGameMaps.Controls.Add(Me.GameMaps)
        Me.TabGameMaps.Location = New System.Drawing.Point(4, 22)
        Me.TabGameMaps.Name = "TabGameMaps"
        Me.TabGameMaps.Padding = New System.Windows.Forms.Padding(3)
        Me.TabGameMaps.Size = New System.Drawing.Size(725, 347)
        Me.TabGameMaps.TabIndex = 6
        Me.TabGameMaps.Text = "GameMaps"
        Me.TabGameMaps.UseVisualStyleBackColor = True
        '
        'GameMaps
        '
        Me.GameMaps.AllowUserToAddRows = False
        Me.GameMaps.AllowUserToResizeRows = False
        Me.GameMaps.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameMaps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GameMaps.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column21, Me.Column22, Me.Column23})
        Me.GameMaps.Location = New System.Drawing.Point(6, 6)
        Me.GameMaps.Name = "GameMaps"
        Me.GameMaps.Size = New System.Drawing.Size(713, 335)
        Me.GameMaps.TabIndex = 0
        '
        'Column21
        '
        Me.Column21.HeaderText = "IsSotF"
        Me.Column21.MinimumWidth = 30
        Me.Column21.Name = "Column21"
        Me.Column21.Width = 80
        '
        'Column22
        '
        Me.Column22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column22.HeaderText = "ClassName"
        Me.Column22.MinimumWidth = 30
        Me.Column22.Name = "Column22"
        Me.Column22.Width = 85
        '
        'Column23
        '
        Me.Column23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column23.HeaderText = "Description"
        Me.Column23.MinimumWidth = 30
        Me.Column23.Name = "Column23"
        Me.Column23.Width = 85
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(751, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 42)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(751, 122)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 42)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(751, 170)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(37, 42)
        Me.Button3.TabIndex = 6
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(751, 218)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(37, 42)
        Me.Button4.TabIndex = 7
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(751, 266)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(37, 42)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "t"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Location = New System.Drawing.Point(751, 314)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(37, 42)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "s"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.Location = New System.Drawing.Point(751, 362)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(37, 42)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "v"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Gamedata file editor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabCreatures.ResumeLayout(False)
        CType(Me.Creatures, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabEngrams.ResumeLayout(False)
        CType(Me.Engrams, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabItems.ResumeLayout(False)
        CType(Me.Items, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMapSpawns.ResumeLayout(False)
        CType(Me.MapSpawns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCrates.ResumeLayout(False)
        CType(Me.SupplyCrates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabInventories.ResumeLayout(False)
        CType(Me.Inventories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabGameMaps.ResumeLayout(False)
        CType(Me.GameMaps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScanModToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScanAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelaodToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Status As ToolStripStatusLabel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabCreatures As TabPage
    Friend WithEvents TabEngrams As TabPage
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ModID As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ModName As ToolStripTextBox
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents CreationDate As ToolStripStatusLabel
    Friend WithEvents TabItems As TabPage
    Friend WithEvents TabMapSpawns As TabPage
    Friend WithEvents TabCrates As TabPage
    Friend WithEvents TabInventories As TabPage
    Friend WithEvents TabGameMaps As TabPage
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Creatures As DataGridView
    Friend WithEvents Engrams As DataGridView
    Friend WithEvents Items As DataGridView
    Friend WithEvents MapSpawns As DataGridView
    Friend WithEvents SupplyCrates As DataGridView
    Friend WithEvents Inventories As DataGridView
    Friend WithEvents GameMaps As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Status2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusSplit As ToolStripStatusLabel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewCheckBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewCheckBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewCheckBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column21 As DataGridViewCheckBoxColumn
    Friend WithEvents Column22 As DataGridViewTextBoxColumn
    Friend WithEvents Column23 As DataGridViewTextBoxColumn
End Class
