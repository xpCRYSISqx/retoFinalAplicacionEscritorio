Imports MySql.Data.MySqlClient
Public Class GestionarUsuarios

	Dim conexion As MySqlConnection = InicioSesion.conexion
	Public inter As Interfaz

	Private Sub GestionarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Cargar()
	End Sub

	Public Sub Cargar()
		Dim adapter As New MySqlDataAdapter("SELECT dni as 'DNI', nombre as 'Nombre', apellido as 'Apellido', email as 'Correo electrónico', telefono as 'Teléfono', activo as 'Activado' FROM alojamientos_fac.usuarios", conexion)
		Dim tabla As New DataTable()
		adapter.Fill(tabla)

		listaUsuarios.DataSource = tabla
	End Sub

	Private Sub ListaUsuarios_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles listaUsuarios.CellContentDoubleClick
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
End Class