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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InicioSesion))
		Me.email = New System.Windows.Forms.TextBox()
		Me.contrasena = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.iniciarSesion = New System.Windows.Forms.Button()
		Me.cancelar = New System.Windows.Forms.Button()
		Me.Cabecera = New System.Windows.Forms.Panel()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Minimizar = New System.Windows.Forms.PictureBox()
		Me.Cerrar = New System.Windows.Forms.PictureBox()
		Me.Cabecera.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'email
		'
		Me.email.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.email.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.email.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.email.Location = New System.Drawing.Point(51, 123)
		Me.email.Name = "email"
		Me.email.Size = New System.Drawing.Size(276, 23)
		Me.email.TabIndex = 0
		'
		'contrasena
		'
		Me.contrasena.AccessibleDescription = ""
		Me.contrasena.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.contrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.contrasena.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.contrasena.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.contrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.contrasena.Location = New System.Drawing.Point(51, 195)
		Me.contrasena.Name = "contrasena"
		Me.contrasena.Size = New System.Drawing.Size(276, 23)
		Me.contrasena.TabIndex = 1
		Me.contrasena.Tag = ""
		Me.contrasena.UseSystemPasswordChar = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(47, 101)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(52, 17)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Correo:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label2.Location = New System.Drawing.Point(47, 173)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(80, 17)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Contraseña:"
		'
		'iniciarSesion
		'
		Me.iniciarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer))
		Me.iniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand
		Me.iniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(6, Byte), Integer))
		Me.iniciarSesion.FlatAppearance.BorderSize = 2
		Me.iniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.iniciarSesion.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.iniciarSesion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.iniciarSesion.Location = New System.Drawing.Point(219, 278)
		Me.iniciarSesion.Name = "iniciarSesion"
		Me.iniciarSesion.Size = New System.Drawing.Size(108, 31)
		Me.iniciarSesion.TabIndex = 4
		Me.iniciarSesion.Text = "Iniciar Sesión"
		Me.iniciarSesion.UseVisualStyleBackColor = False
		'
		'cancelar
		'
		Me.cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer))
		Me.cancelar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(6, Byte), Integer))
		Me.cancelar.FlatAppearance.BorderSize = 2
		Me.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cancelar.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.cancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.cancelar.Location = New System.Drawing.Point(51, 278)
		Me.cancelar.Name = "cancelar"
		Me.cancelar.Size = New System.Drawing.Size(108, 31)
		Me.cancelar.TabIndex = 5
		Me.cancelar.Text = "Cancelar"
		Me.cancelar.UseVisualStyleBackColor = False
		'
		'Cabecera
		'
		Me.Cabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Cabecera.Controls.Add(Me.PictureBox1)
		Me.Cabecera.Controls.Add(Me.Minimizar)
		Me.Cabecera.Controls.Add(Me.Cerrar)
		Me.Cabecera.Dock = System.Windows.Forms.DockStyle.Top
		Me.Cabecera.Location = New System.Drawing.Point(0, 0)
		Me.Cabecera.Name = "Cabecera"
		Me.Cabecera.Size = New System.Drawing.Size(378, 50)
		Me.Cabecera.TabIndex = 6
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
		'Minimizar
		'
		Me.Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Minimizar.Image = CType(resources.GetObject("Minimizar.Image"), System.Drawing.Image)
		Me.Minimizar.Location = New System.Drawing.Point(329, 3)
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
		Me.Cerrar.Location = New System.Drawing.Point(355, 3)
		Me.Cerrar.Name = "Cerrar"
		Me.Cerrar.Size = New System.Drawing.Size(20, 20)
		Me.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.Cerrar.TabIndex = 4
		Me.Cerrar.TabStop = False
		'
		'InicioSesion
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(378, 366)
		Me.Controls.Add(Me.Cabecera)
		Me.Controls.Add(Me.cancelar)
		Me.Controls.Add(Me.iniciarSesion)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.contrasena)
		Me.Controls.Add(Me.email)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "InicioSesion"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Iniciar sesion"
		Me.Cabecera.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents email As TextBox
	Friend WithEvents contrasena As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents iniciarSesion As Button
	Friend WithEvents cancelar As Button
	Friend WithEvents Cabecera As Panel
	Friend WithEvents Minimizar As PictureBox
	Friend WithEvents Cerrar As PictureBox
	Friend WithEvents PictureBox1 As PictureBox
End Class
