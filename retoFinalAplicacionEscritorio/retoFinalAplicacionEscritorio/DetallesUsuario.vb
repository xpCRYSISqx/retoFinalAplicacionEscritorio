Imports MySql.Data.MySqlClient
Public Class DetallesUsuario
	Dim cod As String
	Dim conexion As MySqlConnection = InicioSesion.conexion
	Private Sub DetallesUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim comando As New MySqlCommand("SELECT `dni`, `nombre`, `apellido`, `contrasena`, `email`, `telefono`, `administrador` FROM prueba.usuarios WHERE dni = @dni", conexion)
		comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = cod

		Dim adapter As New MySqlDataAdapter(comando)
		Dim tabla As New DataTable()

		adapter.Fill(tabla)

		dni.Text = tabla(0)(0)
		nombre.Text = tabla(0)(1)
		apellido.Text = tabla(0)(2)
		contrasena.Text = tabla(0)(3)
		mail.Text = tabla(0)(4)
		telefono.Text = tabla(0)(5)
		If tabla(0)(6) = 1 Then
			adminSi.Checked = True
		Else
			adminNo.Checked = True
		End If
	End Sub

	Private Sub DetallesUsuario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
		InicioSesion.Close()
	End Sub

	Public Sub New(ByVal dniGestion As String)

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		cod = dniGestion
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles atras.Click
		GestionarUsuarios.Show()
		Me.Hide()
	End Sub

	Private Sub Editar_Click(sender As Object, e As EventArgs) Handles editar.Click

	End Sub

	Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles actualizar.Click

	End Sub

	Private Sub Terminar_Click(sender As Object, e As EventArgs) Handles terminar.Click

	End Sub
End Class