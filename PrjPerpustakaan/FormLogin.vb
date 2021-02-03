Public Class FormLogin

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from table_admin1810005 where admin_id1810005='" & username.Text & "' and admin_password1810005=MD5('" & password.Text & "')"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            userLogin = username.Text
            FormMenu.username.Text = username.Text
            FormMenu.nama.Text = cek.Item("admin_nama1810005")
            Dim lev, result As String
            lev = cek.Item("admin_level1810005")
            If lev = "1" Then
                result = "Super Admin"
            ElseIf lev = "2" Then
                result = "Pustakawan"
            ElseIf lev = "3" Then
                result = "Kepala Perpustakaan"
            Else
                result = "Anggota"
            End If

            FormMenu.level.Text = result
            cek.Close()

            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "update table_admin1810005 set lastlogin=now() where admin_id1810005='" & username.Text & "'"
            perintah.ExecuteNonQuery()

            FormMenu.Show()
            Me.Hide()
        Else
            pesan.Text = "Username atau Password Salah"
            pesan.ForeColor = Color.Red
        End If
        kon.Close()
    End Sub

    Private Sub username_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles username.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                password.Focus()
        End Select
    End Sub

    Private Sub username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles username.TextChanged

    End Sub
End Class