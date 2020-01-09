Imports System.IO
Imports MySql.Data.MySqlClient
Public Class DetallesAlojamiento
	Dim cod As Integer
	Dim conexion As MySqlConnection = InicioSesion.conexion
	Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
		GestionarAlojamientos.Show()
		Me.Hide()
	End Sub

	Private Sub DetallesAlojamiento_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
		InicioSesion.Close()
	End Sub

	Private Sub DetallesAlojamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim adapter As New MySqlDataAdapter("SELECT `signatura`, `documentname`, `turismdescription`, `lodgingtype`, `address`, `phone`, `tourismemail`, `web`, `marks`, `territory`, `latwgs84`, `lonwgs84`, `postalcode`, `capacity`, `restaurant`, `store`, `autocaravana`, `imagen` FROM prueba.alojamientos WHERE signatura=" & cod, conexion)
		Dim tabla As New DataTable()

		adapter.Fill(tabla)

		Dim adapter2 As New MySqlDataAdapter("SELECT `id`, `nombre` FROM prueba.provincias", conexion)
		Dim tabla2 As New DataTable()

		adapter2.Fill(tabla2)

		provincia.DataSource = tabla2
		provincia.ValueMember = "id"
		provincia.DisplayMember = "nombre"

		labelCodigo.Text = tabla(0)(0)
		nombre.Text = tabla(0)(1)
		descripcion.Text = tabla(0)(2)
		tipo.Text = tabla(0)(3)
		direccion.Text = tabla(0)(4)
		telefono.Text = tabla(0)(5)
		mail.Text = tabla(0)(6)
		web.Text = tabla(0)(7)
		textRegion.Text = tabla(0)(8)
		provincia.SelectedValue = tabla(0)(9)
		latitud.Text = tabla(0)(10)
		longitud.Text = tabla(0)(11)
		codigoPostal.Text = tabla(0)(12)
		capacidad.Text = tabla(0)(13)
		If tabla(0)(14) = 1 Then
			restSi.Checked = True
		Else
			restNo.Checked = True
		End If
		If tabla(0)(15) = 1 Then
			tiendaSi.Checked = True
		Else
			tiendaNo.Checked = True
		End If
		If tabla(0)(16) = 1 Then
			autoSi.Checked = True
		Else
			autoNo.Checked = True
		End If

		Dim imagenByte() As Byte
		imagenByte = tabla(0)(17)
		Dim ms As New MemoryStream(imagenByte)
		imagen.Image = Image.FromStream(ms)

		DeshabilitarCampos()
	End Sub

	Public Sub New(ByVal codigo As Integer)

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		cod = codigo
	End Sub

	Private Sub DeshabilitarCampos()
		nombre.ReadOnly = True
		descripcion.ReadOnly = True
		tipo.ReadOnly = True
		direccion.ReadOnly = True
		telefono.ReadOnly = True
		mail.ReadOnly = True
		web.ReadOnly = True
		textRegion.ReadOnly = True
		provincia.Enabled = False
		latitud.ReadOnly = True
		longitud.ReadOnly = True
		codigoPostal.ReadOnly = True
		capacidad.ReadOnly = True
		restaurante.Enabled = False
		tienda.Enabled = False
		autocaravana.Enabled = False
		cargarImagen.Enabled = False
	End Sub

	Private Sub CargarImagen_Click(sender As Object, e As EventArgs) Handles cargarImagen.Click
		Dim dialogo As New OpenFileDialog
		dialogo.Filter = "Elige una imagen(*.JPG;*.PNG)|*.jpg;*.png"

		If dialogo.ShowDialog = Windows.Forms.DialogResult.OK Then
			imagen.Image = Image.FromFile(dialogo.FileName)
		End If
	End Sub
End Class