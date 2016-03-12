Public Class ProductosClass
    Private CodProducto As String
    Private NomProducto As String
    Private FechVencimi As Date
    Private ValCompra As Decimal
    Private ValVenta As Decimal
    Private CodProveedor As String

    Public Property CodiProveedor As String
        Get
            Return CodProveedor
        End Get
        Set(value As String)
            CodProveedor = value
        End Set
    End Property

    Public Property CodigoProducto As String
        Get
            Return CodProducto
        End Get
        Set(value As String)
            CodProducto = value
        End Set
    End Property

    Public Property FechaVencimiento As Date
        Get
            Return FechVencimi
        End Get
        Set(value As Date)
            FechVencimi = value
        End Set
    End Property

    Public Property NombreProducto As String
        Get
            Return NomProducto
        End Get
        Set(value As String)
            NomProducto = value
        End Set
    End Property

    Public Property ValorCompra As Decimal
        Get
            Return ValCompra
        End Get
        Set(value As Decimal)
            ValCompra = value
        End Set
    End Property

    Public Property ValorVenta As Decimal
        Get
            Return ValVenta
        End Get
        Set(value As Decimal)
            ValVenta = value
        End Set
    End Property

    Sub New(linea As String)
        Dim aux() As String
        aux = Split(linea, ";")
        CodProveedor = aux(0)
        CodProducto = aux(1)
        NomProducto = aux(2)
        FechVencimi = CDate(aux(3))
        ValCompra = aux(4)
        ValVenta = aux(5)

    End Sub
    Sub New()
        MyBase.New()
    End Sub

    Public Function lineaDatos() As String
        Dim s As String
        s = CodProveedor & ";" & CodProducto & ";" & NomProducto & ";" & FechVencimi & ";" & ValCompra & ";" & ValVenta
        Return s
    End Function


End Class
