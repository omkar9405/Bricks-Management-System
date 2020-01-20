Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Imports Nest
Imports System.Drawing.Printing

Public Class AddCustomer
    Dim gst As String

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
            Dim myconnection As New OleDbConnection(connection)
            myconnection.Open()

            Dim sqlQry As String = "INSERT INTO [CustomerDetails] ([ID], [C_Name],[C_Address],[C_Mobile],[C_R_Item_name],[C_count],[C_Cost],[Current_Price],[C_Date],[C_Item_SIze]) VALUES (@ID,@C_Name,@C_Address,@C_Mobile,@C_R_Item_name,@C_count,@C_Cost,@Current_Price,@C_Date,@C_Item_SIze)"
            Dim cmd As New OleDbCommand(sqlQry, myconnection)
            cmd.Parameters.AddWithValue("@ID", IDTextBox.Text)
            cmd.Parameters.AddWithValue("@C_Name", C_NameTextBox.Text)
            cmd.Parameters.AddWithValue("@C_Address", C_AddressTextBox.Text)
            cmd.Parameters.AddWithValue("@C_Mobile", C_MobileTextBox.Text)
            cmd.Parameters.AddWithValue("@C_R_Item_name", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@C_count", C_countTextBox.Text)
            cmd.Parameters.AddWithValue("@C_Cost", C_CostTextBox.Text)
            cmd.Parameters.AddWithValue("@Current_Price", Current_PriceTextBox.Text)
            cmd.Parameters.AddWithValue("@C_Date", C_DateDateTimePicker.Text)
            cmd.Parameters.AddWithValue("@C_Item_SIze", TextBox1.Text)
            cmd.ExecuteNonQuery()
            MsgBox("SAVED")
            'Button2.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub CustomerDetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomerDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BricksProductionDataSet1)

    End Sub


    Private Sub AddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BricksProductionDataSet1.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.BricksProductionDataSet1.Product)
        'TODO: This line of code loads data into the 'BricksProductionDataSet1.CustomerDetails' table. You can move, or remove it, as needed.
        Me.CustomerDetailsTableAdapter.Fill(Me.BricksProductionDataSet1.CustomerDetails)
        Label5.Text = Date.Now.ToString("dd-MMMM-yyyy")

        Try
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
            Dim myconnection As New OleDbConnection(connection)
            Dim cmd1 As New OleDbCommand("SELECT MAX(ID) FROM CustomerDetails", myconnection)
            'cmd1.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = ComboBox1.Text
            myconnection.Open()
            Dim readerobj As OleDbDataReader = cmd1.ExecuteReader()
            readerobj.Read()
            Dim Value2
            Value2 = readerobj.GetValue(0).ToString
            IDTextBox.Text = Value2 + 1
            readerobj.Close()
            myconnection.Close()


        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        C_NameTextBox.Text = ""
        C_AddressTextBox.Text = ""
        C_MobileTextBox.Text = ""
        ComboBox1.Text = ""
        C_countTextBox.Text = ""
        TextBox1.Text = ""
        C_CostTextBox.Text = ""
        Current_PriceTextBox.Text = ""
        Try
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
            Dim myconnection As New OleDbConnection(connection)
            myconnection.Open()
            Dim cmd1 As New OleDbCommand("SELECT MAX(Bill_ID) FROM Bill", myconnection)
            Dim readerobj As OleDbDataReader = cmd1.ExecuteReader()
            readerobj.Read()
            Dim Value1
            Value1 = readerobj.GetValue(0).ToString
            Label8.Text = Value1 + 1

            readerobj.Close()
            myconnection.Close()

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
            Dim myconnection As New OleDbConnection(connection)
            Dim cmd1 As New OleDbCommand("SELECT Product_Price,Product_Size FROM Product WHERE Product_name=? ", myconnection)
            cmd1.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = ComboBox1.Text
            myconnection.Open()
            Dim readerobj As OleDbDataReader = cmd1.ExecuteReader()
            readerobj.Read()
            Current_PriceTextBox.Text = readerobj.GetValue(0).ToString
            TextBox1.Text = readerobj.GetValue(1).ToString
            readerobj.Close()
            myconnection.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("arial", 16, FontStyle.Regular)
        e.Graphics.DrawString(TextBox2.Text, font1, Brushes.Black, 100, 100)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PrintDocument1.Print()

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs)
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            TextBox2.Text = ""
            TextBox2.AppendText("      RAJLAXMI BRICKS SUPPLIERS,SANGALI    " + vbNewLine)

            TextBox2.AppendText(vbNewLine + "Receipt ID :" + Label8.Text + "       Date:" + Label5.Text + vbNewLine)
            TextBox2.AppendText(vbNewLine + "Customer ID :" + IDTextBox.Text)
            TextBox2.AppendText(vbNewLine + "Customer Name :" + C_NameTextBox.Text + vbNewLine)
            TextBox2.AppendText("|===========================================|" + vbNewLine)
            TextBox2.AppendText(vbTab + "Item Name  : " + ComboBox1.Text + vbNewLine)
            TextBox2.AppendText(vbTab + "Item Size  : " + TextBox1.Text + vbNewLine)
            TextBox2.AppendText(vbTab + "Item Price : " + Current_PriceTextBox.Text + vbNewLine)
            TextBox2.AppendText(vbTab + "Count      : " + C_countTextBox.Text + vbNewLine)
            TextBox2.AppendText(vbTab + "Total Price: " + C_CostTextBox.Text + vbNewLine)
            TextBox2.AppendText("                                           " + vbNewLine)

            gst = (5 / 100) * C_CostTextBox.Text
            TextBox2.AppendText(vbTab + "  GST(5%)  : " + gst + vbNewLine)
            TextBox2.AppendText("|-----------------------------------------------------------------------------|" + vbNewLine)

            Label7.Text = C_CostTextBox.Text + (5 / 100) * C_CostTextBox.Text
            TextBox2.AppendText(vbTab + "Total Payable Ammount:" + Label7.Text + vbNewLine)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        Dim cs As Integer
        cs = (gst / 2)
        Try
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
            Dim myconnection As New OleDbConnection(connection)
            myconnection.Open()

            Dim sqlQry As String = "INSERT INTO [Bill] ([Bill_ID], [Bill_Date],[Customer_ID],[Customer_Name],[Item_Name],[Item_Size],[Item_Price],[Count],[Total_Price],[CGST],[SGST],[GST],[Paid_Amount]) VALUES (@B_ID,@B_Date,@C_ID,@C_Name,@I_Name,@I_Size,@I_Price,@Count,@T_Price,@C,@S,@G,@P_Amount)"
            Dim cmd As New OleDbCommand(sqlQry, myconnection)
            cmd.Parameters.AddWithValue("@Bill_ID", Label8.Text)
            cmd.Parameters.AddWithValue("@B_Date", Label5.Text)
            cmd.Parameters.AddWithValue("@C_ID", IDTextBox.Text)
            cmd.Parameters.AddWithValue("@C_Name", C_NameTextBox.Text)
            cmd.Parameters.AddWithValue("@I_Name", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@I_Size", TextBox1.Text)
            cmd.Parameters.AddWithValue("@I_Price", Current_PriceTextBox.Text)
            cmd.Parameters.AddWithValue("@Count", C_countTextBox.Text)
            cmd.Parameters.AddWithValue("@T_Price", C_CostTextBox.Text)
            cmd.Parameters.AddWithValue("@C", cs)
            cmd.Parameters.AddWithValue("@S", cs)
            cmd.Parameters.AddWithValue("@G", gst)
            cmd.Parameters.AddWithValue("@P_Amount", Label7.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Loaded..")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim HP As New HomePage
        HP.Show()
        Me.Dispose()
    End Sub



    Private Sub IDTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IDTextBox.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
            MessageBox.Show("You can only input numbers!")
        End If
    End Sub

    Private Sub C_MobileTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles C_MobileTextBox.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
            MessageBox.Show("You can only input numbers!")
        End If
    End Sub

    Private Sub C_countTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles C_countTextBox.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
            MessageBox.Show("You can only input numbers!")
        End If
    End Sub

    Private Sub C_NameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles C_NameTextBox.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("You can only input characters!")
        End If
    End Sub

    Private Sub C_AddressTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles C_AddressTextBox.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("You can only input characters!")
        End If
    End Sub

    Private Sub C_countTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles C_countTextBox.KeyUp
        Try
            C_CostTextBox.Text = C_countTextBox.Text * Current_PriceTextBox.Text
        Catch ex As Exception

        End Try
    End Sub



    Private Sub TextBox3_KeyUp_1(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyUp
        Try
            If TextBox3.Text.Equals("") Then

                Dim connection1 As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
                Dim myconnection1 As New OleDbConnection(connection1)
                Dim cmd As New OleDbCommand("SELECT MAX(ID) FROM CustomerDetails ", myconnection1)

                myconnection1.Open()
                Dim readerobj1 As OleDbDataReader = cmd.ExecuteReader()
                readerobj1.Read()
                Dim VALUE1
                VALUE1 = readerobj1.GetValue(0).ToString
                IDTextBox.Text = VALUE1 + 1
                readerobj1.Close()
                myconnection1.Close()

                C_NameTextBox.Text = ""
                C_AddressTextBox.Text = ""
                C_MobileTextBox.Text = ""
                ComboBox1.Text = ""
                C_countTextBox.Text = ""
                TextBox1.Text = ""
                C_CostTextBox.Text = ""
                Current_PriceTextBox.Text = ""

            Else
                IDTextBox.Text = TextBox3.Text
                Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
                Dim myconnection As New OleDbConnection(connection)
                Dim cmd1 As New OleDbCommand("SELECT C_Name,C_Address,C_Mobile,C_R_Item_name,C_Item_Size,C_count,C_Cost,Current_Price,C_Date FROM CustomerDetails WHERE ID=? ", myconnection)
                cmd1.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = TextBox3.Text
                myconnection.Open()
                Dim readerobj As OleDbDataReader = cmd1.ExecuteReader()
                readerobj.Read()
                C_NameTextBox.Text = readerobj.GetValue(0).ToString
                C_AddressTextBox.Text = readerobj.GetValue(1).ToString
                C_MobileTextBox.Text = readerobj.GetValue(2).ToString
                ComboBox1.Text = readerobj.GetValue(3).ToString
                TextBox1.Text = readerobj.GetValue(4).ToString
                C_countTextBox.Text = readerobj.GetValue(5).ToString
                C_CostTextBox.Text = readerobj.GetValue(6).ToString
                Current_PriceTextBox.Text = readerobj.GetValue(7).ToString
                C_DateDateTimePicker.Value = readerobj.GetValue(8).ToString
                readerobj.Close()
                myconnection.Close()


            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
            MessageBox.Show("You can only input numbers!")
        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            IDTextBox.Text = Val(IDTextBox.Text) + 1
            C_NameTextBox.Text = ""
            C_AddressTextBox.Text = ""
            C_MobileTextBox.Text = ""
            ComboBox1.Text = ""
            C_countTextBox.Text = ""
            TextBox1.Text = ""
            C_CostTextBox.Text = ""
            Current_PriceTextBox.Text = ""

        Catch ex As Exception
        End Try

    End Sub
End Class