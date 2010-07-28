Public Class frmCommentView
    Private Sub frmCommentView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CommentsTableAdapter.Fill(Me.WSBDataSet.Comments)
    End Sub
End Class