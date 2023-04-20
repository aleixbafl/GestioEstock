Public Class Login
    Private Sub cursorPuntero(obj As Object)
        Cursor = Cursors.Hand
    End Sub
    Private Sub cursorPrincimi(obj As Object)
        Cursor = Cursors.Default
    End Sub

    Private Sub tanca_MouseEnter(sender As Object, e As EventArgs) Handles tanca.MouseEnter
        cursorPuntero(tanca)
    End Sub

    Private Sub tanca_MouseLeave(sender As Object, e As EventArgs) Handles tanca.MouseLeave
        cursorPrincimi(tanca)
    End Sub

    Private Sub tanca_Click(sender As Object, e As EventArgs) Handles tanca.Click
        Application.Exit()
    End Sub
    Private Sub minimitzar_MouseEnter(sender As Object, e As EventArgs) Handles minimitzar.MouseEnter
        cursorPuntero(tanca)
    End Sub

    Private Sub minimitzar_MouseLeave(sender As Object, e As EventArgs) Handles minimitzar.MouseLeave
        cursorPrincimi(tanca)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles minimitzar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
