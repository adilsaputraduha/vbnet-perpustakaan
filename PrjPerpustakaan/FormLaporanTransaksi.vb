Public Class FormLaporanTransaksi
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim tglawal As String
        Dim tglakhir As String

        tglawal = Format(awalpm.Value, "yyyy-MM-dd")
        tglakhir = Format(akhirpm.Value, "yyyy-MM-dd")

        kon.Close()
        Dim lappeminjaman As New LapPeminjaman
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "SELECT peminjaman_id1810005, peminjaman_tglpinjam1810005, peminjaman_tglkembali1810005, anggota_nama1810005, COUNT(dpj_bukuid1810005) AS jmlitem " & _
                "FROM table_peminjaman1810005 JOIN table_detailpeminjaman1810005 ON peminjaman_id1810005=dpj_peminjamanid1810005 " & _
                "JOIN table_anggota1810005 ON anggota_id1810005=peminjaman_idanggota1810005 WHERE peminjaman_tglpinjam1810005 BETWEEN " & _
                "'" & tglawal & "' AND '" & tglakhir & "' GROUP BY peminjaman_id1810005"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "peminjaman")
        lappeminjaman.SetDataSource(ds.Tables("peminjaman"))
        FormCetakLapPeminjaman.crv.ReportSource = lappeminjaman
        FormCetakLapPeminjaman.WindowState = FormWindowState.Maximized
        FormCetakLapPeminjaman.Show()
        kon.Close()
    End Sub

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        Dim tglawal As String
        Dim tglakhir As String

        tglawal = Format(awalpb.Value, "yyyy-MM-dd")
        tglakhir = Format(akhirpb.Value, "yyyy-MM-dd")

        kon.Close()
        Dim lappengembalian As New LapPengembalian
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "SELECT pengembalian_id1810005, pengembalian_tglkembali1810005, anggota_nama1810005, COUNT(dpb_bukuid1810005) AS jmlitem " & _
            "FROM table_pengembalian1810005 JOIN table_detailpengembalian1810005 ON pengembalian_id1810005=dpb_pengembalianid1810005 " & _
            "JOIN table_peminjaman1810005 ON peminjaman_id1810005=pengembalian_peminjamanid1810005 " & _
            "JOIN table_anggota1810005 ON anggota_id1810005=peminjaman_idanggota1810005 WHERE pengembalian_tglkembali1810005 BETWEEN " & _
            "'" & tglawal & "' AND '" & tglakhir & "' GROUP BY pengembalian_id1810005"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "pengembalian")
        lappengembalian.SetDataSource(ds.Tables("pengembalian"))
        FormCetakLapPengembalian.crv.ReportSource = lappengembalian
        FormCetakLapPengembalian.WindowState = FormWindowState.Maximized
        FormCetakLapPengembalian.Show()
        kon.Close()
    End Sub
End Class