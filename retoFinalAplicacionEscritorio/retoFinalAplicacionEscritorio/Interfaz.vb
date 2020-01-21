Imports System.Runtime.InteropServices
Public Class Interfaz

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

	Private Sub Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		AbrirFormulario(New GestionarUsuarios(Me))
	End Sub

	Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles DesplegarMenu.Click
		If MenuVertical.Width = 250 Then
			MenuVertical.Width = 95
		Else
			MenuVertical.Width = 250
		End If
	End Sub

	Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
		Application.Exit()
	End Sub

	Private Sub Minimizar_Click(sender As Object, e As EventArgs) Handles Minimizar.Click
		WindowState = FormWindowState.Minimized
	End Sub

	Public Sub AbrirFormulario(form As Object)
		If Me.Contenedor.Controls.Count > 0 Then
			Me.Contenedor.Controls.RemoveAt(0)
		End If
		Dim formHijo As New Form()
		formHijo = form
		formHijo.TopLevel = False
		formHijo.Dock = DockStyle.Fill
		formHijo.Anchor = AnchorStyles.Top.Right
		Me.Contenedor.Controls.Add(formHijo)
		Me.Contenedor.Tag = formHijo
		formHijo.Show()
		If TypeOf formHijo Is GestionarUsuarios Then
			Usuarios.BackColor = Color.FromArgb(60, 179, 113)
			Alojamientos.BackColor = Color.FromArgb(0, 134, 136)
			Reservas.BackColor = Color.FromArgb(0, 134, 136)
		ElseIf TypeOf formHijo Is GestionarReservas Then
			Reservas.BackColor = Color.FromArgb(60, 179, 113)
			Alojamientos.BackColor = Color.FromArgb(0, 134, 136)
			Usuarios.BackColor = Color.FromArgb(0, 134, 136)
		Else
			Alojamientos.BackColor = Color.FromArgb(60, 179, 113)
			Usuarios.BackColor = Color.FromArgb(0, 134, 136)
			Reservas.BackColor = Color.FromArgb(0, 134, 136)
		End If
	End Sub

	Private Sub Usuarios_Click(sender As Object, e As EventArgs) Handles Usuarios.Click
		AbrirFormulario(New GestionarUsuarios(Me))
	End Sub

	Private Sub Alojamientos_Click(sender As Object, e As EventArgs) Handles Alojamientos.Click
		AbrirFormulario(New GestionarAlojamientos)
	End Sub

	Private Sub CerrarSesion_Click(sender As Object, e As EventArgs) Handles CerrarSesion.Click
		InicioSesion.Actualizar()
		InicioSesion.Show()
		Me.Hide()
		MessageBox.Show("Se ha cerrado la sesión")
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

	Public Sub ActualizarUsuarios()
		AbrirFormulario(New GestionarAlojamientos)
	End Sub
End Class