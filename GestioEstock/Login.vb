Public Class Login

    Private Sub tanca_MouseEnter(sender As Object, e As EventArgs) Handles tanca.MouseEnter
        Cursor = Cursors.Hand
    End Sub
    Private Sub tanca_MouseLeave(sender As Object, e As EventArgs) Handles tanca.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub tanca_Click(sender As Object, e As EventArgs) Handles tanca.Click
        Application.Exit()
    End Sub
End Class
