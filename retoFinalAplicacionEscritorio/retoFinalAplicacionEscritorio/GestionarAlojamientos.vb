Imports MySql.Data.MySqlClient
Public Class GestionarAlojamientos
	Dim conexion As MySqlConnection = InicioSesion.conexion
	Private Sub FormGestionarAlojamientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim adapter As New MySqlDataAdapter("SELECT `id`, `nombre` FROM alojamientos_fac.provincias", conexion)
		Dim tabla As New DataTable()

		adapter.Fill(tabla)

		ComboBox1.DataSource = tabla
		ComboBox1.ValueMember = "id"
		ComboBox1.DisplayMember = "nombre"

		ActualizarLista()
	End Sub

	Private Sub GestionarAlojamientos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
		InicioSesion.Close()
	End Sub

	Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
		Dim formulario As New DetallesAlojamiento(ListBox1.SelectedValue)
		formulario.Show()
		Me.Hide()
	End Sub

	Public Sub ActualizarLista()
		Dim adapter As New MySqlDataAdapter("SELECT `signatura`, `documentname` FROM alojamientos_fac.alojamientos WHERE territory=" & ComboBox1.SelectedValue, conexion)
		Dim tabla As New DataTable()

		adapter.Fill(tabla)
		ListBox1.DataSource = tabla
		ListBox1.ValueMember = "signatura"
		ListBox1.DisplayMember = "documentname"
	End Sub

	Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
		ActualizarLista()
	End Sub

	Public Sub Actualizar()
		Controls.Clear()
		InitializeComponent()
		FormGestionarAlojamientos_Load(Me, Nothing)
	End Sub

	Private Sub CerrarSesion_Click(sender As Object, e As EventArgs)
		InicioSesion.Actualizar()
		InicioSesion.Show()
		Me.Hide()
		MessageBox.Show("Se ha cerrado la sesión")
	End Sub

	Dim HiLiteBrush As New SolidBrush(Color.FromArgb(77, 77, 77))

	Private Sub ListBox1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ListBox1.DrawItem
		e.DrawBackground()
		If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
			e.Graphics.FillRectangle(HiLiteBrush, e.Bounds)
		End If
		Using b As New SolidBrush(e.ForeColor)
			e.Graphics.DrawString(ListBox1.GetItemText(ListBox1.Items(e.Index)), e.Font, b, e.Bounds)
		End Using
		e.DrawFocusRectangle()
	End Sub
End Class