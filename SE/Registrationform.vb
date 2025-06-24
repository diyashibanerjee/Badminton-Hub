Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class RegistrationForm
    Private connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=BadmintonHub;Integrated Security=True"

    Public Sub New()
        InitializeComponent()
        txtPassword.PasswordChar = "*"c  ' 👈 Password will now show as ***
    End Sub


    ' REGISTER Button
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim fullName As String = txtFullname.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim phone As String = txtPhoneNumber.Text.Trim()

        If username = "" Or password = "" Or fullName = "" Or email = "" Or phone = "" Then
            MessageBox.Show("Please fill in all fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not Regex.IsMatch(phone, "^\d{10}$") Then
            MessageBox.Show("Phone number must be exactly 10 digits.", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using conn As New SqlConnection(connectionString)
            Dim checkQuery As String = "SELECT COUNT(*) FROM Users WHERE Username=@username"
            Dim insertQuery As String = "INSERT INTO Users (Username, Password, FullName, Email, PhoneNumber) VALUES (@username, @password, @fullname, @email, @phone)"

            Try
                conn.Open()

                ' Check if user already exists
                Using checkCmd As New SqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@username", username)
                    Dim userExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If userExists > 0 Then
                        MessageBox.Show("Username already registered. Please login.", "User Exists", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoginForm.Show()  ' Show the Login Form
                        Me.Hide()  ' Hide the Registration Form
                        Exit Sub
                    End If
                End Using

                ' Insert new user into the Users table
                Using insertCmd As New SqlCommand(insertQuery, conn)
                    insertCmd.Parameters.AddWithValue("@username", username)
                    insertCmd.Parameters.AddWithValue("@password", password)
                    insertCmd.Parameters.AddWithValue("@fullname", fullName)
                    insertCmd.Parameters.AddWithValue("@email", email)
                    insertCmd.Parameters.AddWithValue("@phone", phone)
                    insertCmd.ExecuteNonQuery()
                End Using

                ' Show a success message and navigate to the Login Form
                MessageBox.Show("Registered successfully! Please login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoginForm.Show()  ' Show the Login Form
                Me.Hide()  ' Hide the Registration Form

            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' LOGIN Button - Navigate to Login Form
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnGoToLogin.Click
        ' Show the Login Form and hide the RegistrationForm
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
