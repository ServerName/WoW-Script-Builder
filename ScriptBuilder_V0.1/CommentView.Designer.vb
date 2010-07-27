<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommentView
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
        Me.WSBDataSet = New ScriptBuilder_V0._1.WSBDataSet
        Me.CommentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommentsTableAdapter = New ScriptBuilder_V0._1.WSBDataSetTableAdapters.CommentsTableAdapter
        Me.TableAdapterManager = New ScriptBuilder_V0._1.WSBDataSetTableAdapters.TableAdapterManager
        Me.CommentsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.WSBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'CommentsDataGridView
        '
        Me.CommentsDataGridView.AllowUserToAddRows = False
        Me.CommentsDataGridView.AllowUserToDeleteRows = False
        Me.CommentsDataGridView.AutoGenerateColumns = False
        Me.CommentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CommentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.CommentsDataGridView.DataSource = Me.CommentsBindingSource
        Me.CommentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CommentsDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.CommentsDataGridView.Name = "CommentsDataGridView"
        Me.CommentsDataGridView.ReadOnly = True
        Me.CommentsDataGridView.Size = New System.Drawing.Size(644, 138)
        Me.CommentsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Text"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Text"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 500
        '
        'frmCommentView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 138)
        Me.Controls.Add(Me.CommentsDataGridView)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCommentView"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "View Comments"
        CType(Me.WSBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WSBDataSet As ScriptBuilder_V0._1.WSBDataSet
    Friend WithEvents CommentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CommentsTableAdapter As ScriptBuilder_V0._1.WSBDataSetTableAdapters.CommentsTableAdapter
    Friend WithEvents TableAdapterManager As ScriptBuilder_V0._1.WSBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CommentsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
