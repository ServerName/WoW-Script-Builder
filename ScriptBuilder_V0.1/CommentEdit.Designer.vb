<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommentEdit
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
        Dim lblCommentID As System.Windows.Forms.Label
        Dim lblCommentText As System.Windows.Forms.Label
        Me.WSBDataSet = New ScriptBuilder_V0._1.WSBDataSet
        Me.CommentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommentsTableAdapter = New ScriptBuilder_V0._1.WSBDataSetTableAdapters.CommentsTableAdapter
        Me.TableAdapterManager = New ScriptBuilder_V0._1.WSBDataSetTableAdapters.TableAdapterManager
        Me.txtCommentText = New System.Windows.Forms.TextBox
        Me.btnCommentEdit = New System.Windows.Forms.Button
        Me.cbCommentId = New System.Windows.Forms.ComboBox
        lblCommentID = New System.Windows.Forms.Label
        lblCommentText = New System.Windows.Forms.Label
        CType(Me.WSBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCommentID
        '
        lblCommentID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        lblCommentID.AutoSize = True
        lblCommentID.Location = New System.Drawing.Point(12, 187)
        lblCommentID.Name = "lblCommentID"
        lblCommentID.Size = New System.Drawing.Size(68, 13)
        lblCommentID.TabIndex = 4
        lblCommentID.Text = "Comment ID:"
        '
        'lblCommentText
        '
        lblCommentText.AutoSize = True
        lblCommentText.Location = New System.Drawing.Point(12, 9)
        lblCommentText.Name = "lblCommentText"
        lblCommentText.Size = New System.Drawing.Size(78, 13)
        lblCommentText.TabIndex = 3
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
        Me.txtCommentText.Size = New System.Drawing.Size(311, 153)
        Me.txtCommentText.TabIndex = 0
        '
        'btnCommentEdit
        '
        Me.btnCommentEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCommentEdit.Location = New System.Drawing.Point(248, 184)
        Me.btnCommentEdit.Name = "btnCommentEdit"
        Me.btnCommentEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnCommentEdit.TabIndex = 2
        Me.btnCommentEdit.Text = "Edit"
        Me.btnCommentEdit.UseVisualStyleBackColor = True
        '
        'cbCommentId
        '
        Me.cbCommentId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCommentId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommentsBindingSource, "ID", True))
        Me.cbCommentId.DataSource = Me.CommentsBindingSource
        Me.cbCommentId.DisplayMember = "ID"
        Me.cbCommentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCommentId.FormattingEnabled = True
        Me.cbCommentId.Location = New System.Drawing.Point(86, 185)
        Me.cbCommentId.Name = "cbCommentId"
        Me.cbCommentId.Size = New System.Drawing.Size(156, 21)
        Me.cbCommentId.TabIndex = 1
        Me.cbCommentId.ValueMember = "ID"
        '
        'frmCommentEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 216)
        Me.Controls.Add(Me.cbCommentId)
        Me.Controls.Add(Me.btnCommentEdit)
        Me.Controls.Add(lblCommentID)
        Me.Controls.Add(lblCommentText)
        Me.Controls.Add(Me.txtCommentText)
        Me.MinimumSize = New System.Drawing.Size(351, 254)
        Me.Name = "frmCommentEdit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Comments"
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
    Friend WithEvents btnCommentEdit As System.Windows.Forms.Button
    Friend WithEvents cbCommentId As System.Windows.Forms.ComboBox
End Class
