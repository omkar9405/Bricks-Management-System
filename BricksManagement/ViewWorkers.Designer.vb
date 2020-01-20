<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewWorkers
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
        Dim W_IDLabel As System.Windows.Forms.Label
        Dim W_NameLabel As System.Windows.Forms.Label
        Dim W_AddressLabel As System.Windows.Forms.Label
        Dim W_MobileLabel As System.Windows.Forms.Label
        Dim W_TypeLabel As System.Windows.Forms.Label
        Dim W_SalaryLabel As System.Windows.Forms.Label
        Dim W_DOBLabel As System.Windows.Forms.Label
        Dim W_JoinDateLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewWorkers))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.W_IDTextBox = New System.Windows.Forms.TextBox()
        Me.WorkerRegistrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BricksProductionDataSet1 = New BricksManagement.BricksProductionDataSet1()
        Me.W_NameTextBox = New System.Windows.Forms.TextBox()
        Me.W_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.W_MobileTextBox = New System.Windows.Forms.TextBox()
        Me.W_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.W_SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.W_DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.W_JoinDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.WorkerRegistrationDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkerRegistrationTableAdapter = New BricksManagement.BricksProductionDataSet1TableAdapters.WorkerRegistrationTableAdapter()
        Me.TableAdapterManager = New BricksManagement.BricksProductionDataSet1TableAdapters.TableAdapterManager()
        Me.WorkerRegistrationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.WorkerRegistrationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        W_IDLabel = New System.Windows.Forms.Label()
        W_NameLabel = New System.Windows.Forms.Label()
        W_AddressLabel = New System.Windows.Forms.Label()
        W_MobileLabel = New System.Windows.Forms.Label()
        W_TypeLabel = New System.Windows.Forms.Label()
        W_SalaryLabel = New System.Windows.Forms.Label()
        W_DOBLabel = New System.Windows.Forms.Label()
        W_JoinDateLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.WorkerRegistrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BricksProductionDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.WorkerRegistrationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkerRegistrationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkerRegistrationBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'W_IDLabel
        '
        W_IDLabel.AutoSize = True
        W_IDLabel.Location = New System.Drawing.Point(37, 109)
        W_IDLabel.Name = "W_IDLabel"
        W_IDLabel.Size = New System.Drawing.Size(56, 18)
        W_IDLabel.TabIndex = 0
        W_IDLabel.Text = "*W ID:"
        '
        'W_NameLabel
        '
        W_NameLabel.AutoSize = True
        W_NameLabel.Location = New System.Drawing.Point(37, 141)
        W_NameLabel.Name = "W_NameLabel"
        W_NameLabel.Size = New System.Drawing.Size(85, 18)
        W_NameLabel.TabIndex = 2
        W_NameLabel.Text = "*W Name:"
        '
        'W_AddressLabel
        '
        W_AddressLabel.AutoSize = True
        W_AddressLabel.Location = New System.Drawing.Point(37, 173)
        W_AddressLabel.Name = "W_AddressLabel"
        W_AddressLabel.Size = New System.Drawing.Size(106, 18)
        W_AddressLabel.TabIndex = 4
        W_AddressLabel.Text = "*W Address:"
        '
        'W_MobileLabel
        '
        W_MobileLabel.AutoSize = True
        W_MobileLabel.Location = New System.Drawing.Point(37, 205)
        W_MobileLabel.Name = "W_MobileLabel"
        W_MobileLabel.Size = New System.Drawing.Size(90, 18)
        W_MobileLabel.TabIndex = 6
        W_MobileLabel.Text = "*W Mobile:"
        '
        'W_TypeLabel
        '
        W_TypeLabel.AutoSize = True
        W_TypeLabel.Location = New System.Drawing.Point(37, 237)
        W_TypeLabel.Name = "W_TypeLabel"
        W_TypeLabel.Size = New System.Drawing.Size(78, 18)
        W_TypeLabel.TabIndex = 8
        W_TypeLabel.Text = "*W Type:"
        '
        'W_SalaryLabel
        '
        W_SalaryLabel.AutoSize = True
        W_SalaryLabel.Location = New System.Drawing.Point(37, 269)
        W_SalaryLabel.Name = "W_SalaryLabel"
        W_SalaryLabel.Size = New System.Drawing.Size(90, 18)
        W_SalaryLabel.TabIndex = 10
        W_SalaryLabel.Text = "*W Salary:"
        '
        'W_DOBLabel
        '
        W_DOBLabel.AutoSize = True
        W_DOBLabel.Location = New System.Drawing.Point(37, 302)
        W_DOBLabel.Name = "W_DOBLabel"
        W_DOBLabel.Size = New System.Drawing.Size(76, 18)
        W_DOBLabel.TabIndex = 12
        W_DOBLabel.Text = "*W DOB:"
        '
        'W_JoinDateLabel
        '
        W_JoinDateLabel.AutoSize = True
        W_JoinDateLabel.Location = New System.Drawing.Point(36, 334)
        W_JoinDateLabel.Name = "W_JoinDateLabel"
        W_JoinDateLabel.Size = New System.Drawing.Size(114, 18)
        W_JoinDateLabel.TabIndex = 14
        W_JoinDateLabel.Text = "*W Join Date:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(131, 38)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(137, 32)
        Label1.TabIndex = 19
        Label1.Text = "WORKER"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(W_IDLabel)
        Me.GroupBox1.Controls.Add(Me.W_IDTextBox)
        Me.GroupBox1.Controls.Add(W_NameLabel)
        Me.GroupBox1.Controls.Add(Me.W_NameTextBox)
        Me.GroupBox1.Controls.Add(W_AddressLabel)
        Me.GroupBox1.Controls.Add(Me.W_AddressTextBox)
        Me.GroupBox1.Controls.Add(W_MobileLabel)
        Me.GroupBox1.Controls.Add(Me.W_MobileTextBox)
        Me.GroupBox1.Controls.Add(W_TypeLabel)
        Me.GroupBox1.Controls.Add(Me.W_TypeTextBox)
        Me.GroupBox1.Controls.Add(W_SalaryLabel)
        Me.GroupBox1.Controls.Add(Me.W_SalaryTextBox)
        Me.GroupBox1.Controls.Add(W_DOBLabel)
        Me.GroupBox1.Controls.Add(Me.W_DOBDateTimePicker)
        Me.GroupBox1.Controls.Add(W_JoinDateLabel)
        Me.GroupBox1.Controls.Add(Me.W_JoinDateDateTimePicker)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(39, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 495)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Worker:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(265, 417)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 34)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lime
        Me.Button2.Location = New System.Drawing.Point(137, 417)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 34)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "UPDATE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(6, 417)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 34)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'W_IDTextBox
        '
        Me.W_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkerRegistrationBindingSource, "W_ID", True))
        Me.W_IDTextBox.Location = New System.Drawing.Point(150, 106)
        Me.W_IDTextBox.Name = "W_IDTextBox"
        Me.W_IDTextBox.Size = New System.Drawing.Size(200, 26)
        Me.W_IDTextBox.TabIndex = 1
        '
        'WorkerRegistrationBindingSource
        '
        Me.WorkerRegistrationBindingSource.DataMember = "WorkerRegistration"
        Me.WorkerRegistrationBindingSource.DataSource = Me.BricksProductionDataSet1
        '
        'BricksProductionDataSet1
        '
        Me.BricksProductionDataSet1.DataSetName = "BricksProductionDataSet1"
        Me.BricksProductionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'W_NameTextBox
        '
        Me.W_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkerRegistrationBindingSource, "W_Name", True))
        Me.W_NameTextBox.Location = New System.Drawing.Point(150, 138)
        Me.W_NameTextBox.Name = "W_NameTextBox"
        Me.W_NameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.W_NameTextBox.TabIndex = 3
        '
        'W_AddressTextBox
        '
        Me.W_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkerRegistrationBindingSource, "W_Address", True))
        Me.W_AddressTextBox.Location = New System.Drawing.Point(150, 170)
        Me.W_AddressTextBox.Name = "W_AddressTextBox"
        Me.W_AddressTextBox.Size = New System.Drawing.Size(200, 26)
        Me.W_AddressTextBox.TabIndex = 5
        '
        'W_MobileTextBox
        '
        Me.W_MobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkerRegistrationBindingSource, "W_Mobile", True))
        Me.W_MobileTextBox.Location = New System.Drawing.Point(150, 202)
        Me.W_MobileTextBox.MaxLength = 10
        Me.W_MobileTextBox.Name = "W_MobileTextBox"
        Me.W_MobileTextBox.Size = New System.Drawing.Size(200, 26)
        Me.W_MobileTextBox.TabIndex = 7
        '
        'W_TypeTextBox
        '
        Me.W_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkerRegistrationBindingSource, "W_Type", True))
        Me.W_TypeTextBox.Location = New System.Drawing.Point(150, 234)
        Me.W_TypeTextBox.Name = "W_TypeTextBox"
        Me.W_TypeTextBox.Size = New System.Drawing.Size(200, 26)
        Me.W_TypeTextBox.TabIndex = 9
        '
        'W_SalaryTextBox
        '
        Me.W_SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkerRegistrationBindingSource, "W_Salary", True))
        Me.W_SalaryTextBox.Location = New System.Drawing.Point(150, 266)
        Me.W_SalaryTextBox.Name = "W_SalaryTextBox"
        Me.W_SalaryTextBox.Size = New System.Drawing.Size(200, 26)
        Me.W_SalaryTextBox.TabIndex = 11
        '
        'W_DOBDateTimePicker
        '
        Me.W_DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WorkerRegistrationBindingSource, "W_DOB", True))
        Me.W_DOBDateTimePicker.Location = New System.Drawing.Point(150, 298)
        Me.W_DOBDateTimePicker.Name = "W_DOBDateTimePicker"
        Me.W_DOBDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.W_DOBDateTimePicker.TabIndex = 13
        '
        'W_JoinDateDateTimePicker
        '
        Me.W_JoinDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WorkerRegistrationBindingSource, "W_JoinDate", True))
        Me.W_JoinDateDateTimePicker.Location = New System.Drawing.Point(150, 330)
        Me.W_JoinDateDateTimePicker.Name = "W_JoinDateDateTimePicker"
        Me.W_JoinDateDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.W_JoinDateDateTimePicker.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.WorkerRegistrationDataGridView)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(479, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(848, 498)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Worker Database:"
        '
        'WorkerRegistrationDataGridView
        '
        Me.WorkerRegistrationDataGridView.AutoGenerateColumns = False
        Me.WorkerRegistrationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WorkerRegistrationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.WorkerRegistrationDataGridView.DataSource = Me.WorkerRegistrationBindingSource
        Me.WorkerRegistrationDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkerRegistrationDataGridView.Location = New System.Drawing.Point(3, 22)
        Me.WorkerRegistrationDataGridView.Name = "WorkerRegistrationDataGridView"
        Me.WorkerRegistrationDataGridView.Size = New System.Drawing.Size(842, 473)
        Me.WorkerRegistrationDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "W_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "W_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "W_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "W_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "W_Address"
        Me.DataGridViewTextBoxColumn3.HeaderText = "W_Address"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "W_Mobile"
        Me.DataGridViewTextBoxColumn4.HeaderText = "W_Mobile"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "W_Type"
        Me.DataGridViewTextBoxColumn5.HeaderText = "W_Type"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "W_Salary"
        Me.DataGridViewTextBoxColumn6.HeaderText = "W_Salary"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "W_DOB"
        Me.DataGridViewTextBoxColumn7.HeaderText = "W_DOB"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "W_JoinDate"
        Me.DataGridViewTextBoxColumn8.HeaderText = "W_JoinDate"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'WorkerRegistrationTableAdapter
        '
        Me.WorkerRegistrationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminLoginTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BillTableAdapter = Nothing
        Me.TableAdapterManager.CustomerDetailsTableAdapter = Nothing
        Me.TableAdapterManager.Material_SupplyTableAdapter = Nothing
        Me.TableAdapterManager.Material_TableTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.SalaryReceiptTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BricksManagement.BricksProductionDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WorkerRegistrationTableAdapter = Me.WorkerRegistrationTableAdapter
        Me.TableAdapterManager.WSalaryTableAdapter = Nothing
        '
        'WorkerRegistrationBindingNavigator
        '
        Me.WorkerRegistrationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.WorkerRegistrationBindingNavigator.BindingSource = Me.WorkerRegistrationBindingSource
        Me.WorkerRegistrationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.WorkerRegistrationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.WorkerRegistrationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.WorkerRegistrationBindingNavigatorSaveItem})
        Me.WorkerRegistrationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.WorkerRegistrationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.WorkerRegistrationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.WorkerRegistrationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.WorkerRegistrationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.WorkerRegistrationBindingNavigator.Name = "WorkerRegistrationBindingNavigator"
        Me.WorkerRegistrationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.WorkerRegistrationBindingNavigator.Size = New System.Drawing.Size(1339, 25)
        Me.WorkerRegistrationBindingNavigator.TabIndex = 2
        Me.WorkerRegistrationBindingNavigator.Text = "BindingNavigator1"
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
        'WorkerRegistrationBindingNavigatorSaveItem
        '
        Me.WorkerRegistrationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.WorkerRegistrationBindingNavigatorSaveItem.Image = CType(resources.GetObject("WorkerRegistrationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.WorkerRegistrationBindingNavigatorSaveItem.Name = "WorkerRegistrationBindingNavigatorSaveItem"
        Me.WorkerRegistrationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.WorkerRegistrationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gray
        Me.Button4.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(12, 37)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 38)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "BACK"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.LightGray
        Me.Label17.Font = New System.Drawing.Font("Algerian", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(453, 37)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(436, 35)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "        WORKER  DETAILS       "
        '
        'ViewWorkers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1339, 599)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.WorkerRegistrationBindingNavigator)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ViewWorkers"
        Me.Text = "ViewWorkers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.WorkerRegistrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BricksProductionDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.WorkerRegistrationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkerRegistrationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkerRegistrationBindingNavigator.ResumeLayout(False)
        Me.WorkerRegistrationBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BricksProductionDataSet1 As BricksProductionDataSet1
    Friend WithEvents WorkerRegistrationBindingSource As BindingSource
    Friend WithEvents WorkerRegistrationTableAdapter As BricksProductionDataSet1TableAdapters.WorkerRegistrationTableAdapter
    Friend WithEvents TableAdapterManager As BricksProductionDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents WorkerRegistrationBindingNavigator As BindingNavigator
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
    Friend WithEvents WorkerRegistrationBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents W_IDTextBox As TextBox
    Friend WithEvents W_NameTextBox As TextBox
    Friend WithEvents W_AddressTextBox As TextBox
    Friend WithEvents W_MobileTextBox As TextBox
    Friend WithEvents W_TypeTextBox As TextBox
    Friend WithEvents W_SalaryTextBox As TextBox
    Friend WithEvents W_DOBDateTimePicker As DateTimePicker
    Friend WithEvents W_JoinDateDateTimePicker As DateTimePicker
    Friend WithEvents WorkerRegistrationDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label17 As Label
End Class
