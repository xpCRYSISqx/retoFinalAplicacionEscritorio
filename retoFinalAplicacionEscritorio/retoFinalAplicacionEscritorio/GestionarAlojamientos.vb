Imports MySql.Data.MySqlClient
Public Class GestionarAlojamientos
	Dim conexion As MySqlConnection = InicioSesion.conexion
	Dim inter As Interfaz
	Dim binding As New BindingSource()
	Private Sub FormGestionarAlojamientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim adapter As New MySqlDataAdapter("SELECT `id`, `nombre` FROM alojamientos_fac.provincias", conexion)
		Dim tabla As New DataTable()

		adapter.Fill(tabla)

		Dim fila As DataRow
		fila = tabla.NewRow()
		fila(0) = 0
		fila(1) = "Todas"
		tabla.Rows.InsertAt(fila, 0)

		provincias.DataSource = tabla
		provincias.ValueMember = "id"
		provincias.DisplayMember = "nombre"

		ActualizarLista()
	End Sub

	Public Sub ActualizarLista()
		Dim consulta As String
		If provincias.SelectedValue <> 0 Then
			consulta = "SELECT LEFT(`documentname`, 21) as 'Nombre', `signatura` as 'Código', `nombre` as 'Provincia', LEFT(`municipality`, 20) as 'Localidad',`lodgingtype` as 'Tipo' FROM alojamientos_fac.alojamientos, alojamientos_fac.provincias WHERE alojamientos_fac.alojamientos.territory = alojamientos_fac.provincias.id AND alojamientos_fac.alojamientos.territory=" & provincias.SelectedValue & " ORDER BY `documentname` ASC"
		Else
			consulta = "SELECT LEFT(`documentname`, 21) as 'Nombre', `signatura` as 'Código', `nombre` as 'Provincia', LEFT(`municipality`, 20) as 'Localidad',`lodgingtype` as 'Tipo' FROM alojamientos_fac.alojamientos, alojamientos_fac.provincias WHERE alojamientos_fac.alojamientos.territory = alojamientos_fac.provincias.id ORDER BY `documentname` ASC"
		End If
		Try
			Dim adapter As New MySqlDataAdapter(consulta, conexion)
			Dim tabla As New DataTable()

			adapter.Fill(tabla)
			binding.DataSource = tabla

			listaAlojamientos.DataSource = binding
		Catch ex As MySqlException

		End Try
	End Sub

	Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles provincias.SelectionChangeCommitted
		ActualizarLista()
	End Sub

	Public Sub New(ByRef form As Interfaz)

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		inter = form
	End Sub

	Private Sub ListaAlojamientos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles listaAlojamientos.CellDoubleClick
		If e.RowIndex <> -1 Then
			inter.AbrirFormulario(New DetallesAlojamiento(listaAlojamientos.Rows(e.RowIndex).Cells(1).Value, inter, Nothing))
			Me.Close()
		End If
	End Sub

	Private Sub TextoBusqueda_Enter(sender As Object, e As EventArgs) Handles textoBusqueda.Enter
		If textoBusqueda.Text = "Buscar" Then
			textoBusqueda.Text = ""
			textoBusqueda.ForeColor = Color.FromArgb(230, 230, 230)
		End If
	End Sub

	Private Sub TextoBusqueda_Leave(sender As Object, e As EventArgs) Handles textoBusqueda.Leave
		If textoBusqueda.Text = "" Then
			textoBusqueda.Text = "Buscar"
			textoBusqueda.ForeColor = Color.Gray
		End If
	End Sub

	Private Sub TextoBusqueda_TextChanged(sender As Object, e As EventArgs) Handles textoBusqueda.TextChanged
		If textoBusqueda.Text <> "Buscar" Then
			binding.Filter = String.Format("{0} LIKE '{1}%'", "Nombre", textoBusqueda.Text)
			'binding.Sort = "Nombre ASC"
		Else
			binding.Filter = String.Format("{0} LIKE '{1}%'", "Nombre", "")
		End If
	End Sub
End Class