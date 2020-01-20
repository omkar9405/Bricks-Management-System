Public Class HomePage

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim AW As New AddWorker
            AW.Show()
            Me.Hide()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Try
            Dim WS As New WorkerSalary
            WS.Show()
            Me.Hide()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim AC As New AddCustomer
            AC.Show()
            Me.Hide()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim VC As New Customer_Details
            VC.Show()
            Me.Hide()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim PD As New ProductionDetails
            PD.Show()
            Me.Hide()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim V As New ViewWorkers
            V.Show()
            Me.Hide()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Label2.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            Dim SD As New SalaryDetails
            SD.Show()
            Me.Hide()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim WS As New WorkerSalary
            WS.Show()
            Me.Hide()
        Catch ex As Exception
        End Try

    End Sub



    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Dim lp As New Login_Form
        lp.Show()
    End Sub



    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            Dim b As New Bill_Details
            b.Show()
            Me.Hide()
        Catch ex As Exception
        End Try

    End Sub
End Class