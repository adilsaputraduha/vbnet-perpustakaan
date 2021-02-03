Public Class FormAnggota
    Sub set_dg()
        dgv.Columns(0).HeaderText = "No."
        dgv.Columns(1).HeaderText = "Id"
        dgv.Columns(2).HeaderText = "Nama"
        dgv.Columns(3).HeaderText = "Jenis Kelamin"
        dgv.Columns(4).HeaderText = "Alamat"
        dgv.Columns(5).HeaderText = "No Telp"
        dgv.Columns(1).Visible = False
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
    End Sub

    Sub tampil_data(ByVal sql As String)
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
        FormTambahEditAnggota.Show()
        FormMenu.Enabled = False
        FormTambahEditAnggota.lblJudul.Text = "Tambah"
        FormTambahEditAnggota.bersih()
        FormTambahEditAnggota.btnSave.Text = "Simpan"
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim i As Integer
        Dim id, n As String
        i = dgv.CurrentRow.Index
        id = CStr(dgv.Rows.Item(i).Cells(1).Value)
        n = CStr(dgv.Rows.Item(i).Cells(2).Value)

        'Jika diklik tombol edit
        If e.ColumnIndex = 6 Then
            FormTambahEditAnggota.id.Text = id
            FormTambahEditAnggota.nama.Text = CStr(dgv.Rows.Item(i).Cells(2).Value)
            FormTambahEditAnggota.jenkel.Text = CStr(dgv.Rows.Item(i).Cells(3).Value)
            FormTambahEditAnggota.alamat.Text = CStr(dgv.Rows.Item(i).Cells(4).Value)
            FormTambahEditAnggota.notelp.Text = CStr(dgv.Rows.Item(i).Cells(5).Value)

            FormTambahEditAnggota.btnSave.Text = "Edit"
            FormTambahEditAnggota.lblJudul.Text = "Update"
            FormTambahEditAnggota.Show()
            FormMenu.Enabled = False
        End If

        If e.ColumnIndex = 7 Then
            Dim x As Byte
            x = CByte(MsgBox("Hapus data dengan kode " + id + " dan nama " + n, CType(MsgBoxStyle.Critical + vbYesNo, MsgBoxStyle), "Konfirmasi"))
            If x = vbYes Then
                kon.Open()
                perintah.Connection = kon
                perintah.CommandType = CommandType.Text
                perintah.CommandText = "delete from table_anggota1810005 where anggota_id1810005='" & id & "'"
                perintah.ExecuteNonQuery()
                kon.Close()

                dgv.Columns.Clear()
                Call tampil_data("select * from table_anggota1810005")
                Call buat_tombol()
                Call set_dg()
            End If
        End If
    End Sub

    Private Sub Guna2TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2TextBox1.TextChanged
        'Call tampil_data("select * from table_pengarang1810005 where pengarang_nama1810005 like '%" & Guna2TextBox1.Text & "%' or pengarang_alamat1810005 like '%" & Guna2TextBox1.Text & "%'")
    End Sub
End Class