Public Class frmHeaderDelete
    Private Sub btnHeaderDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHeaderDelete.Click
        HeaderId = cbHeaderId.SelectedValue

        Me.HeadersTableAdapter.DelHeader(Me.WSBDataSet.Headers, HeaderId)
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub frmHeaderDelete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.HeadersTableAdapter.Fill(Me.WSBDataSet.Headers)
    End Sub
End Class