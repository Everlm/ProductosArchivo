Imports Entidades
Imports Controles
Public Class Productos

    Public listapro As List(Of ProductosClass)
    Private gp As New GestionProductosClass
    Private listaprove As List(Of ProveedorClass)
    Private gc As New GestionProveedorClass

    Sub guardar()
        Dim c As New ProductosClass
        c.CodiProveedor = txtcodigoprove.Text
        c.CodigoProducto  = txtcodigoproducto.Text
        c.NombreProducto = txtnombrepro.Text
        c.FechaVencimiento = FormatDateTime(txtfechavenci.Value, DateFormat.ShortDate)
        c.ValorCompra = txtvalorcompra.Text
        c.ValorVenta = txtvalprventa.Text
        Select Case gp.guardar(c)
            Case 0
                MsgBox("Producto Guardado", MsgBoxStyle.Information)
                actualizarlista()
                cargar()
            Case -1
                MsgBox("Error al guardar Producto", MsgBoxStyle.Critical)
        End Select

    End Sub
   
    Sub actualizarlista()
        listapro = gp.listado
        listaprove = gc.listado
    End Sub
    Sub cargar()
        GrillaProductos.Rows.Clear()
        If listapro Is Nothing Then
        Else
            For Each c As ProductosClass In listapro
                GrillaProductos.Rows.Add(c.CodiProveedor, c.CodigoProducto, c.NombreProducto, c.FechaVencimiento, c.ValorCompra, c.ValorVenta)
            Next
        End If

    End Sub
    Sub buscar()
        Dim p As ProductosClass
        p = gp.buscarID(txtcodigoproducto.Text)
        ver(p)
    End Sub
    Sub Ver(ByVal So As ProductosClass)

        txtcodigoprove.Text = So.CodiProveedor
        txtcodigoproducto.Text = So.CodigoProducto
        txtfechavenci.Text = So.FechaVencimiento
        txtnombrepro.Text = So.NombreProducto
        txtvalorcompra.Text = So.ValorCompra
        txtvalprventa.Text = So.ValorVenta


    End Sub

    Sub modificar()
        Dim pos As Integer = gp.buscarPosicion(txtcodigoproducto.Text)

        listapro(pos).NombreProducto = txtnombrepro.Text
        listapro(pos).FechaVencimiento = txtfechavenci.Value
        listapro(pos).ValorCompra = txtvalorcompra.Text
        listapro(pos).ValorVenta = txtvalprventa.Text


        If gp.Modificar(listapro) Then
            MsgBox("Modificado", MsgBoxStyle.Information)
            actualizarlista()
            cargar()
        Else
            MsgBox("Error al modificar", MsgBoxStyle.Critical)
        End If
    End Sub
    Sub nuevo()
        txtcodigoproducto.Clear()
        txtcodigoprove.SelectedIndex = -1
        txtfechavenci.ResetText()
        txtnombrepro.Clear()
        txtvalorcompra.Clear()
        txtvalprventa.Clear()
    End Sub

    Sub cargarcodigo()
        txtcodigoprove.Items.Clear()
        If listaprove Is Nothing Then
        Else

            For Each c As ProveedorClass In listaprove
                txtcodigoprove.Items.Add(c.CodigoProveedor)
            Next
        End If

    End Sub


    Sub mostrarnombreproveedor()

        If txtcodigoprove.Text = "" Then
            Labelnombre.Visible = False
        Else


            For Each s As ProveedorClass In listaprove
                If s.CodigoProveedor = txtcodigoprove.Text Then

                    Ver(s)
                End If
            Next

            Labelnombre.Visible = True
        End If

    End Sub
    Sub ver(ByVal cod As ProveedorClass)
        Labelnombre.Text = cod.NombreProveedor
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

    Private Sub txtcodigoprove_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtcodigoprove.SelectedIndexChanged


        mostrarnombreproveedor()

    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        actualizarlista()
        cargarcodigo()
        cargar()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProductosRegistrados.ShowDialog()

    End Sub

    Private Sub txtvalorcompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtvalorcompra.KeyPress
        soloNum(e)

    End Sub


    Private Sub txtvalorcompra_TextChanged(sender As Object, e As EventArgs) Handles txtvalorcompra.TextChanged


        Dim a As Decimal = 0.25
        Try
            txtvalprventa.Text = txtvalorcompra.Text * a + txtvalorcompra.Text
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        nuevo()

    End Sub

    Private Sub txtcodigoproducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigoproducto.KeyPress
        soloNum(e)

    End Sub

    Private Sub txtnombrepro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombrepro.KeyPress
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
End Class