Imports Controles
Imports Entidades
Public Class TotalProductos
    Private lista As List(Of ProductosClass)
    Private gc As New GestionProductosClass
    Sub cargar()

        GrillaTotalProductos.Rows.Clear()
        If lista Is Nothing Then
        Else
            For Each c As ProductosClass In lista


                GrillaTotalProductos.Rows.Add(c.CodiProveedor, c.CodigoProducto, c.NombreProducto, c.FechaVencimiento, c.ValorCompra, c.ValorVenta)


            Next
        End If




    End Sub
    Sub actualizarlista()
        lista = gc.listado

    End Sub




    Private Sub TotalProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarlista()

        cargar()

    End Sub
End Class