Public Class FirstSeasonExp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        StaringMode = 1
        If DonotwantButton.Checked = True Then
            Gender = NOANSWER_G
            Age = AgeBox.Value
            Me.Close()
        ElseIf FemaleButton.Checked = True Then
            Gender = FEMALE_G
            Age = AgeBox.Value
            Me.Close()
        ElseIf MaleButton.Checked = True Then
            Gender = MALE_G
            Age = AgeBox.Value
            Me.Close()
        ElseIf NotSureButton.Checked = True Then
            Gender = NOTSURE_G
            Age = AgeBox.Value
            Me.Close()
        ElseIf OtherButton.Checked = True Then
            Gender = OTHER_G
            Age = AgeBox.Value
            Me.Close()
        Else
            MsgBox("ジェンダー・性別に関して回答を選択してください")
        End If

    End Sub

    Private Sub FirstSeasonExp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label3.Focus()

        If ExpCondtion = INDIVIDUAL Then
            CondLabel.Text = "IDV"
        ElseIf ExpCondtion = OBLIQUE Then
            CondLabel.Text = "OBL"
        ElseIf ExpCondtion = VERTICAL Then
            CondLabel.Text = "VER"
        End If

        If SpeedMode = 1 Then
            CondLabel.Text = CondLabel.Text & "バグ取りモード(注意)”

        End If


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles OtherButton.CheckedChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    'Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
    '    Button1.BackColor = Color.Red
    'End Sub
End Class