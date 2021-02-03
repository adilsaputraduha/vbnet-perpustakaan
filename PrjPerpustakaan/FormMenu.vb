Public Class FormMenu

    Sub multiuser()
        If level.Text = "Anggota" Then
            'sidebar
            Guna2Button17.Enabled = False
            Guna2Button15.Enabled = False
            Guna2Button16.Enabled = False
            btnLapPen.Enabled = False
            btnReportBarang.Enabled = False
            Guna2Button14.Enabled = False
            btnPenjualan.Enabled = False
            Guna2Button3.Enabled = False
            Guna2Button1.Enabled = False
            btnpenerbit.Enabled = False
            'sidebar up
            Guna2Button13.Enabled = False
            Guna2Button12.Enabled = False
            Guna2Button4.Enabled = False
            Guna2Button2.Enabled = False
            Guna2Button18.Enabled = False
            Guna2Button19.Enabled = False
            Guna2Button11.Enabled = False
            Guna2Button20.Enabled = False
            Guna2Button10.Enabled = False
            Guna2Button9.Enabled = False

        ElseIf level.Text = "Pustakawan" Then
            btnPenjualan.Enabled = False
            Guna2Button18.Enabled = False
        ElseIf level.Text = "Kepala Perpustakaan" Then
            Guna2Button9.Enabled = False
            Guna2Button10.Enabled = False
            Guna2Button15.Enabled = False
            Guna2Button16.Enabled = False
        Else

        End If
    End Sub

    Private Sub btnpengarang_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpengarang.Click
        sidebarup.Width = 256
        sidebarpu.Width = 0
    End Sub

    Private Sub Guna2Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button21.Click
        sidebarup.Width = 0
        sidebarpu.Width = 93
    End Sub

    Private Sub FormMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With FormDashboard
            .TopLevel = False
            pnDashboard.Controls.Add(FormDashboard)
            .BringToFront()
            .Show()
        End With
        Call multiuser()
        Call FormDashboard.tampil_data("select admin_nama1810005, lastlogin from table_admin1810005")
        Call FormDashboard.set_dg()
        Call FormDashboard.tampil_data1("select buku_judul1810005 from table_buku1810005")
        Call FormDashboard.set_dg1()
    End Sub

    Private Sub Guna2Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button17.Click
        With FormPengarang
            .TopLevel = False
            pnDashboard.Controls.Add(FormPengarang)
            .BringToFront()
            .Show()
        End With
        Call FormPengarang.dgv.Columns.Clear()
        Call FormPengarang.tampil_data("select * from table_pengarang1810005")
        Call FormPengarang.buat_tombol()
        Call FormPengarang.set_dg()
    End Sub

    Private Sub btnpenerbit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpenerbit.Click
        With FormPenerbit
            .TopLevel = False
            pnDashboard.Controls.Add(FormPenerbit)
            .BringToFront()
            .Show()
        End With
        Call FormPenerbit.dgv.Columns.Clear()
        Call FormPenerbit.tampil_data("select * from table_penerbit1810005")
        Call FormPenerbit.buat_tombol()
        Call FormPenerbit.set_dg()
    End Sub

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        With FormRak
            .TopLevel = False
            pnDashboard.Controls.Add(FormRak)
            .BringToFront()
            .Show()
        End With
        Call FormRak.dgv.Columns.Clear()
        Call FormRak.tampil_data("select * from table_rak1810005")
        Call FormRak.buat_tombol()
        Call FormRak.set_dg()
    End Sub

    Private Sub Guna2Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button14.Click
        With FormAnggota
            .TopLevel = False
            pnDashboard.Controls.Add(FormAnggota)
            .BringToFront()
            .Show()
        End With
        Call FormAnggota.dgv.Columns.Clear()
        Call FormAnggota.tampil_data("select * from table_anggota1810005")
        Call FormAnggota.buat_tombol()
        Call FormAnggota.set_dg()
    End Sub

    Private Sub Guna2Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button3.Click
        With FormBuku
            .TopLevel = False
            pnDashboard.Controls.Add(FormBuku)
            .BringToFront()
            .Show()
        End With
        Call FormBuku.dgv.Columns.Clear()
        Call FormBuku.tampil_data("select nourut, buku_id1810005, buku_judul1810005, buku_jumlah1810005 from table_buku1810005")
        Call FormBuku.buat_tombol()
        Call FormBuku.set_dg()
    End Sub

    Private Sub Guna2Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button7.Click
        With FormDashboard
            .TopLevel = False
            pnDashboard.Controls.Add(FormDashboard)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button18.Click
        With FormAdmin
            .TopLevel = False
            pnDashboard.Controls.Add(FormAdmin)
            .BringToFront()
            .Show()
        End With
        Call FormAdmin.dgv.Columns.Clear()
        Call FormAdmin.tampil_data("select nourut, admin_id1810005, admin_nama1810005, admin_level1810005, admin_alamat1810005, admin_notelp1810005 from table_admin1810005")
        Call FormAdmin.buat_tombol()
        Call FormAdmin.set_dg()
    End Sub

    Private Sub btnPenjualan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPenjualan.Click
        With FormAdmin
            .TopLevel = False
            pnDashboard.Controls.Add(FormAdmin)
            .BringToFront()
            .Show()
        End With
        Call FormAdmin.dgv.Columns.Clear()
        Call FormAdmin.tampil_data("select nourut, admin_id1810005, admin_nama1810005, admin_level1810005, admin_alamat1810005, admin_notelp1810005 from table_admin1810005")
        Call FormAdmin.buat_tombol()
        Call FormAdmin.set_dg()
    End Sub

    Private Sub Guna2Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button13.Click
        With FormPenerbit
            .TopLevel = False
            pnDashboard.Controls.Add(FormPenerbit)
            .BringToFront()
            .Show()
        End With
        Call FormPenerbit.dgv.Columns.Clear()
        Call FormPenerbit.tampil_data("select * from table_penerbit1810005")
        Call FormPenerbit.buat_tombol()
        Call FormPenerbit.set_dg()
    End Sub

    Private Sub Guna2Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button12.Click
        With FormPengarang
            .TopLevel = False
            pnDashboard.Controls.Add(FormPengarang)
            .BringToFront()
            .Show()
        End With
        Call FormPengarang.dgv.Columns.Clear()
        Call FormPengarang.tampil_data("select * from table_pengarang1810005")
        Call FormPengarang.buat_tombol()
        Call FormPengarang.set_dg()
    End Sub

    Private Sub Guna2Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button4.Click
        With FormRak
            .TopLevel = False
            pnDashboard.Controls.Add(FormRak)
            .BringToFront()
            .Show()
        End With
        Call FormRak.dgv.Columns.Clear()
        Call FormRak.tampil_data("select * from table_rak1810005")
        Call FormRak.buat_tombol()
        Call FormRak.set_dg()
    End Sub

    Private Sub Guna2Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button2.Click
        With FormBuku
            .TopLevel = False
            pnDashboard.Controls.Add(FormBuku)
            .BringToFront()
            .Show()
        End With
        Call FormBuku.dgv.Columns.Clear()
        Call FormBuku.tampil_data("select nourut, buku_id1810005, buku_judul1810005, buku_jumlah1810005 from table_buku1810005")
        Call FormBuku.buat_tombol()
        Call FormBuku.set_dg()
    End Sub

    Private Sub Guna2Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button19.Click
        With FormAnggota
            .TopLevel = False
            pnDashboard.Controls.Add(FormAnggota)
            .BringToFront()
            .Show()
        End With
        Call FormAnggota.dgv.Columns.Clear()
        Call FormAnggota.tampil_data("select * from table_anggota1810005")
        Call FormAnggota.buat_tombol()
        Call FormAnggota.set_dg()
    End Sub

    Private Sub btnReportBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportBarang.Click
        With FormPeminjaman
            .TopLevel = False
            pnDashboard.Controls.Add(FormPeminjaman)
            .BringToFront()
            .Show()
        End With
        Call FormPeminjaman.dgv.Columns.Clear()
        Call FormPeminjaman.tampil_data("select table_peminjaman1810005.nourut, peminjaman_id1810005, peminjaman_tglpinjam1810005, peminjaman_tglkembali1810005, " & _
                                  "COUNT(dpj_bukuid1810005) as jmlitem from table_peminjaman1810005 join table_detailpeminjaman1810005 " & _
                                  "on peminjaman_id1810005=dpj_peminjamanid1810005 group by dpj_peminjamanid1810005")
        Call FormPeminjaman.buat_tombol()
        Call FormPeminjaman.set_dg()
    End Sub

    Private Sub btnLapPen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLapPen.Click
        With FormPengembalian
            .TopLevel = False
            pnDashboard.Controls.Add(FormPengembalian)
            .BringToFront()
            .Show()
        End With
        Call FormPengembalian.dgv.Columns.Clear()
        Call FormPengembalian.tampil_data("select table_pengembalian1810005.nourut, pengembalian_id1810005, pengembalian_peminjamanid1810005, pengembalian_tglkembali1810005, " & _
                                  "COUNT(dpb_bukuid1810005) as jmlitem from table_pengembalian1810005 join table_detailpengembalian1810005 " & _
                                  "on pengembalian_id1810005=dpb_pengembalianid1810005 group by dpb_pengembalianid1810005")
        Call FormPengembalian.buat_tombol()
        Call FormPengembalian.set_dg()
    End Sub

    Private Sub Guna2Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button16.Click
        With FormLaporanMaster
            .TopLevel = False
            pnDashboard.Controls.Add(FormLaporanMaster)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button15.Click
        With FormLaporanTransaksi
            .TopLevel = False
            pnDashboard.Controls.Add(FormLaporanTransaksi)
            .BringToFront()
            .Show()
        End With
    End Sub

End Class
