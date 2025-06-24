Imports System.Data.SqlClient

Public Class ShuttleForm

    Private loggedInUsername As String
    Private connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=BadmintonHub;Integrated Security=True"

    ' Constructor receives username
    Public Sub New(username As String)
        InitializeComponent()
        loggedInUsername = username
    End Sub

    ' Sample ItemIDs for 6 shuttle options
    Private shuttleItemIDs As Integer() = {101, 102, 103, 104, 105, 106}

    Private Sub ShuttleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tag Buy buttons with ItemID
        btnBuy1.Tag = shuttleItemIDs(0)
        btnBuy2.Tag = shuttleItemIDs(1)
        btnBuy3.Tag = shuttleItemIDs(2)
        btnBuy4.Tag = shuttleItemIDs(3)
        btnBuy5.Tag = shuttleItemIDs(4)
        btnBuy6.Tag = shuttleItemIDs(5)
    End Sub

    ' All Buy buttons handled here
    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy1.Click, btnBuy2.Click, btnBuy3.Click, btnBuy4.Click, btnBuy5.Click, btnBuy6.Click
        Dim btn As Button = CType(sender, Button)
        Dim selectedItemId As Integer = CInt(btn.Tag)

        ' Insert into Equipment table
        Dim insertQuery As String = "INSERT INTO Equipment (Username, ItemID, Quantity) VALUES (@Username, @ItemID, @Quantity)"

        Try
            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(insertQuery, con)
                    cmd.Parameters.AddWithValue("@Username", loggedInUsername)
                    cmd.Parameters.AddWithValue("@ItemID", selectedItemId)
                    cmd.Parameters.AddWithValue("@Quantity", 1) ' Fixed quantity

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Open PaymentForm with both required arguments
            Dim payForm As New PaymentForm(loggedInUsername, selectedItemId)
            payForm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Error placing order: " & ex.Message)
        End Try
    End Sub

End Class