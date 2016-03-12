Imports Entidades
Imports System.IO
Imports AccesoDatos
Public Class GestionProveedorClass

    Public archProveedor As New ArchivoLeerClass(Application.StartupPath & "\Proveedor.text")
    Public AuxiProve As New ArchivoLeerClass(Application.StartupPath & "\AuxPoveedor.text")

    Function listado() As List(Of ProveedorClass)
        Dim lista As New List(Of ProveedorClass)
        lista = archProveedor.leerProve
        Return lista
    End Function
    Function guardar(c As ProveedorClass) As Integer
        Return archProveedor.guardar(c.lineaDatos)
    End Function
    Public Function buscarID(ced As String) As ProveedorClass
        Dim lista As List(Of ProveedorClass) = archProveedor.leerProve
        For Each c As ProveedorClass In lista
            If c.CodigoProveedor = ced Then
                Return c
            End If
        Next
        Return Nothing
    End Function
    Public Function buscarPosicion(ced As String) As Integer
        Dim lista As List(Of ProveedorClass) = archProveedor.leerProve
        Dim i As Integer
        For Each c As ProveedorClass In lista
            If c.CodigoProveedor = ced Then
                Return i
            End If
            i += 1
        Next
        Return -1
    End Function

    Public Function Modificar(l As List(Of ProveedorClass)) As Boolean
        Try
            Dim sw As New StreamWriter(archProveedor.ruta, False)
            For Each c As ProveedorClass In l
                sw.WriteLine(c.lineaDatos)
            Next
            sw.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function eliminar(ced As Long) As Boolean
        Dim r1, r2 As String
        r1 = archProveedor.ruta
        r2 = AuxiProve.ruta

        Using sr As New StreamReader(r1)
            Using sw As New StreamWriter(r2)

                Dim linea As String

                Do While Not sr.EndOfStream
                    linea = sr.ReadLine
                    If Split(linea, ";")(0) <> ced Then
                        sw.WriteLine(linea)
                    End If
                Loop
            End Using
        End Using
        File.Delete(r1)
        File.Move(r2, r1)
        Return True
    End Function
    

End Class
