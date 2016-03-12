Imports Controles
Imports Entidades
Public Class ProductosRegistrados
    Private lista As New List(Of ProductosClass)
 Sub cargar()
        GrillaProductos.Rows.Clear()
        For Each c As ProductosClass In lista
            GrillaProductos.Rows.Add(c.CodiProveedor, c.CodigoProducto, c.NombreProducto, c.NombreProducto, c.FechaVencimiento, c.ValorCompra, c.ValorVenta)
        Next
    End Sub
    Private Sub ProductosRegistrados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()

    End Sub
End Class