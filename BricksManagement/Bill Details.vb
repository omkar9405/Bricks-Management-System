Imports System.Data.OleDb
Imports System.Data
Public Class Bill_Details
    Dim connection As New OleDbConnection
    Private Sub BillBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BillBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BillBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BricksProductionDataSet1)

    End Sub

    Private Sub Bill_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BricksProductionDataSet1.Bill' table. You can move, or remove it, as needed.
        Me.BillTableAdapter.Fill(Me.BricksProductionDataSet1.Bill)
        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Me.BillBindingSource.Filter = "Bill_Date >= '" & DateTimePicker1.Text & "' and Bill_Date >='" & DateTimePicker2.Text & "'"
        Try
            Dim dt As New DataTable()
            Dim command As New OleDbCommand("Select * from Bill where Bill_Date between @d1 and @d2", connection)
            command.Parameters.Add("@d1", OleDbType.Date).Value = DateTimePicker1.Value
            command.Parameters.Add("@d2", OleDbType.Date).Value = DateTimePicker2.Value
            Dim adp As New OleDbDataAdapter(command)
            adp.Fill(dt)
            BillDataGridView.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try

            Dim connection1 As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
            Dim myconnection As New OleDbConnection(connection1)
            If (ComboBox1.SelectedItem.Equals("CGST")) Then
                Dim cmd1 As New OleDbCommand("SELECT SUM(CGST)  FROM Bill WHERE Bill_Date BETWEEN @c2 AND @c3", myconnection)
                cmd1.Parameters.Add("@c2", OleDbType.Date).Value = DateTimePicker1.Value
                cmd1.Parameters.Add("@c3", OleDbType.Date).Value = DateTimePicker2.Value

                myconnection.Open()
                Dim readerobj As OleDbDataReader = cmd1.ExecuteReader()
                readerobj.Read()
                Dim VALUE1
                VALUE1 = readerobj.GetValue(0).ToString
                TextBox1.Text = VALUE1
                readerobj.Close()
                myconnection.Close()

            ElseIf (ComboBox1.SelectedItem.Equals("SGST")) Then
                Dim cmd1 As New OleDbCommand("SELECT SUM(CGST)  FROM Bill WHERE Bill_Date BETWEEN @c2 AND @c3", myconnection)
                cmd1.Parameters.Add("@c2", OleDbType.Date).Value = DateTimePicker1.Value
                cmd1.Parameters.Add("@c3", OleDbType.Date).Value = DateTimePicker2.Value

                myconnection.Open()
                Dim readerobj As OleDbDataReader = cmd1.ExecuteReader()
                readerobj.Read()
                Dim VALUE1
                VALUE1 = readerobj.GetValue(0).ToString
                TextBox1.Text = VALUE1
                readerobj.Close()
                myconnection.Close()

            Else
                Dim cmd1 As New OleDbCommand("SELECT SUM(GST)  FROM Bill WHERE Bill_Date BETWEEN @c2 AND @c3", myconnection)
                cmd1.Parameters.Add("@c2", OleDbType.Date).Value = DateTimePicker1.Value
                cmd1.Parameters.Add("@c3", OleDbType.Date).Value = DateTimePicker2.Value

                myconnection.Open()
                Dim readerobj As OleDbDataReader = cmd1.ExecuteReader()
                readerobj.Read()
                Dim VALUE1
                VALUE1 = readerobj.GetValue(0).ToString
                TextBox1.Text = VALUE1
                readerobj.Close()
                myconnection.Close()

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim hp As New HomePage
        hp.Show()
        Me.Dispose()
    End Sub
End Class