<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateTimeClose
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
        Me.btnUpdateTime = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblCurrentTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnUpdateTime
        '
        Me.btnUpdateTime.Location = New System.Drawing.Point(17, 19)
        Me.btnUpdateTime.Name = "btnUpdateTime"
        Me.btnUpdateTime.Size = New System.Drawing.Size(145, 52)
        Me.btnUpdateTime.TabIndex = 0
        Me.btnUpdateTime.Text = "Update Time"
        Me.btnUpdateTime.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(17, 107)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(145, 52)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblCurrentTime
        '
        Me.lblCurrentTime.AutoSize = True
        Me.lblCurrentTime.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCurrentTime.Location = New System.Drawing.Point(178, 25)
        Me.lblCurrentTime.Name = "lblCurrentTime"
        Me.lblCurrentTime.Size = New System.Drawing.Size(213, 46)
        Me.lblCurrentTime.TabIndex = 2
        Me.lblCurrentTime.Text = "00:00:00  AM"
        '
        'frmUpdateTimeClose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 189)
        Me.Controls.Add(Me.lblCurrentTime)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnUpdateTime)
        Me.Name = "frmUpdateTimeClose"
        Me.Text = "Update Time or Close"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdateTime As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblCurrentTime As Label
End Class
