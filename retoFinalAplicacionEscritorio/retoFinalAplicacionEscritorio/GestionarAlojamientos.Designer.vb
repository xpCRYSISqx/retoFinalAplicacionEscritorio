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
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.ListBox1 = New System.Windows.Forms.ListBox()
		Me.SuspendLayout()
		'
		'ComboBox1
		'
		Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
		Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBox1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(138, 73)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(163, 25)
		Me.ComboBox1.TabIndex = 0
		'
		'ListBox1
		'
		Me.ListBox1.BackColor = System.Drawing.SystemColors.Control
		Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.ListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
		Me.ListBox1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.ListBox1.FormattingEnabled = True
		Me.ListBox1.ItemHeight = 17
		Me.ListBox1.Location = New System.Drawing.Point(569, 73)
		Me.ListBox1.Name = "ListBox1"
		Me.ListBox1.Size = New System.Drawing.Size(229, 461)
		Me.ListBox1.TabIndex = 1
		'
		'GestionarAlojamientos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(950, 625)
		Me.Controls.Add(Me.ListBox1)
		Me.Controls.Add(Me.ComboBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.MaximizeBox = False
		Me.Name = "GestionarAlojamientos"
		Me.Padding = New System.Windows.Forms.Padding(70)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Gestion de alojamientos"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents ListBox1 As ListBox
End Class
