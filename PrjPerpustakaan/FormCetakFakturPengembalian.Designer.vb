<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCetakFakturPengembalian
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
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox4 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox5 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox6 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Guna2Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Guna2Panel3.Controls.Add(Me.Guna2ControlBox4)
        Me.Guna2Panel3.Controls.Add(Me.Guna2ControlBox5)
        Me.Guna2Panel3.Controls.Add(Me.Guna2ControlBox6)
        Me.Guna2Panel3.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(329, 31)
        Me.Guna2Panel3.TabIndex = 14
        '
        'Guna2ControlBox4
        '
        Me.Guna2ControlBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox4.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2ControlBox4.FillColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ControlBox4.HoverState.Parent = Me.Guna2ControlBox4
        Me.Guna2ControlBox4.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox4.Location = New System.Drawing.Point(261, 1)
        Me.Guna2ControlBox4.Name = "Guna2ControlBox4"
        Me.Guna2ControlBox4.ShadowDecoration.Parent = Me.Guna2ControlBox4
        Me.Guna2ControlBox4.Size = New System.Drawing.Size(31, 29)
        Me.Guna2ControlBox4.TabIndex = 3
        '
        'Guna2ControlBox5
        '
        Me.Guna2ControlBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox5.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox5.FillColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ControlBox5.HoverState.Parent = Me.Guna2ControlBox5
        Me.Guna2ControlBox5.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox5.Location = New System.Drawing.Point(224, 1)
        Me.Guna2ControlBox5.Name = "Guna2ControlBox5"
        Me.Guna2ControlBox5.ShadowDecoration.Parent = Me.Guna2ControlBox5
        Me.Guna2ControlBox5.Size = New System.Drawing.Size(31, 29)
        Me.Guna2ControlBox5.TabIndex = 2
        '
        'Guna2ControlBox6
        '
        Me.Guna2ControlBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox6.FillColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ControlBox6.HoverState.Parent = Me.Guna2ControlBox6
        Me.Guna2ControlBox6.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox6.Location = New System.Drawing.Point(298, 1)
        Me.Guna2ControlBox6.Name = "Guna2ControlBox6"
        Me.Guna2ControlBox6.ShadowDecoration.Parent = Me.Guna2ControlBox6
        Me.Guna2ControlBox6.Size = New System.Drawing.Size(31, 29)
        Me.Guna2ControlBox6.TabIndex = 1
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv.Location = New System.Drawing.Point(0, 31)
        Me.crv.Name = "crv"
        Me.crv.Size = New System.Drawing.Size(329, 252)
        Me.crv.TabIndex = 15
        '
        'FormCetakFakturPengembalian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 283)
        Me.Controls.Add(Me.crv)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCetakFakturPengembalian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCetakFakturPengembalian"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox4 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox5 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox6 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
