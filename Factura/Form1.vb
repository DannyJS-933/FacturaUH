Imports System.Xml

Public Class Form1

    'Cargar ComboBox
    Dim dataArticulos = {"Mouse", "Monitor", "Teclado", "Headset", "Cargador", "Laptop", "Router", "Desktop"}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbArticulo.Items.AddRange(dataArticulos)
        cbArticulo.SelectedIndex = 0

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try
            'obtener las variables
            Dim nombre = txtName.Text
            Dim codigo = txtCodigo.Text
            Dim fecha = dtFecha.Value
            Dim codigoArticulo = txtCodigoArticulo.Text
            Dim cantidad = NumericUpDownCantidad.Value
            Dim precioArticulo = txtPrecio.Text

            'validar campos
            If String.IsNullOrEmpty(nombre) Then
                MessageBox.Show("Nombre no puede ser vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf String.IsNullOrEmpty(codigo) Then
                MessageBox.Show("Codigo no puede ser vacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf String.IsNullOrEmpty(codigoArticulo) Then
                MessageBox.Show("Codigo articulo no puede ser vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf cantidad = 0 Then
                MessageBox.Show("Error", "Cantidad articulos debe ser mayor a 0", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'Acciones si todo esta bien defino el objeto Persona e instancio la clase
                Dim objPersona As New Persona
                Dim objArticulo As New articulo
                objPersona.Nombre = nombre
                objPersona.Codigo = codigoArticulo
                objPersona.Fecha = fecha

                'Agregar el objeto persona a una lista



            End If

        Catch ex As Exception
            MessageBox.Show("Error", "Error: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cargarTabla()
        Try
            'Definir una tabla
            Dim tabla As New DataTable
            tabla.Columns.Add("Nombre")
            tabla.Columns.Add("Codigo de Articulo")
            tabla.Columns.Add("Fecha")

        Catch ex As Exception
            MessageBox.Show("Error", "Error: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
