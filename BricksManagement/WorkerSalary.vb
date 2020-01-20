Imports System.Data.OleDb
Imports System.Data
Public Class WorkerSalary
    Dim dbname As String
    Dim dbaddress As String
    Dim dbmobile As String
    Dim dbsalary As String
    Dim VALUE1
    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub WSalaryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles WSalaryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.WSalaryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BricksProductionDataSet1)

    End Sub

    Private Sub WorkerSalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BricksProductionDataSet1.WSalary' table. You can move, or remove it, as needed.
        Me.WSalaryTableAdapter.Fill(Me.BricksProductionDataSet1.WSalary)
        W_IDTextBox.Text = ""
        W__NameTextBox.Text = ""
        W__AddressTextBox.Text = ""
        W__MobileTextBox.Text = ""
        W__SalaryTextBox.Text = ""
        W_PaidTextBox.Text = ""
        W_RemainingTextBox.Text = ""

        Button4.Enabled = False
        Try
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
            Dim myconnection As New OleDbConnection(connection)
            Dim cmd1 As New OleDbCommand("SELECT MAX(ID) FROM WSalary", myconnection)

            myconnection.Open()
            Dim readerobj As OleDbDataReader = cmd1.ExecuteReader()
            readerobj.Read()
            Dim VALUE1
            VALUE1 = readerobj.GetValue(0).ToString
            TextBox2.Text = VALUE1 + 1
            readerobj.Close()
            myconnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub W__MobileLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
            Dim myconnection As New OleDbConnection(connection)
            myconnection.Open()

            Dim sqlQry As String = "INSERT INTO [WSalary] ([ID],[W_ID], [W__Name],[W__Address],[W__Mobile],[W__Salary],[W_Paid],[Paid_date],[W_Remaining]) VALUES (@id,@wid,@wname,@waddress,@wmobile,@wsalary,@wpaid,@wpaiddate,@wremaining)"
            Dim cmd As New OleDbCommand(sqlQry, myconnection)
            cmd.Parameters.AddWithValue("@id", TextBox2.Text)
            cmd.Parameters.AddWithValue("@wid", W_IDTextBox.Text)
            cmd.Parameters.AddWithValue("@wname", W__NameTextBox.Text)
            cmd.Parameters.AddWithValue("@waddress", W__AddressTextBox.Text)
            cmd.Parameters.AddWithValue("@wmobile", W__MobileTextBox.Text)
            cmd.Parameters.AddWithValue("@wsalary", W__SalaryTextBox.Text)
            cmd.Parameters.AddWithValue("@waddress", W_PaidTextBox.Text)
            cmd.Parameters.AddWithValue("@wmobile", Paid_dateDateTimePicker.Text)
            cmd.Parameters.AddWithValue("@wsalary", W_RemainingTextBox.Text)
            Button4.Enabled = True
            cmd.ExecuteNonQuery()
            MsgBox("SAVED")

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub W_IDTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles W_IDTextBox.KeyUp
        Try
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
            Dim myconnection As New OleDbConnection(connection)
                Dim cmd1 As New OleDbCommand("SELECT W_Name,W_Address,W_Mobile,W_Salary FROM WorkerRegistration WHERE W_ID=? ", myconnection)
                cmd1.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = W_IDTextBox.Text
                myconnection.Open()
                Dim readerobj As OleDbDataReader = cmd1.ExecuteReader()
                readerobj.Read()
                W__NameTextBox.Text = readerobj.GetValue(0).ToString
                W__AddressTextBox.Text = readerobj.GetValue(1).ToString
                W__MobileTextBox.Text = readerobj.GetValue(2).ToString
                W__SalaryTextBox.Text = readerobj.GetValue(3).ToString
                readerobj.Close()
                myconnection.Close()
            W_PaidTextBox.Text = ""
            W_RemainingTextBox.Text = ""



        Catch ex As Exception
            'MsgBox("No such Worker ID...")
            W__NameTextBox.Text = ""
            W__AddressTextBox.Text = ""
            W__MobileTextBox.Text = ""
            W__SalaryTextBox.Text = ""
            W_PaidTextBox.Text = ""
            W_RemainingTextBox.Text = ""

        End Try


    End Sub

    Private Sub W_PaidTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles W_PaidTextBox.KeyUp
        Try
            W_RemainingTextBox.Text = W__SalaryTextBox.Text - W_PaidTextBox.Text
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim HP As New HomePage
        HP.Show()
        Me.Dispose()
    End Sub

    Private Sub W_IDTextBox_TextChanged(sender As Object, e As EventArgs) Handles W_IDTextBox.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
            Dim myconnection As New OleDbConnection(connection)
            Dim cmd1 As New OleDbCommand("SELECT W_Paid,Paid_date,W_Remaining FROM WSalary WHERE W_ID=? ", myconnection)
            cmd1.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = W_IDTextBox.Text
            myconnection.Open()
            Dim readerobj As OleDbDataReader = cmd1.ExecuteReader()
            readerobj.Read()
            W_PaidTextBox.Text = readerobj.GetValue(0).ToString
            Paid_dateDateTimePicker.Text = readerobj.GetValue(1).ToString
            W_RemainingTextBox.Text = readerobj.GetValue(2).ToString
            readerobj.Close()
            myconnection.Close()

        Catch ex As Exception
            MsgBox("Salary not paid...")
            W_PaidTextBox.Text = ""
            W_RemainingTextBox.Text = ""

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
            Dim myconnection As New OleDbConnection(connection)
            myconnection.Open()
            Dim cmd1 As New OleDbCommand("UPDATE WSalary SET W_Paid=? ,W_Remaining=? ,Paid_date=? WHERE W_ID=? AND ID=? ", myconnection)
            cmd1.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = W_PaidTextBox.Text
            cmd1.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = W_RemainingTextBox.Text
            cmd1.Parameters.AddWithValue("@3", OleDbType.VarChar).Value = Paid_dateDateTimePicker.Text
            cmd1.Parameters.AddWithValue("@4", OleDbType.VarChar).Value = W_IDTextBox.Text
            cmd1.Parameters.AddWithValue("@5", OleDbType.VarChar).Value = TextBox2.Text

            Dim readerobj As OleDbDataReader = cmd1.ExecuteReader()
            readerobj.Read()
            readerobj.Close()
            MessageBox.Show("Salary Updated..")
            myconnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'PrintDialog1.Document = PrintDocument1
        'PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        'PrintDialog1.AllowSomePages = True
        'If PrintDialog1.ShowDialog = DialogResult.OK Then
        ' PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        ' PrintDocument1.Print()
        'End If
        Try
            TextBox1.Text = ""
            TextBox1.AppendText("       RAJLAXMI BRICKS SUPPLIERS,SANGALI    " + vbNewLine)
            TextBox1.AppendText("                  Worker Salary              " + vbNewLine)

            TextBox1.AppendText(vbNewLine + "Receipt ID  :" + TextBox2.Text + "         Date:" + Paid_dateDateTimePicker.Text + vbNewLine)
            TextBox1.AppendText(vbNewLine + "Worker ID   :" + W_IDTextBox.Text)
            TextBox1.AppendText(vbNewLine + "Worker Name :" + W__NameTextBox.Text + vbNewLine)
            TextBox1.AppendText("==========================================" + vbNewLine)
            TextBox1.AppendText(vbTab + "Total Salary : " + W__SalaryTextBox.Text + vbNewLine)
            TextBox1.AppendText(vbTab + "Paid         : " + W_PaidTextBox.Text + vbNewLine)
            TextBox1.AppendText(vbTab + "Remaining    : " + W_RemainingTextBox.Text + vbNewLine)
            TextBox1.AppendText("==========================================" + vbNewLine)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox2.Text = TextBox2.Text + 1
        W_IDTextBox.Text = ""
        W__NameTextBox.Text = ""
        W__AddressTextBox.Text = ""
        W__MobileTextBox.Text = ""
        W__SalaryTextBox.Text = ""
        W_PaidTextBox.Text = ""
        W_RemainingTextBox.Text = ""

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("arial", 16, FontStyle.Regular)
        e.Graphics.DrawString(TextBox1.Text, font1, Brushes.Black, 100, 100)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PrintDocument1.Print()
        Try
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
            Dim myconnection As New OleDbConnection(connection)
            myconnection.Open()

            Dim sqlQry As String = "INSERT INTO [SalaryReceipt] ([ReceiptID],[WorkerID], [WorkerName],[ReceiptDate],[TotalSalary],[Paid],[Remaining])VALUES (@ReceiptID,@WorkerID,@WorkerName,@ReceiptDate,@TotalSalary,@Paid,@Remaining)"
            Dim cmd As New OleDbCommand(sqlQry, myconnection)
            cmd.Parameters.AddWithValue("@ReceiptID", TextBox2.Text)
            cmd.Parameters.AddWithValue("@WorkerID", W_IDTextBox.Text)
            cmd.Parameters.AddWithValue("@wnWorkerNameame", W__NameTextBox.Text)
            cmd.Parameters.AddWithValue("@ReceiptDate", W_PaidTextBox.Text)
            cmd.Parameters.AddWithValue("@TotalSalary", W__SalaryTextBox.Text)
            cmd.Parameters.AddWithValue("@Paid", W_PaidTextBox.Text)
            cmd.Parameters.AddWithValue("@Remaining", W_RemainingTextBox.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Printing....")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub WSalaryBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles WSalaryBindingNavigator.RefreshItems

    End Sub



    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
            MessageBox.Show("You can only input numbers!")
        End If

    End Sub

    Private Sub TextBox3_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyUp
        Try
            If TextBox3.Text.Equals("") Then

                Dim connection1 As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
                Dim myconnection1 As New OleDbConnection(connection1)
                Dim cmd As New OleDbCommand("SELECT MAX(ID) FROM WSalary", myconnection1)

                myconnection1.Open()
                Dim readerobj1 As OleDbDataReader = cmd.ExecuteReader()
                readerobj1.Read()
                Dim VALUE1
                VALUE1 = readerobj1.GetValue(0).ToString
                TextBox2.Text = VALUE1 + 1
                readerobj1.Close()
                myconnection1.Close()
                W_IDTextBox.Text = ""
                W__NameTextBox.Text = ""
                W__AddressTextBox.Text = ""
                W__MobileTextBox.Text = ""
                W__SalaryTextBox.Text = ""
                W_PaidTextBox.Text = ""
                W_RemainingTextBox.Text = ""

            Else
                TextBox2.Text = TextBox3.Text
                Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
                Dim myconnection As New OleDbConnection(connection)
                Dim cmd1 As New OleDbCommand("SELECT W_ID,W__Name,W__Address,W__Mobile,W__Salary,W_Paid,Paid_date,W_Remaining FROM WSalary WHERE ID=? ", myconnection)
                cmd1.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = TextBox3.Text
                myconnection.Open()
                Dim readerobj As OleDbDataReader = cmd1.ExecuteReader()
                readerobj.Read()
                W_IDTextBox.Text = readerobj.GetValue(0).ToString
                W__NameTextBox.Text = readerobj.GetValue(1).ToString
                W__AddressTextBox.Text = readerobj.GetValue(2).ToString
                W__MobileTextBox.Text = readerobj.GetValue(3).ToString
                W__SalaryTextBox.Text = readerobj.GetValue(4).ToString
                W_PaidTextBox.Text = readerobj.GetValue(5).ToString
                Paid_dateDateTimePicker.Value = readerobj.GetValue(6).ToString
                W_RemainingTextBox.Text = readerobj.GetValue(7).ToString
                readerobj.Close()
                myconnection.Close()
                W_PaidTextBox.Text = ""
                W_RemainingTextBox.Text = ""


            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub W_IDTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles W_IDTextBox.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
            MessageBox.Show("You can only input numbers!")
        End If
    End Sub

    Private Sub W__MobileTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles W__MobileTextBox.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
            MessageBox.Show("You can only input numbers!")
        End If
    End Sub

    Private Sub W_PaidTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles W_PaidTextBox.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
            MessageBox.Show("You can only input numbers!")
        End If
    End Sub
End Class