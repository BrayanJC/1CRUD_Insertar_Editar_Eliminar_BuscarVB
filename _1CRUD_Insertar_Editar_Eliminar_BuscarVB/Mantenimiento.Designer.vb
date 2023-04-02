<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mantenimiento
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
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.CMB_Tipo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_Tratamiento = New System.Windows.Forms.TextBox()
        Me.TXT_Apellido = New System.Windows.Forms.TextBox()
        Me.TXT_Nombre = New System.Windows.Forms.TextBox()
        Me.BNT_Guardar = New System.Windows.Forms.Button()
        Me.PIB_Imagen = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.PIB_Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(248, 176)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(69, 13)
        Me.LinkLabel1.TabIndex = 22
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Subir Imagen"
        '
        'CMB_Tipo
        '
        Me.CMB_Tipo.BackColor = System.Drawing.Color.White
        Me.CMB_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMB_Tipo.FormattingEnabled = True
        Me.CMB_Tipo.Items.AddRange(New Object() {"Niño", "Joven", "Adulto"})
        Me.CMB_Tipo.Location = New System.Drawing.Point(121, 283)
        Me.CMB_Tipo.Name = "CMB_Tipo"
        Me.CMB_Tipo.Size = New System.Drawing.Size(287, 23)
        Me.CMB_Tipo.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Tratamiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Tipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Apellidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nombre"
        '
        'TXT_Tratamiento
        '
        Me.TXT_Tratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Tratamiento.Location = New System.Drawing.Point(121, 312)
        Me.TXT_Tratamiento.Name = "TXT_Tratamiento"
        Me.TXT_Tratamiento.Size = New System.Drawing.Size(287, 21)
        Me.TXT_Tratamiento.TabIndex = 4
        '
        'TXT_Apellido
        '
        Me.TXT_Apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Apellido.Location = New System.Drawing.Point(121, 256)
        Me.TXT_Apellido.Name = "TXT_Apellido"
        Me.TXT_Apellido.Size = New System.Drawing.Size(287, 21)
        Me.TXT_Apellido.TabIndex = 2
        '
        'TXT_Nombre
        '
        Me.TXT_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Nombre.Location = New System.Drawing.Point(121, 229)
        Me.TXT_Nombre.Name = "TXT_Nombre"
        Me.TXT_Nombre.Size = New System.Drawing.Size(287, 21)
        Me.TXT_Nombre.TabIndex = 1
        '
        'BNT_Guardar
        '
        Me.BNT_Guardar.BackColor = System.Drawing.Color.DarkCyan
        Me.BNT_Guardar.FlatAppearance.BorderSize = 0
        Me.BNT_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BNT_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BNT_Guardar.ForeColor = System.Drawing.Color.White
        Me.BNT_Guardar.Location = New System.Drawing.Point(120, 374)
        Me.BNT_Guardar.Name = "BNT_Guardar"
        Me.BNT_Guardar.Size = New System.Drawing.Size(239, 40)
        Me.BNT_Guardar.TabIndex = 5
        Me.BNT_Guardar.Text = "Insertar"
        Me.BNT_Guardar.UseVisualStyleBackColor = False
        '
        'PIB_Imagen
        '
        Me.PIB_Imagen.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.PIB_Imagen.Image = Global._1CRUD_Insertar_Editar_Eliminar_Buscar.My.Resources.Resources.userProfile
        Me.PIB_Imagen.Location = New System.Drawing.Point(167, 25)
        Me.PIB_Imagen.Name = "PIB_Imagen"
        Me.PIB_Imagen.Size = New System.Drawing.Size(150, 143)
        Me.PIB_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PIB_Imagen.TabIndex = 16
        Me.PIB_Imagen.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 423)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Paciente"
        '
        'Mantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 448)
        Me.Controls.Add(Me.BNT_Guardar)
        Me.Controls.Add(Me.CMB_Tipo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_Tratamiento)
        Me.Controls.Add(Me.TXT_Apellido)
        Me.Controls.Add(Me.TXT_Nombre)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PIB_Imagen)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Mantenimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento"
        CType(Me.PIB_Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents CMB_Tipo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PIB_Imagen As PictureBox
    Friend WithEvents TXT_Tratamiento As TextBox
    Friend WithEvents TXT_Apellido As TextBox
    Friend WithEvents TXT_Nombre As TextBox
    Friend WithEvents BNT_Guardar As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
