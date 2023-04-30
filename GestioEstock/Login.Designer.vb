<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrinEmpleat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrinEmpleat))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.barraSuperiorPartBotons = New System.Windows.Forms.PictureBox()
        Me.barraSuperiorMoure = New System.Windows.Forms.PictureBox()
        Me.adaptarFinestra = New System.Windows.Forms.PictureBox()
        Me.minimitzar = New System.Windows.Forms.PictureBox()
        Me.tanca = New System.Windows.Forms.PictureBox()
        Me.login = New System.Windows.Forms.Label()
        CType(Me.barraSuperiorPartBotons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barraSuperiorMoure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adaptarFinestra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimitzar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tanca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(469, 431)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 39)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(257, 247)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 37)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "    Usuari    "
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(257, 322)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 37)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Contrasenya"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(469, 247)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(252, 34)
        Me.TextBox2.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(469, 321)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(252, 34)
        Me.TextBox1.TabIndex = 10
        '
        'barraSuperiorPartBotons
        '
        Me.barraSuperiorPartBotons.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barraSuperiorPartBotons.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.barraSuperiorPartBotons.Location = New System.Drawing.Point(1115, 0)
        Me.barraSuperiorPartBotons.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.barraSuperiorPartBotons.Name = "barraSuperiorPartBotons"
        Me.barraSuperiorPartBotons.Size = New System.Drawing.Size(85, 53)
        Me.barraSuperiorPartBotons.TabIndex = 4
        Me.barraSuperiorPartBotons.TabStop = False
        '
        'barraSuperiorMoure
        '
        Me.barraSuperiorMoure.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barraSuperiorMoure.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.barraSuperiorMoure.Location = New System.Drawing.Point(0, 0)
        Me.barraSuperiorMoure.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.barraSuperiorMoure.Name = "barraSuperiorMoure"
        Me.barraSuperiorMoure.Size = New System.Drawing.Size(1116, 53)
        Me.barraSuperiorMoure.TabIndex = 3
        Me.barraSuperiorMoure.TabStop = False
        '
        'adaptarFinestra
        '
        Me.adaptarFinestra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.adaptarFinestra.Image = CType(resources.GetObject("adaptarFinestra.Image"), System.Drawing.Image)
        Me.adaptarFinestra.Location = New System.Drawing.Point(1171, 586)
        Me.adaptarFinestra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.adaptarFinestra.Name = "adaptarFinestra"
        Me.adaptarFinestra.Size = New System.Drawing.Size(25, 25)
        Me.adaptarFinestra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.adaptarFinestra.TabIndex = 2
        Me.adaptarFinestra.TabStop = False
        '
        'minimitzar
        '
        Me.minimitzar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimitzar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.minimitzar.Image = CType(resources.GetObject("minimitzar.Image"), System.Drawing.Image)
        Me.minimitzar.Location = New System.Drawing.Point(1127, 10)
        Me.minimitzar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.minimitzar.Name = "minimitzar"
        Me.minimitzar.Size = New System.Drawing.Size(25, 25)
        Me.minimitzar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.minimitzar.TabIndex = 1
        Me.minimitzar.TabStop = False
        '
        'tanca
        '
        Me.tanca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tanca.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tanca.Image = CType(resources.GetObject("tanca.Image"), System.Drawing.Image)
        Me.tanca.Location = New System.Drawing.Point(1167, 10)
        Me.tanca.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tanca.Name = "tanca"
        Me.tanca.Size = New System.Drawing.Size(25, 25)
        Me.tanca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.tanca.TabIndex = 0
        Me.tanca.TabStop = False
        '
        'login
        '
        Me.login.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.login.AutoSize = True
        Me.login.Font = New System.Drawing.Font("Monotype Corsiva", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.ForeColor = System.Drawing.Color.White
        Me.login.Location = New System.Drawing.Point(530, 98)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(102, 45)
        Me.login.TabIndex = 11
        Me.login.Text = "Login"
        Me.login.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MenuPrinEmpleat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 615)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.barraSuperiorPartBotons)
        Me.Controls.Add(Me.barraSuperiorMoure)
        Me.Controls.Add(Me.adaptarFinestra)
        Me.Controls.Add(Me.minimitzar)
        Me.Controls.Add(Me.tanca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MenuPrinEmpleat"
        Me.Text = "z"
        CType(Me.barraSuperiorPartBotons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barraSuperiorMoure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adaptarFinestra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimitzar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tanca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tanca As PictureBox
    Friend WithEvents minimitzar As PictureBox
    Friend WithEvents barraSuperiorMoure As PictureBox
    Friend WithEvents barraSuperiorPartBotons As PictureBox
    Friend WithEvents adaptarFinestra As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents login As Label
End Class
