Public Class articulo

    Private _articulo As String
    Private _codigoArticulo As String
    Private _precioArticulo As Integer


    Public Property Articulo As String
        Get
            Return _articulo
        End Get
        Set(value As String)
            _articulo = value
        End Set
    End Property

    Public Property CodigoArticulo As String
        Get
            Return _codigoArticulo
        End Get
        Set(value As String)
            _codigoArticulo = value
        End Set
    End Property

    Public Property PrecioArticulo As Integer
        Get
            Return _precioArticulo
        End Get
        Set(value As Integer)
            _precioArticulo = value
        End Set
    End Property
End Class
