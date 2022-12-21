<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.HuntButton = New System.Windows.Forms.Button()
        Me.LengthBox = New System.Windows.Forms.NumericUpDown()
        Me.WidthBox = New System.Windows.Forms.NumericUpDown()
        Me.ThickBox = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WidthLable = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LeftDayL = New System.Windows.Forms.Label()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PrePointLabel = New System.Windows.Forms.Label()
        Me.CurPointLabel = New System.Windows.Forms.Label()
        Me.GageBack = New System.Windows.Forms.Label()
        Me.LeftDayValueL = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SeasonLabel = New System.Windows.Forms.Label()
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.tmplabel = New System.Windows.Forms.Label()
        Me.tmplabel2 = New System.Windows.Forms.Label()
        Me.GageTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NextRoundTeller = New System.Windows.Forms.Timer(Me.components)
        Me.KnappingButton = New System.Windows.Forms.Button()
        Me.CurPointLabel2 = New System.Windows.Forms.Label()
        Me.NextKnapButton = New System.Windows.Forms.Button()
        Me.ChangeTButton = New System.Windows.Forms.Button()
        Me.ChangeWButton = New System.Windows.Forms.Button()
        Me.ChangeLButton = New System.Windows.Forms.Button()
        Me.KnappingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PointGage = New System.Windows.Forms.Label()
        Me.MainPictureBox1 = New System.Windows.Forms.PictureBox()
        Me.KnappingLabel = New System.Windows.Forms.Label()
        Me.KnappingPictureBox = New System.Windows.Forms.PictureBox()
        Me.NextDayTeller = New System.Windows.Forms.Timer(Me.components)
        Me.PrevPointValueL = New System.Windows.Forms.Label()
        Me.SumPointValueL = New System.Windows.Forms.Label()
        Me.CurPointValueL = New System.Windows.Forms.Label()
        Me.InitialButton = New System.Windows.Forms.Button()
        Me.AddMoneyLab = New System.Windows.Forms.Label()
        Me.BonusValueLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.KnappingChoicePanel = New System.Windows.Forms.Panel()
        Me.KnapChoiceLabel = New System.Windows.Forms.Label()
        Me.KnapChoicePic = New System.Windows.Forms.PictureBox()
        Me.HuntChoicePanel = New System.Windows.Forms.Panel()
        Me.HuntChoiceLabel = New System.Windows.Forms.Label()
        Me.HuntChoicePic = New System.Windows.Forms.PictureBox()
        Me.BigMessageBack = New System.Windows.Forms.Label()
        Me.BigMessageLabel = New System.Windows.Forms.Label()
        Me.MessageLabelController = New System.Windows.Forms.Timer(Me.components)
        CType(Me.LengthBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WidthBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ThickBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnappingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KnappingChoicePanel.SuspendLayout()
        CType(Me.KnapChoicePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HuntChoicePanel.SuspendLayout()
        CType(Me.HuntChoicePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HuntButton
        '
        Me.HuntButton.BackColor = System.Drawing.Color.White
        Me.HuntButton.Enabled = False
        Me.HuntButton.Font = New System.Drawing.Font("Yu Gothic Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.HuntButton.Location = New System.Drawing.Point(624, 593)
        Me.HuntButton.Name = "HuntButton"
        Me.HuntButton.Size = New System.Drawing.Size(135, 83)
        Me.HuntButton.TabIndex = 0
        Me.HuntButton.Text = "狩りをする"
        Me.HuntButton.UseVisualStyleBackColor = False
        Me.HuntButton.Visible = False
        '
        'LengthBox
        '
        Me.LengthBox.Font = New System.Drawing.Font("Yu Gothic Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LengthBox.Location = New System.Drawing.Point(210, 19)
        Me.LengthBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.LengthBox.Name = "LengthBox"
        Me.LengthBox.Size = New System.Drawing.Size(87, 41)
        Me.LengthBox.TabIndex = 4
        Me.LengthBox.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'WidthBox
        '
        Me.WidthBox.Font = New System.Drawing.Font("Yu Gothic Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.WidthBox.Location = New System.Drawing.Point(210, 65)
        Me.WidthBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.WidthBox.Name = "WidthBox"
        Me.WidthBox.Size = New System.Drawing.Size(87, 41)
        Me.WidthBox.TabIndex = 5
        Me.WidthBox.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'ThickBox
        '
        Me.ThickBox.Font = New System.Drawing.Font("Yu Gothic Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ThickBox.Location = New System.Drawing.Point(210, 113)
        Me.ThickBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ThickBox.Name = "ThickBox"
        Me.ThickBox.Size = New System.Drawing.Size(87, 41)
        Me.ThickBox.TabIndex = 6
        Me.ThickBox.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 27)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "長さ (1-100)"
        '
        'WidthLable
        '
        Me.WidthLable.AutoSize = True
        Me.WidthLable.BackColor = System.Drawing.SystemColors.ControlLight
        Me.WidthLable.Font = New System.Drawing.Font("Yu Gothic Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.WidthLable.Location = New System.Drawing.Point(34, 67)
        Me.WidthLable.Name = "WidthLable"
        Me.WidthLable.Size = New System.Drawing.Size(165, 27)
        Me.WidthLable.TabIndex = 9
        Me.WidthLable.Text = "幅広さ (1-100)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 27)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "厚さ (1-100)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Meiryo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 582)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 31)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "シーズン："
        Me.Label3.Visible = False
        '
        'LeftDayL
        '
        Me.LeftDayL.AutoSize = True
        Me.LeftDayL.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LeftDayL.Font = New System.Drawing.Font("Meiryo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LeftDayL.Location = New System.Drawing.Point(37, 627)
        Me.LeftDayL.Name = "LeftDayL"
        Me.LeftDayL.Size = New System.Drawing.Size(140, 31)
        Me.LeftDayL.TabIndex = 19
        Me.LeftDayL.Text = "残りの日数："
        '
        'NextButton
        '
        Me.NextButton.BackColor = System.Drawing.Color.White
        Me.NextButton.Font = New System.Drawing.Font("Yu Gothic Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.NextButton.Location = New System.Drawing.Point(824, 593)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(129, 83)
        Me.NextButton.TabIndex = 20
        Me.NextButton.Text = "次の日へ"
        Me.NextButton.UseVisualStyleBackColor = False
        Me.NextButton.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Font = New System.Drawing.Font("Meiryo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(245, 645)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 31)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "シーズン総得点："
        '
        'PrePointLabel
        '
        Me.PrePointLabel.AutoSize = True
        Me.PrePointLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PrePointLabel.Font = New System.Drawing.Font("Meiryo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PrePointLabel.Location = New System.Drawing.Point(245, 611)
        Me.PrePointLabel.Name = "PrePointLabel"
        Me.PrePointLabel.Size = New System.Drawing.Size(182, 31)
        Me.PrePointLabel.TabIndex = 21
        Me.PrePointLabel.Text = "前回のカロリー："
        '
        'CurPointLabel
        '
        Me.CurPointLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CurPointLabel.Font = New System.Drawing.Font("Meiryo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CurPointLabel.Location = New System.Drawing.Point(245, 557)
        Me.CurPointLabel.Name = "CurPointLabel"
        Me.CurPointLabel.Size = New System.Drawing.Size(217, 27)
        Me.CurPointLabel.TabIndex = 23
        Me.CurPointLabel.Text = "今回のカロリー："
        '
        'GageBack
        '
        Me.GageBack.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GageBack.Location = New System.Drawing.Point(180, 476)
        Me.GageBack.Name = "GageBack"
        Me.GageBack.Size = New System.Drawing.Size(500, 50)
        Me.GageBack.TabIndex = 27
        '
        'LeftDayValueL
        '
        Me.LeftDayValueL.AutoSize = True
        Me.LeftDayValueL.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LeftDayValueL.Font = New System.Drawing.Font("Meiryo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LeftDayValueL.Location = New System.Drawing.Point(167, 627)
        Me.LeftDayValueL.Name = "LeftDayValueL"
        Me.LeftDayValueL.Size = New System.Drawing.Size(40, 31)
        Me.LeftDayValueL.TabIndex = 29
        Me.LeftDayValueL.Text = "30"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Font = New System.Drawing.Font("Yu Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(979, 161)
        Me.Label10.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Font = New System.Drawing.Font("Meiryo", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 541)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(980, 207)
        Me.Label6.TabIndex = 102
        '
        'SeasonLabel
        '
        Me.SeasonLabel.AutoSize = True
        Me.SeasonLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SeasonLabel.Font = New System.Drawing.Font("Meiryo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SeasonLabel.Location = New System.Drawing.Point(149, 584)
        Me.SeasonLabel.Name = "SeasonLabel"
        Me.SeasonLabel.Size = New System.Drawing.Size(27, 31)
        Me.SeasonLabel.TabIndex = 108
        Me.SeasonLabel.Text = "1"
        Me.SeasonLabel.Visible = False
        '
        'MessageLabel
        '
        Me.MessageLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MessageLabel.Font = New System.Drawing.Font("Meiryo", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.MessageLabel.Location = New System.Drawing.Point(704, 183)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(276, 342)
        Me.MessageLabel.TabIndex = 109
        Me.MessageLabel.Text = "最初の日は、デザインを変更できません。「入手した矢尻を表示」を押して手に入れた矢尻を表示してください。"
        Me.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmplabel
        '
        Me.tmplabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.tmplabel.AutoSize = True
        Me.tmplabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tmplabel.Font = New System.Drawing.Font("Meiryo", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.tmplabel.Location = New System.Drawing.Point(197, 711)
        Me.tmplabel.Name = "tmplabel"
        Me.tmplabel.Size = New System.Drawing.Size(33, 38)
        Me.tmplabel.TabIndex = 114
        Me.tmplabel.Text = "0"
        Me.tmplabel.Visible = False
        '
        'tmplabel2
        '
        Me.tmplabel2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.tmplabel2.AutoSize = True
        Me.tmplabel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tmplabel2.Font = New System.Drawing.Font("Meiryo", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.tmplabel2.Location = New System.Drawing.Point(1711, 694)
        Me.tmplabel2.Name = "tmplabel2"
        Me.tmplabel2.Size = New System.Drawing.Size(33, 38)
        Me.tmplabel2.TabIndex = 115
        Me.tmplabel2.Text = "0"
        Me.tmplabel2.Visible = False
        '
        'GageTimer
        '
        Me.GageTimer.Interval = 50
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'NextRoundTeller
        '
        Me.NextRoundTeller.Interval = 1400
        '
        'KnappingButton
        '
        Me.KnappingButton.BackColor = System.Drawing.Color.White
        Me.KnappingButton.Font = New System.Drawing.Font("Yu Gothic Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.KnappingButton.Location = New System.Drawing.Point(624, 42)
        Me.KnappingButton.Name = "KnappingButton"
        Me.KnappingButton.Size = New System.Drawing.Size(152, 83)
        Me.KnappingButton.TabIndex = 116
        Me.KnappingButton.Text = "この形にする"
        Me.KnappingButton.UseVisualStyleBackColor = False
        Me.KnappingButton.Visible = False
        '
        'CurPointLabel2
        '
        Me.CurPointLabel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CurPointLabel2.Font = New System.Drawing.Font("Meiryo", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CurPointLabel2.Location = New System.Drawing.Point(260, 584)
        Me.CurPointLabel2.Name = "CurPointLabel2"
        Me.CurPointLabel2.Size = New System.Drawing.Size(199, 29)
        Me.CurPointLabel2.TabIndex = 117
        Me.CurPointLabel2.Text = "（最大1000）"
        '
        'NextKnapButton
        '
        Me.NextKnapButton.BackColor = System.Drawing.Color.White
        Me.NextKnapButton.Enabled = False
        Me.NextKnapButton.Font = New System.Drawing.Font("Yu Gothic Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.NextKnapButton.Location = New System.Drawing.Point(824, 42)
        Me.NextKnapButton.Name = "NextKnapButton"
        Me.NextKnapButton.Size = New System.Drawing.Size(129, 83)
        Me.NextKnapButton.TabIndex = 118
        Me.NextKnapButton.Text = "次の日へ"
        Me.NextKnapButton.UseVisualStyleBackColor = False
        Me.NextKnapButton.Visible = False
        '
        'ChangeTButton
        '
        Me.ChangeTButton.BackColor = System.Drawing.Color.White
        Me.ChangeTButton.Enabled = False
        Me.ChangeTButton.Font = New System.Drawing.Font("Yu Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ChangeTButton.Location = New System.Drawing.Point(304, 113)
        Me.ChangeTButton.Name = "ChangeTButton"
        Me.ChangeTButton.Size = New System.Drawing.Size(167, 39)
        Me.ChangeTButton.TabIndex = 121
        Me.ChangeTButton.Text = "厚さを変える"
        Me.ChangeTButton.UseVisualStyleBackColor = False
        Me.ChangeTButton.Visible = False
        '
        'ChangeWButton
        '
        Me.ChangeWButton.BackColor = System.Drawing.Color.White
        Me.ChangeWButton.Enabled = False
        Me.ChangeWButton.Font = New System.Drawing.Font("Yu Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ChangeWButton.Location = New System.Drawing.Point(304, 65)
        Me.ChangeWButton.Name = "ChangeWButton"
        Me.ChangeWButton.Size = New System.Drawing.Size(167, 39)
        Me.ChangeWButton.TabIndex = 122
        Me.ChangeWButton.Text = "幅広さを変える"
        Me.ChangeWButton.UseVisualStyleBackColor = False
        Me.ChangeWButton.Visible = False
        '
        'ChangeLButton
        '
        Me.ChangeLButton.BackColor = System.Drawing.Color.White
        Me.ChangeLButton.Enabled = False
        Me.ChangeLButton.Font = New System.Drawing.Font("Yu Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ChangeLButton.Location = New System.Drawing.Point(304, 19)
        Me.ChangeLButton.Name = "ChangeLButton"
        Me.ChangeLButton.Size = New System.Drawing.Size(167, 39)
        Me.ChangeLButton.TabIndex = 123
        Me.ChangeLButton.Text = "長さを変える"
        Me.ChangeLButton.UseVisualStyleBackColor = False
        Me.ChangeLButton.Visible = False
        '
        'KnappingTimer
        '
        Me.KnappingTimer.Interval = 2000
        '
        'PointGage
        '
        Me.PointGage.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PointGage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PointGage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PointGage.Image = Global.Projectile_test.My.Resources.Resources.Serial_projectileanimal1
        Me.PointGage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PointGage.Location = New System.Drawing.Point(179, 477)
        Me.PointGage.Name = "PointGage"
        Me.PointGage.Size = New System.Drawing.Size(64, 49)
        Me.PointGage.TabIndex = 28
        '
        'MainPictureBox1
        '
        Me.MainPictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MainPictureBox1.InitialImage = Global.Projectile_test.My.Resources.Resources._4w
        Me.MainPictureBox1.Location = New System.Drawing.Point(215, 211)
        Me.MainPictureBox1.Name = "MainPictureBox1"
        Me.MainPictureBox1.Size = New System.Drawing.Size(250, 250)
        Me.MainPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MainPictureBox1.TabIndex = 17
        Me.MainPictureBox1.TabStop = False
        Me.MainPictureBox1.Visible = False
        '
        'KnappingLabel
        '
        Me.KnappingLabel.AutoSize = True
        Me.KnappingLabel.BackColor = System.Drawing.Color.White
        Me.KnappingLabel.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.KnappingLabel.Location = New System.Drawing.Point(732, 339)
        Me.KnappingLabel.Name = "KnappingLabel"
        Me.KnappingLabel.Size = New System.Drawing.Size(130, 24)
        Me.KnappingLabel.TabIndex = 125
        Me.KnappingLabel.Text = "矢尻作成中"
        Me.KnappingLabel.Visible = False
        '
        'KnappingPictureBox
        '
        Me.KnappingPictureBox.Image = Global.Projectile_test.My.Resources.Resources.石器作成___コピー__2_
        Me.KnappingPictureBox.Location = New System.Drawing.Point(624, 221)
        Me.KnappingPictureBox.Name = "KnappingPictureBox"
        Me.KnappingPictureBox.Size = New System.Drawing.Size(356, 252)
        Me.KnappingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.KnappingPictureBox.TabIndex = 126
        Me.KnappingPictureBox.TabStop = False
        Me.KnappingPictureBox.Visible = False
        '
        'NextDayTeller
        '
        Me.NextDayTeller.Interval = 2000
        '
        'PrevPointValueL
        '
        Me.PrevPointValueL.AutoSize = True
        Me.PrevPointValueL.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PrevPointValueL.Font = New System.Drawing.Font("Meiryo", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PrevPointValueL.Location = New System.Drawing.Point(429, 608)
        Me.PrevPointValueL.Name = "PrevPointValueL"
        Me.PrevPointValueL.Size = New System.Drawing.Size(29, 34)
        Me.PrevPointValueL.TabIndex = 25
        Me.PrevPointValueL.Text = "0"
        Me.PrevPointValueL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SumPointValueL
        '
        Me.SumPointValueL.AutoSize = True
        Me.SumPointValueL.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SumPointValueL.Font = New System.Drawing.Font("Meiryo", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SumPointValueL.Location = New System.Drawing.Point(429, 645)
        Me.SumPointValueL.Name = "SumPointValueL"
        Me.SumPointValueL.Size = New System.Drawing.Size(29, 34)
        Me.SumPointValueL.TabIndex = 26
        Me.SumPointValueL.Text = "0"
        '
        'CurPointValueL
        '
        Me.CurPointValueL.AutoSize = True
        Me.CurPointValueL.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CurPointValueL.Font = New System.Drawing.Font("Meiryo", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CurPointValueL.Location = New System.Drawing.Point(429, 555)
        Me.CurPointValueL.Name = "CurPointValueL"
        Me.CurPointValueL.Size = New System.Drawing.Size(29, 34)
        Me.CurPointValueL.TabIndex = 24
        Me.CurPointValueL.Text = "0"
        Me.CurPointValueL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'InitialButton
        '
        Me.InitialButton.BackColor = System.Drawing.Color.LemonChiffon
        Me.InitialButton.Font = New System.Drawing.Font("Yu Gothic Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.InitialButton.Location = New System.Drawing.Point(27, 284)
        Me.InitialButton.Name = "InitialButton"
        Me.InitialButton.Size = New System.Drawing.Size(172, 93)
        Me.InitialButton.TabIndex = 127
        Me.InitialButton.Text = "入手した矢尻を表示"
        Me.InitialButton.UseVisualStyleBackColor = False
        '
        'AddMoneyLab
        '
        Me.AddMoneyLab.AutoSize = True
        Me.AddMoneyLab.BackColor = System.Drawing.SystemColors.ControlLight
        Me.AddMoneyLab.Font = New System.Drawing.Font("Meiryo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.AddMoneyLab.Location = New System.Drawing.Point(308, 681)
        Me.AddMoneyLab.Name = "AddMoneyLab"
        Me.AddMoneyLab.Size = New System.Drawing.Size(119, 31)
        Me.AddMoneyLab.TabIndex = 128
        Me.AddMoneyLab.Text = "追加報酬："
        '
        'BonusValueLabel
        '
        Me.BonusValueLabel.AutoSize = True
        Me.BonusValueLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BonusValueLabel.Font = New System.Drawing.Font("Meiryo", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BonusValueLabel.Location = New System.Drawing.Point(429, 679)
        Me.BonusValueLabel.Name = "BonusValueLabel"
        Me.BonusValueLabel.Size = New System.Drawing.Size(29, 34)
        Me.BonusValueLabel.TabIndex = 129
        Me.BonusValueLabel.Text = "0"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Meiryo", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(229, 712)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(358, 29)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "(実際の支払いは10円単位で切り上げ）"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(1001, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(448, 741)
        Me.Label4.TabIndex = 131
        '
        'KnappingChoicePanel
        '
        Me.KnappingChoicePanel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.KnappingChoicePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KnappingChoicePanel.Controls.Add(Me.KnapChoiceLabel)
        Me.KnappingChoicePanel.Controls.Add(Me.KnapChoicePic)
        Me.KnappingChoicePanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KnappingChoicePanel.Location = New System.Drawing.Point(1112, 87)
        Me.KnappingChoicePanel.Name = "KnappingChoicePanel"
        Me.KnappingChoicePanel.Size = New System.Drawing.Size(229, 236)
        Me.KnappingChoicePanel.TabIndex = 132
        Me.KnappingChoicePanel.Visible = False
        '
        'KnapChoiceLabel
        '
        Me.KnapChoiceLabel.AutoSize = True
        Me.KnapChoiceLabel.Font = New System.Drawing.Font("Yu Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.KnapChoiceLabel.Location = New System.Drawing.Point(13, 12)
        Me.KnapChoiceLabel.Name = "KnapChoiceLabel"
        Me.KnapChoiceLabel.Size = New System.Drawing.Size(201, 27)
        Me.KnapChoiceLabel.TabIndex = 6
        Me.KnapChoiceLabel.Text = "矢尻をデザインする"
        '
        'KnapChoicePic
        '
        Me.KnapChoicePic.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.KnapChoicePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KnapChoicePic.Image = Global.Projectile_test.My.Resources.Resources._1s
        Me.KnapChoicePic.Location = New System.Drawing.Point(43, 44)
        Me.KnapChoicePic.Name = "KnapChoicePic"
        Me.KnapChoicePic.Size = New System.Drawing.Size(147, 152)
        Me.KnapChoicePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.KnapChoicePic.TabIndex = 3
        Me.KnapChoicePic.TabStop = False
        '
        'HuntChoicePanel
        '
        Me.HuntChoicePanel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.HuntChoicePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HuntChoicePanel.Controls.Add(Me.HuntChoiceLabel)
        Me.HuntChoicePanel.Controls.Add(Me.HuntChoicePic)
        Me.HuntChoicePanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HuntChoicePanel.Location = New System.Drawing.Point(1112, 409)
        Me.HuntChoicePanel.Name = "HuntChoicePanel"
        Me.HuntChoicePanel.Size = New System.Drawing.Size(229, 233)
        Me.HuntChoicePanel.TabIndex = 133
        Me.HuntChoicePanel.Visible = False
        '
        'HuntChoiceLabel
        '
        Me.HuntChoiceLabel.AutoSize = True
        Me.HuntChoiceLabel.Font = New System.Drawing.Font("Yu Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.HuntChoiceLabel.Location = New System.Drawing.Point(57, 12)
        Me.HuntChoiceLabel.Name = "HuntChoiceLabel"
        Me.HuntChoiceLabel.Size = New System.Drawing.Size(117, 27)
        Me.HuntChoiceLabel.TabIndex = 6
        Me.HuntChoiceLabel.Text = "狩場に行く"
        '
        'HuntChoicePic
        '
        Me.HuntChoicePic.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.HuntChoicePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HuntChoicePic.Image = Global.Projectile_test.My.Resources.Resources.hunting
        Me.HuntChoicePic.Location = New System.Drawing.Point(42, 51)
        Me.HuntChoicePic.Name = "HuntChoicePic"
        Me.HuntChoicePic.Size = New System.Drawing.Size(148, 150)
        Me.HuntChoicePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HuntChoicePic.TabIndex = 3
        Me.HuntChoicePic.TabStop = False
        '
        'BigMessageBack
        '
        Me.BigMessageBack.BackColor = System.Drawing.Color.Turquoise
        Me.BigMessageBack.Font = New System.Drawing.Font("Yu Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BigMessageBack.Location = New System.Drawing.Point(-16, 268)
        Me.BigMessageBack.Name = "BigMessageBack"
        Me.BigMessageBack.Size = New System.Drawing.Size(1455, 154)
        Me.BigMessageBack.TabIndex = 134
        '
        'BigMessageLabel
        '
        Me.BigMessageLabel.BackColor = System.Drawing.Color.Turquoise
        Me.BigMessageLabel.Font = New System.Drawing.Font("Yu Gothic", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BigMessageLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BigMessageLabel.Location = New System.Drawing.Point(265, 311)
        Me.BigMessageLabel.Name = "BigMessageLabel"
        Me.BigMessageLabel.Size = New System.Drawing.Size(928, 73)
        Me.BigMessageLabel.TabIndex = 135
        Me.BigMessageLabel.Text = "１日目が始まります"
        Me.BigMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MessageLabelController
        '
        Me.MessageLabelController.Interval = 800
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1461, 757)
        Me.ControlBox = False
        Me.Controls.Add(Me.BigMessageLabel)
        Me.Controls.Add(Me.BigMessageBack)
        Me.Controls.Add(Me.HuntChoicePanel)
        Me.Controls.Add(Me.KnappingChoicePanel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BonusValueLabel)
        Me.Controls.Add(Me.AddMoneyLab)
        Me.Controls.Add(Me.InitialButton)
        Me.Controls.Add(Me.KnappingLabel)
        Me.Controls.Add(Me.KnappingPictureBox)
        Me.Controls.Add(Me.ChangeLButton)
        Me.Controls.Add(Me.ChangeWButton)
        Me.Controls.Add(Me.ChangeTButton)
        Me.Controls.Add(Me.NextKnapButton)
        Me.Controls.Add(Me.CurPointValueL)
        Me.Controls.Add(Me.CurPointLabel)
        Me.Controls.Add(Me.CurPointLabel2)
        Me.Controls.Add(Me.KnappingButton)
        Me.Controls.Add(Me.tmplabel2)
        Me.Controls.Add(Me.tmplabel)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.SeasonLabel)
        Me.Controls.Add(Me.ThickBox)
        Me.Controls.Add(Me.LeftDayValueL)
        Me.Controls.Add(Me.PointGage)
        Me.Controls.Add(Me.GageBack)
        Me.Controls.Add(Me.SumPointValueL)
        Me.Controls.Add(Me.PrevPointValueL)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PrePointLabel)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.LeftDayL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MainPictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.WidthLable)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WidthBox)
        Me.Controls.Add(Me.LengthBox)
        Me.Controls.Add(Me.HuntButton)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Peru
        CType(Me.LengthBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WidthBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ThickBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnappingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KnappingChoicePanel.ResumeLayout(False)
        Me.KnappingChoicePanel.PerformLayout()
        CType(Me.KnapChoicePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HuntChoicePanel.ResumeLayout(False)
        Me.HuntChoicePanel.PerformLayout()
        CType(Me.HuntChoicePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HuntButton As Button
    Friend WithEvents LengthBox As NumericUpDown
    Friend WithEvents WidthBox As NumericUpDown
    Friend WithEvents ThickBox As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents WidthLable As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MainPictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LeftDayL As Label
    Friend WithEvents NextButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents PrePointLabel As Label
    Friend WithEvents CurPointLabel As Label
    Friend WithEvents GageBack As Label
    Friend WithEvents PointGage As Label
    Friend WithEvents LeftDayValueL As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SeasonLabel As Label
    Friend WithEvents MessageLabel As Label
    Friend WithEvents tmplabel As Label
    Friend WithEvents tmplabel2 As Label
    Friend WithEvents GageTimer As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NextRoundTeller As Timer
    Friend WithEvents KnappingButton As Button
    Friend WithEvents CurPointLabel2 As Label
    Friend WithEvents NextKnapButton As Button
    Friend WithEvents ChangeTButton As Button
    Friend WithEvents ChangeWButton As Button
    Friend WithEvents ChangeLButton As Button
    Friend WithEvents KnappingTimer As Timer
    Friend WithEvents KnappingLabel As Label
    Friend WithEvents KnappingPictureBox As PictureBox
    Friend WithEvents NextDayTeller As Timer
    Friend WithEvents PrevPointValueL As Label
    Friend WithEvents SumPointValueL As Label
    Friend WithEvents CurPointValueL As Label
    Friend WithEvents InitialButton As Button
    Friend WithEvents AddMoneyLab As Label
    Friend WithEvents BonusValueLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents KnappingChoicePanel As Panel
    Friend WithEvents KnapChoiceLabel As Label
    Friend WithEvents KnapChoicePic As PictureBox
    Friend WithEvents HuntChoicePanel As Panel
    Friend WithEvents HuntChoiceLabel As Label
    Friend WithEvents HuntChoicePic As PictureBox
    Friend WithEvents BigMessageBack As Label
    Friend WithEvents BigMessageLabel As Label
    Friend WithEvents MessageLabelController As Timer
End Class

