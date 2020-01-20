Imports System.Data.OleDb
Imports System.Data
Public Class AddWorker


    Private Sub AddWorker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WorkerRegistrationTableAdapter.Fill(Me.BricksProductionDataSet1.WorkerRegistration)
        Me.Refresh()
        Try
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"


            Dim myconnection As New OleDbConnection(connection)
            Dim cmd1 As New OleDbCommand("SELECT MAX(W_ID) FROM WorkerRegistration", myconnection)

            myconnection.Open()
            Dim readerobj As OleDbDataReader = cmd1.ExecuteReader()
            readerobj.Read()
            Dim VALUE1
            VALUE1 = readerobj.GetValue(0).ToString
            W_IDTextBox.Text = VALUE1 + 1
            readerobj.Close()
            myconnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        W_NameTextBox.Text = ""
        W_AddressTextBox.Text = ""
        W_MobileTextBox.Text = ""
        W_TypeTextBox.Text = ""
        W_SalaryTextBox.Text = ""

    End Sub
    Private Sub WorkerRegistrationBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles WorkerRegistrationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.WorkerRegistrationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BricksProductionDataSet1)
    End Sub


    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            If (W_NameTextBox.Text.Equals("") Or W_AddressTextBox.Text.Equals("") Or W_MobileTextBox.Equals("") Or W_TypeTextBox.Text.Equals("") Or W_SalaryTextBox.Text.Equals("")) Then
                MessageBox.Show("Please Fill All Fields...")
            Else
                Try


                    Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
                    Dim myconnection As New OleDbConnection(connection)
                    If myconnection.State = ConnectionState.Closed Then
                        myconnection.Open()
                    End If

                    Dim sqlQry As String = "INSERT INTO [WorkerRegistration] ([W_ID], [W_Name],[W_Address],[W_Mobile],[W_Type],[W_Salary],[W_DOB],[W_joinDate]) VALUES (@wid,@wname,@waddress,@wmobile,@wtype,@wsalary,@wdob,@joindate)"
                    Dim cmd As New OleDbCommand(sqlQry, myconnection)
                    cmd.Parameters.AddWithValue("@wid", W_IDTextBox.Text)
                    cmd.Parameters.AddWithValue("@wname", W_NameTextBox.Text)
                    cmd.Parameters.AddWithValue("@waddress", W_AddressTextBox.Text)
                    cmd.Parameters.AddWithValue("@wmobile", W_MobileTextBox.Text)
                    cmd.Parameters.AddWithValue("@wtype", W_TypeTextBox.Text)
                    cmd.Parameters.AddWithValue("@wsalary", W_SalaryTextBox.Text)
                    cmd.Parameters.AddWithValue("@wdob", W_DOBDateTimePicker.Text)
                    cmd.Parameters.AddWithValue("@wjoindate", W_JoinDateDateTimePicker.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("SAVED")

                Catch ex As Exception
                    MessageBox.Show("Worker is already register with this ID")
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim HP As New HomePage
        HP.Show()
        Me.Dispose()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            'WorkerRegistrationBindingSource.AddNew()
            W_IDTextBox.Text = W_IDTextBox.Text + 1
            W_NameTextBox.Text = ""
            W_AddressTextBox.Text = ""
            W_MobileTextBox.Text = ""
            W_SalaryTextBox.Text = ""
            W_TypeTextBox.Text = ""


        Catch ex As Exception

        End Try
    End Sub

    Private Sub W_NameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles W_NameTextBox.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("You can only input characters!")
        End If
    End Sub

    Private Sub W_AddressTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles W_AddressTextBox.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("You can only input characters!")
        End If
    End Sub

    Private Sub W_TypeTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles W_TypeTextBox.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("You can only input characters!")
        End If
    End Sub

    Private Sub W_MobileTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles W_MobileTextBox.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
            MessageBox.Show("You can only input numbers!")
        End If
    End Sub

    Private Sub W_SalaryTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles W_SalaryTextBox.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
            MessageBox.Show("You can only input numbers!")
        End If
    End Sub


End Class