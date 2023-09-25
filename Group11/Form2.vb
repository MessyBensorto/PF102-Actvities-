Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class Form2
    Private Sub btnMY_Click(sender As Object, e As EventArgs) Handles btnMY.Click
        conn = New MySqlConnection(connectionString)
        Try
            conn.Open()

            Dim query As String = "INSERT INTO names (id, first_name, middle_name, last_name) VALUES (@id, @Fname, @Mname, @Lname) "
            Dim command As New MySqlCommand(query, conn)

            command.Parameters.AddWithValue("@id", txtID.Text)
            command.Parameters.AddWithValue("@Fname", txtfname.Text)
            command.Parameters.AddWithValue("@Mname", txtmname.Text)
            command.Parameters.AddWithValue("@Lname", txtlname.Text)

            command.ExecuteNonQuery()

            MessageBox.Show("Records Inserted Successfully")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnMS_Click(sender As Object, e As EventArgs) Handles btnMS.Click
        Try
            MSconnection = New SqlConnection(MSconnectionString)
            MSconnection.Open()

            Dim query As String = "INSERT INTO names (id, first_name, middle_name, last_name) VALUES (@id, @Fname, @Mname, @Lname)"
            Dim MScommand As New SqlCommand(query, MSconnection)

            MScommand.Parameters.AddWithValue("@id", txtID.Text)
            MScommand.Parameters.AddWithValue("@Fname", txtfname.Text)
            MScommand.Parameters.AddWithValue("@Mname", txtmname.Text)
            MScommand.Parameters.AddWithValue("@Lname", txtlname.Text)

            MScommand.ExecuteNonQuery()

            MessageBox.Show("Records Inserted Successfully")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            MSconnection.Close()
        End Try
    End Sub
End Class