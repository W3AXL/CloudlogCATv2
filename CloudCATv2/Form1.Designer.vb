<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRigFreq = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblRigMode = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblRigStatus = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloudlogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OmnirigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransverterOffsetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblCloudlogStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.fldRigSelection = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RX"
        '
        'lblRigFreq
        '
        Me.lblRigFreq.AutoSize = True
        Me.lblRigFreq.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRigFreq.Location = New System.Drawing.Point(12, 66)
        Me.lblRigFreq.Name = "lblRigFreq"
        Me.lblRigFreq.Size = New System.Drawing.Size(35, 15)
        Me.lblRigFreq.TabIndex = 2
        Me.lblRigFreq.Text = "0.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(111, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mode"
        '
        'lblRigMode
        '
        Me.lblRigMode.AutoSize = True
        Me.lblRigMode.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRigMode.Location = New System.Drawing.Point(111, 66)
        Me.lblRigMode.Name = "lblRigMode"
        Me.lblRigMode.Size = New System.Drawing.Size(49, 15)
        Me.lblRigMode.TabIndex = 5
        Me.lblRigMode.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(199, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Status"
        '
        'lblRigStatus
        '
        Me.lblRigStatus.AutoSize = True
        Me.lblRigStatus.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRigStatus.Location = New System.Drawing.Point(199, 66)
        Me.lblRigStatus.Name = "lblRigStatus"
        Me.lblRigStatus.Size = New System.Drawing.Size(49, 15)
        Me.lblRigStatus.TabIndex = 7
        Me.lblRigStatus.Text = "Label8"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(462, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SettingsToolStripMenuItem1
        '
        Me.SettingsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloudlogToolStripMenuItem, Me.OmnirigToolStripMenuItem, Me.TransverterOffsetToolStripMenuItem})
        Me.SettingsToolStripMenuItem1.Name = "SettingsToolStripMenuItem1"
        Me.SettingsToolStripMenuItem1.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem1.Text = "Settings"
        '
        'CloudlogToolStripMenuItem
        '
        Me.CloudlogToolStripMenuItem.Name = "CloudlogToolStripMenuItem"
        Me.CloudlogToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.CloudlogToolStripMenuItem.Text = "Cloudlog"
        '
        'OmnirigToolStripMenuItem
        '
        Me.OmnirigToolStripMenuItem.Name = "OmnirigToolStripMenuItem"
        Me.OmnirigToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.OmnirigToolStripMenuItem.Text = "Omnirig"
        '
        'TransverterOffsetToolStripMenuItem
        '
        Me.TransverterOffsetToolStripMenuItem.Name = "TransverterOffsetToolStripMenuItem"
        Me.TransverterOffsetToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.TransverterOffsetToolStripMenuItem.Text = "Transverter Offset"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblCloudlogStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 98)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(462, 22)
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblCloudlogStatus
        '
        Me.lblCloudlogStatus.Name = "lblCloudlogStatus"
        Me.lblCloudlogStatus.Size = New System.Drawing.Size(86, 17)
        Me.lblCloudlogStatus.Text = "cloudlogStatus"
        '
        'fldRigSelection
        '
        Me.fldRigSelection.FormattingEnabled = True
        Me.fldRigSelection.Location = New System.Drawing.Point(309, 64)
        Me.fldRigSelection.Name = "fldRigSelection"
        Me.fldRigSelection.Size = New System.Drawing.Size(141, 21)
        Me.fldRigSelection.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(306, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Rig Selection"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 120)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fldRigSelection)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblRigStatus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblRigMode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblRigFreq)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "CloudlogCAT"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblRigFreq As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblRigMode As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblRigStatus As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CloudlogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OmnirigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblCloudlogStatus As ToolStripStatusLabel
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransverterOffsetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents fldRigSelection As ComboBox
    Friend WithEvents Label2 As Label
End Class
