Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class Form1
    Private Sub btnMysql_Click(sender As Object, e As EventArgs) Handles btnMysql.Click

        Try
            conn = New MySqlConnection(connectionString)
            conn.Open()

            If conn.State = ConnectionState.Open Then
                MessageBox.Show("Connection Success!")
                Form2.Show()
                Me.Hide()
            Else
                MessageBox.Show("Connection Error!")
            End If

        Catch ex As Exception
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            MSconnection = New SqlConnection(MSconnectionString)
            MSconnection.Open()

            If MSconnection.State = ConnectionState.Open Then
                MessageBox.Show("Connection Success!")
                Form2.Show()
                Me.Hide()
            Else
                MessageBox.Show("Connection Error!")
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error:" & ex.Message)

        Finally
            MSconnection.Dispose()
        End Try
    End Sub
End Class
