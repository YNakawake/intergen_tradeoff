Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IfInputInitialSoc = 0 Then
            ' SocialLabel.Visible = False
        Else
            '  SocialLabel.Visible = True
        End If

    End Sub

    Private Sub HunterAppearLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub GoHunting()
        ActionMode = HUNTING
        Form1.Owner = Me


        F1Activater = 1
        Form1.Activate()
        Me.Visible = False

    End Sub

    Private Sub GoKnapping()
        ActionMode = KNAPPING


        F1Activater = 1
        Form1.Activate()
        Me.Visible = False
    End Sub


    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles KnappingPanel.Click
        GoKnapping()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles KnappingPic.Click
        GoKnapping()
    End Sub

    Private Sub KnappingLabel_Click(sender As Object, e As EventArgs) Handles KnappingLabel.Click
        GoKnapping()
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles HunttingPanel.Click
        GoHunting()
    End Sub

    Private Sub HuntingLabel_Click(sender As Object, e As EventArgs) Handles HuntingLabel.Click
        GoHunting()
    End Sub

    Private Sub HuntingPic_Click(sender As Object, e As EventArgs) Handles HuntingPic.Click
        GoHunting()
    End Sub

End Class