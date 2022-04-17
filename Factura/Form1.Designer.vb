<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.cbArticulo = New System.Windows.Forms.ComboBox()
        Me.NumericUpDownCantidad = New System.Windows.Forms.NumericUpDown()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.DataGridViewFactura = New System.Windows.Forms.DataGridView()
        Me.SaveFileDialogXML = New System.Windows.Forms.SaveFileDialog()
        Me.btnExportXML = New System.Windows.Forms.Button()
        Me.cbCodigoArticulo = New System.Windows.Forms.ComboBox()
        Me.cbPrecioArticulo = New System.Windows.Forms.ComboBox()
        CType(Me.NumericUpDownCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(264, 56)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(198, 31)
        Me.txtName.TabIndex = 0
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(264, 142)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(198, 31)
        Me.txtCodigo.TabIndex = 1
        '
        'dtFecha
        '
        Me.dtFecha.Location = New System.Drawing.Point(264, 223)
        Me.dtFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(198, 31)
        Me.dtFecha.TabIndex = 2
        '
        'cbArticulo
        '
        Me.cbArticulo.FormattingEnabled = True
        Me.cbArticulo.Location = New System.Drawing.Point(264, 398)
        Me.cbArticulo.Margin = New System.Windows.Forms.Padding(4)
        Me.cbArticulo.Name = "cbArticulo"
        Me.cbArticulo.Size = New System.Drawing.Size(198, 33)
        Me.cbArticulo.TabIndex = 4
        '
        'NumericUpDownCantidad
        '
        Me.NumericUpDownCantidad.Location = New System.Drawing.Point(264, 513)
        Me.NumericUpDownCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDownCantidad.Name = "NumericUpDownCantidad"
        Me.NumericUpDownCantidad.Size = New System.Drawing.Size(98, 31)
        Me.NumericUpDownCantidad.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(1040, 642)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(244, 31)
        Me.TextBox4.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 56)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 131)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Codigo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 223)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 312)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Condigo del Articulo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 406)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Articulo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 504)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cantidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(700, 648)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 25)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "TOTAL sin IVA"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(1040, 735)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(244, 31)
        Me.TextBox5.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(700, 740)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 25)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "SUBTOTAL"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(1188, 827)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(98, 31)
        Me.TextBox6.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(700, 833)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 25)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "IVA"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(1040, 917)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(244, 31)
        Me.TextBox7.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(700, 919)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 25)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "TOTAL + IVA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Factura.My.Resources.Resources._5f7f8ccf2b7a7189bbaf491e18f5fe34
        Me.PictureBox1.Location = New System.Drawing.Point(792, 33)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(492, 537)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(48, 619)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(151, 25)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Precio Articulo"
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(344, 690)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(120, 58)
        Me.btnSalvar.TabIndex = 23
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'DataGridViewFactura
        '
        Me.DataGridViewFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFactura.Location = New System.Drawing.Point(24, 979)
        Me.DataGridViewFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewFactura.Name = "DataGridViewFactura"
        Me.DataGridViewFactura.RowHeadersWidth = 82
        Me.DataGridViewFactura.RowTemplate.Height = 33
        Me.DataGridViewFactura.Size = New System.Drawing.Size(1108, 179)
        Me.DataGridViewFactura.TabIndex = 24
        '
        'btnExportXML
        '
        Me.btnExportXML.Location = New System.Drawing.Point(1164, 1081)
        Me.btnExportXML.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExportXML.Name = "btnExportXML"
        Me.btnExportXML.Size = New System.Drawing.Size(176, 65)
        Me.btnExportXML.TabIndex = 25
        Me.btnExportXML.Text = "Crear Factura"
        Me.btnExportXML.UseVisualStyleBackColor = True
        '
        'cbCodigoArticulo
        '
        Me.cbCodigoArticulo.FormattingEnabled = True
        Me.cbCodigoArticulo.Location = New System.Drawing.Point(264, 303)
        Me.cbCodigoArticulo.Name = "cbCodigoArticulo"
        Me.cbCodigoArticulo.Size = New System.Drawing.Size(198, 33)
        Me.cbCodigoArticulo.TabIndex = 26
        '
        'cbPrecioArticulo
        '
        Me.cbPrecioArticulo.FormattingEnabled = True
        Me.cbPrecioArticulo.Location = New System.Drawing.Point(264, 619)
        Me.cbPrecioArticulo.Name = "cbPrecioArticulo"
        Me.cbPrecioArticulo.Size = New System.Drawing.Size(198, 33)
        Me.cbPrecioArticulo.TabIndex = 27
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1672, 1125)
        Me.Controls.Add(Me.cbPrecioArticulo)
        Me.Controls.Add(Me.cbCodigoArticulo)
        Me.Controls.Add(Me.btnExportXML)
        Me.Controls.Add(Me.DataGridViewFactura)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.NumericUpDownCantidad)
        Me.Controls.Add(Me.cbArticulo)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtName)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.NumericUpDownCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents dtFecha As DateTimePicker
    Friend WithEvents cbArticulo As ComboBox
    Friend WithEvents NumericUpDownCantidad As NumericUpDown
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSalvar As Button
    Friend WithEvents DataGridViewFactura As DataGridView
    Friend WithEvents SaveFileDialogXML As SaveFileDialog
    Friend WithEvents btnExportXML As Button
    Friend WithEvents cbCodigoArticulo As ComboBox
    Friend WithEvents cbPrecioArticulo As ComboBox
End Class
