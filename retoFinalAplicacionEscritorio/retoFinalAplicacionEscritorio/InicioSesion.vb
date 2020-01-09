Imports MySql.Data.MySqlClient

Public Class InicioSesion
	Public conexion As New MySqlConnection("datasource=192.168.101.15;port=3306;username=ldmj;password=ladamijo")
	Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
		Me.Close()
	End Sub

	Private Sub IniciarSesion_Click(sender As Object, e As EventArgs) Handles iniciarSesion.Click
		Dim formulario As New SelecionarOpcion
		formulario.Show()
		Me.Hide()
	End Sub
End Class