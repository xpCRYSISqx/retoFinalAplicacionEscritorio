Imports MySql.Data.MySqlClient
Public Class GestionarUsuarios

	Dim conexion As MySqlConnection = InicioSesion.conexion
	Public inter As Interfaz

	Private Sub GestionarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Cargar()
		AddHandler listaUsuarios.RowEnter, AddressOf ListaUsuarios_RowEnter

	End Sub

	Public Sub Cargar()
		Dim adapter As New MySqlDataAdapter("SELECT dni as 'DNI', nombre as 'Nombre', apellido as 'Apellido', email as 'Correo electrónico', telefono as 'Teléfono', activo as 'Activado' FROM alojamientos_fac.usuarios", conexion)
		Dim tabla As New DataTable()
		adapter.Fill(tabla)

		listaUsuarios.DataSource = tabla
	End Sub

	Private Sub ListaUsuarios_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles listaUsuarios.CellDoubleClick
		If e.RowIndex <> -1 Then
			inter.AbrirFormulario(New DetallesUsuario(listaUsuarios.Rows(e.RowIndex).Cells(0).Value, inter, Nothing))
			Me.Close()
		End If
	End Sub

	Private Sub CrearUsuario_Click(sender As Object, e As EventArgs) Handles crearUsuario.Click
		inter.AbrirFormulario(New CrearUsuario(inter))
		Me.Close()
	End Sub

	Public Sub New(ByRef form As Interfaz)

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		inter = form
	End Sub

	Private Sub ListaUsuarios_RowEnter(sender As Object, e As DataGridViewCellEventArgs)
		'listaReservas.Rows.Clear()
		Dim comando As New MySqlCommand("SELECT id as 'Código de reserva', dni as 'DNI cliente', alojamiento as 'Código alojamiento', fecha_entrada as 'Fecha de entrada', fecha_salida as 'Fecha de salida', personas as 'Personas' FROM alojamientos_fac.reservas WHERE dni = @dni", conexion)
		comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = listaUsuarios.Rows(e.RowIndex).Cells(0).Value

		Dim adapter As New MySqlDataAdapter(comando)
		Dim tabla As New DataTable()
		adapter.Fill(tabla)

		listaReservas.DataSource = tabla
	End Sub
End Class