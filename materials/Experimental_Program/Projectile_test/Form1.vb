Public Class Form1


    '0928
    ' I did not use the first item of a array e.g. AnyVector(0) for the most case, in order to avoid cofusion
    Public ALength As Integer 'Height 250 pic = 100 thus 
    Public AWidth As Integer
    Public AThick As Integer
    Public CurrentImage As Image
    Public AColour As Integer : Public AShape As Integer
    Public BoxlocationX As Integer : Public BoxlocationY As Integer
    Public Bonus As String

    Public CurPoint As Integer : Public PrevPoint As Integer : Public SumPoint As Integer
    Public CurPointBeforeRand As Integer
    Public MaxDays As Integer
    Public Today As Integer

    Private f1 As New FirstSeasonExp
    Private f2 As New Form2
    Private f3 As New Form3
    ' Public backf As New backform

    'constant maltiplied to each weight
    Public bWl As Double : Public bWw As Double : Public bWt As Double : Public bWs As Double

    Public Ol1 As Integer : Public Ol2 As Integer
    Public Ow1 As Integer : Public Ow2 As Integer
    Public Ot1 As Integer : Public Ot2 As Integer
    Public Season As Integer = 1


    Public Wl1 As Double : Public Wl2 As Double : Public Wl As Double
    ' Note Height and Length used interchangeably
    Public Ww1 As Double : Public Ww2 As Double : Public Ww As Double
    Public Wt1 As Double : Public Wt2 As Double : Public Wt As Double
    Public tempRnd As Double

    Public SubOptimalCoef As Double = 0.66

    Public WsValue(4) As Double
    Public WsRank(4) As Integer
    Public tempRank As Integer
    Public Ws As Double
    Public OptShapeRank(4) As Integer
    Public CurShapeRank As Integer

    Public WSum As Double
    Public OtherPlayerVal(100, 5, 7) As Integer 'OtherPlay(time, PlayNum. (0,l,w,t,s,c,sum, witherror), value

    Public ChangeRate As Double
    Public ChangeSigma As Integer

    Public OutPutFileName As String
    Public LogFileName As String
    Public TidyDataName As String

    'Public OtherPicture() As System.Windows.Forms.PictureBox
    '    Private Vallab() As System.Windows.Forms.Label

    'Private OtherPicture() As ComboBox


    'to avoid being a magic number
    Public LENGTH_INDEX As Integer = 1 : Public WIDTH_INDEX As Integer = 2
    Public THICK_INDEX As Integer = 3 : Public SHAPE_INDEX As Integer = 4 : Public COLOUR_INDEX As Integer = 5

    Public WatchArrowNumbers(4) As Integer
    Public WatchArrowDuration(4) As TimeSpan
    Public LastViewArrow As Integer

    Public OtherHunterSwitch As Integer
    Public OpenTimeStr As String
    Public CurTimeStr As String

    Public TotalChange(5) As Integer


    Public Button_TimeKeeper As New System.Diagnostics.Stopwatch()
    Public Trial_TimeKeeper As New System.Diagnostics.Stopwatch()
    Public General_TimeKeeper As New System.Diagnostics.Stopwatch()
    Public HuntDuration As New TimeSpan

    Public IfBiModal As Integer = 0

    Public ParaChangeRecorder(5) As Integer

    Public WatchHunterCost As Integer = 5

    Public ID As String
    Public Pay2See As Integer

    Public gagecounter As Integer

    Public MaxPoint As Double
    Public OffLinePerformance As Double


    Public SocLearningMean As Integer = 10
    Public SocLearningSD As Integer = 10
    Public SocLearningDirection As Integer = 0
    Public tempSocLearDirectionRnd As Integer = 0

    Public MaxChangeUnit As Integer = 5
    Public CurModifyingDimention As Integer = 0 'Public LENGTH_INDEX As Integer = 1 : Public WIDTH_INDEX As Integer = 2 Public THICK_INDEX As Integer = 3


    Public LastAction As Integer


    Public SocLearningOppt As Integer = 1





    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Randomize()
        ID = IDinput
        SocLearningOppt = IfInputInitialSoc
        'SocLearningOppt = 2 '0





        IfBiModal = IfInitialBimodalInput


        Button_TimeKeeper.Restart()


        'OtherPicture = {Me.MainPictureBox1, Me.OtherPicture1, Me.OtherPicture2, Me.OtherPicture3, Me.OtherPicture4}


        ' backf.Owner = Me
        ' backf.Show()
        ' Me.Owner = Nothing
        Me.TopMost = True



        Me.TopMost = False


        OpenTimeStr = Format(Now, "yyyyMMddhhmmss")
        OutPutFileName = "..\..\OutData\" & OpenTimeStr & "_" & ID & ".txt"
        FileOpen(10, OutPutFileName, OpenMode.Output)
        FileClose(10)






        LogFileName = "..\..\Log\" & OpenTimeStr & "_" & ID & ".txt"
        FileOpen(15, LogFileName, OpenMode.Output)
        Write(15, OpenTimeStr)




        ChangeSigma = 5 '5 'should be 5
        ChangeRate = 0.4

        Write(15, "Generation" & Generation)
        Write(15, ChangeSigma)
        Write(15, ChangeRate)




        MaxDays = 50 '30
        LeftDayValueL.Text = MaxDays
        MaxPoint = 1000
        bWl = 0.275
        bWw = 0.25
        bWt = 0.35
        bWs = 0.125



        'Ol1 = 73
        'Ol2 = 33
        'Ow1 = 21
        'Ow2 = 60
        'Ot1 = 83
        'Ot2 = 12
        'OptShapeRank = {0, 3, 2, 1, 4}

        If QuadraticLandscape = 1 Then
            Ol1 = 70
            Ow1 = 48
            Ot1 = 11

            ' bWl = 0.25
            'bWw = 0.4
            'bWt = 0.35
            'bWs = 0

            bWl = 0.275
            bWw = 0.375
            bWt = 0.35
            bWs = 0

            LengthBox.Value = 14
            WidthBox.Value = 6
            ThickBox.Value = 83

        Else
            Ol1 = 30
            ' Ol2 = 71
            Ow1 = 63
            ' Ow2 = 7
            Ot1 = 34
            ' Ot2 = 60

            LengthBox.Value = 52
            WidthBox.Value = 22
            ThickBox.Value = 75

            bWl = 0.275
            bWw = 0.375
            bWt = 0.35
            bWs = 0

            ' bWl = 0.275
            ' bWw = 0.25
            ' bWt = 0.35
            ' bWs = 0.125
        End If



        Write(15, MaxDays) : Write(15, MaxPoint)
        Write(15, "weight")
        Write(15, bWl) : Write(15, bWw) : Write(15, bWt) : Write(15, bWs)



        OptShapeRank = {0, 3, 4, 2, 1}


        Write(15, ID)
        Write(15, ExpCondtion)


        Write(15, QuadraticLandscape)


        Write(15, "participant")

        Write(15, Gender)
        Write(15, Age)

        Write(15, "parameta")
        Write(15, MaxDays)
        Write(15, Wl1)
        Write(15, Ww1)
        Write(15, Wt1)
        Write(15, ChangeSigma)

        Write(15, "initial")
        Write(15, LengthBox.Value)
        Write(15, WidthBox.Value)
        Write(15, ThickBox.Value)


        Write(15, "optima")
        Write(15, Ol1) : Write(15, Ol2) : Write(15, Ow1) : Write(15, Ow2) : Write(15, Ot1) : Write(15, Ot2)

        Write(15, "Shape")

        WsValue = {0, 1, 1, 1, 1}
        '  WsValue = {0, 1, 0.9, 0.66, 0.33} 'Mesoudi(2008), Ws[rank] give you the Ws[1] =1 , Ws[2] =0.9, Ws[3] = 0.66, Ws[4] =0.33

        'Write(15, WsValue(1)) : Write(15, WsValue(2)) : Write(15, WsValue(3)) : Write(15, WsValue(4))
        'Write(15, OptShapeRank(1)) : Write(15, OptShapeRank(2)) : Write(15, OptShapeRank(3)) : Write(15, OptShapeRank(4))

        Today = 1
        BoxlocationX = MainPictureBox1.Location.X
        BoxlocationY = MainPictureBox1.Location.Y
        SumPoint = 0




        FileClose(15)





        'Need to be channged later
        'ShapeBox.SetSelected(0, True)
        'ColourBox.SetSelected(0, True)

        MainPictureBox1.Visible = False
        NextButton.Enabled = False
        CurPointValueL.Visible = False
        PointGage.Visible = False
        GageBack.Visible = False




        ' ShapeBox.SelectedIndex = 2 - 1
        ' ColourBox.SelectedIndex = 3 - 1
        LengthBox.Enabled = False
        WidthBox.Enabled = False
        ThickBox.Enabled = False
        'ShapeBox.Enabled = False
        'ColourBox.Enabled = False
        KnappingButton.Enabled = False
        NextKnapButton.Enabled = False

        f1.Owner = Me
        f1.Show()

        redraw()
        MainPictureBox1.Visible = False



    End Sub



    Private Sub redraw()
        MainPictureBox1.Visible = True
        'AShape = ShapeBox.SelectedIndex + 1
        'AColour = ColourBox.SelectedIndex + 1


        ALength = LengthBox.Value
        AWidth = WidthBox.Value
        AThick = ThickBox.Value

        AShape = 3
        AColour = 4

        If AShape = 1 Then
            If AColour = 1 Then
                CurrentImage = My.Resources._1s
            ElseIf AColour = 2 Then
                CurrentImage = My.Resources._1h
            ElseIf AColour = 3 Then
                CurrentImage = My.Resources._1o
            ElseIf AColour = 4 Then
                CurrentImage = My.Resources._1w
            End If
        ElseIf AShape = 2 Then
            If AColour = 1 Then
                CurrentImage = My.Resources._2s
            ElseIf AColour = 2 Then
                CurrentImage = My.Resources._2h
            ElseIf AColour = 3 Then
                CurrentImage = My.Resources._2o
            ElseIf AColour = 4 Then
                CurrentImage = My.Resources._2w
            End If
        ElseIf AShape = 3 Then
            If AColour = 1 Then
                CurrentImage = My.Resources._3s
            ElseIf AColour = 2 Then
                CurrentImage = My.Resources._3h
            ElseIf AColour = 3 Then
                CurrentImage = My.Resources._3o
            ElseIf AColour = 4 Then
                CurrentImage = My.Resources._3w
            End If
        ElseIf AShape = 4 Then
            If AColour = 1 Then
                CurrentImage = My.Resources._4s
            ElseIf AColour = 2 Then
                CurrentImage = My.Resources._4h
            ElseIf AColour = 3 Then
                CurrentImage = My.Resources._4o
            ElseIf AColour = 4 Then
                CurrentImage = My.Resources._4w
            End If
        End If

        MainPictureBox1.Left = BoxlocationX - AWidth + 100
        MainPictureBox1.Top = BoxlocationY - ALength + 100


        MainPictureBox1.Height = 100 + ALength * 2
        MainPictureBox1.Width = 100 + AWidth * 2
        MainPictureBox1.Image = CurrentImage
        MainPictureBox1.Visible = True





    End Sub


    Private Sub HeightBox_ValueChanged_1(sender As Object, e As EventArgs) Handles LengthBox.ValueChanged
        If Today > 1 Then
            ' redraw()
            'ParaChangeRecorder(LENGTH_INDEX) = ParaChangeRecorder(LENGTH_INDEX) + 1
            'tmplabel.Text = ParaChangeRecorder(LENGTH_INDEX)
            KnappingButton.BackColor = Color.PaleGreen
            KnappingButton.Enabled = True
        End If
    End Sub

    Private Sub WidthBox_ValueChanged(sender As Object, e As EventArgs) Handles WidthBox.ValueChanged
        If Today > 1 Then
            KnappingButton.Enabled = True
            KnappingButton.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub ThickBox_ValueChanged(sender As Object, e As EventArgs) Handles ThickBox.ValueChanged
        If Today > 1 Then
            KnappingButton.Enabled = True
            KnappingButton.BackColor = Color.PaleGreen
        End If
    End Sub




    Private Sub ShowButtonClick(sender As Object, e As EventArgs) Handles KnappingButton.Click
        KnappingButton.BackColor = Color.White
        LengthBox.Enabled = False
        LengthBox.BackColor = Color.White
        ThickBox.Enabled = False
        ThickBox.BackColor = Color.White
        WidthBox.Enabled = False
        WidthBox.BackColor = Color.White


        If SpeedMode = 1 Then
            KnappingTimer.Interval = 1
        Else
            KnappingTimer.Interval = 1000
        End If

        KnappingTimer.Enabled = True
        KnappingButton.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        KnappingLabel.Visible = True
        KnappingPictureBox.Visible = True

        MessageLabel.Text = "矢尻の形が新しくなりました!（注：厚さを変えても画像に変化はありません）。" & Environment.NewLine & Environment.NewLine & " 「次の日へ」を押して進んでください。"

    End Sub
    Private Sub KnappingTimer_Tick(sender As Object, e As EventArgs) Handles KnappingTimer.Tick
        KnappingTimer.Interval = 2000
        NextKnapButton.Enabled = True
        KnappingTimer.Enabled = False
        Me.Cursor = Cursors.Default
        NextKnapButton.BackColor = Color.PaleGreen
        KnappingLabel.Visible = False
        KnappingPictureBox.Visible = False
        redraw()
    End Sub








    Private Sub HuntButton_Click(sender As Object, e As EventArgs) Handles HuntButton.Click

        redraw()
        KnappingButton.Enabled = False
        Me.Cursor = Cursors.WaitCursor

        HuntButton.BackColor = Color.White

        HuntDuration = General_TimeKeeper.Elapsed


        'HunterAppearLabel.Visible = False


        'HiddingLabel.Enabled = False
        'HiddingLabel.Text = ""
        'HiddingLabel.BackColor = Color.Gainsboro
        'HiddingLabel.Visible = True


        'CalcPoint()
        CalcPoint_f(ALength, AWidth, AThick, AShape)
        CurPointBeforeRand = CalcPoint_f(ALength, AWidth, AThick, AShape)
        OffLinePerformance = CurPointBeforeRand
        CurPoint = Int(CurPointBeforeRand + rnorm(0, ChangeSigma))

        CurPoint = CeilingFloor(CurPoint)

        'CurPointValueL.Text = Str(CurPoint)
        CurPointValueL.Text = "0"
        CurPointValueL.Visible = True
        CurPointLabel.Visible = True
        CurPointLabel2.Visible = True
        'PointGage.Width = 5 * CurPoint / 10
        PointGage.Visible = True

        CurPointValueL.Visible = True
        GageBack.Visible = True
        PointGage.Visible = True

        GageTimer.Interval = 10
        GageUp()
        gagecounter = 0

        HuntButton.Enabled = False

        LengthBox.Enabled = False
        WidthBox.Enabled = False
        ThickBox.Enabled = False
        'ColourBox.Enabled = False
        'ShapeBox.Enabled = False
        'OtherPlayers()

        MessageLabel.Text = "狩りを行っています。お待ちください。"


        If SpeedMode = 1 Then
            Timer1.Interval = 1
        Else
            Timer1.Interval = 1200
        End If
        Timer1.Enabled = True
        ' For Other Players
    End Sub


    Private Sub GageUp()


        If gagecounter < (CurPoint - 30) Then
            GageTimer.Interval = 10
            GageTimer.Enabled = True
        Else
            CurPointValueL.Text = Str(CurPoint)
            PointGage.Width = 5 * CurPoint / 10
            gagecounter = 0
        End If

    End Sub

    Private Sub GageTimer_Tick(sender As Object, e As EventArgs) Handles GageTimer.Tick
        GageTimer.Enabled = False
        Dim r As New Random

        gagecounter = gagecounter + 30
        CurPointValueL.Text = Str(Int(CurPointValueL.Text) + 30 + r.Next(1, 9))
        'CurPointValueL.Text = Str(CurPoint)
        PointGage.Width = (CurPoint Mod 30) / 2 + 5 * gagecounter / 10
        GageUp()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        PrePointLabel.Visible = False
        PrevPointValueL.Visible = False
        CurPointLabel.Visible = True
        CurPointValueL.Visible = True
        CurPointLabel2.Visible = True
        Me.Cursor = Cursors.Default
        Timer1.Enabled = False
        NextButton.Enabled = True
        NextButton.BackColor = Color.PaleGreen
        MessageLabel.Text = "今回の狩りで稼いだカロリーが下に表示されています。" & Environment.NewLine & "また、シーズンの稼いで合計のカロリーも総得点として表示されています" & Environment.NewLine & Environment.NewLine & "「次の日へ」を押して、進んでください"
    End Sub


    Function GetPicture(ByVal tAShape As Integer, tAColour As Integer)
        Dim tempImage As Image
        If tAShape = 1 Then
            If tAColour = 1 Then
                tempImage = My.Resources._1s
            ElseIf tAColour = 2 Then
                tempImage = My.Resources._1h
            ElseIf tAColour = 3 Then
                tempImage = My.Resources._1o
            ElseIf tAColour = 4 Then
                tempImage = My.Resources._1w
            End If
        ElseIf tAShape = 2 Then
            If tAColour = 1 Then
                tempImage = My.Resources._2s
            ElseIf tAColour = 2 Then
                tempImage = My.Resources._2h
            ElseIf tAColour = 3 Then
                tempImage = My.Resources._2o
            ElseIf tAColour = 4 Then
                tempImage = My.Resources._2w
            End If
        ElseIf tAShape = 3 Then
            If tAColour = 1 Then
                tempImage = My.Resources._3s
            ElseIf tAColour = 2 Then
                tempImage = My.Resources._3h
            ElseIf tAColour = 3 Then
                tempImage = My.Resources._3o
            ElseIf tAColour = 4 Then
                tempImage = My.Resources._3w
            End If
        ElseIf tAShape = 4 Then
            If tAColour = 1 Then
                tempImage = My.Resources._4s
            ElseIf tAColour = 2 Then
                tempImage = My.Resources._4h
            ElseIf tAColour = 3 Then
                tempImage = My.Resources._4o
            ElseIf tAColour = 4 Then
                tempImage = My.Resources._4w
            End If
        End If

        Return tempImage
    End Function



    Function CalcPoint_f(ByVal Alengthv As Double, AWidthv As Double, AThickv As Integer, Ashapev As Integer)
        Dim tWl1, tWl2, tWl, tWw1, tWw2, tWw, tWt1, tWt2, tWt, tWs As Double
        Dim tSum As Double
        If QuadraticLandscape = 1 Then

            tWl = Quadratic(Alengthv, Ol1)
            tWw = Quadratic(AWidthv, Ow1)
            tWt = Quadratic(AThickv, Ot1)


            tSum = 1000 * ((bWl * tWl) + (bWw * tWw) + (bWt * tWt))

            Return Int(tSum)

        Else


            tWl1 = exp_distance(Alengthv, Ol1)
            tWl2 = SubOptimalCoef * exp_distance(Alengthv, Ol2)
            tWl = Math.Max(tWl1, tWl2)

            tWw1 = exp_distance(AWidthv, Ow1)
            tWw2 = SubOptimalCoef * exp_distance(AWidthv, Ow2)
            tWw = Math.Max(tWw1, tWw2)


            tWt1 = exp_distance(AThickv, Ot1)
            tWt2 = SubOptimalCoef * exp_distance(AThickv, Ot2)

            If IfBiModal = 1 Then
                tWl = Math.Max(tWl1, tWl2)
                tWw = Math.Max(tWw1, tWw2)
                tWt = Math.Max(tWt1, tWt2)
            Else
                tWl = tWl1
                tWw = tWw1
                tWt = tWt1
            End If

            Dim temprank As Integer
            For i As Integer = 1 To 4
                If OptShapeRank(i) = Ashapev Then
                    temprank = i
                End If
            Next

            ' tWs = 0.25 * Ashapev
            ' tempRank = OptShapeRank(Ashapev)
            tWs = WsValue(temprank)

            ' Ws = WsValue[AShape]


            tSum = 1000 * ((bWl * tWl) + (bWw * tWw) + (bWt * tWt) + (bWs * tWs))
            Return Int(tSum)
        End If
    End Function

    Function Quadratic(ByVal InX As Integer, O As Integer)
        Dim Out As Double

        Dim rSteap As Double
        If O > 49 Then
            rSteap = 1 / O
        Else
            rSteap = 1 / (100 - O + 1)
        End If


        Out = (-1) * rSteap ^ 2 * (InX - O) ^ 2 + 1
            Return (Out)

    End Function




    Function CeilingFloor(ByVal indata As Integer)
        Dim tempCFNum As Integer

        If indata > 1000 Then
            tempCFNum = 1000
        ElseIf indata < 1 Then
            tempCFNum = 0
        Else
            tempCFNum = indata
        End If
        Return (tempCFNum)
    End Function





    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        Me.Cursor = Cursors.WaitCursor
        'WriteText() timing changed
        NextButton.BackColor = Color.White
        OtherHunterSwitch = 0
        LastViewArrow = 0
        Pay2See = 0

        LastAction = HUNTING

        'PrevPointValueL.Text = CurPoint   timing changed
        SumPoint = SumPoint + CurPoint
        SumPointValueL.Text = SumPoint

        Bonus = (SumPoint / (MaxDays / 2)).ToString("0.00")
        BonusValueLabel.Text = Bonus & "円"

        HuntButton.BackColor = Color.White
        NextButton.Enabled = False
        PrePointLabel.Visible = False
        PrevPointValueL.Visible = False
        CurPointLabel.Visible = True
        CurPointValueL.Visible = True
        CurPointLabel2.Visible = True


        If SpeedMode = 1 Then
            NextRoundTeller.Interval = 1
        Else
            NextRoundTeller.Interval = 1000
        End If
        'NextRoundTeller.Enabled = True
        MessageLabel.Text = "次の画面の準備中です。少々お待ちください。”
        NextRoundTeller.Enabled = True

        NextButton.Enabled = False
        NextButton.Enabled = False
        PrePointLabel.Visible = True
        PrevPointValueL.Visible = True
        CurPointLabel.Visible = False
        CurPointValueL.Visible = False
        CurPointLabel2.Visible = False
        CurPointValueL.Visible = False

        GageBack.Visible = False
        PointGage.Visible = False
    End Sub



    Private Sub NextRoundTeller_Tick(sender As Object, e As EventArgs) Handles NextRoundTeller.Tick
        'Me.Cursor = Cursors.Default
        NextRoundTeller.Enabled = False


        nextday()


        'If Today = MaxDays + 1 Then
        '    Today = 1
        '    Season = Season + 1
        '    SeasonLabel.Text = Season

        '    CurPointValueL.Text = "0"
        '    CurPoint = 0
        '    PrevPointValueL.Text = CurPoint

        '    NextSeason()

        '    SumPoint = 0
        '    SumPointValueL.Text = SumPoint
        'End If
    End Sub



    Private Sub WriteText()


        FileOpen(10, OutPutFileName, OpenMode.Append)


        'Write(10, "Ind") : Write(10, Season) :Write(10, Today)
        Write(10, ID) : Write(10, ChainID) : Write(10, Generation) : Write(10, ExpCondtion) : Write(10, Age) : Write(10, Gender) : Write(10, Today) : Write(10, LastAction)
        Write(10, ALength) : Write(10, AWidth) : Write(10, AThick) ': Write(10, AShape) : Write(10, AColour)
        Write(10, OffLinePerformance) : Write(10, CurPoint) : Write(10, Bonus)
        'Write(10, 99999) : Write(10, OtherHunterSwitch)




        'For cPlayer As Integer = 1 To 4
        '    Write(10, cPlayer)
        '    For cDimention As Integer = 1 To 7
        '        Write(10, OtherPlayerVal(Today, cPlayer, cDimention))
        '    Next
        'Next

        'For cPlayer As Integer = 1 To 4
        '    Write(10, WatchArrowDuration(cPlayer).TotalSeconds.ToString("0.00"))
        'Next

        'For cPlayer As Integer = 1 To 4
        '    Write(10, WatchArrowNumbers(cPlayer))
        'Next


        '  Write(10, HuntDuration.TotalSeconds.ToString("0.00"))


        CurTimeStr = Format(Now, "yyyyMMddhhmmss")
        Write(10, CurTimeStr)


        FileClose(10)












    End Sub

    Private Sub PointGage_Click(sender As Object, e As EventArgs) Handles PointGage.Click

    End Sub
    'rnorm

    Private Function exp_distance(ByVal X As Integer, ByVal O As Integer) As Double
        Dim ans As Double
        Dim sigma As Double
        Dim dist As Double
        dist = (-1) * ((X / 100) - (O / 100)) ^ 2
        sigma = 0.035

        ans = Math.Exp(dist / (2 * sigma))
        Return ans
    End Function


    'Box-Muller
    Private Function rnorm(ByVal mean As Double, ByVal sd As Double) As Double
        Dim alpha As Double
        Dim beta As Double
        Dim x As Double
        alpha = Rnd()
        beta = Rnd()
        x = Math.Sqrt(-2 * Math.Log(alpha)) * Math.Sin(2 * Math.PI * beta)
        x = sd * x + mean
        Return x
    End Function






    Private Sub NextKnapButton_Click(sender As Object, e As EventArgs) Handles NextKnapButton.Click
        CurPointBeforeRand = CalcPoint_f(ALength, AWidth, AThick, AShape)
        OffLinePerformance = CurPointBeforeRand
        LastAction = KNAPPING

        If SpeedMode = 1 Then
            NextRoundTeller.Interval = 1
        Else
            NextRoundTeller.Interval = 1000
        End If
        NextKnapButton.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        NextKnapButton.BackColor = Color.White


        NextRoundTeller.Enabled = True
    End Sub


    Private Sub nextday()


        WriteText() 'note changed timing
        Today = Today + 1
        PrevPointValueL.Text = CurPoint
        'Form2.Visible = True
        BigMessageLabel.BackColor = Color.Turquoise
        BigMessageBack.BackColor = Color.Turquoise


        LeftDayValueL.Text = MaxDays - Today + 1
        If Today > MaxDays Then

            EarnedMoney = Int(Bonus) / 10
            EarnedMoney = EarnedMoney * 10

            MessageLabel.Text = ChainID & "_" & Generation & "実験終了です、ありがとうございました。実験者が来るまでお待ちください” &' "S1:" & Season1Score & ", S2:" & Season2Score & ", S3:" & Season3Score &
                Environment.NewLine & Environment.NewLine & "追加金額" & EarnedMoney &
                Environment.NewLine & Environment.NewLine & "合計金額" & (EarnedMoney + 700)
            NextButton.Enabled = False
            NextKnapButton.Enabled = False
            Me.BackColor = Color.AliceBlue
        Else

            HuntChoicePanel.Visible = True

            HuntChoicePic.Visible = True
            HuntChoiceLabel.Visible = True
            HuntChoicePanel.Enabled = True
            HuntChoiceLabel.Enabled = True
            HuntChoicePic.Enabled = True
            HuntChoicePanel.BackColor = Color.LightSteelBlue



            KnappingButton.Visible = False
            NextKnapButton.Visible = False

            ChangeLButton.Visible = False
            ChangeWButton.Visible = False
            ChangeTButton.Visible = False
            HuntButton.Visible = False
            NextButton.Visible = False


            KnappingChoicePanel.Visible = True

            KnapChoicePic.Visible = True
            KnapChoiceLabel.Enabled = True
            KnapChoicePic.Enabled = True
            KnappingChoicePanel.Enabled = True
            KnappingChoicePanel.BackColor = Color.LightSteelBlue

            MessageLabelController.Interval = 2000
            MessageLabelController.Enabled = True
            BigMessageLabel.Text = Today & "日目が始まります"
            BigMessageLabel.Visible = True
            BigMessageBack.Visible = True
            Me.Enabled = False
            'f2.Owner = Me
            'f2.Show()

            MessageLabel.Text = "「矢尻をデザインする」のか「狩りに行く」のか選択してください。どちらか一方の行動しか選べません。"
        End If
    End Sub





    Private Sub ChangeLButton_Click(sender As Object, e As EventArgs) Handles ChangeLButton.Click
        Dim OriginalPara As Integer
        OriginalPara = Int(LengthBox.Value)
        Dim tempMax
        tempMax = OriginalPara + MaxChangeUnit
        If tempMax > 100 Then
            tempMax = 100
        End If
        Dim tempMin = OriginalPara - MaxChangeUnit
        If tempMin < 1 Then
            tempMin = 1
        End If

        MessageLabel.Text = "長さを変更してください、最大で５まで変更できます（ただし、1-100の範囲に限ります）。変更する数が決まったら、「この形にする」を押してください"

        ChangeLButton.Enabled = False
        ChangeWButton.Enabled = False
        ChangeTButton.Enabled = False
        ChangeLButton.BackColor = Color.White
        ChangeWButton.BackColor = Color.White
        ChangeTButton.BackColor = Color.White
        LengthBox.Maximum = tempMax
        LengthBox.Minimum = tempMin
        LengthBox.Enabled = True
        LengthBox.BackColor = Color.PaleGreen

        CurModifyingDimention = LENGTH_INDEX
    End Sub

    Private Sub ChangeWButton_Click(sender As Object, e As EventArgs) Handles ChangeWButton.Click
        Dim OriginalPara As Integer
        OriginalPara = Int(WidthBox.Value)
        Dim tempMax
        tempMax = OriginalPara + MaxChangeUnit
        If tempMax > 100 Then
            tempMax = 100
        End If
        Dim tempMin = OriginalPara - MaxChangeUnit
        If tempMin < 1 Then
            tempMin = 1
        End If

        MessageLabel.Text = "幅広さを変更してください、最大で５まで変更できます（ただし、1-100の範囲に限ります）。変更する数が決まったら、「この形にする」を押してください"
        ChangeLButton.Enabled = False
        ChangeWButton.Enabled = False
        ChangeTButton.Enabled = False
        ChangeLButton.BackColor = Color.White
        ChangeWButton.BackColor = Color.White
        ChangeTButton.BackColor = Color.White
        WidthBox.Maximum = tempMax
        WidthBox.Minimum = tempMin
        WidthBox.Enabled = True
        WidthBox.BackColor = Color.PaleGreen

        CurModifyingDimention = WIDTH_INDEX
    End Sub

    Private Sub ChangeTButton_Click(sender As Object, e As EventArgs) Handles ChangeTButton.Click
        Dim OriginalPara As Integer
        OriginalPara = Int(ThickBox.Value)
        Dim tempMax
        tempMax = OriginalPara + MaxChangeUnit
        If tempMax > 100 Then
            tempMax = 100
        End If
        Dim tempMin = OriginalPara - MaxChangeUnit
        If tempMin < 1 Then
            tempMin = 1
        End If

        MessageLabel.Text = "厚さを変更してください、最大で５まで変更できます（ただし、1-100の範囲に限ります）。変更する数が決まったら、「この形にする」を押してください"
        ChangeLButton.Enabled = False
        ChangeWButton.Enabled = False
        ChangeTButton.Enabled = False

        ChangeLButton.BackColor = Color.White
        ChangeWButton.BackColor = Color.White
        ChangeTButton.BackColor = Color.White

        ThickBox.Maximum = tempMax
        ThickBox.Minimum = tempMin
        ThickBox.Enabled = True
        ThickBox.BackColor = Color.PaleGreen

        CurModifyingDimention = THICK_INDEX
    End Sub
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated


        If StaringMode = 1 Then
            MessageLabelController.Enabled = True
        End If

        KnappingButton.BackColor = Color.White

        If InitialSetting = 1 Then
            If Generation > 1 Then
                LengthBox.Value = InitialL
                WidthBox.Value = InitialW
                ThickBox.Value = InitialT
            End If
            InitialSetting = 0
        Else

            ' この部分はフォームの切り替えにりようしていた部分

            'If F1Activater = 1 Then
            '    If ActionMode = HUNTING Then
            '        HuntButton.Enabled = True
            '        LengthBox.Enabled = False
            '        WidthBox.Enabled = False
            '        ThickBox.Enabled = False
            '        NextKnapButton.Enabled = False

            '        'ChangeLButton.Visible = False
            '        'ChangeWButton.Visible = False
            '        'ChangeTButton.Visible = False
            '        HuntButton.BackColor = Color.PaleGreen

            '    ElseIf ActionMode = KNAPPING Then
            '        HuntButton.Enabled = False
            '        LengthBox.Enabled = False
            '        WidthBox.Enabled = False
            '        ThickBox.Enabled = False
            '        ChangeLButton.Enabled = True
            '        ChangeWButton.Enabled = True
            '        ChangeTButton.Enabled = True

            '        ChangeLButton.BackColor = Color.PaleGreen
            '        ChangeWButton.BackColor = Color.PaleGreen
            '        ChangeTButton.BackColor = Color.PaleGreen


            '        NextKnapButton.Enabled = False

            '        MessageLabel.Text = "高さ・幅広さ・長さのどれを変更しますか？１日に１つのみしか変更できません"
            '    End If
            '    F1Activater = 0


            'End If
        End If
    End Sub

    Private Sub KnappingPictureBox_Click(sender As Object, e As EventArgs) Handles KnappingPictureBox.Click

    End Sub

    Private Sub InitialButton_Click(sender As Object, e As EventArgs) Handles InitialButton.Click
        InitialButton.Visible = False
        MessageLabel.Text = "「狩りに行く」を押して手に入れた矢尻を試してみてください。"
        HuntButton.Enabled = True
        MainPictureBox1.Visible = True
        HuntButton.BackColor = Color.PaleGreen
        redraw()

        HuntButton.Visible = True
        NextButton.Visible = True

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles KnapChoiceLabel.Click
        ChoiceKnap()
    End Sub


    Private Sub KnappingPanel_Click(sender As Object, e As EventArgs) Handles KnappingChoicePanel.Click
        ChoiceKnap()
    End Sub

    Private Sub KnappingPic_Click(sender As Object, e As EventArgs) Handles KnapChoicePic.Click
        ChoiceKnap()
    End Sub

    Private Sub ChoiceKnap()
        HuntChoicePic.Visible = False
        HuntChoicePanel.BackColor = Color.Black
        HuntChoicePanel.Enabled = False
        HuntChoiceLabel.Enabled = False
        HuntChoicePic.Enabled = False

        KnappingChoicePanel.BackColor = Color.LightSalmon
        KnappingChoicePanel.Enabled = False
        KnappingChoicePanel.Enabled = False
        KnapChoiceLabel.Enabled = False
        KnapChoicePic.Enabled = False


        KnappingButton.Visible = True
        NextKnapButton.Visible = True




        HuntChoicePic.Visible = False



        HuntButton.Enabled = False
        LengthBox.Enabled = False
        WidthBox.Enabled = False
        ThickBox.Enabled = False
        ChangeLButton.Enabled = True
        ChangeWButton.Enabled = True
        ChangeTButton.Enabled = True

        ChangeLButton.Visible = True
        ChangeWButton.Visible = True
        ChangeTButton.Visible = True

        ChangeLButton.BackColor = Color.PaleGreen
        ChangeWButton.BackColor = Color.PaleGreen
        ChangeTButton.BackColor = Color.PaleGreen


        NextKnapButton.Enabled = False

        MessageLabel.Text = "高さ・幅広さ・長さのどれを変更しますか？１日に１つのみしか変更できません"


        MessageLabelController.Interval = 600
        MessageLabelController.Enabled = True
        BigMessageBack.BackColor = Color.Beige
        BigMessageLabel.BackColor = Color.Beige
        BigMessageLabel.Text = "「矢尻をデザインする」を選択しました"
        BigMessageLabel.Visible = True
        BigMessageBack.Visible = True
        Me.Enabled = False
    End Sub

    Private Sub ChoiceHunt()


        'Me.Opacity = 0.6

        KnappingChoicePanel.Enabled = False
        KnappingChoicePanel.BackColor = Color.Black
        KnappingChoicePanel.Enabled = False
        KnapChoiceLabel.Enabled = False
        KnapChoicePic.Enabled = False
        KnapChoicePic.Visible = False

        HuntChoicePanel.BackColor = Color.LightSalmon


        HuntChoicePanel.Enabled = False
        HuntChoiceLabel.Enabled = False
        HuntChoicePic.Enabled = False
        HuntButton.BackColor = Color.PaleGreen

        KnappingChoicePanel.Enabled = False
        KnapChoicePic.Enabled = False


        HuntButton.Enabled = True
        HuntButton.Visible = True
        NextButton.Visible = True


        LengthBox.Enabled = False
        WidthBox.Enabled = False
        ThickBox.Enabled = False
        NextKnapButton.Enabled = False

        'ChangeLButton.Visible = False
        'ChangeWButton.Visible = False
        'ChangeTButton.Visible = False
        BigMessageLabel.Text = "「狩り場に行く」を選択しました"
        MessageLabel.Text = "狩場にやってきました。「狩りをする」を押すと、現在持っている矢尻で狩りを行います”
        BigMessageLabel.Visible = True
        BigMessageBack.Visible = True
        BigMessageBack.BackColor = Color.Beige
        BigMessageLabel.BackColor = Color.Beige
        MessageLabelController.Interval = 600
        MessageLabelController.Enabled = True
        Me.Enabled = False
    End Sub

    Private Sub HuntChoicePanel_Click(sender As Object, e As EventArgs) Handles HuntChoicePanel.Click
        ChoiceHunt()
    End Sub

    Private Sub HuntChoiceLabel_Click(sender As Object, e As EventArgs) Handles HuntChoiceLabel.Click
        ChoiceHunt()
    End Sub

    Private Sub HuntChoicePic_Click(sender As Object, e As EventArgs) Handles HuntChoicePic.Click
        ChoiceHunt()
    End Sub

    Private Sub MessageLabelController_Tick(sender As Object, e As EventArgs) Handles MessageLabelController.Tick
        MessageLabelController.Enabled = False
        Me.Enabled = True
        BigMessageLabel.Visible = False
        BigMessageBack.Visible = False
        Me.Cursor = Cursors.Default
    End Sub







    'Private Function OtherPicture(ByVal index As Integer) As PictureBox
    '    Return DirectCast(Me.Controls("OtherPicture" & 2), PictureBox)
    'End Function
    'Private Function Vallab(ByVal Hunter As Integer, ByVal Dimention As Integer) As Label
    '    Return DirectCast(Me.Controls("Vallab" & Hunter.ToString & Dimention.ToString), Label)
    'End Function


End Class
