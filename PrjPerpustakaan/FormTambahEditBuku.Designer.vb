<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahEditBuku
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTambahEditBuku))
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.pengarang = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblJudul = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.penerbit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.jumlah = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.rak = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tgl = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tahun = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.judul = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.id = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.kode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.jumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(42, 167)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(75, 19)
        Me.Guna2HtmlLabel3.TabIndex = 24
        Me.Guna2HtmlLabel3.Text = "Pengarang *"
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 5
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomImages.Image = CType(resources.GetObject("btnCancel.CustomImages.Image"), System.Drawing.Image)
        Me.btnCancel.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCancel.CustomImages.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnCancel.CustomImages.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.Color.Silver
        Me.btnCancel.Font = New System.Drawing.Font("Futura Bk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(321, 12)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(167, 40)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Batal"
        Me.btnCancel.TextOffset = New System.Drawing.Point(5, 0)
        '
        'pengarang
        '
        Me.pengarang.BorderRadius = 3
        Me.pengarang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pengarang.DefaultText = ""
        Me.pengarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.pengarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.pengarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pengarang.DisabledState.Parent = Me.pengarang
        Me.pengarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pengarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pengarang.FocusedState.Parent = Me.pengarang
        Me.pengarang.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.pengarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pengarang.HoverState.Parent = Me.pengarang
        Me.pengarang.Location = New System.Drawing.Point(187, 159)
        Me.pengarang.Name = "pengarang"
        Me.pengarang.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pengarang.PlaceholderText = ""
        Me.pengarang.SelectedText = ""
        Me.pengarang.ShadowDecoration.Parent = Me.pengarang
        Me.pengarang.Size = New System.Drawing.Size(294, 33)
        Me.pengarang.TabIndex = 23
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Futura Md BT", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(96, 20)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(41, 22)
        Me.Guna2HtmlLabel9.TabIndex = 28
        Me.Guna2HtmlLabel9.Text = "Data"
        '
        'btnSave
        '
        Me.btnSave.BorderRadius = 5
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.CustomImages.Image = CType(resources.GetObject("btnSave.CustomImages.Image"), System.Drawing.Image)
        Me.btnSave.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSave.CustomImages.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnSave.CustomImages.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Futura Bk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.Location = New System.Drawing.Point(498, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(167, 40)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Simpan"
        Me.btnSave.TextOffset = New System.Drawing.Point(5, 0)
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.Controls.Add(Me.lblJudul)
        Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(11, 12)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(716, 64)
        Me.Guna2Panel2.TabIndex = 41
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Font = New System.Drawing.Font("Futura Md BT", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.DimGray
        Me.lblJudul.Location = New System.Drawing.Point(28, 20)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(67, 22)
        Me.lblJudul.TabIndex = 25
        Me.lblJudul.Text = "Tambah"
        '
        'penerbit
        '
        Me.penerbit.BorderRadius = 3
        Me.penerbit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.penerbit.DefaultText = ""
        Me.penerbit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.penerbit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.penerbit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.penerbit.DisabledState.Parent = Me.penerbit
        Me.penerbit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.penerbit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.penerbit.FocusedState.Parent = Me.penerbit
        Me.penerbit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.penerbit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.penerbit.HoverState.Parent = Me.penerbit
        Me.penerbit.Location = New System.Drawing.Point(187, 111)
        Me.penerbit.Name = "penerbit"
        Me.penerbit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.penerbit.PlaceholderText = ""
        Me.penerbit.SelectedText = ""
        Me.penerbit.ShadowDecoration.Parent = Me.penerbit
        Me.penerbit.Size = New System.Drawing.Size(294, 33)
        Me.penerbit.TabIndex = 21
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 5
        Me.Guna2Panel1.Controls.Add(Me.jumlah)
        Me.Guna2Panel1.Controls.Add(Me.rak)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel10)
        Me.Guna2Panel1.Controls.Add(Me.tgl)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2Panel1.Controls.Add(Me.tahun)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Panel1.Controls.Add(Me.judul)
        Me.Guna2Panel1.Controls.Add(Me.pengarang)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel1.Controls.Add(Me.penerbit)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Me.id)
        Me.Guna2Panel1.Controls.Add(Me.kode)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(11, 82)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(716, 410)
        Me.Guna2Panel1.TabIndex = 40
        '
        'jumlah
        '
        Me.jumlah.BackColor = System.Drawing.Color.Transparent
        Me.jumlah.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.jumlah.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.jumlah.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.jumlah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.jumlah.DisabledState.Parent = Me.jumlah
        Me.jumlah.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.jumlah.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.jumlah.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.jumlah.FocusedState.Parent = Me.jumlah
        Me.jumlah.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.jumlah.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.jumlah.Location = New System.Drawing.Point(187, 303)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.ShadowDecoration.Parent = Me.jumlah
        Me.jumlah.Size = New System.Drawing.Size(100, 36)
        Me.jumlah.TabIndex = 39
        '
        'rak
        '
        Me.rak.BackColor = System.Drawing.Color.Transparent
        Me.rak.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.rak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rak.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rak.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rak.FocusedState.Parent = Me.rak
        Me.rak.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rak.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.rak.HoverState.Parent = Me.rak
        Me.rak.ItemHeight = 30
        Me.rak.ItemsAppearance.Parent = Me.rak
        Me.rak.Location = New System.Drawing.Point(187, 205)
        Me.rak.Name = "rak"
        Me.rak.ShadowDecoration.Parent = Me.rak
        Me.rak.Size = New System.Drawing.Size(357, 36)
        Me.rak.TabIndex = 38
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderRadius = 5
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.CustomImages.ImageOffset = New System.Drawing.Point(15, 0)
        Me.Guna2Button2.CustomImages.ImageSize = New System.Drawing.Size(24, 24)
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Futura Bk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(487, 159)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(108, 33)
        Me.Guna2Button2.TabIndex = 37
        Me.Guna2Button2.Text = "Cari Data"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.CustomImages.ImageOffset = New System.Drawing.Point(15, 0)
        Me.Guna2Button1.CustomImages.ImageSize = New System.Drawing.Size(24, 24)
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Futura Bk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(487, 111)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(108, 33)
        Me.Guna2Button1.TabIndex = 36
        Me.Guna2Button1.Text = "Cari Data"
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel10.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(42, 362)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(128, 19)
        Me.Guna2HtmlLabel10.TabIndex = 35
        Me.Guna2HtmlLabel10.Text = "Tanggal Pengadaan *"
        '
        'tgl
        '
        Me.tgl.BorderRadius = 5
        Me.tgl.CheckedState.Parent = Me.tgl
        Me.tgl.FillColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tgl.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tgl.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.tgl.HoverState.Parent = Me.tgl
        Me.tgl.Location = New System.Drawing.Point(187, 353)
        Me.tgl.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.tgl.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.tgl.Name = "tgl"
        Me.tgl.ShadowDecoration.Parent = Me.tgl
        Me.tgl.Size = New System.Drawing.Size(257, 36)
        Me.tgl.TabIndex = 34
        Me.tgl.Value = New Date(2021, 1, 1, 0, 0, 0, 0)
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(42, 312)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(52, 19)
        Me.Guna2HtmlLabel8.TabIndex = 33
        Me.Guna2HtmlLabel8.Text = "Jumlah *"
        '
        'tahun
        '
        Me.tahun.BorderRadius = 3
        Me.tahun.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tahun.DefaultText = ""
        Me.tahun.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tahun.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tahun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tahun.DisabledState.Parent = Me.tahun
        Me.tahun.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tahun.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tahun.FocusedState.Parent = Me.tahun
        Me.tahun.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tahun.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tahun.HoverState.Parent = Me.tahun
        Me.tahun.Location = New System.Drawing.Point(187, 255)
        Me.tahun.Name = "tahun"
        Me.tahun.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tahun.PlaceholderText = ""
        Me.tahun.SelectedText = ""
        Me.tahun.ShadowDecoration.Parent = Me.tahun
        Me.tahun.Size = New System.Drawing.Size(178, 33)
        Me.tahun.TabIndex = 30
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(42, 263)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(47, 19)
        Me.Guna2HtmlLabel6.TabIndex = 31
        Me.Guna2HtmlLabel6.Text = "Tahun *"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(42, 215)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(33, 19)
        Me.Guna2HtmlLabel5.TabIndex = 29
        Me.Guna2HtmlLabel5.Text = "Rak *"
        '
        'judul
        '
        Me.judul.BorderRadius = 3
        Me.judul.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.judul.DefaultText = ""
        Me.judul.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.judul.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.judul.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.judul.DisabledState.Parent = Me.judul
        Me.judul.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.judul.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.judul.FocusedState.Parent = Me.judul
        Me.judul.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.judul.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.judul.HoverState.Parent = Me.judul
        Me.judul.Location = New System.Drawing.Point(187, 64)
        Me.judul.Name = "judul"
        Me.judul.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.judul.PlaceholderText = ""
        Me.judul.SelectedText = ""
        Me.judul.ShadowDecoration.Parent = Me.judul
        Me.judul.Size = New System.Drawing.Size(483, 31)
        Me.judul.TabIndex = 25
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(42, 119)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(60, 19)
        Me.Guna2HtmlLabel1.TabIndex = 22
        Me.Guna2HtmlLabel1.Text = "Penerbit *"
        '
        'id
        '
        Me.id.BackColor = System.Drawing.Color.Transparent
        Me.id.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.ForeColor = System.Drawing.Color.Transparent
        Me.id.Location = New System.Drawing.Point(608, 15)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(3, 2)
        Me.id.TabIndex = 20
        Me.id.Text = Nothing
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
        Me.kode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kode.HoverState.Parent = Me.kode
        Me.kode.Location = New System.Drawing.Point(187, 17)
        Me.kode.Name = "kode"
        Me.kode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.kode.PlaceholderText = ""
        Me.kode.SelectedText = ""
        Me.kode.ShadowDecoration.Parent = Me.kode
        Me.kode.Size = New System.Drawing.Size(341, 31)
        Me.kode.TabIndex = 8
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(42, 71)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(73, 19)
        Me.Guna2HtmlLabel7.TabIndex = 19
        Me.Guna2HtmlLabel7.Text = "Judul Buku *"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(42, 24)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(74, 19)
        Me.Guna2HtmlLabel2.TabIndex = 14
        Me.Guna2HtmlLabel2.Text = "Kode Buku *"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.Controls.Add(Me.btnCancel)
        Me.Guna2Panel3.Controls.Add(Me.btnSave)
        Me.Guna2Panel3.CustomBorderThickness = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(11, 498)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(716, 64)
        Me.Guna2Panel3.TabIndex = 42
        '
        'FormTambahEditBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 572)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormTambahEditBuku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTambahEditBuku"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.jumlah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pengarang As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblJudul As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents penerbit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents id As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents kode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tahun As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents judul As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tgl As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents rak As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents jumlah As Guna.UI2.WinForms.Guna2NumericUpDown
End Class
