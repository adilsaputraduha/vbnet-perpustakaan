Imports MySql.Data.MySqlClient
Module Module1
    Dim strkon As String = "server=localhost;uid=root;database=db_perpustakaan1810005"
    Public kon As New MySqlConnection(strkon)
    Public perintah As New MySqlCommand
    Public mda As New MySqlDataAdapter
    Public ds As New DataSet
    Public cek As MySqlDataReader
    Public userLogin As String
End Module
