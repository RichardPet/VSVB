Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Dette er kommentar legt til på GitHub
        MsgBox("Hello World...", MsgBoxStyle.Information)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTime.Text = Now

    End Sub
End Class
