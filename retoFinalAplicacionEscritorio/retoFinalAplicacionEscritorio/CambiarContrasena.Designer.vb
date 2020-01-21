<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CambiarContrasena
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CambiarContrasena))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.contra1 = New System.Windows.Forms.TextBox()
		Me.contra2 = New System.Windows.Forms.TextBox()
		Me.aceptar = New System.Windows.Forms.Button()
		Me.cancelar = New System.Windows.Forms.Button()
		Me.labelError = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Cabecera = New System.Windows.Forms.Panel()
		Me.Minimizar = New System.Windows.Forms.PictureBox()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Cabecera.SuspendLayout()
		CType(Me.Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(31, 72)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(187, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Introduce la nueva contraseña:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(31, 135)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(202, 17)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Vuelve a introducir la contraseña:"
		'
		'contra1
		'
		Me.contra1.Location = New System.Drawing.Point(34, 92)
		Me.contra1.Name = "contra1"
		Me.contra1.Size = New System.Drawing.Size(304, 23)
		Me.contra1.TabIndex = 2
		Me.contra1.UseSystemPasswordChar = True
		'
		'contra2
		'
		Me.contra2.Location = New System.Drawing.Point(34, 155)
		Me.contra2.Name = "contra2"
		Me.contra2.Size = New System.Drawing.Size(304, 23)
		Me.contra2.TabIndex = 3
		Me.contra2.UseSystemPasswordChar = True
		'
		'aceptar
		'
		Me.aceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
		Me.aceptar.Enabled = False
		Me.aceptar.FlatAppearance.BorderSize = 0
		Me.aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.aceptar.Location = New System.Drawing.Point(263, 226)
		Me.aceptar.Name = "aceptar"
		Me.aceptar.Size = New System.Drawing.Size(75, 31)
		Me.aceptar.TabIndex = 4
		Me.aceptar.Text = "Cambiar"
		Me.aceptar.UseVisualStyleBackColor = False
		'
		'cancelar
		'
		Me.cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
		Me.cancelar.FlatAppearance.BorderSize = 0
		Me.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cancelar.Location = New System.Drawing.Point(34, 226)
		Me.cancelar.Name = "cancelar"
		Me.cancelar.Size = New System.Drawing.Size(75, 31)
		Me.cancelar.TabIndex = 5
		Me.cancelar.Text = "Cancelar"
		Me.cancelar.UseVisualStyleBackColor = False
		'
		'labelError
		'
		Me.labelError.AutoSize = True
		Me.labelError.ForeColor = System.Drawing.Color.Red
		Me.labelError.Location = New System.Drawing.Point(94, 197)
		Me.labelError.Name = "labelError"
		Me.labelError.Size = New System.Drawing.Size(179, 17)
		Me.labelError.TabIndex = 6
		Me.labelError.Text = "Las contraseñas no coinciden"
		Me.labelError.Visible = False
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
		Me.Cabecera.Dock = System.Windows.Forms.DockStyle.Top
		Me.Cabecera.Location = New System.Drawing.Point(0, 0)
		Me.Cabecera.Name = "Cabecera"
		Me.Cabecera.Size = New System.Drawing.Size(367, 50)
		Me.Cabecera.TabIndex = 7
		'
		'Minimizar
		'
		Me.Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Minimizar.Image = CType(resources.GetObject("Minimizar.Image"), System.Drawing.Image)
		Me.Minimizar.Location = New System.Drawing.Point(335, 3)
		Me.Minimizar.Name = "Minimizar"
		Me.Minimizar.Size = New System.Drawing.Size(20, 20)
		Me.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.Minimizar.TabIndex = 3
		Me.Minimizar.TabStop = False
		'
		'CambiarContrasena
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(367, 269)
		Me.Controls.Add(Me.Cabecera)
		Me.Controls.Add(Me.labelError)
		Me.Controls.Add(Me.cancelar)
		Me.Controls.Add(Me.aceptar)
		Me.Controls.Add(Me.contra2)
		Me.Controls.Add(Me.contra1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.MaximizeBox = False
		Me.Name = "CambiarContrasena"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "CambiarContrasena"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Cabecera.ResumeLayout(False)
		CType(Me.Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents contra1 As TextBox
	Friend WithEvents contra2 As TextBox
	Friend WithEvents aceptar As Button
	Friend WithEvents cancelar As Button
	Friend WithEvents labelError As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Cabecera As Panel
	Friend WithEvents Minimizar As PictureBox
End Class
