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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.listaUsuarios = New System.Windows.Forms.DataGridView()
		Me.crearUsuario = New System.Windows.Forms.Button()
		CType(Me.listaUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'listaUsuarios
		'
		Me.listaUsuarios.AllowUserToResizeRows = False
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.listaUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
		Me.listaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
		Me.listaUsuarios.BackgroundColor = System.Drawing.SystemColors.Control
		Me.listaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.listaUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.listaUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
		Me.listaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.listaUsuarios.DefaultCellStyle = DataGridViewCellStyle3
		Me.listaUsuarios.EnableHeadersVisualStyles = False
		Me.listaUsuarios.GridColor = System.Drawing.SystemColors.ActiveBorder
		Me.listaUsuarios.Location = New System.Drawing.Point(184, 63)
		Me.listaUsuarios.Name = "listaUsuarios"
		Me.listaUsuarios.ReadOnly = True
		DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.listaUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
		Me.listaUsuarios.RowHeadersVisible = False
		DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.listaUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle5
		Me.listaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.listaUsuarios.Size = New System.Drawing.Size(552, 288)
		Me.listaUsuarios.TabIndex = 0
		'
		'crearUsuario
		'
		Me.crearUsuario.BackColor = System.Drawing.Color.LightSkyBlue
		Me.crearUsuario.Cursor = System.Windows.Forms.Cursors.Hand
		Me.crearUsuario.FlatAppearance.BorderSize = 0
		Me.crearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.crearUsuario.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.crearUsuario.Location = New System.Drawing.Point(382, 525)
		Me.crearUsuario.Name = "crearUsuario"
		Me.crearUsuario.Size = New System.Drawing.Size(157, 37)
		Me.crearUsuario.TabIndex = 2
		Me.crearUsuario.Text = "Crear usuario"
		Me.crearUsuario.UseVisualStyleBackColor = False
		'
		'GestionarUsuarios
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(950, 625)
		Me.Controls.Add(Me.crearUsuario)
		Me.Controls.Add(Me.listaUsuarios)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.MaximizeBox = False
		Me.Name = "GestionarUsuarios"
		Me.Padding = New System.Windows.Forms.Padding(60)
		Me.Text = "Gestion de usuarios"
		CType(Me.listaUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents listaUsuarios As DataGridView
	Friend WithEvents crearUsuario As Button
End Class
