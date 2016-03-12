Imports Controles
Imports Entidades
Public Class ProductosVencenMesEspefico
    Private gc As New GestionProductosClass
    Private lista As List(Of ProductosClass)
    Sub cargar()

        GrillaProductos.Rows.Clear()
        If lista Is Nothing Then
        Else
            For Each c As ProductosClass In lista

                If txtfecha.Text = c.FechaVencimiento.Month Then
                    GrillaProductos.Rows.Add(c.CodiProveedor, c.CodigoProducto, c.NombreProducto, c.FechaVencimiento, c.ValorCompra, c.ValorVenta)

                End If
            Next
        End If
        
    End Sub
   
    Sub actualizarlista()
        lista = gc.listado

    End Sub


    Private Sub txtfecha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtfecha.SelectedIndexChanged
        actualizarlista()

        cargar()

    End Sub

    Private Sub ProductosVencenMesEspefico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class