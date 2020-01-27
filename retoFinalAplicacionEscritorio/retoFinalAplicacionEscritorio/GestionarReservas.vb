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

	Private Sub ListaReservas_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles listaReservas.CellContentDoubleClick
		If e.RowIndex <> -1 Then
			inter.AbrirFormulario(New DetallesReserva(listaReservas.Rows(e.RowIndex).Cells(0).Value, inter))
			Me.Close()
		End If
	End Sub
End Class