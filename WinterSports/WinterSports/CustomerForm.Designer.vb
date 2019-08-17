<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerForm
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
        Dim Customer_IDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Street_AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim Zip_CodeLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerForm))
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Customer_IDTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Street_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.Zip_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Winter_Sports_RentalsDataSet = New WinterSports.Winter_Sports_RentalsDataSet()
        Me.CustomerTableAdapter = New WinterSports.Winter_Sports_RentalsDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New WinterSports.Winter_Sports_RentalsDataSetTableAdapters.TableAdapterManager()
        Customer_IDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Street_AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        Zip_CodeLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Winter_Sports_RentalsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Customer_IDLabel
        '
        Customer_IDLabel.AutoSize = True
        Customer_IDLabel.Location = New System.Drawing.Point(75, 66)
        Customer_IDLabel.Name = "Customer_IDLabel"
        Customer_IDLabel.Size = New System.Drawing.Size(68, 13)
        Customer_IDLabel.TabIndex = 1
        Customer_IDLabel.Text = "Customer ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(83, 136)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 3
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(323, 136)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 5
        Last_NameLabel.Text = "Last Name:"
        '
        'Street_AddressLabel
        '
        Street_AddressLabel.AutoSize = True
        Street_AddressLabel.Location = New System.Drawing.Point(64, 206)
        Street_AddressLabel.Name = "Street_AddressLabel"
        Street_AddressLabel.Size = New System.Drawing.Size(79, 13)
        Street_AddressLabel.TabIndex = 7
        Street_AddressLabel.Text = "Street Address:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(323, 203)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 9
        CityLabel.Text = "City:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(565, 206)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(35, 13)
        StateLabel.TabIndex = 11
        StateLabel.Text = "State:"
        '
        'Zip_CodeLabel
        '
        Zip_CodeLabel.AutoSize = True
        Zip_CodeLabel.Location = New System.Drawing.Point(90, 268)
        Zip_CodeLabel.Name = "Zip_CodeLabel"
        Zip_CodeLabel.Size = New System.Drawing.Size(53, 13)
        Zip_CodeLabel.TabIndex = 13
        Zip_CodeLabel.Text = "Zip Code:"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Location = New System.Drawing.Point(303, 265)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(81, 13)
        Phone_NumberLabel.TabIndex = 15
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.CustomerBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SaveToolStripButton})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(800, 25)
        Me.BindingNavigator1.TabIndex = 0
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'Customer_IDTextBox
        '
        Me.Customer_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Customer ID", True))
        Me.Customer_IDTextBox.Location = New System.Drawing.Point(163, 63)
        Me.Customer_IDTextBox.Name = "Customer_IDTextBox"
        Me.Customer_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Customer_IDTextBox.TabIndex = 2
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "First Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(163, 133)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.First_NameTextBox.TabIndex = 4
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(390, 133)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Last_NameTextBox.TabIndex = 6
        '
        'Street_AddressTextBox
        '
        Me.Street_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Street Address", True))
        Me.Street_AddressTextBox.Location = New System.Drawing.Point(163, 203)
        Me.Street_AddressTextBox.Name = "Street_AddressTextBox"
        Me.Street_AddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Street_AddressTextBox.TabIndex = 8
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(390, 200)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CityTextBox.TabIndex = 10
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(606, 203)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StateTextBox.TabIndex = 12
        '
        'Zip_CodeTextBox
        '
        Me.Zip_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Zip Code", True))
        Me.Zip_CodeTextBox.Location = New System.Drawing.Point(163, 265)
        Me.Zip_CodeTextBox.Name = "Zip_CodeTextBox"
        Me.Zip_CodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Zip_CodeTextBox.TabIndex = 14
        '
        'Phone_NumberTextBox
        '
        Me.Phone_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Phone Number", True))
        Me.Phone_NumberTextBox.Location = New System.Drawing.Point(390, 262)
        Me.Phone_NumberTextBox.Name = "Phone_NumberTextBox"
        Me.Phone_NumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Phone_NumberTextBox.TabIndex = 16
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.Winter_Sports_RentalsDataSet
        '
        'Winter_Sports_RentalsDataSet
        '
        Me.Winter_Sports_RentalsDataSet.DataSetName = "Winter_Sports_RentalsDataSet"
        Me.Winter_Sports_RentalsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.EquipmentTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.InvoicesTableAdapter = Nothing
        Me.TableAdapterManager.Rental_ItemsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WinterSports.Winter_Sports_RentalsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Phone_NumberLabel)
        Me.Controls.Add(Me.Phone_NumberTextBox)
        Me.Controls.Add(Zip_CodeLabel)
        Me.Controls.Add(Me.Zip_CodeTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Street_AddressLabel)
        Me.Controls.Add(Me.Street_AddressTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Customer_IDLabel)
        Me.Controls.Add(Me.Customer_IDTextBox)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Name = "CustomerForm"
        Me.Text = "CustomerForm"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Winter_Sports_RentalsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Winter_Sports_RentalsDataSet As Winter_Sports_RentalsDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As Winter_Sports_RentalsDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As Winter_Sports_RentalsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents Customer_IDTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents Street_AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents Zip_CodeTextBox As TextBox
    Friend WithEvents Phone_NumberTextBox As TextBox
    Friend WithEvents SaveToolStripButton As ToolStripButton
End Class
