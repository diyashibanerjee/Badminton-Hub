Public Class EquipmentTypeForm
    Private loggedInUsername As String

    ' Constructor to receive username from HomeForm
    Public Sub New(username As String)
        InitializeComponent()
        loggedInUsername = username
    End Sub

    ' When Raquet button clicked
    Private Sub btnRaquet_Click(sender As Object, e As EventArgs) Handles btnRaquet.Click
        Dim raquetForm As New RaquetForm(loggedInUsername)
        raquetForm.Show()
        Me.Hide()
    End Sub

    ' When Shuttle button clicked
    Private Sub btnShuttle_Click(sender As Object, e As EventArgs) Handles btnShuttle.Click
        Dim shuttleForm As New ShuttleForm(loggedInUsername)
        shuttleForm.Show()
        Me.Hide()
    End Sub

    ' BACK Button to return to HomeForm
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim homeForm As New HomeForm(loggedInUsername)
        homeForm.Show()
        Me.Close()
    End Sub

    Private Sub EquipmentTypeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
