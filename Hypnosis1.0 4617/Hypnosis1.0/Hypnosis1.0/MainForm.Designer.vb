<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.tbMSG1 = New System.Windows.Forms.TextBox()
        Me.tbMSG2 = New System.Windows.Forms.TextBox()
        Me.lblMSG1 = New System.Windows.Forms.Label()
        Me.lblMSG2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbMin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbSec = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnChooseColor = New System.Windows.Forms.Button()
        Me.pbMSG1Color = New System.Windows.Forms.PictureBox()
        Me.pbMSG2Color = New System.Windows.Forms.PictureBox()
        Me.ttColor1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttColor2 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.pbMSG1Color, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMSG2Color, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Gray
        Me.btnOK.Location = New System.Drawing.Point(5, 302)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(152, 53)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'tbMSG1
        '
        Me.tbMSG1.Location = New System.Drawing.Point(11, 87)
        Me.tbMSG1.Name = "tbMSG1"
        Me.tbMSG1.Size = New System.Drawing.Size(140, 20)
        Me.tbMSG1.TabIndex = 1
        Me.tbMSG1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbMSG2
        '
        Me.tbMSG2.Location = New System.Drawing.Point(11, 146)
        Me.tbMSG2.Name = "tbMSG2"
        Me.tbMSG2.Size = New System.Drawing.Size(140, 20)
        Me.tbMSG2.TabIndex = 2
        Me.tbMSG2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMSG1
        '
        Me.lblMSG1.AutoSize = True
        Me.lblMSG1.BackColor = System.Drawing.Color.Transparent
        Me.lblMSG1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMSG1.Location = New System.Drawing.Point(54, 71)
        Me.lblMSG1.Name = "lblMSG1"
        Me.lblMSG1.Size = New System.Drawing.Size(59, 13)
        Me.lblMSG1.TabIndex = 3
        Me.lblMSG1.Text = "Message 1"
        '
        'lblMSG2
        '
        Me.lblMSG2.AutoSize = True
        Me.lblMSG2.BackColor = System.Drawing.Color.Transparent
        Me.lblMSG2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMSG2.Location = New System.Drawing.Point(54, 130)
        Me.lblMSG2.Name = "lblMSG2"
        Me.lblMSG2.Size = New System.Drawing.Size(59, 13)
        Me.lblMSG2.TabIndex = 4
        Me.lblMSG2.Text = "Message 2"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.Location = New System.Drawing.Point(163, 302)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(152, 53)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(50, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 37)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Hypnosis 1.1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(114, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Minutes"
        '
        'tbMin
        '
        Me.tbMin.Location = New System.Drawing.Point(108, 269)
        Me.tbMin.Name = "tbMin"
        Me.tbMin.Size = New System.Drawing.Size(50, 20)
        Me.tbMin.TabIndex = 7
        Me.tbMin.Text = "0"
        Me.tbMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(165, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Seconds"
        '
        'tbSec
        '
        Me.tbSec.Location = New System.Drawing.Point(164, 269)
        Me.tbSec.Name = "tbSec"
        Me.tbSec.Size = New System.Drawing.Size(50, 20)
        Me.tbSec.TabIndex = 9
        Me.tbSec.Text = "0"
        Me.tbSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(114, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Length of Hypnosis"
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.Gray
        Me.btnAbout.Location = New System.Drawing.Point(5, 361)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(310, 21)
        Me.btnAbout.TabIndex = 12
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'btnChooseColor
        '
        Me.btnChooseColor.BackColor = System.Drawing.Color.Gray
        Me.btnChooseColor.Location = New System.Drawing.Point(108, 181)
        Me.btnChooseColor.Name = "btnChooseColor"
        Me.btnChooseColor.Size = New System.Drawing.Size(112, 20)
        Me.btnChooseColor.TabIndex = 13
        Me.btnChooseColor.Text = "Choose Colors"
        Me.btnChooseColor.UseVisualStyleBackColor = False
        '
        'pbMSG1Color
        '
        Me.pbMSG1Color.BackColor = System.Drawing.Color.White
        Me.pbMSG1Color.Location = New System.Drawing.Point(180, 87)
        Me.pbMSG1Color.Name = "pbMSG1Color"
        Me.pbMSG1Color.Size = New System.Drawing.Size(100, 20)
        Me.pbMSG1Color.TabIndex = 14
        Me.pbMSG1Color.TabStop = False
        '
        'pbMSG2Color
        '
        Me.pbMSG2Color.BackColor = System.Drawing.Color.White
        Me.pbMSG2Color.Location = New System.Drawing.Point(180, 146)
        Me.pbMSG2Color.Name = "pbMSG2Color"
        Me.pbMSG2Color.Size = New System.Drawing.Size(100, 20)
        Me.pbMSG2Color.TabIndex = 15
        Me.pbMSG2Color.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(319, 388)
        Me.Controls.Add(Me.pbMSG2Color)
        Me.Controls.Add(Me.pbMSG1Color)
        Me.Controls.Add(Me.btnChooseColor)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbSec)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbMin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblMSG2)
        Me.Controls.Add(Me.lblMSG1)
        Me.Controls.Add(Me.tbMSG2)
        Me.Controls.Add(Me.tbMSG1)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hypnosis1.1"
        CType(Me.pbMSG1Color, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMSG2Color, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents tbMSG1 As System.Windows.Forms.TextBox
    Friend WithEvents tbMSG2 As System.Windows.Forms.TextBox
    Friend WithEvents lblMSG1 As System.Windows.Forms.Label
    Friend WithEvents lblMSG2 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbMin As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbSec As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnChooseColor As System.Windows.Forms.Button
    Friend WithEvents pbMSG1Color As System.Windows.Forms.PictureBox
    Friend WithEvents pbMSG2Color As System.Windows.Forms.PictureBox
    Friend WithEvents ttColor1 As System.Windows.Forms.ToolTip
    Friend WithEvents ttColor2 As System.Windows.Forms.ToolTip
End Class
