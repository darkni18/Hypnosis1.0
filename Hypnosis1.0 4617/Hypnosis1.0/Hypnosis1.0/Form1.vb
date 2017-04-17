Imports System.IO
Imports Hypnosis1._0.MainForm
Public Class Form1

    'Starts hypnosis
    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        CountDownTimer.Enabled = True
        StartTimer.Enabled = True
        BeepTimer.Enabled = True
    End Sub

    'starts timer for the hypnosis program
    Private Sub StartTimer_Tick(sender As System.Object, e As System.EventArgs) Handles StartTimer.Tick
        If lblN.Text = 1 Then
            pbGreen.Visible = True
            lbl2.Visible = False
            pbRed.Visible = False
            lbl1.Visible = True
            lblN.Text = 0
        ElseIf lblN.Text = 0 Then
            pbGreen.Visible = False
            lbl2.Visible = True
            pbRed.Visible = True
            lbl1.Visible = False
            lblN.Text = 1
        End If
    End Sub

    'Stops timer
    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        CountDownTimer.Enabled = False
        StartTimer.Enabled = False
        BeepTimer.Enabled = False
    End Sub

    'Starts a timer for the beeps that each message has.
    Private Sub BeepTimer_Tick(sender As System.Object, e As System.EventArgs) Handles BeepTimer.Tick
        If lblN.Text = 1 Then
            Console.Beep()
        ElseIf lblN.Text = 0 Then
            Console.Beep(1000, 200)
        End If

    End Sub

    'This closes the Form1 and opens the MainForm back up to input new messages and times.
    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        CountDownTimer.Enabled = False
        StartTimer.Enabled = False
        BeepTimer.Enabled = False
        Close()
        MainForm.Show()

    End Sub

    'Closes program.
    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        CountDownTimer.Enabled = False
        StartTimer.Enabled = False
        BeepTimer.Enabled = False
        Close()
        MainForm.Close()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnStart.Focus()
    End Sub

    'Time count down.
    Private Sub CountDownTimer_Tick(sender As System.Object, e As System.EventArgs) Handles CountDownTimer.Tick
        Dim a As Integer
        Dim b As Integer
        Dim z As Integer
        a = lblSec.Text
        b = lblMin.Text
        z = 1
        lblSec.Text = a - z

       
        If lblSec.Text <= "0" Then
            lblMin.Text = b - z
            lblSec.Text = "59"
        ElseIf lblMin.Text < "0" Or lblMin.Text = "0" And lblSec.Text = "0" Then
            StopTimer.Enabled = True
        End If

    End Sub

    'Stops timer
    Private Sub StopTimer_Tick(sender As System.Object, e As System.EventArgs) Handles StopTimer.Tick
        CountDownTimer.Enabled = False
        StartTimer.Enabled = False
        BeepTimer.Enabled = False
        pbGreen.Visible = False
        lbl1.Visible = False
        pbRed.Visible = False
        lbl2.Visible = False
        lblWakeUp.Visible = True
        lblMin.Text = "0"
        lblSec.Text = "0"

    End Sub
End Class
