Public Class Form2
    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs)
        Dim alreadyOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If TypeOf f Is Form1 Then
                f.BringToFront()
                alreadyOpen = True
                Exit For
            End If
        Next

        If Not alreadyOpen Then
            Dim f1 As New Form1()
            f1.Show()
        End If
    End Sub
End Class