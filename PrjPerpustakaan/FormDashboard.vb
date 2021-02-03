Public Class FormDashboard

    Sub set_dg()
        dgv.Columns(0).HeaderText = "Nama"
        dgv.Columns(1).HeaderText = "Last Login"
    End Sub

    Sub set_dg1()
        dgv1.Columns(0).HeaderText = "Judul"
    End Sub

    Sub tampil_data(ByVal sql As String)
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "data")
        dgv.DataSource = ds.Tables("data")
        kon.Close()
    End Sub

    Sub tampil_data1(ByVal sql As String)
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "data1")
        dgv1.DataSource = ds.Tables("data1")
        kon.Close()
    End Sub

    Private Sub FormDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class