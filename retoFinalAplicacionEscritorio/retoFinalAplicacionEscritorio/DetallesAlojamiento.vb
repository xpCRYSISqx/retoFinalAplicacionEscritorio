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
		Dim adapter As New MySqlDataAdapter("SELECT `signatura`, `documentname`, `turismdescription`, `lodgingtype`, `address`, `phone`, `tourismemail`, `web`, `municipality`, `territory`, `latwgs84`, `lonwgs84`, `postalcode`, `capacity`, `restaurant`, `store`, `autocaravana`, `imagen` FROM prueba.alojamientos WHERE signatura=" & cod, conexion)
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
		localidad.Text = tabla(0)(8)
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
		localidad.ReadOnly = True
		provincia.Enabled = False
		latitud.ReadOnly = True
		longitud.ReadOnly = True
		codigoPostal.ReadOnly = True
		capacidad.ReadOnly = True
		restaurante.Enabled = False
		tienda.Enabled = False
		autocaravana.Enabled = False
		cargarImagen.Enabled = False
		actualizar.Enabled = False
	End Sub

	Private Sub HabilitarCampos()
		nombre.ReadOnly = False
		descripcion.ReadOnly = False
		tipo.ReadOnly = False
		direccion.ReadOnly = False
		telefono.ReadOnly = False
		mail.ReadOnly = False
		web.ReadOnly = False
		localidad.ReadOnly = False
		provincia.Enabled = True
		latitud.ReadOnly = False
		longitud.ReadOnly = False
		codigoPostal.ReadOnly = False
		capacidad.ReadOnly = False
		restaurante.Enabled = True
		tienda.Enabled = True
		autocaravana.Enabled = True
		cargarImagen.Enabled = True
		actualizar.Enabled = True
	End Sub

	Private Sub CargarImagen_Click(sender As Object, e As EventArgs) Handles cargarImagen.Click
		Dim dialogo As New OpenFileDialog
		dialogo.Filter = "Elige una imagen(*.JPG;*.PNG)|*.jpg;*.png"

		If dialogo.ShowDialog = Windows.Forms.DialogResult.OK Then
			imagen.Image = Image.FromFile(dialogo.FileName)
		End If
	End Sub

	Private Sub Editar_Click(sender As Object, e As EventArgs) Handles editar.Click
		If editar.Text = "Editar" Then
			HabilitarCampos()
			editar.Text = "Terminar Edición"
		Else
			DeshabilitarCampos()
			editar.Text = "Editar"
		End If
	End Sub

	Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles actualizar.Click
		Dim actualizacion As New MySqlCommand("UPDATE prueba.alojamientos SET documentname = @nombre, turismdescription = @descripcion, lodgingtype = @tipo, address = @direccion, phone = @telefono, tourismemail = @mail, web = web, municipality = @region, territory = @provincia, latwgs84 = @latitud, lonwgs84 = @longitud, postalcode = @codigoPostal, capacity = @capacidad, restaurant = @restaurante, store = @tienda, autocaravana = @autocaravana, imagen = @imagen WHERE signatura=" & cod, conexion)
		Dim ms As New MemoryStream
		imagen.Image.Save(ms, imagen.Image.RawFormat)

		actualizacion.Parameters.AddWithValue("@nombre", nombre.Text)
		actualizacion.Parameters.AddWithValue("@descripcion", descripcion.Text)
		actualizacion.Parameters.AddWithValue("@tipo", tipo.Text)
		actualizacion.Parameters.AddWithValue("@direccion", direccion.Text)
		actualizacion.Parameters.AddWithValue("@telefono", Integer.Parse(telefono.Text))
		actualizacion.Parameters.AddWithValue("@mail", mail.Text)
		actualizacion.Parameters.AddWithValue("@web", web.Text)
		actualizacion.Parameters.AddWithValue("@region", localidad.Text)
		actualizacion.Parameters.AddWithValue("@provincia", Integer.Parse(provincia.SelectedValue))
		actualizacion.Parameters.AddWithValue("@latitud", Double.Parse(latitud.Text))
		actualizacion.Parameters.AddWithValue("@longitud", Double.Parse(longitud.Text))
		actualizacion.Parameters.AddWithValue("@codigoPostal", Integer.Parse(codigoPostal.Text))
		actualizacion.Parameters.AddWithValue("@capacidad", Integer.Parse(capacidad.Text))
		If restSi.Checked = True Then
			actualizacion.Parameters.AddWithValue("@restaurante", 1)
		Else
			actualizacion.Parameters.AddWithValue("@restaurante", 0)
		End If
		If tiendaSi.Checked = True Then
			actualizacion.Parameters.AddWithValue("@tienda", 1)
		Else
			actualizacion.Parameters.AddWithValue("@tienda", 0)
		End If
		If autoSi.Checked = True Then
			actualizacion.Parameters.AddWithValue("@autocaravana", 1)
		Else
			actualizacion.Parameters.AddWithValue("@autocaravana", 0)
		End If
		actualizacion.Parameters.AddWithValue("@imagen", ms.ToArray())
		conexion.Open()
		actualizacion.ExecuteNonQuery()
		conexion.Close()
		GestionarAlojamientos.Actualizar()
		GestionarAlojamientos.Show()
		Me.Hide()
	End Sub
End Class