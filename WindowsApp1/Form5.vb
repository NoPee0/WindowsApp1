Imports System.IO.Ports
Imports System.Web.UI.WebControls

Public Class Form5

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ports As String() = SerialPort.GetPortNames()
            ComboBox1.Items.Clear()

            If ports.Length > 0 Then
                ComboBox1.Items.AddRange(ports.Cast(Of Object)().ToArray())
            Else
                ComboBox1.Items.Add("No COM ports found")
            End If
        Catch ex As Exception
            MessageBox.Show("Error retrieving ports: " & ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        connectSerial(SharedSerialPort, ComboBox2, ComboBox1)
    End Sub


End Class