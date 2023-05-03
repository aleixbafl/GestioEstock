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
        Dim conn As New ConexioBD()
        conn.ObrirConexio()
        taula.DataSource = conn.EjecutarConsulta("SELECT * FROM categories")
        conn.CerrarConexion()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If categoria.Text <> "" And pare.Text = "" Then
            Dim connect As New ConexioBD()
            connect.ObrirConexio()
            Dim consulta As String = "INSERT INTO `categories`(`categoria`) VALUES ('" & categoria.Text & "'); "
            connect.EjecutarConsulta(consulta)
            connect.CerrarConexion()
        ElseIf categoria.Text <> "" And pare.Text <> "" Then
            Dim connect As New ConexioBD()
            connect.ObrirConexio()
            Dim consulta As String = "INSERT INTO `categories`(`categoria`, `ID_Categoria_Pare`) VALUES ('" & categoria.Text & "','" & pare.Text & "')"
            connect.EjecutarConsulta(consulta)
            connect.CerrarConexion()
        Else
            MessageBox.Show("Com a mínim has d'introduir la categoria")
        End If
        Dim conn As New ConexioBD()
        conn.ObrirConexio()
        taula.DataSource = conn.EjecutarConsulta("SELECT * FROM categories")
        conn.CerrarConexion()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub
End Class