Imports System.Data.OleDb
Imports System.Data
Public Class ProductionDetails
    Dim Current_Price

    Private Sub ProductionDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BricksProductionDataSet1.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.BricksProductionDataSet1.Product)
        'TODO: This line of code loads data into the 'BricksProductionDataSet1.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.BricksProductionDataSet1.Supplier)
        'TODO: This line of code loads data into the 'BricksProductionDataSet1.Material_Table' table. You can move, or remove it, as needed.
        Me.Material_TableTableAdapter.Fill(Me.BricksProductionDataSet1.Material_Table)
        Timer1.Enabled = True
        Try
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
            Dim myconnection As New OleDbConnection(connection)
            Dim cmd1 As New OleDbCommand("SELECT MAX(Supply_ID) FROM Material_Supply", myconnection)
            'cmd1.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = TextBox4.Text
            myconnection.Open()
            Dim readerobj As OleDbDataReader = cmd1.ExecuteReader()
            readerobj.Read()
            Dim VALUE1
            VALUE1 = readerobj.GetValue(0).ToString
            TextBox4.Text = VALUE1 + 1
            readerobj.Close()
            myconnection.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ns As New newSupplier
        ns.Show()
        Me.Dispose()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label13.Text = Date.Now.ToString("dd-MMMM-yyyy hh:mm:ss")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
            Dim myconnection As New OleDbConnection(connection)
            Dim cmd1 As New OleDbCommand("SELECT Material_name,Current_Price FROM Material_Table WHERE M_ID=? ", myconnection)
            cmd1.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = ComboBox1.Text
            myconnection.Open()
            Dim readerobj As OleDbDataReader = cmd1.ExecuteReader()
            readerobj.Read()
            TextBox10.Text = readerobj.GetValue(0).ToString
            TextBox9.Text = readerobj.GetValue(1).ToString
            readerobj.Close()
            myconnection.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
            Dim myconnection As New OleDbConnection(connection)
            Dim cmd1 As New OleDbCommand("SELECT Supplier_name FROM Supplier WHERE Supplier_ID=? ", myconnection)
            cmd1.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = ComboBox2.Text
            myconnection.Open()
            Dim readerobj As OleDbDataReader = cmd1.ExecuteReader()
            readerobj.Read()
            TextBox1.Text = readerobj.GetValue(0).ToString

            readerobj.Close()
            myconnection.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Try
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
            Dim myconnection As New OleDbConnection(connection)
            Dim cmd1 As New OleDbCommand("SELECT Current_Price FROM Material_Table WHERE M_ID=? ", myconnection)
            cmd1.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = ComboBox3.Text
            myconnection.Open()
            Dim readerobj As OleDbDataReader = cmd1.ExecuteReader()
            readerobj.Read()
            Current_Price = readerobj.GetValue(0).ToString

            readerobj.Close()
            myconnection.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox3_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyUp
        Try
            TextBox2.Text = TextBox9.Text * TextBox3.Text
        Catch ex As Exception
            'MessageBox.Show("Please enter number of units...")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
            Dim myconnection As New OleDbConnection(connection)
            Dim cmd1 As New OleDbCommand("UPDATE Material_Table SET Current_Price=? WHERE M_ID=? ", myconnection)
            cmd1.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = TextBox9.Text
            cmd1.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = ComboBox1.Text
            myconnection.Open()
            Dim readerobj As OleDbDataReader = cmd1.ExecuteReader()
            readerobj.Read()
            readerobj.Close()
            myconnection.Close()
            MessageBox.Show("Price Updated..")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
            Dim myconnection As New OleDbConnection(connection)
            myconnection.Open()

            Dim sqlQry As String = "INSERT INTO [Material_Supply] ([Supply_ID], [Supplier_ID],[Supplier_name],[Material_ID],[Unit],[Supply_Date],[Total_price]) VALUES (@id,@s_id,@s_name,@m_id,@unit,@s_date,@t_price)"
            Dim cmd As New OleDbCommand(sqlQry, myconnection)
            cmd.Parameters.AddWithValue("@id", TextBox4.Text)
            cmd.Parameters.AddWithValue("@s_id", ComboBox2.Text)
            cmd.Parameters.AddWithValue("@s_name", TextBox1.Text)
            cmd.Parameters.AddWithValue("@m_id", ComboBox3.Text)
            cmd.Parameters.AddWithValue("@unit", TextBox3.Text)
            cmd.Parameters.AddWithValue("@s_date", DateTimePicker1.Text)
            cmd.Parameters.AddWithValue("@t_price", TextBox2.Text)

            cmd.ExecuteNonQuery()
            MsgBox("SAVED")

            ComboBox2.Text = ""
            TextBox1.Text = ""
            ComboBox3.Text = ""
            TextBox3.Text = ""
            TextBox2.Text = ""
            TextBox4.Text = TextBox4.Text + 1


        Catch ex As Exception
            MessageBox.Show("Supply Id is already used...")
        End Try

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Try
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
            Dim myconnection As New OleDbConnection(connection)
            Dim cmd1 As New OleDbCommand("SELECT Product_name,Product_Size,Product_Price FROM Product WHERE ID=? ", myconnection)
            cmd1.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = ComboBox4.Text
            myconnection.Open()
            Dim readerobj As OleDbDataReader = cmd1.ExecuteReader()
            readerobj.Read()
            TextBox6.Text = readerobj.GetValue(0).ToString
            TextBox8.Text = readerobj.GetValue(1).ToString
            TextBox5.Text = readerobj.GetValue(2).ToString

            readerobj.Close()
            myconnection.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BricksProduction.accdb"
            Dim myconnection As New OleDbConnection(connection)
            Dim cmd1 As New OleDbCommand("UPDATE Product SET Product_Price=? WHERE ID=? ", myconnection)
            cmd1.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = TextBox5.Text
            cmd1.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = ComboBox4.Text
            myconnection.Open()
            Dim readerobj As OleDbDataReader = cmd1.ExecuteReader()
            readerobj.Read()
            readerobj.Close()
            myconnection.Close()
            MessageBox.Show("Price Updated..")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim HP As New HomePage
        HP.Show()
        Me.Dispose()
    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
            MessageBox.Show("You can only input numbers!")
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
            MessageBox.Show("You can only input numbers!")
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
            MessageBox.Show("You can only input numbers!")
        End If
    End Sub
End Class