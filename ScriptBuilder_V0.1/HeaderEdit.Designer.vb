<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHeaderEdit
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
        Dim lblHeaderText As System.Windows.Forms.Label
        Dim lblHeaderId As System.Windows.Forms.Label
        Me.WSBDataSet = New ScriptBuilder_V0._1.WSBDataSet
        Me.HeadersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HeadersTableAdapter = New ScriptBuilder_V0._1.WSBDataSetTableAdapters.HeadersTableAdapter
        Me.TableAdapterManager = New ScriptBuilder_V0._1.WSBDataSetTableAdapters.TableAdapterManager
        Me.btnHeaderEdit = New System.Windows.Forms.Button
        Me.cbHeaderId = New System.Windows.Forms.ComboBox
        Me.txtHeaderText = New System.Windows.Forms.TextBox
        lblHeaderText = New System.Windows.Forms.Label
        lblHeaderId = New System.Windows.Forms.Label
        CType(Me.WSBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeadersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeaderText
        '
        lblHeaderText.AutoSize = True
        lblHeaderText.Location = New System.Drawing.Point(12, 9)
        lblHeaderText.Name = "lblHeaderText"
        lblHeaderText.Size = New System.Drawing.Size(72, 13)
        lblHeaderText.TabIndex = 3
        lblHeaderText.Text = "Header Text: "
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
        'btnHeaderEdit
        '
        Me.btnHeaderEdit.Location = New System.Drawing.Point(248, 51)
        Me.btnHeaderEdit.Name = "btnHeaderEdit"
        Me.btnHeaderEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnHeaderEdit.TabIndex = 5
        Me.btnHeaderEdit.Text = "Edit"
        Me.btnHeaderEdit.UseVisualStyleBackColor = True
        '
        'lblHeaderId
        '
        lblHeaderId.AutoSize = True
        lblHeaderId.Location = New System.Drawing.Point(12, 54)
        lblHeaderId.Name = "lblHeaderId"
        lblHeaderId.Size = New System.Drawing.Size(59, 13)
        lblHeaderId.TabIndex = 5
        lblHeaderId.Text = "Header ID:"
        '
        'cbHeaderId
        '
        Me.cbHeaderId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HeadersBindingSource, "ID", True))
        Me.cbHeaderId.DataSource = Me.HeadersBindingSource
        Me.cbHeaderId.DisplayMember = "ID"
        Me.cbHeaderId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHeaderId.FormattingEnabled = True
        Me.cbHeaderId.Location = New System.Drawing.Point(77, 51)
        Me.cbHeaderId.Name = "cbHeaderId"
        Me.cbHeaderId.Size = New System.Drawing.Size(165, 21)
        Me.cbHeaderId.TabIndex = 6
        Me.cbHeaderId.ValueMember = "ID"
        '
        'txtHeaderText
        '
        Me.txtHeaderText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HeadersBindingSource, "Text", True))
        Me.txtHeaderText.Location = New System.Drawing.Point(12, 25)
        Me.txtHeaderText.Name = "txtHeaderText"
        Me.txtHeaderText.Size = New System.Drawing.Size(311, 20)
        Me.txtHeaderText.TabIndex = 8
        '
        'frmHeaderEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 83)
        Me.Controls.Add(Me.txtHeaderText)
        Me.Controls.Add(lblHeaderId)
        Me.Controls.Add(Me.cbHeaderId)
        Me.Controls.Add(Me.btnHeaderEdit)
        Me.Controls.Add(lblHeaderText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHeaderEdit"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Header"
        CType(Me.WSBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeadersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WSBDataSet As ScriptBuilder_V0._1.WSBDataSet
    Friend WithEvents HeadersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HeadersTableAdapter As ScriptBuilder_V0._1.WSBDataSetTableAdapters.HeadersTableAdapter
    Friend WithEvents TableAdapterManager As ScriptBuilder_V0._1.WSBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnHeaderEdit As System.Windows.Forms.Button
    Friend WithEvents cbHeaderId As System.Windows.Forms.ComboBox
    Friend WithEvents txtHeaderText As System.Windows.Forms.TextBox
End Class
