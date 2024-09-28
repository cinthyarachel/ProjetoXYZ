Imports System.Data.SqlClient
Imports System.Drawing.Text

Public Class FmAdicionarRegistro
    Private Sub FmAdicionarRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btSalvarRegistro_Click(sender As Object, e As EventArgs) Handles btSalvarRegistro.Click
        SalvarRegistro()
    End Sub

    Private Sub SalvarRegistro()

        Try
            Using cn = New SqlConnection(strCon)
                cn.Open()
                Dim sql = "
                            INSERT INTO tb_transacoes
	                            (Numero_Cartao,
	                            Valor_Transacao,
	                            Data_Transacao,
	                            Descricao)
                            VALUES
                            ('253698563214',
                            'R$ 50,00',
                            '27''/09''/2024'',
                            ''teste')"
                Using cmd = New SqlCommand(sql, cn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As Exception

        End Try
    End Sub
End Class