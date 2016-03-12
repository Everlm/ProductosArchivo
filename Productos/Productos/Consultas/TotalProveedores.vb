Imports Controles
Imports Entidades
Public Class TotalProveedores

    Private gp As New GestionProveedorClass

    Private lista As List(Of ProveedorClass)
    Sub cargar()

        GrillaProveedor.Rows.Clear()
        If lista Is Nothing Then
        Else
            For Each pro As ProveedorClass In lista



                GrillaProveedor.Rows.Add(pro.CodigoProveedor, pro.NombreProveedor)


            Next
        End If
       


    End Sub
    Sub actualizarlista()
        lista = gp.listado
    End Sub
    Private Sub TotalProveedoresForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarlista()

        cargar()

    End Sub
End Class