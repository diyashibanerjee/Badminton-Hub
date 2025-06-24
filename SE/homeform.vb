Public Class HomeForm
    Private loggedInUsername As String

    ' Constructor receives username
    Public Sub New(username As String)
        InitializeComponent()
        loggedInUsername = username
    End Sub

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcone.Text = "Welcome, " & loggedInUsername & "!"
    End Sub

    ' Profile Button
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Dim profileForm As New ProfileForm(loggedInUsername)
        profileForm.Show()
        Me.Hide()
    End Sub

    'Chatbot Button — FIXED here by passing username!
    Private Sub btnChatbot_Click(sender As Object, e As EventArgs) Handles btnChatBot.Click
        Dim chatbotForm As New ChatbotForm(loggedInUsername)
        chatbotForm.Show()
        Me.Hide()
    End Sub


    ' Equipment Store Button
    Private Sub btnStore_Click(sender As Object, e As EventArgs) Handles btnStore.Click
        Dim typeForm As New EquipmentTypeForm(loggedInUsername) ' <-- pass the username here!
        typeForm.Show()
        Me.Hide()
    End Sub
    ' Slot Booking Button — FIXED 🔥
    Private Sub btnBookSlot_Click(sender As Object, e As EventArgs) Handles btnBookSlot.Click
        Dim slotForm As New SlotBookingForm(loggedInUsername)
        slotForm.Show()
        Me.Hide()
    End Sub

    ' Logout Button
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Close()
    End Sub
End Class

