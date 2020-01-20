<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customer_Details
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
        Dim Label1 As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim C_NameLabel As System.Windows.Forms.Label
        Dim C_AddressLabel As System.Windows.Forms.Label
        Dim C_MobileLabel As System.Windows.Forms.Label
        Dim C_R_Item_nameLabel As System.Windows.Forms.Label
        Dim C_countLabel As System.Windows.Forms.Label
        Dim C_CostLabel As System.Windows.Forms.Label
        Dim Current_PriceLabel As System.Windows.Forms.Label
        Dim C_DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer_Details))
        Me.BricksProductionDataSet1 = New BricksManagement.BricksProductionDataSet1()
        Me.CustomerDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDetailsTableAdapter = New BricksManagement.BricksProductionDataSet1TableAdapters.CustomerDetailsTableAdapter()
        Me.TableAdapterManager = New BricksManagement.BricksProductionDataSet1TableAdapters.TableAdapterManager()
        Me.CustomerDetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CustomerDetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CustomerDetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.C_NameTextBox = New System.Windows.Forms.TextBox()
        Me.C_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.C_MobileTextBox = New System.Windows.Forms.TextBox()
        Me.C_R_Item_nameTextBox = New System.Windows.Forms.TextBox()
        Me.C_countTextBox = New System.Windows.Forms.TextBox()
        Me.C_CostTextBox = New System.Windows.Forms.TextBox()
        Me.Current_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.C_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Label1 = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        C_NameLabel = New System.Windows.Forms.Label()
        C_AddressLabel = New System.Windows.Forms.Label()
        C_MobileLabel = New System.Windows.Forms.Label()
        C_R_Item_nameLabel = New System.Windows.Forms.Label()
        C_countLabel = New System.Windows.Forms.Label()
        C_CostLabel = New System.Windows.Forms.Label()
        Current_PriceLabel = New System.Windows.Forms.Label()
        C_DateLabel = New System.Windows.Forms.Label()
        CType(Me.BricksProductionDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerDetailsBindingNavigator.SuspendLayout()
        CType(Me.CustomerDetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Label1.Font = New System.Drawing.Font("Algerian", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(556, 63)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(237, 26)
        Label1.TabIndex = 21
        Label1.Text = "CUSTOMER DETAILS:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(16, 26)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(30, 18)
        IDLabel.TabIndex = 17
        IDLabel.Text = "ID:"
        '
        'C_NameLabel
        '
        C_NameLabel.AutoSize = True
        C_NameLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C_NameLabel.Location = New System.Drawing.Point(16, 57)
        C_NameLabel.Name = "C_NameLabel"
        C_NameLabel.Size = New System.Drawing.Size(75, 18)
        C_NameLabel.TabIndex = 19
        C_NameLabel.Text = "C Name:"
        '
        'C_AddressLabel
        '
        C_AddressLabel.AutoSize = True
        C_AddressLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C_AddressLabel.Location = New System.Drawing.Point(16, 88)
        C_AddressLabel.Name = "C_AddressLabel"
        C_AddressLabel.Size = New System.Drawing.Size(96, 18)
        C_AddressLabel.TabIndex = 21
        C_AddressLabel.Text = "C Address:"
        '
        'C_MobileLabel
        '
        C_MobileLabel.AutoSize = True
        C_MobileLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C_MobileLabel.Location = New System.Drawing.Point(16, 119)
        C_MobileLabel.Name = "C_MobileLabel"
        C_MobileLabel.Size = New System.Drawing.Size(80, 18)
        C_MobileLabel.TabIndex = 23
        C_MobileLabel.Text = "C Mobile:"
        '
        'C_R_Item_nameLabel
        '
        C_R_Item_nameLabel.AutoSize = True
        C_R_Item_nameLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C_R_Item_nameLabel.Location = New System.Drawing.Point(16, 151)
        C_R_Item_nameLabel.Name = "C_R_Item_nameLabel"
        C_R_Item_nameLabel.Size = New System.Drawing.Size(128, 18)
        C_R_Item_nameLabel.TabIndex = 25
        C_R_Item_nameLabel.Text = "C R Item name:"
        '
        'C_countLabel
        '
        C_countLabel.AutoSize = True
        C_countLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C_countLabel.Location = New System.Drawing.Point(16, 214)
        C_countLabel.Name = "C_countLabel"
        C_countLabel.Size = New System.Drawing.Size(75, 18)
        C_countLabel.TabIndex = 27
        C_countLabel.Text = "C count:"
        '
        'C_CostLabel
        '
        C_CostLabel.AutoSize = True
        C_CostLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C_CostLabel.Location = New System.Drawing.Point(17, 251)
        C_CostLabel.Name = "C_CostLabel"
        C_CostLabel.Size = New System.Drawing.Size(66, 18)
        C_CostLabel.TabIndex = 29
        C_CostLabel.Text = "C Cost:"
        '
        'Current_PriceLabel
        '
        Current_PriceLabel.AutoSize = True
        Current_PriceLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Current_PriceLabel.Location = New System.Drawing.Point(15, 184)
        Current_PriceLabel.Name = "Current_PriceLabel"
        Current_PriceLabel.Size = New System.Drawing.Size(121, 18)
        Current_PriceLabel.TabIndex = 31
        Current_PriceLabel.Text = "Current Price:"
        '
        'C_DateLabel
        '
        C_DateLabel.AutoSize = True
        C_DateLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C_DateLabel.Location = New System.Drawing.Point(16, 279)
        C_DateLabel.Name = "C_DateLabel"
        C_DateLabel.Size = New System.Drawing.Size(67, 18)
        C_DateLabel.TabIndex = 33
        C_DateLabel.Text = "C Date:"
        '
        'BricksProductionDataSet1
        '
        Me.BricksProductionDataSet1.DataSetName = "BricksProductionDataSet1"
        Me.BricksProductionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerDetailsBindingSource
        '
        Me.CustomerDetailsBindingSource.DataMember = "CustomerDetails"
        Me.CustomerDetailsBindingSource.DataSource = Me.BricksProductionDataSet1
        '
        'CustomerDetailsTableAdapter
        '
        Me.CustomerDetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminLoginTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BillTableAdapter = Nothing
        Me.TableAdapterManager.CustomerDetailsTableAdapter = Me.CustomerDetailsTableAdapter
        Me.TableAdapterManager.Material_SupplyTableAdapter = Nothing
        Me.TableAdapterManager.Material_TableTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.SalaryReceiptTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BricksManagement.BricksProductionDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WorkerRegistrationTableAdapter = Nothing
        Me.TableAdapterManager.WSalaryTableAdapter = Nothing
        '
        'CustomerDetailsBindingNavigator
        '
        Me.CustomerDetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomerDetailsBindingNavigator.BindingSource = Me.CustomerDetailsBindingSource
        Me.CustomerDetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomerDetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomerDetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomerDetailsBindingNavigatorSaveItem})
        Me.CustomerDetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomerDetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomerDetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomerDetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomerDetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomerDetailsBindingNavigator.Name = "CustomerDetailsBindingNavigator"
        Me.CustomerDetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomerDetailsBindingNavigator.Size = New System.Drawing.Size(1342, 25)
        Me.CustomerDetailsBindingNavigator.TabIndex = 0
        Me.CustomerDetailsBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'CustomerDetailsBindingNavigatorSaveItem
        '
        Me.CustomerDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomerDetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomerDetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomerDetailsBindingNavigatorSaveItem.Name = "CustomerDetailsBindingNavigatorSaveItem"
        Me.CustomerDetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CustomerDetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(6, 339)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(347, 46)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "UPDATE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CustomerDetailsDataGridView
        '
        Me.CustomerDetailsDataGridView.AutoGenerateColumns = False
        Me.CustomerDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.CustomerDetailsDataGridView.DataSource = Me.CustomerDetailsBindingSource
        Me.CustomerDetailsDataGridView.Location = New System.Drawing.Point(20, 38)
        Me.CustomerDetailsDataGridView.Name = "CustomerDetailsDataGridView"
        Me.CustomerDetailsDataGridView.Size = New System.Drawing.Size(697, 330)
        Me.CustomerDetailsDataGridView.TabIndex = 18
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "C_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "C_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "C_Address"
        Me.DataGridViewTextBoxColumn3.HeaderText = "C_Address"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "C_Mobile"
        Me.DataGridViewTextBoxColumn4.HeaderText = "C_Mobile"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "C_R_Item_name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "C_R_Item_name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "C_count"
        Me.DataGridViewTextBoxColumn6.HeaderText = "C_count"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "C_Cost"
        Me.DataGridViewTextBoxColumn7.HeaderText = "C_Cost"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Current_Price"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Current_Price"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "C_Date"
        Me.DataGridViewTextBoxColumn9.HeaderText = "C_Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(IDLabel)
        Me.GroupBox1.Controls.Add(Me.IDTextBox)
        Me.GroupBox1.Controls.Add(C_NameLabel)
        Me.GroupBox1.Controls.Add(Me.C_NameTextBox)
        Me.GroupBox1.Controls.Add(C_AddressLabel)
        Me.GroupBox1.Controls.Add(Me.C_AddressTextBox)
        Me.GroupBox1.Controls.Add(C_MobileLabel)
        Me.GroupBox1.Controls.Add(Me.C_MobileTextBox)
        Me.GroupBox1.Controls.Add(C_R_Item_nameLabel)
        Me.GroupBox1.Controls.Add(Me.C_R_Item_nameTextBox)
        Me.GroupBox1.Controls.Add(C_countLabel)
        Me.GroupBox1.Controls.Add(Me.C_countTextBox)
        Me.GroupBox1.Controls.Add(C_CostLabel)
        Me.GroupBox1.Controls.Add(Me.C_CostTextBox)
        Me.GroupBox1.Controls.Add(Current_PriceLabel)
        Me.GroupBox1.Controls.Add(Me.Current_PriceTextBox)
        Me.GroupBox1.Controls.Add(C_DateLabel)
        Me.GroupBox1.Controls.Add(Me.C_DateDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(119, 125)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 391)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDetailsBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(151, 23)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 26)
        Me.IDTextBox.TabIndex = 18
        '
        'C_NameTextBox
        '
        Me.C_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDetailsBindingSource, "C_Name", True))
        Me.C_NameTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_NameTextBox.Location = New System.Drawing.Point(151, 54)
        Me.C_NameTextBox.Name = "C_NameTextBox"
        Me.C_NameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.C_NameTextBox.TabIndex = 20
        '
        'C_AddressTextBox
        '
        Me.C_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDetailsBindingSource, "C_Address", True))
        Me.C_AddressTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_AddressTextBox.Location = New System.Drawing.Point(151, 85)
        Me.C_AddressTextBox.Name = "C_AddressTextBox"
        Me.C_AddressTextBox.Size = New System.Drawing.Size(200, 26)
        Me.C_AddressTextBox.TabIndex = 22
        '
        'C_MobileTextBox
        '
        Me.C_MobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDetailsBindingSource, "C_Mobile", True))
        Me.C_MobileTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_MobileTextBox.Location = New System.Drawing.Point(151, 116)
        Me.C_MobileTextBox.MaxLength = 10
        Me.C_MobileTextBox.Name = "C_MobileTextBox"
        Me.C_MobileTextBox.Size = New System.Drawing.Size(200, 26)
        Me.C_MobileTextBox.TabIndex = 24
        '
        'C_R_Item_nameTextBox
        '
        Me.C_R_Item_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDetailsBindingSource, "C_R_Item_name", True))
        Me.C_R_Item_nameTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_R_Item_nameTextBox.Location = New System.Drawing.Point(151, 148)
        Me.C_R_Item_nameTextBox.Name = "C_R_Item_nameTextBox"
        Me.C_R_Item_nameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.C_R_Item_nameTextBox.TabIndex = 26
        '
        'C_countTextBox
        '
        Me.C_countTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDetailsBindingSource, "C_count", True))
        Me.C_countTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_countTextBox.Location = New System.Drawing.Point(151, 211)
        Me.C_countTextBox.Name = "C_countTextBox"
        Me.C_countTextBox.Size = New System.Drawing.Size(200, 26)
        Me.C_countTextBox.TabIndex = 28
        '
        'C_CostTextBox
        '
        Me.C_CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDetailsBindingSource, "C_Cost", True))
        Me.C_CostTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_CostTextBox.Location = New System.Drawing.Point(151, 243)
        Me.C_CostTextBox.Name = "C_CostTextBox"
        Me.C_CostTextBox.Size = New System.Drawing.Size(200, 26)
        Me.C_CostTextBox.TabIndex = 30
        '
        'Current_PriceTextBox
        '
        Me.Current_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDetailsBindingSource, "Current_Price", True))
        Me.Current_PriceTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Current_PriceTextBox.Location = New System.Drawing.Point(150, 179)
        Me.Current_PriceTextBox.Name = "Current_PriceTextBox"
        Me.Current_PriceTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Current_PriceTextBox.TabIndex = 32
        '
        'C_DateDateTimePicker
        '
        Me.C_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerDetailsBindingSource, "C_Date", True))
        Me.C_DateDateTimePicker.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_DateDateTimePicker.Location = New System.Drawing.Point(151, 275)
        Me.C_DateDateTimePicker.Name = "C_DateDateTimePicker"
        Me.C_DateDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.C_DateDateTimePicker.TabIndex = 34
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.CustomerDetailsDataGridView)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(484, 125)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(735, 391)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Database"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gray
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 33)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "BACK"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Customer_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1342, 565)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.CustomerDetailsBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Customer_Details"
        Me.Text = "Customer_Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BricksProductionDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerDetailsBindingNavigator.ResumeLayout(False)
        Me.CustomerDetailsBindingNavigator.PerformLayout()
        CType(Me.CustomerDetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BricksProductionDataSet1 As BricksProductionDataSet1
    Friend WithEvents CustomerDetailsBindingSource As BindingSource
    Friend WithEvents CustomerDetailsTableAdapter As BricksProductionDataSet1TableAdapters.CustomerDetailsTableAdapter
    Friend WithEvents TableAdapterManager As BricksProductionDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents CustomerDetailsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CustomerDetailsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Button1 As Button
    Friend WithEvents CustomerDetailsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents C_NameTextBox As TextBox
    Friend WithEvents C_AddressTextBox As TextBox
    Friend WithEvents C_MobileTextBox As TextBox
    Friend WithEvents C_R_Item_nameTextBox As TextBox
    Friend WithEvents C_countTextBox As TextBox
    Friend WithEvents C_CostTextBox As TextBox
    Friend WithEvents Current_PriceTextBox As TextBox
    Friend WithEvents C_DateDateTimePicker As DateTimePicker
End Class
