Public Class OwnersForm
    Dim func As New MYFUNCTION()
    Dim tableName As String = "prop_owner"

    Private Sub OwnersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOwners()
    End Sub

    Private Sub LoadOwners()
        Dim selectOwnersQuery As String = "SELECT * FROM prop_owner"
        DataGridViewOWNERS.DataSource = func.getData(selectOwnersQuery)

        'remove selection from the datagrid
        DataGridViewOWNERS.ClearSelection()
    End Sub

    Private Sub ButtonADD_Click(sender As Object, e As EventArgs) Handles ButtonADD.Click
        Dim fname As String = TextBoxfNAME.Text
        Dim lname As String = TextBoxlNAME.Text
        Dim phone As String = TextBoxPHONE.Text
        Dim email As String = TextBoxMAIL.Text
        Dim address As String = TextBoxADDRESS.Text

        Try
            'check empty fields
            If fname.Trim().Equals("") Or lname.Trim().Equals("") Or phone.Trim().Equals("") Or address.Trim().Equals("") Then
                MessageBox.Show("One or More Fields are Empty.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)



            ElseIf (New Owners_and_Client().insertPerson(tableName, fname, lname, phone, email, address)) Then
                MessageBox.Show("The owner has been successfully added.", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LoadOwners() ' Reload the DataGridView
                'clear fields after adding
                ButtonCLEAR_FIELDS.PerformClick()
            Else
                MessageBox.Show("Owner not Added", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        ClearFields()
    End Sub

    Private Sub ClearFields()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    ' DataGridView click event
    Private Sub DataGridViewOWNERS_Click(sender As Object, e As EventArgs) Handles DataGridViewOWNERS.Click
        ' Display the selected owner from DataGridView to textboxes
        TextBoxID.Text = DataGridViewOWNERS.CurrentRow.Cells(0).Value.ToString()
        TextBoxfNAME.Text = DataGridViewOWNERS.CurrentRow.Cells(1).Value.ToString()
        TextBoxlNAME.Text = DataGridViewOWNERS.CurrentRow.Cells(2).Value.ToString()
        TextBoxPHONE.Text = DataGridViewOWNERS.CurrentRow.Cells(3).Value.ToString()
        TextBoxMAIL.Text = DataGridViewOWNERS.CurrentRow.Cells(4).Value.ToString()
        TextBoxADDRESS.Text = DataGridViewOWNERS.CurrentRow.Cells(5).Value.ToString()
    End Sub

    ' Button to delete
    ' Button to delete
    Private Sub ButtonREMOVE_Click(sender As Object, e As EventArgs) Handles ButtonREMOVE.Click
        Try
            ' Get the owner ID
            Dim ownerID As Integer = Convert.ToInt32(TextBoxID.Text)

            ' Show confirmation message before deleting
            If MessageBox.Show("Are you sure you want to delete this Owner?", "Delete Owner", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If New Owners_and_Client().deletePerson(tableName, ownerID) Then
                    MessageBox.Show("The owner has been successfully deleted.", "Delete Owner", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadOwners() ' Reload the DataGridView to reflect changes

                    'clear fields after deleting
                    ButtonCLEAR_FIELDS.PerformClick()
                Else
                    MessageBox.Show("Owner could not be deleted.", "Delete Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch
            MessageBox.Show("Select the owner you want to remove.", "Missing Owner", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub ButtonCLEAR_FIELDS_Click(sender As Object, e As EventArgs) Handles ButtonCLEAR_FIELDS.Click
        TextBoxID.Text = ""
        TextBoxfNAME.Text = ""
        TextBoxlNAME.Text = ""
        TextBoxPHONE.Text = ""
        TextBoxMAIL.Text = ""
        TextBoxADDRESS.Text = ""
    End Sub


    Private Sub ButtonEDIT_Click(sender As Object, e As EventArgs) Handles ButtonEDIT.Click
        Dim ownerID As Integer
        If Integer.TryParse(TextBoxID.Text, ownerID) Then
            Dim fname As String = TextBoxfNAME.Text
            Dim lname As String = TextBoxlNAME.Text
            Dim phone As String = TextBoxPHONE.Text
            Dim email As String = TextBoxMAIL.Text
            Dim address As String = TextBoxADDRESS.Text

            Try
                ' Check for empty fields
                If String.IsNullOrWhiteSpace(fname) Or String.IsNullOrWhiteSpace(lname) Or
               String.IsNullOrWhiteSpace(phone) Or String.IsNullOrWhiteSpace(address) Then
                    MessageBox.Show("One or More Fields are Empty.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf New Owners_and_Client().editPerson(tableName, ownerID, fname, lname, phone, email, address) Then
                    MessageBox.Show("The owner has been successfully updated.", "Edit Owner", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadOwners() ' Reload the DataGridView to reflect changes
                    'clear fields after editing
                    ButtonCLEAR_FIELDS.PerformClick()
                Else
                    MessageBox.Show("Owner data has not been updated.", "Edit Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Edit Owner Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Please select a valid owner to edit.", "Invalid Owner ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
