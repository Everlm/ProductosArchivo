Imports Controles
Imports Entidades
Public Class ProveedoresPorNombre
    Private gc As New GestionProveedorClass
    Private lista As List(Of ProveedorClass)
    Sub cargar()

        GrillaProveedor.Rows.Clear()
        If lista Is Nothing Then
        Else
            For Each pro As ProveedorClass In lista

                If pro.NombreProveedor = txtnombreprovee.Text Then

                    GrillaProveedor.Rows.Add(pro.CodigoProveedor, pro.NombreProveedor)

                End If
            Next
        End If
        

    End Sub
   
    Sub valida()

        If txtnombreprovee.Text = "" Then
            GrillaProveedor.Rows.Clear()
        Else
            cargar()

        End If

    End Sub
    Sub actualizarlista()
        lista = gc.listado

    End Sub
    Private Sub txtnombreprovee_TextChanged(sender As Object, e As EventArgs) Handles txtnombreprovee.TextChanged
        actualizarlista()

        valida()

    End Sub

    Private Sub ProveedoresPorNombre_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class