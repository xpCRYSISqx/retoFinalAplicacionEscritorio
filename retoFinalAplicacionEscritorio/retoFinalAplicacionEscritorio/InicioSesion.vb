Public Class InicioSesion
	Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
		Me.Close()
	End Sub

	Private Sub IniciarSesion_Click(sender As Object, e As EventArgs) Handles iniciarSesion.Click
		Dim formulario As New SelecionarOpcion
		formulario.Show()
		Me.Hide()
	End Sub
End Class