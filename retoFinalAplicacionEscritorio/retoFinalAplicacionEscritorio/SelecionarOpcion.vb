Public Class SelecionarOpcion
	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles alojamientos.Click
		Dim formulario As New GestionarAlojamientos
		formulario.Show()
		Me.Hide()
	End Sub

	Private Sub SelecionarOpcion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
		InicioSesion.Close()
	End Sub

	Private Sub Usuarios_Click(sender As Object, e As EventArgs) Handles usuarios.Click
		Dim formulario As New GestionarUsuarios
		formulario.Show()
		Me.Hide()
	End Sub

	Private Sub CorrarSesion_Click(sender As Object, e As EventArgs) Handles corrarSesion.Click
		InicioSesion.Actualizar()
		InicioSesion.Show()
		Me.Hide()
		MessageBox.Show("Se ha cerrado la sesión")
	End Sub
End Class