Imports Entidades
Imports AccesoDatos
Imports System.IO
Public Class GestionProductosClass

    Public archProductos As New ArchivoLeerClass(Application.StartupPath & "\Productos.text")
    Public AuxiProdu As New ArchivoLeerClass(Application.StartupPath & "\AuxProductos.text")

    Function listado() As List(Of ProductosClass)
        Dim lista As New List(Of ProductosClass)
        lista = archProductos.leerProdu
        Return lista
    End Function
    Function guardar(c As ProductosClass) As Integer
        Return archProductos.guardar(c.lineaDatos)
    End Function
    Public Function buscarID(ced As String) As ProductosClass
        Dim lista As List(Of ProductosClass) = archProductos.leerProdu
        For Each c As ProductosClass In lista
            If c.CodigoProducto = ced Then
                Return c
            End If
        Next
        Return Nothing
    End Function
    Public Function buscarPosicion(ced As String) As Integer
        Dim lista As List(Of ProductosClass) = archProductos.leerProdu
        Dim i As Integer
        For Each c As ProductosClass In lista
            If c.CodigoProducto = ced Then
                Return i
            End If
            i += 1
        Next
        Return -1
    End Function

    Public Function Modificar(l As List(Of ProductosClass)) As Boolean
        Try
            Dim sw As New StreamWriter(archProductos.ruta, False)
            For Each c As ProductosClass In l
                sw.WriteLine(c.lineaDatos)
            Next
            sw.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
  
End Class






