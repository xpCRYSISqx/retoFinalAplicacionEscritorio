Public Class FormSelecionarOpcion
	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Dim formulario As New FormGestionarAlojamientos
		formulario.Show()
		Me.Hide()
	End Sub
End Class