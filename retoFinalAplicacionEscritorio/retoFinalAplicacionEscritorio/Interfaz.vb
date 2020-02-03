Imports System.Runtime.InteropServices
Public Class Interfaz

	'Imports necesarios para hacer que se pueda arrastrar la ventana la mantener el click izquierdo en la cabecera
	<DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
	Private Shared Sub ReleaseCapture()
	End Sub

	<DllImport("user32.DLL", EntryPoint:="SendMessage")>
	Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
	End Sub

	'Metodo que captura la acción de hacer click izquierdo en la cabecera y sigue su movimiento para mover el formulario
	Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Cabecera.MouseDown
		ReleaseCapture()
		SendMessage(Me.Handle, &H112&, &HF012&, 0)
	End Sub

	'Al cargar por primera vez la pagina, ponemos como pagina de inicio la ventada de gestion de usuarios
	Private Sub Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		AbrirFormulario(New GestionarUsuarios(Me))
	End Sub

	'Metodo para plegar y desplegar el menu lateral
	Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles DesplegarMenu.Click
		If MenuVertical.Width = 250 Then
			PictureBox2.Location = New Point(0, 12)
			MenuVertical.Width = 60
		Else
			PictureBox2.Location = New Point(12, 12)
			MenuVertical.Width = 250
		End If
	End Sub

	'Metodo que hace que la aplicación se cierre al darle a la x
	Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
		Application.Exit()
	End Sub

	'Metodo que hace que la aplicacion se minimice al darle a -
	Private Sub Minimizar_Click(sender As Object, e As EventArgs) Handles Minimizar.Click
		WindowState = FormWindowState.Minimized
	End Sub

	'Metodo que hace que los nuevos formularios se abran en el contenedor principal de la interfaz. tambien controla el color que tomaran los botones laterales al
	'entrar y salir de los distintos formularios
	Public Sub AbrirFormulario(form As Object)
		If Me.Contenedor.Controls.Count > 0 Then
			Me.Contenedor.Controls.RemoveAt(0)
		End If
		Dim formHijo As New Form()
		formHijo = form
		formHijo.TopLevel = False
		formHijo.Dock = DockStyle.Fill
		formHijo.Anchor = AnchorStyles.Right
		Me.Contenedor.Controls.Add(formHijo)
		Me.Contenedor.Tag = formHijo
		formHijo.Show()
		If TypeOf formHijo Is GestionarUsuarios Or TypeOf formHijo Is CrearUsuario Or TypeOf formHijo Is DetallesUsuario Then
			Usuarios.BackColor = Color.FromArgb(248, 148, 6)
			Alojamientos.BackColor = Color.FromArgb(0, 38, 92)
			Reservas.BackColor = Color.FromArgb(0, 38, 92)
		ElseIf TypeOf formHijo Is GestionarReservas Or TypeOf formHijo Is DetallesReserva Then
			Reservas.BackColor = Color.FromArgb(248, 148, 6)
			Alojamientos.BackColor = Color.FromArgb(0, 38, 92)
			Usuarios.BackColor = Color.FromArgb(0, 38, 92)
		Else
			Alojamientos.BackColor = Color.FromArgb(248, 148, 6)
			Usuarios.BackColor = Color.FromArgb(0, 38, 92)
			Reservas.BackColor = Color.FromArgb(0, 38, 92)
		End If
	End Sub

	'Listener del boton de usuarios
	Private Sub Usuarios_Click(sender As Object, e As EventArgs) Handles Usuarios.Click
		AbrirFormulario(New GestionarUsuarios(Me))
	End Sub

	'Listener del boton de reservas
	Private Sub Reservas_Click(sender As Object, e As EventArgs) Handles Reservas.Click
		AbrirFormulario(New GestionarReservas(Me))
	End Sub

	'Listener del boton de alojamientos
	Private Sub Alojamientos_Click(sender As Object, e As EventArgs) Handles Alojamientos.Click
		AbrirFormulario(New GestionarAlojamientos(Me))
	End Sub

	'Listener del boton de cerrar sesion, el cual cierra la ventasna actual y devuelve al formulario de inicio de sesión
	Private Sub CerrarSesion_Click(sender As Object, e As EventArgs) Handles CerrarSesion.Click
		InicioSesion.Actualizar()
		InicioSesion.Show()
		Me.Close()
		MessageBox.Show("Se ha cerrado la sesión")
	End Sub

	'Metodos que controlan los colores de los botones de cerrar y minimizar al pasar el cursor por encima
	Private Sub Cerrar_MouseEnter(sender As Object, e As EventArgs) Handles Cerrar.MouseEnter
		Cerrar.BackColor = Color.FromArgb(217, 30, 24)
	End Sub

	Private Sub Cerrar_MouseLeave(sender As Object, e As EventArgs) Handles Cerrar.MouseLeave
		Cerrar.BackColor = Color.FromArgb(0, 53, 128)
	End Sub

	Private Sub Minimizar_MouseEnter(sender As Object, e As EventArgs) Handles Minimizar.MouseEnter
		Minimizar.BackColor = Color.FromArgb(141, 195, 232)
	End Sub

	Private Sub Minimizar_MouseLeave(sender As Object, e As EventArgs) Handles Minimizar.MouseLeave
		Minimizar.BackColor = Color.FromArgb(0, 53, 128)
	End Sub
End Class