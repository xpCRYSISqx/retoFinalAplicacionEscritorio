<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarAlojamientos
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
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.ListBox1 = New System.Windows.Forms.ListBox()
		Me.atras = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'ComboBox1
		'
		Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBox1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(47, 41)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(163, 25)
		Me.ComboBox1.TabIndex = 0
		'
		'ListBox1
		'
		Me.ListBox1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.ListBox1.FormattingEnabled = True
		Me.ListBox1.ItemHeight = 17
		Me.ListBox1.Location = New System.Drawing.Point(266, 41)
		Me.ListBox1.Name = "ListBox1"
		Me.ListBox1.Size = New System.Drawing.Size(229, 361)
		Me.ListBox1.TabIndex = 1
		'
		'atras
		'
		Me.atras.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
		Me.atras.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
		Me.atras.Location = New System.Drawing.Point(47, 372)
		Me.atras.Name = "atras"
		Me.atras.Size = New System.Drawing.Size(75, 30)
		Me.atras.TabIndex = 3
		Me.atras.Text = "Atras"
		Me.atras.UseVisualStyleBackColor = False
		'
		'GestionarAlojamientos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(561, 450)
		Me.Controls.Add(Me.atras)
		Me.Controls.Add(Me.ListBox1)
		Me.Controls.Add(Me.ComboBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "GestionarAlojamientos"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Gestion de alojamientos"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents ListBox1 As ListBox
	Friend WithEvents atras As Button
End Class
