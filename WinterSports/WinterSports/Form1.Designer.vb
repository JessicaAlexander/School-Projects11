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
        Me.lblEquipment = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.lblDueBack1 = New System.Windows.Forms.Label()
        Me.lblDueBack = New System.Windows.Forms.Label()
        Me.lblTotalDue1 = New System.Windows.Forms.Label()
        Me.lblTax1 = New System.Windows.Forms.Label()
        Me.lblInsurance1 = New System.Windows.Forms.Label()
        Me.lblTotalRentalFee1 = New System.Windows.Forms.Label()
        Me.CBLiabilityWaiver = New System.Windows.Forms.CheckBox()
        Me.CBDamageIns = New System.Windows.Forms.CheckBox()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblDeposit = New System.Windows.Forms.Label()
        Me.lblInsurance = New System.Windows.Forms.Label()
        Me.lblTotalRentalFee = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.CBDuration = New System.Windows.Forms.ComboBox()
        Me.llbWeather = New System.Windows.Forms.LinkLabel()
        Me.dtpCalender = New System.Windows.Forms.DateTimePicker()
        Me.chkList_Equipment = New System.Windows.Forms.CheckedListBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TBDeposit1 = New System.Windows.Forms.TextBox()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.lblDueDate1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnNewCust = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEquipment
        '
        Me.lblEquipment.AutoSize = True
        Me.lblEquipment.Location = New System.Drawing.Point(12, 72)
        Me.lblEquipment.Name = "lblEquipment"
        Me.lblEquipment.Size = New System.Drawing.Size(57, 13)
        Me.lblEquipment.TabIndex = 46
        Me.lblEquipment.Text = "Equipment"
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(415, 344)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 45
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(300, 344)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalculate.TabIndex = 44
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'lblDueBack1
        '
        Me.lblDueBack1.Location = New System.Drawing.Point(651, 314)
        Me.lblDueBack1.Name = "lblDueBack1"
        Me.lblDueBack1.Size = New System.Drawing.Size(75, 13)
        Me.lblDueBack1.TabIndex = 43
        '
        'lblDueBack
        '
        Me.lblDueBack.AutoSize = True
        Me.lblDueBack.Location = New System.Drawing.Point(556, 313)
        Me.lblDueBack.Name = "lblDueBack"
        Me.lblDueBack.Size = New System.Drawing.Size(58, 13)
        Me.lblDueBack.TabIndex = 42
        Me.lblDueBack.Text = "Due Back:"
        '
        'lblTotalDue1
        '
        Me.lblTotalDue1.Location = New System.Drawing.Point(651, 280)
        Me.lblTotalDue1.Name = "lblTotalDue1"
        Me.lblTotalDue1.Size = New System.Drawing.Size(75, 13)
        Me.lblTotalDue1.TabIndex = 41
        '
        'lblTax1
        '
        Me.lblTax1.Location = New System.Drawing.Point(651, 246)
        Me.lblTax1.Name = "lblTax1"
        Me.lblTax1.Size = New System.Drawing.Size(75, 13)
        Me.lblTax1.TabIndex = 40
        '
        'lblInsurance1
        '
        Me.lblInsurance1.Location = New System.Drawing.Point(651, 184)
        Me.lblInsurance1.Name = "lblInsurance1"
        Me.lblInsurance1.Size = New System.Drawing.Size(75, 13)
        Me.lblInsurance1.TabIndex = 39
        '
        'lblTotalRentalFee1
        '
        Me.lblTotalRentalFee1.Location = New System.Drawing.Point(651, 151)
        Me.lblTotalRentalFee1.Name = "lblTotalRentalFee1"
        Me.lblTotalRentalFee1.Size = New System.Drawing.Size(75, 13)
        Me.lblTotalRentalFee1.TabIndex = 38
        '
        'CBLiabilityWaiver
        '
        Me.CBLiabilityWaiver.AutoSize = True
        Me.CBLiabilityWaiver.Location = New System.Drawing.Point(381, 267)
        Me.CBLiabilityWaiver.Name = "CBLiabilityWaiver"
        Me.CBLiabilityWaiver.Size = New System.Drawing.Size(97, 17)
        Me.CBLiabilityWaiver.TabIndex = 35
        Me.CBLiabilityWaiver.Text = "Liability Waiver"
        Me.CBLiabilityWaiver.UseVisualStyleBackColor = True
        '
        'CBDamageIns
        '
        Me.CBDamageIns.AutoSize = True
        Me.CBDamageIns.Location = New System.Drawing.Point(381, 234)
        Me.CBDamageIns.Name = "CBDamageIns"
        Me.CBDamageIns.Size = New System.Drawing.Size(86, 17)
        Me.CBDamageIns.TabIndex = 34
        Me.CBDamageIns.Text = "Damage Ins."
        Me.CBDamageIns.UseVisualStyleBackColor = True
        '
        'lblTotalDue
        '
        Me.lblTotalDue.AutoSize = True
        Me.lblTotalDue.Location = New System.Drawing.Point(556, 279)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(54, 13)
        Me.lblTotalDue.TabIndex = 33
        Me.lblTotalDue.Text = "TotalDue:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(556, 247)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(28, 13)
        Me.lblTax.TabIndex = 32
        Me.lblTax.Text = "Tax:"
        '
        'lblDeposit
        '
        Me.lblDeposit.AutoSize = True
        Me.lblDeposit.Location = New System.Drawing.Point(556, 215)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(46, 13)
        Me.lblDeposit.TabIndex = 31
        Me.lblDeposit.Text = "Deposit:"
        '
        'lblInsurance
        '
        Me.lblInsurance.AutoSize = True
        Me.lblInsurance.Location = New System.Drawing.Point(556, 183)
        Me.lblInsurance.Name = "lblInsurance"
        Me.lblInsurance.Size = New System.Drawing.Size(83, 13)
        Me.lblInsurance.TabIndex = 30
        Me.lblInsurance.Text = "Insurance(10%):"
        '
        'lblTotalRentalFee
        '
        Me.lblTotalRentalFee.AutoSize = True
        Me.lblTotalRentalFee.Location = New System.Drawing.Point(556, 151)
        Me.lblTotalRentalFee.Name = "lblTotalRentalFee"
        Me.lblTotalRentalFee.Size = New System.Drawing.Size(89, 13)
        Me.lblTotalRentalFee.TabIndex = 29
        Me.lblTotalRentalFee.Text = "Total Rental Fee:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(566, 72)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 28
        Me.lblDate.Text = "Date"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(378, 72)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(47, 13)
        Me.lblDuration.TabIndex = 27
        Me.lblDuration.Text = "Duration"
        '
        'CBDuration
        '
        Me.CBDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBDuration.FormattingEnabled = True
        Me.CBDuration.Location = New System.Drawing.Point(378, 91)
        Me.CBDuration.Name = "CBDuration"
        Me.CBDuration.Size = New System.Drawing.Size(121, 21)
        Me.CBDuration.TabIndex = 26
        '
        'llbWeather
        '
        Me.llbWeather.AutoSize = True
        Me.llbWeather.Location = New System.Drawing.Point(41, 354)
        Me.llbWeather.Name = "llbWeather"
        Me.llbWeather.Size = New System.Drawing.Size(86, 13)
        Me.llbWeather.TabIndex = 25
        Me.llbWeather.TabStop = True
        Me.llbWeather.Text = "Weather Forcast"
        '
        'dtpCalender
        '
        Me.dtpCalender.Location = New System.Drawing.Point(559, 92)
        Me.dtpCalender.Name = "dtpCalender"
        Me.dtpCalender.Size = New System.Drawing.Size(200, 20)
        Me.dtpCalender.TabIndex = 24
        '
        'chkList_Equipment
        '
        Me.chkList_Equipment.FormattingEnabled = True
        Me.chkList_Equipment.Location = New System.Drawing.Point(15, 88)
        Me.chkList_Equipment.Name = "chkList_Equipment"
        Me.chkList_Equipment.Size = New System.Drawing.Size(330, 94)
        Me.chkList_Equipment.TabIndex = 48
        '
        'TBDeposit1
        '
        Me.TBDeposit1.Location = New System.Drawing.Point(651, 209)
        Me.TBDeposit1.Name = "TBDeposit1"
        Me.TBDeposit1.Size = New System.Drawing.Size(75, 20)
        Me.TBDeposit1.TabIndex = 49
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Location = New System.Drawing.Point(556, 350)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(56, 13)
        Me.lblDueDate.TabIndex = 50
        Me.lblDueDate.Text = "Due Date:"
        '
        'lblDueDate1
        '
        Me.lblDueDate1.Location = New System.Drawing.Point(651, 350)
        Me.lblDueDate1.Name = "lblDueDate1"
        Me.lblDueDate1.Size = New System.Drawing.Size(75, 13)
        Me.lblDueDate1.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(225, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(414, 27)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "St. Anton am Arlberg Ski Resort"
        '
        'BtnNewCust
        '
        Me.BtnNewCust.Location = New System.Drawing.Point(684, 415)
        Me.BtnNewCust.Name = "BtnNewCust"
        Me.BtnNewCust.Size = New System.Drawing.Size(90, 23)
        Me.BtnNewCust.TabIndex = 53
        Me.BtnNewCust.Text = "New Customer"
        Me.BtnNewCust.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnNewCust)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDueDate1)
        Me.Controls.Add(Me.lblDueDate)
        Me.Controls.Add(Me.TBDeposit1)
        Me.Controls.Add(Me.chkList_Equipment)
        Me.Controls.Add(Me.lblEquipment)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.lblDueBack1)
        Me.Controls.Add(Me.lblDueBack)
        Me.Controls.Add(Me.lblTotalDue1)
        Me.Controls.Add(Me.lblTax1)
        Me.Controls.Add(Me.lblInsurance1)
        Me.Controls.Add(Me.lblTotalRentalFee1)
        Me.Controls.Add(Me.CBLiabilityWaiver)
        Me.Controls.Add(Me.CBDamageIns)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblDeposit)
        Me.Controls.Add(Me.lblInsurance)
        Me.Controls.Add(Me.lblTotalRentalFee)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.CBDuration)
        Me.Controls.Add(Me.llbWeather)
        Me.Controls.Add(Me.dtpCalender)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEquipment As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents lblDueBack1 As Label
    Friend WithEvents lblDueBack As Label
    Friend WithEvents lblTotalDue1 As Label
    Friend WithEvents lblTax1 As Label
    Friend WithEvents lblInsurance1 As Label
    Friend WithEvents lblTotalRentalFee1 As Label
    Friend WithEvents CBLiabilityWaiver As CheckBox
    Friend WithEvents CBDamageIns As CheckBox
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblDeposit As Label
    Friend WithEvents lblInsurance As Label
    Friend WithEvents lblTotalRentalFee As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents CBDuration As ComboBox
    Friend WithEvents llbWeather As LinkLabel
    Friend WithEvents dtpCalender As DateTimePicker
    Friend WithEvents chkList_Equipment As CheckedListBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TBDeposit1 As TextBox
    Friend WithEvents lblDueDate As Label
    Friend WithEvents lblDueDate1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnNewCust As Button
End Class
