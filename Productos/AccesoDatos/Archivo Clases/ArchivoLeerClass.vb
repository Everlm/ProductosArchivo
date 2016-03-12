
Imports System.IO.StreamWriter
Imports System.IO.StreamReader
Imports Entidades
Imports System.IO

Public Class ArchivoLeerClass
    Inherits ArchivoGuardarClass


    Sub New(ruta As String)
        MyBase.New(ruta)
    End Sub

    Public Overloads Function leerProve() As List(Of ProveedorClass)
        Try
            Dim sr As New StreamReader(rut)
            Dim arreglo As New List(Of ProveedorClass)
            Do While Not sr.EndOfStream
                Dim c As New ProveedorClass(sr.ReadLine)
                arreglo.Add(c)
            Loop
            sr.Close()
            Return arreglo
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Overloads Function leerProdu() As List(Of ProductosClass)
        Try
            Dim sr As New StreamReader(rut)
            Dim arreglo As New List(Of ProductosClass)
            Do While Not sr.EndOfStream
                Dim c As New ProductosClass(sr.ReadLine)
                arreglo.Add(c)
            Loop
            sr.Close()
            Return arreglo
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class
