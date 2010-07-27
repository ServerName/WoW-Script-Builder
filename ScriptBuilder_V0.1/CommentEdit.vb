Public Class frmCommentEdit

    Private Sub btnCommentEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommentEdit.Click
        Me.CommentsTableAdapter.EditComment(Me.WSBDataSet.Comments, txtCommentID.Text, txtCommentText.Text)
        Me.Dispose()
        Me.Close()
    End Sub
End Class