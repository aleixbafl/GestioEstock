<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Insertar_Usuaris
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Insertar_Usuaris))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.contrasenya = New System.Windows.Forms.TextBox()
        Me.correu = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dataNaixement = New System.Windows.Forms.TextBox()
        Me.cognom = New System.Windows.Forms.TextBox()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.nomUsuari = New System.Windows.Forms.TextBox()
        Me.dni = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.inserta = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.barraSuperiorPartBotons = New System.Windows.Forms.PictureBox()
        Me.barraSuperiorMoure = New System.Windows.Forms.PictureBox()
        Me.adaptarFinestra = New System.Windows.Forms.PictureBox()
        Me.minimitzar = New System.Windows.Forms.PictureBox()
        Me.tanca = New System.Windows.Forms.PictureBox()
        Me.admin = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barraSuperiorPartBotons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barraSuperiorMoure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adaptarFinestra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimitzar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tanca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(320, 331)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 28)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Contrasenya"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(608, 215)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(181, 28)
        Me.Label12.TabIndex = 98
        Me.Label12.Text = "CorreuElectronico"
        '
        'contrasenya
        '
        Me.contrasenya.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.contrasenya.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contrasenya.Location = New System.Drawing.Point(282, 392)
        Me.contrasenya.Name = "contrasenya"
        Me.contrasenya.Size = New System.Drawing.Size(199, 29)
        Me.contrasenya.TabIndex = 96
        '
        'correu
        '
        Me.correu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.correu.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.correu.Location = New System.Drawing.Point(603, 276)
        Me.correu.Name = "correu"
        Me.correu.Size = New System.Drawing.Size(199, 29)
        Me.correu.TabIndex = 95
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(423, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 28)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "DataNaixe"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(195, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 28)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Cognom"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(663, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 28)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Nom"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(423, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 28)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "nomUsuari"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(209, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 28)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "DNI"
        '
        'dataNaixement
        '
        Me.dataNaixement.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dataNaixement.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataNaixement.Location = New System.Drawing.Point(372, 276)
        Me.dataNaixement.Name = "dataNaixement"
        Me.dataNaixement.Size = New System.Drawing.Size(199, 29)
        Me.dataNaixement.TabIndex = 88
        '
        'cognom
        '
        Me.cognom.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cognom.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cognom.Location = New System.Drawing.Point(141, 276)
        Me.cognom.Name = "cognom"
        Me.cognom.Size = New System.Drawing.Size(199, 29)
        Me.cognom.TabIndex = 87
        '
        'nom
        '
        Me.nom.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nom.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom.Location = New System.Drawing.Point(603, 168)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(199, 29)
        Me.nom.TabIndex = 86
        '
        'nomUsuari
        '
        Me.nomUsuari.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nomUsuari.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomUsuari.Location = New System.Drawing.Point(372, 168)
        Me.nomUsuari.Name = "nomUsuari"
        Me.nomUsuari.Size = New System.Drawing.Size(199, 29)
        Me.nomUsuari.TabIndex = 85
        '
        'dni
        '
        Me.dni.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dni.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dni.Location = New System.Drawing.Point(141, 168)
        Me.dni.Name = "dni"
        Me.dni.Size = New System.Drawing.Size(199, 29)
        Me.dni.TabIndex = 84
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(38, 578)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(848, 198)
        Me.DataGridView1.TabIndex = 82
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(521, 460)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 28)
        Me.Label6.TabIndex = 81
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
        Me.Button5.Location = New System.Drawing.Point(526, 508)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(155, 32)
        Me.Button5.TabIndex = 80
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
        Me.Label5.Location = New System.Drawing.Point(393, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 28)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Que Vols Fer ?"
        '
        'inserta
        '
        Me.inserta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.inserta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.inserta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inserta.Cursor = System.Windows.Forms.Cursors.Cross
        Me.inserta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.inserta.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inserta.Location = New System.Drawing.Point(242, 508)
        Me.inserta.Name = "inserta"
        Me.inserta.Size = New System.Drawing.Size(155, 32)
        Me.inserta.TabIndex = 78
        Me.inserta.Text = "Entrar"
        Me.inserta.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(227, 460)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 28)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Insertar Productes"
        '
        'barraSuperiorPartBotons
        '
        Me.barraSuperiorPartBotons.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barraSuperiorPartBotons.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.barraSuperiorPartBotons.Location = New System.Drawing.Point(867, 2)
        Me.barraSuperiorPartBotons.Margin = New System.Windows.Forms.Padding(2)
        Me.barraSuperiorPartBotons.Name = "barraSuperiorPartBotons"
        Me.barraSuperiorPartBotons.Size = New System.Drawing.Size(73, 43)
        Me.barraSuperiorPartBotons.TabIndex = 76
        Me.barraSuperiorPartBotons.TabStop = False
        '
        'barraSuperiorMoure
        '
        Me.barraSuperiorMoure.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barraSuperiorMoure.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.barraSuperiorMoure.Location = New System.Drawing.Point(-1, 2)
        Me.barraSuperiorMoure.Margin = New System.Windows.Forms.Padding(2)
        Me.barraSuperiorMoure.Name = "barraSuperiorMoure"
        Me.barraSuperiorMoure.Size = New System.Drawing.Size(869, 43)
        Me.barraSuperiorMoure.TabIndex = 75
        Me.barraSuperiorMoure.TabStop = False
        '
        'adaptarFinestra
        '
        Me.adaptarFinestra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.adaptarFinestra.Image = CType(resources.GetObject("adaptarFinestra.Image"), System.Drawing.Image)
        Me.adaptarFinestra.Location = New System.Drawing.Point(909, 795)
        Me.adaptarFinestra.Margin = New System.Windows.Forms.Padding(2)
        Me.adaptarFinestra.Name = "adaptarFinestra"
        Me.adaptarFinestra.Size = New System.Drawing.Size(19, 20)
        Me.adaptarFinestra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.adaptarFinestra.TabIndex = 74
        Me.adaptarFinestra.TabStop = False
        '
        'minimitzar
        '
        Me.minimitzar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimitzar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.minimitzar.Image = CType(resources.GetObject("minimitzar.Image"), System.Drawing.Image)
        Me.minimitzar.Location = New System.Drawing.Point(876, 10)
        Me.minimitzar.Margin = New System.Windows.Forms.Padding(2)
        Me.minimitzar.Name = "minimitzar"
        Me.minimitzar.Size = New System.Drawing.Size(28, 20)
        Me.minimitzar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.minimitzar.TabIndex = 73
        Me.minimitzar.TabStop = False
        '
        'tanca
        '
        Me.tanca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tanca.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tanca.Image = CType(resources.GetObject("tanca.Image"), System.Drawing.Image)
        Me.tanca.Location = New System.Drawing.Point(906, 10)
        Me.tanca.Margin = New System.Windows.Forms.Padding(2)
        Me.tanca.Name = "tanca"
        Me.tanca.Size = New System.Drawing.Size(28, 20)
        Me.tanca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.tanca.TabIndex = 72
        Me.tanca.TabStop = False
        '
        'admin
        '
        Me.admin.AutoSize = True
        Me.admin.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.admin.ForeColor = System.Drawing.Color.White
        Me.admin.Location = New System.Drawing.Point(559, 361)
        Me.admin.Name = "admin"
        Me.admin.Size = New System.Drawing.Size(125, 32)
        Me.admin.TabIndex = 100
        Me.admin.Text = "Es Admin"
        Me.admin.UseVisualStyleBackColor = True
        '
        'Insertar_Usuaris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(938, 817)
        Me.Controls.Add(Me.admin)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.contrasenya)
        Me.Controls.Add(Me.correu)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dataNaixement)
        Me.Controls.Add(Me.cognom)
        Me.Controls.Add(Me.nom)
        Me.Controls.Add(Me.nomUsuari)
        Me.Controls.Add(Me.dni)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.inserta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.barraSuperiorPartBotons)
        Me.Controls.Add(Me.barraSuperiorMoure)
        Me.Controls.Add(Me.adaptarFinestra)
        Me.Controls.Add(Me.minimitzar)
        Me.Controls.Add(Me.tanca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Insertar_Usuaris"
        Me.Text = "Insertar_Usuaris"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barraSuperiorPartBotons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barraSuperiorMoure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adaptarFinestra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimitzar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tanca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents contrasenya As TextBox
    Friend WithEvents correu As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dataNaixement As TextBox
    Friend WithEvents cognom As TextBox
    Friend WithEvents nom As TextBox
    Friend WithEvents nomUsuari As TextBox
    Friend WithEvents dni As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents inserta As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents barraSuperiorPartBotons As PictureBox
    Friend WithEvents barraSuperiorMoure As PictureBox
    Friend WithEvents adaptarFinestra As PictureBox
    Friend WithEvents minimitzar As PictureBox
    Friend WithEvents tanca As PictureBox
    Friend WithEvents admin As CheckBox
End Class
