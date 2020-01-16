<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearUsuario
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.nombre = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.apellido = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.mail = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.telefono = New System.Windows.Forms.MaskedTextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.contra1 = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.contra2 = New System.Windows.Forms.TextBox()
		Me.cancelar = New System.Windows.Forms.Button()
		Me.aceptar = New System.Windows.Forms.Button()
		Me.dni = New System.Windows.Forms.MaskedTextBox()
		Me.labelError = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.adminNo = New System.Windows.Forms.RadioButton()
		Me.adminSi = New System.Windows.Forms.RadioButton()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(43, 40)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(34, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "DNI:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(43, 99)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(60, 17)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Nombre:"
		'
		'nombre
		'
		Me.nombre.Location = New System.Drawing.Point(46, 119)
		Me.nombre.Name = "nombre"
		Me.nombre.Size = New System.Drawing.Size(185, 23)
		Me.nombre.TabIndex = 2
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(43, 161)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(59, 17)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "Apellido:"
		'
		'apellido
		'
		Me.apellido.Location = New System.Drawing.Point(45, 181)
		Me.apellido.Name = "apellido"
		Me.apellido.Size = New System.Drawing.Size(186, 23)
		Me.apellido.TabIndex = 3
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(43, 224)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(120, 17)
		Me.Label4.TabIndex = 5
		Me.Label4.Text = "Correo electrónico:"
		'
		'mail
		'
		Me.mail.ForeColor = System.Drawing.Color.Gray
		Me.mail.Location = New System.Drawing.Point(46, 244)
		Me.mail.Name = "mail"
		Me.mail.Size = New System.Drawing.Size(246, 23)
		Me.mail.TabIndex = 4
		Me.mail.Text = "ejemplo@ejemplo.com"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(43, 284)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(62, 17)
		Me.Label5.TabIndex = 7
		Me.Label5.Text = "Teléfono:"
		'
		'telefono
		'
		Me.telefono.Location = New System.Drawing.Point(46, 304)
		Me.telefono.Mask = "000000000"
		Me.telefono.Name = "telefono"
		Me.telefono.Size = New System.Drawing.Size(104, 23)
		Me.telefono.TabIndex = 5
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(43, 349)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(77, 17)
		Me.Label6.TabIndex = 9
		Me.Label6.Text = "Contraseña:"
		'
		'contra1
		'
		Me.contra1.Location = New System.Drawing.Point(46, 369)
		Me.contra1.Name = "contra1"
		Me.contra1.Size = New System.Drawing.Size(185, 23)
		Me.contra1.TabIndex = 6
		Me.contra1.UseSystemPasswordChar = True
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(42, 415)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(121, 17)
		Me.Label7.TabIndex = 11
		Me.Label7.Text = "Repetir contraseña:"
		'
		'contra2
		'
		Me.contra2.Location = New System.Drawing.Point(46, 435)
		Me.contra2.Name = "contra2"
		Me.contra2.Size = New System.Drawing.Size(186, 23)
		Me.contra2.TabIndex = 7
		Me.contra2.UseSystemPasswordChar = True
		'
		'cancelar
		'
		Me.cancelar.Location = New System.Drawing.Point(43, 512)
		Me.cancelar.Name = "cancelar"
		Me.cancelar.Size = New System.Drawing.Size(75, 33)
		Me.cancelar.TabIndex = 10
		Me.cancelar.Text = "Cancelar"
		Me.cancelar.UseVisualStyleBackColor = True
		'
		'aceptar
		'
		Me.aceptar.Location = New System.Drawing.Point(268, 512)
		Me.aceptar.Name = "aceptar"
		Me.aceptar.Size = New System.Drawing.Size(75, 33)
		Me.aceptar.TabIndex = 11
		Me.aceptar.Text = "Aceptar"
		Me.aceptar.UseVisualStyleBackColor = True
		'
		'dni
		'
		Me.dni.Location = New System.Drawing.Point(46, 60)
		Me.dni.Mask = "00000000L"
		Me.dni.Name = "dni"
		Me.dni.Size = New System.Drawing.Size(117, 23)
		Me.dni.TabIndex = 1
		'
		'labelError
		'
		Me.labelError.AutoSize = True
		Me.labelError.ForeColor = System.Drawing.Color.Red
		Me.labelError.Location = New System.Drawing.Point(102, 474)
		Me.labelError.Name = "labelError"
		Me.labelError.Size = New System.Drawing.Size(179, 17)
		Me.labelError.TabIndex = 16
		Me.labelError.Text = "Las contraseñas no coinciden"
		Me.labelError.Visible = False
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.adminNo)
		Me.GroupBox1.Controls.Add(Me.adminSi)
		Me.GroupBox1.Location = New System.Drawing.Point(238, 413)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(111, 45)
		Me.GroupBox1.TabIndex = 17
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Administrador:"
		'
		'adminNo
		'
		Me.adminNo.AutoSize = True
		Me.adminNo.Checked = True
		Me.adminNo.Location = New System.Drawing.Point(57, 22)
		Me.adminNo.Name = "adminNo"
		Me.adminNo.Size = New System.Drawing.Size(44, 21)
		Me.adminNo.TabIndex = 9
		Me.adminNo.TabStop = True
		Me.adminNo.Text = "No"
		Me.adminNo.UseVisualStyleBackColor = True
		'
		'adminSi
		'
		Me.adminSi.AutoSize = True
		Me.adminSi.Location = New System.Drawing.Point(15, 22)
		Me.adminSi.Name = "adminSi"
		Me.adminSi.Size = New System.Drawing.Size(36, 21)
		Me.adminSi.TabIndex = 8
		Me.adminSi.Text = "Si"
		Me.adminSi.UseVisualStyleBackColor = True
		'
		'CrearUsuario
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(386, 588)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.labelError)
		Me.Controls.Add(Me.dni)
		Me.Controls.Add(Me.aceptar)
		Me.Controls.Add(Me.cancelar)
		Me.Controls.Add(Me.contra2)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.contra1)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.telefono)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.mail)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.apellido)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.nombre)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.MaximizeBox = False
		Me.Name = "CrearUsuario"
		Me.Padding = New System.Windows.Forms.Padding(40)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "CrearUsuario"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents nombre As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents apellido As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents mail As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents telefono As MaskedTextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents contra1 As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents contra2 As TextBox
	Friend WithEvents cancelar As Button
	Friend WithEvents aceptar As Button
	Friend WithEvents dni As MaskedTextBox
	Friend WithEvents labelError As Label
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents adminNo As RadioButton
	Friend WithEvents adminSi As RadioButton
End Class
