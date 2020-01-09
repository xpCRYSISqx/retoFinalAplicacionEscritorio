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
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.iniciarSesion = New System.Windows.Forms.Button()
		Me.cancelar = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(134, 94)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(168, 20)
		Me.TextBox1.TabIndex = 0
		'
		'TextBox2
		'
		Me.TextBox2.AccessibleDescription = ""
		Me.TextBox2.Location = New System.Drawing.Point(134, 167)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(168, 20)
		Me.TextBox2.TabIndex = 1
		Me.TextBox2.Tag = ""
		Me.TextBox2.UseSystemPasswordChar = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(70, 95)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(58, 16)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Usuario:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(48, 168)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(80, 16)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Contraseña:"
		'
		'iniciarSesion
		'
		Me.iniciarSesion.Location = New System.Drawing.Point(230, 278)
		Me.iniciarSesion.Name = "iniciarSesion"
		Me.iniciarSesion.Size = New System.Drawing.Size(97, 23)
		Me.iniciarSesion.TabIndex = 4
		Me.iniciarSesion.Text = "Iniciar Sesion"
		Me.iniciarSesion.UseVisualStyleBackColor = True
		'
		'cancelar
		'
		Me.cancelar.Location = New System.Drawing.Point(51, 278)
		Me.cancelar.Name = "cancelar"
		Me.cancelar.Size = New System.Drawing.Size(97, 23)
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
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "InicioSesion"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Iniciar Sesion"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents iniciarSesion As Button
	Friend WithEvents cancelar As Button
End Class
