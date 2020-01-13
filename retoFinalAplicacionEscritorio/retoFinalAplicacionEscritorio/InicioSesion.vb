Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class InicioSesion
	Public conexion As New MySqlConnection("datasource=188.213.5.150;port=3306;username=ldmj;password=ladamijo")
	Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
		Me.Close()
	End Sub

	Private Sub IniciarSesion_Click(sender As Object, e As EventArgs) Handles iniciarSesion.Click
		Dim formulario As New SelecionarOpcion
		If ComprobarDatos() Then
			formulario.Show()
			Me.Hide()
		Else
			contrasena.Text = ""
		End If
	End Sub

	Private Function ComprobarDatos()
		Dim comando As New MySqlCommand("SELECT `contrasena`, `administrador` FROM prueba.usuarios WHERE email = @email", conexion)
		comando.Parameters.Add("@email", MySqlDbType.VarChar).Value = email.Text

		Dim adapter As New MySqlDataAdapter(comando)
		Dim tabla As New DataTable()

		adapter.Fill(tabla)

		If tabla.Rows.Count = 0 Then
			MsgBox("Datos de inicio de sesion incorrectos", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Critical, "Error")
			Return False
		ElseIf tabla(0)(0) <> Encriptar(contrasena.Text) Then
			MsgBox("Datos de inicio de sesion incorrectos", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Critical, "Error")
			Return False
		ElseIf tabla(0)(1) <> 1 Then
			MsgBox("Este usuario no tiene derechos de administrador", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Critical, "Error")
			Return False
		End If
		Return True
	End Function

	Private Function Encriptar(ByVal input As String)
		Dim md5 As MD5 = MD5.Create()
		Dim data() As Byte = md5.ComputeHash(Encoding.Default.GetBytes(input))
		Dim stringBuilder As New StringBuilder()

		For i As Integer = 0 To data.Length - 1
			stringBuilder.Append(data(i).ToString("x2"))
		Next

		Return stringBuilder.ToString
	End Function
End Class