Imports System.Data.SqlClient

Public Class AdminForm
    Private connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=BadmintonHub;Integrated Security=True"

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBookings()
        LoadSlots()
    End Sub

    ' 🔄 LOAD ALL USER BOOKINGS
    Private Sub LoadBookings()
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "
                SELECT 
                    b.BookingID,
                    b.Username,
                    c.CourtName + ' (' + c.Location + ')' AS Court,
                    s.SlotTime,
                    b.BookingDate
                FROM SlotBookings b
                INNER JOIN Courts c ON b.CourtID = c.CourtID
                INNER JOIN Slots s ON b.SlotID = s.SlotID
                ORDER BY b.BookingDate DESC, s.SlotTime"
            Dim cmd As New SqlCommand(query, conn)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvCourt.DataSource = dt

            dgvCourt.AutoResizeColumns()
        End Using
    End Sub

    ' 🔄 LOAD SLOT TIMINGS FOR EDITING
    Private Sub LoadSlots()
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT SlotID, SlotTime FROM Slots ORDER BY SlotID"
            Dim cmd As New SqlCommand(query, conn)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvSlots.DataSource = dt

            dgvSlots.AutoResizeColumns()
        End Using
    End Sub

    ' ✅ UPDATE SLOT TIME
    Private Sub btnUpdateSlot_Click(sender As Object, e As EventArgs)
        If dgvSlots.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a slot to update!", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim slotID As Integer = CInt(dgvSlots.SelectedRows(0).Cells("SlotID").Value)
        Dim newTime As String = InputBox("Enter new time for the slot (e.g., 08:00 AM):", "Update Slot Time")

        If String.IsNullOrWhiteSpace(newTime) Then
            MessageBox.Show("No time entered. Update cancelled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim updateCmd As New SqlCommand("UPDATE Slots SET SlotTime = @SlotTime WHERE SlotID = @SlotID", conn)
            updateCmd.Parameters.AddWithValue("@SlotTime", newTime)
            updateCmd.Parameters.AddWithValue("@SlotID", slotID)
            updateCmd.ExecuteNonQuery()
        End Using

        MessageBox.Show("Slot time updated!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadSlots()
    End Sub

    ' ➕ ADD NEW COURT
    Private Sub btnAddCourt_Click(sender As Object, e As EventArgs) Handles btnAddCourt.Click
        Dim courtName As String = InputBox("Enter court name:", "Add Court")
        Dim location As String = InputBox("Enter court location:", "Add Court")

        If String.IsNullOrWhiteSpace(courtName) Or String.IsNullOrWhiteSpace(location) Then
            MessageBox.Show("Court name and location cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim insertCmd As New SqlCommand("INSERT INTO Courts (CourtName, Location) VALUES (@name, @location)", conn)
            insertCmd.Parameters.AddWithValue("@name", courtName)
            insertCmd.Parameters.AddWithValue("@location", location)
            insertCmd.ExecuteNonQuery()
        End Using

        MessageBox.Show("Court added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' 🏠 BACK TO LOGIN OR HOME
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim login As New LoginForm()
        login.Show()
        Me.Close()
    End Sub

End Class



