<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WorkerSalary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WorkerSalary))
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.W_IDTextBox = New System.Windows.Forms.TextBox()
        Me.WSalaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BricksProductionDataSet1 = New BricksManagement.BricksProductionDataSet1()
        Me.W__NameTextBox = New System.Windows.Forms.TextBox()
        Me.W__AddressTextBox = New System.Windows.Forms.TextBox()
        Me.W__MobileTextBox = New System.Windows.Forms.TextBox()
        Me.W__SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.W_PaidTextBox = New System.Windows.Forms.TextBox()
        Me.Paid_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.W_RemainingTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.WSalaryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.WSalaryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.WSalaryTableAdapter = New BricksManagement.BricksProductionDataSet1TableAdapters.WSalaryTableAdapter()
        Me.TableAdapterManager = New BricksManagement.BricksProductionDataSet1TableAdapters.TableAdapterManager()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        CType(Me.WSalaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BricksProductionDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.WSalaryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WSalaryBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(318, 464)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(206, 44)
        Me.Button8.TabIndex = 17
        Me.Button8.Text = "SAVE"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(162, 317)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 22)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "*Salary :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(162, 383)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(178, 22)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "*Remainig Salary :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(162, 354)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 22)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "*Paid:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(162, 416)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 22)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "*Paid_Date :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(162, 282)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(186, 22)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "*Worker Mobile No:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(162, 243)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(178, 22)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "*Worker Address :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(162, 205)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(149, 22)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "*Worker Name:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(163, 172)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(121, 22)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "*Worker ID :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Algerian", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(619, 40)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(245, 30)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "SALARY DETAILS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.W_IDTextBox)
        Me.Panel1.Controls.Add(Me.W__NameTextBox)
        Me.Panel1.Controls.Add(Me.W__AddressTextBox)
        Me.Panel1.Controls.Add(Me.W__MobileTextBox)
        Me.Panel1.Controls.Add(Me.W__SalaryTextBox)
        Me.Panel1.Controls.Add(Me.W_PaidTextBox)
        Me.Panel1.Controls.Add(Me.Paid_dateDateTimePicker)
        Me.Panel1.Controls.Add(Me.W_RemainingTextBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 566)
        Me.Panel1.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(356, 76)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(258, 29)
        Me.TextBox3.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(219, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 22)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "*SEARCH :"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Red
        Me.Button6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(157, 464)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(163, 44)
        Me.Button6.TabIndex = 44
        Me.Button6.Text = "Clear"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(843, 464)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(391, 40)
        Me.Button5.TabIndex = 43
        Me.Button5.Text = "Print"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(862, 134)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(356, 274)
        Me.TextBox1.TabIndex = 42
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(726, 239)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(93, 60)
        Me.Button4.TabIndex = 41
        Me.Button4.Text = "Generate Receipt"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(522, 464)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(173, 44)
        Me.Button3.TabIndex = 40
        Me.Button3.Text = "UPDATE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(615, 350)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 28)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Show"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 35)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'W_IDTextBox
        '
        Me.W_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSalaryBindingSource, "W_ID", True))
        Me.W_IDTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W_IDTextBox.Location = New System.Drawing.Point(417, 167)
        Me.W_IDTextBox.Name = "W_IDTextBox"
        Me.W_IDTextBox.Size = New System.Drawing.Size(258, 25)
        Me.W_IDTextBox.TabIndex = 23
        '
        'WSalaryBindingSource
        '
        Me.WSalaryBindingSource.DataMember = "WSalary"
        Me.WSalaryBindingSource.DataSource = Me.BricksProductionDataSet1
        '
        'BricksProductionDataSet1
        '
        Me.BricksProductionDataSet1.DataSetName = "BricksProductionDataSet1"
        Me.BricksProductionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'W__NameTextBox
        '
        Me.W__NameTextBox.BackColor = System.Drawing.Color.White
        Me.W__NameTextBox.Cursor = System.Windows.Forms.Cursors.No
        Me.W__NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSalaryBindingSource, "W__Name", True))
        Me.W__NameTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W__NameTextBox.ForeColor = System.Drawing.Color.Black
        Me.W__NameTextBox.Location = New System.Drawing.Point(417, 201)
        Me.W__NameTextBox.Name = "W__NameTextBox"
        Me.W__NameTextBox.ReadOnly = True
        Me.W__NameTextBox.Size = New System.Drawing.Size(258, 25)
        Me.W__NameTextBox.TabIndex = 25
        '
        'W__AddressTextBox
        '
        Me.W__AddressTextBox.BackColor = System.Drawing.Color.White
        Me.W__AddressTextBox.Cursor = System.Windows.Forms.Cursors.No
        Me.W__AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSalaryBindingSource, "W__Address", True))
        Me.W__AddressTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W__AddressTextBox.ForeColor = System.Drawing.Color.Black
        Me.W__AddressTextBox.Location = New System.Drawing.Point(417, 237)
        Me.W__AddressTextBox.Name = "W__AddressTextBox"
        Me.W__AddressTextBox.ReadOnly = True
        Me.W__AddressTextBox.Size = New System.Drawing.Size(258, 25)
        Me.W__AddressTextBox.TabIndex = 27
        '
        'W__MobileTextBox
        '
        Me.W__MobileTextBox.BackColor = System.Drawing.Color.White
        Me.W__MobileTextBox.Cursor = System.Windows.Forms.Cursors.No
        Me.W__MobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSalaryBindingSource, "W__Mobile", True))
        Me.W__MobileTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W__MobileTextBox.ForeColor = System.Drawing.Color.Black
        Me.W__MobileTextBox.Location = New System.Drawing.Point(417, 274)
        Me.W__MobileTextBox.MaxLength = 10
        Me.W__MobileTextBox.Name = "W__MobileTextBox"
        Me.W__MobileTextBox.ReadOnly = True
        Me.W__MobileTextBox.Size = New System.Drawing.Size(258, 25)
        Me.W__MobileTextBox.TabIndex = 29
        '
        'W__SalaryTextBox
        '
        Me.W__SalaryTextBox.BackColor = System.Drawing.Color.White
        Me.W__SalaryTextBox.Cursor = System.Windows.Forms.Cursors.No
        Me.W__SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSalaryBindingSource, "W__Salary", True))
        Me.W__SalaryTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W__SalaryTextBox.ForeColor = System.Drawing.Color.Black
        Me.W__SalaryTextBox.Location = New System.Drawing.Point(417, 313)
        Me.W__SalaryTextBox.Name = "W__SalaryTextBox"
        Me.W__SalaryTextBox.ReadOnly = True
        Me.W__SalaryTextBox.Size = New System.Drawing.Size(258, 25)
        Me.W__SalaryTextBox.TabIndex = 31
        '
        'W_PaidTextBox
        '
        Me.W_PaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSalaryBindingSource, "W_Paid", True))
        Me.W_PaidTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W_PaidTextBox.Location = New System.Drawing.Point(417, 351)
        Me.W_PaidTextBox.Name = "W_PaidTextBox"
        Me.W_PaidTextBox.Size = New System.Drawing.Size(201, 25)
        Me.W_PaidTextBox.TabIndex = 33
        '
        'Paid_dateDateTimePicker
        '
        Me.Paid_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WSalaryBindingSource, "Paid_date", True))
        Me.Paid_dateDateTimePicker.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Paid_dateDateTimePicker.Location = New System.Drawing.Point(417, 414)
        Me.Paid_dateDateTimePicker.Name = "Paid_dateDateTimePicker"
        Me.Paid_dateDateTimePicker.Size = New System.Drawing.Size(258, 25)
        Me.Paid_dateDateTimePicker.TabIndex = 35
        '
        'W_RemainingTextBox
        '
        Me.W_RemainingTextBox.BackColor = System.Drawing.Color.White
        Me.W_RemainingTextBox.Cursor = System.Windows.Forms.Cursors.No
        Me.W_RemainingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSalaryBindingSource, "W_Remaining", True))
        Me.W_RemainingTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W_RemainingTextBox.ForeColor = System.Drawing.Color.Black
        Me.W_RemainingTextBox.Location = New System.Drawing.Point(417, 383)
        Me.W_RemainingTextBox.Name = "W_RemainingTextBox"
        Me.W_RemainingTextBox.Size = New System.Drawing.Size(258, 25)
        Me.W_RemainingTextBox.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(165, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 22)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "*ID :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Location = New System.Drawing.Point(157, 113)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(537, 351)
        Me.Panel2.TabIndex = 45
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSalaryBindingSource, "W_ID", True))
        Me.TextBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(259, 21)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(258, 25)
        Me.TextBox2.TabIndex = 48
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(843, 113)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(391, 351)
        Me.Panel3.TabIndex = 46
        '
        'WSalaryBindingNavigator
        '
        Me.WSalaryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.WSalaryBindingNavigator.BindingSource = Me.WSalaryBindingSource
        Me.WSalaryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.WSalaryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.WSalaryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.WSalaryBindingNavigatorSaveItem})
        Me.WSalaryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.WSalaryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.WSalaryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.WSalaryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.WSalaryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.WSalaryBindingNavigator.Name = "WSalaryBindingNavigator"
        Me.WSalaryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.WSalaryBindingNavigator.Size = New System.Drawing.Size(1370, 25)
        Me.WSalaryBindingNavigator.TabIndex = 7
        Me.WSalaryBindingNavigator.Text = "BindingNavigator1"
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
        'WSalaryBindingNavigatorSaveItem
        '
        Me.WSalaryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.WSalaryBindingNavigatorSaveItem.Image = CType(resources.GetObject("WSalaryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.WSalaryBindingNavigatorSaveItem.Name = "WSalaryBindingNavigatorSaveItem"
        Me.WSalaryBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.WSalaryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'WSalaryTableAdapter
        '
        Me.WSalaryTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.WorkerRegistrationTableAdapter = Nothing
        Me.TableAdapterManager.WSalaryTableAdapter = Me.WSalaryTableAdapter
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'WorkerSalary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 566)
        Me.Controls.Add(Me.WSalaryBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.HelpButton = True
        Me.Location = New System.Drawing.Point(1000, 1000)
        Me.Name = "WorkerSalary"
        Me.Text = "WorkerSalary"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.WSalaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BricksProductionDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.WSalaryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WSalaryBindingNavigator.ResumeLayout(False)
        Me.WSalaryBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button8 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BricksProductionDataSet1 As BricksProductionDataSet1
    Friend WithEvents WSalaryBindingSource As BindingSource
    Friend WithEvents WSalaryTableAdapter As BricksProductionDataSet1TableAdapters.WSalaryTableAdapter
    Friend WithEvents TableAdapterManager As BricksProductionDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents WSalaryBindingNavigator As BindingNavigator
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
    Friend WithEvents WSalaryBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents W_IDTextBox As TextBox
    Friend WithEvents W__NameTextBox As TextBox
    Friend WithEvents W__AddressTextBox As TextBox
    Friend WithEvents W__MobileTextBox As TextBox
    Friend WithEvents W__SalaryTextBox As TextBox
    Friend WithEvents W_PaidTextBox As TextBox
    Friend WithEvents Paid_dateDateTimePicker As DateTimePicker
    Friend WithEvents W_RemainingTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
