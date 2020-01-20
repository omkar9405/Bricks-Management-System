Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Public Class ViewWorkers
    Dim connection As New OleDbConnection
    Private Sub WorkerRegistrationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles WorkerRegistrationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.WorkerRegistrationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BricksProductionDataSet1)

    End Sub

    Private Sub ViewWorkers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BricksProductionDataSet1.WorkerRegistration' table. You can move, or remove it, as needed.
        Me.Refresh()
        Me.WorkerRegistrationTableAdapter.Fill(Me.BricksProductionDataSet1.WorkerRegistration)
        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WorkerRegistrationBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            WorkerRegistrationBindingSource.EndEdit()
            WorkerRegistrationTableAdapter.Update(BricksProductionDataSet1.WorkerRegistration)
            MsgBox("Data Updated")
        Catch ex As Exception
            MsgBox("Error occured while saving ")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WorkerRegistrationBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim HP As New HomePage
        HP.Show()
        Me.Dispose()
    End Sub



    Private Sub W_IDTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles W_IDTextBox.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
            MessageBox.Show("You can only input numbers!")
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
End Class