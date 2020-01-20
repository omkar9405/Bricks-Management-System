Public Class SalaryDetails
    Private Sub WSalaryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles WSalaryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.WSalaryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BricksProductionDataSet1)
    End Sub

    Private Sub SalaryDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BricksProductionDataSet1.WSalary' table. You can move, or remove it, as needed.
        Me.WSalaryTableAdapter.Fill(Me.BricksProductionDataSet1.WSalary)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim HP As New HomePage
        HP.Show()
        Me.Dispose()
    End Sub
End Class