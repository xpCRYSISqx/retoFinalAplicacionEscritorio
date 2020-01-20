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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetallesUsuario))
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
		Me.editar = New System.Windows.Forms.Button()
		Me.actualiza = New System.Windows.Forms.Button()
		Me.terminar = New System.Windows.Forms.Button()
		Me.dni = New System.Windows.Forms.Label()
		Me.activo = New System.Windows.Forms.GroupBox()
		Me.actNo = New System.Windows.Forms.RadioButton()
		Me.actSi = New System.Windows.Forms.RadioButton()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Cabecera = New System.Windows.Forms.Panel()
		Me.Minimizar = New System.Windows.Forms.PictureBox()
		Me.Cerrar = New System.Windows.Forms.PictureBox()
		Me.admin.SuspendLayout()
		Me.activo.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Cabecera.SuspendLayout()
		CType(Me.Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Location = New System.Drawing.Point(154, 100)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(34, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "DNI:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Location = New System.Drawing.Point(488, 100)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(60, 17)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Nombre:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Location = New System.Drawing.Point(489, 162)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(59, 17)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Apellido:"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Location = New System.Drawing.Point(154, 236)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(120, 17)
		Me.Label5.TabIndex = 4
		Me.Label5.Text = "Correo Electrónico:"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Location = New System.Drawing.Point(489, 236)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(62, 17)
		Me.Label6.TabIndex = 5
		Me.Label6.Text = "Teléfono:"
		'
		'nombre
		'
		Me.nombre.Location = New System.Drawing.Point(491, 120)
		Me.nombre.Name = "nombre"
		Me.nombre.Size = New System.Drawing.Size(302, 23)
		Me.nombre.TabIndex = 7
		'
		'apellido
		'
		Me.apellido.Location = New System.Drawing.Point(490, 182)
		Me.apellido.Name = "apellido"
		Me.apellido.Size = New System.Drawing.Size(303, 23)
		Me.apellido.TabIndex = 8
		'
		'mail
		'
		Me.mail.Location = New System.Drawing.Point(157, 256)
		Me.mail.Name = "mail"
		Me.mail.Size = New System.Drawing.Size(308, 23)
		Me.mail.TabIndex = 10
		'
		'telefono
		'
		Me.telefono.Location = New System.Drawing.Point(491, 256)
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
		Me.admin.ForeColor = System.Drawing.SystemColors.ControlText
		Me.admin.Location = New System.Drawing.Point(157, 153)
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
		Me.adminSi.Size = New System.Drawing.Size(36, 21)
		Me.adminSi.TabIndex = 13
		Me.adminSi.TabStop = True
		Me.adminSi.Text = "Si"
		Me.adminSi.UseVisualStyleBackColor = True
		'
		'atras
		'
		Me.atras.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
		Me.atras.Location = New System.Drawing.Point(83, 473)
		Me.atras.Name = "atras"
		Me.atras.Size = New System.Drawing.Size(75, 30)
		Me.atras.TabIndex = 13
		Me.atras.Text = "Atras"
		Me.atras.UseVisualStyleBackColor = False
		'
		'cambiarContrasena
		'
		Me.cambiarContrasena.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
		Me.cambiarContrasena.Location = New System.Drawing.Point(708, 418)
		Me.cambiarContrasena.Name = "cambiarContrasena"
		Me.cambiarContrasena.Size = New System.Drawing.Size(143, 34)
		Me.cambiarContrasena.TabIndex = 14
		Me.cambiarContrasena.Text = "Cambiar contraseña"
		Me.cambiarContrasena.UseVisualStyleBackColor = False
		'
		'editar
		'
		Me.editar.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
		Me.editar.Location = New System.Drawing.Point(450, 473)
		Me.editar.Name = "editar"
		Me.editar.Size = New System.Drawing.Size(75, 30)
		Me.editar.TabIndex = 15
		Me.editar.Text = "Editar"
		Me.editar.UseVisualStyleBackColor = False
		'
		'actualiza
		'
		Me.actualiza.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
		Me.actualiza.Enabled = False
		Me.actualiza.Location = New System.Drawing.Point(776, 473)
		Me.actualiza.Name = "actualiza"
		Me.actualiza.Size = New System.Drawing.Size(75, 30)
		Me.actualiza.TabIndex = 16
		Me.actualiza.Text = "Actualizar"
		Me.actualiza.UseVisualStyleBackColor = False
		'
		'terminar
		'
		Me.terminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
		Me.terminar.Location = New System.Drawing.Point(432, 473)
		Me.terminar.Name = "terminar"
		Me.terminar.Size = New System.Drawing.Size(116, 30)
		Me.terminar.TabIndex = 17
		Me.terminar.Text = "Terminar edición"
		Me.terminar.UseVisualStyleBackColor = False
		Me.terminar.Visible = False
		'
		'dni
		'
		Me.dni.AutoSize = True
		Me.dni.BackColor = System.Drawing.Color.Transparent
		Me.dni.ForeColor = System.Drawing.SystemColors.ControlText
		Me.dni.Location = New System.Drawing.Point(154, 117)
		Me.dni.Name = "dni"
		Me.dni.Size = New System.Drawing.Size(43, 17)
		Me.dni.TabIndex = 18
		Me.dni.Text = "klabel"
		'
		'activo
		'
		Me.activo.BackColor = System.Drawing.Color.Transparent
		Me.activo.Controls.Add(Me.actNo)
		Me.activo.Controls.Add(Me.actSi)
		Me.activo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.activo.Location = New System.Drawing.Point(373, 153)
		Me.activo.Name = "activo"
		Me.activo.Size = New System.Drawing.Size(92, 52)
		Me.activo.TabIndex = 19
		Me.activo.TabStop = False
		Me.activo.Text = "Activo:"
		'
		'actNo
		'
		Me.actNo.AutoSize = True
		Me.actNo.Location = New System.Drawing.Point(48, 22)
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
		Me.actSi.Location = New System.Drawing.Point(6, 22)
		Me.actSi.Name = "actSi"
		Me.actSi.Size = New System.Drawing.Size(36, 21)
		Me.actSi.TabIndex = 20
		Me.actSi.TabStop = True
		Me.actSi.Text = "Si"
		Me.actSi.UseVisualStyleBackColor = True
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 7
		Me.PictureBox1.TabStop = False
		'
		'Cabecera
		'
		Me.Cabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(175, Byte), Integer))
		Me.Cabecera.Controls.Add(Me.PictureBox1)
		Me.Cabecera.Controls.Add(Me.Minimizar)
		Me.Cabecera.Controls.Add(Me.Cerrar)
		Me.Cabecera.Dock = System.Windows.Forms.DockStyle.Top
		Me.Cabecera.Location = New System.Drawing.Point(0, 0)
		Me.Cabecera.Name = "Cabecera"
		Me.Cabecera.Size = New System.Drawing.Size(950, 50)
		Me.Cabecera.TabIndex = 20
		'
		'Minimizar
		'
		Me.Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Minimizar.Image = CType(resources.GetObject("Minimizar.Image"), System.Drawing.Image)
		Me.Minimizar.Location = New System.Drawing.Point(901, 3)
		Me.Minimizar.Name = "Minimizar"
		Me.Minimizar.Size = New System.Drawing.Size(20, 20)
		Me.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.Minimizar.TabIndex = 3
		Me.Minimizar.TabStop = False
		'
		'Cerrar
		'
		Me.Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Cerrar.Image = CType(resources.GetObject("Cerrar.Image"), System.Drawing.Image)
		Me.Cerrar.Location = New System.Drawing.Point(927, 3)
		Me.Cerrar.Name = "Cerrar"
		Me.Cerrar.Size = New System.Drawing.Size(20, 20)
		Me.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.Cerrar.TabIndex = 4
		Me.Cerrar.TabStop = False
		'
		'DetallesUsuario
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(950, 625)
		Me.Controls.Add(Me.Cabecera)
		Me.Controls.Add(Me.activo)
		Me.Controls.Add(Me.dni)
		Me.Controls.Add(Me.terminar)
		Me.Controls.Add(Me.actualiza)
		Me.Controls.Add(Me.editar)
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
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Cabecera.ResumeLayout(False)
		CType(Me.Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
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
	Friend WithEvents editar As Button
	Friend WithEvents actualiza As Button
	Friend WithEvents terminar As Button
	Friend WithEvents dni As Label
	Friend WithEvents activo As GroupBox
	Friend WithEvents actNo As RadioButton
	Friend WithEvents actSi As RadioButton
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Cabecera As Panel
	Friend WithEvents Minimizar As PictureBox
	Friend WithEvents Cerrar As PictureBox
End Class
