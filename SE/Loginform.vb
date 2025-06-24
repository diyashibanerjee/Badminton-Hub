Imports System.Data.SqlClient

Public Class LoginForm
    Dim connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=BadmintonHub;Integrated Security=True"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' 🚨 Special Check: Is this the Admin?
        If username = "admin" And password = "admin123" Then
            Dim adminForm As New Adminform()
            adminForm.Show()
            Me.Hide()
            Exit Sub
        End If

        ' 💼 Regular User Login
        Using conn As New SqlConnection(connectionString)
            conn.Open()

            Dim query As String = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count = 1 Then
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim homeForm As New HomeForm(username) ' assuming HomeForm accepts username
                homeForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
    End Sub
End Class

