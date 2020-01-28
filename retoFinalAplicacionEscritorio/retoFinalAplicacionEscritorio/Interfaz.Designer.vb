<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Interfaz
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Interfaz))
		Me.MenuVertical = New System.Windows.Forms.Panel()
		Me.CerrarSesion = New System.Windows.Forms.Button()
		Me.Alojamientos = New System.Windows.Forms.Button()
		Me.Reservas = New System.Windows.Forms.Button()
		Me.Usuarios = New System.Windows.Forms.Button()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.Cabecera = New System.Windows.Forms.Panel()
		Me.Minimizar = New System.Windows.Forms.PictureBox()
		Me.Cerrar = New System.Windows.Forms.PictureBox()
		Me.DesplegarMenu = New System.Windows.Forms.PictureBox()
		Me.Contenedor = New System.Windows.Forms.Panel()
		Me.MenuVertical.SuspendLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Cabecera.SuspendLayout()
		CType(Me.Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DesplegarMenu, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MenuVertical
		'
		Me.MenuVertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(136, Byte), Integer))
		Me.MenuVertical.Controls.Add(Me.CerrarSesion)
		Me.MenuVertical.Controls.Add(Me.Alojamientos)
		Me.MenuVertical.Controls.Add(Me.Reservas)
		Me.MenuVertical.Controls.Add(Me.Usuarios)
		Me.MenuVertical.Controls.Add(Me.PictureBox2)
		Me.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left
		Me.MenuVertical.Location = New System.Drawing.Point(0, 0)
		Me.MenuVertical.Name = "MenuVertical"
		Me.MenuVertical.Size = New System.Drawing.Size(250, 700)
		Me.MenuVertical.TabIndex = 0
		'
		'CerrarSesion
		'
		Me.CerrarSesion.FlatAppearance.BorderSize = 0
		Me.CerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(24, Byte), Integer))
		Me.CerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CerrarSesion.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CerrarSesion.ForeColor = System.Drawing.SystemColors.Control
		Me.CerrarSesion.Image = CType(resources.GetObject("CerrarSesion.Image"), System.Drawing.Image)
		Me.CerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.CerrarSesion.Location = New System.Drawing.Point(0, 625)
		Me.CerrarSesion.Name = "CerrarSesion"
		Me.CerrarSesion.Size = New System.Drawing.Size(250, 45)
		Me.CerrarSesion.TabIndex = 4
		Me.CerrarSesion.Text = "Cerrar Sesión"
		Me.CerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.CerrarSesion.UseVisualStyleBackColor = True
		'
		'Alojamientos
		'
		Me.Alojamientos.FlatAppearance.BorderSize = 0
		Me.Alojamientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
		Me.Alojamientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Alojamientos.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Alojamientos.ForeColor = System.Drawing.SystemColors.Control
		Me.Alojamientos.Image = CType(resources.GetObject("Alojamientos.Image"), System.Drawing.Image)
		Me.Alojamientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Alojamientos.Location = New System.Drawing.Point(0, 286)
		Me.Alojamientos.Name = "Alojamientos"
		Me.Alojamientos.Size = New System.Drawing.Size(250, 45)
		Me.Alojamientos.TabIndex = 3
		Me.Alojamientos.Text = "Alojamientos"
		Me.Alojamientos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Alojamientos.UseVisualStyleBackColor = True
		'
		'Reservas
		'
		Me.Reservas.FlatAppearance.BorderSize = 0
		Me.Reservas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
		Me.Reservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Reservas.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Reservas.ForeColor = System.Drawing.SystemColors.Control
		Me.Reservas.Image = CType(resources.GetObject("Reservas.Image"), System.Drawing.Image)
		Me.Reservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Reservas.Location = New System.Drawing.Point(0, 235)
		Me.Reservas.Name = "Reservas"
		Me.Reservas.Size = New System.Drawing.Size(250, 45)
		Me.Reservas.TabIndex = 2
		Me.Reservas.Text = "Reservas"
		Me.Reservas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Reservas.UseVisualStyleBackColor = True
		'
		'Usuarios
		'
		Me.Usuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(136, Byte), Integer))
		Me.Usuarios.FlatAppearance.BorderSize = 0
		Me.Usuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
		Me.Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Usuarios.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Usuarios.ForeColor = System.Drawing.SystemColors.Control
		Me.Usuarios.Image = CType(resources.GetObject("Usuarios.Image"), System.Drawing.Image)
		Me.Usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Usuarios.Location = New System.Drawing.Point(0, 184)
		Me.Usuarios.Name = "Usuarios"
		Me.Usuarios.Size = New System.Drawing.Size(250, 45)
		Me.Usuarios.TabIndex = 1
		Me.Usuarios.Text = "Usuarios"
		Me.Usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Usuarios.UseVisualStyleBackColor = False
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
		Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(60, 60)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox2.TabIndex = 0
		Me.PictureBox2.TabStop = False
		'
		'Cabecera
		'
		Me.Cabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(175, Byte), Integer))
		Me.Cabecera.Controls.Add(Me.Minimizar)
		Me.Cabecera.Controls.Add(Me.Cerrar)
		Me.Cabecera.Controls.Add(Me.DesplegarMenu)
		Me.Cabecera.Dock = System.Windows.Forms.DockStyle.Top
		Me.Cabecera.Location = New System.Drawing.Point(250, 0)
		Me.Cabecera.Name = "Cabecera"
		Me.Cabecera.Size = New System.Drawing.Size(950, 75)
		Me.Cabecera.TabIndex = 1
		'
		'Minimizar
		'
		Me.Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Minimizar.Image = CType(resources.GetObject("Minimizar.Image"), System.Drawing.Image)
		Me.Minimizar.Location = New System.Drawing.Point(892, 3)
		Me.Minimizar.Name = "Minimizar"
		Me.Minimizar.Size = New System.Drawing.Size(20, 20)
		Me.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.Minimizar.TabIndex = 2
		Me.Minimizar.TabStop = False
		'
		'Cerrar
		'
		Me.Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Cerrar.Image = CType(resources.GetObject("Cerrar.Image"), System.Drawing.Image)
		Me.Cerrar.Location = New System.Drawing.Point(918, 3)
		Me.Cerrar.Name = "Cerrar"
		Me.Cerrar.Size = New System.Drawing.Size(20, 20)
		Me.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.Cerrar.TabIndex = 2
		Me.Cerrar.TabStop = False
		'
		'DesplegarMenu
		'
		Me.DesplegarMenu.Cursor = System.Windows.Forms.Cursors.Hand
		Me.DesplegarMenu.Image = CType(resources.GetObject("DesplegarMenu.Image"), System.Drawing.Image)
		Me.DesplegarMenu.Location = New System.Drawing.Point(6, 22)
		Me.DesplegarMenu.Name = "DesplegarMenu"
		Me.DesplegarMenu.Size = New System.Drawing.Size(35, 35)
		Me.DesplegarMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.DesplegarMenu.TabIndex = 0
		Me.DesplegarMenu.TabStop = False
		'
		'Contenedor
		'
		Me.Contenedor.BackColor = System.Drawing.SystemColors.ButtonShadow
		Me.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Contenedor.Location = New System.Drawing.Point(250, 75)
		Me.Contenedor.Name = "Contenedor"
		Me.Contenedor.Size = New System.Drawing.Size(950, 625)
		Me.Contenedor.TabIndex = 2
		'
		'Interfaz
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1200, 700)
		Me.Controls.Add(Me.Contenedor)
		Me.Controls.Add(Me.Cabecera)
		Me.Controls.Add(Me.MenuVertical)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "Interfaz"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Interfaz"
		Me.MenuVertical.ResumeLayout(False)
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Cabecera.ResumeLayout(False)
		CType(Me.Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DesplegarMenu, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents MenuVertical As Panel
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents Cabecera As Panel
	Friend WithEvents DesplegarMenu As PictureBox
	Friend WithEvents Minimizar As PictureBox
	Friend WithEvents Cerrar As PictureBox
	Friend WithEvents Usuarios As Button
	Friend WithEvents Alojamientos As Button
	Friend WithEvents Reservas As Button
	Friend WithEvents Contenedor As Panel
	Friend WithEvents CerrarSesion As Button
End Class
