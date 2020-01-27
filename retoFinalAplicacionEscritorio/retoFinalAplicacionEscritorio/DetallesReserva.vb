Imports MySql.Data.MySqlClient

Public Class DetallesReserva

	Dim inter As Interfaz
	Dim cod As Integer
	Dim conexion As MySqlConnection = InicioSesion.conexion
	Dim dni As String
	Dim codigo As String

	Public Sub New(ByVal codigo As Integer, ByRef form As Interfaz)

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		inter = form
		cod = codigo
	End Sub

	Private Sub DetallesReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CargarReserva()
		Dim adapter As New MySqlDataAdapter("SELECT `dni` FROM alojamientos_fac.usuarios", conexion)
		Dim tabla As New DataTable()

		adapter.Fill(tabla)
		dniUsu.DataSource = tabla
		dniUsu.ValueMember = "dni"
		dniUsu.DisplayMember = "dni"
		dniUsu.SelectedValue = dni

		Dim adapter2 As New MySqlDataAdapter("SELECT `signatura`, `documentname` FROM alojamientos_fac.alojamientos ORDER BY `documentname` ASC", conexion)
		Dim tabla2 As New DataTable()

		adapter2.Fill(tabla2)
		nombreAloj.DataSource = tabla2
		nombreAloj.ValueMember = "signatura"
		nombreAloj.DisplayMember = "documentname"
		nombreAloj.SelectedValue = codigo

		CargarCliente()
		CargarAlojamiento()
	End Sub

	Private Sub CargarReserva()
		Dim adapter As New MySqlDataAdapter("SELECT `id`, `dni`, `fecha_entrada`, `fecha_salida`, `alojamiento`, `personas` FROM alojamientos_fac.reservas WHERE id=" & cod, conexion)
		Dim tabla As New DataTable()

		adapter.Fill(tabla)
		dni = tabla(0)(1)
		codigo = tabla(0)(4)
		codigoRes.Text = cod
	End Sub

	Private Sub CargarCliente()
		Dim comando As New MySqlCommand("SELECT `nombre`, `apellido` FROM alojamientos_fac.usuarios WHERE dni = @dni", conexion)
		comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = dniUsu.SelectedValue

		Dim adapter As New MySqlDataAdapter(comando)
		Dim tabla As New DataTable()

		adapter.Fill(tabla)
		nombreUsu.Text = tabla(0)(0)
		apellidoUsu.Text = tabla(0)(1)
	End Sub

	Private Sub CargarAlojamiento()
		Dim comando As New MySqlCommand("SELECT `signatura`, `capacity` FROM alojamientos_fac.alojamientos WHERE signatura = @signatura", conexion)
		comando.Parameters.Add("@signatura", MySqlDbType.VarChar).Value = nombreAloj.SelectedValue

		Dim adapter As New MySqlDataAdapter(comando)
		Dim tabla As New DataTable()

		adapter.Fill(tabla)
		codigoAloj.Text = tabla(0)(0)
		capacidadAloj.Text = tabla(0)(1)
	End Sub

	Private Sub DniUsu_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles dniUsu.SelectionChangeCommitted
		CargarCliente()
	End Sub

	Private Sub NombreAloj_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles nombreAloj.SelectionChangeCommitted
		CargarAlojamiento()
	End Sub

	Private Sub DetallesCliente_Click(sender As Object, e As EventArgs) Handles detallesCliente.Click
		inter.AbrirFormulario(New DetallesUsuario(dniUsu.SelectedValue, inter))
	End Sub

	Private Sub DetallesAlojamiento_Click(sender As Object, e As EventArgs) Handles detallesAlojamiento.Click
		inter.AbrirFormulario(New DetallesAlojamiento(nombreAloj.SelectedValue, inter))
	End Sub
End Class