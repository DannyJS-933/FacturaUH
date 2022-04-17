Imports System.Xml

Public Class Form1

    'Cargar ComboBox
    Dim dataArticulos = {"Mouse", "Monitor", "Teclado", "Headset", "Cargador", "Laptop", "Router", "Desktop"}
    Dim dataPrecioArticulo() As Integer = {12000, 280000, 15000, 20000, 10000, 500000, 25000, 380000}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbArticulo.Items.AddRange(dataArticulos)
            cbArticulo.SelectedIndex = 0


            cbPrecioArticulo.DropDownStyle = ComboBoxStyle.DropDownList
            cbPrecioArticulo.DataSource = dataPrecioArticulo

            For i As Integer = 0 To 7
                Dim valorCodigoArticulo As String = i.ToString()
                cbCodigoArticulo.Items.Add(valorCodigoArticulo)
            Next


        Catch ex As Exception
            MessageBox.Show("Error", "Error: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try
            'obtener las variables
            Dim nombre = txtName.Text
            Dim codigo = txtCodigo.Text
            Dim fecha = dtFecha.Value
            Dim codigoArticulo = cbCodigoArticulo.Text
            Dim cantidad = NumericUpDownCantidad.Value
            Dim precioArticulo = cbPrecioArticulo.Text
            Dim articulo = cbArticulo.Text

            'validar campos
            If String.IsNullOrEmpty(nombre) Then
                MessageBox.Show("Nombre no puede ser vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf String.IsNullOrEmpty(codigo) Then
                MessageBox.Show("Codigo no puede ser vacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf String.IsNullOrEmpty(codigoArticulo) Then
                MessageBox.Show("Codigo articulo no puede ser vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf cantidad = 0 Then
                MessageBox.Show("Error", "Cantidad articulos debe ser mayor a 0", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf String.IsNullOrEmpty(precioArticulo) Then
                MessageBox.Show("Debe indicar el precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'Acciones si todo esta bien defino el objeto Persona e instancio la clase
                Dim objPersona As New Persona
                objPersona.Nombre = nombre
                objPersona.Codigo = codigoArticulo
                objPersona.Fecha = fecha
                objPersona.Articulo = articulo
                objPersona.CodigoArticulo = codigoArticulo
                objPersona.PrecioArticulo = precioArticulo

                'Agregar el objeto persona a una lista
                listaPersona.Add(objPersona)

                'llamar a la tabla
                cargarTabla()
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
            tabla.Columns.Add("Codigo usuario")
            tabla.Columns.Add("Fecha")
            tabla.Columns.Add("Articulo")
            tabla.Columns.Add("Codigo Articulo")
            tabla.Columns.Add("Precio del Articulo")

            'Recorrer lista
            If listaPersona.Count > 0 Then
                'Recorrer la lista 
                For Each objeto As Persona In listaPersona
                    tabla.Rows.Add(objeto.Nombre, objeto.Codigo, objeto.Fecha, objeto.Articulo, objeto.CodigoArticulo, objeto.PrecioArticulo)
                Next

                'Asignar al GridView 
                DataGridViewFactura.DataSource = tabla
            Else
                MessageBox.Show("Noy Hay informacion para mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error", "Error: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportXML_Click(sender As Object, e As EventArgs) Handles btnExportXML.Click
        'Salvar datos en un XML
        Try
            If listaPersona.Count > 0 Then

                'Configurar el FileDialog
                SaveFileDialogXML.Title = "Seleccione la ubicacion en la que desea guardar la factura"
                SaveFileDialogXML.Filter = "XML | *.xml"

                'Abrir el dialog
                If SaveFileDialogXML.ShowDialog = Windows.Forms.DialogResult.OK Then
                    'Obtener la ruta del archivo 
                    Dim urlArchivoXML = SaveFileDialogXML.FileName

                    'Configura el writter
                    Dim config As New XmlWriterSettings()

                    'Salto de linea 
                    config.Indent = True

                    'Crear el XML
                    Using writer As XmlWriter = XmlWriter.Create(urlArchivoXML, config)
                        writer.WriteStartDocument()
                        writer.WriteStartElement("Factura") 'Este es el tag principal <Factura>

                        For Each objPersona As Persona In listaPersona
                            'Escribir en el XML
                            'Creando el tag <Persona> 
                            writer.WriteStartElement("Persona")
                            'Agregamos los atributos
                            writer.WriteElementString("Nombre", objPersona.Nombre)
                            writer.WriteElementString("Codigo", objPersona.Codigo)
                            writer.WriteElementString("Fecha", objPersona.Fecha)
                            writer.WriteElementString("Articulo", objPersona.Articulo)
                            writer.WriteElementString("CodigoArticulo", objPersona.CodigoArticulo)
                            writer.WriteElementString("PrecioArticulo", objPersona.PrecioArticulo)
                            'Aqui cerramos el tag <Persona>
                            writer.WriteEndElement()
                        Next
                        'Cerramos el tag principal <Factura>
                        writer.WriteEndElement()
                        'Cerramos el XML
                        writer.WriteEndDocument()
                    End Using
                Else
                    MessageBox.Show("No selecciono una ruta valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbCodigoArticulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCodigoArticulo.SelectedIndexChanged

        Try
            If cbCodigoArticulo.SelectedIndex = 0 Then
                cbArticulo.SelectedIndex = 0
            ElseIf cbCodigoArticulo.SelectedIndex = 1 Then
                cbArticulo.SelectedIndex = 1
            ElseIf cbCodigoArticulo.SelectedIndex = 2 Then
                cbArticulo.SelectedIndex = 2
            ElseIf cbCodigoArticulo.SelectedIndex = 3 Then
                cbArticulo.SelectedIndex = 3
            ElseIf cbCodigoArticulo.SelectedIndex = 4 Then
                cbArticulo.SelectedIndex = 4
            ElseIf cbCodigoArticulo.SelectedIndex = 5 Then
                cbArticulo.SelectedIndex = 5
            ElseIf cbCodigoArticulo.SelectedIndex = 6 Then
                cbArticulo.SelectedIndex = 6
            ElseIf cbCodigoArticulo.SelectedIndex = 7 Then
                cbArticulo.SelectedIndex = 7
            Else
                MessageBox.Show("Los datos no son validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbArticulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbArticulo.SelectedIndexChanged
        Try
            If cbArticulo.SelectedItem = "Mouse" Then
                cbPrecioArticulo.SelectedItem = 12000
            ElseIf cbArticulo.SelectedItem = "Monitor" Then
                cbPrecioArticulo.SelectedItem = 280000
            ElseIf cbArticulo.SelectedItem = "Teclado" Then
                cbPrecioArticulo.SelectedItem = 15000
            ElseIf cbArticulo.SelectedItem = "Headset" Then
                cbPrecioArticulo.SelectedItem = 20000
            ElseIf cbArticulo.SelectedItem = "Cargador" Then
                cbPrecioArticulo.SelectedItem = 10000
            ElseIf cbArticulo.SelectedItem = "Laptop" Then
                cbPrecioArticulo.SelectedItem = 500000
            ElseIf cbArticulo.SelectedItem = "Router" Then
                cbPrecioArticulo.SelectedItem = 25000
            ElseIf cbArticulo.SelectedItem = "Desktop" Then
                cbPrecioArticulo.SelectedItem = 380000
            Else
                MessageBox.Show("Los datos no son validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
