<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelecionarOpcion
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
		Me.usuarios = New System.Windows.Forms.Button()
		Me.alojamientos = New System.Windows.Forms.Button()
		Me.reservas = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'usuarios
		'
		Me.usuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.usuarios.Location = New System.Drawing.Point(91, 76)
		Me.usuarios.Name = "usuarios"
		Me.usuarios.Size = New System.Drawing.Size(190, 23)
		Me.usuarios.TabIndex = 0
		Me.usuarios.Text = "Gestionar Usuarios"
		Me.usuarios.UseVisualStyleBackColor = False
		'
		'alojamientos
		'
		Me.alojamientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.alojamientos.Location = New System.Drawing.Point(91, 130)
		Me.alojamientos.Name = "alojamientos"
		Me.alojamientos.Size = New System.Drawing.Size(190, 23)
		Me.alojamientos.TabIndex = 1
		Me.alojamientos.Text = "Gestionar Alojamientos"
		Me.alojamientos.UseVisualStyleBackColor = True
		'
		'reservas
		'
		Me.reservas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.reservas.Location = New System.Drawing.Point(91, 183)
		Me.reservas.Name = "reservas"
		Me.reservas.Size = New System.Drawing.Size(190, 23)
		Me.reservas.TabIndex = 2
		Me.reservas.Text = "Gestionar Reservas"
		Me.reservas.UseVisualStyleBackColor = True
		'
		'SelecionarOpcion
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(378, 299)
		Me.Controls.Add(Me.reservas)
		Me.Controls.Add(Me.alojamientos)
		Me.Controls.Add(Me.usuarios)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "SelecionarOpcion"
		Me.Text = "Opciones"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents usuarios As Button
	Friend WithEvents alojamientos As Button
	Friend WithEvents reservas As Button
End Class
