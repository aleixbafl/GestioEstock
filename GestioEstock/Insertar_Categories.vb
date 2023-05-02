Public Class Insertar_Categories
    Private Sub cursorPuntero(obj As Object) 'Metode per a cambiar el curasor de puntero
        Cursor = Cursors.Hand
    End Sub
    Private Sub cursorPrincimi(obj As Object) 'Metode per a cambiar el cursor al seu estat original
        Cursor = Cursors.Default
    End Sub

    Private Sub tanca_Click(sender As Object, e As EventArgs) Handles tanca.Click
        Application.Exit()  'Finalitzar el programa
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles minimitzar.Click
        Me.WindowState = FormWindowState.Minimized  'Minimitzar la finestra
    End Sub

    Dim mouse_offset As Point

    Private Sub barraSuperiorMoure_MouseUp(sender As Object, e As MouseEventArgs) Handles barraSuperiorMoure.MouseUp
        Me.ResumeLayout()
    End Sub

    Private Sub Menu_Categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tanca.BringToFront()
        minimitzar.BringToFront()
    End Sub

End Class