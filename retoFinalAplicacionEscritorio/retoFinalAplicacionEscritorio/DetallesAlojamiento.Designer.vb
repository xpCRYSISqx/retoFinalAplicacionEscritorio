<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetallesAlojamiento
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
		Me.cancelar = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.nombre = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.labelCodigo = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.descripcion = New System.Windows.Forms.RichTextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.tipo = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.direccion = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.telefono = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.mail = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.web = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Region = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.provincia = New System.Windows.Forms.TextBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.latitud = New System.Windows.Forms.TextBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.longitud = New System.Windows.Forms.TextBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.codigoPostal = New System.Windows.Forms.TextBox()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.capacidad = New System.Windows.Forms.TextBox()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		Me.RadioButton2 = New System.Windows.Forms.RadioButton()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.RadioButton3 = New System.Windows.Forms.RadioButton()
		Me.RadioButton4 = New System.Windows.Forms.RadioButton()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.RadioButton5 = New System.Windows.Forms.RadioButton()
		Me.RadioButton6 = New System.Windows.Forms.RadioButton()
		Me.SuspendLayout()
		'
		'cancelar
		'
		Me.cancelar.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.cancelar.Location = New System.Drawing.Point(33, 599)
		Me.cancelar.Name = "cancelar"
		Me.cancelar.Size = New System.Drawing.Size(75, 23)
		Me.cancelar.TabIndex = 0
		Me.cancelar.Text = "Cancelar"
		Me.cancelar.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(33, 30)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(60, 17)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Nombre:"
		'
		'nombre
		'
		Me.nombre.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.nombre.Location = New System.Drawing.Point(99, 29)
		Me.nombre.Name = "nombre"
		Me.nombre.Size = New System.Drawing.Size(160, 23)
		Me.nombre.TabIndex = 2
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.Label2.Location = New System.Drawing.Point(265, 30)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(54, 17)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Código:"
		'
		'labelCodigo
		'
		Me.labelCodigo.AutoSize = True
		Me.labelCodigo.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.labelCodigo.Location = New System.Drawing.Point(325, 30)
		Me.labelCodigo.Name = "labelCodigo"
		Me.labelCodigo.Size = New System.Drawing.Size(0, 17)
		Me.labelCodigo.TabIndex = 4
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.Label3.Location = New System.Drawing.Point(33, 65)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(79, 17)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "Descripcion:"
		'
		'descripcion
		'
		Me.descripcion.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.descripcion.Location = New System.Drawing.Point(118, 64)
		Me.descripcion.Name = "descripcion"
		Me.descripcion.Size = New System.Drawing.Size(311, 46)
		Me.descripcion.TabIndex = 6
		Me.descripcion.Text = ""
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.Label4.Location = New System.Drawing.Point(33, 119)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(37, 17)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "Tipo:"
		'
		'tipo
		'
		Me.tipo.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.tipo.Location = New System.Drawing.Point(76, 118)
		Me.tipo.Name = "tipo"
		Me.tipo.Size = New System.Drawing.Size(140, 23)
		Me.tipo.TabIndex = 8
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.Label5.Location = New System.Drawing.Point(33, 375)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(65, 17)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "Dirección:"
		'
		'direccion
		'
		Me.direccion.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.direccion.Location = New System.Drawing.Point(104, 374)
		Me.direccion.Name = "direccion"
		Me.direccion.Size = New System.Drawing.Size(114, 23)
		Me.direccion.TabIndex = 10
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.Label6.Location = New System.Drawing.Point(33, 175)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(62, 17)
		Me.Label6.TabIndex = 11
		Me.Label6.Text = "Teléfono:"
		'
		'telefono
		'
		Me.telefono.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.telefono.Location = New System.Drawing.Point(101, 174)
		Me.telefono.Name = "telefono"
		Me.telefono.Size = New System.Drawing.Size(117, 23)
		Me.telefono.TabIndex = 12
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.Label7.Location = New System.Drawing.Point(35, 211)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(47, 17)
		Me.Label7.TabIndex = 13
		Me.Label7.Text = "E-mail:"
		'
		'mail
		'
		Me.mail.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.mail.Location = New System.Drawing.Point(88, 210)
		Me.mail.Name = "mail"
		Me.mail.Size = New System.Drawing.Size(343, 23)
		Me.mail.TabIndex = 14
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.Label8.Location = New System.Drawing.Point(35, 246)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(38, 17)
		Me.Label8.TabIndex = 15
		Me.Label8.Text = "Web:"
		'
		'web
		'
		Me.web.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.web.Location = New System.Drawing.Point(78, 245)
		Me.web.Name = "web"
		Me.web.Size = New System.Drawing.Size(353, 23)
		Me.web.TabIndex = 16
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.Label9.Location = New System.Drawing.Point(33, 343)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(52, 17)
		Me.Label9.TabIndex = 17
		Me.Label9.Text = "Region:"
		'
		'Region
		'
		Me.Region.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.Region.Location = New System.Drawing.Point(91, 340)
		Me.Region.Name = "Region"
		Me.Region.Size = New System.Drawing.Size(168, 23)
		Me.Region.TabIndex = 18
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.Label10.Location = New System.Drawing.Point(33, 309)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(63, 17)
		Me.Label10.TabIndex = 19
		Me.Label10.Text = "Provincia:"
		'
		'provincia
		'
		Me.provincia.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.provincia.Location = New System.Drawing.Point(102, 308)
		Me.provincia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.provincia.Name = "provincia"
		Me.provincia.Size = New System.Drawing.Size(167, 23)
		Me.provincia.TabIndex = 20
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.Label11.Location = New System.Drawing.Point(33, 408)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(50, 17)
		Me.Label11.TabIndex = 21
		Me.Label11.Text = "Latitud:"
		'
		'latitud
		'
		Me.latitud.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.latitud.Location = New System.Drawing.Point(89, 407)
		Me.latitud.Name = "latitud"
		Me.latitud.Size = New System.Drawing.Size(100, 23)
		Me.latitud.TabIndex = 22
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.Label12.Location = New System.Drawing.Point(198, 410)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(62, 17)
		Me.Label12.TabIndex = 23
		Me.Label12.Text = "Longitud:"
		'
		'longitud
		'
		Me.longitud.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.longitud.Location = New System.Drawing.Point(266, 409)
		Me.longitud.Name = "longitud"
		Me.longitud.Size = New System.Drawing.Size(100, 23)
		Me.longitud.TabIndex = 24
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.Label13.Location = New System.Drawing.Point(231, 375)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(94, 17)
		Me.Label13.TabIndex = 25
		Me.Label13.Text = "Código postal:"
		'
		'codigoPostal
		'
		Me.codigoPostal.Location = New System.Drawing.Point(331, 376)
		Me.codigoPostal.Name = "codigoPostal"
		Me.codigoPostal.Size = New System.Drawing.Size(98, 20)
		Me.codigoPostal.TabIndex = 26
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.Label14.Location = New System.Drawing.Point(33, 471)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(73, 17)
		Me.Label14.TabIndex = 27
		Me.Label14.Text = "Capacidad:"
		'
		'capacidad
		'
		Me.capacidad.Location = New System.Drawing.Point(112, 470)
		Me.capacidad.Name = "capacidad"
		Me.capacidad.Size = New System.Drawing.Size(55, 20)
		Me.capacidad.TabIndex = 28
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.Label15.Location = New System.Drawing.Point(33, 502)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(80, 17)
		Me.Label15.TabIndex = 29
		Me.Label15.Text = "Restaurante:"
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.RadioButton1.Location = New System.Drawing.Point(119, 500)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(36, 21)
		Me.RadioButton1.TabIndex = 30
		Me.RadioButton1.TabStop = True
		Me.RadioButton1.Text = "Si"
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'RadioButton2
		'
		Me.RadioButton2.AutoSize = True
		Me.RadioButton2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.RadioButton2.Location = New System.Drawing.Point(161, 500)
		Me.RadioButton2.Name = "RadioButton2"
		Me.RadioButton2.Size = New System.Drawing.Size(44, 21)
		Me.RadioButton2.TabIndex = 31
		Me.RadioButton2.TabStop = True
		Me.RadioButton2.Text = "No"
		Me.RadioButton2.UseVisualStyleBackColor = True
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.Label16.Location = New System.Drawing.Point(33, 529)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(50, 17)
		Me.Label16.TabIndex = 32
		Me.Label16.Text = "Tienda:"
		'
		'RadioButton3
		'
		Me.RadioButton3.AutoSize = True
		Me.RadioButton3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.RadioButton3.Location = New System.Drawing.Point(89, 527)
		Me.RadioButton3.Name = "RadioButton3"
		Me.RadioButton3.Size = New System.Drawing.Size(37, 21)
		Me.RadioButton3.TabIndex = 33
		Me.RadioButton3.TabStop = True
		Me.RadioButton3.Text = "SI"
		Me.RadioButton3.UseVisualStyleBackColor = True
		'
		'RadioButton4
		'
		Me.RadioButton4.AutoSize = True
		Me.RadioButton4.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.RadioButton4.Location = New System.Drawing.Point(132, 527)
		Me.RadioButton4.Name = "RadioButton4"
		Me.RadioButton4.Size = New System.Drawing.Size(44, 21)
		Me.RadioButton4.TabIndex = 34
		Me.RadioButton4.TabStop = True
		Me.RadioButton4.Text = "No"
		Me.RadioButton4.UseVisualStyleBackColor = True
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.Label17.Location = New System.Drawing.Point(33, 551)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(90, 17)
		Me.Label17.TabIndex = 35
		Me.Label17.Text = "Autocaravana:"
		'
		'RadioButton5
		'
		Me.RadioButton5.AutoSize = True
		Me.RadioButton5.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.RadioButton5.Location = New System.Drawing.Point(129, 549)
		Me.RadioButton5.Name = "RadioButton5"
		Me.RadioButton5.Size = New System.Drawing.Size(36, 21)
		Me.RadioButton5.TabIndex = 36
		Me.RadioButton5.TabStop = True
		Me.RadioButton5.Text = "Si"
		Me.RadioButton5.UseVisualStyleBackColor = True
		'
		'RadioButton6
		'
		Me.RadioButton6.AutoSize = True
		Me.RadioButton6.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.RadioButton6.Location = New System.Drawing.Point(171, 549)
		Me.RadioButton6.Name = "RadioButton6"
		Me.RadioButton6.Size = New System.Drawing.Size(44, 21)
		Me.RadioButton6.TabIndex = 37
		Me.RadioButton6.TabStop = True
		Me.RadioButton6.Text = "No"
		Me.RadioButton6.UseVisualStyleBackColor = True
		'
		'DetallesAlojamiento
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(462, 655)
		Me.Controls.Add(Me.RadioButton6)
		Me.Controls.Add(Me.RadioButton5)
		Me.Controls.Add(Me.Label17)
		Me.Controls.Add(Me.RadioButton4)
		Me.Controls.Add(Me.RadioButton3)
		Me.Controls.Add(Me.Label16)
		Me.Controls.Add(Me.RadioButton2)
		Me.Controls.Add(Me.RadioButton1)
		Me.Controls.Add(Me.Label15)
		Me.Controls.Add(Me.capacidad)
		Me.Controls.Add(Me.Label14)
		Me.Controls.Add(Me.codigoPostal)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.longitud)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.latitud)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.provincia)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.Region)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.web)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.mail)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.telefono)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.direccion)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.tipo)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.descripcion)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.labelCodigo)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.nombre)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.cancelar)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Name = "DetallesAlojamiento"
		Me.Padding = New System.Windows.Forms.Padding(30, 30, 30, 30)
		Me.Text = "Detalles Alojamiento"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents cancelar As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents nombre As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents labelCodigo As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents descripcion As RichTextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents tipo As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents direccion As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents telefono As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents mail As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents web As TextBox
	Friend WithEvents Label9 As Label
	Friend WithEvents Region As TextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents provincia As TextBox
	Friend WithEvents Label11 As Label
	Friend WithEvents latitud As TextBox
	Friend WithEvents Label12 As Label
	Friend WithEvents longitud As TextBox
	Friend WithEvents Label13 As Label
	Friend WithEvents codigoPostal As TextBox
	Friend WithEvents Label14 As Label
	Friend WithEvents capacidad As TextBox
	Friend WithEvents Label15 As Label
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents RadioButton2 As RadioButton
	Friend WithEvents Label16 As Label
	Friend WithEvents RadioButton3 As RadioButton
	Friend WithEvents RadioButton4 As RadioButton
	Friend WithEvents Label17 As Label
	Friend WithEvents RadioButton5 As RadioButton
	Friend WithEvents RadioButton6 As RadioButton
End Class
