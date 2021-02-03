Public Class FormTambahEditBuku
    Public idpn, idpg As String

    Sub bersih()
        id.Text = ""
        kode.Clear()
        penerbit.Clear()
        pengarang.Clear()
        rak.Text = ""
        judul.Clear()
        tahun.Clear()
    End Sub

    Sub isicomborak()
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from table_rak1810005 order by rak_kode1810005"
        cek = perintah.ExecuteReader
        While cek.Read
            rak.Items.Add(cek.Item("rak_kode1810005") & " - Kapasitas = " & cek.Item("rak_kapasitas1810005"))
        End While
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        FormMenu.Enabled = True
        Me.Visible = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim a As String = rak.SelectedItem
        a = a.Substring(0, 4)

        If btnSave.Text = "Simpan" Then
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "insert into table_buku1810005 (buku_id1810005, buku_judul1810005, buku_idpenerbit1810005, buku_idpengarang1810005, " & _
                " buku_idrak1810005, buku_tahun1810005, buku_jumlah1810005, buku_tanggalpengadaan1810005) values " & _
                "('" & kode.Text & "','" & judul.Text & "','" & idpn & "','" & idpg & "','" & a & "','" & tahun.Text & "','" & jumlah.Text & "','" & Format(tgl.Value, "yyyy-MM-dd") & "')"
            perintah.ExecuteNonQuery()
            kon.Close()

            FormMenu.Enabled = True
            Me.Visible = False

            FormBuku.dgv.Columns.Clear()
            Call FormBuku.tampil_data("select nourut, buku_id1810005, buku_judul1810005, buku_jumlah1810005 from table_buku1810005")
            Call FormBuku.buat_tombol()
            Call FormBuku.set_dg()

            MsgBox("Data Berhasil Di Simpan", MsgBoxStyle.Information, "Informasi")

        ElseIf btnSave.Text = "Edit" Then
            kon.Close()
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "update table_buku1810005 set buku_judul1810005='" & judul.Text & "', " & _
                " buku_idpenerbit1810005='" & idpn & "', buku_idpengarang1810005='" & idpg & "', " & _
                " buku_idrak1810005='" & a & "', buku_tahun1810005='" & tahun.Text & "', buku_jumlah1810005='" & jumlah.Text & "', " & _
                " buku_tanggalpengadaan1810005='" & Format(tgl.Value, "yyyy-MM-dd") & "' where buku_id1810005='" & kode.Text & "'"
            perintah.ExecuteNonQuery()
            kon.Close()

            FormMenu.Enabled = True
            Me.Visible = False

            FormBuku.dgv.Columns.Clear()
            Call FormBuku.tampil_data("select nourut, buku_id1810005, buku_judul1810005, buku_jumlah1810005 from table_buku1810005")
            Call FormBuku.buat_tombol()
            Call FormBuku.set_dg()

            MsgBox("Data Berhasil Di Update", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub judul_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles judul.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                tahun.Focus()
        End Select
    End Sub

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        FormCariDataPenerbit.Show()
        Call FormCariDataPenerbit.dgv.Columns.Clear()
        Call FormCariDataPenerbit.tampil_data("select * from table_penerbit1810005")
        Call FormCariDataPenerbit.buat_tombol()
        Call FormCariDataPenerbit.set_dg()
    End Sub

    Private Sub Guna2Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button2.Click
        FormCariDataPengarang.Show()
        Call FormCariDataPengarang.dgv.Columns.Clear()
        Call FormCariDataPengarang.tampil_data("select * from table_pengarang1810005")
        Call FormCariDataPengarang.buat_tombol()
        Call FormCariDataPengarang.set_dg()
    End Sub

    Private Sub FormTambahEditBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call isicomborak()
        penerbit.Enabled = False
        pengarang.Enabled = False

    End Sub

    Private Sub kode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles kode.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                kon.Close()
                kon.Open()
                perintah.Connection = kon
                perintah.CommandType = CommandType.Text
                perintah.CommandText = "select * from table_buku1810005 where buku_id1810005='" & kode.Text & "'"
                cek = perintah.ExecuteReader
                cek.Read()
                If cek.HasRows Then
                    MsgBox("Username sudah ada", MsgBoxStyle.Information, "Informasi")
                    kode.Clear()
                    kode.Focus()
                Else
                    judul.Focus()
                End If
                kon.Close()
        End Select
    End Sub

    Private Sub judul_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles judul.TextChanged

    End Sub
End Class