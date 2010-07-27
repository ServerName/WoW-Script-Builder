<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHeaderDelete
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
        Dim lblHeaderId As System.Windows.Forms.Label
        Me.WSBDataSet = New ScriptBuilder_V0._1.WSBDataSet
        Me.HeadersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HeadersTableAdapter = New ScriptBuilder_V0._1.WSBDataSetTableAdapters.HeadersTableAdapter
        Me.TableAdapterManager = New ScriptBuilder_V0._1.WSBDataSetTableAdapters.TableAdapterManager
        Me.btnHeaderDelete = New System.Windows.Forms.Button
        Me.cbHeaderId = New System.Windows.Forms.ComboBox
        Me.HeadersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HeadersBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        lblHeaderId = New System.Windows.Forms.Label
        CType(Me.WSBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeadersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeadersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeadersBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WSBDataSet
        '
        Me.WSBDataSet.DataSetName = "WSBDataSet"
        Me.WSBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HeadersBindingSource
        '
        Me.HeadersBindingSource.DataMember = "Headers"
        Me.HeadersBindingSource.DataSource = Me.WSBDataSet
        '
        'HeadersTableAdapter
        '
        Me.HeadersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CommentsTableAdapter = Nothing
        Me.TableAdapterManager.HeadersTableAdapter = Me.HeadersTableAdapter
        Me.TableAdapterManager.NPCTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ScriptBuilder_V0._1.WSBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnHeaderDelete
        '
        Me.btnHeaderDelete.Location = New System.Drawing.Point(290, 12)
        Me.btnHeaderDelete.Name = "btnHeaderDelete"
        Me.btnHeaderDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnHeaderDelete.TabIndex = 3
        Me.btnHeaderDelete.Text = "Delete"
        Me.btnHeaderDelete.UseVisualStyleBackColor = True
        '
        'lblHeaderId
        '
        lblHeaderId.AutoSize = True
        lblHeaderId.Location = New System.Drawing.Point(12, 15)
        lblHeaderId.Name = "lblHeaderId"
        lblHeaderId.Size = New System.Drawing.Size(72, 13)
        lblHeaderId.TabIndex = 3
        lblHeaderId.Text = "Header Text: "
        '
        'cbHeaderId
        '
        Me.cbHeaderId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HeadersBindingSource, "ID", True))
        Me.cbHeaderId.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HeadersBindingSource2, "ID", True))
        Me.cbHeaderId.DataSource = Me.HeadersBindingSource1
        Me.cbHeaderId.DisplayMember = "Text"
        Me.cbHeaderId.FormattingEnabled = True
        Me.cbHeaderId.Location = New System.Drawing.Point(90, 12)
        Me.cbHeaderId.Name = "cbHeaderId"
        Me.cbHeaderId.Size = New System.Drawing.Size(194, 21)
        Me.cbHeaderId.TabIndex = 4
        Me.cbHeaderId.ValueMember = "ID"
        '
        'HeadersBindingSource1
        '
        Me.HeadersBindingSource1.DataMember = "Headers"
        Me.HeadersBindingSource1.DataSource = Me.WSBDataSet
        '
        'HeadersBindingSource2
        '
        Me.HeadersBindingSource2.DataMember = "Headers"
        Me.HeadersBindingSource2.DataSource = Me.WSBDataSet
        '
        'frmHeaderDelete
        '
        Me.AcceptButton = Me.btnHeaderDelete
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 47)
        Me.Controls.Add(lblHeaderId)
        Me.Controls.Add(Me.cbHeaderId)
        Me.Controls.Add(Me.btnHeaderDelete)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHeaderDelete"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Delete Header"
        CType(Me.WSBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeadersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeadersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeadersBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WSBDataSet As ScriptBuilder_V0._1.WSBDataSet
    Friend WithEvents HeadersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HeadersTableAdapter As ScriptBuilder_V0._1.WSBDataSetTableAdapters.HeadersTableAdapter
    Friend WithEvents TableAdapterManager As ScriptBuilder_V0._1.WSBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnHeaderDelete As System.Windows.Forms.Button
    Friend WithEvents cbHeaderId As System.Windows.Forms.ComboBox
    Friend WithEvents HeadersBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents HeadersBindingSource2 As System.Windows.Forms.BindingSource
End Class
