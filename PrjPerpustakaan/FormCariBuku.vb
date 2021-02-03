Public Class FormCariBuku
    Public idd As String

    Sub set_dg()
        dgv.Columns(0).HeaderText = "No."
        dgv.Columns(1).HeaderText = "Kode Buku"
        dgv.Columns(2).HeaderText = "Judul"
        dgv.Columns(3).HeaderText = "Penerbit"
        dgv.Columns(4).HeaderText = "Pengarang"
        dgv.Columns(5).HeaderText = "Rak"
        dgv.Columns(6).HeaderText = "Jumlah"
        dgv.Columns(0).Width = "50"
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

        If idd = "1" Then
            If e.ColumnIndex = 7 Then
                FormTambahPengembalian.kode.Text = id
                FormTambahPengembalian.nama.Text = CStr(dgv.Rows.Item(i).Cells(2).Value)
                FormTambahPengembalian.stok.Text = CStr(dgv.Rows.Item(i).Cells(6).Value)
                FormTambahPengembalian.qty.Text = "1"
                FormTambahPengembalian.qty.Focus()

                FormMenu.Enabled = True
                Me.Visible = False
            End If
        ElseIf idd = "0" Then
            If e.ColumnIndex = 7 Then
                FormTambahPeminjaman.kode.Text = id
                FormTambahPeminjaman.nama.Text = CStr(dgv.Rows.Item(i).Cells(2).Value)
                FormTambahPeminjaman.stok.Text = CStr(dgv.Rows.Item(i).Cells(6).Value)
                FormTambahPeminjaman.qty.Text = "1"
                FormTambahPeminjaman.qty.Focus()

                FormMenu.Enabled = True
                Me.Visible = False
            End If
        Else
            MsgBox("tes")
        End If
    End Sub

    'Private Sub Guna2TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2TextBox1.TextChanged
    'Call tampil_data("select * from table_pengarang1810005 where pengarang_nama1810005 like '%" & Guna2TextBox1.Text & "%' or pengarang_alamat1810005 like '%" & Guna2TextBox1.Text & "%'")
    'End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        FormMenu.Enabled = True
        Me.Visible = False
    End Sub
End Class