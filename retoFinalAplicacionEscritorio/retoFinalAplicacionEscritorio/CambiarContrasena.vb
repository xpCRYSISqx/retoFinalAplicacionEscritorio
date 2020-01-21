Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class CambiarContrasena
	Dim dni As String
	Dim conexion As MySqlConnection = InicioSesion.conexion
	Dim detalles As DetallesUsuario
	Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles contra2.TextChanged, contra1.TextChanged
		If contra1.Text <> contra2.Text Then
			labelError.Visible = True
			aceptar.Enabled = False
		Else
			labelError.Visible = False
			aceptar.Enabled = True
		End If
		If contra1.Text = "" Or contra2.Text = "" Then
			aceptar.Enabled = False
		End If
	End Sub

	Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
		detalles.ActualizarContra()
		Me.Close()
	End Sub

	Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles aceptar.Click
		Dim actualizacion As New MySqlCommand("UPDATE alojamientos_fac.usuarios SET contrasena = @contrasena WHERE dni = @dni", conexion)
		actualizacion.Parameters.Add("@dni", MySqlDbType.VarChar).Value = dni.ToString

		actualizacion.Parameters.AddWithValue("@contrasena", InicioSesion.Encriptar(contra1.Text))
		conexion.Open()
		actualizacion.ExecuteNonQuery()
		conexion.Close()
		detalles.ActualizarContra()
		Me.Close()
		MsgBox("Contraseña cambiada correctamente.", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, "Cambio correcto")
	End Sub

	Public Sub New(ByVal dniPas As String, ByRef detallesUsu As DetallesUsuario)

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		dni = dniPas
		detalles = detallesUsu
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

	Private Sub Minimizar_MouseEnter(sender As Object, e As EventArgs) Handles Minimizar.MouseEnter
		Minimizar.BackColor = Color.FromArgb(141, 195, 232)
	End Sub

	Private Sub Minimizar_MouseLeave(sender As Object, e As EventArgs) Handles Minimizar.MouseLeave
		Minimizar.BackColor = Color.FromArgb(85, 174, 175)
	End Sub
End Class