<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambiarContrasena
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
		Me.contra1 = New System.Windows.Forms.TextBox()
		Me.contra2 = New System.Windows.Forms.TextBox()
		Me.aceptar = New System.Windows.Forms.Button()
		Me.cancelar = New System.Windows.Forms.Button()
		Me.labelError = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(31, 24)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(187, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Introduce la nueva contraseña:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(31, 87)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(202, 17)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Vuelve a introducir la contraseña:"
		'
		'contra1
		'
		Me.contra1.Location = New System.Drawing.Point(34, 44)
		Me.contra1.Name = "contra1"
		Me.contra1.Size = New System.Drawing.Size(304, 23)
		Me.contra1.TabIndex = 2
		Me.contra1.UseSystemPasswordChar = True
		'
		'contra2
		'
		Me.contra2.Location = New System.Drawing.Point(34, 107)
		Me.contra2.Name = "contra2"
		Me.contra2.Size = New System.Drawing.Size(304, 23)
		Me.contra2.TabIndex = 3
		Me.contra2.UseSystemPasswordChar = True
		'
		'aceptar
		'
		Me.aceptar.Enabled = False
		Me.aceptar.Location = New System.Drawing.Point(263, 194)
		Me.aceptar.Name = "aceptar"
		Me.aceptar.Size = New System.Drawing.Size(75, 31)
		Me.aceptar.TabIndex = 4
		Me.aceptar.Text = "Cambiar"
		Me.aceptar.UseVisualStyleBackColor = True
		'
		'cancelar
		'
		Me.cancelar.Location = New System.Drawing.Point(34, 194)
		Me.cancelar.Name = "cancelar"
		Me.cancelar.Size = New System.Drawing.Size(75, 31)
		Me.cancelar.TabIndex = 5
		Me.cancelar.Text = "Cancelar"
		Me.cancelar.UseVisualStyleBackColor = True
		'
		'labelError
		'
		Me.labelError.AutoSize = True
		Me.labelError.ForeColor = System.Drawing.Color.Red
		Me.labelError.Location = New System.Drawing.Point(94, 149)
		Me.labelError.Name = "labelError"
		Me.labelError.Size = New System.Drawing.Size(179, 17)
		Me.labelError.TabIndex = 6
		Me.labelError.Text = "Las contraseñas no coinciden"
		Me.labelError.Visible = False
		'
		'CambiarContrasena
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(367, 269)
		Me.Controls.Add(Me.labelError)
		Me.Controls.Add(Me.cancelar)
		Me.Controls.Add(Me.aceptar)
		Me.Controls.Add(Me.contra2)
		Me.Controls.Add(Me.contra1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.MaximizeBox = False
		Me.Name = "CambiarContrasena"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "CambiarContrasena"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents contra1 As TextBox
	Friend WithEvents contra2 As TextBox
	Friend WithEvents aceptar As Button
	Friend WithEvents cancelar As Button
	Friend WithEvents labelError As Label
End Class
