Public Class ProveedorClass
    Private CodProveedor As String
    Private NomProveedor As String

    Public Property CodigoProveedor As String
        Get
            Return CodProveedor
        End Get
        Set(value As String)
            CodProveedor = value
        End Set
    End Property

    Public Property NombreProveedor As String
        Get
            Return NomProveedor
        End Get
        Set(value As String)
            NomProveedor = value
        End Set
    End Property

    Sub New(linea As String)
        Dim aux() As String
        aux = Split(linea, ";")
        CodProveedor = aux(0)
        NomProveedor = aux(1)
      
    End Sub
    Sub New()
        MyBase.New()
    End Sub

    Public Function lineaDatos() As String
        Dim s As String
        s = CodProveedor & ";" & NomProveedor
        Return s
    End Function



End Class
