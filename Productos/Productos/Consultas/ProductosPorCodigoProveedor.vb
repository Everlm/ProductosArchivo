Imports Controles
Imports Entidades
Public Class ProductosPorCodigoProveedor

    Private gc As New GestionProductosClass
    Private lista As List(Of ProductosClass)
    Private listaprove As List(Of ProveedorClass)
    Private gt As New GestionProveedorClass
    Sub cargar()

        GrillaProductos.Rows.Clear()
        If lista Is Nothing Then
        Else
            For Each c As ProductosClass In lista


                If c.CodiProveedor = txtcodigoproveedor.Text Then
                    If c.FechaVencimiento < System.DateTime.Now Then

                        GrillaProductos.Rows.Add(c.CodiProveedor, c.CodigoProducto, c.NombreProducto, c.FechaVencimiento, c.ValorCompra, c.ValorVenta)

                    End If
                End If
            Next
        End If

    End Sub
   
    Sub actualizarlista()
        lista = gc.listado

    End Sub


    Private Sub txtcodigoproveedor_TextChanged(sender As Object, e As EventArgs)


    End Sub

   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        actualizarlista()
        cargar()




    End Sub

    Private Sub ProductosPorCodigoProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class