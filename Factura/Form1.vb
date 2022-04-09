﻿Imports System.Xml

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
            tabla.Columns.Add("Codigo de Articulo")
            tabla.Columns.Add("Fecha")

            'Recorrer lista
            If listaPersona.Count > 0 Then
                'Recorrer la lista 
                For Each objeto As Persona In listaPersona
                    tabla.Rows.Add(objeto.Nombre, objeto.Codigo, objeto.Fecha)
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
End Class
