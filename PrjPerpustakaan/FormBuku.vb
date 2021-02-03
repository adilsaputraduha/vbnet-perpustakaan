Public Class FormBuku
    Sub set_dg()
        dgv.Columns(0).HeaderText = "No."
        dgv.Columns(1).HeaderText = "Kode"
        dgv.Columns(2).HeaderText = "Judul"
        dgv.Columns(3).HeaderText = "Jumlah"

        dgv.Columns(0).Width = 50
        dgv.Columns(4).Width = 60
        dgv.Columns(5).Width = 60
        dgv.Columns(6).Width = 90
    End Sub

    Sub buat_tombol()
        'tombol edit
        Dim btnEdit As New DataGridViewButtonColumn
        btnEdit.Name = "btnEdit"
        btnEdit.FlatStyle = FlatStyle.Popup
        btnEdit.DefaultCellStyle.ForeColor = Color.DarkCyan
        btnEdit.HeaderText = ""
        btnEdit.Text = "Edit"
        btnEdit.Width = 5
        btnEdit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        btnEdit.UseColumnTextForButtonValue = True
        dgv.Columns.Add(btnEdit)

        'tombol delete
        Dim btnDelete As New DataGridViewButtonColumn
        btnDelete.Name = "btnDelete"
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.DefaultCellStyle.ForeColor = Color.Red
        btnDelete.HeaderText = ""
        btnDelete.Text = "Hapus"
        btnDelete.Width = 5
        btnDelete.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        btnDelete.UseColumnTextForButtonValue = True
        dgv.Columns.Add(btnDelete)

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
        FormTambahEditBuku.Show()
        FormMenu.Enabled = False
        FormTambahEditBuku.lblJudul.Text = "Tambah"
        FormTambahEditBuku.bersih()
        FormTambahEditBuku.btnSave.Text = "Simpan"
        FormTambahEditBuku.kode.Enabled = True
        FormTambahEditBuku.kode.Focus()
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim i As Integer
        Dim id, n As String
        i = dgv.CurrentRow.Index
        id = CStr(dgv.Rows.Item(i).Cells(1).Value)
        n = CStr(dgv.Rows.Item(i).Cells(2).Value)

        'Jika diklik tombol edit
        If e.ColumnIndex = 4 Then
            kon.Close()
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "select buku_judul1810005, buku_idpenerbit1810005, penerbit_nama1810005, buku_idpengarang1810005, " & _
                "pengarang_nama1810005, " & _
                "buku_idrak1810005, rak_kapasitas1810005, buku_tahun1810005, buku_jumlah1810005, buku_tanggalpengadaan1810005 " & _
                "from table_buku1810005 join table_rak1810005 on buku_idrak1810005=rak_kode1810005 join table_penerbit1810005 on " & _
                "penerbit_id1810005=buku_idpenerbit1810005 join table_pengarang1810005 on pengarang_id1810005=buku_idpengarang1810005 " & _
                "where buku_id1810005='" & id & "'"
            cek = perintah.ExecuteReader
            While cek.Read
                FormTambahEditBuku.kode.Text = id
                FormTambahEditBuku.judul.Text = (cek.Item("buku_judul1810005"))
                FormTambahEditBuku.idpn = (cek.Item("buku_idpenerbit1810005"))
                FormTambahEditBuku.penerbit.Text = (cek.Item("penerbit_nama1810005"))
                FormTambahEditBuku.idpg = (cek.Item("buku_idpengarang1810005"))
                FormTambahEditBuku.pengarang.Text = (cek.Item("pengarang_nama1810005"))
                FormTambahEditBuku.rak.Text = (cek.Item("buku_idrak1810005") & " - Kapasitas = " & cek.Item("rak_kapasitas1810005"))
                FormTambahEditBuku.tahun.Text = (cek.Item("buku_tahun1810005"))
                FormTambahEditBuku.jumlah.Text = (cek.Item("buku_jumlah1810005"))
                FormTambahEditBuku.tgl.Value = (cek.Item("buku_tanggalpengadaan1810005"))
            End While

            FormTambahEditBuku.btnSave.Text = "Edit"
            FormTambahEditBuku.lblJudul.Text = "Update"
            FormTambahEditBuku.Show()
            FormMenu.Enabled = False
        End If

        If e.ColumnIndex = 5 Then
            Dim x As Byte
            x = CByte(MsgBox("Hapus data dengan kode " + id + " dan judul " + n, CType(MsgBoxStyle.Critical + vbYesNo, MsgBoxStyle), "Konfirmasi"))
            If x = vbYes Then
                kon.Close()
                kon.Open()
                perintah.Connection = kon
                perintah.CommandType = CommandType.Text
                perintah.CommandText = "delete from table_buku1810005 where buku_id1810005='" & id & "'"
                perintah.ExecuteNonQuery()
                kon.Close()

                dgv.Columns.Clear()
                Call tampil_data("select nourut, buku_id1810005, buku_judul1810005, buku_jumlah1810005 from table_buku1810005")
                Call buat_tombol()
                Call set_dg()
            End If
        End If

        If e.ColumnIndex = 6 Then
            FormDetailBuku.show()
        End If
    End Sub

    Private Sub Guna2TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2TextBox1.TextChanged
        'Call tampil_data("select * from table_pengarang1810005 where pengarang_nama1810005 like '%" & Guna2TextBox1.Text & "%' or pengarang_alamat1810005 like '%" & Guna2TextBox1.Text & "%'")
    End Sub

    Private Sub FormBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class