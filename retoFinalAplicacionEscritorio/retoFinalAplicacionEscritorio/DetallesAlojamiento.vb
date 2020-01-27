﻿Imports System.IO
Imports MySql.Data.MySqlClient
Public Class DetallesAlojamiento
	Dim cod As String 'Codigo del alojamiento
	Dim conexion As MySqlConnection = InicioSesion.conexion 'Instancia de la conexión
	Dim inter As Interfaz 'Instancia de la interfaz
	Dim reserva 'instancia del formulario de detalles de la reserva

	'Listener del boton cancelar, cierra el formulario y vuelve a abrir el formulario de gestion de alojamientos
	Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
		If TypeOf reserva Is DetallesReserva Then
			inter.AbrirFormulario(reserva)
		Else
			inter.AbrirFormulario(New GestionarAlojamientos(inter))
		End If
		Me.Close()
	End Sub

	'Realiza las consultas necesarias para recuperar los datos de alojamiento y mostrarla
	Private Sub DetallesAlojamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim comando As New MySqlCommand("SELECT `signatura`, `documentname`, `turismdescription`, `lodgingtype`, `address`, `phone`, `tourismemail`, `web`, `municipality`, `territory`, `latwgs84`, `lonwgs84`, `postalcode`, `capacity`, `restaurant`, `store`, `autocaravana`, `imagen` FROM alojamientos_fac.alojamientos WHERE signatura = @id", conexion)
		comando.Parameters.Add("@id", MySqlDbType.VarChar).Value = cod

		Dim adapter As New MySqlDataAdapter(comando)
		Dim tabla As New DataTable()

		Dim adapter2 As New MySqlDataAdapter("SELECT `id`, `nombre` FROM alojamientos_fac.provincias", conexion)
		Dim tabla2 As New DataTable()
		Try
			adapter.Fill(tabla)
			Try
				adapter2.Fill(tabla2)
				provincia.DataSource = tabla2
				provincia.ValueMember = "id"
				provincia.DisplayMember = "nombre"
				Try
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
				Catch ex As Exception
					MessageBox.Show("Error al mostrar los datos")
				End Try
			Catch ex As Exception
				MessageBox.Show("Error al cargar las provincias")
			End Try
		Catch ex As Exception
			MessageBox.Show("Error al cargar los detalles del alojamiento")
		End Try

	End Sub

	'Constructor del formulario
	Public Sub New(ByVal codigo As String, ByRef form As Interfaz, ByRef form2 As DetallesReserva)

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		cod = codigo
		inter = form
		reserva = form2
	End Sub

	'Deshabilita los campos cuando el formulario no es editable
	Private Sub DeshabilitarCampos()
		nombre.ReadOnly = True
		nombre.Cursor = Cursors.No
		descripcion.ReadOnly = True
		descripcion.Cursor = Cursors.No
		tipo.ReadOnly = True
		tipo.Cursor = Cursors.No
		direccion.ReadOnly = True
		direccion.Cursor = Cursors.No
		telefono.ReadOnly = True
		telefono.Cursor = Cursors.No
		mail.ReadOnly = True
		mail.Cursor = Cursors.No
		web.ReadOnly = True
		web.Cursor = Cursors.No
		localidad.ReadOnly = True
		localidad.Cursor = Cursors.No
		provincia.Enabled = False
		provincia.Cursor = Cursors.No
		latitud.ReadOnly = True
		latitud.Cursor = Cursors.No
		longitud.ReadOnly = True
		longitud.Cursor = Cursors.No
		codigoPostal.ReadOnly = True
		codigoPostal.Cursor = Cursors.No
		capacidad.ReadOnly = True
		capacidad.Cursor = Cursors.No
		restaurante.Enabled = False
		restaurante.Cursor = Cursors.No
		tienda.Enabled = False
		tienda.Cursor = Cursors.No
		autocaravana.Enabled = False
		autocaravana.Cursor = Cursors.No
		cargarImagen.Enabled = False
		cargarImagen.Cursor = Cursors.No
	End Sub

	'Habilita todos los datos cuando se activa la edición
	Private Sub HabilitarCampos()
		nombre.ReadOnly = False
		nombre.Cursor = Cursors.IBeam
		descripcion.ReadOnly = False
		descripcion.Cursor = Cursors.IBeam
		tipo.ReadOnly = False
		tipo.Cursor = Cursors.IBeam
		direccion.ReadOnly = False
		direccion.Cursor = Cursors.IBeam
		telefono.ReadOnly = False
		telefono.Cursor = Cursors.IBeam
		mail.ReadOnly = False
		mail.Cursor = Cursors.IBeam
		web.ReadOnly = False
		web.Cursor = Cursors.IBeam
		localidad.ReadOnly = False
		localidad.Cursor = Cursors.IBeam
		provincia.Enabled = True
		provincia.Cursor = Cursors.Default
		latitud.ReadOnly = False
		latitud.Cursor = Cursors.IBeam
		longitud.ReadOnly = False
		longitud.Cursor = Cursors.IBeam
		codigoPostal.ReadOnly = False
		codigoPostal.Cursor = Cursors.IBeam
		capacidad.ReadOnly = False
		capacidad.Cursor = Cursors.IBeam
		restaurante.Enabled = True
		restaurante.Cursor = Cursors.Default
		tienda.Enabled = True
		tienda.Cursor = Cursors.Default
		autocaravana.Enabled = True
		autocaravana.Cursor = Cursors.Default
		cargarImagen.Enabled = True
		cargarImagen.Cursor = Cursors.Default
	End Sub

	'Habre un menu para seleccionar imagenes del ordenador
	Private Sub CargarImagen_Click(sender As Object, e As EventArgs) Handles cargarImagen.Click
		Dim dialogo As New OpenFileDialog
		dialogo.Filter = "Elige una imagen(*.JPG;*.PNG)|*.jpg;*.png"

		If dialogo.ShowDialog = Windows.Forms.DialogResult.OK Then
			imagen.Image = Image.FromFile(dialogo.FileName)
		End If
	End Sub

	'Habilita la edicion de los campos
	Private Sub Editar_Click(sender As Object, e As EventArgs) Handles editar.Click
		HabilitarCampos()
		terminarEdicion.Visible = True
		terminarEdicion.Enabled = True
		editar.Visible = False
		editar.Enabled = False
		actualizar.Enabled = False
	End Sub

	'Deshabilita la edicion de los campos
	Private Sub TerminarEdicion_Click(sender As Object, e As EventArgs) Handles terminarEdicion.Click
		DeshabilitarCampos()
		terminarEdicion.Visible = False
		terminarEdicion.Enabled = False
		editar.Visible = True
		editar.Enabled = True
		actualizar.Enabled = True
	End Sub

	'Actuliza los datos de la base de datos con los campos modificados del alojamiento seleccionado
	Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles actualizar.Click
		Dim actualizacion As New MySqlCommand("UPDATE alojamientos_fac.alojamientos SET documentname = @nombre, turismdescription = @descripcion, lodgingtype = @tipo, address = @direccion, phone = @telefono, tourismemail = @mail, web = web, municipality = @region, territory = @provincia, latwgs84 = @latitud, lonwgs84 = @longitud, postalcode = @codigoPostal, capacity = @capacidad, restaurant = @restaurante, store = @tienda, autocaravana = @autocaravana, imagen = @imagen WHERE signatura = @id", conexion)
		actualizacion.Parameters.Add("@id", MySqlDbType.VarChar).Value = cod
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
		Try
			conexion.Open()
			actualizacion.ExecuteNonQuery()
			conexion.Close()
		Catch ex As Exception
			MessageBox.Show("Error al actualizar la base de datos")
		Finally
			inter.AbrirFormulario(New GestionarAlojamientos(inter))
			Me.Close()
		End Try
	End Sub
End Class