Imports Controles
Imports Entidades
Public Class ProductosPorRangoFechaVencimiento

    Private gc As New GestionProductosClass
    Private lista As List(Of ProductosClass)
    Sub cargar()

        GrillaProductos.Rows.Clear()
        If lista Is Nothing Then
        Else
            For Each c As ProductosClass In lista

                If txtfecha.Value.Day <= c.FechaVencimiento.Day And txtfecha2.Value.Day >= c.FechaVencimiento.Day Then

                    If txtfecha.Value.Month <= c.FechaVencimiento.Month And txtfecha2.Value.Month >= c.FechaVencimiento.Month Then
                        If txtfecha.Value.Year <= c.FechaVencimiento.Year And txtfecha2.Value.Year >= c.FechaVencimiento.Year Then

                            GrillaProductos.Rows.Add(c.CodiProveedor, c.CodigoProducto, c.NombreProducto, c.FechaVencimiento, c.ValorCompra, c.ValorVenta)
                        End If
                    End If

                End If
            Next
        End If
        

    End Sub

    Sub sumar()
        Try
            Dim Total As Single
            Dim Col As Integer = Me.GrillaProductos.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.GrillaProductos.Rows
                Total += Val(row.Cells(5).Value)
            Next
            Me.txttotal.Text = Total.ToString
        Catch ex As Exception

        End Try
       
    End Sub
    Sub actualizarlista()
        lista = gc.listado

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        actualizarlista()
        cargar()
        sumar()

    End Sub

    Private Sub ProductosPorRangoFechaVencimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged
        sumar()

    End Sub
End Class