Imports MySql.Data.MySqlClient

Public Class CrearReserva
    Dim inter As Interfaz
    Dim conexion As MySqlConnection = InicioSesion.conexion
    Dim cod As String
    Dim tipo As String
    Dim usuario As DetallesAlojamiento

    Public Sub New(ByVal codigo As String, ByRef form As Interfaz, ByRef form2 As DetallesAlojamiento)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        inter = form
        cod = codigo
        usuario = form2
    End Sub

    Private Sub DetallesReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New MySqlDataAdapter("SELECT `dni` FROM alojamientos_fac.usuarios", conexion)
        Dim tabla As New DataTable()
        Try
            adapter.Fill(tabla)
            dniUsu.DataSource = tabla
            dniUsu.ValueMember = "dni"
            dniUsu.DisplayMember = "dni"
        Catch ex As MySqlException
            MsgBox("Error al cargar los usuarios", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Critical, "Error")
        End Try

        Dim adapter2 As New MySqlDataAdapter("SELECT `signatura`, `documentname` FROM alojamientos_fac.alojamientos ORDER BY `documentname` ASC", conexion)
        Dim tabla2 As New DataTable()
        Try
            adapter2.Fill(tabla2)
            nombreAloj.DataSource = tabla2
            nombreAloj.ValueMember = "signatura"
            nombreAloj.DisplayMember = "documentname"
            Try
                nombreAloj.SelectedValue = cod
            Catch
            End Try
        Catch ex As MySqlException
                MsgBox("Error al cargar los alojamientos", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Critical, "Error")
        End Try

        CargarCliente()
        CargarAlojamiento()
        ComprobarOcupacion()
        AddHandler fechaEntrada.ValueChanged, AddressOf ComprobarOcupacion
        AddHandler fechaSalida.ValueChanged, AddressOf ComprobarOcupacion
    End Sub

    Private Sub CargarCliente()
		Dim comando As New MySqlCommand("SELECT `nombre`, `apellido` FROM alojamientos_fac.usuarios WHERE dni = @dni", conexion)
		comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = dniUsu.SelectedValue
		Try
			Dim adapter As New MySqlDataAdapter(comando)
			Dim tabla As New DataTable()

			adapter.Fill(tabla)
			nombreUsu.Text = tabla(0)(0)
			apellidoUsu.Text = tabla(0)(1)
		Catch ex As MySqlException
			MsgBox("Error al recuperar la información del cliente de la base de datos", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Critical, "Error")
		End Try
	End Sub

	Private Sub CargarAlojamiento()
		Dim comando As New MySqlCommand("SELECT `signatura`, `capacity`, `lodgingtype` FROM alojamientos_fac.alojamientos WHERE signatura = @signatura", conexion)
		comando.Parameters.Add("@signatura", MySqlDbType.VarChar).Value = nombreAloj.SelectedValue
		Try
			Dim adapter As New MySqlDataAdapter(comando)
			Dim tabla As New DataTable()

			adapter.Fill(tabla)
			codigoAloj.Text = tabla(0)(0)
			capacidadAloj.Text = tabla(0)(1)
			tipo = tabla(0)(2)
		Catch ex As MySqlException
			MsgBox("Error al recuperar la información del alojamiento de la base de datos", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Critical, "Error")
		End Try
	End Sub

	Private Sub DniUsu_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles dniUsu.SelectionChangeCommitted
		CargarCliente()
	End Sub

    Private Sub NombreAloj_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles nombreAloj.SelectionChangeCommitted
        CargarAlojamiento()
        ComprobarOcupacion()
    End Sub

    Private Sub Atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        If TypeOf usuario Is DetallesAlojamiento Then
            inter.AbrirFormulario(New DetallesAlojamiento(cod, inter, Nothing))
        Else
            inter.AbrirFormulario(New GestionarReservas(inter))
		End If
		Me.Close()
	End Sub

	Private Sub Actualiza_Click(sender As Object, e As EventArgs) Handles actualiza.Click
		If numeroPersonas.Value > Integer.Parse(capacidadDisponible.Text) Then
			MsgBox("El numero de personas excede la capacidad del alojamiento", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Critical, "Error")
		Else
			Dim respuesta As MsgBoxResult
            respuesta = MsgBox("¿Esta segur@ de que quiere realizar la reserva?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "Realizar reserva")
            If respuesta = MsgBoxResult.Yes Then
                Dim id As Integer
                Dim adapter As New MySqlDataAdapter("SELECT MAX(`id`) FROM alojamientos_fac.reservas", conexion)
                Dim tab As New DataTable

                adapter.Fill(tab)
                id = Integer.Parse(tab(0)(0)) + 1

                Dim actualizacion As New MySqlCommand("INSERT INTO alojamientos_fac.reservas (`id`, `dni`, `fecha_entrada`, `fecha_salida`, `alojamiento`, `personas`) VALUES (@id,@dni,@entrada,@salida,@alojamiento,@personas)", conexion)
                actualizacion.Parameters.Add("@id", MySqlDbType.Int16).Value = id
                actualizacion.Parameters.AddWithValue("@dni", dniUsu.SelectedValue)
                actualizacion.Parameters.AddWithValue("@entrada", fechaEntrada.Value.ToString("yyyy-MM-dd"))
                actualizacion.Parameters.AddWithValue("@salida", fechaSalida.Value.ToString("yyyy-MM-dd"))
                actualizacion.Parameters.AddWithValue("@alojamiento", codigoAloj.Text)
                If tipo = "Casas Rurales" Or tipo = "Agroturismos" Then
                    actualizacion.Parameters.AddWithValue("@personas", Integer.Parse(capacidadAloj.Text))
                Else
                    actualizacion.Parameters.AddWithValue("@personas", numeroPersonas.Value)
                End If
                Try
                    conexion.Open()
                    actualizacion.ExecuteNonQuery()
                    conexion.Close()
                Catch ex As MySqlException
                    MsgBox("Error al introducir la reserva en la base de datos", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Critical, "Error")
                End Try
                inter.AbrirFormulario(New GestionarReservas(inter))
                Me.Close()
            ElseIf respuesta = MsgBoxResult.Cancel Then
                If TypeOf usuario Is DetallesAlojamiento Then
                    inter.AbrirFormulario(New DetallesAlojamiento(cod, inter, Nothing))
                Else
                    inter.AbrirFormulario(New GestionarReservas(inter))
				End If
				Me.Close()
			End If
		End If
	End Sub

	Private Sub ComprobarOcupacion()
		Dim comando As New MySqlCommand("SELECT SUM(`personas`) FROM alojamientos_fac.reservas WHERE alojamiento = @alojamiento AND ((fecha_entrada BETWEEN @fechaEntrada AND @fechaSalida) OR (fecha_salida BETWEEN @fechaEntrada AND @fechaSalida) OR (@fechaEntrada BETWEEN fecha_entrada AND fecha_salida) OR (@fechaSalida BETWEEN fecha_entrada AND fecha_salida))", conexion)
		comando.Parameters.Add("@alojamiento", MySqlDbType.VarChar).Value = codigoAloj.Text
		comando.Parameters.Add("@fechaEntrada", MySqlDbType.Date).Value = fechaEntrada.Value.ToString("yyyy-MM-dd")
		comando.Parameters.Add("@fechaSalida", MySqlDbType.Date).Value = fechaSalida.Value.ToString("yyyy-MM-dd")
		Try
			Dim adapter As New MySqlDataAdapter(comando)
			Dim tabla As New DataTable()

			adapter.Fill(tabla)
			Try
				capacidadDisponible.Text = Integer.Parse(capacidadAloj.Text) - Integer.Parse(tabla(0)(0)) + numeroPersonas.Value
				If Integer.Parse(capacidadDisponible.Text) < 0 Then
					capacidadDisponible.Text = 0
				End If
			Catch
				capacidadDisponible.Text = Integer.Parse(capacidadAloj.Text)
			End Try
		Catch ex As MySqlException
			MsgBox("Error al recuperar la ocupacion del alojamiento de la base de datos", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Critical, "Error")
		End Try
	End Sub
End Class