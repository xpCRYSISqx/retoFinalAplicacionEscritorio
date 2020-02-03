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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.capacidadDisponible = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.capacidadAloj = New System.Windows.Forms.Label()
		Me.detallesAlojamiento = New System.Windows.Forms.Button()
		Me.codigoAloj = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.nombreAloj = New System.Windows.Forms.ComboBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.fechaEntrada = New System.Windows.Forms.DateTimePicker()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.fechaSalida = New System.Windows.Forms.DateTimePicker()
		Me.actualiza = New System.Windows.Forms.Button()
		Me.atras = New System.Windows.Forms.Button()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.numeroPersonas = New System.Windows.Forms.NumericUpDown()
		Me.datosUsuario.SuspendLayout()
		Me.datosAlojamiento.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		CType(Me.numeroPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(123, 99)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(182, 22)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Código de la reserva:"
		'
		'codigoRes
		'
		Me.codigoRes.AutoSize = True
		Me.codigoRes.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.codigoRes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.codigoRes.Location = New System.Drawing.Point(311, 103)
		Me.codigoRes.Name = "codigoRes"
		Me.codigoRes.Size = New System.Drawing.Size(0, 22)
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
		Me.datosUsuario.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.datosUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.datosUsuario.Location = New System.Drawing.Point(127, 140)
		Me.datosUsuario.Name = "datosUsuario"
		Me.datosUsuario.Size = New System.Drawing.Size(302, 230)
		Me.datosUsuario.TabIndex = 2
		Me.datosUsuario.TabStop = False
		Me.datosUsuario.Text = "Datos del cliente:"
		'
		'detallesCliente
		'
		Me.detallesCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer))
		Me.detallesCliente.Cursor = System.Windows.Forms.Cursors.Hand
		Me.detallesCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(178, Byte), Integer))
		Me.detallesCliente.FlatAppearance.BorderSize = 2
		Me.detallesCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.detallesCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
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
		Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label5.Location = New System.Drawing.Point(21, 127)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(63, 17)
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
		Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label4.Location = New System.Drawing.Point(21, 90)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(61, 17)
		Me.Label4.TabIndex = 2
		Me.Label4.Text = "Nombre:"
		'
		'dniUsu
		'
		Me.dniUsu.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.dniUsu.Cursor = System.Windows.Forms.Cursors.Hand
		Me.dniUsu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.dniUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.dniUsu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.dniUsu.FormattingEnabled = True
		Me.dniUsu.Location = New System.Drawing.Point(24, 52)
		Me.dniUsu.Name = "dniUsu"
		Me.dniUsu.Size = New System.Drawing.Size(256, 25)
		Me.dniUsu.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label2.Location = New System.Drawing.Point(21, 32)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(35, 17)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "DNI:"
		'
		'datosAlojamiento
		'
		Me.datosAlojamiento.Controls.Add(Me.GroupBox1)
		Me.datosAlojamiento.Controls.Add(Me.detallesAlojamiento)
		Me.datosAlojamiento.Controls.Add(Me.codigoAloj)
		Me.datosAlojamiento.Controls.Add(Me.Label6)
		Me.datosAlojamiento.Controls.Add(Me.nombreAloj)
		Me.datosAlojamiento.Controls.Add(Me.Label3)
		Me.datosAlojamiento.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.datosAlojamiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.datosAlojamiento.Location = New System.Drawing.Point(525, 140)
		Me.datosAlojamiento.Name = "datosAlojamiento"
		Me.datosAlojamiento.Size = New System.Drawing.Size(302, 230)
		Me.datosAlojamiento.TabIndex = 3
		Me.datosAlojamiento.TabStop = False
		Me.datosAlojamiento.Text = "Datos del alojamiento:"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.capacidadDisponible)
		Me.GroupBox1.Controls.Add(Me.Label11)
		Me.GroupBox1.Controls.Add(Me.Label7)
		Me.GroupBox1.Controls.Add(Me.capacidadAloj)
		Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.GroupBox1.Location = New System.Drawing.Point(24, 120)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(256, 46)
		Me.GroupBox1.TabIndex = 7
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Capacidad:"
		'
		'capacidadDisponible
		'
		Me.capacidadDisponible.AutoSize = True
		Me.capacidadDisponible.Location = New System.Drawing.Point(195, 19)
		Me.capacidadDisponible.Name = "capacidadDisponible"
		Me.capacidadDisponible.Size = New System.Drawing.Size(0, 17)
		Me.capacidadDisponible.TabIndex = 24
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label11.Location = New System.Drawing.Point(116, 19)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(78, 17)
		Me.Label11.TabIndex = 24
		Me.Label11.Text = "Disponible:"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label7.Location = New System.Drawing.Point(6, 19)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(43, 17)
		Me.Label7.TabIndex = 0
		Me.Label7.Text = "Total:"
		'
		'capacidadAloj
		'
		Me.capacidadAloj.AutoSize = True
		Me.capacidadAloj.Location = New System.Drawing.Point(52, 19)
		Me.capacidadAloj.Name = "capacidadAloj"
		Me.capacidadAloj.Size = New System.Drawing.Size(0, 17)
		Me.capacidadAloj.TabIndex = 5
		'
		'detallesAlojamiento
		'
		Me.detallesAlojamiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer))
		Me.detallesAlojamiento.Cursor = System.Windows.Forms.Cursors.Hand
		Me.detallesAlojamiento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(178, Byte), Integer))
		Me.detallesAlojamiento.FlatAppearance.BorderSize = 2
		Me.detallesAlojamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.detallesAlojamiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.detallesAlojamiento.Location = New System.Drawing.Point(24, 172)
		Me.detallesAlojamiento.Name = "detallesAlojamiento"
		Me.detallesAlojamiento.Size = New System.Drawing.Size(256, 34)
		Me.detallesAlojamiento.TabIndex = 6
		Me.detallesAlojamiento.Text = "Detalles del alojamiento"
		Me.detallesAlojamiento.UseVisualStyleBackColor = False
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
		Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label6.Location = New System.Drawing.Point(21, 90)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(55, 17)
		Me.Label6.TabIndex = 2
		Me.Label6.Text = "Código:"
		'
		'nombreAloj
		'
		Me.nombreAloj.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.nombreAloj.Cursor = System.Windows.Forms.Cursors.Hand
		Me.nombreAloj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.nombreAloj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.nombreAloj.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.nombreAloj.FormattingEnabled = True
		Me.nombreAloj.Location = New System.Drawing.Point(24, 52)
		Me.nombreAloj.Name = "nombreAloj"
		Me.nombreAloj.Size = New System.Drawing.Size(256, 25)
		Me.nombreAloj.TabIndex = 1
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label3.Location = New System.Drawing.Point(21, 32)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(61, 17)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "Nombre:"
		'
		'fechaEntrada
		'
		Me.fechaEntrada.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.fechaEntrada.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.fechaEntrada.Cursor = System.Windows.Forms.Cursors.Default
		Me.fechaEntrada.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
		Me.fechaEntrada.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.fechaEntrada.Location = New System.Drawing.Point(187, 406)
		Me.fechaEntrada.Name = "fechaEntrada"
		Me.fechaEntrada.Size = New System.Drawing.Size(192, 23)
		Me.fechaEntrada.TabIndex = 4
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label8.Location = New System.Drawing.Point(213, 383)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(116, 17)
		Me.Label8.TabIndex = 5
		Me.Label8.Text = "Fecha de entrada:"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label9.Location = New System.Drawing.Point(615, 383)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(105, 17)
		Me.Label9.TabIndex = 6
		Me.Label9.Text = "Fecha de salida:"
		'
		'fechaSalida
		'
		Me.fechaSalida.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.fechaSalida.Cursor = System.Windows.Forms.Cursors.Default
		Me.fechaSalida.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
		Me.fechaSalida.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.fechaSalida.Location = New System.Drawing.Point(580, 406)
		Me.fechaSalida.Name = "fechaSalida"
		Me.fechaSalida.Size = New System.Drawing.Size(192, 23)
		Me.fechaSalida.TabIndex = 7
		'
		'actualiza
		'
		Me.actualiza.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer))
		Me.actualiza.Cursor = System.Windows.Forms.Cursors.Hand
		Me.actualiza.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(6, Byte), Integer))
		Me.actualiza.FlatAppearance.BorderSize = 2
		Me.actualiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.actualiza.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.actualiza.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.actualiza.Location = New System.Drawing.Point(801, 532)
		Me.actualiza.Name = "actualiza"
		Me.actualiza.Size = New System.Drawing.Size(86, 30)
		Me.actualiza.TabIndex = 20
		Me.actualiza.Text = "Guardar"
		Me.actualiza.UseVisualStyleBackColor = False
		'
		'atras
		'
		Me.atras.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer))
		Me.atras.Cursor = System.Windows.Forms.Cursors.Hand
		Me.atras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(6, Byte), Integer))
		Me.atras.FlatAppearance.BorderSize = 2
		Me.atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.atras.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.atras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.atras.Location = New System.Drawing.Point(63, 532)
		Me.atras.Name = "atras"
		Me.atras.Size = New System.Drawing.Size(86, 30)
		Me.atras.TabIndex = 18
		Me.atras.Text = "Cancelar"
		Me.atras.UseVisualStyleBackColor = False
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label10.Location = New System.Drawing.Point(521, 99)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(88, 22)
		Me.Label10.TabIndex = 22
		Me.Label10.Text = "Personas:"
		'
		'numeroPersonas
		'
		Me.numeroPersonas.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.numeroPersonas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.numeroPersonas.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.numeroPersonas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.numeroPersonas.Location = New System.Drawing.Point(615, 98)
		Me.numeroPersonas.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
		Me.numeroPersonas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.numeroPersonas.Name = "numeroPersonas"
		Me.numeroPersonas.Size = New System.Drawing.Size(58, 23)
		Me.numeroPersonas.TabIndex = 23
		Me.numeroPersonas.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'DetallesReserva
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(950, 625)
		Me.Controls.Add(Me.numeroPersonas)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.actualiza)
		Me.Controls.Add(Me.atras)
		Me.Controls.Add(Me.fechaSalida)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.fechaEntrada)
		Me.Controls.Add(Me.datosAlojamiento)
		Me.Controls.Add(Me.datosUsuario)
		Me.Controls.Add(Me.codigoRes)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.Name = "DetallesReserva"
		Me.Padding = New System.Windows.Forms.Padding(60)
		Me.Text = "DetallesReserva"
		Me.datosUsuario.ResumeLayout(False)
		Me.datosUsuario.PerformLayout()
		Me.datosAlojamiento.ResumeLayout(False)
		Me.datosAlojamiento.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.numeroPersonas, System.ComponentModel.ISupportInitialize).EndInit()
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
	Friend WithEvents codigoAloj As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents nombreAloj As ComboBox
	Friend WithEvents Label3 As Label
	Friend WithEvents fechaEntrada As DateTimePicker
	Friend WithEvents Label8 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents fechaSalida As DateTimePicker
	Friend WithEvents actualiza As Button
	Friend WithEvents atras As Button
	Friend WithEvents Label10 As Label
	Friend WithEvents numeroPersonas As NumericUpDown
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents capacidadDisponible As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents Label7 As Label
End Class
