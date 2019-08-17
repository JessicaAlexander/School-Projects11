Public Class Form1
    Private rentalPrices As New Equipment
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkList_Equipment.Items.Add("Ski  $25  $35  $70  $140  $270  $320")
        chkList_Equipment.Items.Add("Ski  $25  $35  $70  $140  $270  $320")
        chkList_Equipment.Items.Add("Ski  $25  $35  $70  $140  $270  $320")
        chkList_Equipment.Items.Add("Ski  $25  $35  $70  $140  $270  $320")
        chkList_Equipment.Items.Add("Ski Bindings  $35  $45  $90  $180  $310  $400")
        chkList_Equipment.Items.Add("Ski Bindings  $35  $45  $90  $180  $310  $400")
        chkList_Equipment.Items.Add("Ski Bindings  $35  $45  $90  $180  $310  $400")
        chkList_Equipment.Items.Add("Ski Bindings  $35  $45  $90  $180  $310  $400")
        chkList_Equipment.Items.Add("Ski Boots  $15  $30  $45  $90  $150  $230")
        chkList_Equipment.Items.Add("Ski Boots  $15  $30  $45  $90  $150  $230")
        chkList_Equipment.Items.Add("Ski Boots  $15  $30  $45  $90  $150  $230")
        chkList_Equipment.Items.Add("Ski Boots  $15  $30  $45  $90  $150  $230")
        chkList_Equipment.Items.Add("Ski Helment  $30  $60  $120  $170  $250  $370")
        chkList_Equipment.Items.Add("Ski Helment  $30  $60  $120  $170  $250  $370")
        chkList_Equipment.Items.Add("Ski Helment  $30  $60  $120  $170  $250  $370")
        chkList_Equipment.Items.Add("Ski Helment  $30  $60  $120  $170  $250  $370")
        chkList_Equipment.Items.Add("Ski Goggles  $15  $30  $45  $90  $220  $310")
        chkList_Equipment.Items.Add("Ski Goggles  $15  $30  $45  $90  $220  $310")
        chkList_Equipment.Items.Add("Ski Goggles  $15  $30  $45  $90  $220  $310")
        chkList_Equipment.Items.Add("Ski Goggles  $15  $30  $45  $90  $220  $310")
        chkList_Equipment.Items.Add("Ski Backpack  $30  $65  $90  $150  $200  $270")
        chkList_Equipment.Items.Add("Ski Backpack  $30  $65  $90  $150  $200  $270")
        chkList_Equipment.Items.Add("Ski Backpack  $30  $65  $90  $150  $200  $270")
        chkList_Equipment.Items.Add("Ski Backpack  $30  $65  $90  $150  $200  $270")




        CBDuration.Items.Add("1 Day")
        CBDuration.Items.Add("2 Days")
        CBDuration.Items.Add("3 Days")
        CBDuration.Items.Add("1 Week")
        CBDuration.Items.Add("2 Weeks")
        CBDuration.Items.Add("3 Weeks")
    End Sub

    Private Sub llbWeather_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbWeather.LinkClicked
        WeatherForm.ShowDialog()
    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        If CBLiabilityWaiver.Checked Then

            If Not TBDeposit1.Text.Equals(String.Empty) Then

                If Not CBDuration.Text.Equals(String.Empty) Then

                    If chkList_Equipment.CheckedIndices.Count > 0 Then
                        Dim Price As Double
                        Dim Tax As Double
                        Dim Total As Double
                        Dim Deposit As Double
                        Dim Insurance As Double
                        Dim DueBack As Double
                        Dim startDate As Date
                        Dim DueDate As Date

                        Double.TryParse(TBDeposit1.SelectedText.ToString, Deposit)
                        Deposit = TBDeposit1.Text

                        Dim duration As Equipment.EquipmentType = CType(CBDuration.SelectedIndex, Equipment.EquipmentType)
                        Dim subtotal As Double = 0


                        For Each Index As Integer In chkList_Equipment.CheckedIndices
                            Dim equipType As Equipment.EquipmentType = CType(Index, Equipment.EquipmentType)
                            subtotal += rentalPrices.GetRentalPrices(equipType, duration)
                        Next Index
                        lblTotalRentalFee1.Text = subtotal.ToString("C2")

                        Tax = subtotal * 0.0825
                        lblTax1.Text = Tax.ToString("C2")

                        If CBDamageIns.Checked Then
                            Insurance = subtotal * 0.1
                            lblInsurance1.Text = Insurance.ToString("C2")

                            Total = subtotal + Tax + Deposit + Insurance
                            lblTotalDue1.Text = Total.ToString("C2")

                            DueBack = Deposit
                            lblDueBack1.Text = DueBack.ToString("C2")
                        End If

                        startDate = dtpCalender.Value
                        Select Case (CBDuration.SelectedIndex)
                            Case 0
                                DueDate = startDate.AddDays(1)
                            Case 1
                                DueDate = startDate.AddDays(2)
                            Case 2
                                DueDate = startDate.AddDays(3)
                            Case 3
                                DueDate = startDate.AddDays(7)
                            Case 4
                                DueDate = startDate.AddDays(14)
                            Case 5
                                DueDate = startDate.AddDays(21)
                        End Select
                        lblDueDate1.Text = DueDate
                    Else
                        MessageBox.Show("Please Select Equipment!")
                    End If
                Else
                    MessageBox.Show("Please select a duration!")
                End If
            Else
                MessageBox.Show("Please enter a deposit!")
            End If
        Else
            MessageBox.Show("Liability Waiver must be signed!")
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnNewCust_Click(sender As Object, e As EventArgs) Handles BtnNewCust.Click
        CustomerForm.Show()
    End Sub
End Class