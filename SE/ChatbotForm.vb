Public Class ChatbotForm

    Private loggedInUser As String

    ' Constructor: accept username when creating the form
    Public Sub New(username As String)
        InitializeComponent()
        loggedInUser = username
    End Sub

    ' Dictionary of predefined Q&A
    Private qaDictionary As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase) From {
        {"what is badminton?", "Badminton is a racket sport played with a shuttlecock across a net."},
        {"how many players in badminton?", "Badminton can be played as singles (1 vs 1) or doubles (2 vs 2)."},
        {"how do you score in badminton?", "You score by winning rallies, each rally won gives you 1 point."},
        {"what is a shuttlecock?", "A shuttlecock is a feathered projectile hit back and forth in badminton."},
        {"what are the basic rules of badminton?", "Basic rules: serve diagonally, shuttle must pass over net, game played to 21 points."},
        {"how long is a badminton match?", "A badminton match is usually best of 3 games, each game to 21 points."},
        {"what equipment do i need?", "You need a racket, shuttlecock, net, and proper sportswear to play badminton."},
        {"can i play badminton indoors?", "Yes! Badminton is commonly played indoors to avoid wind interference."},
        {"who is the best badminton player?", "Some of the best are Lin Dan, Lee Chong Wei, and PV Sindhu."},
        {"how do i improve my badminton skills?", "Practice footwork, improve racket control, and play regularly against better opponents."},
         {"badminton", "Badminton is a racket sport played with a shuttlecock across a net."},
        {"players", "Badminton can be played as singles (1 vs 1) or doubles (2 vs 2)."},
        {"score", "You score by winning rallies, each rally won gives you 1 point."},
        {"shuttle", "A shuttlecock is a feathered projectile hit back and forth in badminton."},
        {"rules", "Basic rules: serve diagonally, shuttle must pass over net, game played to 21 points."},
        {"match", "A badminton match is usually best of 3 games, each game to 21 points."},
        {"equipment", "You need a racket, shuttlecock, net, and proper sportswear to play badminton."},
        {"indoor", "Yes! Badminton is commonly played indoors to avoid wind interference."},
        {"best player", "Some of the best are Lin Dan, Lee Chong Wei, and PV Sindhu."},
        {"skills", "Practice footwork, improve racket control, and play regularly against better opponents."},
        {"smash", "A smash is a powerful attacking shot aimed sharply downward."},
        {"grip", "There are two main grips: forehand and backhand. Hold your racket comfortably!"}
    }

    Private Sub ChatbotForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtbChatHistory.ReadOnly = True
        rtbChatHistory.AppendText("Badminton Bot: Hi " & loggedInUser & "! Ask me anything about badminton." & Environment.NewLine)
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim userQuestion As String = txtUserInput.Text.Trim()

        If String.IsNullOrEmpty(userQuestion) Then
            MessageBox.Show("Type your question first!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        rtbChatHistory.AppendText("You: " & userQuestion & Environment.NewLine)

        Dim answer As String = Nothing
        If qaDictionary.TryGetValue(userQuestion, answer) Then
            rtbChatHistory.AppendText("Badminton Bot: " & answer & Environment.NewLine)
        Else
            rtbChatHistory.AppendText("Badminton Bot: Sorry, I don't know the answer to that. Try another question!" & Environment.NewLine)
        End If

        txtUserInput.Clear()
        rtbChatHistory.SelectionStart = rtbChatHistory.Text.Length
        rtbChatHistory.ScrollToCaret()
    End Sub

    Private Sub txtUserInput_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUserInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnSend.PerformClick()
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim home As New HomeForm(loggedInUser)
        home.Show()
        Me.Close()
    End Sub

End Class
