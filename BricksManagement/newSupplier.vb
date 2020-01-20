Imports System.Data.OleDb
Imports System.Data
Public Class newSupplier

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
            Dim myconnection As New OleDbConnection(connection)
            myconnection.Open()

            Dim sqlQry As String = "INSERT INTO [Supplier] ([Supplier_ID],[Supplier_name],[Supplier_contact]) VALUES (@id,@s_id,@s_contact)"
            Dim cmd As New OleDbCommand(sqlQry, myconnection)
            cmd.Parameters.AddWithValue("@id", TextBox1.Text)
            cmd.Parameters.AddWithValue("@s_id", TextBox3.Text)
            cmd.Parameters.AddWithValue("@s_contact", TextBox2.Text)

            cmd.ExecuteNonQuery()
            MsgBox("SAVED")

            TextBox2.Text = " "
            TextBox3.Text = " "
            TextBox1.Text = TextBox1.Text + 1


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub NewSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
            Dim myconnection As New OleDbConnection(connection)
            Dim cmd1 As New OleDbCommand("SELECT MAX(Supplier_ID) FROM Supplier", myconnection)

            myconnection.Open()
            Dim readerobj As OleDbDataReader = cmd1.ExecuteReader()
            readerobj.Read()
            Dim VALUE1
            VALUE1 = readerobj.GetValue(0).ToString
            TextBox1.Text = VALUE1 + 1
            readerobj.Close()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
            MessageBox.Show("You can only input numbers!")
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("You can only input characters!")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim BP As New ProductionDetails
        BP.Show()
        Me.Dispose()
    End Sub
End Class