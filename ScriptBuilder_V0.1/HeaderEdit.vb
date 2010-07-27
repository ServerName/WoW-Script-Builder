Public Class frmHeaderEdit
    Private Sub btnHeaderEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHeaderEdit.Click
        HeaderId = cbHeaderId.SelectedValue
        HeaderName = txtHeaderText.Text

        Me.HeadersTableAdapter.EditHeader(Me.WSBDataSet.Headers, HeaderId, HeaderName)
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub frmHeaderEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.HeadersTableAdapter.Fill(Me.WSBDataSet.Headers)
    End Sub
End Class