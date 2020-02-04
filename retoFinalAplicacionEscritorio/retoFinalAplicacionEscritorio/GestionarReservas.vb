Imports MySql.Data.MySqlClient

Public Class GestionarReservas
	Dim conexion As MySqlConnection = InicioSesion.conexion
	Dim inter As Interfaz
	Private Sub GestionarReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim adapter As New MySqlDataAdapter("SELECT id as 'Código de reserva', dni as 'DNI cliente', alojamiento as 'Código alojamiento', fecha_entrada as 'Fecha de entrada', fecha_salida as 'Fecha de salida', personas as 'Personas' FROM alojamientos_fac.reservas", conexion)
		Dim tabla As New DataTable()
		adapter.Fill(tabla)

		listaReservas.DataSource = tabla
	End Sub

	Public Sub New(ByRef form As Interfaz)

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		inter = form
	End Sub

	Private Sub ListaReservas_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles listaReservas.CellDoubleClick
		If e.RowIndex <> -1 Then
			inter.AbrirFormulario(New DetallesReserva(listaReservas.Rows(e.RowIndex).Cells(0).Value, inter, Nothing))
			Me.Close()
		End If
	End Sub

	Private Sub Editar_Click(sender As Object, e As EventArgs) Handles editar.Click
		If listaReservas.CurrentRow.Cells(0).Value >= 1 Then
			inter.AbrirFormulario(New DetallesReserva(listaReservas.CurrentRow.Cells(0).Value, inter, Nothing))
			Me.Close()
		End If
	End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        inter.AbrirFormulario(New CrearReserva(Nothing, inter, Nothing))
        Me.Close()
    End Sub
End Class