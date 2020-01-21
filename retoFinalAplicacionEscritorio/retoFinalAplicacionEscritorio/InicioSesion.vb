Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class InicioSesion
	Public conexion As New MySqlConnection("datasource=188.213.5.150;port=3306;username=ldmj;password=ladamijo;CharSet=UTF8")
	Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
		Me.Close()
	End Sub

	Private Sub IniciarSesion_Click(sender As Object, e As EventArgs) Handles iniciarSesion.Click
		Dim formulario As New Interfaz()
		If ComprobarDatos() Then
			formulario.Show()
			Me.Hide()
		Else
			contrasena.Text = ""
		End If
	End Sub

	Private Function ComprobarDatos()
		Dim comando As New MySqlCommand("SELECT `contrasena`, `administrador`, `activo` FROM alojamientos_fac.usuarios WHERE email = @email", conexion)
		comando.Parameters.Add("@email", MySqlDbType.VarChar).Value = email.Text

		Try
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
			ElseIf tabla(0)(2) = "inactivo" Then
				MsgBox("Este usuario esta desactivado", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Critical, "Error")
				Return False
			End If
			Return True
		Catch e As MySqlException
			MessageBox.Show("Error al conectarse a la base de datos")
		End Try
		Return False
	End Function

	Public Function Encriptar(ByVal input As String)
		Dim md5 As MD5 = MD5.Create()
		Dim data() As Byte = md5.ComputeHash(Encoding.Default.GetBytes(input))
		Dim stringBuilder As New StringBuilder()

		For i As Integer = 0 To data.Length - 1
			stringBuilder.Append(data(i).ToString("x2"))
		Next

		Return stringBuilder.ToString
	End Function

	Public Sub Actualizar()
		Controls.Clear()
		InitializeComponent()
	End Sub

	Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
		Application.Exit()
	End Sub

	Private Sub Minimizar_Click(sender As Object, e As EventArgs) Handles Minimizar.Click
		WindowState = FormWindowState.Minimized
	End Sub

	<DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
	Private Shared Sub ReleaseCapture()
	End Sub
	<DllImport("user32.DLL", EntryPoint:="SendMessage")>
	Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
	End Sub

	Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Cabecera.MouseDown
		ReleaseCapture()
		SendMessage(Me.Handle, &H112&, &HF012&, 0)
	End Sub

	Private Sub Cerrar_MouseEnter(sender As Object, e As EventArgs) Handles Cerrar.MouseEnter
		Cerrar.BackColor = Color.FromArgb(217, 30, 24)
	End Sub

	Private Sub Cerrar_MouseLeave(sender As Object, e As EventArgs) Handles Cerrar.MouseLeave
		Cerrar.BackColor = Color.FromArgb(85, 174, 175)
	End Sub

	Private Sub Minimizar_MouseEnter(sender As Object, e As EventArgs) Handles Minimizar.MouseEnter
		Minimizar.BackColor = Color.FromArgb(141, 195, 232)
	End Sub

	Private Sub Minimizar_MouseLeave(sender As Object, e As EventArgs) Handles Minimizar.MouseLeave
		Minimizar.BackColor = Color.FromArgb(85, 174, 175)
	End Sub
End Class