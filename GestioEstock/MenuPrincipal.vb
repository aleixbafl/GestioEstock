Public Class MenuPrincipal
    Private Sub cursorPuntero(obj As Object) 'Metode per a cambiar el curasor de puntero
        Cursor = Cursors.Hand
    End Sub
    Private Sub cursorPrincimi(obj As Object) 'Metode per a cambiar el cursor al seu estat original
        Cursor = Cursors.Default
    End Sub

    Private Sub tanca_MouseEnter(sender As Object, e As EventArgs) Handles tanca.MouseEnter
        cursorPuntero(tanca)
    End Sub

    Private Sub tanca_MouseLeave(sender As Object, e As EventArgs) Handles tanca.MouseLeave
        cursorPrincimi(tanca)
    End Sub

    Private Sub tanca_Click(sender As Object, e As EventArgs) Handles tanca.Click
        Application.Exit()  'Finalitzar el programa
    End Sub
    Private Sub minimitzar_MouseEnter(sender As Object, e As EventArgs)

    End Sub

    Private Sub minimitzar_MouseLeave(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized  'Minimitzar la finestra
    End Sub

    Dim mouse_offset As Point
    'Comprobe si el boto del ratoli es l'esquerra a l'hora de clicar la icona de cambiar el tamany de la finestra
    Private Sub adaptarFinestra_MouseDown(sender As Object, e As MouseEventArgs)

    End Sub
    'Aqui es lo que permet cambiar el tamany de la finestra
    Private Sub adaptarFinestra_MouseMove(sender As Object, e As MouseEventArgs) Handles adaptarFinestra.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Width = Cursor.Position.X - Me.Left
            Me.Height = Cursor.Position.Y - Me.Top
        End If
    End Sub
    'Quant clique a la barra superior
    Private Sub barraSuperiorMoure_MouseDown(sender As Object, e As MouseEventArgs) Handles barraSuperiorMoure.MouseDown
        If e.Button = MouseButtons.Left Then
            mouse_offset = New Point(e.Location.X, e.Location.Y)
            Me.SuspendLayout() ' Desactivar redimensionamiento de la ventana
        End If
    End Sub

    Private Sub barraSuperiorMoure_MouseMove(sender As Object, e As MouseEventArgs) Handles barraSuperiorMoure.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Left = Cursor.Position.X - mouse_offset.X
            Me.Top = Cursor.Position.Y - mouse_offset.Y
        End If
    End Sub

    Private Sub barraSuperiorMoure_MouseUp(sender As Object, e As MouseEventArgs)
        Me.ResumeLayout()

        minimitzar.BringToFront()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usuari As String = MenuPrinEmpleat.Usuari
        tanca.BringToFront()
        minimitzar.BringToFront()
        Dim consulta As String = "SELECT IF(a.ID_Usuari IS NOT NULL, 'Admin', 'Empleado') AS Rol FROM usuari u LEFT JOIN admin a ON u.ID_Usuari = a.ID_Usuari WHERE u.nomUsuari = '" & usuari & "';"
        Dim conn As New ConexioBD()
        conn.ObrirConexio()
        Dim resultatConsulta As DataTable = conn.EjecutarConsulta(consulta)
        conn.CerrarConexion()
        Dim ValorColumna As String = resultatConsulta.Rows(0)("Rol").ToString()
        If ValorColumna = "Empleado" Then
            Button4.Visible = False
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Menu_Productes.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Menu_Categories.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Menu_Usuaris.Show()
        Me.Hide()
    End Sub

    Private Sub tancaSessio_Click(sender As Object, e As EventArgs) Handles tancaSessio.Click
        MenuPrinEmpleat.Show()
        Me.Hide()
        MenuPrinEmpleat.Usuari = ""
    End Sub
End Class