Public Class Insert_Productes
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
    Private Sub minimitzar_MouseEnter(sender As Object, e As EventArgs) Handles minimitzar.MouseEnter
        cursorPuntero(minimitzar)
    End Sub

    Private Sub minimitzar_MouseLeave(sender As Object, e As EventArgs) Handles minimitzar.MouseLeave
        cursorPrincimi(minimitzar)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles minimitzar.Click
        Me.WindowState = FormWindowState.Minimized  'Minimitzar la finestra
    End Sub

    Dim mouse_offset As Point
    'Comprobe si el boto del ratoli es l'esquerra a l'hora de clicar la icona de cambiar el tamany de la finestra
    Private Sub adaptarFinestra_MouseDown(sender As Object, e As MouseEventArgs) Handles adaptarFinestra.MouseDown
        If e.Button = MouseButtons.Left Then
            mouse_offset = New Point(e.Location.X, e.Location.Y)
        End If
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

    Private Sub barraSuperiorMoure_MouseUp(sender As Object, e As MouseEventArgs) Handles barraSuperiorMoure.MouseUp
        Me.ResumeLayout()
    End Sub

    Private Sub Menu_Usuaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tanca.BringToFront()
        minimitzar.BringToFront()
        Dim conn As New ConexioBD()
        conn.ObrirConexio()
        taula.DataSource = conn.EjecutarConsulta("SELECT * FROM productes")
        conn.CerrarConexion()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Menu_Productes.Show()
        Me.Close()
    End Sub

    Private Sub barraSuperiorPartBotons_Click(sender As Object, e As EventArgs) Handles barraSuperiorPartBotons.Click

    End Sub

    Private Sub barraSuperiorMoure_Click(sender As Object, e As EventArgs) Handles barraSuperiorMoure.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Insertar.Click
        Dim conn As New ConexioBD()
        conn.ObrirConexio()
        Dim consulta As String = "INSERT INTO `productes`(`ID_Producte`, `ID_Categoria`, `preu`, `stock`, `marca`, `model`, `especificacions`, `imatge`, `actiu`) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "')"
        conn.EjecutarConsulta(consulta)
        taula.DataSource = conn.EjecutarConsulta("SELECT * FROM productes")
        conn.CerrarConexion()
    End Sub
End Class