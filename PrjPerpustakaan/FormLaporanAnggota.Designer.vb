<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanAnggota
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLaporanAnggota))
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.akhiranggota = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblJudul = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.awalanggota = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Futura Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(347, 54)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(24, 18)
        Me.Guna2HtmlLabel6.TabIndex = 72
        Me.Guna2HtmlLabel6.Text = "S/d"
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
        Me.btnSave.Text = "Cetak"
        Me.btnSave.TextOffset = New System.Drawing.Point(5, 0)
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.Controls.Add(Me.btnCancel)
        Me.Guna2Panel3.Controls.Add(Me.btnSave)
        Me.Guna2Panel3.CustomBorderThickness = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(13, 220)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(716, 64)
        Me.Guna2Panel3.TabIndex = 54
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
        'akhiranggota
        '
        Me.akhiranggota.BackColor = System.Drawing.Color.Transparent
        Me.akhiranggota.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.akhiranggota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.akhiranggota.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.akhiranggota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.akhiranggota.FocusedState.Parent = Me.akhiranggota
        Me.akhiranggota.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.akhiranggota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.akhiranggota.HoverState.Parent = Me.akhiranggota
        Me.akhiranggota.ItemHeight = 30
        Me.akhiranggota.ItemsAppearance.Parent = Me.akhiranggota
        Me.akhiranggota.Location = New System.Drawing.Point(389, 45)
        Me.akhiranggota.Name = "akhiranggota"
        Me.akhiranggota.ShadowDecoration.Parent = Me.akhiranggota
        Me.akhiranggota.Size = New System.Drawing.Size(298, 36)
        Me.akhiranggota.TabIndex = 70
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.DimGray
        Me.lblJudul.Location = New System.Drawing.Point(28, 20)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(168, 21)
        Me.lblJudul.TabIndex = 25
        Me.lblJudul.Text = "Laporan Data Anggota"
        '
        'awalanggota
        '
        Me.awalanggota.BackColor = System.Drawing.Color.Transparent
        Me.awalanggota.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.awalanggota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.awalanggota.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.awalanggota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.awalanggota.FocusedState.Parent = Me.awalanggota
        Me.awalanggota.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.awalanggota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.awalanggota.HoverState.Parent = Me.awalanggota
        Me.awalanggota.ItemHeight = 30
        Me.awalanggota.ItemsAppearance.Parent = Me.awalanggota
        Me.awalanggota.Location = New System.Drawing.Point(28, 45)
        Me.awalanggota.Name = "awalanggota"
        Me.awalanggota.ShadowDecoration.Parent = Me.awalanggota
        Me.awalanggota.Size = New System.Drawing.Size(298, 36)
        Me.awalanggota.TabIndex = 69
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 5
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2Panel1.Controls.Add(Me.akhiranggota)
        Me.Guna2Panel1.Controls.Add(Me.awalanggota)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(13, 83)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(716, 131)
        Me.Guna2Panel1.TabIndex = 52
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.Controls.Add(Me.lblJudul)
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(13, 13)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(716, 64)
        Me.Guna2Panel2.TabIndex = 53
        '
        'FormLaporanAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 297)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLaporanAnggota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLaporanAnggota"
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents akhiranggota As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblJudul As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents awalanggota As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
End Class
