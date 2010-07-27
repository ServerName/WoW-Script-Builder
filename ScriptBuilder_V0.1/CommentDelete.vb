Public Class frmCommentDelete
    Private Sub btnCommentDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommentDelete.Click
        Me.CommentsTableAdapter.DelComment(Me.WSBDataSet.Comments, txtCommentID.Text)
        Me.Dispose()
        Me.Close()
    End Sub
End Class