'Option Strict On
Public Class Form1
    ' Declare and Initialize variables
    Const SALES_TAX_RATE As Double = 0.05, DISCOUNT_PERCENT As Double = 0.2
    Const PAINT_TOUCH_UP As Double = 250, UNDERCOAT As Double = 300, BOTH As Double = 550
    Const TIRES As Double = 450, HD_RADIO As Double = 190.95, GPS As Double = 700, FLOOR_MATS As Double = 55
    Dim price, extras, subtotal, salesTax, discount, tradeIn, total As Double
    Private vehicleCount As Integer = 0
    Private totalSales, averageSales As Double

    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click
        Try
            price = Double.Parse(PriceTextBox.Text)
            extras = 0
            tradeIn = Double.Parse(TradeInTextBox.Text)
            ' Check if user is a wholesale dealer
            If DiscountCheckBox.Checked Then
                discount = DISCOUNT_PERCENT * price
                salesTax = 0
            Else
                discount = 0
                salesTax = SALES_TAX_RATE * price
            End If

            ' Check is user selected any Exterior Extra
            If PaintRadioBtn.Checked Then
                extras += PAINT_TOUCH_UP
            ElseIf UndercoatRadioBtn.Checked Then
                extras += UNDERCOAT
            ElseIf BothRadioBtn.Checked Then
                extras += BOTH
            Else
                extras = 0
            End If

            ' Check is user selected any Accessory Extra
            If TiresCheckBox.Checked Then
                extras += TIRES
            End If
            If RadioCheckBox.Checked Then
                extras += HD_RADIO
            End If
            If GPSCheckBox.Checked Then
                extras += GPS
            End If
            If FloorMatsCheckBox.Checked Then
                extras += FLOOR_MATS
            End If

            ' Perform computations
            subtotal = (price - discount) + extras
            total = subtotal - tradeIn

            ' Display outputs
            DiscountTextBox.Text = discount.ToString("N2")
            ExtrasTextBox.Text = extras.ToString("N2")
            SubtotalTextBox.Text = subtotal.ToString("N2")
            SalesTaxTextBox.Text = salesTax.ToString("N2")
            TotalTextBox.Text = total.ToString("C2")

            ' Totals and Averages
            vehicleCount += 1
            totalSales += total


        Catch ex As Exception
            MessageBox.Show("Error in Price entry", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click

    End Sub

    Private Sub TotalsButton_Click(sender As Object, e As EventArgs) Handles TotalsButton.Click
        Dim averageSales As Double
        averageSales = totalSales / vehicleCount
        Dim TotalsString As String = "Total due all sales: " & totalSales.ToString("C2") & ControlChars.NewLine & "Total vehicles sold: " & vehicleCount & ControlChars.NewLine & "Average total due: " & averageSales.ToString("C2")
        MessageBox.Show(TotalsString, "Totals and Averages", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim MessageString As String = "Exit Application (Y/N)?"
        Dim ButtonDialogResult As DialogResult = MessageBox.Show(MessageString, "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If ButtonDialogResult = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = False
    End Sub

    Private Sub LotNumberTxtBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles LotNumberTxtBox.Validating
        If LotNumberTxtBox.Text = String.Empty Then
            e.Cancel = True
            LotNumErrorProvider.SetError(LotNumberTxtBox, "Lot Number is required")
        ElseIf IsNumeric(LotNumberTxtBox.Text) = False Then
            e.Cancel = True
            LotNumErrorProvider.SetError(LotNumberTxtBox, "Lot number should be a number")
        Else
            'Clear error provider message
            LotNumErrorProvider.SetError(LotNumberTxtBox, "")
        End If
    End Sub

    Private Sub YearTxtBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles YearTxtBox.Validating
        If YearTxtBox.Text = String.Empty Then
            e.Cancel = True
            YearErrorProvider.SetError(YearTxtBox, "Year is required")
        ElseIf Integer.Parse(YearTxtBox.Text) < 1900 Or Integer.Parse(YearTxtBox.Text) > 2500 Then
            e.Cancel = True
            LotNumErrorProvider.SetError(YearTxtBox, "Invalid Year Entered")
        Else
            'Clear error provider message
            YearErrorProvider.SetError(YearTxtBox, "")
        End If
    End Sub

    Private Sub MakeTxtBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MakeTxtBox.Validating
        If MakeTxtBox.Text = String.Empty Then
            e.Cancel = True
            VehicleMakeErrorProvider.SetError(MakeTxtBox, "Vehicle Make/Model is required")
        Else
            'Clear error provider message
            VehicleMakeErrorProvider.SetError(MakeTxtBox, "")
        End If
    End Sub

    Private Sub PriceTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PriceTextBox.Validating
        If PriceTextBox.Text = String.Empty Then
            e.Cancel = True
            PriceErrorProvider.SetError(PriceTextBox, "Price is required")
        Else
            'Clear error provider message
            PriceErrorProvider.SetError(PriceTextBox, "")
        End If
    End Sub


End Class
