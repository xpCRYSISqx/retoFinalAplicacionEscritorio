Imports MySql.Data.MySqlClient
Public Class GestionarAlojamientos
	Dim conexion As MySqlConnection = InicioSesion.conexion
	Dim inter As Interfaz
	Private Sub FormGestionarAlojamientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim adapter As New MySqlDataAdapter("SELECT `id`, `nombre` FROM alojamientos_fac.provincias", conexion)
		Dim tabla As New DataTable()

		adapter.Fill(tabla)

		ComboBox1.DataSource = tabla
		ComboBox1.ValueMember = "id"
		ComboBox1.DisplayMember = "nombre"

		ActualizarLista()
	End Sub

	Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
		inter.AbrirFormulario(New DetallesAlojamiento(ListBox1.SelectedValue, inter, Nothing))
		Me.Close()
	End Sub

	Public Sub ActualizarLista()
		Dim adapter As New MySqlDataAdapter("SELECT `signatura`, `documentname` FROM alojamientos_fac.alojamientos WHERE territory=" & ComboBox1.SelectedValue & " ORDER BY `documentname` ASC", conexion)
		Dim tabla As New DataTable()

		adapter.Fill(tabla)
		ListBox1.DataSource = tabla
		ListBox1.ValueMember = "signatura"
		ListBox1.DisplayMember = "documentname"
	End Sub

	Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
		ActualizarLista()
	End Sub

	Dim HiLiteBrush As New SolidBrush(Color.FromArgb(77, 77, 77))

	Private Sub ListBox1_DrawItem(ByVal sender As Object, ByVal evento As System.Windows.Forms.DrawItemEventArgs) Handles ListBox1.DrawItem
		evento.DrawBackground()
		If (evento.State And DrawItemState.Selected) = DrawItemState.Selected Then
			evento.Graphics.FillRectangle(HiLiteBrush, evento.Bounds)
		End If
		Using brush As New SolidBrush(evento.ForeColor)
			evento.Graphics.DrawString(ListBox1.GetItemText(ListBox1.Items(evento.Index)), evento.Font, brush, evento.Bounds)
		End Using
		evento.DrawFocusRectangle()
	End Sub

	Public Sub New(ByRef form As Interfaz)

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		inter = form
	End Sub
End Class