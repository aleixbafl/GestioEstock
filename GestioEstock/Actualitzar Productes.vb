Imports MySqlConnector

Public Class Actualitzar_Productes
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
        LoadDataGrid()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Menu_Productes.Show()
        Me.Close()
    End Sub

    Private Sub LoadDataGrid()
        Dim conn As New ConexioBD()
        conn.ObrirConexio()
        tabla.DataSource = conn.EjecutarConsulta("SELECT * FROM productes")
        conn.CerrarConexion()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim conn As New ConexioBD()
        Dim command As MySqlCommand = New MySqlCommand()
        command.CommandText = "UPDATE productes SET ID_Categoria = @ID_Categoria, preu = @preu, stock = @stock, marca = @marca, model = @model, especificacions = @especificacions, imatge = @imatge, actiu = @actiu WHERE ID_Producte = @ID_Producte"
        command.Parameters.AddWithValue("@ID_Categoria", "")
        command.Parameters.AddWithValue("@preu", "")
        command.Parameters.AddWithValue("@stock", "")
        command.Parameters.AddWithValue("@marca", "")
        command.Parameters.AddWithValue("@model", "")
        command.Parameters.AddWithValue("@especificacions", "")
        command.Parameters.AddWithValue("@imatge", "")
        command.Parameters.AddWithValue("@actiu", "")
        command.Parameters.AddWithValue("@ID_Producte", "")

        For Each row As DataGridViewRow In tabla.Rows
            If Not row.IsNewRow Then
                command.Parameters("@ID_Categoria").Value = row.Cells("ID_Categoria").Value.ToString()
                command.Parameters("@preu").Value = row.Cells("preu").Value.ToString()
                command.Parameters("@stock").Value = row.Cells("stock").Value.ToString()
                command.Parameters("@marca").Value = row.Cells("marca").Value.ToString()
                command.Parameters("@model").Value = row.Cells("model").Value.ToString()
                command.Parameters("@especificacions").Value = row.Cells("especificacions").Value.ToString()
                command.Parameters("@imatge").Value = row.Cells("imatge").Value.ToString()
                command.Parameters("@actiu").Value = row.Cells("actiu").Value.ToString()
                command.Parameters("@ID_Producte").Value = row.Cells("ID_Producte").Value.ToString()
                conn.ObrirConexio()
                command.ExecuteNonQuery()
                conn.CerrarConexion()
            End If
        Next

        LoadDataGrid()
    End Sub
End Class