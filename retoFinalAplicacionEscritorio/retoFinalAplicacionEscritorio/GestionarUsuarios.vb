Imports MySql.Data.MySqlClient
Public Class GestionarUsuarios
	Dim conexion As MySqlConnection = InicioSesion.conexion
	Private Sub GestionarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim adapter As New MySqlDataAdapter("SELECT dni as 'DNI', nombre as 'Nombre', apellido as 'Apellido', email as 'Correo electrónico', telefono as 'Teléfono', activo as 'Activado' FROM prueba.usuarios", conexion)
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

	Public Sub Actualizar()
		Controls.Clear()
		InitializeComponent()
		GestionarUsuarios_Load(Me, Nothing)
	End Sub

	Private Sub ListaUsuarios_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles listaUsuarios.CellContentDoubleClick
		If e.RowIndex <> -1 Then
			Dim formulario As New DetallesUsuario(listaUsuarios.Rows(e.RowIndex).Cells(0).Value)
			formulario.Show()
			Me.Hide()
		End If
	End Sub

	Private Sub CrearUsuario_Click(sender As Object, e As EventArgs) Handles crearUsuario.Click
		Dim formulario As New CrearUsuario()
		formulario.Show()
	End Sub
End Class