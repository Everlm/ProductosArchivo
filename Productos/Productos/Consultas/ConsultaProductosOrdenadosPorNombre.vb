Imports Controles
Imports Entidades

Public Class ConsultaProductosOrdenadosPorNombre

    Private gc As New GestionProductosClass
    Private lista As List(Of ProductosClass)
    Sub cargar()

        GrillaTotalProductos.Rows.Clear()
        If lista Is Nothing Then
        Else
            For Each c As ProductosClass In lista

                GrillaTotalProductos.Rows.Add(c.CodiProveedor, c.CodigoProducto, c.NombreProducto, c.FechaVencimiento, c.ValorCompra, c.ValorVenta)

            Next
        End If
        GrillaTotalProductos.Sort(GrillaTotalProductos.Columns(3), System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Sub actualizarlista()
        lista = gc.listado

    End Sub



    Private Sub ConsultaProductosOrdenadosPorNombre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarlista()
        cargar()

    End Sub
End Class