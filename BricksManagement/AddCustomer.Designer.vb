<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCustomer))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Current_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BricksProductionDataSet1 = New BricksManagement.BricksProductionDataSet1()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.C_NameTextBox = New System.Windows.Forms.TextBox()
        Me.C_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.C_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.C_MobileTextBox = New System.Windows.Forms.TextBox()
        Me.C_CostTextBox = New System.Windows.Forms.TextBox()
        Me.C_countTextBox = New System.Windows.Forms.TextBox()
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
        Me.ProductTableAdapter = New BricksManagement.BricksProductionDataSet1TableAdapters.ProductTableAdapter()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.CustomerDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BricksProductionDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerDetailsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1302, 659)
        Me.Panel1.TabIndex = 9
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(152, 531)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(277, 52)
        Me.Button4.TabIndex = 53
        Me.Button4.Text = "ADD NEW"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightGray
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1164, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 18)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "DATE"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(789, 528)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(413, 52)
        Me.Button3.TabIndex = 50
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Location = New System.Drawing.Point(789, 103)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(413, 425)
        Me.Panel3.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Gainsboro
        Me.Label9.Font = New System.Drawing.Font("Algerian", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(1, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(408, 32)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "             BILL RECEIPT            "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(190, 406)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 12)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "(B_ID)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(141, 406)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 12)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 406)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 12)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "TOTAL AMOUNT PAID:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(3, 47)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(405, 356)
        Me.TextBox2.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(691, 290)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 58)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "Generate  Bill"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(13, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 32)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(427, 531)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(261, 52)
        Me.Button8.TabIndex = 17
        Me.Button8.Text = "SAVE"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Current_PriceTextBox)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.IDTextBox)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.C_NameTextBox)
        Me.Panel2.Controls.Add(Me.C_DateDateTimePicker)
        Me.Panel2.Controls.Add(Me.C_AddressTextBox)
        Me.Panel2.Controls.Add(Me.C_MobileTextBox)
        Me.Panel2.Controls.Add(Me.C_CostTextBox)
        Me.Panel2.Controls.Add(Me.C_countTextBox)
        Me.Panel2.Location = New System.Drawing.Point(154, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(533, 432)
        Me.Panel2.TabIndex = 48
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(251, 41)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(264, 26)
        Me.TextBox3.TabIndex = 48
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(17, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(154, 22)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "SEARCH BY ID:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 145)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(200, 22)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "*Customer Address :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 107)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(171, 22)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "*Customer Name:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 184)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(208, 22)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "*Customer Mobile No:"
        '
        'Current_PriceTextBox
        '
        Me.Current_PriceTextBox.BackColor = System.Drawing.Color.White
        Me.Current_PriceTextBox.Cursor = System.Windows.Forms.Cursors.No
        Me.Current_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDetailsBindingSource, "Current_Price", True))
        Me.Current_PriceTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Current_PriceTextBox.ForeColor = System.Drawing.Color.Black
        Me.Current_PriceTextBox.Location = New System.Drawing.Point(254, 287)
        Me.Current_PriceTextBox.Name = "Current_PriceTextBox"
        Me.Current_PriceTextBox.ReadOnly = True
        Me.Current_PriceTextBox.Size = New System.Drawing.Size(262, 26)
        Me.Current_PriceTextBox.TabIndex = 41
        '
        'CustomerDetailsBindingSource
        '
        Me.CustomerDetailsBindingSource.DataMember = "CustomerDetails"
        Me.CustomerDetailsBindingSource.DataSource = Me.BricksProductionDataSet1
        '
        'BricksProductionDataSet1
        '
        Me.BricksProductionDataSet1.DataSetName = "BricksProductionDataSet1"
        Me.BricksProductionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(14, 291)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(157, 22)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "*Current_Price :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 323)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 22)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "*Count :"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(253, 254)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(262, 26)
        Me.TextBox1.TabIndex = 46
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Gainsboro
        Me.Label17.Font = New System.Drawing.Font("Algerian", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(1, 3)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(529, 32)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "          CUSTOMER REGISTRATION        "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 352)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 22)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "*Cost :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 22)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "*Item Size:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 22)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "*Item_Name  :"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ProductBindingSource
        Me.ComboBox1.DisplayMember = "Product_name"
        Me.ComboBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(254, 219)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(259, 26)
        Me.ComboBox1.TabIndex = 44
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.BricksProductionDataSet1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 22)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "*ID :"
        '
        'IDTextBox
        '
        Me.IDTextBox.BackColor = System.Drawing.Color.White
        Me.IDTextBox.Cursor = System.Windows.Forms.Cursors.No
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDetailsBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.ForeColor = System.Drawing.Color.Black
        Me.IDTextBox.Location = New System.Drawing.Point(254, 76)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(262, 26)
        Me.IDTextBox.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 393)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 22)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "*Date :"
        '
        'C_NameTextBox
        '
        Me.C_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDetailsBindingSource, "C_Name", True))
        Me.C_NameTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_NameTextBox.Location = New System.Drawing.Point(254, 109)
        Me.C_NameTextBox.Name = "C_NameTextBox"
        Me.C_NameTextBox.Size = New System.Drawing.Size(262, 26)
        Me.C_NameTextBox.TabIndex = 29
        '
        'C_DateDateTimePicker
        '
        Me.C_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerDetailsBindingSource, "C_Date", True))
        Me.C_DateDateTimePicker.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_DateDateTimePicker.Location = New System.Drawing.Point(254, 389)
        Me.C_DateDateTimePicker.Name = "C_DateDateTimePicker"
        Me.C_DateDateTimePicker.Size = New System.Drawing.Size(262, 26)
        Me.C_DateDateTimePicker.TabIndex = 43
        '
        'C_AddressTextBox
        '
        Me.C_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDetailsBindingSource, "C_Address", True))
        Me.C_AddressTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_AddressTextBox.Location = New System.Drawing.Point(254, 144)
        Me.C_AddressTextBox.Name = "C_AddressTextBox"
        Me.C_AddressTextBox.Size = New System.Drawing.Size(262, 26)
        Me.C_AddressTextBox.TabIndex = 31
        '
        'C_MobileTextBox
        '
        Me.C_MobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDetailsBindingSource, "C_Mobile", True))
        Me.C_MobileTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_MobileTextBox.Location = New System.Drawing.Point(254, 181)
        Me.C_MobileTextBox.MaxLength = 10
        Me.C_MobileTextBox.Name = "C_MobileTextBox"
        Me.C_MobileTextBox.Size = New System.Drawing.Size(262, 26)
        Me.C_MobileTextBox.TabIndex = 33
        '
        'C_CostTextBox
        '
        Me.C_CostTextBox.BackColor = System.Drawing.Color.White
        Me.C_CostTextBox.Cursor = System.Windows.Forms.Cursors.No
        Me.C_CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDetailsBindingSource, "C_Cost", True))
        Me.C_CostTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_CostTextBox.ForeColor = System.Drawing.Color.Black
        Me.C_CostTextBox.Location = New System.Drawing.Point(254, 351)
        Me.C_CostTextBox.Name = "C_CostTextBox"
        Me.C_CostTextBox.ReadOnly = True
        Me.C_CostTextBox.Size = New System.Drawing.Size(262, 26)
        Me.C_CostTextBox.TabIndex = 39
        '
        'C_countTextBox
        '
        Me.C_countTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDetailsBindingSource, "C_count", True))
        Me.C_countTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_countTextBox.Location = New System.Drawing.Point(254, 319)
        Me.C_countTextBox.Name = "C_countTextBox"
        Me.C_countTextBox.Size = New System.Drawing.Size(262, 26)
        Me.C_countTextBox.TabIndex = 37
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
        Me.CustomerDetailsBindingNavigator.Size = New System.Drawing.Size(1302, 25)
        Me.CustomerDetailsBindingNavigator.TabIndex = 10
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
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'AddCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1302, 659)
        Me.Controls.Add(Me.CustomerDetailsBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AddCustomer"
        Me.Text = "AddCustomer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.CustomerDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BricksProductionDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerDetailsBindingNavigator.ResumeLayout(False)
        Me.CustomerDetailsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents C_NameTextBox As TextBox
    Friend WithEvents C_AddressTextBox As TextBox
    Friend WithEvents C_MobileTextBox As TextBox
    Friend WithEvents C_countTextBox As TextBox
    Friend WithEvents C_CostTextBox As TextBox
    Friend WithEvents Current_PriceTextBox As TextBox
    Friend WithEvents C_DateDateTimePicker As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As BricksProductionDataSet1TableAdapters.ProductTableAdapter
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button4 As Button
End Class
