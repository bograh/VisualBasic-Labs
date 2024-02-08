<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        AutomotiveInfoGroupBox = New GroupBox()
        DiscountCheckBox = New CheckBox()
        MakeTxtBox = New TextBox()
        YearTxtBox = New TextBox()
        YearLbl = New Label()
        LotNumberTxtBox = New TextBox()
        MakeLbl = New Label()
        LotNumberLbl = New Label()
        SalesInfoGroupBox = New GroupBox()
        TotalTextBox = New TextBox()
        TradeInTextBox = New TextBox()
        SalesTaxTextBox = New TextBox()
        SubtotalTextBox = New TextBox()
        ExtrasTextBox = New TextBox()
        DiscountTextBox = New TextBox()
        PriceTextBox = New TextBox()
        TotalLbl = New Label()
        TradeInLbl = New Label()
        SalesTaxLbl = New Label()
        SubtotalLbl = New Label()
        ExtrasLbl = New Label()
        DiscountLbl = New Label()
        PriceLbl = New Label()
        ExteriorExtrasGroupBox = New GroupBox()
        BothRadioBtn = New RadioButton()
        UndercoatRadioBtn = New RadioButton()
        PaintRadioBtn = New RadioButton()
        NoneRadioBtn = New RadioButton()
        AccessoryGroupBox = New GroupBox()
        FloorMatsCheckBox = New CheckBox()
        GPSCheckBox = New CheckBox()
        RadioCheckBox = New CheckBox()
        TiresCheckBox = New CheckBox()
        ComputeButton = New Button()
        ResetButton = New Button()
        TotalsButton = New Button()
        ExitButton = New Button()
        LotNumErrorProvider = New ErrorProvider(components)
        YearErrorProvider = New ErrorProvider(components)
        VehicleMakeErrorProvider = New ErrorProvider(components)
        PriceErrorProvider = New ErrorProvider(components)
        AutomotiveInfoGroupBox.SuspendLayout()
        SalesInfoGroupBox.SuspendLayout()
        ExteriorExtrasGroupBox.SuspendLayout()
        AccessoryGroupBox.SuspendLayout()
        CType(LotNumErrorProvider, ComponentModel.ISupportInitialize).BeginInit()
        CType(YearErrorProvider, ComponentModel.ISupportInitialize).BeginInit()
        CType(VehicleMakeErrorProvider, ComponentModel.ISupportInitialize).BeginInit()
        CType(PriceErrorProvider, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' AutomotiveInfoGroupBox
        ' 
        AutomotiveInfoGroupBox.Controls.Add(DiscountCheckBox)
        AutomotiveInfoGroupBox.Controls.Add(MakeTxtBox)
        AutomotiveInfoGroupBox.Controls.Add(YearTxtBox)
        AutomotiveInfoGroupBox.Controls.Add(YearLbl)
        AutomotiveInfoGroupBox.Controls.Add(LotNumberTxtBox)
        AutomotiveInfoGroupBox.Controls.Add(MakeLbl)
        AutomotiveInfoGroupBox.Controls.Add(LotNumberLbl)
        AutomotiveInfoGroupBox.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        AutomotiveInfoGroupBox.Location = New Point(12, 10)
        AutomotiveInfoGroupBox.Margin = New Padding(2, 3, 2, 3)
        AutomotiveInfoGroupBox.Name = "AutomotiveInfoGroupBox"
        AutomotiveInfoGroupBox.Padding = New Padding(2, 3, 2, 3)
        AutomotiveInfoGroupBox.Size = New Size(604, 131)
        AutomotiveInfoGroupBox.TabIndex = 0
        AutomotiveInfoGroupBox.TabStop = False
        AutomotiveInfoGroupBox.Text = "Used Automotive Information"
        ' 
        ' DiscountCheckBox
        ' 
        DiscountCheckBox.AutoSize = True
        DiscountCheckBox.Checked = True
        DiscountCheckBox.CheckState = CheckState.Checked
        DiscountCheckBox.Location = New Point(167, 94)
        DiscountCheckBox.Margin = New Padding(2, 3, 2, 3)
        DiscountCheckBox.Name = "DiscountCheckBox"
        DiscountCheckBox.Size = New Size(206, 23)
        DiscountCheckBox.TabIndex = 6
        DiscountCheckBox.Text = "&Wholesale Dealer Discount"
        DiscountCheckBox.UseVisualStyleBackColor = True
        ' 
        ' MakeTxtBox
        ' 
        MakeTxtBox.Location = New Point(167, 61)
        MakeTxtBox.Margin = New Padding(2, 3, 2, 3)
        MakeTxtBox.Name = "MakeTxtBox"
        MakeTxtBox.Size = New Size(405, 25)
        MakeTxtBox.TabIndex = 5
        ' 
        ' YearTxtBox
        ' 
        YearTxtBox.Location = New Point(473, 25)
        YearTxtBox.Margin = New Padding(2, 3, 2, 3)
        YearTxtBox.Name = "YearTxtBox"
        YearTxtBox.Size = New Size(100, 25)
        YearTxtBox.TabIndex = 4
        ' 
        ' YearLbl
        ' 
        YearLbl.AutoSize = True
        YearLbl.Location = New Point(421, 29)
        YearLbl.Margin = New Padding(2, 0, 2, 0)
        YearLbl.Name = "YearLbl"
        YearLbl.Size = New Size(44, 19)
        YearLbl.TabIndex = 3
        YearLbl.Text = "&Year:"
        ' 
        ' LotNumberTxtBox
        ' 
        LotNumberTxtBox.Location = New Point(167, 26)
        LotNumberTxtBox.Margin = New Padding(2, 3, 2, 3)
        LotNumberTxtBox.Name = "LotNumberTxtBox"
        LotNumberTxtBox.Size = New Size(230, 25)
        LotNumberTxtBox.TabIndex = 2
        ' 
        ' MakeLbl
        ' 
        MakeLbl.AutoSize = True
        MakeLbl.Location = New Point(6, 64)
        MakeLbl.Margin = New Padding(2, 0, 2, 0)
        MakeLbl.Name = "MakeLbl"
        MakeLbl.Size = New Size(150, 19)
        MakeLbl.TabIndex = 1
        MakeLbl.Text = "&Vehicle Make/Model:"
        ' 
        ' LotNumberLbl
        ' 
        LotNumberLbl.AutoSize = True
        LotNumberLbl.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        LotNumberLbl.Location = New Point(6, 29)
        LotNumberLbl.Margin = New Padding(2, 0, 2, 0)
        LotNumberLbl.Name = "LotNumberLbl"
        LotNumberLbl.Size = New Size(94, 19)
        LotNumberLbl.TabIndex = 0
        LotNumberLbl.Text = "&Lot Number:"
        ' 
        ' SalesInfoGroupBox
        ' 
        SalesInfoGroupBox.Controls.Add(TotalTextBox)
        SalesInfoGroupBox.Controls.Add(TradeInTextBox)
        SalesInfoGroupBox.Controls.Add(SalesTaxTextBox)
        SalesInfoGroupBox.Controls.Add(SubtotalTextBox)
        SalesInfoGroupBox.Controls.Add(ExtrasTextBox)
        SalesInfoGroupBox.Controls.Add(DiscountTextBox)
        SalesInfoGroupBox.Controls.Add(PriceTextBox)
        SalesInfoGroupBox.Controls.Add(TotalLbl)
        SalesInfoGroupBox.Controls.Add(TradeInLbl)
        SalesInfoGroupBox.Controls.Add(SalesTaxLbl)
        SalesInfoGroupBox.Controls.Add(SubtotalLbl)
        SalesInfoGroupBox.Controls.Add(ExtrasLbl)
        SalesInfoGroupBox.Controls.Add(DiscountLbl)
        SalesInfoGroupBox.Controls.Add(PriceLbl)
        SalesInfoGroupBox.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        SalesInfoGroupBox.Location = New Point(12, 156)
        SalesInfoGroupBox.Margin = New Padding(2, 3, 2, 3)
        SalesInfoGroupBox.Name = "SalesInfoGroupBox"
        SalesInfoGroupBox.Padding = New Padding(2, 3, 2, 3)
        SalesInfoGroupBox.Size = New Size(388, 253)
        SalesInfoGroupBox.TabIndex = 1
        SalesInfoGroupBox.TabStop = False
        SalesInfoGroupBox.Text = "Sales Information"
        ' 
        ' TotalTextBox
        ' 
        TotalTextBox.Location = New Point(112, 221)
        TotalTextBox.Name = "TotalTextBox"
        TotalTextBox.ReadOnly = True
        TotalTextBox.Size = New Size(181, 25)
        TotalTextBox.TabIndex = 13
        TotalTextBox.TabStop = False
        TotalTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' TradeInTextBox
        ' 
        TradeInTextBox.Location = New Point(112, 188)
        TradeInTextBox.Name = "TradeInTextBox"
        TradeInTextBox.Size = New Size(181, 25)
        TradeInTextBox.TabIndex = 12
        TradeInTextBox.Text = "0.00"
        TradeInTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' SalesTaxTextBox
        ' 
        SalesTaxTextBox.Location = New Point(112, 155)
        SalesTaxTextBox.Name = "SalesTaxTextBox"
        SalesTaxTextBox.ReadOnly = True
        SalesTaxTextBox.Size = New Size(181, 25)
        SalesTaxTextBox.TabIndex = 11
        SalesTaxTextBox.TabStop = False
        SalesTaxTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' SubtotalTextBox
        ' 
        SubtotalTextBox.Location = New Point(112, 121)
        SubtotalTextBox.Name = "SubtotalTextBox"
        SubtotalTextBox.ReadOnly = True
        SubtotalTextBox.Size = New Size(181, 25)
        SubtotalTextBox.TabIndex = 10
        SubtotalTextBox.TabStop = False
        SubtotalTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' ExtrasTextBox
        ' 
        ExtrasTextBox.Location = New Point(112, 89)
        ExtrasTextBox.Name = "ExtrasTextBox"
        ExtrasTextBox.ReadOnly = True
        ExtrasTextBox.Size = New Size(181, 25)
        ExtrasTextBox.TabIndex = 9
        ExtrasTextBox.TabStop = False
        ExtrasTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' DiscountTextBox
        ' 
        DiscountTextBox.Location = New Point(112, 56)
        DiscountTextBox.Name = "DiscountTextBox"
        DiscountTextBox.ReadOnly = True
        DiscountTextBox.Size = New Size(181, 25)
        DiscountTextBox.TabIndex = 8
        DiscountTextBox.TabStop = False
        DiscountTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' PriceTextBox
        ' 
        PriceTextBox.Location = New Point(112, 21)
        PriceTextBox.Name = "PriceTextBox"
        PriceTextBox.Size = New Size(181, 25)
        PriceTextBox.TabIndex = 7
        PriceTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' TotalLbl
        ' 
        TotalLbl.AutoSize = True
        TotalLbl.Location = New Point(6, 224)
        TotalLbl.Margin = New Padding(2, 0, 2, 0)
        TotalLbl.Name = "TotalLbl"
        TotalLbl.Size = New Size(76, 19)
        TotalLbl.TabIndex = 6
        TotalLbl.Text = "Total Due:"
        ' 
        ' TradeInLbl
        ' 
        TradeInLbl.AutoSize = True
        TradeInLbl.Location = New Point(6, 191)
        TradeInLbl.Margin = New Padding(2, 0, 2, 0)
        TradeInLbl.Name = "TradeInLbl"
        TradeInLbl.Size = New Size(69, 19)
        TradeInLbl.TabIndex = 5
        TradeInLbl.Text = "T&rade-in:"
        ' 
        ' SalesTaxLbl
        ' 
        SalesTaxLbl.AutoSize = True
        SalesTaxLbl.Location = New Point(6, 158)
        SalesTaxLbl.Margin = New Padding(2, 0, 2, 0)
        SalesTaxLbl.Name = "SalesTaxLbl"
        SalesTaxLbl.Size = New Size(74, 19)
        SalesTaxLbl.TabIndex = 4
        SalesTaxLbl.Text = "Sales Tax:"
        ' 
        ' SubtotalLbl
        ' 
        SubtotalLbl.AutoSize = True
        SubtotalLbl.Location = New Point(6, 124)
        SubtotalLbl.Margin = New Padding(2, 0, 2, 0)
        SubtotalLbl.Name = "SubtotalLbl"
        SubtotalLbl.Size = New Size(69, 19)
        SubtotalLbl.TabIndex = 3
        SubtotalLbl.Text = "Subtotal:"
        ' 
        ' ExtrasLbl
        ' 
        ExtrasLbl.AutoSize = True
        ExtrasLbl.Location = New Point(6, 92)
        ExtrasLbl.Margin = New Padding(2, 0, 2, 0)
        ExtrasLbl.Name = "ExtrasLbl"
        ExtrasLbl.Size = New Size(53, 19)
        ExtrasLbl.TabIndex = 2
        ExtrasLbl.Text = "Extras:"
        ' 
        ' DiscountLbl
        ' 
        DiscountLbl.AutoSize = True
        DiscountLbl.Location = New Point(6, 59)
        DiscountLbl.Margin = New Padding(2, 0, 2, 0)
        DiscountLbl.Name = "DiscountLbl"
        DiscountLbl.Size = New Size(70, 19)
        DiscountLbl.TabIndex = 1
        DiscountLbl.Text = "Discount:"
        ' 
        ' PriceLbl
        ' 
        PriceLbl.AutoSize = True
        PriceLbl.Location = New Point(6, 24)
        PriceLbl.Margin = New Padding(2, 0, 2, 0)
        PriceLbl.Name = "PriceLbl"
        PriceLbl.Size = New Size(47, 19)
        PriceLbl.TabIndex = 0
        PriceLbl.Text = "&Price:"
        ' 
        ' ExteriorExtrasGroupBox
        ' 
        ExteriorExtrasGroupBox.Controls.Add(BothRadioBtn)
        ExteriorExtrasGroupBox.Controls.Add(UndercoatRadioBtn)
        ExteriorExtrasGroupBox.Controls.Add(PaintRadioBtn)
        ExteriorExtrasGroupBox.Controls.Add(NoneRadioBtn)
        ExteriorExtrasGroupBox.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        ExteriorExtrasGroupBox.Location = New Point(415, 156)
        ExteriorExtrasGroupBox.Margin = New Padding(2, 3, 2, 3)
        ExteriorExtrasGroupBox.Name = "ExteriorExtrasGroupBox"
        ExteriorExtrasGroupBox.Padding = New Padding(2, 3, 2, 3)
        ExteriorExtrasGroupBox.Size = New Size(201, 130)
        ExteriorExtrasGroupBox.TabIndex = 2
        ExteriorExtrasGroupBox.TabStop = False
        ExteriorExtrasGroupBox.Text = "Exterior Extras"
        ' 
        ' BothRadioBtn
        ' 
        BothRadioBtn.AutoSize = True
        BothRadioBtn.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        BothRadioBtn.Location = New Point(5, 103)
        BothRadioBtn.Name = "BothRadioBtn"
        BothRadioBtn.Size = New Size(58, 23)
        BothRadioBtn.TabIndex = 6
        BothRadioBtn.Text = "Both"
        BothRadioBtn.UseVisualStyleBackColor = True
        ' 
        ' UndercoatRadioBtn
        ' 
        UndercoatRadioBtn.AutoSize = True
        UndercoatRadioBtn.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        UndercoatRadioBtn.Location = New Point(5, 76)
        UndercoatRadioBtn.Name = "UndercoatRadioBtn"
        UndercoatRadioBtn.Size = New Size(97, 23)
        UndercoatRadioBtn.TabIndex = 4
        UndercoatRadioBtn.Text = "Undercoat"
        UndercoatRadioBtn.UseVisualStyleBackColor = True
        ' 
        ' PaintRadioBtn
        ' 
        PaintRadioBtn.AutoSize = True
        PaintRadioBtn.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        PaintRadioBtn.Location = New Point(5, 47)
        PaintRadioBtn.Name = "PaintRadioBtn"
        PaintRadioBtn.Size = New Size(129, 23)
        PaintRadioBtn.TabIndex = 5
        PaintRadioBtn.Text = "Paint Touch-Up"
        PaintRadioBtn.UseVisualStyleBackColor = True
        ' 
        ' NoneRadioBtn
        ' 
        NoneRadioBtn.AutoSize = True
        NoneRadioBtn.Checked = True
        NoneRadioBtn.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        NoneRadioBtn.Location = New Point(5, 22)
        NoneRadioBtn.Name = "NoneRadioBtn"
        NoneRadioBtn.Size = New Size(63, 23)
        NoneRadioBtn.TabIndex = 4
        NoneRadioBtn.TabStop = True
        NoneRadioBtn.Text = "&None"
        NoneRadioBtn.UseVisualStyleBackColor = True
        ' 
        ' AccessoryGroupBox
        ' 
        AccessoryGroupBox.Controls.Add(FloorMatsCheckBox)
        AccessoryGroupBox.Controls.Add(GPSCheckBox)
        AccessoryGroupBox.Controls.Add(RadioCheckBox)
        AccessoryGroupBox.Controls.Add(TiresCheckBox)
        AccessoryGroupBox.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        AccessoryGroupBox.Location = New Point(415, 292)
        AccessoryGroupBox.Margin = New Padding(2, 3, 2, 3)
        AccessoryGroupBox.Name = "AccessoryGroupBox"
        AccessoryGroupBox.Padding = New Padding(2, 3, 2, 3)
        AccessoryGroupBox.Size = New Size(201, 117)
        AccessoryGroupBox.TabIndex = 3
        AccessoryGroupBox.TabStop = False
        AccessoryGroupBox.Text = "Accessory Extras"
        ' 
        ' FloorMatsCheckBox
        ' 
        FloorMatsCheckBox.AutoSize = True
        FloorMatsCheckBox.Location = New Point(5, 94)
        FloorMatsCheckBox.Name = "FloorMatsCheckBox"
        FloorMatsCheckBox.Size = New Size(133, 23)
        FloorMatsCheckBox.TabIndex = 3
        FloorMatsCheckBox.Text = "New Floor Mats"
        FloorMatsCheckBox.UseVisualStyleBackColor = True
        ' 
        ' GPSCheckBox
        ' 
        GPSCheckBox.AutoSize = True
        GPSCheckBox.Location = New Point(5, 68)
        GPSCheckBox.Name = "GPSCheckBox"
        GPSCheckBox.Size = New Size(106, 23)
        GPSCheckBox.TabIndex = 2
        GPSCheckBox.Text = "Built-in &GPS"
        GPSCheckBox.UseVisualStyleBackColor = True
        ' 
        ' RadioCheckBox
        ' 
        RadioCheckBox.AutoSize = True
        RadioCheckBox.Location = New Point(5, 44)
        RadioCheckBox.Name = "RadioCheckBox"
        RadioCheckBox.Size = New Size(126, 23)
        RadioCheckBox.TabIndex = 1
        RadioCheckBox.Text = "New &HD Radio"
        RadioCheckBox.UseVisualStyleBackColor = True
        ' 
        ' TiresCheckBox
        ' 
        TiresCheckBox.AutoSize = True
        TiresCheckBox.Location = New Point(5, 22)
        TiresCheckBox.Name = "TiresCheckBox"
        TiresCheckBox.Size = New Size(94, 23)
        TiresCheckBox.TabIndex = 0
        TiresCheckBox.Text = "New T&ires"
        TiresCheckBox.UseVisualStyleBackColor = True
        ' 
        ' ComputeButton
        ' 
        ComputeButton.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        ComputeButton.Location = New Point(149, 437)
        ComputeButton.Name = "ComputeButton"
        ComputeButton.Size = New Size(95, 33)
        ComputeButton.TabIndex = 4
        ComputeButton.Text = "&Compute"
        ComputeButton.UseVisualStyleBackColor = True
        ' 
        ' ResetButton
        ' 
        ResetButton.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        ResetButton.Location = New Point(269, 437)
        ResetButton.Name = "ResetButton"
        ResetButton.Size = New Size(95, 33)
        ResetButton.TabIndex = 5
        ResetButton.Text = "&Reset"
        ResetButton.UseVisualStyleBackColor = True
        ' 
        ' TotalsButton
        ' 
        TotalsButton.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        TotalsButton.Location = New Point(389, 437)
        TotalsButton.Name = "TotalsButton"
        TotalsButton.Size = New Size(95, 33)
        TotalsButton.TabIndex = 6
        TotalsButton.Text = "&Totals"
        TotalsButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        ExitButton.Location = New Point(508, 437)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(95, 33)
        ExitButton.TabIndex = 7
        ExitButton.Text = "E&xit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' LotNumErrorProvider
        ' 
        LotNumErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink
        LotNumErrorProvider.ContainerControl = Me
        ' 
        ' YearErrorProvider
        ' 
        YearErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink
        YearErrorProvider.ContainerControl = Me
        ' 
        ' VehicleMakeErrorProvider
        ' 
        VehicleMakeErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink
        VehicleMakeErrorProvider.ContainerControl = Me
        ' 
        ' PriceErrorProvider
        ' 
        PriceErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink
        PriceErrorProvider.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AcceptButton = ComputeButton
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = ExitButton
        ClientSize = New Size(730, 510)
        Controls.Add(ExitButton)
        Controls.Add(TotalsButton)
        Controls.Add(ResetButton)
        Controls.Add(ComputeButton)
        Controls.Add(AccessoryGroupBox)
        Controls.Add(ExteriorExtrasGroupBox)
        Controls.Add(SalesInfoGroupBox)
        Controls.Add(AutomotiveInfoGroupBox)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(2, 3, 2, 3)
        Name = "Form1"
        Text = "Bock Repair Parts and Automotive Sales"
        AutomotiveInfoGroupBox.ResumeLayout(False)
        AutomotiveInfoGroupBox.PerformLayout()
        SalesInfoGroupBox.ResumeLayout(False)
        SalesInfoGroupBox.PerformLayout()
        ExteriorExtrasGroupBox.ResumeLayout(False)
        ExteriorExtrasGroupBox.PerformLayout()
        AccessoryGroupBox.ResumeLayout(False)
        AccessoryGroupBox.PerformLayout()
        CType(LotNumErrorProvider, ComponentModel.ISupportInitialize).EndInit()
        CType(YearErrorProvider, ComponentModel.ISupportInitialize).EndInit()
        CType(VehicleMakeErrorProvider, ComponentModel.ISupportInitialize).EndInit()
        CType(PriceErrorProvider, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents AutomotiveInfoGroupBox As GroupBox
    Friend WithEvents LotNumberLbl As Label
    Friend WithEvents MakeLbl As Label
    Friend WithEvents DiscountCheckBox As CheckBox
    Friend WithEvents MakeTxtBox As TextBox
    Friend WithEvents YearTxtBox As TextBox
    Friend WithEvents YearLbl As Label
    Friend WithEvents LotNumberTxtBox As TextBox
    Friend WithEvents SalesInfoGroupBox As GroupBox
    Friend WithEvents ExtrasLbl As Label
    Friend WithEvents DiscountLbl As Label
    Friend WithEvents PriceLbl As Label
    Friend WithEvents ExteriorExtrasGroupBox As GroupBox
    Friend WithEvents AccessoryGroupBox As GroupBox
    Friend WithEvents TotalLbl As Label
    Friend WithEvents TradeInLbl As Label
    Friend WithEvents SalesTaxLbl As Label
    Friend WithEvents SubtotalLbl As Label
    Friend WithEvents ExtrasTextBox As TextBox
    Friend WithEvents DiscountTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents TradeInTextBox As TextBox
    Friend WithEvents SalesTaxTextBox As TextBox
    Friend WithEvents SubtotalTextBox As TextBox
    Friend WithEvents BothRadioBtn As RadioButton
    Friend WithEvents UndercoatRadioBtn As RadioButton
    Friend WithEvents PaintRadioBtn As RadioButton
    Friend WithEvents NoneRadioBtn As RadioButton
    Friend WithEvents FloorMatsCheckBox As CheckBox
    Friend WithEvents GPSCheckBox As CheckBox
    Friend WithEvents RadioCheckBox As CheckBox
    Friend WithEvents TiresCheckBox As CheckBox
    Friend WithEvents ComputeButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents TotalsButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents LotNumErrorProvider As ErrorProvider
    Friend WithEvents YearErrorProvider As ErrorProvider
    Friend WithEvents VehicleMakeErrorProvider As ErrorProvider
    Friend WithEvents PriceErrorProvider As ErrorProvider
End Class
