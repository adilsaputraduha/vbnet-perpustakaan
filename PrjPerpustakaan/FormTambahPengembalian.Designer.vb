<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahPengembalian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTambahPengembalian))
        Dim DataGridViewCellStyle67 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle68 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle69 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSimpan = New Guna.UI2.WinForms.Guna2Button()
        Me.dgv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnCari = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.qty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.nama = New Guna.UI2.WinForms.Guna2TextBox()
        Me.kode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.stok = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel13 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel15 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel12 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.fakturpinjam = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.akhir = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnTambah = New Guna.UI2.WinForms.Guna2Button()
        Me.id = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel11 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnOk = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.denda = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSimpan
        '
        Me.btnSimpan.BorderRadius = 6
        Me.btnSimpan.CheckedState.Parent = Me.btnSimpan
        Me.btnSimpan.CustomImages.Image = CType(resources.GetObject("btnSimpan.CustomImages.Image"), System.Drawing.Image)
        Me.btnSimpan.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSimpan.CustomImages.ImageOffset = New System.Drawing.Point(14, 0)
        Me.btnSimpan.CustomImages.Parent = Me.btnSimpan
        Me.btnSimpan.FillColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSimpan.Font = New System.Drawing.Font("Futura Bk BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.HoverState.Parent = Me.btnSimpan
        Me.btnSimpan.Location = New System.Drawing.Point(21, 189)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.ShadowDecoration.Parent = Me.btnSimpan
        Me.btnSimpan.Size = New System.Drawing.Size(159, 36)
        Me.btnSimpan.TabIndex = 45
        Me.btnSimpan.Text = "Simpan"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        DataGridViewCellStyle67.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle67
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle68.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle68.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle68.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle68.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle68.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle68.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle68.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle68
        Me.dgv.ColumnHeadersHeight = 25
        DataGridViewCellStyle69.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle69.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle69.Font = New System.Drawing.Font("Futura Bk BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle69.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle69.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle69.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle69.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle69
        Me.dgv.EnableHeadersVisualStyles = False
        Me.dgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dgv.Location = New System.Drawing.Point(7, 7)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray
        Me.dgv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgv.RowTemplate.Height = 30
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(865, 166)
        Me.dgv.TabIndex = 0
        Me.dgv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue
        Me.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dgv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgv.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv.ThemeStyle.HeaderStyle.Height = 25
        Me.dgv.ThemeStyle.ReadOnly = False
        Me.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Futura Bk BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgv.ThemeStyle.RowsStyle.Height = 30
        Me.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'btnCari
        '
        Me.btnCari.BorderRadius = 6
        Me.btnCari.CheckedState.Parent = Me.btnCari
        Me.btnCari.CustomImages.Parent = Me.btnCari
        Me.btnCari.FillColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCari.Font = New System.Drawing.Font("Futura Bk BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.HoverState.Parent = Me.btnCari
        Me.btnCari.Location = New System.Drawing.Point(75, 87)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.ShadowDecoration.Parent = Me.btnCari
        Me.btnCari.Size = New System.Drawing.Size(109, 36)
        Me.btnCari.TabIndex = 45
        Me.btnCari.Text = "Cari Data"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2Panel3.CustomBorderThickness = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 615)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(891, 64)
        Me.Guna2Panel3.TabIndex = 57
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Futura Md BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(273, 25)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(367, 18)
        Me.Guna2HtmlLabel8.TabIndex = 15
        Me.Guna2HtmlLabel8.Text = "Copyright © 2021 Perpustakaan Sanak , All rights reserved."
        '
        'qty
        '
        Me.qty.BorderRadius = 3
        Me.qty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.qty.DefaultText = ""
        Me.qty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.qty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.qty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.qty.DisabledState.Parent = Me.qty
        Me.qty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.qty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.qty.FocusedState.Parent = Me.qty
        Me.qty.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.qty.ForeColor = System.Drawing.SystemColors.ControlText
        Me.qty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.qty.HoverState.Parent = Me.qty
        Me.qty.Location = New System.Drawing.Point(665, 45)
        Me.qty.Name = "qty"
        Me.qty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.qty.PlaceholderText = ""
        Me.qty.SelectedText = ""
        Me.qty.ShadowDecoration.Parent = Me.qty
        Me.qty.Size = New System.Drawing.Size(121, 36)
        Me.qty.TabIndex = 41
        '
        'nama
        '
        Me.nama.BorderRadius = 3
        Me.nama.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nama.DefaultText = ""
        Me.nama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.nama.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.nama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.nama.DisabledState.Parent = Me.nama
        Me.nama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.nama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nama.FocusedState.Parent = Me.nama
        Me.nama.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.nama.ForeColor = System.Drawing.SystemColors.ControlText
        Me.nama.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nama.HoverState.Parent = Me.nama
        Me.nama.Location = New System.Drawing.Point(246, 45)
        Me.nama.Name = "nama"
        Me.nama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nama.PlaceholderText = ""
        Me.nama.SelectedText = ""
        Me.nama.ShadowDecoration.Parent = Me.nama
        Me.nama.Size = New System.Drawing.Size(286, 36)
        Me.nama.TabIndex = 39
        '
        'kode
        '
        Me.kode.BorderRadius = 3
        Me.kode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kode.DefaultText = ""
        Me.kode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.kode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.kode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.kode.DisabledState.Parent = Me.kode
        Me.kode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.kode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kode.FocusedState.Parent = Me.kode
        Me.kode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.kode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.kode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kode.HoverState.Parent = Me.kode
        Me.kode.Location = New System.Drawing.Point(19, 45)
        Me.kode.Name = "kode"
        Me.kode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.kode.PlaceholderText = ""
        Me.kode.SelectedText = ""
        Me.kode.ShadowDecoration.Parent = Me.kode
        Me.kode.Size = New System.Drawing.Size(220, 36)
        Me.kode.TabIndex = 38
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.White
        Me.Guna2Panel2.Controls.Add(Me.btnClose)
        Me.Guna2Panel2.Controls.Add(Me.btnSimpan)
        Me.Guna2Panel2.Controls.Add(Me.dgv)
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(5, 368)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(878, 241)
        Me.Guna2Panel2.TabIndex = 55
        '
        'btnClose
        '
        Me.btnClose.BorderRadius = 6
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Image = CType(resources.GetObject("btnClose.CustomImages.Image"), System.Drawing.Image)
        Me.btnClose.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnClose.CustomImages.ImageOffset = New System.Drawing.Point(14, 0)
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.DarkGray
        Me.btnClose.Font = New System.Drawing.Font("Futura Bk BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(186, 189)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(159, 36)
        Me.btnClose.TabIndex = 46
        Me.btnClose.Text = "Batal"
        '
        'stok
        '
        Me.stok.BorderRadius = 3
        Me.stok.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.stok.DefaultText = ""
        Me.stok.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.stok.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.stok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.stok.DisabledState.Parent = Me.stok
        Me.stok.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.stok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stok.FocusedState.Parent = Me.stok
        Me.stok.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.stok.ForeColor = System.Drawing.SystemColors.ControlText
        Me.stok.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stok.HoverState.Parent = Me.stok
        Me.stok.Location = New System.Drawing.Point(538, 45)
        Me.stok.Name = "stok"
        Me.stok.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.stok.PlaceholderText = ""
        Me.stok.SelectedText = ""
        Me.stok.ShadowDecoration.Parent = Me.stok
        Me.stok.Size = New System.Drawing.Size(121, 36)
        Me.stok.TabIndex = 43
        '
        'Guna2HtmlLabel13
        '
        Me.Guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel13.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel13.Location = New System.Drawing.Point(580, 20)
        Me.Guna2HtmlLabel13.Name = "Guna2HtmlLabel13"
        Me.Guna2HtmlLabel13.Size = New System.Drawing.Size(41, 19)
        Me.Guna2HtmlLabel13.TabIndex = 34
        Me.Guna2HtmlLabel13.Text = "Pinjam"
        '
        'Guna2HtmlLabel15
        '
        Me.Guna2HtmlLabel15.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel15.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel15.Location = New System.Drawing.Point(702, 20)
        Me.Guna2HtmlLabel15.Name = "Guna2HtmlLabel15"
        Me.Guna2HtmlLabel15.Size = New System.Drawing.Size(50, 19)
        Me.Guna2HtmlLabel15.TabIndex = 36
        Me.Guna2HtmlLabel15.Text = "Kembali"
        '
        'Guna2HtmlLabel12
        '
        Me.Guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel12.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel12.Location = New System.Drawing.Point(354, 20)
        Me.Guna2HtmlLabel12.Name = "Guna2HtmlLabel12"
        Me.Guna2HtmlLabel12.Size = New System.Drawing.Size(64, 19)
        Me.Guna2HtmlLabel12.TabIndex = 33
        Me.Guna2HtmlLabel12.Text = "Judul Buku"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.Controls.Add(Me.denda)
        Me.Guna2Panel4.Controls.Add(Me.fakturpinjam)
        Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel4.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel4.Controls.Add(Me.akhir)
        Me.Guna2Panel4.Controls.Add(Me.btnTambah)
        Me.Guna2Panel4.Controls.Add(Me.id)
        Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Guna2Panel4.CustomBorderThickness = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Guna2Panel4.FillColor = System.Drawing.Color.White
        Me.Guna2Panel4.Location = New System.Drawing.Point(8, 76)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(875, 140)
        Me.Guna2Panel4.TabIndex = 53
        '
        'fakturpinjam
        '
        Me.fakturpinjam.BorderRadius = 3
        Me.fakturpinjam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fakturpinjam.DefaultText = ""
        Me.fakturpinjam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.fakturpinjam.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.fakturpinjam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fakturpinjam.DisabledState.Parent = Me.fakturpinjam
        Me.fakturpinjam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fakturpinjam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fakturpinjam.FocusedState.Parent = Me.fakturpinjam
        Me.fakturpinjam.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fakturpinjam.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fakturpinjam.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fakturpinjam.HoverState.Parent = Me.fakturpinjam
        Me.fakturpinjam.Location = New System.Drawing.Point(127, 77)
        Me.fakturpinjam.Name = "fakturpinjam"
        Me.fakturpinjam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fakturpinjam.PlaceholderText = ""
        Me.fakturpinjam.SelectedText = ""
        Me.fakturpinjam.ShadowDecoration.Parent = Me.fakturpinjam
        Me.fakturpinjam.Size = New System.Drawing.Size(187, 36)
        Me.fakturpinjam.TabIndex = 41
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 6
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Futura Bk BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.Location = New System.Drawing.Point(320, 77)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(109, 36)
        Me.Guna2Button1.TabIndex = 40
        Me.Guna2Button1.Text = "Cari Data"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(27, 86)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(80, 19)
        Me.Guna2HtmlLabel4.TabIndex = 38
        Me.Guna2HtmlLabel4.Text = "Faktur Pinjam"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(457, 38)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(101, 19)
        Me.Guna2HtmlLabel3.TabIndex = 37
        Me.Guna2HtmlLabel3.Text = "Tanggal Kembali"
        '
        'akhir
        '
        Me.akhir.BackColor = System.Drawing.Color.White
        Me.akhir.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.akhir.BorderRadius = 4
        Me.akhir.BorderThickness = 1
        Me.akhir.CheckedState.Parent = Me.akhir
        Me.akhir.FillColor = System.Drawing.Color.White
        Me.akhir.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.akhir.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.akhir.HoverState.Parent = Me.akhir
        Me.akhir.Location = New System.Drawing.Point(581, 28)
        Me.akhir.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.akhir.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.akhir.Name = "akhir"
        Me.akhir.ShadowDecoration.Parent = Me.akhir
        Me.akhir.Size = New System.Drawing.Size(261, 36)
        Me.akhir.TabIndex = 36
        Me.akhir.Value = New Date(2021, 1, 1, 0, 0, 0, 0)
        '
        'btnTambah
        '
        Me.btnTambah.BorderRadius = 6
        Me.btnTambah.CheckedState.Parent = Me.btnTambah
        Me.btnTambah.CustomImages.Image = CType(resources.GetObject("btnTambah.CustomImages.Image"), System.Drawing.Image)
        Me.btnTambah.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTambah.CustomImages.ImageOffset = New System.Drawing.Point(-2, 0)
        Me.btnTambah.CustomImages.Parent = Me.btnTambah
        Me.btnTambah.FillColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTambah.Font = New System.Drawing.Font("Futura Bk BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.HoverState.Parent = Me.btnTambah
        Me.btnTambah.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTambah.Location = New System.Drawing.Point(320, 28)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.ShadowDecoration.Parent = Me.btnTambah
        Me.btnTambah.Size = New System.Drawing.Size(109, 36)
        Me.btnTambah.TabIndex = 35
        Me.btnTambah.Text = "Buat Faktur"
        Me.btnTambah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'id
        '
        Me.id.BorderRadius = 3
        Me.id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.id.DefaultText = ""
        Me.id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.id.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.id.DisabledState.Parent = Me.id
        Me.id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.id.FocusedState.Parent = Me.id
        Me.id.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.id.ForeColor = System.Drawing.SystemColors.ControlText
        Me.id.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.id.HoverState.Parent = Me.id
        Me.id.Location = New System.Drawing.Point(127, 28)
        Me.id.Name = "id"
        Me.id.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.id.PlaceholderText = ""
        Me.id.SelectedText = ""
        Me.id.ShadowDecoration.Parent = Me.id
        Me.id.Size = New System.Drawing.Size(187, 36)
        Me.id.TabIndex = 33
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(27, 37)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(79, 19)
        Me.Guna2HtmlLabel9.TabIndex = 31
        Me.Guna2HtmlLabel9.Text = "No Transaksi"
        '
        'Guna2HtmlLabel11
        '
        Me.Guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel11.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel11.Location = New System.Drawing.Point(98, 20)
        Me.Guna2HtmlLabel11.Name = "Guna2HtmlLabel11"
        Me.Guna2HtmlLabel11.Size = New System.Drawing.Size(65, 19)
        Me.Guna2HtmlLabel11.TabIndex = 32
        Me.Guna2HtmlLabel11.Text = "Kode Buku"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Futura Md BT", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(25, 22)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(225, 22)
        Me.Guna2HtmlLabel1.TabIndex = 56
        Me.Guna2HtmlLabel1.Text = "Tambah Data Pengembalian"
        '
        'btnOk
        '
        Me.btnOk.BorderRadius = 6
        Me.btnOk.CheckedState.Parent = Me.btnOk
        Me.btnOk.CustomImages.Parent = Me.btnOk
        Me.btnOk.FillColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOk.Font = New System.Drawing.Font("Futura Bk BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.HoverState.Parent = Me.btnOk
        Me.btnOk.Location = New System.Drawing.Point(792, 45)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.ShadowDecoration.Parent = Me.btnOk
        Me.btnOk.Size = New System.Drawing.Size(64, 36)
        Me.btnOk.TabIndex = 44
        Me.btnOk.Text = "Ok"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.btnCari)
        Me.Guna2Panel1.Controls.Add(Me.btnOk)
        Me.Guna2Panel1.Controls.Add(Me.stok)
        Me.Guna2Panel1.Controls.Add(Me.qty)
        Me.Guna2Panel1.Controls.Add(Me.nama)
        Me.Guna2Panel1.Controls.Add(Me.kode)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel13)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel15)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel12)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel11)
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(6, 222)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(877, 140)
        Me.Guna2Panel1.TabIndex = 54
        '
        'denda
        '
        Me.denda.BorderRadius = 3
        Me.denda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.denda.DefaultText = ""
        Me.denda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.denda.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.denda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.denda.DisabledState.Parent = Me.denda
        Me.denda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.denda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.denda.FocusedState.Parent = Me.denda
        Me.denda.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.denda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.denda.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.denda.HoverState.Parent = Me.denda
        Me.denda.Location = New System.Drawing.Point(580, 77)
        Me.denda.Name = "denda"
        Me.denda.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.denda.PlaceholderText = ""
        Me.denda.SelectedText = ""
        Me.denda.ShadowDecoration.Parent = Me.denda
        Me.denda.Size = New System.Drawing.Size(262, 36)
        Me.denda.TabIndex = 47
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(459, 86)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(41, 19)
        Me.Guna2HtmlLabel2.TabIndex = 46
        Me.Guna2HtmlLabel2.Text = "Denda"
        '
        'FormTambahPengembalian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 679)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormTambahPengembalian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTambahPengembalian"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSimpan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnCari As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents qty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents nama As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents kode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents stok As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel13 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel15 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel12 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents fakturpinjam As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents akhir As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnTambah As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents id As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel11 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnOk As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents denda As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
