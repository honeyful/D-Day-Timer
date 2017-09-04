<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.Clock = New System.Windows.Forms.Timer(Me.components)
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TrayContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StartupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowDateTimePickerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayContextMenuStrip.SuspendLayout()
        Me.FormContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelTime
        '
        Me.LabelTime.AutoSize = True
        Me.LabelTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelTime.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTime.ForeColor = System.Drawing.Color.White
        Me.LabelTime.Location = New System.Drawing.Point(12, 9)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(0, 24)
        Me.LabelTime.TabIndex = 0
        '
        'Clock
        '
        '
        'ColorDialog
        '
        Me.ColorDialog.Color = System.Drawing.Color.White
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Location = New System.Drawing.Point(81, 32)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(403, 21)
        Me.DateTimePicker.TabIndex = 2
        Me.DateTimePicker.Visible = False
        '
        'TrayIcon
        '
        Me.TrayIcon.ContextMenuStrip = Me.TrayContextMenuStrip
        Me.TrayIcon.Icon = CType(resources.GetObject("TrayIcon.Icon"), System.Drawing.Icon)
        Me.TrayIcon.Text = "vTimer"
        Me.TrayIcon.Visible = True
        '
        'TrayContextMenuStrip
        '
        Me.TrayContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartupToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.TrayContextMenuStrip.Name = "ContextMenu"
        Me.TrayContextMenuStrip.Size = New System.Drawing.Size(114, 48)
        '
        'StartupToolStripMenuItem
        '
        Me.StartupToolStripMenuItem.Name = "StartupToolStripMenuItem"
        Me.StartupToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.StartupToolStripMenuItem.Text = "Startup"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'FormContextMenuStrip
        '
        Me.FormContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowDateTimePickerToolStripMenuItem})
        Me.FormContextMenuStrip.Name = "FormContextMenuStrip"
        Me.FormContextMenuStrip.Size = New System.Drawing.Size(192, 48)
        '
        'ShowDateTimePickerToolStripMenuItem
        '
        Me.ShowDateTimePickerToolStripMenuItem.Name = "ShowDateTimePickerToolStripMenuItem"
        Me.ShowDateTimePickerToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ShowDateTimePickerToolStripMenuItem.Text = "Show DateTimePicker"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(496, 56)
        Me.ContextMenuStrip = Me.FormContextMenuStrip
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.LabelTime)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TrayContextMenuStrip.ResumeLayout(False)
        Me.FormContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTime As Label
    Friend WithEvents Clock As Timer
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents TrayIcon As NotifyIcon
    Friend WithEvents TrayContextMenuStrip As ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormContextMenuStrip As ContextMenuStrip
    Friend WithEvents ShowDateTimePickerToolStripMenuItem As ToolStripMenuItem
End Class
