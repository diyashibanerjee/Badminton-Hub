Public Class RaquetForm
    Private loggedInUsername As String

    ' Constructor
    Public Sub New(username As String)
        InitializeComponent()
        loggedInUsername = username
    End Sub

    Private Sub RaquetForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' You can set PictureBox images here or directly from Designer
    End Sub

    ' Example for Buy Button 1
    Private Sub btnBuy9_Click(sender As Object, e As EventArgs) Handles btnBuy9.Click
        Dim itemID As Integer = 7 ' Set ItemID for Raquet 1
        Dim paymentForm As New PaymentForm(loggedInUsername, itemID)
        paymentForm.ShowDialog()
    End Sub

    ' Repeat for each buy button
    Private Sub btnBuy8_Click(sender As Object, e As EventArgs) Handles btnBuy8.Click
        Dim itemID As Integer = 8
        Dim paymentForm As New PaymentForm(loggedInUsername, itemID)
        paymentForm.ShowDialog()
    End Sub

    Private Sub btnBuy7_Click(sender As Object, e As EventArgs) Handles btnBuy7.Click
        Dim itemID As Integer = 9
        Dim paymentForm As New PaymentForm(loggedInUsername, itemID)
        paymentForm.ShowDialog()
    End Sub

    Private Sub btnBuy99_Click(sender As Object, e As EventArgs) Handles btnBuy99.Click
        Dim itemID As Integer = 10
        Dim paymentForm As New PaymentForm(loggedInUsername, itemID)
        paymentForm.ShowDialog()
    End Sub

    Private Sub btnBuy88_Click(sender As Object, e As EventArgs) Handles btnBuy88.Click
        Dim itemID As Integer = 11
        Dim paymentForm As New PaymentForm(loggedInUsername, itemID)
        paymentForm.ShowDialog()
    End Sub

    Private Sub btnBuy77_Click(sender As Object, e As EventArgs) Handles btnBuy77.Click
        Dim itemID As Integer = 12
        Dim paymentForm As New PaymentForm(loggedInUsername, itemID)
        paymentForm.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
