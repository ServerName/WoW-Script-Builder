Public Class frmHeaderDelete
    Private Sub btnHeaderDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHeaderDelete.Click
        Me.HeadersTableAdapter.DelHeader(Me.WSBDataSet.Headers, txtHeaderID.Text)
        Me.Dispose()
        Me.Close()
    End Sub
End Class