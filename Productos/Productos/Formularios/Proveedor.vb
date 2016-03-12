Imports Entidades
Imports Controles
Public Class Proveedor
    Private lista As List(Of ProveedorClass)
    Private gp As New GestionProveedorClass

    Sub guardar()
        Dim c As New ProveedorClass
        c.CodigoProveedor = txtcodigo.Text
        c.NombreProveedor = txtnombre.Text

        Select Case gp.guardar(c)
            Case 0
                MsgBox("Proveedor Guardado", MsgBoxStyle.Information)
                actualizarlista()
                cargar()
            Case -1
                MsgBox("Error al guardar Proveedor", MsgBoxStyle.Critical)
        End Select

    End Sub

    Sub actualizarlista()
        lista = gp.listado
    End Sub
    Sub cargar()
        GrillaProveedor.Rows.Clear()
        For Each c As ProveedorClass In lista
            GrillaProveedor.Rows.Add(c.CodigoProveedor, c.NombreProveedor)
        Next
    End Sub
    Sub buscar()
        Dim p As ProveedorClass
        p = gp.buscarID(txtcodigo.Text)
        ver(p)
    End Sub
    Sub ver(p As ProveedorClass)
        txtcodigo.Text = p.CodigoProveedor
        txtnombre.Text = p.NombreProveedor
       
    End Sub
    Sub modificar()
        Dim pos As Integer = gp.buscarPosicion(txtcodigo.Text)

        lista(pos).NombreProveedor = txtnombre.Text
       
        If gp.Modificar(lista) Then
            MsgBox("Modificado", MsgBoxStyle.Information)
            actualizarlista()
            cargar()
        Else
            MsgBox("Error al modificar", MsgBoxStyle.Critical)
        End If
    End Sub

   
    Sub nuevo()
        txtcodigo.Clear()
        txtnombre.Clear()
    End Sub


    Sub soloNum(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'solo numeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Sub soloLetras(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'solo letras
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub




   

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()

    End Sub

    Private Sub Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarlista()
        cargar()

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        nuevo()

    End Sub

    Private Sub txtcodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigo.KeyPress
        soloNum(e)

    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        soloLetras(e)

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        guardar()
        nuevo()

    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        buscar()

    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        modificar()

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        'Public ListadoMovimientos As New GestionProductosClass
        'Dim p As Long
        'p = ListadoMovimientos.
    End Sub
End Class