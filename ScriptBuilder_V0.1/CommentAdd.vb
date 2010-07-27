Public Class frmCommentAdd
    Private Sub btnCommentAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommentAdd.Click
        Me.CommentsTableAdapter.AddComment(Me.WSBDataSet.Comments, txtCommentText.Text)
        Me.Dispose()
        Me.Close()
    End Sub
End Class