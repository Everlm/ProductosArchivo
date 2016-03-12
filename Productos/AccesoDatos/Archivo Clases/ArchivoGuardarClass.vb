Imports System.IO
Imports System.IO.StreamReader
Imports System.IO.StreamWriter
Public Class ArchivoGuardarClass

    Protected rut As String

    Public ReadOnly Property ruta() As String
        Get
            Return rut
        End Get
    End Property

    Sub New(ruta As String)
        rut = ruta
    End Sub

   Public Function guardar(linea As String) As Integer
        Try
            Dim sw As New StreamWriter(rut, True)
            sw.WriteLine(linea)
            sw.Close()
            Return 0
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function leer() As ArrayList
        Try
            Dim sr As New StreamReader(rut)
            Dim arreglo As New ArrayList
            Do While Not sr.EndOfStream
                arreglo.Add(sr.ReadLine)
            Loop
            sr.Close()
            Return arreglo
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
   



End Class
