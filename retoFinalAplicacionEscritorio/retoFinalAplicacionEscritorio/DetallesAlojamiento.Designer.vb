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
		Me.Label2 = New System.Windows.Forms.Label()
		Me.labelCodigo = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.descripcion = New System.Windows.Forms.RichTextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.tipo = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.direccion = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.mail = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.web = New System.Windows.Forms.TextBox()
		Me.localidad = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.latitud = New System.Windows.Forms.TextBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.longitud = New System.Windows.Forms.TextBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.capacidad = New System.Windows.Forms.TextBox()
		Me.restSi = New System.Windows.Forms.RadioButton()
		Me.restNo = New System.Windows.Forms.RadioButton()
		Me.tiendaSi = New System.Windows.Forms.RadioButton()
		Me.tiendaNo = New System.Windows.Forms.RadioButton()
		Me.autoSi = New System.Windows.Forms.RadioButton()
		Me.autoNo = New System.Windows.Forms.RadioButton()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.restaurante = New System.Windows.Forms.GroupBox()
		Me.tienda = New System.Windows.Forms.GroupBox()
		Me.autocaravana = New System.Windows.Forms.GroupBox()
		Me.provincia = New System.Windows.Forms.ComboBox()
		Me.imagen = New System.Windows.Forms.PictureBox()
		Me.telefono = New System.Windows.Forms.MaskedTextBox()
		Me.cargarImagen = New System.Windows.Forms.Button()
		Me.actualizar = New System.Windows.Forms.Button()
		Me.nombre = New System.Windows.Forms.TextBox()
		Me.codigoPostal = New System.Windows.Forms.MaskedTextBox()
		Me.restaurante.SuspendLayout()
		Me.tienda.SuspendLayout()
		Me.autocaravana.SuspendLayout()
		CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'cancelar
		'
		Me.cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer))
		Me.cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(3, Byte), Integer))
		Me.cancelar.FlatAppearance.BorderSize = 2
		Me.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cancelar.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.cancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.cancelar.Location = New System.Drawing.Point(63, 530)
		Me.cancelar.Name = "cancelar"
		Me.cancelar.Size = New System.Drawing.Size(75, 32)
		Me.cancelar.TabIndex = 0
		Me.cancelar.Text = "Cancelar"
		Me.cancelar.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(63, 60)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(61, 17)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Nombre:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label2.Location = New System.Drawing.Point(238, 60)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(55, 17)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Código:"
		'
		'labelCodigo
		'
		Me.labelCodigo.AutoSize = True
		Me.labelCodigo.BackColor = System.Drawing.Color.Transparent
		Me.labelCodigo.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.labelCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.labelCodigo.Location = New System.Drawing.Point(298, 60)
		Me.labelCodigo.Name = "labelCodigo"
		Me.labelCodigo.Size = New System.Drawing.Size(0, 17)
		Me.labelCodigo.TabIndex = 4
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label3.Location = New System.Drawing.Point(60, 106)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(83, 17)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "Descripcion:"
		'
		'descripcion
		'
		Me.descripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.descripcion.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.descripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.descripcion.Location = New System.Drawing.Point(63, 127)
		Me.descripcion.Name = "descripcion"
		Me.descripcion.Size = New System.Drawing.Size(386, 149)
		Me.descripcion.TabIndex = 6
		Me.descripcion.Text = ""
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label4.Location = New System.Drawing.Point(63, 279)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(39, 17)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "Tipo:"
		'
		'tipo
		'
		Me.tipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.tipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.tipo.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.tipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.tipo.Location = New System.Drawing.Point(63, 299)
		Me.tipo.Name = "tipo"
		Me.tipo.Size = New System.Drawing.Size(140, 23)
		Me.tipo.TabIndex = 8
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label5.Location = New System.Drawing.Point(499, 108)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(69, 17)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "Dirección:"
		'
		'direccion
		'
		Me.direccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.direccion.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.direccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.direccion.Location = New System.Drawing.Point(502, 128)
		Me.direccion.Name = "direccion"
		Me.direccion.Size = New System.Drawing.Size(275, 23)
		Me.direccion.TabIndex = 10
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label6.Location = New System.Drawing.Point(60, 417)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(66, 17)
		Me.Label6.TabIndex = 11
		Me.Label6.Text = "Teléfono:"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.BackColor = System.Drawing.Color.Transparent
		Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label7.Location = New System.Drawing.Point(63, 325)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(124, 17)
		Me.Label7.TabIndex = 13
		Me.Label7.Text = "Correo electrónico:"
		'
		'mail
		'
		Me.mail.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.mail.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.mail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.mail.Location = New System.Drawing.Point(63, 345)
		Me.mail.Name = "mail"
		Me.mail.Size = New System.Drawing.Size(386, 23)
		Me.mail.TabIndex = 14
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.BackColor = System.Drawing.Color.Transparent
		Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label8.Location = New System.Drawing.Point(63, 371)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(39, 17)
		Me.Label8.TabIndex = 15
		Me.Label8.Text = "Web:"
		'
		'web
		'
		Me.web.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.web.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.web.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.web.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.web.Location = New System.Drawing.Point(63, 391)
		Me.web.Name = "web"
		Me.web.Size = New System.Drawing.Size(386, 23)
		Me.web.TabIndex = 16
		'
		'localidad
		'
		Me.localidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.localidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.localidad.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.localidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.localidad.Location = New System.Drawing.Point(695, 80)
		Me.localidad.Name = "localidad"
		Me.localidad.Size = New System.Drawing.Size(192, 23)
		Me.localidad.TabIndex = 18
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.BackColor = System.Drawing.Color.Transparent
		Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label10.Location = New System.Drawing.Point(499, 60)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(68, 17)
		Me.Label10.TabIndex = 19
		Me.Label10.Text = "Provincia:"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.BackColor = System.Drawing.Color.Transparent
		Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label11.Location = New System.Drawing.Point(499, 154)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(55, 17)
		Me.Label11.TabIndex = 21
		Me.Label11.Text = "Latitud:"
		'
		'latitud
		'
		Me.latitud.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.latitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.latitud.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.latitud.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.latitud.Location = New System.Drawing.Point(502, 174)
		Me.latitud.Name = "latitud"
		Me.latitud.Size = New System.Drawing.Size(122, 23)
		Me.latitud.TabIndex = 22
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.BackColor = System.Drawing.Color.Transparent
		Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label12.Location = New System.Drawing.Point(627, 154)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(67, 17)
		Me.Label12.TabIndex = 23
		Me.Label12.Text = "Longitud:"
		'
		'longitud
		'
		Me.longitud.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.longitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.longitud.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.longitud.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.longitud.Location = New System.Drawing.Point(630, 174)
		Me.longitud.Name = "longitud"
		Me.longitud.Size = New System.Drawing.Size(121, 23)
		Me.longitud.TabIndex = 24
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.BackColor = System.Drawing.Color.Transparent
		Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label13.Location = New System.Drawing.Point(783, 108)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(97, 17)
		Me.Label13.TabIndex = 25
		Me.Label13.Text = "Código postal:"
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.BackColor = System.Drawing.Color.Transparent
		Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label14.Location = New System.Drawing.Point(783, 154)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(74, 17)
		Me.Label14.TabIndex = 27
		Me.Label14.Text = "Capacidad:"
		'
		'capacidad
		'
		Me.capacidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.capacidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.capacidad.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.capacidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.capacidad.Location = New System.Drawing.Point(786, 174)
		Me.capacidad.Name = "capacidad"
		Me.capacidad.Size = New System.Drawing.Size(101, 23)
		Me.capacidad.TabIndex = 28
		'
		'restSi
		'
		Me.restSi.AutoSize = True
		Me.restSi.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.restSi.Location = New System.Drawing.Point(10, 17)
		Me.restSi.Name = "restSi"
		Me.restSi.Size = New System.Drawing.Size(36, 21)
		Me.restSi.TabIndex = 30
		Me.restSi.TabStop = True
		Me.restSi.Text = "Si"
		Me.restSi.UseVisualStyleBackColor = True
		'
		'restNo
		'
		Me.restNo.AutoSize = True
		Me.restNo.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.restNo.Location = New System.Drawing.Point(52, 17)
		Me.restNo.Name = "restNo"
		Me.restNo.Size = New System.Drawing.Size(44, 21)
		Me.restNo.TabIndex = 31
		Me.restNo.TabStop = True
		Me.restNo.Text = "No"
		Me.restNo.UseVisualStyleBackColor = True
		'
		'tiendaSi
		'
		Me.tiendaSi.AutoSize = True
		Me.tiendaSi.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.tiendaSi.Location = New System.Drawing.Point(6, 18)
		Me.tiendaSi.Name = "tiendaSi"
		Me.tiendaSi.Size = New System.Drawing.Size(37, 21)
		Me.tiendaSi.TabIndex = 33
		Me.tiendaSi.TabStop = True
		Me.tiendaSi.Text = "SI"
		Me.tiendaSi.UseVisualStyleBackColor = True
		'
		'tiendaNo
		'
		Me.tiendaNo.AutoSize = True
		Me.tiendaNo.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.tiendaNo.Location = New System.Drawing.Point(49, 18)
		Me.tiendaNo.Name = "tiendaNo"
		Me.tiendaNo.Size = New System.Drawing.Size(44, 21)
		Me.tiendaNo.TabIndex = 34
		Me.tiendaNo.TabStop = True
		Me.tiendaNo.Text = "No"
		Me.tiendaNo.UseVisualStyleBackColor = True
		'
		'autoSi
		'
		Me.autoSi.AutoSize = True
		Me.autoSi.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.autoSi.Location = New System.Drawing.Point(6, 17)
		Me.autoSi.Name = "autoSi"
		Me.autoSi.Size = New System.Drawing.Size(36, 21)
		Me.autoSi.TabIndex = 36
		Me.autoSi.TabStop = True
		Me.autoSi.Text = "Si"
		Me.autoSi.UseVisualStyleBackColor = True
		'
		'autoNo
		'
		Me.autoNo.AutoSize = True
		Me.autoNo.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.autoNo.Location = New System.Drawing.Point(48, 17)
		Me.autoNo.Name = "autoNo"
		Me.autoNo.Size = New System.Drawing.Size(44, 21)
		Me.autoNo.TabIndex = 37
		Me.autoNo.TabStop = True
		Me.autoNo.Text = "No"
		Me.autoNo.UseVisualStyleBackColor = True
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.BackColor = System.Drawing.Color.Transparent
		Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label9.Location = New System.Drawing.Point(692, 60)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(70, 17)
		Me.Label9.TabIndex = 17
		Me.Label9.Text = "Localidad:"
		'
		'restaurante
		'
		Me.restaurante.BackColor = System.Drawing.Color.Transparent
		Me.restaurante.Controls.Add(Me.restNo)
		Me.restaurante.Controls.Add(Me.restSi)
		Me.restaurante.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.restaurante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.restaurante.Location = New System.Drawing.Point(643, 223)
		Me.restaurante.Name = "restaurante"
		Me.restaurante.Size = New System.Drawing.Size(108, 39)
		Me.restaurante.TabIndex = 38
		Me.restaurante.TabStop = False
		Me.restaurante.Text = "Restaurante:"
		'
		'tienda
		'
		Me.tienda.BackColor = System.Drawing.Color.Transparent
		Me.tienda.Controls.Add(Me.tiendaNo)
		Me.tienda.Controls.Add(Me.tiendaSi)
		Me.tienda.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.tienda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.tienda.Location = New System.Drawing.Point(502, 222)
		Me.tienda.Name = "tienda"
		Me.tienda.Size = New System.Drawing.Size(108, 40)
		Me.tienda.TabIndex = 39
		Me.tienda.TabStop = False
		Me.tienda.Text = "Tienda:"
		'
		'autocaravana
		'
		Me.autocaravana.BackColor = System.Drawing.Color.Transparent
		Me.autocaravana.Controls.Add(Me.autoSi)
		Me.autocaravana.Controls.Add(Me.autoNo)
		Me.autocaravana.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.autocaravana.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.autocaravana.Location = New System.Drawing.Point(779, 223)
		Me.autocaravana.Name = "autocaravana"
		Me.autocaravana.Size = New System.Drawing.Size(108, 39)
		Me.autocaravana.TabIndex = 40
		Me.autocaravana.TabStop = False
		Me.autocaravana.Text = "Autocaravana:"
		'
		'provincia
		'
		Me.provincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.provincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.provincia.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.provincia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.provincia.FormattingEnabled = True
		Me.provincia.Location = New System.Drawing.Point(502, 80)
		Me.provincia.Name = "provincia"
		Me.provincia.Size = New System.Drawing.Size(187, 25)
		Me.provincia.TabIndex = 41
		'
		'imagen
		'
		Me.imagen.Location = New System.Drawing.Point(502, 267)
		Me.imagen.Name = "imagen"
		Me.imagen.Size = New System.Drawing.Size(385, 212)
		Me.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.imagen.TabIndex = 42
		Me.imagen.TabStop = False
		'
		'telefono
		'
		Me.telefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.telefono.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.telefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.telefono.Location = New System.Drawing.Point(63, 437)
		Me.telefono.Mask = "000000000"
		Me.telefono.Name = "telefono"
		Me.telefono.Size = New System.Drawing.Size(117, 23)
		Me.telefono.TabIndex = 43
		'
		'cargarImagen
		'
		Me.cargarImagen.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer))
		Me.cargarImagen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(178, Byte), Integer))
		Me.cargarImagen.FlatAppearance.BorderSize = 2
		Me.cargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cargarImagen.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.cargarImagen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.cargarImagen.Location = New System.Drawing.Point(502, 475)
		Me.cargarImagen.Name = "cargarImagen"
		Me.cargarImagen.Size = New System.Drawing.Size(385, 37)
		Me.cargarImagen.TabIndex = 44
		Me.cargarImagen.Text = "Seleccionar imagen"
		Me.cargarImagen.UseVisualStyleBackColor = False
		'
		'actualizar
		'
		Me.actualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer))
		Me.actualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(3, Byte), Integer))
		Me.actualizar.FlatAppearance.BorderSize = 2
		Me.actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.actualizar.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.actualizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.actualizar.Location = New System.Drawing.Point(807, 530)
		Me.actualizar.Name = "actualizar"
		Me.actualizar.Size = New System.Drawing.Size(80, 32)
		Me.actualizar.TabIndex = 46
		Me.actualizar.Text = "Guardar"
		Me.actualizar.UseVisualStyleBackColor = False
		'
		'nombre
		'
		Me.nombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.nombre.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.nombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.nombre.Location = New System.Drawing.Point(63, 80)
		Me.nombre.Name = "nombre"
		Me.nombre.Size = New System.Drawing.Size(386, 23)
		Me.nombre.TabIndex = 47
		'
		'codigoPostal
		'
		Me.codigoPostal.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.codigoPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.codigoPostal.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.codigoPostal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.codigoPostal.Location = New System.Drawing.Point(786, 128)
		Me.codigoPostal.Mask = "00000"
		Me.codigoPostal.Name = "codigoPostal"
		Me.codigoPostal.Size = New System.Drawing.Size(104, 23)
		Me.codigoPostal.TabIndex = 49
		'
		'DetallesAlojamiento
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(950, 625)
		Me.Controls.Add(Me.codigoPostal)
		Me.Controls.Add(Me.nombre)
		Me.Controls.Add(Me.actualizar)
		Me.Controls.Add(Me.cargarImagen)
		Me.Controls.Add(Me.telefono)
		Me.Controls.Add(Me.imagen)
		Me.Controls.Add(Me.provincia)
		Me.Controls.Add(Me.autocaravana)
		Me.Controls.Add(Me.tienda)
		Me.Controls.Add(Me.restaurante)
		Me.Controls.Add(Me.capacidad)
		Me.Controls.Add(Me.Label14)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.longitud)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.latitud)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.localidad)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.web)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.mail)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.direccion)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.tipo)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.descripcion)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.labelCodigo)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.cancelar)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.MaximizeBox = False
		Me.Name = "DetallesAlojamiento"
		Me.Padding = New System.Windows.Forms.Padding(60)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Detalles del alojamiento"
		Me.restaurante.ResumeLayout(False)
		Me.restaurante.PerformLayout()
		Me.tienda.ResumeLayout(False)
		Me.tienda.PerformLayout()
		Me.autocaravana.ResumeLayout(False)
		Me.autocaravana.PerformLayout()
		CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents cancelar As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents labelCodigo As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents descripcion As RichTextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents tipo As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents direccion As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents mail As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents web As TextBox
	Friend WithEvents localidad As TextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents latitud As TextBox
	Friend WithEvents Label12 As Label
	Friend WithEvents longitud As TextBox
	Friend WithEvents Label13 As Label
	Friend WithEvents Label14 As Label
	Friend WithEvents capacidad As TextBox
	Friend WithEvents restSi As RadioButton
	Friend WithEvents restNo As RadioButton
	Friend WithEvents tiendaSi As RadioButton
	Friend WithEvents tiendaNo As RadioButton
	Friend WithEvents autoSi As RadioButton
	Friend WithEvents autoNo As RadioButton
	Friend WithEvents Label9 As Label
	Friend WithEvents restaurante As GroupBox
	Friend WithEvents tienda As GroupBox
	Friend WithEvents autocaravana As GroupBox
	Friend WithEvents provincia As ComboBox
	Friend WithEvents imagen As PictureBox
	Friend WithEvents telefono As MaskedTextBox
	Friend WithEvents cargarImagen As Button
	Friend WithEvents actualizar As Button
	Friend WithEvents nombre As TextBox
	Friend WithEvents codigoPostal As MaskedTextBox
End Class
