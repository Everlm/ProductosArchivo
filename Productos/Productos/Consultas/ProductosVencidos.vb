Imports Controles
Imports Entidades
Public Class ProductosVencidos
    Private gc As New GestionProductosClass
    Private lista As List(Of ProductosClass)
    Sub cargar()

        GrillaProductos.Rows.Clear()
        If lista Is Nothing Then
        Else
            For Each c As ProductosClass In lista

                If c.FechaVencimiento < System.DateTime.Now Then
                    GrillaProductos.Rows.Add(c.CodiProveedor, c.CodigoProducto, c.NombreProducto, c.FechaVencimiento, c.ValorCompra, c.ValorVenta)

                End If
            Next
        End If
        

    End Sub
    Sub actualizarlista()
        lista = gc.listado

    End Sub

    Private Sub ProductosVencidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarlista()

        cargar()

    End Sub
End Class