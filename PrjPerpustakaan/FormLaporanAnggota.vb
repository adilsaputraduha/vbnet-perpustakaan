Public Class FormLaporanAnggota
    Sub isicombo()
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from table_anggota1810005 order by anggota_id1810005"
        cek = perintah.ExecuteReader
        While cek.Read
            awalanggota.Items.Add(cek.Item("anggota_id1810005") & " - " & cek.Item("anggota_nama1810005"))
            akhiranggota.Items.Add(cek.Item("anggota_id1810005") & " - " & cek.Item("anggota_nama1810005"))
        End While
    End Sub
    Private Sub FormLaporanAnggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call isicombo()
    End Sub
End Class