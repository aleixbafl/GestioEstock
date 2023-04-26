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
        Me.tanca = New System.Windows.Forms.PictureBox()
        Me.minimitzar = New System.Windows.Forms.PictureBox()
        Me.barraSuperiorMoure = New System.Windows.Forms.PictureBox()
        Me.barraSuperiorPartBotons = New System.Windows.Forms.PictureBox()
        Me.adaptarFinestra = New System.Windows.Forms.PictureBox()
        Me.fondoLoginCentre = New System.Windows.Forms.PictureBox()
        CType(Me.tanca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimitzar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barraSuperiorMoure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barraSuperiorPartBotons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adaptarFinestra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fondoLoginCentre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tanca
        '
        Me.tanca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tanca.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tanca.Image = CType(resources.GetObject("tanca.Image"), System.Drawing.Image)
        Me.tanca.Location = New System.Drawing.Point(872, 8)
        Me.tanca.Margin = New System.Windows.Forms.Padding(2)
        Me.tanca.Name = "tanca"
        Me.tanca.Size = New System.Drawing.Size(19, 20)
        Me.tanca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.tanca.TabIndex = 0
        Me.tanca.TabStop = False
        '
        'minimitzar
        '
        Me.minimitzar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimitzar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.minimitzar.Image = CType(resources.GetObject("minimitzar.Image"), System.Drawing.Image)
        Me.minimitzar.Location = New System.Drawing.Point(842, 8)
        Me.minimitzar.Margin = New System.Windows.Forms.Padding(2)
        Me.minimitzar.Name = "minimitzar"
        Me.minimitzar.Size = New System.Drawing.Size(19, 20)
        Me.minimitzar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.minimitzar.TabIndex = 1
        Me.minimitzar.TabStop = False
        '
        'barraSuperiorMoure
        '
        Me.barraSuperiorMoure.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barraSuperiorMoure.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.barraSuperiorMoure.Location = New System.Drawing.Point(0, 0)
        Me.barraSuperiorMoure.Margin = New System.Windows.Forms.Padding(2)
        Me.barraSuperiorMoure.Name = "barraSuperiorMoure"
        Me.barraSuperiorMoure.Size = New System.Drawing.Size(837, 32)
        Me.barraSuperiorMoure.TabIndex = 3
        Me.barraSuperiorMoure.TabStop = False
        '
        'barraSuperiorPartBotons
        '
        Me.barraSuperiorPartBotons.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barraSuperiorPartBotons.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.barraSuperiorPartBotons.Location = New System.Drawing.Point(836, 0)
        Me.barraSuperiorPartBotons.Margin = New System.Windows.Forms.Padding(2)
        Me.barraSuperiorPartBotons.Name = "barraSuperiorPartBotons"
        Me.barraSuperiorPartBotons.Size = New System.Drawing.Size(64, 32)
        Me.barraSuperiorPartBotons.TabIndex = 4
        Me.barraSuperiorPartBotons.TabStop = False
        '
        'adaptarFinestra
        '
        Me.adaptarFinestra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.adaptarFinestra.Image = CType(resources.GetObject("adaptarFinestra.Image"), System.Drawing.Image)
        Me.adaptarFinestra.Location = New System.Drawing.Point(878, 476)
        Me.adaptarFinestra.Margin = New System.Windows.Forms.Padding(2)
        Me.adaptarFinestra.Name = "adaptarFinestra"
        Me.adaptarFinestra.Size = New System.Drawing.Size(19, 20)
        Me.adaptarFinestra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.adaptarFinestra.TabIndex = 2
        Me.adaptarFinestra.TabStop = False
        '
        'fondoLoginCentre
        '
        Me.fondoLoginCentre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fondoLoginCentre.BackColor = System.Drawing.Color.Gray
        Me.fondoLoginCentre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fondoLoginCentre.Location = New System.Drawing.Point(235, 109)
        Me.fondoLoginCentre.Name = "fondoLoginCentre"
        Me.fondoLoginCentre.Size = New System.Drawing.Size(450, 250)
        Me.fondoLoginCentre.TabIndex = 5
        Me.fondoLoginCentre.TabStop = False
        '
        'MenuPrinEmpleat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.Controls.Add(Me.fondoLoginCentre)
        Me.Controls.Add(Me.barraSuperiorPartBotons)
        Me.Controls.Add(Me.barraSuperiorMoure)
        Me.Controls.Add(Me.adaptarFinestra)
        Me.Controls.Add(Me.minimitzar)
        Me.Controls.Add(Me.tanca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MenuPrinEmpleat"
        Me.Text = "Login"
        CType(Me.tanca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimitzar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barraSuperiorMoure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barraSuperiorPartBotons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adaptarFinestra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fondoLoginCentre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tanca As PictureBox
    Friend WithEvents minimitzar As PictureBox
    Friend WithEvents barraSuperiorMoure As PictureBox
    Friend WithEvents barraSuperiorPartBotons As PictureBox
    Friend WithEvents adaptarFinestra As PictureBox
    Friend WithEvents fondoLoginCentre As PictureBox
End Class
