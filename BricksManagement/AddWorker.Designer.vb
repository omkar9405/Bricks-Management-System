<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddWorker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddWorker))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.W_IDTextBox = New System.Windows.Forms.TextBox()
        Me.WorkerRegistrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BricksProductionDataSet1 = New BricksManagement.BricksProductionDataSet1()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.W_MobileTextBox = New System.Windows.Forms.TextBox()
        Me.W_NameTextBox = New System.Windows.Forms.TextBox()
        Me.W_JoinDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.W_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.W_DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.W_SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.W_TypeTextBox = New System.Windows.Forms.TextBox()
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
        W_IDLabel = New System.Windows.Forms.Label()
        W_NameLabel = New System.Windows.Forms.Label()
        W_AddressLabel = New System.Windows.Forms.Label()
        W_MobileLabel = New System.Windows.Forms.Label()
        W_TypeLabel = New System.Windows.Forms.Label()
        W_SalaryLabel = New System.Windows.Forms.Label()
        W_DOBLabel = New System.Windows.Forms.Label()
        W_JoinDateLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.WorkerRegistrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BricksProductionDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkerRegistrationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkerRegistrationBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'W_IDLabel
        '
        W_IDLabel.AutoSize = True
        W_IDLabel.BackColor = System.Drawing.Color.Transparent
        W_IDLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        W_IDLabel.Location = New System.Drawing.Point(100, 92)
        W_IDLabel.Name = "W_IDLabel"
        W_IDLabel.Size = New System.Drawing.Size(56, 18)
        W_IDLabel.TabIndex = 19
        W_IDLabel.Text = "*W ID:"
        '
        'W_NameLabel
        '
        W_NameLabel.AutoSize = True
        W_NameLabel.BackColor = System.Drawing.Color.Transparent
        W_NameLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        W_NameLabel.Location = New System.Drawing.Point(100, 126)
        W_NameLabel.Name = "W_NameLabel"
        W_NameLabel.Size = New System.Drawing.Size(85, 18)
        W_NameLabel.TabIndex = 21
        W_NameLabel.Text = "*W Name:"
        '
        'W_AddressLabel
        '
        W_AddressLabel.AutoSize = True
        W_AddressLabel.BackColor = System.Drawing.Color.Transparent
        W_AddressLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        W_AddressLabel.Location = New System.Drawing.Point(100, 160)
        W_AddressLabel.Name = "W_AddressLabel"
        W_AddressLabel.Size = New System.Drawing.Size(106, 18)
        W_AddressLabel.TabIndex = 23
        W_AddressLabel.Text = "*W Address:"
        '
        'W_MobileLabel
        '
        W_MobileLabel.AutoSize = True
        W_MobileLabel.BackColor = System.Drawing.Color.Transparent
        W_MobileLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        W_MobileLabel.Location = New System.Drawing.Point(100, 194)
        W_MobileLabel.Name = "W_MobileLabel"
        W_MobileLabel.Size = New System.Drawing.Size(90, 18)
        W_MobileLabel.TabIndex = 25
        W_MobileLabel.Text = "*W Mobile:"
        '
        'W_TypeLabel
        '
        W_TypeLabel.AutoSize = True
        W_TypeLabel.BackColor = System.Drawing.Color.Transparent
        W_TypeLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        W_TypeLabel.Location = New System.Drawing.Point(100, 228)
        W_TypeLabel.Name = "W_TypeLabel"
        W_TypeLabel.Size = New System.Drawing.Size(78, 18)
        W_TypeLabel.TabIndex = 27
        W_TypeLabel.Text = "*W Type:"
        '
        'W_SalaryLabel
        '
        W_SalaryLabel.AutoSize = True
        W_SalaryLabel.BackColor = System.Drawing.Color.Transparent
        W_SalaryLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        W_SalaryLabel.Location = New System.Drawing.Point(100, 262)
        W_SalaryLabel.Name = "W_SalaryLabel"
        W_SalaryLabel.Size = New System.Drawing.Size(90, 18)
        W_SalaryLabel.TabIndex = 29
        W_SalaryLabel.Text = "*W Salary:"
        '
        'W_DOBLabel
        '
        W_DOBLabel.AutoSize = True
        W_DOBLabel.BackColor = System.Drawing.Color.Transparent
        W_DOBLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        W_DOBLabel.Location = New System.Drawing.Point(100, 297)
        W_DOBLabel.Name = "W_DOBLabel"
        W_DOBLabel.Size = New System.Drawing.Size(76, 18)
        W_DOBLabel.TabIndex = 31
        W_DOBLabel.Text = "*W DOB:"
        '
        'W_JoinDateLabel
        '
        W_JoinDateLabel.AutoSize = True
        W_JoinDateLabel.BackColor = System.Drawing.Color.Transparent
        W_JoinDateLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        W_JoinDateLabel.Location = New System.Drawing.Point(100, 332)
        W_JoinDateLabel.Name = "W_JoinDateLabel"
        W_JoinDateLabel.Size = New System.Drawing.Size(114, 18)
        W_JoinDateLabel.TabIndex = 33
        W_JoinDateLabel.Text = "*W Join Date:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1219, 578)
        Me.Panel1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 32)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(W_IDLabel)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.W_IDTextBox)
        Me.Panel2.Controls.Add(W_NameLabel)
        Me.Panel2.Controls.Add(Me.W_MobileTextBox)
        Me.Panel2.Controls.Add(Me.W_NameTextBox)
        Me.Panel2.Controls.Add(Me.W_JoinDateDateTimePicker)
        Me.Panel2.Controls.Add(W_AddressLabel)
        Me.Panel2.Controls.Add(W_JoinDateLabel)
        Me.Panel2.Controls.Add(Me.W_AddressTextBox)
        Me.Panel2.Controls.Add(Me.W_DOBDateTimePicker)
        Me.Panel2.Controls.Add(W_MobileLabel)
        Me.Panel2.Controls.Add(W_DOBLabel)
        Me.Panel2.Controls.Add(Me.W_SalaryTextBox)
        Me.Panel2.Controls.Add(W_TypeLabel)
        Me.Panel2.Controls.Add(W_SalaryLabel)
        Me.Panel2.Controls.Add(Me.W_TypeTextBox)
        Me.Panel2.Location = New System.Drawing.Point(371, 98)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(533, 373)
        Me.Panel2.TabIndex = 36
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.LightGray
        Me.Label17.Font = New System.Drawing.Font("Algerian", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(-2, 3)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(534, 35)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "        WORKER  REGISTRATION       "
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(371, 470)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(280, 55)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "ADD NEW"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'W_IDTextBox
        '
        Me.W_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkerRegistrationBindingSource, "W_ID", True))
        Me.W_IDTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W_IDTextBox.Location = New System.Drawing.Point(240, 89)
        Me.W_IDTextBox.Name = "W_IDTextBox"
        Me.W_IDTextBox.ReadOnly = True
        Me.W_IDTextBox.Size = New System.Drawing.Size(200, 29)
        Me.W_IDTextBox.TabIndex = 20
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
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(649, 470)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(255, 55)
        Me.Button8.TabIndex = 17
        Me.Button8.Text = "SAVE"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'W_MobileTextBox
        '
        Me.W_MobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkerRegistrationBindingSource, "W_Mobile", True))
        Me.W_MobileTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W_MobileTextBox.Location = New System.Drawing.Point(240, 191)
        Me.W_MobileTextBox.MaxLength = 10
        Me.W_MobileTextBox.Name = "W_MobileTextBox"
        Me.W_MobileTextBox.Size = New System.Drawing.Size(200, 29)
        Me.W_MobileTextBox.TabIndex = 26
        '
        'W_NameTextBox
        '
        Me.W_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkerRegistrationBindingSource, "W_Name", True))
        Me.W_NameTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W_NameTextBox.Location = New System.Drawing.Point(240, 123)
        Me.W_NameTextBox.Name = "W_NameTextBox"
        Me.W_NameTextBox.Size = New System.Drawing.Size(200, 29)
        Me.W_NameTextBox.TabIndex = 22
        '
        'W_JoinDateDateTimePicker
        '
        Me.W_JoinDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WorkerRegistrationBindingSource, "W_JoinDate", True))
        Me.W_JoinDateDateTimePicker.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W_JoinDateDateTimePicker.Location = New System.Drawing.Point(240, 328)
        Me.W_JoinDateDateTimePicker.Name = "W_JoinDateDateTimePicker"
        Me.W_JoinDateDateTimePicker.Size = New System.Drawing.Size(200, 29)
        Me.W_JoinDateDateTimePicker.TabIndex = 34
        '
        'W_AddressTextBox
        '
        Me.W_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkerRegistrationBindingSource, "W_Address", True))
        Me.W_AddressTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W_AddressTextBox.Location = New System.Drawing.Point(240, 157)
        Me.W_AddressTextBox.Name = "W_AddressTextBox"
        Me.W_AddressTextBox.Size = New System.Drawing.Size(200, 29)
        Me.W_AddressTextBox.TabIndex = 24
        '
        'W_DOBDateTimePicker
        '
        Me.W_DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WorkerRegistrationBindingSource, "W_DOB", True))
        Me.W_DOBDateTimePicker.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W_DOBDateTimePicker.Location = New System.Drawing.Point(240, 293)
        Me.W_DOBDateTimePicker.Name = "W_DOBDateTimePicker"
        Me.W_DOBDateTimePicker.Size = New System.Drawing.Size(200, 29)
        Me.W_DOBDateTimePicker.TabIndex = 32
        '
        'W_SalaryTextBox
        '
        Me.W_SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkerRegistrationBindingSource, "W_Salary", True))
        Me.W_SalaryTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W_SalaryTextBox.Location = New System.Drawing.Point(240, 259)
        Me.W_SalaryTextBox.Name = "W_SalaryTextBox"
        Me.W_SalaryTextBox.Size = New System.Drawing.Size(200, 29)
        Me.W_SalaryTextBox.TabIndex = 30
        '
        'W_TypeTextBox
        '
        Me.W_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkerRegistrationBindingSource, "W_Type", True))
        Me.W_TypeTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W_TypeTextBox.Location = New System.Drawing.Point(240, 225)
        Me.W_TypeTextBox.Name = "W_TypeTextBox"
        Me.W_TypeTextBox.Size = New System.Drawing.Size(200, 29)
        Me.W_TypeTextBox.TabIndex = 28
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
        Me.WorkerRegistrationBindingNavigator.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.WorkerRegistrationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.WorkerRegistrationBindingNavigatorSaveItem})
        Me.WorkerRegistrationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.WorkerRegistrationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.WorkerRegistrationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.WorkerRegistrationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.WorkerRegistrationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.WorkerRegistrationBindingNavigator.Name = "WorkerRegistrationBindingNavigator"
        Me.WorkerRegistrationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.WorkerRegistrationBindingNavigator.Size = New System.Drawing.Size(1219, 25)
        Me.WorkerRegistrationBindingNavigator.TabIndex = 6
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
        'AddWorker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 578)
        Me.Controls.Add(Me.WorkerRegistrationBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Name = "AddWorker"
        Me.Text = "AddWorker"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.WorkerRegistrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BricksProductionDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkerRegistrationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkerRegistrationBindingNavigator.ResumeLayout(False)
        Me.WorkerRegistrationBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel1 As Panel

    Private Sub WorkerRegistrationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

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
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
End Class
