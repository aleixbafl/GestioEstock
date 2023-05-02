Imports MySqlConnector

Public Class Eliminar_Productes
    
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
        DataGridView1.DataSource = GetData()
    End Sub
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        'Verifica que se ha hecho clic en una celda con el botón derecho del ratón
        If e.Button = MouseButtons.Right Then
            Dim isbn As String = DataGridView1.Rows(e.RowIndex).Cells("ID_Producte").Value.ToString()
            If MessageBox.Show("¿Estás seguro de que deseas eliminar este Registro?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim connString As String = "Server=sql965.main-hosting.eu;Database=u346867692_gestiorEstoc;Uid=u346867692_gestiorEstoc;Pwd=Fat/3232;"
                Dim query As String = "DELETE FROM productes WHERE ID_Producte = @ID_Producte;"
                Using conn As New MySqlConnection(connString), cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID_Producte", isbn)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
                DataGridView1.DataSource = GetData()
            End If
        End If
    End Sub
    Private Function GetData() As DataTable
        Dim connString As String = "Server=sql965.main-hosting.eu;Database=u346867692_gestiorEstoc;Uid=u346867692_gestiorEstoc;Pwd=Fat/3232;"
        Dim query As String = "SELECT * FROM productes;"
        Using conn As New MySqlConnection(connString), da As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            da.Fill(table)
            Return table
        End Using
    End Function
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Menu_Productes.Show()
        Me.Close()
    End Sub
End Class