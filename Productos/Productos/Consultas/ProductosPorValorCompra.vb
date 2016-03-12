﻿Imports Controles
Imports Entidades
Public Class ProductosPorValorCompra
    Private gc As New GestionProductosClass
    Private lista As List(Of ProductosClass)
    Sub cargar()
        GrillaProductos.Rows.Clear()
        If lista Is Nothing Then
        Else
            For Each c As ProductosClass In lista

                If c.ValorCompra <= txtvalorcompra.Text And c.ValorCompra >= txtvalorcompra.Text Then

                    GrillaProductos.Rows.Add(c.CodiProveedor, c.CodigoProducto, c.NombreProducto, c.FechaVencimiento, c.ValorCompra, c.ValorVenta)

                End If
            Next
        End If
        


    End Sub

    Sub valida()

        If txtvalorcompra.Text = "" Then
            GrillaProductos.Rows.Clear()
        Else
            cargar()

        End If

    End Sub
    Sub actualizarlista()
        lista = gc.listado

    End Sub
    Private Sub txtvalorcompra_TextChanged(sender As Object, e As EventArgs) Handles txtvalorcompra.TextChanged
        actualizarlista()

        valida()

    End Sub

    Private Sub ProductosPorValorCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class