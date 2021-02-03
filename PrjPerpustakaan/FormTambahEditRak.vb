Public Class FormTambahEditRak
    Sub bersih()
        id.Text = ""
        kode.Clear()
        kapasitas.Clear()
        lokasi.Clear()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        FormMenu.Enabled = True
        Me.Visible = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If btnSave.Text = "Simpan" Then
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "insert into table_rak1810005 (rak_kode1810005, rak_kapasitas1810005, " & _
                " rak_lokasi1810005) values ('" & kode.Text & "','" & kapasitas.Text & "','" & lokasi.Text & "')"
            perintah.ExecuteNonQuery()
            kon.Close()

            FormMenu.Enabled = True
            Me.Visible = False

            FormRak.dgv.Columns.Clear()
            Call FormRak.tampil_data("select * from table_rak1810005")
            Call FormRak.buat_tombol()
            Call FormRak.set_dg()

            MsgBox("Data Berhasil Di Simpan", MsgBoxStyle.Information, "Informasi")

        ElseIf btnSave.Text = "Edit" Then
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "update table_rak1810005 set rak_kapasitas1810005='" & kapasitas.Text & "', " & _
                " rak_lokasi1810005='" & lokasi.Text & "' where rak_kode1810005='" & kode.Text & "'"
            perintah.ExecuteNonQuery()
            kon.Close()

            FormMenu.Enabled = True
            Me.Visible = False

            FormRak.dgv.Columns.Clear()
            Call FormRak.tampil_data("select * from table_rak1810005")
            Call FormRak.buat_tombol()
            Call FormRak.set_dg()

            MsgBox("Data Berhasil Di Update", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub nama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles kode.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                kapasitas.Focus()
        End Select
    End Sub
End Class