<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNpcDelete
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
        Dim lblNpcId As System.Windows.Forms.Label
        Me.WSBDataSet = New ScriptBuilder_V0._1.WSBDataSet
        Me.NPCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NPCTableAdapter = New ScriptBuilder_V0._1.WSBDataSetTableAdapters.NPCTableAdapter
        Me.TableAdapterManager = New ScriptBuilder_V0._1.WSBDataSetTableAdapters.TableAdapterManager
        Me.cbNpcId2 = New System.Windows.Forms.ComboBox
        Me.btnNpcDelete = New System.Windows.Forms.Button
        lblNpcId = New System.Windows.Forms.Label
        CType(Me.WSBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NPCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNpcId
        '
        lblNpcId.AutoSize = True
        lblNpcId.Location = New System.Drawing.Point(12, 15)
        lblNpcId.Name = "lblNpcId"
        lblNpcId.Size = New System.Drawing.Size(21, 13)
        lblNpcId.TabIndex = 1
        lblNpcId.Text = "ID:"
        '
        'WSBDataSet
        '
        Me.WSBDataSet.DataSetName = "WSBDataSet"
        Me.WSBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NPCBindingSource
        '
        Me.NPCBindingSource.DataMember = "NPC"
        Me.NPCBindingSource.DataSource = Me.WSBDataSet
        '
        'NPCTableAdapter
        '
        Me.NPCTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CommentsTableAdapter = Nothing
        Me.TableAdapterManager.HeadersTableAdapter = Nothing
        Me.TableAdapterManager.NPCTableAdapter = Me.NPCTableAdapter
        Me.TableAdapterManager.UpdateOrder = ScriptBuilder_V0._1.WSBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'cbNpcId2
        '
        Me.cbNpcId2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NPCBindingSource, "ID", True))
        Me.cbNpcId2.DataSource = Me.NPCBindingSource
        Me.cbNpcId2.DisplayMember = "NPCID"
        Me.cbNpcId2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNpcId2.FormattingEnabled = True
        Me.cbNpcId2.Location = New System.Drawing.Point(39, 12)
        Me.cbNpcId2.Name = "cbNpcId2"
        Me.cbNpcId2.Size = New System.Drawing.Size(138, 21)
        Me.cbNpcId2.TabIndex = 2
        Me.cbNpcId2.ValueMember = "ID"
        '
        'btnNpcDelete
        '
        Me.btnNpcDelete.Location = New System.Drawing.Point(183, 12)
        Me.btnNpcDelete.Name = "btnNpcDelete"
        Me.btnNpcDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnNpcDelete.TabIndex = 3
        Me.btnNpcDelete.Text = "Delete"
        Me.btnNpcDelete.UseVisualStyleBackColor = True
        '
        'frmNpcDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 47)
        Me.Controls.Add(Me.btnNpcDelete)
        Me.Controls.Add(lblNpcId)
        Me.Controls.Add(Me.cbNpcId2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNpcDelete"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Delete NPC"
        CType(Me.WSBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NPCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WSBDataSet As ScriptBuilder_V0._1.WSBDataSet
    Friend WithEvents NPCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NPCTableAdapter As ScriptBuilder_V0._1.WSBDataSetTableAdapters.NPCTableAdapter
    Friend WithEvents TableAdapterManager As ScriptBuilder_V0._1.WSBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents cbNpcId2 As System.Windows.Forms.ComboBox
    Friend WithEvents btnNpcDelete As System.Windows.Forms.Button
End Class
