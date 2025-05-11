Imports MySql.Data.MySqlClient

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If cn.State <> ConnectionState.Closed Then cn.Close()
        cn.Open()
        DataGridView1.Rows.Clear()
        cm = New MySqlCommand("SELECT * FROM rfid_students order by rfid, firstName, middleName, lastName, age", cn)
        dr = cm.ExecuteReader
        While dr.Read
            DataGridView1.Rows.Add(dr.Item(0).ToString,
                                   dr.Item(1).ToString,
                                   dr.Item(2).ToString,
                                   dr.Item(3).ToString,
                                   dr.Item(4).ToString)
        End While
        dr.Close()
        cn.Close()
    End Sub
End Class