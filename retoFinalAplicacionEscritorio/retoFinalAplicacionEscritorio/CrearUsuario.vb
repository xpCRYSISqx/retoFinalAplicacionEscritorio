Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class CrearUsuario
	Dim conexion As MySqlConnection = InicioSesion.conexion
	Private Sub CrearUsuario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
		InicioSesion.Close()
	End Sub

	Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles aceptar.Click
		If Comprobar() Then

		End If
	End Sub

	Private Function Comprobar() As Boolean
		Dim dniRegex As New Regex("^[0-9]{8,8}[A-Za-z]$")

		If dniRegex.IsMatch(dni.Text) And ValidarLetra() Then
			If ComprobarDNIBaseDatos() <> True Then
				MsgBox("Ya existe un usuario con ese DNI", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Critical, "Error")
				Return False
			End If
		Else
			MsgBox("DNI incorrecto", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Critical, "Error")
		End If
		If nombre.Text = "" Then
			MsgBox("Debes introducir un nombre", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Critical, "Error")
			Return False
		ElseIf apellido.Text = "" Then
			MsgBox("Debes introducir un apellido", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Critical, "Error")
			Return False
		End If
	End Function

	Private Function ValidarLetra() As Boolean
		Dim letras As String = "TRWAGMYFPDXBNJZSQVHLCKE"
		Dim numero As Integer = Integer.Parse(dni.Text.Substring(0, 8))
		Dim resultado As Integer = numero Mod 23
		Dim dniValido As String = numero & letras.Substring(resultado, 1)

		If dni.Text.ToUpper = dniValido Then
			Return True
		Else
			Return False
		End If
	End Function

	Private Function ComprobarDNIBaseDatos() As Boolean
		Dim comando As New MySqlCommand("SELECT * FROM prueba.usuarios WHERE dni = @dni", conexion)
		comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = dni.Text

		Dim adapter As New MySqlDataAdapter(comando)
		Dim tabla As New DataTable()

		adapter.Fill(tabla)

		If tabla.Rows.Count = 0 Then
			Return True
		Else
			Return False
		End If
	End Function
End Class