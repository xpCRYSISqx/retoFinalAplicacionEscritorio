<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionarUsuarios
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
		Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.crearUsuario = New System.Windows.Forms.Button()
		Me.listaReservas = New System.Windows.Forms.DataGridView()
		Me.listaUsuarios = New System.Windows.Forms.DataGridView()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		CType(Me.listaReservas, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.listaUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'crearUsuario
		'
		Me.crearUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer))
		Me.crearUsuario.Cursor = System.Windows.Forms.Cursors.Hand
		Me.crearUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(6, Byte), Integer))
		Me.crearUsuario.FlatAppearance.BorderSize = 2
		Me.crearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.crearUsuario.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.crearUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.crearUsuario.Location = New System.Drawing.Point(781, 63)
		Me.crearUsuario.Name = "crearUsuario"
		Me.crearUsuario.Size = New System.Drawing.Size(157, 37)
		Me.crearUsuario.TabIndex = 2
		Me.crearUsuario.Text = "Crear usuario"
		Me.crearUsuario.UseVisualStyleBackColor = False
		'
		'listaReservas
		'
		Me.listaReservas.AllowUserToResizeRows = False
		DataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		DataGridViewCellStyle25.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		DataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.listaReservas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle25
		Me.listaReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
		Me.listaReservas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.listaReservas.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.listaReservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
		DataGridViewCellStyle26.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
		DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.listaReservas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
		Me.listaReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		DataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
		DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.listaReservas.DefaultCellStyle = DataGridViewCellStyle27
		Me.listaReservas.EnableHeadersVisualStyles = False
		Me.listaReservas.GridColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.listaReservas.Location = New System.Drawing.Point(29, 299)
		Me.listaReservas.Name = "listaReservas"
		Me.listaReservas.ReadOnly = True
		Me.listaReservas.RowHeadersVisible = False
		DataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		DataGridViewCellStyle28.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		DataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.listaReservas.RowsDefaultCellStyle = DataGridViewCellStyle28
		Me.listaReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.listaReservas.Size = New System.Drawing.Size(725, 280)
		Me.listaReservas.TabIndex = 3
		'
		'listaUsuarios
		'
		Me.listaUsuarios.AllowUserToResizeRows = False
		DataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		DataGridViewCellStyle29.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		DataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.listaUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle29
		Me.listaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
		Me.listaUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.listaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.listaUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
		DataGridViewCellStyle30.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		DataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
		DataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.listaUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle30
		Me.listaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		DataGridViewCellStyle31.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		DataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
		DataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.listaUsuarios.DefaultCellStyle = DataGridViewCellStyle31
		Me.listaUsuarios.EnableHeadersVisualStyles = False
		Me.listaUsuarios.GridColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.listaUsuarios.Location = New System.Drawing.Point(29, 63)
		Me.listaUsuarios.Name = "listaUsuarios"
		Me.listaUsuarios.ReadOnly = True
		Me.listaUsuarios.RowHeadersVisible = False
		DataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		DataGridViewCellStyle32.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		DataGridViewCellStyle32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.listaUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle32
		Me.listaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.listaUsuarios.Size = New System.Drawing.Size(725, 191)
		Me.listaUsuarios.TabIndex = 4
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(25, 39)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(136, 19)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "Lista de usuarios:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label2.Location = New System.Drawing.Point(25, 277)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(168, 19)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Reservas del usuario:"
		'
		'GestionarUsuarios
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(950, 625)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.listaUsuarios)
		Me.Controls.Add(Me.listaReservas)
		Me.Controls.Add(Me.crearUsuario)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.MaximizeBox = False
		Me.Name = "GestionarUsuarios"
		Me.Text = "Gestion de usuarios"
		CType(Me.listaReservas, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.listaUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents crearUsuario As Button
	Friend WithEvents listaReservas As DataGridView
	Friend WithEvents listaUsuarios As DataGridView
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
End Class
