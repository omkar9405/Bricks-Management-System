Imports System.Data.OleDb
Imports System.Data
Public Class Customer_Details
    Dim connection As New OleDbConnection
    Private Sub CustomerDetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerDetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BricksProductionDataSet1)

    End Sub

    Private Sub Customer_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BricksProductionDataSet1.CustomerDetails' table. You can move, or remove it, as needed.
        Me.CustomerDetailsTableAdapter.Fill(Me.BricksProductionDataSet1.CustomerDetails)
        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Onkar Powar\source\repos\BricksManagement\BricksProduction.accdb"
            'Dim myconnection As New OleDbConnection(connection)
            'myconnection.Open()

            'Dim sqlQry As String = "INSERT INTO [CustomerDetails] ([ID], [C_Name],[C_Address],[C_Mobile],[C_R_Item_name],[C_Count],[C_Cost],[Current_Price],[C_DATE]) VALUES (@id,@cname,@caddress,@cmobile,@critemname,@crcount,@ccost,@cprice,@cdate)"
            'Dim cmd As New OleDbCommand(sqlQry, myconnection)
            'cmd.Parameters.AddWithValue("@cid", IDTextBox.Text)
            'cmd.Parameters.AddWithValue("@cname", C_NameTextBox.Text)
            'cmd.Parameters.AddWithValue("@caddress", C_AddressTextBox.Text)
            'cmd.Parameters.AddWithValue("@cmobile", C_MobileTextBox.Text)
            'cmd.Parameters.AddWithValue("@critemname", C_R_Item_nameTextBox.Text)
            'cmd.Parameters.AddWithValue("@crcount", C_countTextBox.Text)
            'cmd.Parameters.AddWithValue("@ccost", C_CostTextBox.Text)
            'cmd.Parameters.AddWithValue("@cprice", Current_PriceTextBox.Text)
            'cmd.Parameters.AddWithValue("@cdate", C_DateDateTimePicker.Text)

            'cmd.ExecuteNonQuery()
            MsgBox("Upadated")
            'Me.Refresh()
            CustomerDetailsBindingSource.EndEdit()
            CustomerDetailsTableAdapter.Update(BricksProductionDataSet1.CustomerDetails)
            MessageBox.Show("Updated")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim HP As New HomePage
        HP.Show()
        Me.Dispose()
    End Sub

    Private Sub C_AddressTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles C_AddressTextBox.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("You can only input characters!")
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

    Private Sub C_R_Item_nameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles C_R_Item_nameTextBox.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("You can only input characters!")
        End If
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

    Private Sub Current_PriceTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Current_PriceTextBox.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
            MessageBox.Show("You can only input numbers!")
        End If
    End Sub

    Private Sub C_CostTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles C_CostTextBox.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
            MessageBox.Show("You can only input numbers!")
        End If
    End Sub

    Private Sub C_countTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles C_countTextBox.KeyUp
        Try
            C_CostTextBox.Text = C_countTextBox.Text * Current_PriceTextBox.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class