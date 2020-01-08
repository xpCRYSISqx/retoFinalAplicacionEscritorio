Imports MySql.Data.MySqlClient
Public Class GestionarAlojamientos
	Dim conexion As New MySqlConnection("datasource=192.168.101.15;port=3306;username=ldmj;password=ladamijo")
	Private Sub FormGestionarAlojamientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim adapter As New MySqlDataAdapter("SELECT `id`, `nombre` FROM prueba.provincias", conexion)
		Dim tabla As New DataTable()

		adapter.Fill(tabla)

		ComboBox1.DataSource = tabla
		ComboBox1.ValueMember = "id"
		ComboBox1.DisplayMember = "nombre"

		Dim adapter2 As New MySqlDataAdapter("SELECT `documentname` FROM prueba.alojamientos WHERE territory=" & ComboBox1.SelectedValue, conexion)
		Dim tabla2 As New DataTable()

		adapter2.Fill(tabla2)
		ListBox1.DataSource = tabla2
		ListBox1.DisplayMember = "documentname"
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles filtrar.Click
		Dim adapter As New MySqlDataAdapter("SELECT `documentname` FROM prueba.alojamientos WHERE territory=" & ComboBox1.SelectedValue, conexion)
		Dim tabla As New DataTable()

		adapter.Fill(tabla)
		ListBox1.DataSource = tabla
		ListBox1.DisplayMember = "documentname"
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles atras.Click
		SelecionarOpcion.Show()
		Me.Hide()
	End Sub

	Private Sub GestionarAlojamientos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
		InicioSesion.Close()
	End Sub
End Class