Imports System.IO

Public Class MainForm

    'After hitting ok button the form1 will pop up and the informaion entered will then be used.
    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If tbMin.Text = Nothing Then
            MessageBox.Show("Please enter number in Minutes Text Box!")
        ElseIf tbSec.Text = Nothing Then
            MessageBox.Show("Please enter number in Seconds Text Box!")
        Else
            Form1.lbl1.Text = tbMSG1.Text
            Form1.pbGreen.BackColor = pbMSG1Color.BackColor
            Form1.lbl1.BackColor = pbMSG1Color.BackColor
            Form1.lbl2.Text = tbMSG2.Text
            Form1.pbRed.BackColor = pbMSG2Color.BackColor
            Form1.lbl2.BackColor = pbMSG2Color.BackColor
            Form1.lblMin.Text = tbMin.Text
            Form1.lblSec.Text = tbSec.Text
            Hide()
            Form1.Show()
        End If
       

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Close()

    End Sub

    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tbMSG1.Select()
    End Sub

    Private Sub btnAbout_Click(sender As System.Object, e As System.EventArgs) Handles btnAbout.Click
        AboutForm.ShowDialog()
    End Sub

    'Opens up a dialog to pick a color for each message box.
    Private Sub btnChooseColor_Click(sender As System.Object, e As System.EventArgs) Handles btnChooseColor.Click
        Dim mcf As New MSGColorForm
        mcf.ShowDialog()
    End Sub


    'Sets up minutes.
    Private Sub tbMin_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbMin.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    'Sets up seconds.
    Private Sub tbSec_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbSec.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub
End Class