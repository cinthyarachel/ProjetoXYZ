Imports System.Data.SqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            Using cn = New SqlConnection(strCon)
                cn.Open()

                FmAdicionarRegistro.ShowDialog()


            End Using
        Catch ex As Exception

        End Try
    End Sub
End Class
