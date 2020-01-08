Public Class SelecionarOpcion
	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Dim formulario As New GestionarAlojamientos
		formulario.Owner = Me
		formulario.Show()
		Me.Hide()
	End Sub

	Private Sub SelecionarOpcion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
		InicioSesion.Close()
	End Sub
End Class