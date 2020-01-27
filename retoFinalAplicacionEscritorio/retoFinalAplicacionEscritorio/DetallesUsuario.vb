Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class DetallesUsuario
	Dim cod As String 'Codigo del usuario
	Dim conexion As MySqlConnection = InicioSesion.conexion 'Instancia de la conexion
	Dim inter As Interfaz 'Instancia de la interfaz principal
	Dim reserva As DetallesReserva 'Intancia del formulario de detalles de la reserva

	'Muestra los detalles del usuario seleccionado en el formulario de gestion de usuarios al cargar el formulario de detalles
	Private Sub DetallesUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim comando As New MySqlCommand("SELECT `dni`, `nombre`, `apellido`, `email`, `telefono`, `administrador`, `activo` FROM alojamientos_fac.usuarios WHERE dni = @dni", conexion)
		comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = cod

		Dim adapter As New MySqlDataAdapter(comando)
		Dim tabla As New DataTable()

		adapter.Fill(tabla)

		dni.Text = tabla(0)(0)
		nombre.Text = tabla(0)(1)
		apellido.Text = tabla(0)(2)
		mail.Text = tabla(0)(3)
		telefono.Text = tabla(0)(4)
		If tabla(0)(5) = 1 Then
			adminSi.Checked = True
		Else
			adminNo.Checked = True
		End If
		If tabla(0)(6) = "activo" Then
			actSi.Checked = True
		Else
			actNo.Checked = True
		End If
		DeshabilitarCampos()
	End Sub

	'Contructor del formulario
	Public Sub New(ByVal dniGestion As String, ByRef form As Interfaz, ByRef form2 As DetallesReserva)

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		cod = dniGestion
		inter = form
		reserva = form2
	End Sub

	'Listener del boton de atras
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles atras.Click
		If TypeOf reserva Is DetallesReserva Then
			inter.AbrirFormulario(reserva)
		Else
			inter.AbrirFormulario(New GestionarUsuarios(inter))
		End If
		Me.Close()
	End Sub

	'listener del boton de edtiar, el cual habilita la edición de los diferentes campos del usuario
	Private Sub Editar_Click(sender As Object, e As EventArgs) Handles editar.Click
		HabilitarCampos()
		terminar.Enabled = True
		terminar.Visible = True
		editar.Enabled = False
		editar.Visible = False
		actualiza.Enabled = False
	End Sub

	'Listener del boton actualizar, actualiza la informacion del usuario en la base de datos una vez terminada la edición
	Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles actualiza.Click
		Dim actualizacion As New MySqlCommand("UPDATE alojamientos_fac.usuarios SET nombre = @nombre, apellido = @apellido, telefono = @telefono, email = @email, administrador = @admin, activo = @activo WHERE dni = @dni", conexion)
		actualizacion.Parameters.Add("@dni", MySqlDbType.VarChar).Value = cod.ToString

		actualizacion.Parameters.AddWithValue("@nombre", nombre.Text)
		actualizacion.Parameters.AddWithValue("@apellido", apellido.Text)
		actualizacion.Parameters.AddWithValue("@telefono", telefono.Text)
		actualizacion.Parameters.AddWithValue("@email", mail.Text)
		If adminSi.Checked = True Then
			actualizacion.Parameters.AddWithValue("@admin", 1)
		Else
			actualizacion.Parameters.AddWithValue("@admin", 0)
		End If
		If actSi.Checked = True Then
			actualizacion.Parameters.AddWithValue("@activo", "activo")
		Else
			actualizacion.Parameters.AddWithValue("@activo", "inactivo")
		End If
		Try
			conexion.Open()
			actualizacion.ExecuteNonQuery()
			conexion.Close()
		Catch ex As MySqlException
			MessageBox.Show("Error al cargar los datos actualizados en la base de datos")
		End Try
		inter.AbrirFormulario(New GestionarUsuarios(inter))
		Me.Close()
	End Sub

	'Listener del boton terminar edición, vuelve a desabilitar los campos del usuario y habilita la posibilidad de actualizar la base de datos con los nuevos detalles
	Private Sub Terminar_Click(sender As Object, e As EventArgs) Handles terminar.Click
		DeshabilitarCampos()
		terminar.Enabled = False
		terminar.Visible = False
		editar.Enabled = True
		editar.Visible = True
		actualiza.Enabled = True
	End Sub

	'Habilita los distintos campos del formulario
	Private Sub HabilitarCampos()
		nombre.ReadOnly = False
		nombre.Cursor = Cursors.IBeam
		apellido.ReadOnly = False
		apellido.Cursor = Cursors.IBeam
		mail.ReadOnly = False
		mail.Cursor = Cursors.IBeam
		telefono.ReadOnly = False
		telefono.Cursor = Cursors.IBeam
		admin.Enabled = True
		admin.Cursor = Cursors.Default
		activo.Enabled = True
		activo.Cursor = Cursors.Default
	End Sub

	'Deshabilita los distintos campos del formulario
	Private Sub DeshabilitarCampos()
		nombre.ReadOnly = True
		nombre.Cursor = Cursors.No
		apellido.ReadOnly = True
		apellido.Cursor = Cursors.No
		mail.ReadOnly = True
		mail.Cursor = Cursors.No
		telefono.ReadOnly = True
		telefono.Cursor = Cursors.No
		admin.Enabled = False
		admin.Cursor = Cursors.No
		activo.Enabled = False
		activo.Cursor = Cursors.No
	End Sub

	'Habilita el panel para cambiar la contraseña
	Private Sub CambiarContraseña_Click(sender As Object, e As EventArgs) Handles cambiarContrasena.Click
		PanelContrasena.Visible = True
		PanelContrasena.Enabled = True
		cambiarContrasena.Enabled = False
		cambiarContrasena.Visible = False
	End Sub

	'Esconde el panel de contraseña despues de actualizarla o al cancelar la actualización
	Public Sub EsconderContra()
		PanelContrasena.Visible = False
		PanelContrasena.Enabled = False
		cambiarContrasena.Enabled = True
		cambiarContrasena.Visible = True
	End Sub

	'Comprueba si las contraseñas son iguales
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

	'Listener del boton de calncelar al cambio de contraseña
	Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
		EsconderContra()
	End Sub

	'Actualiza la información de la contraseña del usuario en la base de datos
	Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles aceptar.Click
		Dim actualizacion As New MySqlCommand("UPDATE alojamientos_fac.usuarios SET contrasena = @contrasena WHERE dni = @dni", conexion)
		actualizacion.Parameters.Add("@dni", MySqlDbType.VarChar).Value = dni.Text

		actualizacion.Parameters.AddWithValue("@contrasena", InicioSesion.Encriptar(contra1.Text))
		Try
			conexion.Open()
			actualizacion.ExecuteNonQuery()
			conexion.Close()
		Catch ex As Exception
			MessageBox.Show("Error al actualizar la contraseña en la base de datos")
		End Try
		EsconderContra()
		MsgBox("Contraseña cambiada correctamente.", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, "Cambio correcto")
	End Sub
End Class