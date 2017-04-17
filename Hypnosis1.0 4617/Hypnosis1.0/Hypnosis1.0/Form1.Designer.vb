<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.pbGreen = New System.Windows.Forms.PictureBox()
        Me.pbRed = New System.Windows.Forms.PictureBox()
        Me.StartTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblN = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.BeepTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.CountDownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StopTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblWakeUp = New System.Windows.Forms.Label()
        CType(Me.pbGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbGreen
        '
        Me.pbGreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbGreen.Location = New System.Drawing.Point(12, 12)
        Me.pbGreen.Name = "pbGreen"
        Me.pbGreen.Size = New System.Drawing.Size(619, 391)
        Me.pbGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbGreen.TabIndex = 0
        Me.pbGreen.TabStop = False
        Me.pbGreen.Visible = False
        '
        'pbRed
        '
        Me.pbRed.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbRed.Location = New System.Drawing.Point(12, 12)
        Me.pbRed.Name = "pbRed"
        Me.pbRed.Size = New System.Drawing.Size(619, 391)
        Me.pbRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRed.TabIndex = 1
        Me.pbRed.TabStop = False
        Me.pbRed.Visible = False
        '
        'StartTimer
        '
        Me.StartTimer.Interval = 300
        '
        'lblN
        '
        Me.lblN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblN.AutoSize = True
        Me.lblN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblN.Location = New System.Drawing.Point(12, 436)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(15, 16)
        Me.lblN.TabIndex = 4
        Me.lblN.Text = "1"
        Me.lblN.Visible = False
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnStart.BackColor = System.Drawing.Color.Gray
        Me.btnStart.Location = New System.Drawing.Point(15, 409)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(120, 43)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnStop.BackColor = System.Drawing.Color.Gray
        Me.btnStop.Location = New System.Drawing.Point(141, 409)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(120, 43)
        Me.btnStop.TabIndex = 3
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'lbl2
        '
        Me.lbl2.BackColor = System.Drawing.Color.White
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.Black
        Me.lbl2.Location = New System.Drawing.Point(166, 178)
        Me.lbl2.MaximumSize = New System.Drawing.Size(305, 55)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(305, 55)
        Me.lbl2.TabIndex = 7
        Me.lbl2.Text = "Message2"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl2.Visible = False
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.White
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(166, 178)
        Me.lbl1.MaximumSize = New System.Drawing.Size(305, 55)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(305, 55)
        Me.lbl1.TabIndex = 8
        Me.lbl1.Text = "Message1"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl1.Visible = False
        '
        'BeepTimer
        '
        Me.BeepTimer.Interval = 301
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReset.BackColor = System.Drawing.Color.Gray
        Me.btnReset.Location = New System.Drawing.Point(385, 409)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(120, 43)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Gray
        Me.btnClose.Location = New System.Drawing.Point(511, 409)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(120, 43)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'CountDownTimer
        '
        Me.CountDownTimer.Interval = 1000
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMin.Location = New System.Drawing.Point(292, 422)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(22, 16)
        Me.lblMin.TabIndex = 9
        Me.lblMin.Text = "00"
        Me.lblMin.Visible = False
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSec.Location = New System.Drawing.Point(330, 422)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(22, 16)
        Me.lblSec.TabIndex = 10
        Me.lblSec.Text = "00"
        Me.lblSec.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(313, 422)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = ":"
        Me.Label3.Visible = False
        '
        'StopTimer
        '
        '
        'lblWakeUp
        '
        Me.lblWakeUp.AutoSize = True
        Me.lblWakeUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWakeUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblWakeUp.Location = New System.Drawing.Point(107, 145)
        Me.lblWakeUp.Name = "lblWakeUp"
        Me.lblWakeUp.Size = New System.Drawing.Size(438, 108)
        Me.lblWakeUp.TabIndex = 12
        Me.lblWakeUp.Text = "Wake Up"
        Me.lblWakeUp.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(643, 455)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSec)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblN)
        Me.Controls.Add(Me.pbRed)
        Me.Controls.Add(Me.pbGreen)
        Me.Controls.Add(Me.lblWakeUp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.pbGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbGreen As System.Windows.Forms.PictureBox
    Friend WithEvents pbRed As System.Windows.Forms.PictureBox
    Friend WithEvents StartTimer As System.Windows.Forms.Timer
    Friend WithEvents lblN As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents BeepTimer As System.Windows.Forms.Timer
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents CountDownTimer As System.Windows.Forms.Timer
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents lblSec As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StopTimer As System.Windows.Forms.Timer
    Friend WithEvents lblWakeUp As System.Windows.Forms.Label

End Class
