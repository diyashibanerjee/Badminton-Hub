Imports System.Data.SqlClient

Public Class PaymentForm

    Private selectedItemID As Integer
    Private loggedInUsername As String
    Private connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=BadmintonHub;Integrated Security=True"

    ' 🧠 New constructor accepting both username and item ID
    Public Sub New(username As String, itemID As Integer)
        InitializeComponent()
        loggedInUsername = username
        selectedItemID = itemID
    End Sub

    Private paymentMethodSelected As String = ""

    Private Sub btnConfirmPayment_Click(sender As Object, e As EventArgs) Handles btnConfirmPayment.Click
        If rbtnUPI.Checked Then
            paymentMethodSelected = "UPI"
        ElseIf rbtnCard.Checked Then
            paymentMethodSelected = "Card"
        ElseIf rbtnCash.Checked Then
            paymentMethodSelected = "Cash"
        Else
            MessageBox.Show("Please select a payment method.")
            Exit Sub
        End If

        ' INSERT into Purchase table (we include Username now too!)
        Dim insertQuery As String = "INSERT INTO Purchase (Username, ItemID, PaymentMethod) VALUES (@Username, @ItemID, @PaymentMethod)"

        Try
            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(insertQuery, con)
                    cmd.Parameters.AddWithValue("@Username", loggedInUsername)
                    cmd.Parameters.AddWithValue("@ItemID", selectedItemID)
                    cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethodSelected)

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Payment Successful!")
            txtFeedback.Enabled = True
            btnSubmitFeedback.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Error processing payment: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSubmitFeedback_Click(sender As Object, e As EventArgs) Handles btnSubmitFeedback.Click
        Dim feedbackText As String = txtFeedback.Text.Trim()
        If String.IsNullOrEmpty(feedbackText) Then
            MessageBox.Show("Please write some feedback before submitting.")
            Return
        End If

        Dim updateQuery As String = "UPDATE Purchase SET Feedback = @Feedback WHERE PaymentID = (SELECT MAX(PaymentID) FROM Purchase WHERE Username = @Username AND ItemID = @ItemID)"

        Try
            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(updateQuery, con)
                    cmd.Parameters.AddWithValue("@Feedback", feedbackText)
                    cmd.Parameters.AddWithValue("@Username", loggedInUsername)
                    cmd.Parameters.AddWithValue("@ItemID", selectedItemID)

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Thank you for your feedback!")
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error saving feedback: " & ex.Message)
        End Try
    End Sub

    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFeedback.Enabled = False
        btnSubmitFeedback.Enabled = False
    End Sub

End Class
