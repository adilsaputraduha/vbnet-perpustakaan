Public Class FormTambahPeminjaman
    Dim subTotal As Double
    Dim totSel, jmlUang, kembali As Double
    Dim i, nomor As Integer
    Dim idBarang, noFaktur As String
    Public ipag As String

    Sub bersihsemua()
        id.Clear()
        anggota.Clear()
        kode.Clear()
        nama.Clear()
        stok.Clear()
        qty.Clear()
    End Sub
    Sub first()
        anggota.Enabled = False
        nama.Enabled = False
        stok.Enabled = False
        id.Enabled = False
    End Sub

    Sub set_dg()
        dgv.Columns(0).HeaderText = "No."
        dgv.Columns(1).HeaderText = "Kode Buku"
        dgv.Columns(2).HeaderText = "Judul Buku"
        dgv.Columns(3).HeaderText = "Stok"
        dgv.Columns(4).HeaderText = "Jumlah Pinjam"
        dgv.Columns(0).Width = 50
    End Sub

    Sub bersih()
        kode.Clear()
        nama.Clear()
        stok.Clear()
        qty.Clear()
    End Sub

    Sub tampilData()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select table_temp1810005.nourut, table_temp1810005.idbuku1810005, buku_judul1810005, buku_jumlah1810005, qty1810005 " & _
            "from table_temp1810005 join table_buku1810005 on idbuku1810005=buku_id1810005"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "data")
        dgv.DataSource = ds.Tables("data")
        For Each row As DataGridViewRow In Me.dgv.Rows
            row.Cells(0).Value = row.Index + 1
        Next
        kon.Close()
    End Sub

    Sub buat_tombol()
        'tombol pilih
        Dim btnHapus As New DataGridViewButtonColumn
        btnHapus.Name = "btnHapus"
        btnHapus.FlatStyle = FlatStyle.Popup
        btnHapus.DefaultCellStyle.ForeColor = Color.DarkCyan
        btnHapus.Text = "Hapus"
        btnHapus.Width = 5
        btnHapus.UseColumnTextForButtonValue = True
        dgv.Columns.Add(btnHapus)
    End Sub

    Sub buatNoFaktur()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select ifnull(max(right(peminjaman_id1810005,3)),0) as nourutt from table_peminjaman1810005"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            nomor = CInt(cek.Item("nourutt"))
            nomor = nomor + 1
            noFaktur = "FJ" + Format(nomor, "000")
            id.Text = noFaktur
        End If
        kon.Close()
    End Sub

    Sub cetakFaktur()
        Dim crfakturpj As New FakturPeminjaman
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "SELECT dpj_peminjamanid1810005, peminjaman_tglpinjam1810005, peminjaman_tglkembali1810005, anggota_nama1810005, " & _
        "admin_nama1810005, dpj_bukuid1810005, buku_judul1810005, penerbit_nama1810005, pengarang_nama1810005, dpj_qty1810005 " & _
        "FROM(table_peminjaman1810005) " & _
        "JOIN table_detailpeminjaman1810005 ON peminjaman_id1810005=dpj_peminjamanid1810005 " & _
        "JOIN table_buku1810005 ON buku_id1810005=dpj_bukuid1810005 " & _
        "JOIN table_pengarang1810005 ON pengarang_id1810005=buku_idpengarang1810005 " & _
        "JOIN table_penerbit1810005 ON penerbit_id1810005=buku_idpenerbit1810005 " & _
        "JOIN table_anggota1810005 ON anggota_id1810005=peminjaman_idanggota1810005 " & _
        "JOIN table_admin1810005 ON admin_id1810005=peminjaman_idadmin1810005 where dpj_peminjamanid1810005='" & id.Text & "'"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "fakturpj")
        crfakturpj.SetDataSource(ds.Tables("fakturpj"))
        FormCetakFakturPeminjaman.crv.ReportSource = crfakturpj
        FormCetakFakturPeminjaman.WindowState = FormWindowState.Maximized
        FormCetakFakturPeminjaman.Show()
        kon.Close()
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        FormCariBuku.Show()
        FormMenu.Enabled = False
        Call FormCariBuku.dgv.Columns.Clear()
        Call FormCariBuku.tampil_data("select table_buku1810005.nourut, buku_id1810005, buku_judul1810005, penerbit_nama1810005, " & _
                                      "pengarang_nama1810005, buku_idrak1810005, buku_jumlah1810005 from table_buku1810005 " & _
                                      "join table_penerbit1810005 on buku_idpenerbit1810005=penerbit_id1810005 join " & _
                                      "table_pengarang1810005 on buku_idpengarang1810005=pengarang_id1810005")
        Call FormCariBuku.buat_tombol()
        Call FormCariBuku.set_dg()
        FormCariBuku.idd = "0"
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        id.Clear()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from table_temp1810005"
        perintah.ExecuteNonQuery()
        kon.Close()

        Call buatNoFaktur()
        dgv.Columns.Clear()
        Call tampilData()
        Call buat_tombol()
        Call set_dg()
    End Sub

    Private Sub kode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles kode.KeyPress
        If e.KeyChar = Chr(13) Then
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "select * from table_buku1810005 where buku_id1810005='" & kode.Text & "'"
            cek = perintah.ExecuteReader
            cek.Read()
            If cek.HasRows Then
                idBarang = CStr(cek.Item("buku_id1810005"))
                nama.Text = CStr(cek.Item("buku_judul1810005"))
                stok.Text = CStr(cek.Item("buku_jumlah1810005"))
                qty.Focus()
            Else
                MsgBox("Data Tidak Ditemukan")
                kode.Clear()
                kode.Focus()
            End If
            kon.Close()
        End If
    End Sub

    Private Sub qty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles qty.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnOk_Click(e, CType(AcceptButton, EventArgs))
        End Select
    End Sub

    Private Sub qty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qty.TextChanged
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into table_temp1810005 (idbuku1810005, qty1810005) values('" & kode.Text & "','" & qty.Text & "')"
        perintah.ExecuteNonQuery()
        kon.Close()

        dgv.Columns.Clear()
        Call tampilData()
        Call buat_tombol()
        Call set_dg()
        Call bersih()
    End Sub

    Private Sub kode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kode.TextChanged

    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim i As Integer
        Dim id, n As String
        i = dgv.CurrentRow.Index
        id = CStr(dgv.Rows.Item(i).Cells(1).Value)
        n = CStr(dgv.Rows.Item(i).Cells(2).Value)

        If e.ColumnIndex = 5 Then
            Dim x As Byte
            x = CByte(MsgBox("Hapus data dengan kode " + id + " dan nama " + n, CType(MsgBoxStyle.Critical + vbYesNo, MsgBoxStyle), "Konfirmasi"))
            If x = vbYes Then
                kon.Open()
                perintah.Connection = kon
                perintah.CommandType = CommandType.Text
                perintah.CommandText = "delete from table_temp1810005 where idbuku1810005='" & id & "'"
                perintah.ExecuteNonQuery()
                kon.Close()

                dgv.Columns.Clear()
                Call tampilData()
                Call buat_tombol()
                Call set_dg()
            End If
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        With FormPeminjaman
            .TopLevel = False
            FormMenu.pnDashboard.Controls.Add(FormPeminjaman)
            .BringToFront()
            .Show()
        End With
        Call bersihsemua()
        Call FormPeminjaman.dgv.Columns.Clear()
        Call FormPeminjaman.tampil_data("select table_peminjaman1810005.nourut, peminjaman_id1810005, peminjaman_tglpinjam1810005, peminjaman_tglkembali1810005, " & _
                                  "COUNT(dpj_bukuid1810005) as jmlitem from table_peminjaman1810005 join table_detailpeminjaman1810005 " & _
                                  "on peminjaman_id1810005=dpj_peminjamanid1810005 group by dpj_peminjamanid1810005")
        Call FormPeminjaman.buat_tombol()
        Call FormPeminjaman.set_dg()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into table_peminjaman1810005 (peminjaman_id1810005, peminjaman_tglpinjam1810005, " & _
            "peminjaman_tglkembali1810005, peminjaman_idanggota1810005, peminjaman_idadmin1810005) values ('" & id.Text & "'" & _
            ",'" & Format(awal.Value, "yyyy-MM-dd") & "','" & Format(akhir.Value, "yyyy-MM-dd") & "','" & ipag & "','USER003')"
        perintah.ExecuteNonQuery()
        kon.Close()

        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into table_detailpeminjaman1810005(dpj_peminjamanid1810005, dpj_bukuid1810005, dpj_qty1810005) " & _
            "select '" & id.Text & "',idbuku1810005, qty1810005 from table_temp1810005"
        perintah.ExecuteNonQuery()
        kon.Close()

        MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Informasi")
        Call cetakFaktur()
        Call bersihsemua()
        id.Clear()

        btnTambah_Click(e, CType(AcceptButton, EventArgs))
    End Sub

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        FormCariAnggota.Show()
        FormMenu.Enabled = False
        Call FormCariAnggota.dgv.Columns.Clear()
        Call FormCariAnggota.tampil_data("select * from table_anggota1810005")
        Call FormCariAnggota.buat_tombol()
        Call FormCariAnggota.set_dg()
    End Sub

    Private Sub FormTambahPeminjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call first()
    End Sub

    Private Sub anggota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles anggota.TextChanged

    End Sub

    Private Sub id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id.TextChanged

    End Sub
End Class