<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetallesReserva
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
		Me.codigoRes = New System.Windows.Forms.Label()
		Me.datosUsuario = New System.Windows.Forms.GroupBox()
		Me.detallesCliente = New System.Windows.Forms.Button()
		Me.apellidoUsu = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.nombreUsu = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.dniUsu = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.datosAlojamiento = New System.Windows.Forms.GroupBox()
		Me.detallesAlojamiento = New System.Windows.Forms.Button()
		Me.capacidadAloj = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.codigoAloj = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.nombreAloj = New System.Windows.Forms.ComboBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.datosUsuario.SuspendLayout()
		Me.datosAlojamiento.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(123, 70)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(163, 20)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Código de la reserva:"
		'
		'codigoRes
		'
		Me.codigoRes.AutoSize = True
		Me.codigoRes.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!)
		Me.codigoRes.Location = New System.Drawing.Point(292, 70)
		Me.codigoRes.Name = "codigoRes"
		Me.codigoRes.Size = New System.Drawing.Size(0, 20)
		Me.codigoRes.TabIndex = 1
		'
		'datosUsuario
		'
		Me.datosUsuario.Controls.Add(Me.detallesCliente)
		Me.datosUsuario.Controls.Add(Me.apellidoUsu)
		Me.datosUsuario.Controls.Add(Me.Label5)
		Me.datosUsuario.Controls.Add(Me.nombreUsu)
		Me.datosUsuario.Controls.Add(Me.Label4)
		Me.datosUsuario.Controls.Add(Me.dniUsu)
		Me.datosUsuario.Controls.Add(Me.Label2)
		Me.datosUsuario.Location = New System.Drawing.Point(127, 117)
		Me.datosUsuario.Name = "datosUsuario"
		Me.datosUsuario.Size = New System.Drawing.Size(302, 230)
		Me.datosUsuario.TabIndex = 2
		Me.datosUsuario.TabStop = False
		Me.datosUsuario.Text = "Datos del cliente:"
		'
		'detallesCliente
		'
		Me.detallesCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(178, Byte), Integer))
		Me.detallesCliente.Cursor = System.Windows.Forms.Cursors.Hand
		Me.detallesCliente.FlatAppearance.BorderSize = 0
		Me.detallesCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.detallesCliente.Location = New System.Drawing.Point(24, 172)
		Me.detallesCliente.Name = "detallesCliente"
		Me.detallesCliente.Size = New System.Drawing.Size(256, 34)
		Me.detallesCliente.TabIndex = 6
		Me.detallesCliente.Text = "Detalles del cliente"
		Me.detallesCliente.UseVisualStyleBackColor = False
		'
		'apellidoUsu
		'
		Me.apellidoUsu.AutoSize = True
		Me.apellidoUsu.Location = New System.Drawing.Point(86, 127)
		Me.apellidoUsu.Name = "apellidoUsu"
		Me.apellidoUsu.Size = New System.Drawing.Size(0, 17)
		Me.apellidoUsu.TabIndex = 5
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(21, 127)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(59, 17)
		Me.Label5.TabIndex = 4
		Me.Label5.Text = "Apellido:"
		'
		'nombreUsu
		'
		Me.nombreUsu.AutoSize = True
		Me.nombreUsu.Location = New System.Drawing.Point(87, 90)
		Me.nombreUsu.Name = "nombreUsu"
		Me.nombreUsu.Size = New System.Drawing.Size(0, 17)
		Me.nombreUsu.TabIndex = 3
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(21, 90)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(60, 17)
		Me.Label4.TabIndex = 2
		Me.Label4.Text = "Nombre:"
		'
		'dniUsu
		'
		Me.dniUsu.FormattingEnabled = True
		Me.dniUsu.Location = New System.Drawing.Point(24, 52)
		Me.dniUsu.Name = "dniUsu"
		Me.dniUsu.Size = New System.Drawing.Size(256, 25)
		Me.dniUsu.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(21, 32)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(34, 17)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "DNI:"
		'
		'datosAlojamiento
		'
		Me.datosAlojamiento.Controls.Add(Me.detallesAlojamiento)
		Me.datosAlojamiento.Controls.Add(Me.capacidadAloj)
		Me.datosAlojamiento.Controls.Add(Me.Label7)
		Me.datosAlojamiento.Controls.Add(Me.codigoAloj)
		Me.datosAlojamiento.Controls.Add(Me.Label6)
		Me.datosAlojamiento.Controls.Add(Me.nombreAloj)
		Me.datosAlojamiento.Controls.Add(Me.Label3)
		Me.datosAlojamiento.Location = New System.Drawing.Point(525, 117)
		Me.datosAlojamiento.Name = "datosAlojamiento"
		Me.datosAlojamiento.Size = New System.Drawing.Size(302, 230)
		Me.datosAlojamiento.TabIndex = 3
		Me.datosAlojamiento.TabStop = False
		Me.datosAlojamiento.Text = "Datos del alojamiento:"
		'
		'detallesAlojamiento
		'
		Me.detallesAlojamiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(178, Byte), Integer))
		Me.detallesAlojamiento.Cursor = System.Windows.Forms.Cursors.Hand
		Me.detallesAlojamiento.FlatAppearance.BorderSize = 0
		Me.detallesAlojamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.detallesAlojamiento.Location = New System.Drawing.Point(24, 172)
		Me.detallesAlojamiento.Name = "detallesAlojamiento"
		Me.detallesAlojamiento.Size = New System.Drawing.Size(256, 34)
		Me.detallesAlojamiento.TabIndex = 6
		Me.detallesAlojamiento.Text = "Detalles del alojamiento"
		Me.detallesAlojamiento.UseVisualStyleBackColor = False
		'
		'capacidadAloj
		'
		Me.capacidadAloj.AutoSize = True
		Me.capacidadAloj.Location = New System.Drawing.Point(100, 127)
		Me.capacidadAloj.Name = "capacidadAloj"
		Me.capacidadAloj.Size = New System.Drawing.Size(0, 17)
		Me.capacidadAloj.TabIndex = 5
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(21, 127)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(73, 17)
		Me.Label7.TabIndex = 4
		Me.Label7.Text = "Capacidad:"
		'
		'codigoAloj
		'
		Me.codigoAloj.AutoSize = True
		Me.codigoAloj.Location = New System.Drawing.Point(81, 90)
		Me.codigoAloj.Name = "codigoAloj"
		Me.codigoAloj.Size = New System.Drawing.Size(0, 17)
		Me.codigoAloj.TabIndex = 3
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(21, 90)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(54, 17)
		Me.Label6.TabIndex = 2
		Me.Label6.Text = "Código:"
		'
		'nombreAloj
		'
		Me.nombreAloj.FormattingEnabled = True
		Me.nombreAloj.Location = New System.Drawing.Point(24, 52)
		Me.nombreAloj.Name = "nombreAloj"
		Me.nombreAloj.Size = New System.Drawing.Size(256, 25)
		Me.nombreAloj.TabIndex = 1
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(21, 32)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(60, 17)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "Nombre:"
		'
		'DetallesReserva
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(950, 625)
		Me.Controls.Add(Me.datosAlojamiento)
		Me.Controls.Add(Me.datosUsuario)
		Me.Controls.Add(Me.codigoRes)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.Name = "DetallesReserva"
		Me.Padding = New System.Windows.Forms.Padding(120, 70, 120, 70)
		Me.Text = "DetallesReserva"
		Me.datosUsuario.ResumeLayout(False)
		Me.datosUsuario.PerformLayout()
		Me.datosAlojamiento.ResumeLayout(False)
		Me.datosAlojamiento.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents codigoRes As Label
	Friend WithEvents datosUsuario As GroupBox
	Friend WithEvents detallesCliente As Button
	Friend WithEvents apellidoUsu As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents nombreUsu As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents dniUsu As ComboBox
	Friend WithEvents Label2 As Label
	Friend WithEvents datosAlojamiento As GroupBox
	Friend WithEvents detallesAlojamiento As Button
	Friend WithEvents capacidadAloj As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents codigoAloj As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents nombreAloj As ComboBox
	Friend WithEvents Label3 As Label
End Class
