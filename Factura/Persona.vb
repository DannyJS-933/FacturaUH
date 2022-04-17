Public Class Persona

    Private _nombre As String
    Private _codigo As String
    Private _fecha As Date
    Private _articulo As String
    Private _codigoArticulo As String
    Private _precioArticulo As String

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

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

    Public Property PrecioArticulo As String
        Get
            Return _precioArticulo
        End Get
        Set(value As String)
            _precioArticulo = value
        End Set
    End Property
End Class
