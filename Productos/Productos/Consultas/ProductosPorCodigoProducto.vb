
Imports Controles
Imports Entidades
Public Class ProductosPorCodigoProducto
    Private gc As New GestionProductosClass
    Private lista As List(Of ProductosClass)
    Sub cargar()

        GrillaProductos.Rows.Clear()
        If lista Is Nothing Then
        Else
            For Each c As ProductosClass In lista

                If c.CodigoProducto = txtcodigoproducto.Text Then

                    GrillaProductos.Rows.Add(c.CodiProveedor, c.CodigoProducto, c.NombreProducto, c.FechaVencimiento, c.ValorCompra, c.ValorVenta)

                End If
            Next
        End If
       
    End Sub

    Sub actualizarlista()
        lista = gc.listado

    End Sub

    
    Sub valida()

        If txtcodigoproducto.Text = "" Then
            GrillaProductos.Rows.Clear()
        Else
            cargar()

        End If

    End Sub

    Private Sub txtcodigoproducto_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoproducto.TextChanged
        actualizarlista()

        valida()

    End Sub


    Private Sub ProductosPorCodigoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class