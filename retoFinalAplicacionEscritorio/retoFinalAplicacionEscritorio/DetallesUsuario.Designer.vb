<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DetallesUsuario
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.nombre = New System.Windows.Forms.TextBox()
		Me.apellido = New System.Windows.Forms.TextBox()
		Me.mail = New System.Windows.Forms.TextBox()
		Me.telefono = New System.Windows.Forms.MaskedTextBox()
		Me.admin = New System.Windows.Forms.GroupBox()
		Me.adminNo = New System.Windows.Forms.RadioButton()
		Me.adminSi = New System.Windows.Forms.RadioButton()
		Me.atras = New System.Windows.Forms.Button()
		Me.cambiarContrasena = New System.Windows.Forms.Button()
		Me.actualiza = New System.Windows.Forms.Button()
		Me.dni = New System.Windows.Forms.Label()
		Me.activo = New System.Windows.Forms.GroupBox()
		Me.actNo = New System.Windows.Forms.RadioButton()
		Me.actSi = New System.Windows.Forms.RadioButton()
		Me.PanelContrasena = New System.Windows.Forms.Panel()
		Me.labelError = New System.Windows.Forms.Label()
		Me.cancelar = New System.Windows.Forms.Button()
		Me.aceptar = New System.Windows.Forms.Button()
		Me.contra2 = New System.Windows.Forms.TextBox()
		Me.contra1 = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.admin.SuspendLayout()
		Me.activo.SuspendLayout()
		Me.PanelContrasena.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(159, 24)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(47, 22)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "DNI:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label2.Location = New System.Drawing.Point(160, 72)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(61, 17)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Nombre:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label3.Location = New System.Drawing.Point(495, 72)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(63, 17)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Apellido:"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label5.Location = New System.Drawing.Point(160, 224)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(124, 17)
		Me.Label5.TabIndex = 4
		Me.Label5.Text = "Correo Electrónico:"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label6.Location = New System.Drawing.Point(495, 224)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(66, 17)
		Me.Label6.TabIndex = 5
		Me.Label6.Text = "Teléfono:"
		'
		'nombre
		'
		Me.nombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.nombre.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.nombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.nombre.Location = New System.Drawing.Point(163, 92)
		Me.nombre.Name = "nombre"
		Me.nombre.Size = New System.Drawing.Size(302, 23)
		Me.nombre.TabIndex = 7
		'
		'apellido
		'
		Me.apellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.apellido.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.apellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.apellido.Location = New System.Drawing.Point(496, 92)
		Me.apellido.Name = "apellido"
		Me.apellido.Size = New System.Drawing.Size(303, 23)
		Me.apellido.TabIndex = 8
		'
		'mail
		'
		Me.mail.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.mail.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.mail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.mail.Location = New System.Drawing.Point(163, 244)
		Me.mail.Name = "mail"
		Me.mail.Size = New System.Drawing.Size(308, 23)
		Me.mail.TabIndex = 10
		'
		'telefono
		'
		Me.telefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.telefono.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.telefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.telefono.Location = New System.Drawing.Point(497, 244)
		Me.telefono.Mask = "000000000"
		Me.telefono.Name = "telefono"
		Me.telefono.Size = New System.Drawing.Size(113, 23)
		Me.telefono.TabIndex = 11
		'
		'admin
		'
		Me.admin.BackColor = System.Drawing.Color.Transparent
		Me.admin.Controls.Add(Me.adminNo)
		Me.admin.Controls.Add(Me.adminSi)
		Me.admin.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.admin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.admin.Location = New System.Drawing.Point(348, 142)
		Me.admin.Name = "admin"
		Me.admin.Size = New System.Drawing.Size(117, 52)
		Me.admin.TabIndex = 12
		Me.admin.TabStop = False
		Me.admin.Text = "Administrador:"
		'
		'adminNo
		'
		Me.adminNo.AutoSize = True
		Me.adminNo.Location = New System.Drawing.Point(62, 22)
		Me.adminNo.Name = "adminNo"
		Me.adminNo.Size = New System.Drawing.Size(44, 21)
		Me.adminNo.TabIndex = 14
		Me.adminNo.TabStop = True
		Me.adminNo.Text = "No"
		Me.adminNo.UseVisualStyleBackColor = True
		'
		'adminSi
		'
		Me.adminSi.AutoSize = True
		Me.adminSi.Location = New System.Drawing.Point(20, 22)
		Me.adminSi.Name = "adminSi"
		Me.adminSi.Size = New System.Drawing.Size(37, 21)
		Me.adminSi.TabIndex = 13
		Me.adminSi.TabStop = True
		Me.adminSi.Text = "Si"
		Me.adminSi.UseVisualStyleBackColor = True
		'
		'atras
		'
		Me.atras.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer))
		Me.atras.Cursor = System.Windows.Forms.Cursors.Hand
		Me.atras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(6, Byte), Integer))
		Me.atras.FlatAppearance.BorderSize = 2
		Me.atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.atras.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.atras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.atras.Location = New System.Drawing.Point(56, 551)
		Me.atras.Name = "atras"
		Me.atras.Size = New System.Drawing.Size(75, 30)
		Me.atras.TabIndex = 13
		Me.atras.Text = "Cancelar"
		Me.atras.UseVisualStyleBackColor = False
		'
		'cambiarContrasena
		'
		Me.cambiarContrasena.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer))
		Me.cambiarContrasena.Cursor = System.Windows.Forms.Cursors.Hand
		Me.cambiarContrasena.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(178, Byte), Integer))
		Me.cambiarContrasena.FlatAppearance.BorderSize = 2
		Me.cambiarContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cambiarContrasena.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.cambiarContrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.cambiarContrasena.Location = New System.Drawing.Point(415, 480)
		Me.cambiarContrasena.Name = "cambiarContrasena"
		Me.cambiarContrasena.Size = New System.Drawing.Size(143, 34)
		Me.cambiarContrasena.TabIndex = 14
		Me.cambiarContrasena.Text = "Cambiar contraseña"
		Me.cambiarContrasena.UseVisualStyleBackColor = False
		'
		'actualiza
		'
		Me.actualiza.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer))
		Me.actualiza.Cursor = System.Windows.Forms.Cursors.Hand
		Me.actualiza.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(6, Byte), Integer))
		Me.actualiza.FlatAppearance.BorderSize = 2
		Me.actualiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.actualiza.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.actualiza.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.actualiza.Location = New System.Drawing.Point(812, 551)
		Me.actualiza.Name = "actualiza"
		Me.actualiza.Size = New System.Drawing.Size(86, 30)
		Me.actualiza.TabIndex = 16
		Me.actualiza.Text = "Guardar"
		Me.actualiza.UseVisualStyleBackColor = False
		'
		'dni
		'
		Me.dni.AutoSize = True
		Me.dni.BackColor = System.Drawing.Color.Transparent
		Me.dni.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.dni.Location = New System.Drawing.Point(200, 24)
		Me.dni.Name = "dni"
		Me.dni.Size = New System.Drawing.Size(0, 22)
		Me.dni.TabIndex = 18
		'
		'activo
		'
		Me.activo.BackColor = System.Drawing.Color.Transparent
		Me.activo.Controls.Add(Me.actNo)
		Me.activo.Controls.Add(Me.actSi)
		Me.activo.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.activo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.activo.Location = New System.Drawing.Point(496, 142)
		Me.activo.Name = "activo"
		Me.activo.Size = New System.Drawing.Size(107, 52)
		Me.activo.TabIndex = 19
		Me.activo.TabStop = False
		Me.activo.Text = "Activo:"
		'
		'actNo
		'
		Me.actNo.AutoSize = True
		Me.actNo.Location = New System.Drawing.Point(57, 22)
		Me.actNo.Name = "actNo"
		Me.actNo.Size = New System.Drawing.Size(44, 21)
		Me.actNo.TabIndex = 20
		Me.actNo.TabStop = True
		Me.actNo.Text = "No"
		Me.actNo.UseVisualStyleBackColor = True
		'
		'actSi
		'
		Me.actSi.AutoSize = True
		Me.actSi.Location = New System.Drawing.Point(14, 22)
		Me.actSi.Name = "actSi"
		Me.actSi.Size = New System.Drawing.Size(37, 21)
		Me.actSi.TabIndex = 20
		Me.actSi.TabStop = True
		Me.actSi.Text = "Si"
		Me.actSi.UseVisualStyleBackColor = True
		'
		'PanelContrasena
		'
		Me.PanelContrasena.Controls.Add(Me.labelError)
		Me.PanelContrasena.Controls.Add(Me.cancelar)
		Me.PanelContrasena.Controls.Add(Me.aceptar)
		Me.PanelContrasena.Controls.Add(Me.contra2)
		Me.PanelContrasena.Controls.Add(Me.contra1)
		Me.PanelContrasena.Controls.Add(Me.Label4)
		Me.PanelContrasena.Controls.Add(Me.Label7)
		Me.PanelContrasena.Enabled = False
		Me.PanelContrasena.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.PanelContrasena.Location = New System.Drawing.Point(163, 314)
		Me.PanelContrasena.Name = "PanelContrasena"
		Me.PanelContrasena.Size = New System.Drawing.Size(635, 160)
		Me.PanelContrasena.TabIndex = 8
		Me.PanelContrasena.Visible = False
		'
		'labelError
		'
		Me.labelError.AutoSize = True
		Me.labelError.ForeColor = System.Drawing.Color.Red
		Me.labelError.Location = New System.Drawing.Point(230, 78)
		Me.labelError.Name = "labelError"
		Me.labelError.Size = New System.Drawing.Size(188, 17)
		Me.labelError.TabIndex = 13
		Me.labelError.Text = "Las contraseñas no coinciden"
		Me.labelError.Visible = False
		'
		'cancelar
		'
		Me.cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer))
		Me.cancelar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(178, Byte), Integer))
		Me.cancelar.FlatAppearance.BorderSize = 2
		Me.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.cancelar.Location = New System.Drawing.Point(20, 110)
		Me.cancelar.Name = "cancelar"
		Me.cancelar.Size = New System.Drawing.Size(75, 31)
		Me.cancelar.TabIndex = 12
		Me.cancelar.Text = "Cancelar"
		Me.cancelar.UseVisualStyleBackColor = False
		'
		'aceptar
		'
		Me.aceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer))
		Me.aceptar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.aceptar.Enabled = False
		Me.aceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(178, Byte), Integer))
		Me.aceptar.FlatAppearance.BorderSize = 2
		Me.aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.aceptar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.aceptar.Location = New System.Drawing.Point(537, 110)
		Me.aceptar.Name = "aceptar"
		Me.aceptar.Size = New System.Drawing.Size(75, 31)
		Me.aceptar.TabIndex = 11
		Me.aceptar.Text = "Cambiar"
		Me.aceptar.UseVisualStyleBackColor = False
		'
		'contra2
		'
		Me.contra2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.contra2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.contra2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.contra2.Location = New System.Drawing.Point(322, 33)
		Me.contra2.Name = "contra2"
		Me.contra2.Size = New System.Drawing.Size(304, 23)
		Me.contra2.TabIndex = 10
		Me.contra2.UseSystemPasswordChar = True
		'
		'contra1
		'
		Me.contra1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.contra1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.contra1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.contra1.Location = New System.Drawing.Point(6, 33)
		Me.contra1.Name = "contra1"
		Me.contra1.Size = New System.Drawing.Size(304, 23)
		Me.contra1.TabIndex = 9
		Me.contra1.UseSystemPasswordChar = True
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label4.Location = New System.Drawing.Point(319, 13)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(215, 17)
		Me.Label4.TabIndex = 8
		Me.Label4.Text = "Vuelve a introducir la contraseña:"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label7.Location = New System.Drawing.Point(3, 13)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(197, 17)
		Me.Label7.TabIndex = 7
		Me.Label7.Text = "Introduce la nueva contraseña:"
		'
		'DetallesUsuario
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(950, 625)
		Me.Controls.Add(Me.PanelContrasena)
		Me.Controls.Add(Me.activo)
		Me.Controls.Add(Me.dni)
		Me.Controls.Add(Me.actualiza)
		Me.Controls.Add(Me.cambiarContrasena)
		Me.Controls.Add(Me.atras)
		Me.Controls.Add(Me.admin)
		Me.Controls.Add(Me.telefono)
		Me.Controls.Add(Me.mail)
		Me.Controls.Add(Me.apellido)
		Me.Controls.Add(Me.nombre)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.Name = "DetallesUsuario"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Detalles del usuario"
		Me.admin.ResumeLayout(False)
		Me.admin.PerformLayout()
		Me.activo.ResumeLayout(False)
		Me.activo.PerformLayout()
		Me.PanelContrasena.ResumeLayout(False)
		Me.PanelContrasena.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents nombre As TextBox
	Friend WithEvents apellido As TextBox
	Friend WithEvents mail As TextBox
	Friend WithEvents telefono As MaskedTextBox
	Friend WithEvents admin As GroupBox
	Friend WithEvents adminNo As RadioButton
	Friend WithEvents adminSi As RadioButton
	Friend WithEvents atras As Button
	Friend WithEvents cambiarContrasena As Button
	Friend WithEvents actualiza As Button
	Friend WithEvents dni As Label
	Friend WithEvents activo As GroupBox
	Friend WithEvents actNo As RadioButton
	Friend WithEvents actSi As RadioButton
	Friend WithEvents PanelContrasena As Panel
	Friend WithEvents labelError As Label
	Friend WithEvents cancelar As Button
	Friend WithEvents aceptar As Button
	Friend WithEvents contra2 As TextBox
	Friend WithEvents contra1 As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents Label7 As Label
End Class
