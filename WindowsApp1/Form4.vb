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
        rfidSerial(Me, SharedSerialPort, rfid)

        SetupGunaPlaceholder(rfid, "RFID")
        SetupGunaPlaceholder(firstNametxt, "First Name")
        SetupGunaPlaceholder(middleNametxt, "Middle Name")
        SetupGunaPlaceholder(lastNametxt, "Last Name")
        SetupGunaPlaceholder(agetxt, "age")
    End Sub
End Class