Imports System.Data.OleDb

Imports System.Data
Public Class Login_Form
    Dim connection As New OleDbConnection(My.Settings.BricksProductionConnectionString)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then
            MsgBox("Enter credentials", MsgBoxStyle.Exclamation)
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim cmd As New OleDbCommand("select count(*) from AdminLogin where USERNAME=? and PASSWORD=?", connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = TextBox1.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = TextBox2.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            If (count > 0) Then

                Dim HP As New HomePage
                HP.Show()

                MsgBox("Login succeed", MsgBoxStyle.Information)
                Me.Hide()

            Else
                MsgBox("Login Failed", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub Login_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Visible = True
        TextBox2.Visible = True
        Button2.Visible = False
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Button2.Visible = True
    End Sub
End Class
