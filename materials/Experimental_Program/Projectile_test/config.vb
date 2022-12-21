Public Class config
    ' Public form1_exp As New FirstSeasonExp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SetButton.Click
        IDinput = TextBox1.Text

        If G1Button.Checked = True Then
            Generation = 1
        ElseIf G2Button.Checked = True Then
            Generation = 2
        ElseIf G3Button.Checked = True Then
            Generation = 3
        End If



        If INDButton.Checked = True Then
            ExpCondtion = INDIVIDUAL
        ElseIf OBLBUtton.Checked = True Then
            ExpCondtion = OBLIQUE
        ElseIf VERButton.Checked = True Then
            ExpCondtion = VERTICAL
        End If



        If UniButton.Checked = True Then
            IfInitialBimodalInput = 0
        Else
            IfInitialBimodalInput = 1
        End If


        If QuadraticButton.Checked = True Then
            QuadraticLandscape = 1

        End If




        If SppedButton.Checked = True Then

            SpeedMode = 1
        Else
            SpeedMode = 0
        End If

        OKButton.Enabled = True

        InitialL = LengthBox.Value
        InitialW = WidthBox.Value
        InitialT = ThickBox.Value

    End Sub

    Private Sub config_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub SetButton_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub G2Button_CheckedChanged(sender As Object, e As EventArgs) Handles G2Button.CheckedChanged
        LengthBox.Enabled = True
        WidthBox.Enabled = True
        ThickBox.Enabled = True


    End Sub

    Private Sub G3Button_CheckedChanged(sender As Object, e As EventArgs) Handles G3Button.CheckedChanged
        LengthBox.Enabled = True
        WidthBox.Enabled = True
        ThickBox.Enabled = True
    End Sub

    Private Sub G1Button_CheckedChanged(sender As Object, e As EventArgs) Handles G1Button.CheckedChanged
        LengthBox.Enabled = False
        WidthBox.Enabled = False
        ThickBox.Enabled = False
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Me.TopMost = False
        ' form1_exp.Owner = Me
        'form1_exp.Show()
        Me.Close()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class