<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommentAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim lblCommentText As System.Windows.Forms.Label
        Me.WSBDataSet = New ScriptBuilder_V0._1.WSBDataSet
        Me.CommentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommentsTableAdapter = New ScriptBuilder_V0._1.WSBDataSetTableAdapters.CommentsTableAdapter
        Me.TableAdapterManager = New ScriptBuilder_V0._1.WSBDataSetTableAdapters.TableAdapterManager
        Me.txtCommentText = New System.Windows.Forms.TextBox
        Me.btnCommentAdd = New System.Windows.Forms.Button
        lblCommentText = New System.Windows.Forms.Label
        CType(Me.WSBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCommentText
        '
        lblCommentText.AutoSize = True
        lblCommentText.Location = New System.Drawing.Point(12, 9)
        lblCommentText.Name = "lblCommentText"
        lblCommentText.Size = New System.Drawing.Size(78, 13)
        lblCommentText.TabIndex = 1
        lblCommentText.Text = "Comment Text:"
        '
        'WSBDataSet
        '
        Me.WSBDataSet.DataSetName = "WSBDataSet"
        Me.WSBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CommentsBindingSource
        '
        Me.CommentsBindingSource.DataMember = "Comments"
        Me.CommentsBindingSource.DataSource = Me.WSBDataSet
        '
        'CommentsTableAdapter
        '
        Me.CommentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CommentsTableAdapter = Me.CommentsTableAdapter
        Me.TableAdapterManager.HeadersTableAdapter = Nothing
        Me.TableAdapterManager.NPCTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ScriptBuilder_V0._1.WSBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'txtCommentText
        '
        Me.txtCommentText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCommentText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommentsBindingSource, "Text", True))
        Me.txtCommentText.Location = New System.Drawing.Point(12, 25)
        Me.txtCommentText.Multiline = True
        Me.txtCommentText.Name = "txtCommentText"
        Me.txtCommentText.Size = New System.Drawing.Size(311, 150)
        Me.txtCommentText.TabIndex = 2
        '
        'btnCommentAdd
        '
        Me.btnCommentAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCommentAdd.Location = New System.Drawing.Point(248, 181)
        Me.btnCommentAdd.Name = "btnCommentAdd"
        Me.btnCommentAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnCommentAdd.TabIndex = 3
        Me.btnCommentAdd.Text = "Add"
        Me.btnCommentAdd.UseVisualStyleBackColor = True
        '
        'frmCommentAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 216)
        Me.Controls.Add(Me.btnCommentAdd)
        Me.Controls.Add(lblCommentText)
        Me.Controls.Add(Me.txtCommentText)
        Me.MinimumSize = New System.Drawing.Size(351, 254)
        Me.Name = "frmCommentAdd"
        Me.ShowInTaskbar = False
        Me.Text = "Add Comment"
        CType(Me.WSBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WSBDataSet As ScriptBuilder_V0._1.WSBDataSet
    Friend WithEvents CommentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CommentsTableAdapter As ScriptBuilder_V0._1.WSBDataSetTableAdapters.CommentsTableAdapter
    Friend WithEvents TableAdapterManager As ScriptBuilder_V0._1.WSBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtCommentText As System.Windows.Forms.TextBox
    Friend WithEvents btnCommentAdd As System.Windows.Forms.Button
End Class
