' Name: Bernard Ograh
' Date: 

Public Class Lab2

    Private Sub DisplayBtn_Click(sender As Object, e As EventArgs) Handles DisplayBtn.Click
        Dim VehicleName

        If AutoRadioButton.Checked Then
            ' When Auto vehicle type radio checked, display picture for Auto
            AutoPictureBox.Visible = True
            TruckPictureBox.Visible = False
            CommercialPictureBox.Visible = False
            VehicleName = "Ford Focus"

            VehicleInfoTextBox.Text = VehicleName
            MultilineTextBox.Text = "Congratulations " & CustomerNameTextBox.Text _
            & "!" & ControlChars.NewLine _
            & "Discount repair parts for your selected " _
            & VehicleName & " are available by contacting us at 800-555-1925"

        ElseIf TruckRadioButton.Checked Then
            ' When Truck vehicle type radio checked, display picture for Truck
            AutoPictureBox.Visible = False
            TruckPictureBox.Visible = True
            CommercialPictureBox.Visible = False
            VehicleName = "TATA Truck"

            VehicleInfoTextBox.Text = VehicleName
            MultilineTextBox.Text = "Congratulations " & CustomerNameTextBox.Text _
            & "!" & ControlChars.NewLine _
            & "Discount repair parts for your selected " _
            & VehicleName & " are available by contacting us at 800-555-1925"

        ElseIf CommercialRadioButton.Checked Then
            ' When Commercial vehicle type radio checked, display picture for Commercial
            AutoPictureBox.Visible = False
            TruckPictureBox.Visible = False
            CommercialPictureBox.Visible = True
            VehicleName = "GMC Commercial Truck"

            VehicleInfoTextBox.Text = VehicleName
            MultilineTextBox.Text = "Congratulations " & CustomerNameTextBox.Text _
            & "!" & ControlChars.NewLine _
            & "Discount repair parts for your selected " _
            & VehicleName & " are available by contacting us at 800-555-1925"

        End If


    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        CustomerNameTextBox.Clear()
        CustomerAddressTextBox.Clear()
        CityTextBox.Clear()
        VehicleInfoTextBox.Clear()
        MultilineTextBox.Clear()
        StateTextBox.Clear()
        ZipCodeMaskedTextBox.Clear()
        AutoRadioButton.Checked = True
        GrayRadioButton.Checked = True
        VisibilityCheckBox.Checked = True

        ' Set focus to the Customer name text box
        CustomerNameTextBox.Focus()


    End Sub

    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        Me.Width = Width - 125
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub VisibilityCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles VisibilityCheckBox.CheckedChanged
        VehicleInfoTextBox.Visible = VisibilityCheckBox.Checked
        MultilineTextBox.Visible = VisibilityCheckBox.Checked

    End Sub

    'Private Sub AutoRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AutoRadioButton.CheckedChanged    

    'End Sub

    'Private Sub TruckRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles TruckRadioButton.CheckedChanged

    'End Sub

    'Private Sub CommercialRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CommercialRadioButton.CheckedChanged

    'End Sub


    Private Sub GrayRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GrayRadioButton.CheckedChanged
        ' Change the form background color to Default when Gray radio selected
        Me.BackColor = DefaultBackColor
        CustomerInformationGroupBox.ForeColor = DefaultForeColor
        VehicleTypeGroupBox.ForeColor = DefaultForeColor
        ColorGroupBox.ForeColor = DefaultForeColor
        VisibilityCheckBox.ForeColor = DefaultForeColor
        CustomerNameLabel.ForeColor = DefaultForeColor
        AddressLabel.ForeColor = DefaultForeColor
        CityLabel.ForeColor = DefaultForeColor
        VehicleInfoLabel.ForeColor = DefaultForeColor
        AutoRadioButton.ForeColor = DefaultForeColor
        CommercialRadioButton.ForeColor = DefaultForeColor
        TruckRadioButton.ForeColor = DefaultForeColor
        GrayRadioButton.ForeColor = DefaultForeColor
        YellowRadioButton.ForeColor = DefaultForeColor
        GreenRadioButton.ForeColor = DefaultForeColor
        BlueRadioButton.ForeColor = DefaultForeColor

    End Sub

    Private Sub YellowRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles YellowRadioButton.CheckedChanged
        ' Change the form background color to yellow when yellow radio selected
        Me.BackColor = Color.Yellow
        CustomerInformationGroupBox.ForeColor = DefaultForeColor
        VehicleTypeGroupBox.ForeColor = DefaultForeColor
        ColorGroupBox.ForeColor = DefaultForeColor
        VisibilityCheckBox.ForeColor = DefaultForeColor
        CustomerNameLabel.ForeColor = DefaultForeColor
        AddressLabel.ForeColor = DefaultForeColor
        CityLabel.ForeColor = DefaultForeColor
        VehicleInfoLabel.ForeColor = DefaultForeColor
        AutoRadioButton.ForeColor = DefaultForeColor
        CommercialRadioButton.ForeColor = DefaultForeColor
        TruckRadioButton.ForeColor = DefaultForeColor
        GrayRadioButton.ForeColor = DefaultForeColor
        YellowRadioButton.ForeColor = DefaultForeColor
        GreenRadioButton.ForeColor = DefaultForeColor
        BlueRadioButton.ForeColor = DefaultForeColor

    End Sub

    Private Sub GreenRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GreenRadioButton.CheckedChanged
        ' This sub procedure changes the background color of the form to Green when the
        ' Green radio button is selected and changes the text colors
        ' to white to be visible on the Gree background
        Me.BackColor = Color.Green
        CustomerInformationGroupBox.ForeColor = Color.White
        VehicleTypeGroupBox.ForeColor = Color.White
        ColorGroupBox.ForeColor = Color.White
        VisibilityCheckBox.ForeColor = Color.White
        CustomerNameLabel.ForeColor = Color.White
        AddressLabel.ForeColor = Color.White
        CityLabel.ForeColor = Color.White
        VehicleInfoLabel.ForeColor = Color.White
        AutoRadioButton.ForeColor = Color.White
        CommercialRadioButton.ForeColor = Color.White
        TruckRadioButton.ForeColor = Color.White
        GrayRadioButton.ForeColor = Color.White
        YellowRadioButton.ForeColor = Color.White
        GreenRadioButton.ForeColor = Color.White
        BlueRadioButton.ForeColor = Color.White

    End Sub

    Private Sub BlueRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BlueRadioButton.CheckedChanged
        ' This sub procedure changes the background color of the form to Blue when the
        ' Blue radio button is selected and changes the text colors
        ' to white to be visible on the Blue background
        Me.BackColor = Color.Blue
        CustomerInformationGroupBox.ForeColor = Color.White
        VehicleTypeGroupBox.ForeColor = Color.White
        ColorGroupBox.ForeColor = Color.White
        VisibilityCheckBox.ForeColor = Color.White
        CustomerNameLabel.ForeColor = Color.White
        AddressLabel.ForeColor = Color.White
        CityLabel.ForeColor = Color.White
        VehicleInfoLabel.ForeColor = Color.White
        AutoRadioButton.ForeColor = Color.White
        CommercialRadioButton.ForeColor = Color.White
        TruckRadioButton.ForeColor = Color.White
        GrayRadioButton.ForeColor = Color.White
        YellowRadioButton.ForeColor = Color.White
        GreenRadioButton.ForeColor = Color.White
        BlueRadioButton.ForeColor = Color.White


    End Sub

End Class
