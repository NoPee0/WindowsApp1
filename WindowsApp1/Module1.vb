Imports System.IO.Ports
Imports System.Web.UI.WebControls
Imports MySql.Data.MySqlClient

Module Module1
    Public cn As New MySqlConnection
    Public cm As New MySqlCommand
    Public dr As MySqlDataReader

    Function ConnectToDB() As Boolean
        Try
            If cn.State <> ConnectionState.Closed Then cn.Close()

            cn.ConnectionString = "server=sql102.infinityfree.com;user id=if0_38953241;password=y3UFOGWUJTys8jQ;database=if0_38953241_rfid_students;"

            cn.Open()

            If cn.State = ConnectionState.Open Then
                MessageBox.Show("Connected to database successfully!")
                Return True
            Else
                MessageBox.Show("Connection failed!")
                Return False
            End If

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("Database Error: " & ex.Message)
            Return False
        Catch ex As Exception
            MessageBox.Show("General Error: " & ex.Message)
            Return False
        End Try
    End Function

    Function registerStudent(rfid As String, fName As String, mName As String, lName As String, age As String) As Boolean
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()

            Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM rfid_students WHERE rfid = @rfid", cn)
            checkCmd.Parameters.AddWithValue("@rfid", rfid)
            Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If count > 0 Then
                MsgBox("RFID already registered!")
                Return False
            End If

            Dim sql As String = "INSERT INTO rfid_students(rfid, firstName, middleName, lastName, age) VALUES(@rfid, @firstName, @middleName, @lastName, @age)"
            cm = New MySqlCommand(sql, cn)
            With cm
                .Parameters.AddWithValue("@rfid", rfid)
                .Parameters.AddWithValue("@firstName", fName)
                .Parameters.AddWithValue("@middleName", mName)
                .Parameters.AddWithValue("@lastName", lName)
                .Parameters.AddWithValue("@age", age)
                .ExecuteNonQuery()
            End With

            MsgBox("Register Complete")
            Return True
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        Finally
            cn.Close()
        End Try
    End Function

    Public Sub SetupGunaPlaceholder(txt As Guna.UI2.WinForms.Guna2TextBox, placeholder As String)
        txt.PlaceholderText = placeholder


        AddHandler txt.Enter, Sub(sender As Object, e As EventArgs)
                                  If txt.Text = placeholder AndAlso txt.ForeColor = Color.FromArgb(193, 200, 207) Then
                                      txt.Text = ""
                                      txt.ForeColor = Color.Black
                                  End If
                              End Sub


        AddHandler txt.Leave, Sub(sender As Object, e As EventArgs)
                                  If String.IsNullOrWhiteSpace(txt.Text) Then
                                      txt.Text = placeholder
                                      txt.ForeColor = Color.FromArgb(193, 200, 207)
                                  End If
                              End Sub


        If String.IsNullOrWhiteSpace(txt.Text) Then
            txt.Text = placeholder
            txt.ForeColor = Color.FromArgb(193, 200, 207)
        End If
    End Sub


    Public Sub searchPort(lb As ListBox)
        Try
            Dim ports As String() = SerialPort.GetPortNames()
            lb.Items.Clear()

            If ports.Length > 0 Then
                lb.Items.AddRange(ports.Cast(Of Object)().ToArray())
            Else
                lb.Items.Add("No COM ports found")
            End If
        Catch ex As Exception
            MessageBox.Show("Error retrieving ports: " & ex.Message)
        End Try
    End Sub

End Module
