<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionarAlojamientos
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
		Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.provincias = New System.Windows.Forms.ComboBox()
		Me.listaAlojamientos = New System.Windows.Forms.DataGridView()
		Me.textoBusqueda = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		CType(Me.listaAlojamientos, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'provincias
		'
		Me.provincias.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.provincias.Cursor = System.Windows.Forms.Cursors.Hand
		Me.provincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.provincias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.provincias.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.provincias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.provincias.FormattingEnabled = True
		Me.provincias.Location = New System.Drawing.Point(714, 139)
		Me.provincias.Name = "provincias"
		Me.provincias.Size = New System.Drawing.Size(224, 25)
		Me.provincias.TabIndex = 2
		'
		'listaAlojamientos
		'
		Me.listaAlojamientos.AllowUserToResizeRows = False
		DataGridViewCellStyle41.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		DataGridViewCellStyle41.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		DataGridViewCellStyle41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.listaAlojamientos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle41
		Me.listaAlojamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
		Me.listaAlojamientos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.listaAlojamientos.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.listaAlojamientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		DataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
		DataGridViewCellStyle42.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		DataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
		DataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.listaAlojamientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle42
		Me.listaAlojamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		DataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle43.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		DataGridViewCellStyle43.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		DataGridViewCellStyle43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		DataGridViewCellStyle43.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
		DataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.listaAlojamientos.DefaultCellStyle = DataGridViewCellStyle43
		Me.listaAlojamientos.EnableHeadersVisualStyles = False
		Me.listaAlojamientos.GridColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.listaAlojamientos.Location = New System.Drawing.Point(24, 53)
		Me.listaAlojamientos.Name = "listaAlojamientos"
		Me.listaAlojamientos.ReadOnly = True
		Me.listaAlojamientos.RowHeadersVisible = False
		DataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		DataGridViewCellStyle44.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		DataGridViewCellStyle44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.listaAlojamientos.RowsDefaultCellStyle = DataGridViewCellStyle44
		Me.listaAlojamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.listaAlojamientos.Size = New System.Drawing.Size(665, 505)
		Me.listaAlojamientos.TabIndex = 3
		'
		'textoBusqueda
		'
		Me.textoBusqueda.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(98, Byte), Integer))
		Me.textoBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.textoBusqueda.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.textoBusqueda.ForeColor = System.Drawing.Color.Gray
		Me.textoBusqueda.Location = New System.Drawing.Point(714, 73)
		Me.textoBusqueda.Name = "textoBusqueda"
		Me.textoBusqueda.Size = New System.Drawing.Size(224, 23)
		Me.textoBusqueda.TabIndex = 4
		Me.textoBusqueda.Text = "Buscar"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(711, 53)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(128, 17)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "Buscar por nombre:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label2.Location = New System.Drawing.Point(711, 119)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(68, 17)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Provincia:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
		Me.Label3.Location = New System.Drawing.Point(20, 31)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(174, 19)
		Me.Label3.TabIndex = 7
		Me.Label3.Text = "Lista de alojamientos:"
		'
		'GestionarAlojamientos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(71, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(950, 625)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.textoBusqueda)
		Me.Controls.Add(Me.listaAlojamientos)
		Me.Controls.Add(Me.provincias)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.MaximizeBox = False
		Me.Name = "GestionarAlojamientos"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Gestion de alojamientos"
		CType(Me.listaAlojamientos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents provincias As ComboBox
	Friend WithEvents listaAlojamientos As DataGridView
	Friend WithEvents textoBusqueda As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
End Class
