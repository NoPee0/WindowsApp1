Imports System.IO.Ports
Imports System.Web.UI.WebControls
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Module Module1
    Public WithEvents SharedSerialPort As New IO.Ports.SerialPort()
    Public cn As New MySqlConnection
    Public cm As New MySqlCommand
    Public dr As MySqlDataReader

    Function ConnectToDB() As Boolean
        Try
            If cn.State <> ConnectionState.Closed Then cn.Close()

            cn.ConnectionString = "server=sql12.freesqldatabase.com;user id=sql12777652;password=vhBv2bsUYz;database=sql12777652;"

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

    Public Sub connectSerial(sPort As SerialPort, baudRate As ComboBox, port As ComboBox)

        sPort.PortName = port.Text
        sPort.BaudRate = Convert.ToInt32(baudRate.SelectedItem)
        sPort.Parity = Parity.None
        sPort.StopBits = StopBits.One
        sPort.DataBits = 8
        sPort.Handshake = Handshake.None

        Try
            sPort.Open()
            MessageBox.Show("Connected")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Public Sub rfidSerial(form As Form, rfidserial As SerialPort, rfidshow As Guna.UI2.WinForms.Guna2TextBox)
        AddHandler rfidserial.DataReceived, Sub(sender As Object, e As EventArgs)
                                                Try
                                                    If rfidserial.IsOpen Then
                                                        Dim buffer As String = rfidserial.ReadExisting()

                                                        If Not String.IsNullOrWhiteSpace(buffer) Then
                                                            Dim lines() As String = buffer.Split({ControlChars.Lf, ControlChars.Cr}, StringSplitOptions.RemoveEmptyEntries)
                                                            Dim uid As String = ""

                                                            For Each line In lines
                                                                If line.ToLower().Contains("uid:") Then
                                                                    Dim parts = line.Split(":"c)
                                                                    If parts.Length > 1 Then
                                                                        uid = parts(1).Trim()
                                                                        Exit For
                                                                    End If
                                                                End If
                                                            Next

                                                            If uid <> "" Then

                                                                If form.InvokeRequired Then
                                                                    form.Invoke(Sub() rfidshow.Text = uid)
                                                                Else
                                                                    rfidshow.Text = uid
                                                                    MessageBox.Show(rfidshow.Text)
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                Catch ex As Exception
                                                    MessageBox.Show("Error reading data: " & ex.Message)
                                                End Try
                                            End Sub
    End Sub

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


End Module
