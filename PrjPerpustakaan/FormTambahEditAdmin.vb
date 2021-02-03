Public Class FormTambahEditAdmin
    Sub bersih()
        id.Text = ""
        nama.Clear()
        alamat.Clear()
        notelp.Clear()
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
            perintah.CommandText = "insert into table_anggota1810005 (anggota_id1810005, anggota_nama1810005, " & _
                " anggota_jenkel1810005, anggota_alamat1810005, anggota_notelp1810005) values " & _
                "('" & id.Text & "','" & nama.Text & "','" & level.Text & "','" & alamat.Text & "','" & notelp.Text & "')"
            perintah.ExecuteNonQuery()
            kon.Close()

            FormMenu.Enabled = True
            Me.Visible = False

            FormAnggota.dgv.Columns.Clear()
            Call FormAnggota.tampil_data("select * from table_anggota1810005")
            Call FormAnggota.buat_tombol()
            Call FormAnggota.set_dg()

            MsgBox("Data Berhasil Di Simpan", MsgBoxStyle.Information, "Informasi")

        ElseIf btnSave.Text = "Edit" Then
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "update table_anggota1810005 set anggota_nama1810005='" & nama.Text & "', " & _
                " anggota_jenkel1810005='" & level.Text & "', anggota_alamat1810005='" & alamat.Text & "', " & _
                " anggota_notelp1810005='" & notelp.Text & "' where anggota_id1810005='" & id.Text & "'"
            perintah.ExecuteNonQuery()
            kon.Close()

            FormMenu.Enabled = True
            Me.Visible = False

            FormAnggota.dgv.Columns.Clear()
            Call FormAnggota.tampil_data("select * from table_anggota1810005")
            Call FormAnggota.buat_tombol()
            Call FormAnggota.set_dg()

            MsgBox("Data Berhasil Di Update", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub nama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nama.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                alamat.Focus()
        End Select
    End Sub

    Private Sub alamat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles alamat.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                notelp.Focus()
        End Select
    End Sub
End Class