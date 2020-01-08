Public Class SelecionarOpcion
	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Dim formulario As New GestionarAlojamientos
		formulario.Show()
		Me.Hide()
	End Sub
End Class