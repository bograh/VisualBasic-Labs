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
        Me.SaleInformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.ISBNMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TotalOutputTextBox = New System.Windows.Forms.TextBox()
        Me.VatOutputTextBox = New System.Windows.Forms.TextBox()
        Me.SubtotalOutputTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.BookTitleTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComputeButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.TotalsButton = New System.Windows.Forms.Button()
        Me.SaleInformationGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SaleInformationGroupBox
        '
        Me.SaleInformationGroupBox.Controls.Add(Me.ISBNMaskedTextBox)
        Me.SaleInformationGroupBox.Controls.Add(Me.TotalOutputTextBox)
        Me.SaleInformationGroupBox.Controls.Add(Me.VatOutputTextBox)
        Me.SaleInformationGroupBox.Controls.Add(Me.SubtotalOutputTextBox)
        Me.SaleInformationGroupBox.Controls.Add(Me.QuantityTextBox)
        Me.SaleInformationGroupBox.Controls.Add(Me.PriceTextBox)
        Me.SaleInformationGroupBox.Controls.Add(Me.BookTitleTextBox)
        Me.SaleInformationGroupBox.Controls.Add(Me.Label7)
        Me.SaleInformationGroupBox.Controls.Add(Me.Label4)
        Me.SaleInformationGroupBox.Controls.Add(Me.Label5)
        Me.SaleInformationGroupBox.Controls.Add(Me.Label6)
        Me.SaleInformationGroupBox.Controls.Add(Me.Label3)
        Me.SaleInformationGroupBox.Controls.Add(Me.Label2)
        Me.SaleInformationGroupBox.Controls.Add(Me.Label1)
        Me.SaleInformationGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaleInformationGroupBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.SaleInformationGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.SaleInformationGroupBox.Name = "SaleInformationGroupBox"
        Me.SaleInformationGroupBox.Size = New System.Drawing.Size(776, 325)
        Me.SaleInformationGroupBox.TabIndex = 0
        Me.SaleInformationGroupBox.TabStop = False
        Me.SaleInformationGroupBox.Text = "Textbook Sale Information"
        '
        'ISBNMaskedTextBox
        '
        Me.ISBNMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBNMaskedTextBox.Location = New System.Drawing.Point(174, 74)
        Me.ISBNMaskedTextBox.Mask = "0-000-00000-0"
        Me.ISBNMaskedTextBox.Name = "ISBNMaskedTextBox"
        Me.ISBNMaskedTextBox.Size = New System.Drawing.Size(227, 23)
        Me.ISBNMaskedTextBox.TabIndex = 1
        '
        'TotalOutputTextBox
        '
        Me.TotalOutputTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.TotalOutputTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalOutputTextBox.Location = New System.Drawing.Point(174, 279)
        Me.TotalOutputTextBox.Name = "TotalOutputTextBox"
        Me.TotalOutputTextBox.ReadOnly = True
        Me.TotalOutputTextBox.Size = New System.Drawing.Size(100, 23)
        Me.TotalOutputTextBox.TabIndex = 6
        Me.TotalOutputTextBox.TabStop = False
        Me.TotalOutputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'VatOutputTextBox
        '
        Me.VatOutputTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.VatOutputTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VatOutputTextBox.Location = New System.Drawing.Point(174, 238)
        Me.VatOutputTextBox.Name = "VatOutputTextBox"
        Me.VatOutputTextBox.ReadOnly = True
        Me.VatOutputTextBox.Size = New System.Drawing.Size(100, 23)
        Me.VatOutputTextBox.TabIndex = 6
        Me.VatOutputTextBox.TabStop = False
        Me.VatOutputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SubtotalOutputTextBox
        '
        Me.SubtotalOutputTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.SubtotalOutputTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubtotalOutputTextBox.Location = New System.Drawing.Point(174, 197)
        Me.SubtotalOutputTextBox.Name = "SubtotalOutputTextBox"
        Me.SubtotalOutputTextBox.ReadOnly = True
        Me.SubtotalOutputTextBox.Size = New System.Drawing.Size(100, 23)
        Me.SubtotalOutputTextBox.TabIndex = 6
        Me.SubtotalOutputTextBox.TabStop = False
        Me.SubtotalOutputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(174, 156)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(100, 23)
        Me.QuantityTextBox.TabIndex = 3
        Me.QuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceTextBox.Location = New System.Drawing.Point(174, 115)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 23)
        Me.PriceTextBox.TabIndex = 2
        Me.PriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BookTitleTextBox
        '
        Me.BookTitleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookTitleTextBox.Location = New System.Drawing.Point(174, 33)
        Me.BookTitleTextBox.Name = "BookTitleTextBox"
        Me.BookTitleTextBox.Size = New System.Drawing.Size(449, 23)
        Me.BookTitleTextBox.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(6, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Total Due"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(6, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "VAT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(6, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Subtotal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(6, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(6, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(6, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ISBN (Identifier)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Book Title"
        '
        'ComputeButton
        '
        Me.ComputeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComputeButton.Location = New System.Drawing.Point(127, 363)
        Me.ComputeButton.Name = "ComputeButton"
        Me.ComputeButton.Size = New System.Drawing.Size(112, 44)
        Me.ComputeButton.TabIndex = 4
        Me.ComputeButton.Text = "Compute"
        Me.ComputeButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.Location = New System.Drawing.Point(260, 363)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(112, 44)
        Me.ResetButton.TabIndex = 5
        Me.ResetButton.Text = "&Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(526, 363)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(112, 44)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'TotalsButton
        '
        Me.TotalsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalsButton.Location = New System.Drawing.Point(393, 363)
        Me.TotalsButton.Name = "TotalsButton"
        Me.TotalsButton.Size = New System.Drawing.Size(112, 44)
        Me.TotalsButton.TabIndex = 6
        Me.TotalsButton.Text = "&Totals"
        Me.TotalsButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.ComputeButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TotalsButton)
        Me.Controls.Add(Me.ComputeButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SaleInformationGroupBox)
        Me.Controls.Add(Me.ResetButton)
        Me.Name = "Form1"
        Me.Text = "Book Store - by Bernard Ograh"
        Me.SaleInformationGroupBox.ResumeLayout(False)
        Me.SaleInformationGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SaleInformationGroupBox As GroupBox
    Friend WithEvents TotalOutputTextBox As TextBox
    Friend WithEvents VatOutputTextBox As TextBox
    Friend WithEvents SubtotalOutputTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents BookTitleTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ISBNMaskedTextBox As MaskedTextBox
    Friend WithEvents ComputeButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents TotalsButton As Button
End Class
