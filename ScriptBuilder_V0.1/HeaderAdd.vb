Public Class frmHeaderAdd
    Private Sub btnHeaderSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHeaderAdd.Click
        Me.HeadersTableAdapter.AddHeader(Me.WSBDataSet.Headers, txtHeaderText.Text)
        Me.Dispose()
        Me.Close()
    End Sub
End Class