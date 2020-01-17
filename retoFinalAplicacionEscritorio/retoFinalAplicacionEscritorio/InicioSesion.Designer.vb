<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicioSesion
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
		Me.email = New System.Windows.Forms.TextBox()
		Me.contrasena = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.iniciarSesion = New System.Windows.Forms.Button()
		Me.cancelar = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'email
		'
		Me.email.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.email.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.email.Location = New System.Drawing.Point(134, 94)
		Me.email.Name = "email"
		Me.email.Size = New System.Drawing.Size(193, 25)
		Me.email.TabIndex = 0
		'
		'contrasena
		'
		Me.contrasena.AccessibleDescription = ""
		Me.contrasena.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.contrasena.Location = New System.Drawing.Point(134, 166)
		Me.contrasena.Name = "contrasena"
		Me.contrasena.Size = New System.Drawing.Size(193, 25)
		Me.contrasena.TabIndex = 1
		Me.contrasena.Tag = ""
		Me.contrasena.UseSystemPasswordChar = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(74, 97)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(54, 19)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Correo:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(47, 169)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(82, 19)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Contraseña:"
		'
		'iniciarSesion
		'
		Me.iniciarSesion.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.iniciarSesion.Location = New System.Drawing.Point(230, 278)
		Me.iniciarSesion.Name = "iniciarSesion"
		Me.iniciarSesion.Size = New System.Drawing.Size(97, 31)
		Me.iniciarSesion.TabIndex = 4
		Me.iniciarSesion.Text = "Iniciar Sesion"
		Me.iniciarSesion.UseVisualStyleBackColor = True
		'
		'cancelar
		'
		Me.cancelar.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.cancelar.Location = New System.Drawing.Point(51, 278)
		Me.cancelar.Name = "cancelar"
		Me.cancelar.Size = New System.Drawing.Size(97, 31)
		Me.cancelar.TabIndex = 5
		Me.cancelar.Text = "Cancelar"
		Me.cancelar.UseVisualStyleBackColor = True
		'
		'InicioSesion
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(378, 366)
		Me.Controls.Add(Me.cancelar)
		Me.Controls.Add(Me.iniciarSesion)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.contrasena)
		Me.Controls.Add(Me.email)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "InicioSesion"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Iniciar sesion"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents email As TextBox
	Friend WithEvents contrasena As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents iniciarSesion As Button
	Friend WithEvents cancelar As Button
End Class
