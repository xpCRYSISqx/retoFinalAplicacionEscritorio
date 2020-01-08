Public Class DetallesAlojamiento
	Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
		GestionarAlojamientos.Show()
		Me.Hide()
	End Sub

	Private Sub DetallesAlojamiento_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
		InicioSesion.Close()
	End Sub
End Class