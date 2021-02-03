Public Class FormTambahEditPengarang
    Sub bersih()
        id.Text = ""
        nama.Clear()
        alamat.Clear()
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
            perintah.CommandText = "insert into table_pengarang1810005 (pengarang_id1810005, pengarang_nama1810005, " & _
                " pengarang_alamat1810005) values ('" & id.Text & "','" & nama.Text & "','" & alamat.Text & "')"
            perintah.ExecuteNonQuery()
            kon.Close()

            FormMenu.Enabled = True
            Me.Visible = False

            FormPengarang.dgv.Columns.Clear()
            Call FormPengarang.tampil_data("select * from table_pengarang1810005")
            Call FormPengarang.buat_tombol()
            Call FormPengarang.set_dg()

            MsgBox("Data Berhasil Di Simpan", MsgBoxStyle.Information, "Informasi")

        ElseIf btnSave.Text = "Edit" Then
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "update table_pengarang1810005 set pengarang_nama1810005='" & nama.Text & "', " & _
                " pengarang_alamat1810005='" & alamat.Text & "' where pengarang_id1810005='" & id.Text & "'"
            perintah.ExecuteNonQuery()
            kon.Close()

            FormMenu.Enabled = True
            Me.Visible = False

            FormPengarang.dgv.Columns.Clear()
            Call FormPengarang.tampil_data("select * from table_pengarang1810005")
            Call FormPengarang.buat_tombol()
            Call FormPengarang.set_dg()

            MsgBox("Data Berhasil Di Update", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub nama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nama.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                alamat.Focus()
        End Select
    End Sub
End Class