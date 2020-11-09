<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Canel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.No_empleado = New System.Windows.Forms.TextBox()
        Me.Contrasenia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Perfiles = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Aceptar
        '
        Me.Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Aceptar.Location = New System.Drawing.Point(86, 300)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(127, 34)
        Me.Aceptar.TabIndex = 0
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Canel
        '
        Me.Canel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Canel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Canel.Location = New System.Drawing.Point(219, 300)
        Me.Canel.Name = "Canel"
        Me.Canel.Size = New System.Drawing.Size(127, 34)
        Me.Canel.TabIndex = 1
        Me.Canel.Text = "Cancelar"
        Me.Canel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Iniciar Sesión"
        '
        'No_empleado
        '
        Me.No_empleado.Location = New System.Drawing.Point(169, 108)
        Me.No_empleado.Name = "No_empleado"
        Me.No_empleado.Size = New System.Drawing.Size(177, 20)
        Me.No_empleado.TabIndex = 3
        '
        'Contrasenia
        '
        Me.Contrasenia.Location = New System.Drawing.Point(169, 178)
        Me.Contrasenia.Name = "Contrasenia"
        Me.Contrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Contrasenia.Size = New System.Drawing.Size(177, 20)
        Me.Contrasenia.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "No. Empleado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Contraeña"
        '
        'Perfiles
        '
        Me.Perfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Perfiles.FormattingEnabled = True
        Me.Perfiles.Location = New System.Drawing.Point(169, 242)
        Me.Perfiles.Name = "Perfiles"
        Me.Perfiles.Size = New System.Drawing.Size(177, 21)
        Me.Perfiles.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(96, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Entrar como"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 353)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Perfiles)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Contrasenia)
        Me.Controls.Add(Me.No_empleado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Canel)
        Me.Controls.Add(Me.Aceptar)
        Me.MaximizeBox = False
        Me.Name = "login"
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Aceptar As Button
    Friend WithEvents Canel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents No_empleado As TextBox
    Friend WithEvents Contrasenia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Perfiles As ComboBox
    Friend WithEvents Label4 As Label
End Class
