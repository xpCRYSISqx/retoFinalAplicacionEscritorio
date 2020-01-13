Imports MySql.Data.MySqlClient
Public Class GestionarUsuarios
	Dim conexion As MySqlConnection = InicioSesion.conexion
	Private Sub GestionarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim adapter As New MySqlDataAdapter("SELECT dni as 'DNI', nombre as 'Nombre', apellido as 'Apellido', email as 'Correo electronico', contrasena as 'Contraseña', telefono as 'Teléfono' FROM prueba.usuarios", conexion)
		Dim tabla As New DataTable()
		adapter.Fill(tabla)

		listaUsuarios.DataSource = tabla
	End Sub

	Private Sub GestionarUsuarios_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
		InicioSesion.Close()
	End Sub

	Private Sub Atras_Click(sender As Object, e As EventArgs) Handles atras.Click
		SelecionarOpcion.Show()
		Me.Hide()
	End Sub

	Private Sub ListaUsuarios_DoubleClick(sender As Object, e As EventArgs) Handles listaUsuarios.DoubleClick

	End Sub
End Class