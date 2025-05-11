
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectToDB()
    End Sub

    Private Sub LoadChildForm(childForm As Form)
        Panel1.Controls.Clear()

        With childForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
        End With

        Panel1.Controls.Add(childForm)
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        LoadChildForm(New Form4())
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        LoadChildForm(New Form3())
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        LoadChildForm(New Form5())
    End Sub

End Class
