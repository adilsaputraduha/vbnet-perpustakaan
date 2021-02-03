<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanTransaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLaporanTransaksi))
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.akhirpm = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.awalpm = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.akhirpb = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.awalpb = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblJudul = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.awal = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.BorderRadius = 5
        Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Panel4.Controls.Add(Me.btnSave)
        Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel4.Controls.Add(Me.akhirpm)
        Me.Guna2Panel4.Controls.Add(Me.awalpm)
        Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel4.CustomBorderThickness = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Guna2Panel4.FillColor = System.Drawing.Color.White
        Me.Guna2Panel4.Location = New System.Drawing.Point(12, 96)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(867, 213)
        Me.Guna2Panel4.TabIndex = 26
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(579, 64)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(83, 19)
        Me.Guna2HtmlLabel6.TabIndex = 40
        Me.Guna2HtmlLabel6.Text = "Tanggal Akhir"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(227, 64)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(81, 19)
        Me.Guna2HtmlLabel5.TabIndex = 39
        Me.Guna2HtmlLabel5.Text = "Tanggal Awal"
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
        Me.btnSave.Location = New System.Drawing.Point(359, 151)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(167, 40)
        Me.btnSave.TabIndex = 38
        Me.btnSave.Text = "Cetak"
        Me.btnSave.TextOffset = New System.Drawing.Point(5, 0)
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(429, 98)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(23, 19)
        Me.Guna2HtmlLabel4.TabIndex = 37
        Me.Guna2HtmlLabel4.Text = "S/d"
        '
        'akhirpm
        '
        Me.akhirpm.BackColor = System.Drawing.Color.White
        Me.akhirpm.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.akhirpm.BorderRadius = 4
        Me.akhirpm.BorderThickness = 1
        Me.akhirpm.CheckedState.Parent = Me.akhirpm
        Me.akhirpm.FillColor = System.Drawing.Color.White
        Me.akhirpm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.akhirpm.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.akhirpm.HoverState.Parent = Me.akhirpm
        Me.akhirpm.Location = New System.Drawing.Point(489, 89)
        Me.akhirpm.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.akhirpm.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.akhirpm.Name = "akhirpm"
        Me.akhirpm.ShadowDecoration.Parent = Me.akhirpm
        Me.akhirpm.Size = New System.Drawing.Size(261, 36)
        Me.akhirpm.TabIndex = 36
        Me.akhirpm.Value = New Date(2021, 1, 1, 0, 0, 0, 0)
        '
        'awalpm
        '
        Me.awalpm.BackColor = System.Drawing.Color.White
        Me.awalpm.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.awalpm.BorderRadius = 4
        Me.awalpm.BorderThickness = 1
        Me.awalpm.CheckedState.Parent = Me.awalpm
        Me.awalpm.FillColor = System.Drawing.Color.White
        Me.awalpm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.awalpm.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.awalpm.HoverState.Parent = Me.awalpm
        Me.awalpm.Location = New System.Drawing.Point(134, 89)
        Me.awalpm.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.awalpm.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.awalpm.Name = "awalpm"
        Me.awalpm.ShadowDecoration.Parent = Me.awalpm
        Me.awalpm.Size = New System.Drawing.Size(261, 36)
        Me.awalpm.TabIndex = 35
        Me.awalpm.Value = New Date(2021, 1, 1, 0, 0, 0, 0)
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Futura Md BT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(25, 21)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(199, 20)
        Me.Guna2HtmlLabel1.TabIndex = 3
        Me.Guna2HtmlLabel1.Text = "Transaksi Peminjaman Buku"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 5
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Guna2Panel1.Controls.Add(Me.akhirpb)
        Me.Guna2Panel1.Controls.Add(Me.awalpb)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(12, 344)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(867, 213)
        Me.Guna2Panel1.TabIndex = 27
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(579, 64)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(83, 19)
        Me.Guna2HtmlLabel7.TabIndex = 46
        Me.Guna2HtmlLabel7.Text = "Tanggal Akhir"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(227, 64)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(81, 19)
        Me.Guna2HtmlLabel8.TabIndex = 45
        Me.Guna2HtmlLabel8.Text = "Tanggal Awal"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Image = CType(resources.GetObject("Guna2Button1.CustomImages.Image"), System.Drawing.Image)
        Me.Guna2Button1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.CustomImages.ImageOffset = New System.Drawing.Point(15, 0)
        Me.Guna2Button1.CustomImages.ImageSize = New System.Drawing.Size(24, 24)
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Futura Bk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(359, 151)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(167, 40)
        Me.Guna2Button1.TabIndex = 44
        Me.Guna2Button1.Text = "Cetak"
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(5, 0)
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(429, 98)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(23, 19)
        Me.Guna2HtmlLabel9.TabIndex = 43
        Me.Guna2HtmlLabel9.Text = "S/d"
        '
        'akhirpb
        '
        Me.akhirpb.BackColor = System.Drawing.Color.White
        Me.akhirpb.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.akhirpb.BorderRadius = 4
        Me.akhirpb.BorderThickness = 1
        Me.akhirpb.CheckedState.Parent = Me.akhirpb
        Me.akhirpb.FillColor = System.Drawing.Color.White
        Me.akhirpb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.akhirpb.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.akhirpb.HoverState.Parent = Me.akhirpb
        Me.akhirpb.Location = New System.Drawing.Point(489, 89)
        Me.akhirpb.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.akhirpb.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.akhirpb.Name = "akhirpb"
        Me.akhirpb.ShadowDecoration.Parent = Me.akhirpb
        Me.akhirpb.Size = New System.Drawing.Size(261, 36)
        Me.akhirpb.TabIndex = 42
        Me.akhirpb.Value = New Date(2021, 1, 1, 0, 0, 0, 0)
        '
        'awalpb
        '
        Me.awalpb.BackColor = System.Drawing.Color.White
        Me.awalpb.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.awalpb.BorderRadius = 4
        Me.awalpb.BorderThickness = 1
        Me.awalpb.CheckedState.Parent = Me.awalpb
        Me.awalpb.FillColor = System.Drawing.Color.White
        Me.awalpb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.awalpb.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.awalpb.HoverState.Parent = Me.awalpb
        Me.awalpb.Location = New System.Drawing.Point(134, 89)
        Me.awalpb.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.awalpb.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.awalpb.Name = "awalpb"
        Me.awalpb.ShadowDecoration.Parent = Me.awalpb
        Me.awalpb.Size = New System.Drawing.Size(261, 36)
        Me.awalpb.TabIndex = 41
        Me.awalpb.Value = New Date(2021, 1, 1, 0, 0, 0, 0)
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Futura Md BT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(25, 21)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(212, 20)
        Me.Guna2HtmlLabel2.TabIndex = 3
        Me.Guna2HtmlLabel2.Text = "Transaksi Pengembalian Buku"
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Font = New System.Drawing.Font("Futura Md BT", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.DimGray
        Me.lblJudul.Location = New System.Drawing.Point(22, 12)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(144, 22)
        Me.lblJudul.TabIndex = 28
        Me.lblJudul.Text = "Laporan Transaksi"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 615)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(891, 64)
        Me.Guna2Panel2.TabIndex = 31
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Futura Md BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(273, 25)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(367, 18)
        Me.Guna2HtmlLabel3.TabIndex = 15
        Me.Guna2HtmlLabel3.Text = "Copyright © 2021 Perpustakaan Sanak , All rights reserved."
        '
        'awal
        '
        Me.awal.BackColor = System.Drawing.Color.White
        Me.awal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.awal.BorderRadius = 4
        Me.awal.BorderThickness = 1
        Me.awal.CheckedState.Parent = Me.awal
        Me.awal.FillColor = System.Drawing.Color.White
        Me.awal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.awal.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.awal.HoverState.Parent = Me.awal
        Me.awal.Location = New System.Drawing.Point(134, 89)
        Me.awal.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.awal.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.awal.Name = "awal"
        Me.awal.ShadowDecoration.Parent = Me.awal
        Me.awal.Size = New System.Drawing.Size(261, 36)
        Me.awal.TabIndex = 35
        Me.awal.Value = New Date(2021, 1, 1, 0, 0, 0, 0)
        '
        'FormLaporanTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 679)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.lblJudul)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLaporanTransaksi"
        Me.Text = "FormLaporanTransaksi"
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblJudul As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents akhirpm As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents awalpm As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents akhirpb As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents awalpb As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents awal As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
