Public Class frmCommentEdit

    Private Sub btnCommentEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommentEdit.Click
        CommentId = cbCommentId.SelectedValue
        CommentName = txtCommentText.Text

        Me.CommentsTableAdapter.EditComment(Me.WSBDataSet.Comments, CommentId, CommentName)
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub frmCommentEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CommentsTableAdapter.Fill(Me.WSBDataSet.Comments)
    End Sub
End Class