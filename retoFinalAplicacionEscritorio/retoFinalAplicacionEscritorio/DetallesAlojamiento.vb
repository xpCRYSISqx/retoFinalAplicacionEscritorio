Imports System.IO
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

	'Habre un menu para seleccionar imagenes del ordenador
	Private Sub CargarImagen_Click(sender As Object, e As EventArgs) Handles cargarImagen.Click
		Dim dialogo As New OpenFileDialog
		dialogo.Filter = "Elige una imagen(*.JPG;*.PNG)|*.jpg;*.png"

		If dialogo.ShowDialog = Windows.Forms.DialogResult.OK Then
			imagen.Image = Image.FromFile(dialogo.FileName)
		End If
	End Sub

	'Actuliza los datos de la base de datos con los campos modificados del alojamiento seleccionado
	Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles actualizar.Click
		Dim respuesta As MsgBoxResult
		respuesta = MsgBox("¿Esta segur@ de que quiere guardar los cambios en la informacion del alojamiento?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "Actualización de alojamiento")

		If respuesta = MsgBoxResult.Yes Then
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
		ElseIf respuesta = MsgBoxResult.Cancel Then
			If TypeOf reserva Is DetallesReserva Then
				inter.AbrirFormulario(reserva)
			Else
				inter.AbrirFormulario(New GestionarAlojamientos(inter))
			End If
			Me.Close()
		End If
	End Sub

    Private Sub reservar_Click(sender As Object, e As EventArgs) Handles reservar.Click
        inter.AbrirFormulario(New CrearReserva(labelCodigo.Text, inter, Me))
        Me.Close()
    End Sub
End Class