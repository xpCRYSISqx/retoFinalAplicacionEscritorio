Imports MySql.Data.MySqlClient
Public Class GestionarAlojamientos
	Dim conexion As MySqlConnection = InicioSesion.conexion
	Private Sub FormGestionarAlojamientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim adapter As New MySqlDataAdapter("SELECT `id`, `nombre` FROM prueba.provincias", conexion)
		Dim tabla As New DataTable()

		adapter.Fill(tabla)

		ComboBox1.DataSource = tabla
		ComboBox1.ValueMember = "id"
		ComboBox1.DisplayMember = "nombre"

		Dim adapter2 As New MySqlDataAdapter("SELECT `signatura`, `documentname` FROM prueba.alojamientos2 WHERE territory=" & ComboBox1.SelectedValue, conexion)
		Dim tabla2 As New DataTable()

		adapter2.Fill(tabla2)
		ListBox1.DataSource = tabla2
		ListBox1.ValueMember = "signatura"
		ListBox1.DisplayMember = "documentname"
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles filtrar.Click
		Dim adapter As New MySqlDataAdapter("SELECT `signatura`, `documentname` FROM prueba.alojamientos2 WHERE territory=" & ComboBox1.SelectedValue, conexion)
		Dim tabla As New DataTable()

		adapter.Fill(tabla)
		ListBox1.DataSource = tabla
		ListBox1.ValueMember = "signatura"
		ListBox1.DisplayMember = "documentname"
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles atras.Click
		SelecionarOpcion.Show()
		Me.Hide()
	End Sub

	Private Sub GestionarAlojamientos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
		InicioSesion.Close()
	End Sub

	Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
		Dim formulario As New DetallesAlojamiento(Integer.Parse(ListBox1.SelectedValue))
		formulario.Show()
		Me.Hide()
	End Sub
End Class