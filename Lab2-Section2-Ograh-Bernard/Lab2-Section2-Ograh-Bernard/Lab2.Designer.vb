<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lab2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lab2))
        Me.CustomerInformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.ZipCodeMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.VehicleTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.CommercialRadioButton = New System.Windows.Forms.RadioButton()
        Me.TruckRadioButton = New System.Windows.Forms.RadioButton()
        Me.AutoRadioButton = New System.Windows.Forms.RadioButton()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.CustomerAddressTextBox = New System.Windows.Forms.TextBox()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNameLabel = New System.Windows.Forms.Label()
        Me.ColorGroupBox = New System.Windows.Forms.GroupBox()
        Me.BlueRadioButton = New System.Windows.Forms.RadioButton()
        Me.GreenRadioButton = New System.Windows.Forms.RadioButton()
        Me.YellowRadioButton = New System.Windows.Forms.RadioButton()
        Me.GrayRadioButton = New System.Windows.Forms.RadioButton()
        Me.VehicleInfoTextBox = New System.Windows.Forms.TextBox()
        Me.VehicleInfoLabel = New System.Windows.Forms.Label()
        Me.MultilineTextBox = New System.Windows.Forms.TextBox()
        Me.VisibilityCheckBox = New System.Windows.Forms.CheckBox()
        Me.DisplayBtn = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.PrintBtn = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TruckPictureBox = New System.Windows.Forms.PictureBox()
        Me.CommercialPictureBox = New System.Windows.Forms.PictureBox()
        Me.AutoPictureBox = New System.Windows.Forms.PictureBox()
        Me.CustomerInformationGroupBox.SuspendLayout()
        Me.VehicleTypeGroupBox.SuspendLayout()
        Me.ColorGroupBox.SuspendLayout()
        CType(Me.TruckPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommercialPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerInformationGroupBox
        '
        Me.CustomerInformationGroupBox.Controls.Add(Me.ZipCodeMaskedTextBox)
        Me.CustomerInformationGroupBox.Controls.Add(Me.VehicleTypeGroupBox)
        Me.CustomerInformationGroupBox.Controls.Add(Me.StateTextBox)
        Me.CustomerInformationGroupBox.Controls.Add(Me.CityTextBox)
        Me.CustomerInformationGroupBox.Controls.Add(Me.CityLabel)
        Me.CustomerInformationGroupBox.Controls.Add(Me.CustomerAddressTextBox)
        Me.CustomerInformationGroupBox.Controls.Add(Me.AddressLabel)
        Me.CustomerInformationGroupBox.Controls.Add(Me.CustomerNameTextBox)
        Me.CustomerInformationGroupBox.Controls.Add(Me.CustomerNameLabel)
        Me.CustomerInformationGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerInformationGroupBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.CustomerInformationGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.CustomerInformationGroupBox.Name = "CustomerInformationGroupBox"
        Me.CustomerInformationGroupBox.Size = New System.Drawing.Size(625, 140)
        Me.CustomerInformationGroupBox.TabIndex = 0
        Me.CustomerInformationGroupBox.TabStop = False
        Me.CustomerInformationGroupBox.Text = "Customer Information"
        '
        'ZipCodeMaskedTextBox
        '
        Me.ZipCodeMaskedTextBox.Location = New System.Drawing.Point(363, 92)
        Me.ZipCodeMaskedTextBox.Mask = "00000-9999"
        Me.ZipCodeMaskedTextBox.Name = "ZipCodeMaskedTextBox"
        Me.ZipCodeMaskedTextBox.Size = New System.Drawing.Size(127, 23)
        Me.ZipCodeMaskedTextBox.TabIndex = 6
        '
        'VehicleTypeGroupBox
        '
        Me.VehicleTypeGroupBox.Controls.Add(Me.CommercialRadioButton)
        Me.VehicleTypeGroupBox.Controls.Add(Me.TruckRadioButton)
        Me.VehicleTypeGroupBox.Controls.Add(Me.AutoRadioButton)
        Me.VehicleTypeGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VehicleTypeGroupBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.VehicleTypeGroupBox.Location = New System.Drawing.Point(496, 12)
        Me.VehicleTypeGroupBox.Name = "VehicleTypeGroupBox"
        Me.VehicleTypeGroupBox.Size = New System.Drawing.Size(123, 122)
        Me.VehicleTypeGroupBox.TabIndex = 7
        Me.VehicleTypeGroupBox.TabStop = False
        Me.VehicleTypeGroupBox.Text = "Vehicle Type"
        '
        'CommercialRadioButton
        '
        Me.CommercialRadioButton.AutoSize = True
        Me.CommercialRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommercialRadioButton.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CommercialRadioButton.Location = New System.Drawing.Point(7, 77)
        Me.CommercialRadioButton.Name = "CommercialRadioButton"
        Me.CommercialRadioButton.Size = New System.Drawing.Size(102, 19)
        Me.CommercialRadioButton.TabIndex = 2
        Me.CommercialRadioButton.Text = "Commercial"
        Me.CommercialRadioButton.UseVisualStyleBackColor = True
        '
        'TruckRadioButton
        '
        Me.TruckRadioButton.AutoSize = True
        Me.TruckRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TruckRadioButton.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TruckRadioButton.Location = New System.Drawing.Point(7, 49)
        Me.TruckRadioButton.Name = "TruckRadioButton"
        Me.TruckRadioButton.Size = New System.Drawing.Size(60, 19)
        Me.TruckRadioButton.TabIndex = 1
        Me.TruckRadioButton.Text = "Truck"
        Me.TruckRadioButton.UseVisualStyleBackColor = True
        '
        'AutoRadioButton
        '
        Me.AutoRadioButton.AutoSize = True
        Me.AutoRadioButton.Checked = True
        Me.AutoRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoRadioButton.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AutoRadioButton.Location = New System.Drawing.Point(7, 21)
        Me.AutoRadioButton.Name = "AutoRadioButton"
        Me.AutoRadioButton.Size = New System.Drawing.Size(53, 19)
        Me.AutoRadioButton.TabIndex = 0
        Me.AutoRadioButton.TabStop = True
        Me.AutoRadioButton.Text = "Auto"
        Me.AutoRadioButton.UseVisualStyleBackColor = True
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(328, 92)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(29, 23)
        Me.StateTextBox.TabIndex = 5
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(131, 92)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(191, 23)
        Me.CityTextBox.TabIndex = 4
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityLabel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CityLabel.Location = New System.Drawing.Point(8, 92)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(105, 16)
        Me.CityLabel.TabIndex = 5
        Me.CityLabel.Text = "City/State/Zip:"
        '
        'CustomerAddressTextBox
        '
        Me.CustomerAddressTextBox.Location = New System.Drawing.Point(130, 60)
        Me.CustomerAddressTextBox.Name = "CustomerAddressTextBox"
        Me.CustomerAddressTextBox.Size = New System.Drawing.Size(360, 23)
        Me.CustomerAddressTextBox.TabIndex = 3
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLabel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AddressLabel.Location = New System.Drawing.Point(7, 60)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(69, 16)
        Me.AddressLabel.TabIndex = 3
        Me.AddressLabel.Text = "Address:"
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(129, 30)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(361, 23)
        Me.CustomerNameTextBox.TabIndex = 2
        '
        'CustomerNameLabel
        '
        Me.CustomerNameLabel.AutoSize = True
        Me.CustomerNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerNameLabel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CustomerNameLabel.Location = New System.Drawing.Point(6, 30)
        Me.CustomerNameLabel.Name = "CustomerNameLabel"
        Me.CustomerNameLabel.Size = New System.Drawing.Size(121, 16)
        Me.CustomerNameLabel.TabIndex = 1
        Me.CustomerNameLabel.Text = "Customer Name:"
        '
        'ColorGroupBox
        '
        Me.ColorGroupBox.Controls.Add(Me.BlueRadioButton)
        Me.ColorGroupBox.Controls.Add(Me.GreenRadioButton)
        Me.ColorGroupBox.Controls.Add(Me.YellowRadioButton)
        Me.ColorGroupBox.Controls.Add(Me.GrayRadioButton)
        Me.ColorGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorGroupBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ColorGroupBox.Location = New System.Drawing.Point(643, 12)
        Me.ColorGroupBox.Name = "ColorGroupBox"
        Me.ColorGroupBox.Size = New System.Drawing.Size(110, 140)
        Me.ColorGroupBox.TabIndex = 8
        Me.ColorGroupBox.TabStop = False
        Me.ColorGroupBox.Text = "Select Color"
        '
        'BlueRadioButton
        '
        Me.BlueRadioButton.AutoSize = True
        Me.BlueRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlueRadioButton.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BlueRadioButton.Location = New System.Drawing.Point(7, 96)
        Me.BlueRadioButton.Name = "BlueRadioButton"
        Me.BlueRadioButton.Size = New System.Drawing.Size(54, 19)
        Me.BlueRadioButton.TabIndex = 3
        Me.BlueRadioButton.Text = "Blue"
        Me.BlueRadioButton.UseVisualStyleBackColor = True
        '
        'GreenRadioButton
        '
        Me.GreenRadioButton.AutoSize = True
        Me.GreenRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GreenRadioButton.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GreenRadioButton.Location = New System.Drawing.Point(7, 71)
        Me.GreenRadioButton.Name = "GreenRadioButton"
        Me.GreenRadioButton.Size = New System.Drawing.Size(64, 19)
        Me.GreenRadioButton.TabIndex = 2
        Me.GreenRadioButton.Text = "Green"
        Me.GreenRadioButton.UseVisualStyleBackColor = True
        '
        'YellowRadioButton
        '
        Me.YellowRadioButton.AutoSize = True
        Me.YellowRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YellowRadioButton.ForeColor = System.Drawing.SystemColors.WindowText
        Me.YellowRadioButton.Location = New System.Drawing.Point(7, 46)
        Me.YellowRadioButton.Name = "YellowRadioButton"
        Me.YellowRadioButton.Size = New System.Drawing.Size(67, 19)
        Me.YellowRadioButton.TabIndex = 1
        Me.YellowRadioButton.Text = "Yellow"
        Me.YellowRadioButton.UseVisualStyleBackColor = True
        '
        'GrayRadioButton
        '
        Me.GrayRadioButton.AutoSize = True
        Me.GrayRadioButton.Checked = True
        Me.GrayRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrayRadioButton.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GrayRadioButton.Location = New System.Drawing.Point(7, 21)
        Me.GrayRadioButton.Name = "GrayRadioButton"
        Me.GrayRadioButton.Size = New System.Drawing.Size(54, 19)
        Me.GrayRadioButton.TabIndex = 0
        Me.GrayRadioButton.TabStop = True
        Me.GrayRadioButton.Text = "Gray"
        Me.GrayRadioButton.UseVisualStyleBackColor = True
        '
        'VehicleInfoTextBox
        '
        Me.VehicleInfoTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.VehicleInfoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VehicleInfoTextBox.Location = New System.Drawing.Point(303, 179)
        Me.VehicleInfoTextBox.Name = "VehicleInfoTextBox"
        Me.VehicleInfoTextBox.ReadOnly = True
        Me.VehicleInfoTextBox.Size = New System.Drawing.Size(249, 21)
        Me.VehicleInfoTextBox.TabIndex = 10
        Me.VehicleInfoTextBox.TabStop = False
        '
        'VehicleInfoLabel
        '
        Me.VehicleInfoLabel.AutoSize = True
        Me.VehicleInfoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VehicleInfoLabel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.VehicleInfoLabel.Location = New System.Drawing.Point(205, 179)
        Me.VehicleInfoLabel.Name = "VehicleInfoLabel"
        Me.VehicleInfoLabel.Size = New System.Drawing.Size(92, 16)
        Me.VehicleInfoLabel.TabIndex = 9
        Me.VehicleInfoLabel.Text = "Vehicle Info:"
        '
        'MultilineTextBox
        '
        Me.MultilineTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.MultilineTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultilineTextBox.Location = New System.Drawing.Point(208, 205)
        Me.MultilineTextBox.Multiline = True
        Me.MultilineTextBox.Name = "MultilineTextBox"
        Me.MultilineTextBox.ReadOnly = True
        Me.MultilineTextBox.Size = New System.Drawing.Size(344, 109)
        Me.MultilineTextBox.TabIndex = 15
        Me.MultilineTextBox.TabStop = False
        '
        'VisibilityCheckBox
        '
        Me.VisibilityCheckBox.AutoSize = True
        Me.VisibilityCheckBox.Checked = True
        Me.VisibilityCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.VisibilityCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VisibilityCheckBox.Location = New System.Drawing.Point(607, 182)
        Me.VisibilityCheckBox.Name = "VisibilityCheckBox"
        Me.VisibilityCheckBox.Size = New System.Drawing.Size(116, 17)
        Me.VisibilityCheckBox.TabIndex = 9
        Me.VisibilityCheckBox.Text = "Visible/Invisible"
        Me.VisibilityCheckBox.UseVisualStyleBackColor = True
        '
        'DisplayBtn
        '
        Me.DisplayBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayBtn.Location = New System.Drawing.Point(563, 238)
        Me.DisplayBtn.Name = "DisplayBtn"
        Me.DisplayBtn.Size = New System.Drawing.Size(87, 29)
        Me.DisplayBtn.TabIndex = 10
        Me.DisplayBtn.Text = "&Display"
        Me.ToolTip1.SetToolTip(Me.DisplayBtn, "Display congratulations message")
        Me.DisplayBtn.UseVisualStyleBackColor = True
        '
        'ResetBtn
        '
        Me.ResetBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ResetBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetBtn.Location = New System.Drawing.Point(661, 238)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(87, 29)
        Me.ResetBtn.TabIndex = 11
        Me.ResetBtn.Text = "&Reset"
        Me.ToolTip2.SetToolTip(Me.ResetBtn, "Reset the Form")
        Me.ResetBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.Location = New System.Drawing.Point(661, 276)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(87, 29)
        Me.ExitBtn.TabIndex = 13
        Me.ExitBtn.Text = "E&xit"
        Me.ToolTip4.SetToolTip(Me.ExitBtn, "Exit the Application")
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'PrintBtn
        '
        Me.PrintBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintBtn.Location = New System.Drawing.Point(563, 276)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(87, 29)
        Me.PrintBtn.TabIndex = 12
        Me.PrintBtn.Text = "&Print"
        Me.ToolTip3.SetToolTip(Me.PrintBtn, "Print the form")
        Me.PrintBtn.UseVisualStyleBackColor = True
        '
        'TruckPictureBox
        '
        Me.TruckPictureBox.BackColor = System.Drawing.SystemColors.Window
        Me.TruckPictureBox.BackgroundImage = CType(resources.GetObject("TruckPictureBox.BackgroundImage"), System.Drawing.Image)
        Me.TruckPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TruckPictureBox.Location = New System.Drawing.Point(12, 179)
        Me.TruckPictureBox.Name = "TruckPictureBox"
        Me.TruckPictureBox.Size = New System.Drawing.Size(180, 150)
        Me.TruckPictureBox.TabIndex = 23
        Me.TruckPictureBox.TabStop = False
        Me.TruckPictureBox.Visible = False
        '
        'CommercialPictureBox
        '
        Me.CommercialPictureBox.BackColor = System.Drawing.SystemColors.Window
        Me.CommercialPictureBox.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.CommercialPicture
        Me.CommercialPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CommercialPictureBox.Location = New System.Drawing.Point(12, 179)
        Me.CommercialPictureBox.Name = "CommercialPictureBox"
        Me.CommercialPictureBox.Size = New System.Drawing.Size(180, 150)
        Me.CommercialPictureBox.TabIndex = 22
        Me.CommercialPictureBox.TabStop = False
        Me.CommercialPictureBox.Visible = False
        '
        'AutoPictureBox
        '
        Me.AutoPictureBox.BackColor = System.Drawing.SystemColors.Window
        Me.AutoPictureBox.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.AutoPictures
        Me.AutoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AutoPictureBox.Location = New System.Drawing.Point(12, 179)
        Me.AutoPictureBox.Name = "AutoPictureBox"
        Me.AutoPictureBox.Size = New System.Drawing.Size(180, 150)
        Me.AutoPictureBox.TabIndex = 21
        Me.AutoPictureBox.TabStop = False
        '
        'Lab2
        '
        Me.AcceptButton = Me.DisplayBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.ResetBtn
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TruckPictureBox)
        Me.Controls.Add(Me.CommercialPictureBox)
        Me.Controls.Add(Me.AutoPictureBox)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.PrintBtn)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.DisplayBtn)
        Me.Controls.Add(Me.VisibilityCheckBox)
        Me.Controls.Add(Me.MultilineTextBox)
        Me.Controls.Add(Me.VehicleInfoTextBox)
        Me.Controls.Add(Me.VehicleInfoLabel)
        Me.Controls.Add(Me.ColorGroupBox)
        Me.Controls.Add(Me.CustomerInformationGroupBox)
        Me.Name = "Lab2"
        Me.Text = "Block Repair Parts - by Bernard Ograh"
        Me.CustomerInformationGroupBox.ResumeLayout(False)
        Me.CustomerInformationGroupBox.PerformLayout()
        Me.VehicleTypeGroupBox.ResumeLayout(False)
        Me.VehicleTypeGroupBox.PerformLayout()
        Me.ColorGroupBox.ResumeLayout(False)
        Me.ColorGroupBox.PerformLayout()
        CType(Me.TruckPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommercialPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerInformationGroupBox As GroupBox
    Friend WithEvents CustomerNameLabel As Label
    Friend WithEvents ColorGroupBox As GroupBox
    Friend WithEvents GrayRadioButton As RadioButton
    Friend WithEvents BlueRadioButton As RadioButton
    Friend WithEvents GreenRadioButton As RadioButton
    Friend WithEvents YellowRadioButton As RadioButton
    Friend WithEvents CustomerAddressTextBox As TextBox
    Friend WithEvents AddressLabel As Label
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents CityLabel As Label
    Friend WithEvents VehicleTypeGroupBox As GroupBox
    Friend WithEvents CommercialRadioButton As RadioButton
    Friend WithEvents TruckRadioButton As RadioButton
    Friend WithEvents AutoRadioButton As RadioButton
    Friend WithEvents VehicleInfoTextBox As TextBox
    Friend WithEvents VehicleInfoLabel As Label
    Friend WithEvents MultilineTextBox As TextBox
    Friend WithEvents VisibilityCheckBox As CheckBox
    Friend WithEvents DisplayBtn As Button
    Friend WithEvents ResetBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents PrintBtn As Button
    Friend WithEvents ZipCodeMaskedTextBox As MaskedTextBox
    Friend WithEvents AutoPictureBox As PictureBox
    Friend WithEvents CommercialPictureBox As PictureBox
    Friend WithEvents TruckPictureBox As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip4 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
End Class
