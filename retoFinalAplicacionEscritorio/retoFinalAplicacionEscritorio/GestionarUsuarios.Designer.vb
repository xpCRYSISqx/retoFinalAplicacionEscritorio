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
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.listaUsuarios = New System.Windows.Forms.DataGridView()
		Me.atras = New System.Windows.Forms.Button()
		Me.crearUsuario = New System.Windows.Forms.Button()
		CType(Me.listaUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'listaUsuarios
		'
		Me.listaUsuarios.AllowUserToResizeRows = False
		DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.listaUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
		Me.listaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
		Me.listaUsuarios.BackgroundColor = System.Drawing.SystemColors.Control
		Me.listaUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle4.BackColor = System.Drawing.Color.Violet
		DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.listaUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
		Me.listaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.listaUsuarios.Location = New System.Drawing.Point(48, 37)
		Me.listaUsuarios.Name = "listaUsuarios"
		Me.listaUsuarios.ReadOnly = True
		Me.listaUsuarios.RowHeadersVisible = False
		Me.listaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.listaUsuarios.Size = New System.Drawing.Size(471, 185)
		Me.listaUsuarios.TabIndex = 0
		'
		'atras
		'
		Me.atras.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.atras.Location = New System.Drawing.Point(48, 369)
		Me.atras.Name = "atras"
		Me.atras.Size = New System.Drawing.Size(75, 37)
		Me.atras.TabIndex = 1
		Me.atras.Text = "Atras"
		Me.atras.UseVisualStyleBackColor = True
		'
		'crearUsuario
		'
		Me.crearUsuario.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.crearUsuario.Location = New System.Drawing.Point(419, 369)
		Me.crearUsuario.Name = "crearUsuario"
		Me.crearUsuario.Size = New System.Drawing.Size(100, 37)
		Me.crearUsuario.TabIndex = 2
		Me.crearUsuario.Text = "Crear usuario"
		Me.crearUsuario.UseVisualStyleBackColor = True
		'
		'GestionarUsuarios
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(584, 450)
		Me.Controls.Add(Me.crearUsuario)
		Me.Controls.Add(Me.atras)
		Me.Controls.Add(Me.listaUsuarios)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "GestionarUsuarios"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Gestion de usuarios"
		CType(Me.listaUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents listaUsuarios As DataGridView
	Friend WithEvents atras As Button
	Friend WithEvents crearUsuario As Button
End Class
