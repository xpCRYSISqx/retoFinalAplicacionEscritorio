Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class CrearUsuario
	Dim conexion As MySqlConnection = InicioSesion.conexion
	Dim inter As Interfaz
	Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles aceptar.Click
		If Comprobar() Then
			Dim comando As New MySqlCommand("INSERT INTO alojamientos_fac.usuarios (`dni`, `nombre`, `apellido`, `contrasena`, `telefono`, `email`, `administrador`, `activo`) VALUES (@dni,@nombre,@apellido,@contrasena,@telefono,@email,@administrador,@activo)", conexion)
			comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = dni.Text.ToUpper
			comando.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = nombre.Text
			comando.Parameters.Add("@apellido", MySqlDbType.VarChar).Value = apellido.Text
			comando.Parameters.Add("@contrasena", MySqlDbType.VarChar).Value = InicioSesion.Encriptar(contra1.Text)
			comando.Parameters.Add("@telefono", MySqlDbType.Int16).Value = Integer.Parse(telefono.Text)
			comando.Parameters.Add("@email", MySqlDbType.VarChar).Value = mail.Text
			If adminSi.Checked = True Then
				comando.Parameters.Add("@administrador", MySqlDbType.Int16).Value = 1
			Else
				comando.Parameters.Add("@administrador", MySqlDbType.Int16).Value = 0
			End If
			comando.Parameters.Add("@activo", MySqlDbType.VarChar).Value = "activo"
			Try
				conexion.Open()
				comando.ExecuteNonQuery()
				conexion.Close()
			Catch ex As Exception
				MessageBox.Show("Error al insertar los datos en la base de datos")
			End Try
			inter.AbrirFormulario(New GestionarUsuarios(inter))
			Me.Close()
		End If
	End Sub

	Private Function Comprobar() As Boolean
		Dim dniRegex As New Regex("^[0-9]{8,8}[A-Za-z]$")
		Dim mailRegex As New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")

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
		ElseIf mail.text = "ejemplo@ejemplo.com" Then
			MsgBox("El correo electronico no tiene un formato válido", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Critical, "Error")
			Return False
		ElseIf mailRegex.IsMatch(mail.text) <> True Then
			MsgBox("El correo electronico no tiene un formato válido", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Critical, "Error")
			Return False
		ElseIf telefono.Text.Length <> 9 Then
			MsgBox("Telefono no válido", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Critical, "Error")
			Return False
		ElseIf contra1.Text = "" Or contra2.Text = "" Then
			MsgBox("Debes introducir una contraseña", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Critical, "Error")
			Return False
		End If
		Return True
	End Function

	Private Function ValidarLetra() As Boolean
		If dni.Text.Length = 9 Then
			Dim letras As String = "TRWAGMYFPDXBNJZSQVHLCKE"
			Dim numero As Integer = Integer.Parse(dni.Text.Substring(0, 8))
			Dim resultado As Integer = numero Mod 23
			Dim dniValido As String = numero & letras.Substring(resultado, 1)

			If dni.Text.ToUpper = dniValido Then
				Return True
			Else
				Return False
			End If
		End If
		Return False
	End Function

	Private Function ComprobarDNIBaseDatos() As Boolean
		Dim comando As New MySqlCommand("SELECT * FROM alojamientos_fac.usuarios WHERE dni = @dni", conexion)
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

	Private Sub Mail_Enter(sender As Object, e As EventArgs) Handles mail.Enter
		If mail.Text = "ejemplo@ejemplo.com" Then
			mail.Text = ""
			mail.ForeColor = Color.FromArgb(230, 230, 230)
		End If
	End Sub

	Private Sub Mail_Leave(sender As Object, e As EventArgs) Handles mail.Leave
		If mail.Text = "" Then
			mail.Text = "ejemplo@ejemplo.com"
			mail.ForeColor = Color.Gray
		End If
	End Sub

	Private Sub CompararContraseñas(sender As Object, e As EventArgs) Handles contra2.TextChanged, contra1.TextChanged
		If contra1.Text <> contra2.Text Then
			labelError.Visible = True
			aceptar.Enabled = False
		Else
			labelError.Visible = False
			aceptar.Enabled = True
		End If
	End Sub

	Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
		inter.AbrirFormulario(New GestionarUsuarios(inter))
		Me.Close()
	End Sub

	Public Sub New(ByRef form As Interfaz)

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		inter = form
	End Sub
End Class