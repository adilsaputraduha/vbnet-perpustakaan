Public Class FormCariDataPenerbit
    Sub set_dg()
        dgv.Columns(0).HeaderText = "No."
        dgv.Columns(1).HeaderText = "Id"
        dgv.Columns(2).HeaderText = "Nama"
        dgv.Columns(3).HeaderText = "Alamat"
        dgv.Columns(1).Visible = False
    End Sub

    Sub buat_tombol()
        'tombol delete
        Dim btnPilih As New DataGridViewButtonColumn
        btnPilih.Name = "btnPilih"
        btnPilih.FlatStyle = FlatStyle.Popup
        btnPilih.DefaultCellStyle.ForeColor = Color.Blue
        btnPilih.HeaderText = ""
        btnPilih.Text = "Pilih"
        btnPilih.Width = 5
        btnPilih.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        btnPilih.UseColumnTextForButtonValue = True
        dgv.Columns.Add(btnPilih)
    End Sub

    Sub tampil_data(ByVal sql As String)
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "data")
        dgv.DataSource = ds.Tables("data")
        For Each row As DataGridViewRow In Me.dgv.Rows
            row.Cells(0).Value = row.Index + 1
        Next
        kon.Close()
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim i As Integer
        Dim id As String
        i = dgv.CurrentRow.Index
        id = CStr(dgv.Rows.Item(i).Cells(1).Value)

        'Jika diklik tombol edit
        If e.ColumnIndex = 4 Then
            FormTambahEditBuku.idpn = id
            FormTambahEditBuku.penerbit.Text = CStr(dgv.Rows.Item(i).Cells(2).Value)
            FormTambahEditBuku.Show()
            Me.Dispose()
            FormMenu.Enabled = False
        End If
    End Sub

    'Private Sub Guna2TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2TextBox1.TextChanged
    'Call tampil_data("select * from table_pengarang1810005 where pengarang_nama1810005 like '%" & Guna2TextBox1.Text & "%' or pengarang_alamat1810005 like '%" & Guna2TextBox1.Text & "%'")
    'End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Me.Dispose()
    End Sub
End Class