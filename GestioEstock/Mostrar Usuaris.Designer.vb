<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mostrar_Usuaris
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mostrar_Usuaris))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.barraSuperiorPartBotons = New System.Windows.Forms.PictureBox()
        Me.barraSuperiorMoure = New System.Windows.Forms.PictureBox()
        Me.adaptarFinestra = New System.Windows.Forms.PictureBox()
        Me.minimitzar = New System.Windows.Forms.PictureBox()
        Me.tanca = New System.Windows.Forms.PictureBox()
        Me.taula = New System.Windows.Forms.DataGridView()
        CType(Me.barraSuperiorPartBotons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barraSuperiorMoure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adaptarFinestra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimitzar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tanca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.taula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(183, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 28)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Tornar Enrere"
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(449, 185)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(146, 32)
        Me.Button5.TabIndex = 39
        Me.Button5.Text = "Entrar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(337, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 28)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Que Vols Fer ?"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(183, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 28)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Mostrar Categories"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(449, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 32)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Entrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'barraSuperiorPartBotons
        '
        Me.barraSuperiorPartBotons.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barraSuperiorPartBotons.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.barraSuperiorPartBotons.Location = New System.Drawing.Point(836, 2)
        Me.barraSuperiorPartBotons.Margin = New System.Windows.Forms.Padding(2)
        Me.barraSuperiorPartBotons.Name = "barraSuperiorPartBotons"
        Me.barraSuperiorPartBotons.Size = New System.Drawing.Size(64, 43)
        Me.barraSuperiorPartBotons.TabIndex = 35
        Me.barraSuperiorPartBotons.TabStop = False
        '
        'barraSuperiorMoure
        '
        Me.barraSuperiorMoure.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barraSuperiorMoure.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.barraSuperiorMoure.Location = New System.Drawing.Point(0, 2)
        Me.barraSuperiorMoure.Margin = New System.Windows.Forms.Padding(2)
        Me.barraSuperiorMoure.Name = "barraSuperiorMoure"
        Me.barraSuperiorMoure.Size = New System.Drawing.Size(837, 43)
        Me.barraSuperiorMoure.TabIndex = 34
        Me.barraSuperiorMoure.TabStop = False
        '
        'adaptarFinestra
        '
        Me.adaptarFinestra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.adaptarFinestra.Image = CType(resources.GetObject("adaptarFinestra.Image"), System.Drawing.Image)
        Me.adaptarFinestra.Location = New System.Drawing.Point(878, 478)
        Me.adaptarFinestra.Margin = New System.Windows.Forms.Padding(2)
        Me.adaptarFinestra.Name = "adaptarFinestra"
        Me.adaptarFinestra.Size = New System.Drawing.Size(19, 20)
        Me.adaptarFinestra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.adaptarFinestra.TabIndex = 33
        Me.adaptarFinestra.TabStop = False
        '
        'minimitzar
        '
        Me.minimitzar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimitzar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.minimitzar.Image = CType(resources.GetObject("minimitzar.Image"), System.Drawing.Image)
        Me.minimitzar.Location = New System.Drawing.Point(845, 10)
        Me.minimitzar.Margin = New System.Windows.Forms.Padding(2)
        Me.minimitzar.Name = "minimitzar"
        Me.minimitzar.Size = New System.Drawing.Size(19, 20)
        Me.minimitzar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.minimitzar.TabIndex = 32
        Me.minimitzar.TabStop = False
        '
        'tanca
        '
        Me.tanca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tanca.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tanca.Image = CType(resources.GetObject("tanca.Image"), System.Drawing.Image)
        Me.tanca.Location = New System.Drawing.Point(875, 10)
        Me.tanca.Margin = New System.Windows.Forms.Padding(2)
        Me.tanca.Name = "tanca"
        Me.tanca.Size = New System.Drawing.Size(19, 20)
        Me.tanca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.tanca.TabIndex = 31
        Me.tanca.TabStop = False
        '
        'taula
        '
        Me.taula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.taula.Location = New System.Drawing.Point(23, 244)
        Me.taula.Name = "taula"
        Me.taula.Size = New System.Drawing.Size(852, 219)
        Me.taula.TabIndex = 84
        '
        'Mostrar_Usuaris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.Controls.Add(Me.taula)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.barraSuperiorPartBotons)
        Me.Controls.Add(Me.barraSuperiorMoure)
        Me.Controls.Add(Me.adaptarFinestra)
        Me.Controls.Add(Me.minimitzar)
        Me.Controls.Add(Me.tanca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Mostrar_Usuaris"
        Me.Text = "Mostrar_Usuaris"
        CType(Me.barraSuperiorPartBotons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barraSuperiorMoure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adaptarFinestra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimitzar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tanca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.taula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents barraSuperiorPartBotons As PictureBox
    Friend WithEvents barraSuperiorMoure As PictureBox
    Friend WithEvents adaptarFinestra As PictureBox
    Friend WithEvents minimitzar As PictureBox
    Friend WithEvents tanca As PictureBox
    Friend WithEvents taula As DataGridView
End Class
