Public Class FormLaporanMaster
    Sub buat_tombol()
        'tombol edit
        Dim btnPilih As New DataGridViewButtonColumn
        btnPilih.Name = "btnPilih"
        btnPilih.FlatStyle = FlatStyle.Popup
        btnPilih.DefaultCellStyle.ForeColor = Color.DarkCyan
        btnPilih.HeaderText = ""
        btnPilih.Text = "Pilih"
        btnPilih.Width = 5
        btnPilih.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        btnPilih.UseColumnTextForButtonValue = True
        dgv.Columns.Add(btnPilih)

        dgv.Columns(0).Width = 50
        dgv.Columns(1).Width = 650
        For Each row As DataGridViewRow In Me.dgv.Rows
            row.Cells(0).Value = row.Index + 1
        Next
    End Sub

    Private Sub FormLaporanMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgv.Rows.Add(4)
        dgv.Rows(0).Cells(1).Value = "Laporan Data Buku Berdasarkan Penerbit"
        dgv.Rows(1).Cells(1).Value = "Laporan Data Buku Berdasarkan Pengarang"
        dgv.Rows(2).Cells(1).Value = "Laporan Data Buku Berdasarkan Rak"
        dgv.Rows(3).Cells(1).Value = "Laporan Data Anggota"
        Call buat_tombol()
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim i As Integer
        Dim id As String
        i = dgv.CurrentRow.Index
        id = CStr(dgv.Rows.Item(i).Cells(0).Value)

        If e.ColumnIndex = 2 Then
            If id = "1" Then
                FormLaporanBukuPn.Show()
                FormMenu.Enabled = False
            ElseIf id = "2" Then
                FormLaporanBukuPg.Show()
                FormMenu.Enabled = False
            ElseIf id = "3" Then
                FormLaporanBukuRak.Show()
                FormMenu.Enabled = False
            ElseIf id = "4" Then
                FormLaporanAnggota.Show()
                FormMenu.Enabled = False
            End If
        End If
    End Sub
End Class