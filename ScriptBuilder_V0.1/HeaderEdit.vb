Public Class frmHeaderEdit
    Private Sub btnHeaderEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHeaderEdit.Click
        Me.HeadersTableAdapter.EditHeader(Me.WSBDataSet.Headers, txtHeaderID.Text, txtHeaderText.Text)
        Me.Dispose()
        Me.Close()
    End Sub
End Class