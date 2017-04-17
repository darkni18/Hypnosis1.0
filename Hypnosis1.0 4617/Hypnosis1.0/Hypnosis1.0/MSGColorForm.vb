Imports System.IO

Public Class MSGColorForm
    'This code sets up the ComboBox1 for the user to set the color of the messages.
    'The RichTextBox1 is set up to tell the user what influences each color has psychology.
    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Blue" Then
            pbmsg1Color.BackColor = Color.Blue
            RichTextBox1.Text = "Blue =  Intelligence, communication, trust, efficiency, serenity, duty, logic, coolness, reflection, calm."
        ElseIf ComboBox1.Text = "Green" Then
            pbmsg1Color.BackColor = Color.Green
            RichTextBox1.Text = "Green = Harmony, balance, refreshment, universal love, rest, restoration, reassurance, environmental awareness, equilibrium, peace."
        ElseIf ComboBox1.Text = "Red" Then
            pbmsg1Color.BackColor = Color.Red
            RichTextBox1.Text = "Red = Physical courage, strength, warmth, energy, basic survival, 'fight or flight', stimulation, masculinity, excitement."
        ElseIf ComboBox1.Text = "Orange" Then
            pbmsg1Color.BackColor = Color.Orange
            RichTextBox1.Text = "Orange = Physical comfort, food, warmth, security, sensuality, passion, abundance, fun. "
        ElseIf ComboBox1.Text = "Yellow" Then
            pbmsg1Color.BackColor = Color.Yellow
            RichTextBox1.Text = "Yellow = Optimism, confidence, self-esteem, extraversion, emotional strength, friendliness, creativity."
        ElseIf ComboBox1.Text = "Pink" Then
            pbmsg1Color.BackColor = Color.Pink
            RichTextBox1.Text = "Pink = Physical tranquillity, nurture, warmth, femininity, love, sexuality, survival of the species. "
        ElseIf ComboBox1.Text = "Violet" Then
            pbmsg1Color.BackColor = Color.Violet
            RichTextBox1.Text = "Violet = Spiritual awareness, containment, vision, luxury, authenticity, truth, quality."
        ElseIf ComboBox1.Text = "Purple" Then
            pbmsg1Color.BackColor = Color.Purple
            RichTextBox1.Text = "Purple = spirituality, power, dignity, royalty, magic, wisdom, mystery, containment, vision, luxury, quality, authenticity, truth, creativity, peace, calm."
        End If
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        MainForm.pbMSG1Color.BackColor = pbmsg1Color.BackColor
        MainForm.ttColor1.SetToolTip(MainForm.pbMSG1Color, RichTextBox1.Text)
        MainForm.pbMSG2Color.BackColor = pbmsg2Color.BackColor
        MainForm.ttColor2.SetToolTip(MainForm.pbMSG2Color, RichTextBox2.Text)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    'This code sets up the ComboBox2 for the user to set the color of the messages.
    'The RichTextBox2 is set up to tell the user what influences each color has psychology.
    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Blue" Then
            pbmsg2Color.BackColor = Color.Blue
            RichTextBox2.Text = "Blue =  Intelligence, communication, trust, efficiency, serenity, duty, logic, coolness, reflection, calm."
        ElseIf ComboBox2.Text = "Green" Then
            pbmsg2Color.BackColor = Color.Green
            RichTextBox2.Text = "Green = Harmony, balance, refreshment, universal love, rest, restoration, reassurance, environmental awareness, equilibrium, peace."
        ElseIf ComboBox2.Text = "Red" Then
            pbmsg2Color.BackColor = Color.Red
            RichTextBox2.Text = "Red = Physical courage, strength, warmth, energy, basic survival, 'fight or flight', stimulation, masculinity, excitement."
        ElseIf ComboBox2.Text = "Orange" Then
            pbmsg2Color.BackColor = Color.Orange
            RichTextBox2.Text = "Orange = Physical comfort, food, warmth, security, sensuality, passion, abundance, fun. "
        ElseIf ComboBox2.Text = "Yellow" Then
            pbmsg2Color.BackColor = Color.Yellow
            RichTextBox2.Text = "Yellow = Optimism, confidence, self-esteem, extraversion, emotional strength, friendliness, creativity."
        ElseIf ComboBox2.Text = "Pink" Then
            pbmsg2Color.BackColor = Color.Pink
            RichTextBox2.Text = "Pink = Physical tranquillity, nurture, warmth, femininity, love, sexuality, survival of the species. "
        ElseIf ComboBox2.Text = "Violet" Then
            pbmsg2Color.BackColor = Color.Violet
            RichTextBox2.Text = "Violet = Spiritual awareness, containment, vision, luxury, authenticity, truth, quality."
        ElseIf ComboBox2.Text = "Purple" Then
            pbmsg2Color.BackColor = Color.Purple
            RichTextBox2.Text = "Purple = spirituality, power, dignity, royalty, magic, wisdom, mystery, containment, vision, luxury, quality, authenticity, truth, creativity, peace, calm."
        End If
    End Sub
End Class