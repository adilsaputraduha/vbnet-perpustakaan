Public Class FormPeminjaman
    Sub set_dg()
        dgv.Columns(0).HeaderText = "No."
        dgv.Columns(1).HeaderText = "No Faktur"
        dgv.Columns(2).HeaderText = "Tanggal Pinjam"
        dgv.Columns(3).HeaderText = "Tanggal Kembali"
        dgv.Columns(4).HeaderText = "Total Pinjam"
        dgv.Columns(0).Width = 50
    End Sub

    Sub buat_tombol()
        Dim btnDetail As New DataGridViewButtonColumn
        btnDetail.Name = "btnDetail"
        btnDetail.FlatStyle = FlatStyle.Popup
        btnDetail.DefaultCellStyle.ForeColor = Color.Red
        btnDetail.HeaderText = ""
        btnDetail.Text = "Detail"
        btnDetail.Width = 5
        btnDetail.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        btnDetail.UseColumnTextForButtonValue = True
        dgv.Columns.Add(btnDetail)
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

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        With FormTambahPeminjaman
            .TopLevel = False
            FormMenu.pnDashboard.Controls.Add(FormTambahPeminjaman)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim i As Integer
        Dim id, n As String
        i = dgv.CurrentRow.Index
        id = CStr(dgv.Rows.Item(i).Cells(1).Value)
        n = CStr(dgv.Rows.Item(i).Cells(2).Value)

        'Jika diklik tombol edit
        If e.ColumnIndex = 5 Then
            MsgBox("Masih dalam pengembangan")
        End If
    End Sub

    Private Sub Guna2TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2TextBox1.TextChanged
        'Call tampil_data("select * from table_pengarang1810005 where pengarang_nama1810005 like '%" & Guna2TextBox1.Text & "%' or pengarang_alamat1810005 like '%" & Guna2TextBox1.Text & "%'")
    End Sub
End Class