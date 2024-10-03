Public Class Main_Form
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Menu.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim clientsF As New ClientsForm()
        clientsF.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim property_type As New PropertyTypeForm
        property_type.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Center the panel in the form
        Panel_Menu.Location = New Point(ClientSize.Width / 3 - ClientSize.Width / 4)

        'Make the panel right/left full height
        PanelLeft.Size = New Size(PanelLeft.Width, ClientSize.Height)
        PanelRight.Size = New Size(PanelRight.Width, ClientSize.Height)
        PanelRight.Location = New Point(ClientSize.Width - 5, 0)

        'Button close (upper right)
        ButtonClose.Location = New Point(ClientSize.Width - (PanelRight.Width + ButtonClose.Width + 10), 10)

    End Sub

    Private Sub Panel_1_Paint(sender As Object, e As PaintEventArgs) Handles Panel_1.Paint

    End Sub


    Private Sub Button_Owner_Click(sender As Object, e As EventArgs) Handles Button_Owner.Click
        Dim ownersf As New OwnersForm()
        ownersf.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim propertyF As New PropertyForm()
        propertyF.Show()
    End Sub
End Class