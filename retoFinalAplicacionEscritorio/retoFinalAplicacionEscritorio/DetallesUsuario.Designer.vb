﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetallesUsuario
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
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.nombre = New System.Windows.Forms.TextBox()
		Me.apellido = New System.Windows.Forms.TextBox()
		Me.mail = New System.Windows.Forms.TextBox()
		Me.telefono = New System.Windows.Forms.MaskedTextBox()
		Me.admin = New System.Windows.Forms.GroupBox()
		Me.adminSi = New System.Windows.Forms.RadioButton()
		Me.adminNo = New System.Windows.Forms.RadioButton()
		Me.atras = New System.Windows.Forms.Button()
		Me.cambiarContrasena = New System.Windows.Forms.Button()
		Me.editar = New System.Windows.Forms.Button()
		Me.actualiza = New System.Windows.Forms.Button()
		Me.terminar = New System.Windows.Forms.Button()
		Me.dni = New System.Windows.Forms.Label()
		Me.admin.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(43, 40)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(34, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "DNI:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(43, 71)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(60, 17)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Nombre:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(43, 106)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(59, 17)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Apellido:"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(43, 145)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(120, 17)
		Me.Label5.TabIndex = 4
		Me.Label5.Text = "Correo Electrónico:"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(43, 181)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(62, 17)
		Me.Label6.TabIndex = 5
		Me.Label6.Text = "Teléfono:"
		'
		'nombre
		'
		Me.nombre.Location = New System.Drawing.Point(109, 68)
		Me.nombre.Name = "nombre"
		Me.nombre.Size = New System.Drawing.Size(302, 23)
		Me.nombre.TabIndex = 7
		'
		'apellido
		'
		Me.apellido.Location = New System.Drawing.Point(108, 103)
		Me.apellido.Name = "apellido"
		Me.apellido.Size = New System.Drawing.Size(303, 23)
		Me.apellido.TabIndex = 8
		'
		'mail
		'
		Me.mail.Location = New System.Drawing.Point(169, 142)
		Me.mail.Name = "mail"
		Me.mail.Size = New System.Drawing.Size(242, 23)
		Me.mail.TabIndex = 10
		'
		'telefono
		'
		Me.telefono.Location = New System.Drawing.Point(111, 178)
		Me.telefono.Mask = "000000000"
		Me.telefono.Name = "telefono"
		Me.telefono.Size = New System.Drawing.Size(113, 23)
		Me.telefono.TabIndex = 11
		'
		'admin
		'
		Me.admin.Controls.Add(Me.adminNo)
		Me.admin.Controls.Add(Me.adminSi)
		Me.admin.Location = New System.Drawing.Point(46, 223)
		Me.admin.Name = "admin"
		Me.admin.Size = New System.Drawing.Size(117, 52)
		Me.admin.TabIndex = 12
		Me.admin.TabStop = False
		Me.admin.Text = "Administrador:"
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
		'atras
		'
		Me.atras.Location = New System.Drawing.Point(43, 307)
		Me.atras.Name = "atras"
		Me.atras.Size = New System.Drawing.Size(75, 30)
		Me.atras.TabIndex = 13
		Me.atras.Text = "Atras"
		Me.atras.UseVisualStyleBackColor = True
		'
		'cambiarContrasena
		'
		Me.cambiarContrasena.Location = New System.Drawing.Point(268, 238)
		Me.cambiarContrasena.Name = "cambiarContrasena"
		Me.cambiarContrasena.Size = New System.Drawing.Size(143, 34)
		Me.cambiarContrasena.TabIndex = 14
		Me.cambiarContrasena.Text = "Cambiar contraseña"
		Me.cambiarContrasena.UseVisualStyleBackColor = True
		'
		'editar
		'
		Me.editar.Location = New System.Drawing.Point(192, 307)
		Me.editar.Name = "editar"
		Me.editar.Size = New System.Drawing.Size(75, 30)
		Me.editar.TabIndex = 15
		Me.editar.Text = "Editar"
		Me.editar.UseVisualStyleBackColor = True
		'
		'actualiza
		'
		Me.actualiza.Enabled = False
		Me.actualiza.Location = New System.Drawing.Point(336, 307)
		Me.actualiza.Name = "actualiza"
		Me.actualiza.Size = New System.Drawing.Size(75, 30)
		Me.actualiza.TabIndex = 16
		Me.actualiza.Text = "Actualizar"
		Me.actualiza.UseVisualStyleBackColor = True
		'
		'terminar
		'
		Me.terminar.Location = New System.Drawing.Point(169, 307)
		Me.terminar.Name = "terminar"
		Me.terminar.Size = New System.Drawing.Size(116, 30)
		Me.terminar.TabIndex = 17
		Me.terminar.Text = "Terminar edición"
		Me.terminar.UseVisualStyleBackColor = True
		Me.terminar.Visible = False
		'
		'dni
		'
		Me.dni.AutoSize = True
		Me.dni.Location = New System.Drawing.Point(83, 40)
		Me.dni.Name = "dni"
		Me.dni.Size = New System.Drawing.Size(0, 17)
		Me.dni.TabIndex = 18
		'
		'DetallesUsuario
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(454, 378)
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
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.Name = "DetallesUsuario"
		Me.Padding = New System.Windows.Forms.Padding(40)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Detalles del usuario"
		Me.admin.ResumeLayout(False)
		Me.admin.PerformLayout()
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
End Class