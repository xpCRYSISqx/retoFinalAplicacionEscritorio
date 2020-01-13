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
		Me.listaUsuarios = New System.Windows.Forms.DataGridView()
		Me.atras = New System.Windows.Forms.Button()
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
		Me.listaUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.Violet
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.listaUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
		Me.listaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.listaUsuarios.Location = New System.Drawing.Point(48, 37)
		Me.listaUsuarios.Name = "listaUsuarios"
		Me.listaUsuarios.RowHeadersVisible = False
		Me.listaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.listaUsuarios.Size = New System.Drawing.Size(654, 185)
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
		'GestionarUsuarios
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(750, 450)
		Me.Controls.Add(Me.atras)
		Me.Controls.Add(Me.listaUsuarios)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "GestionarUsuarios"
		Me.Text = "Gestion de usuarios"
		CType(Me.listaUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents listaUsuarios As DataGridView
	Friend WithEvents atras As Button
End Class
