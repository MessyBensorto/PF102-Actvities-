Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class MSSQL_MYSQLINTERECORDS
    Private Sub btnMySql_Click(sender As Object, e As EventArgs) Handles btnMySql.Click
        Myconnection = New MySqlConnection(MYconnectionString)
        Try
            Myconnection.Open()

            Dim query As String = "INSERT INTO tbl_info (Idno,first_name,middle_name,last_name) VALUES (@id,@Fname,@Mname,@Lname)"
            Dim cmd As New MySqlCommand(query, Myconnection)

            cmd.Parameters.AddWithValue("@id", txtID.Text)
            cmd.Parameters.AddWithValue("@Fname", txtFname.Text)
            cmd.Parameters.AddWithValue("@Mname", txtMname.Text)
            cmd.Parameters.AddWithValue("@Lname", txtLname.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Record Insert Sucesss")
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        Finally
            Myconnection.Close()
        End Try
    End Sub

    Private Sub btnMsSql_Click(sender As Object, e As EventArgs) Handles btnMsSql.Click
        MSconnection = New SqlConnection(MSconnectionString)
        Try
            MSconnection.Open()
            Dim query As String = "INSERT INTO tbl_info (Idno,first_name,middle_name,last_name) VALUES (@id,@fname,@mname,@lname)"
            Dim MScommand As New SqlCommand(query, MSconnection)
            MScommand.Parameters.AddWithValue("@Id", txtID.Text)
            MScommand.Parameters.AddWithValue("@Fname", txtFname.Text)
            MScommand.Parameters.AddWithValue("@Mname", txtMname.Text)
            MScommand.Parameters.AddWithValue("@Lname", txtLname.Text)

            MScommand.ExecuteNonQuery()

            MessageBox.Show("Records Inserted Successfully")
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        Finally
            MSconnection.Close()
        End Try
    End Sub
End Class