Imports System.IO.Ports

Public Class Form4

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Dim registered As Boolean = registerStudent(rfid.Text, firstNametxt.Text, middleNametxt.Text, lastNametxt.Text, agetxt.Text)
        If registered Then
            rfid.Text = String.Empty
            firstNametxt.Text = String.Empty
            middleNametxt.Text = String.Empty
            lastNametxt.Text = String.Empty
            agetxt.Text = String.Empty
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SerialPort1.PortName = "COM12"
        SerialPort1.BaudRate = 9600
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.DataBits = 8
        SerialPort1.Handshake = Handshake.None

        Try
            SerialPort1.Open()
            MessageBox.Show("Connected")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        SetupGunaPlaceholder(rfid, "RFID")
        SetupGunaPlaceholder(firstNametxt, "First Name")
        SetupGunaPlaceholder(middleNametxt, "Middle Name")
        SetupGunaPlaceholder(lastNametxt, "Last Name")
        SetupGunaPlaceholder(agetxt, "age")
    End Sub

    Private Sub rfid_TextChanged(sender As Object, e As EventArgs) Handles rfid.TextChanged

    End Sub

    Private Sub SerialPort1_Datareceived(snder As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            If SerialPort1.IsOpen Then
                Dim buffer As String = SerialPort1.ReadExisting()

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

                        If Me.InvokeRequired Then
                            Me.Invoke(Sub() rfid.Text = uid)
                        Else
                            rfid.Text = uid
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error reading data: " & ex.Message)
        End Try

    End Sub
End Class