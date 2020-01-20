Imports MySql.Data.MySqlClient
Public Class DetallesUsuario
	Dim cod As String
	Dim conexion As MySqlConnection = InicioSesion.conexion
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

	Public Sub New(ByVal dniGestion As String)

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		cod = dniGestion
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles atras.Click
		GestionarUsuarios.Show()
		Me.Hide()
	End Sub

	Private Sub Editar_Click(sender As Object, e As EventArgs) Handles editar.Click
		HabilitarCampos()
		terminar.Enabled = True
		terminar.Visible = True
		editar.Enabled = False
		editar.Visible = False
		actualiza.Enabled = False
	End Sub

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

		conexion.Open()
		actualizacion.ExecuteNonQuery()
		conexion.Close()
		GestionarUsuarios.Actualizar()
		Interfaz.AbrirFormulario(New GestionarUsuarios)
		Me.Close()
	End Sub

	Private Sub Terminar_Click(sender As Object, e As EventArgs) Handles terminar.Click
		DeshabilitarCampos()
		terminar.Enabled = False
		terminar.Visible = False
		editar.Enabled = True
		editar.Visible = True
		actualiza.Enabled = True
	End Sub

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

	Private Sub CambiarContraseña_Click(sender As Object, e As EventArgs) Handles cambiarContrasena.Click
		Dim formulario As New CambiarContrasena(cod, Me)
		formulario.Show()
		cambiarContrasena.Enabled = False
	End Sub

	Public Sub ActualizarContra()
		cambiarContrasena.Enabled = True
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

	Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
		Application.Exit()
	End Sub

	Private Sub Minimizar_Click(sender As Object, e As EventArgs) Handles Minimizar.Click
		WindowState = FormWindowState.Minimized
	End Sub
End Class