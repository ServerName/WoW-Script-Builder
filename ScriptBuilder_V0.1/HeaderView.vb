Public Class frmHeaderView
    Private Sub frmHeaderView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WSBDataSet.Headers' table. You can move, or remove it, as needed.
        Me.HeadersTableAdapter.Fill(Me.WSBDataSet.Headers)
    End Sub
End Class