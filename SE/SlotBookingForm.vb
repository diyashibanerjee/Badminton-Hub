Imports System.Data.SqlClient

Public Class SlotBookingForm

    Private loggedInUser As String
    Private connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=BadmintonHub;Integrated Security=True"

    Public Sub New(username As String)
        InitializeComponent()
        loggedInUser = username
    End Sub

    Private Sub SlotBookingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourts()
        LoadSlots()
        dtpDate.MinDate = DateTime.Today
        LoadUserBookings()
    End Sub

    ' COURT COMBO
    Private Sub LoadCourts()
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT CourtID, CourtName + ' (' + Location + ')' AS DisplayName FROM Courts", conn)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            cmbCourt.DataSource = dt
            cmbCourt.DisplayMember = "DisplayName"
            cmbCourt.ValueMember = "CourtID"
        End Using
    End Sub

    ' SLOT COMBO
    Private Sub LoadSlots()
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT SlotID, CAST(SlotTime AS VARCHAR(20)) AS SlotTime FROM Slots", conn)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            cmbSlot.DataSource = dt
            cmbSlot.DisplayMember = "SlotTime"
            cmbSlot.ValueMember = "SlotID"
        End Using
    End Sub

    ' BOOKINGS TABLE
    Private Sub LoadUserBookings()
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT b.BookingID, b.Username, c.CourtName, c.Location, CAST(s.SlotTime AS VARCHAR(20)) AS SlotTime, b.BookingDate " &
                                  "FROM SlotBookings b " &
                                  "INNER JOIN Courts c ON b.CourtID = c.CourtID " &
                                  "INNER JOIN Slots s ON b.SlotID = s.SlotID " &
                                  "WHERE b.Username = @username " &
                                  "ORDER BY b.BookingDate, s.SlotTime"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", loggedInUser)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvBookings.DataSource = dt

            ' Rename Columns
            If dgvBookings.Columns.Contains("BookingID") Then dgvBookings.Columns("BookingID").Visible = False
            If dgvBookings.Columns.Contains("Username") Then dgvBookings.Columns("Username").HeaderText = "User"
            If dgvBookings.Columns.Contains("CourtName") Then dgvBookings.Columns("CourtName").HeaderText = "Court"
            If dgvBookings.Columns.Contains("Location") Then dgvBookings.Columns("Location").HeaderText = "Location"
            If dgvBookings.Columns.Contains("SlotTime") Then dgvBookings.Columns("SlotTime").HeaderText = "Time"
            If dgvBookings.Columns.Contains("BookingDate") Then dgvBookings.Columns("BookingDate").HeaderText = "Date"

            dgvBookings.AutoResizeColumns()
        End Using
    End Sub

    ' BOOK SLOT
    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        If cmbCourt.SelectedIndex = -1 Or cmbSlot.SelectedIndex = -1 Then
            MessageBox.Show("Please select both a court and a slot!", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim courtID As Integer = CInt(cmbCourt.SelectedValue)
        Dim slotID As Integer = CInt(cmbSlot.SelectedValue)
        Dim bookingDate As Date = dtpDate.Value.Date

        If bookingDate < DateTime.Today Then
            MessageBox.Show("Booking for past dates is not allowed!", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            conn.Open()

            ' CHECK if already booked
            Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM SlotBookings WHERE CourtID = @courtID AND SlotID = @slotID AND BookingDate = @bookingDate", conn)
            checkCmd.Parameters.AddWithValue("@courtID", courtID)
            checkCmd.Parameters.AddWithValue("@slotID", slotID)
            checkCmd.Parameters.AddWithValue("@bookingDate", bookingDate)

            Dim exists As Integer = CInt(checkCmd.ExecuteScalar())
            If exists > 0 Then
                MessageBox.Show("Slot already booked! Try another court or time.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' INSERT
            Dim insertCmd As New SqlCommand("INSERT INTO SlotBookings (Username, CourtID, SlotID, BookingDate) VALUES (@username, @courtID, @slotID, @bookingDate)", conn)
            insertCmd.Parameters.AddWithValue("@username", loggedInUser)
            insertCmd.Parameters.AddWithValue("@courtID", courtID)
            insertCmd.Parameters.AddWithValue("@slotID", slotID)
            insertCmd.Parameters.AddWithValue("@bookingDate", bookingDate)
            insertCmd.ExecuteNonQuery()

            MessageBox.Show("Slot booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Using

        LoadUserBookings()
    End Sub

    ' CANCEL SLOT
    Private Sub btnCancelBookings_Click(sender As Object, e As EventArgs) Handles btnCancelBookings.Click
        If dgvBookings.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a booking to cancel.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bookingID As Integer = CInt(dgvBookings.SelectedRows(0).Cells("BookingID").Value)

        If MessageBox.Show("Are you sure you want to cancel?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim deleteCmd As New SqlCommand("DELETE FROM SlotBookings WHERE BookingID = @bookingID AND Username = @username", conn)
                deleteCmd.Parameters.AddWithValue("@bookingID", bookingID)
                deleteCmd.Parameters.AddWithValue("@username", loggedInUser)
                Dim rowsDeleted As Integer = deleteCmd.ExecuteNonQuery()

                If rowsDeleted > 0 Then
                    MessageBox.Show("Booking cancelled!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Couldn’t cancel. It might not belong to you.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
            LoadUserBookings()
        End If
    End Sub

    ' If you wanna go back to Home Form
    Private Sub btnBackToHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim home As New HomeForm(loggedInUser)
        home.Show()
        Me.Close()
    End Sub

    ' Optional Setter
    Public Sub SetLoggedInUser(username As String)
        loggedInUser = username
    End Sub

    Private Sub lblLoggedInUser_Click(sender As Object, e As EventArgs) Handles lblLoggedInUser.Click

    End Sub

    Private Sub lblStatus_Click(sender As Object, e As EventArgs) Handles lblStatus.Click

    End Sub
End Class

