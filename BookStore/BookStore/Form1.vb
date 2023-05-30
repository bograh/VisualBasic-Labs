Public Class Form1
    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click
        Try
            ' Declare Variables and Constants
            Dim price, subtotal, VAT, totalDue As Decimal
            Dim quantity As Integer
            Const VatRate As Decimal = 0.175

            ' Perform calculations
            price = Decimal.Parse(PriceTextBox.Text)
            quantity = Integer.Parse(QuantityTextBox.Text)
            subtotal = price * quantity
            VAT = subtotal * VatRate
            totalDue = subtotal + VAT

            ' Display Outputs
            SubtotalOutputTextBox.Text = subtotal.ToString("C2")
            VatOutputTextBox.Text = VAT.ToString("C2")
            TotalOutputTextBox.Text = totalDue.ToString("C2")

            ' Disable compute button after click
            ComputeButton.Enabled = False

        Catch ex As Exception
            MessageBox.Show("Price and Quantity should be numbers!", "Error message")
        End Try
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        BookTitleTextBox.Clear()
        ISBNMaskedTextBox.Clear()
        PriceTextBox.Clear()
        QuantityTextBox.Clear()
        SubtotalOutputTextBox.Clear()
        VatOutputTextBox.Clear()
        TotalOutputTextBox.Clear()
        BookTitleTextBox.Focus()
        ComputeButton.Enabled = True

    End Sub
End Class
