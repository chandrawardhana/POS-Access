<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.PanelBar = New System.Windows.Forms.Panel()
        Me.ToggleSwitch1 = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SlideRight = New FontAwesome.Sharp.IconButton()
        Me.SlideLeft = New FontAwesome.Sharp.IconButton()
        Me.btnNotif = New FontAwesome.Sharp.IconButton()
        Me.btnAdmin = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.btnMinimeze = New FontAwesome.Sharp.IconButton()
        Me.btnRestore = New FontAwesome.Sharp.IconButton()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnLogout = New FontAwesome.Sharp.IconButton()
        Me.btnAminstrator = New FontAwesome.Sharp.IconButton()
        Me.btnLaporan = New FontAwesome.Sharp.IconButton()
        Me.btnTransaksi = New FontAwesome.Sharp.IconButton()
        Me.btnProdak = New FontAwesome.Sharp.IconButton()
        Me.btnHome = New FontAwesome.Sharp.IconButton()
        Me.PanelBody = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelBar.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.PanelBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBar
        '
        Me.PanelBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.PanelBar.Controls.Add(Me.ToggleSwitch1)
        Me.PanelBar.Controls.Add(Me.IconButton1)
        Me.PanelBar.Controls.Add(Me.Label2)
        Me.PanelBar.Controls.Add(Me.Label1)
        Me.PanelBar.Controls.Add(Me.SlideRight)
        Me.PanelBar.Controls.Add(Me.SlideLeft)
        Me.PanelBar.Controls.Add(Me.btnNotif)
        Me.PanelBar.Controls.Add(Me.btnAdmin)
        Me.PanelBar.Controls.Add(Me.btnMinimeze)
        Me.PanelBar.Controls.Add(Me.btnRestore)
        Me.PanelBar.Controls.Add(Me.btnClose)
        Me.PanelBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelBar.Name = "PanelBar"
        Me.PanelBar.Size = New System.Drawing.Size(1121, 45)
        Me.PanelBar.TabIndex = 1
        '
        'ToggleSwitch1
        '
        Me.ToggleSwitch1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White
        Me.ToggleSwitch1.CheckedState.Parent = Me.ToggleSwitch1
        Me.ToggleSwitch1.Location = New System.Drawing.Point(767, 12)
        Me.ToggleSwitch1.Name = "ToggleSwitch1"
        Me.ToggleSwitch1.ShadowDecoration.Parent = Me.ToggleSwitch1
        Me.ToggleSwitch1.Size = New System.Drawing.Size(33, 18)
        Me.ToggleSwitch1.TabIndex = 12
        Me.ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.ToggleSwitch1.UncheckedState.Parent = Me.ToggleSwitch1
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 23
        Me.IconButton1.Location = New System.Drawing.Point(685, 3)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.IconButton1.Size = New System.Drawing.Size(35, 38)
        Me.IconButton1.TabIndex = 11
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(854, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Admin"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(834, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "CWardhana"
        '
        'SlideRight
        '
        Me.SlideRight.Dock = System.Windows.Forms.DockStyle.Left
        Me.SlideRight.FlatAppearance.BorderSize = 0
        Me.SlideRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SlideRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SlideRight.IconChar = FontAwesome.Sharp.IconChar.ChevronRight
        Me.SlideRight.IconColor = System.Drawing.Color.White
        Me.SlideRight.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SlideRight.IconSize = 23
        Me.SlideRight.Location = New System.Drawing.Point(35, 0)
        Me.SlideRight.Name = "SlideRight"
        Me.SlideRight.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.SlideRight.Size = New System.Drawing.Size(35, 45)
        Me.SlideRight.TabIndex = 8
        Me.SlideRight.UseVisualStyleBackColor = True
        '
        'SlideLeft
        '
        Me.SlideLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.SlideLeft.FlatAppearance.BorderSize = 0
        Me.SlideLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SlideLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SlideLeft.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft
        Me.SlideLeft.IconColor = System.Drawing.Color.White
        Me.SlideLeft.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SlideLeft.IconSize = 23
        Me.SlideLeft.Location = New System.Drawing.Point(0, 0)
        Me.SlideLeft.Name = "SlideLeft"
        Me.SlideLeft.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.SlideLeft.Size = New System.Drawing.Size(35, 45)
        Me.SlideLeft.TabIndex = 7
        Me.SlideLeft.UseVisualStyleBackColor = True
        '
        'btnNotif
        '
        Me.btnNotif.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNotif.FlatAppearance.BorderSize = 0
        Me.btnNotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotif.IconChar = FontAwesome.Sharp.IconChar.Bell
        Me.btnNotif.IconColor = System.Drawing.Color.White
        Me.btnNotif.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnNotif.IconSize = 23
        Me.btnNotif.Location = New System.Drawing.Point(726, 3)
        Me.btnNotif.Name = "btnNotif"
        Me.btnNotif.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.btnNotif.Size = New System.Drawing.Size(35, 38)
        Me.btnNotif.TabIndex = 6
        Me.btnNotif.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdmin.CheckedState.Parent = Me.btnAdmin
        Me.btnAdmin.CustomImages.Parent = Me.btnAdmin
        Me.btnAdmin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdmin.ForeColor = System.Drawing.Color.White
        Me.btnAdmin.HoverState.Parent = Me.btnAdmin
        Me.btnAdmin.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnAdmin.Location = New System.Drawing.Point(913, 4)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnAdmin.ShadowDecoration.Parent = Me.btnAdmin
        Me.btnAdmin.Size = New System.Drawing.Size(33, 33)
        Me.btnAdmin.TabIndex = 5
        '
        'btnMinimeze
        '
        Me.btnMinimeze.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimeze.FlatAppearance.BorderSize = 0
        Me.btnMinimeze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMinimeze.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimeze.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.btnMinimeze.IconColor = System.Drawing.Color.White
        Me.btnMinimeze.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMinimeze.IconSize = 25
        Me.btnMinimeze.Location = New System.Drawing.Point(1001, 4)
        Me.btnMinimeze.Name = "btnMinimeze"
        Me.btnMinimeze.Size = New System.Drawing.Size(35, 38)
        Me.btnMinimeze.TabIndex = 4
        Me.btnMinimeze.UseVisualStyleBackColor = True
        '
        'btnRestore
        '
        Me.btnRestore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestore.FlatAppearance.BorderSize = 0
        Me.btnRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestore.IconChar = FontAwesome.Sharp.IconChar.WindowRestore
        Me.btnRestore.IconColor = System.Drawing.Color.White
        Me.btnRestore.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRestore.IconSize = 25
        Me.btnRestore.Location = New System.Drawing.Point(1042, 4)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(35, 38)
        Me.btnRestore.TabIndex = 3
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnClose.IconColor = System.Drawing.Color.White
        Me.btnClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClose.IconSize = 25
        Me.btnClose.Location = New System.Drawing.Point(1083, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(35, 38)
        Me.btnClose.TabIndex = 2
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnLogout)
        Me.PanelMenu.Controls.Add(Me.btnAminstrator)
        Me.PanelMenu.Controls.Add(Me.btnLaporan)
        Me.PanelMenu.Controls.Add(Me.btnTransaksi)
        Me.PanelMenu.Controls.Add(Me.btnProdak)
        Me.PanelMenu.Controls.Add(Me.btnHome)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 45)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(60, 529)
        Me.PanelMenu.TabIndex = 2
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Silver
        Me.btnLogout.IconChar = FontAwesome.Sharp.IconChar.LowVision
        Me.btnLogout.IconColor = System.Drawing.Color.LightGray
        Me.btnLogout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogout.IconSize = 26
        Me.btnLogout.Location = New System.Drawing.Point(0, 475)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(60, 54)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnAminstrator
        '
        Me.btnAminstrator.BackColor = System.Drawing.Color.Transparent
        Me.btnAminstrator.FlatAppearance.BorderSize = 0
        Me.btnAminstrator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAminstrator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAminstrator.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAminstrator.ForeColor = System.Drawing.Color.Silver
        Me.btnAminstrator.IconChar = FontAwesome.Sharp.IconChar.Key
        Me.btnAminstrator.IconColor = System.Drawing.Color.LightGray
        Me.btnAminstrator.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAminstrator.IconSize = 26
        Me.btnAminstrator.Location = New System.Drawing.Point(0, 248)
        Me.btnAminstrator.Name = "btnAminstrator"
        Me.btnAminstrator.Size = New System.Drawing.Size(57, 54)
        Me.btnAminstrator.TabIndex = 6
        Me.btnAminstrator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAminstrator.UseVisualStyleBackColor = False
        '
        'btnLaporan
        '
        Me.btnLaporan.BackColor = System.Drawing.Color.Transparent
        Me.btnLaporan.FlatAppearance.BorderSize = 0
        Me.btnLaporan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaporan.ForeColor = System.Drawing.Color.Silver
        Me.btnLaporan.IconChar = FontAwesome.Sharp.IconChar.Receipt
        Me.btnLaporan.IconColor = System.Drawing.Color.LightGray
        Me.btnLaporan.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLaporan.IconSize = 26
        Me.btnLaporan.Location = New System.Drawing.Point(0, 195)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(57, 54)
        Me.btnLaporan.TabIndex = 5
        Me.btnLaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLaporan.UseVisualStyleBackColor = False
        '
        'btnTransaksi
        '
        Me.btnTransaksi.BackColor = System.Drawing.Color.Transparent
        Me.btnTransaksi.FlatAppearance.BorderSize = 0
        Me.btnTransaksi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaksi.ForeColor = System.Drawing.Color.Silver
        Me.btnTransaksi.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.btnTransaksi.IconColor = System.Drawing.Color.LightGray
        Me.btnTransaksi.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTransaksi.IconSize = 26
        Me.btnTransaksi.Location = New System.Drawing.Point(0, 135)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Size = New System.Drawing.Size(57, 54)
        Me.btnTransaksi.TabIndex = 4
        Me.btnTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTransaksi.UseVisualStyleBackColor = False
        '
        'btnProdak
        '
        Me.btnProdak.BackColor = System.Drawing.Color.Transparent
        Me.btnProdak.FlatAppearance.BorderSize = 0
        Me.btnProdak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnProdak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProdak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProdak.ForeColor = System.Drawing.Color.Silver
        Me.btnProdak.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag
        Me.btnProdak.IconColor = System.Drawing.Color.LightGray
        Me.btnProdak.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnProdak.IconSize = 26
        Me.btnProdak.Location = New System.Drawing.Point(0, 75)
        Me.btnProdak.Name = "btnProdak"
        Me.btnProdak.Size = New System.Drawing.Size(57, 54)
        Me.btnProdak.TabIndex = 3
        Me.btnProdak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnProdak.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.Silver
        Me.btnHome.IconChar = FontAwesome.Sharp.IconChar.HouseUser
        Me.btnHome.IconColor = System.Drawing.Color.LightGray
        Me.btnHome.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHome.IconSize = 26
        Me.btnHome.Location = New System.Drawing.Point(0, 15)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(57, 54)
        Me.btnHome.TabIndex = 2
        Me.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'PanelBody
        '
        Me.PanelBody.Controls.Add(Me.Panel1)
        Me.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBody.Location = New System.Drawing.Point(60, 45)
        Me.PanelBody.Name = "PanelBody"
        Me.PanelBody.Size = New System.Drawing.Size(1061, 529)
        Me.PanelBody.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1061, 529)
        Me.Panel1.TabIndex = 3
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 574)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelBody)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMenu"
        Me.Opacity = 0.96R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelBar.ResumeLayout(False)
        Me.PanelBar.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelBody.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBar As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SlideRight As FontAwesome.Sharp.IconButton
    Friend WithEvents SlideLeft As FontAwesome.Sharp.IconButton
    Friend WithEvents btnNotif As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAdmin As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents btnMinimeze As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRestore As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnLogout As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAminstrator As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLaporan As FontAwesome.Sharp.IconButton
    Friend WithEvents btnTransaksi As FontAwesome.Sharp.IconButton
    Friend WithEvents btnProdak As FontAwesome.Sharp.IconButton
    Friend WithEvents btnHome As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelBody As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToggleSwitch1 As Guna.UI2.WinForms.Guna2ToggleSwitch
End Class
