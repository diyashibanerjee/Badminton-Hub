Imports System.Data.SqlClient
Imports System.IO

Public Class ProfileForm
    Private loggedInUsername As String
    Private connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=BadmintonHub;Integrated Security=True"
    Private selectedProfilePicPath As String = ""

    ' Default constructor (required for Designer)
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Constructor to receive username
    Public Sub New(username As String)
        InitializeComponent()
        loggedInUsername = username
    End Sub

    ' Load user data on form load
    Private Sub ProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = "Logged in as: " & loggedInUsername

        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT Email, ProfilePicture FROM Users WHERE Username = @username"

            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", loggedInUsername)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtEmail.Text = reader("Email").ToString()

                            Dim picPath As String = reader("ProfilePicture").ToString()
                            If Not String.IsNullOrEmpty(picPath) AndAlso File.Exists(picPath) Then
                                picProfile.Image = Image.FromFile(picPath)
                            End If
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading profile: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Browse button for profile pic
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnUploadPic.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            selectedProfilePicPath = openFileDialog.FileName
            picProfile.Image = Image.FromFile(selectedProfilePicPath)
        End If
    End Sub

    ' Update profile info
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim email As String = txtEmail.Text.Trim()
        Dim oldPassword As String = txtOldPassword.Text.Trim()
        Dim newPassword As String = txtNewPassword.Text.Trim()

        If email = "" Or oldPassword = "" Or newPassword = "" Then
            MessageBox.Show("All fields are required!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Dim checkQuery As String = "SELECT Password FROM Users WHERE Username = @username"
            Dim updateQuery As String = "UPDATE Users SET Password = @password, Email = @email, ProfilePicture = @pic WHERE Username = @username"

            Try
                conn.Open()

                ' Verify old password
                Dim currentPassword As String = ""
                Using checkCmd As New SqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@username", loggedInUsername)
                    currentPassword = Convert.ToString(checkCmd.ExecuteScalar())
                End Using

                If oldPassword <> currentPassword Then
                    MessageBox.Show("Old password is incorrect!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                If oldPassword = newPassword Then
                    MessageBox.Show("New password must be different from the old one!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Update details
                Using updateCmd As New SqlCommand(updateQuery, conn)
                    updateCmd.Parameters.AddWithValue("@username", loggedInUsername)
                    updateCmd.Parameters.AddWithValue("@password", newPassword)
                    updateCmd.Parameters.AddWithValue("@email", email)
                    updateCmd.Parameters.AddWithValue("@pic", selectedProfilePicPath)
                    updateCmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Update failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Back to Home button
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBackToHome.Click
        Dim home As New homeform(loggedInUsername)
        home.Show()
        Me.Close()
    End Sub
End Class



