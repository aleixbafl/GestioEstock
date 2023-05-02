Imports MySqlConnector

Public Class Actualitzar_Usuaris
    Dim cadena As String = "Server=sql965.main-hosting.eu;Database=u346867692_gestiorEstoc;Uid=u346867692_gestiorEstoc;Pwd=Fat/3232;AllowZeroDateTime=True;"
    Dim conn As New MySqlConnection(cadena)
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

    Private Sub Menu_Categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tanca.BringToFront()
        minimitzar.BringToFront()
        LoadDataGrid()
    End Sub
    Private Sub LoadDataGrid()
        Dim query As String = "SELECT * FROM usuari"
        Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(query, conn)
        Dim table As DataTable = New DataTable()
        adapter.Fill(table)
        tabla.DataSource = table
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Menu_Usuaris.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As MySqlCommand = New MySqlCommand()
        command.Connection = conn
        command.CommandText = "UPDATE usuari SET DNI = @DNI, nomUsuari = @nomUsuari, nom = @nom, cognom = @cognom, dataNaixe = @dataNaixe, correuElect = @correuElect, contrarenya = @contrarenya WHERE ID_Usuari = @ID_Usuari"
        command.Parameters.AddWithValue("@DNI", "")
        command.Parameters.AddWithValue("@nomUsuari", "")
        command.Parameters.AddWithValue("@nom", "")
        command.Parameters.AddWithValue("@cognom", "")
        command.Parameters.AddWithValue("@dataNaixe", "")
        command.Parameters.AddWithValue("@correuElect", "")
        command.Parameters.AddWithValue("@contrarenya", "")
        command.Parameters.AddWithValue("@ID_Usuari", "")

        For Each row As DataGridViewRow In tabla.Rows
            If Not row.IsNewRow Then

                command.Parameters("@DNI").Value = row.Cells("DNI").Value.ToString()
                command.Parameters("@nomUsuari").Value = row.Cells("nomUsuari").Value.ToString()
                command.Parameters("@nom").Value = row.Cells("nom").Value.ToString()
                command.Parameters("@cognom").Value = row.Cells("cognom").Value.ToString()
                command.Parameters("@dataNaixe").Value = row.Cells("dataNaixe").Value.ToString()
                command.Parameters("@correuElect").Value = row.Cells("correuElect").Value.ToString()
                command.Parameters("@contrarenya").Value = row.Cells("contrarenya").Value.ToString()
                command.Parameters("@ID_Usuari").Value = row.Cells("ID_Usuari").Value.ToString()
                conn.Open()
                command.ExecuteNonQuery()
                conn.Close()
            End If
        Next

        LoadDataGrid()
    End Sub
End Class