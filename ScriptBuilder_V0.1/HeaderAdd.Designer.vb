<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHeaderAdd
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
        Me.txtHeaderText = New System.Windows.Forms.TextBox
        Me.HeadersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WSBDataSet = New ScriptBuilder_V0._1.WSBDataSet
        Me.btnHeaderAdd = New System.Windows.Forms.Button
        Me.HeadersTableAdapter = New ScriptBuilder_V0._1.WSBDataSetTableAdapters.HeadersTableAdapter
        Me.TableAdapterManager = New ScriptBuilder_V0._1.WSBDataSetTableAdapters.TableAdapterManager
        lblHeaderText = New System.Windows.Forms.Label
        CType(Me.HeadersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WSBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeaderText
        '
        lblHeaderText.AutoSize = True
        lblHeaderText.Location = New System.Drawing.Point(12, 9)
        lblHeaderText.Name = "lblHeaderText"
        lblHeaderText.Size = New System.Drawing.Size(72, 13)
        lblHeaderText.TabIndex = 1
        lblHeaderText.Text = "Header Text: "
        '
        'txtHeaderText
        '
        Me.txtHeaderText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HeadersBindingSource, "Text", True))
        Me.txtHeaderText.Location = New System.Drawing.Point(12, 25)
        Me.txtHeaderText.Name = "txtHeaderText"
        Me.txtHeaderText.Size = New System.Drawing.Size(311, 20)
        Me.txtHeaderText.TabIndex = 2
        '
        'HeadersBindingSource
        '
        Me.HeadersBindingSource.DataMember = "Headers"
        Me.HeadersBindingSource.DataSource = Me.WSBDataSet
        '
        'WSBDataSet
        '
        Me.WSBDataSet.DataSetName = "WSBDataSet"
        Me.WSBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnHeaderAdd
        '
        Me.btnHeaderAdd.Location = New System.Drawing.Point(248, 51)
        Me.btnHeaderAdd.Name = "btnHeaderAdd"
        Me.btnHeaderAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnHeaderAdd.TabIndex = 3
        Me.btnHeaderAdd.Text = "Add"
        Me.btnHeaderAdd.UseVisualStyleBackColor = True
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
        'frmHeaderAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 83)
        Me.Controls.Add(Me.btnHeaderAdd)
        Me.Controls.Add(lblHeaderText)
        Me.Controls.Add(Me.txtHeaderText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHeaderAdd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Header"
        CType(Me.HeadersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WSBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WSBDataSet As ScriptBuilder_V0._1.WSBDataSet
    Friend WithEvents HeadersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HeadersTableAdapter As ScriptBuilder_V0._1.WSBDataSetTableAdapters.HeadersTableAdapter
    Friend WithEvents TableAdapterManager As ScriptBuilder_V0._1.WSBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtHeaderText As System.Windows.Forms.TextBox
    Friend WithEvents btnHeaderAdd As System.Windows.Forms.Button
End Class
