Public Class frmCommentDelete
    Private Sub btnCommentDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommentDelete.Click
        CommentId = cbCommentId.SelectedValue

        Me.CommentsTableAdapter.DelComment(Me.WSBDataSet.Comments, CommentId)
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub frmCommentDelete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CommentsTableAdapter.Fill(Me.WSBDataSet.Comments)
    End Sub
End Class