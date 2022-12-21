<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FirstSeasonExp
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CondLabel = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.AgeBox = New System.Windows.Forms.NumericUpDown()
        Me.DonotwantButton = New System.Windows.Forms.RadioButton()
        Me.FemaleButton = New System.Windows.Forms.RadioButton()
        Me.MaleButton = New System.Windows.Forms.RadioButton()
        Me.NotSureButton = New System.Windows.Forms.RadioButton()
        Me.OtherButton = New System.Windows.Forms.RadioButton()
        Me.GenderBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CType(Me.AgeBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GenderBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Yu Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(410, 770)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(613, 54)
        Me.Button1.TabIndex = 132
        Me.Button1.Text = "画面を読んだので、実験を開始する"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Yu Gothic", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(130, 139)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1215, 293)
        Me.TextBox1.TabIndex = 130
        Me.TextBox1.Text = "1日目は、手に入れた矢尻を試してみてください。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2日目以降は「矢尻をデザインする」のか「狩りに行く」の選択できます。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Meiryo", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(639, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 72)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "　"
        '
        'CondLabel
        '
        Me.CondLabel.AutoSize = True
        Me.CondLabel.BackColor = System.Drawing.SystemColors.Control
        Me.CondLabel.Font = New System.Drawing.Font("Meiryo", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CondLabel.Location = New System.Drawing.Point(1105, 23)
        Me.CondLabel.Name = "CondLabel"
        Me.CondLabel.Size = New System.Drawing.Size(123, 28)
        Me.CondLabel.TabIndex = 133
        Me.CondLabel.Text = "CONDITION"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Yu Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.DarkBlue
        Me.TextBox2.Location = New System.Drawing.Point(162, 54)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(1201, 79)
        Me.TextBox2.TabIndex = 134
        Me.TextBox2.Text = "※実験者の合図が出るまで、画面に触れないでください。"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Yu Gothic", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(148, 458)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(1215, 169)
        Me.TextBox4.TabIndex = 136
        Me.TextBox4.Text = "以下の項目についてお答えください。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "すべて回答が終わったら下のボタンを押して実験をはじめてください。"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AgeBox
        '
        Me.AgeBox.Font = New System.Drawing.Font("Yu Gothic Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.AgeBox.Location = New System.Drawing.Point(579, 632)
        Me.AgeBox.Maximum = New Decimal(New Integer() {110, 0, 0, 0})
        Me.AgeBox.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.AgeBox.Name = "AgeBox"
        Me.AgeBox.ReadOnly = True
        Me.AgeBox.Size = New System.Drawing.Size(87, 41)
        Me.AgeBox.TabIndex = 138
        Me.AgeBox.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'DonotwantButton
        '
        Me.DonotwantButton.AutoSize = True
        Me.DonotwantButton.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DonotwantButton.Location = New System.Drawing.Point(32, 30)
        Me.DonotwantButton.Name = "DonotwantButton"
        Me.DonotwantButton.Size = New System.Drawing.Size(103, 20)
        Me.DonotwantButton.TabIndex = 139
        Me.DonotwantButton.Text = "答えたくない"
        Me.DonotwantButton.UseVisualStyleBackColor = True
        '
        'FemaleButton
        '
        Me.FemaleButton.AutoSize = True
        Me.FemaleButton.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FemaleButton.Location = New System.Drawing.Point(32, 54)
        Me.FemaleButton.Name = "FemaleButton"
        Me.FemaleButton.Size = New System.Drawing.Size(58, 20)
        Me.FemaleButton.TabIndex = 140
        Me.FemaleButton.TabStop = True
        Me.FemaleButton.Text = "女性"
        Me.FemaleButton.UseVisualStyleBackColor = True
        '
        'MaleButton
        '
        Me.MaleButton.AutoSize = True
        Me.MaleButton.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.MaleButton.Location = New System.Drawing.Point(32, 80)
        Me.MaleButton.Name = "MaleButton"
        Me.MaleButton.Size = New System.Drawing.Size(58, 20)
        Me.MaleButton.TabIndex = 141
        Me.MaleButton.TabStop = True
        Me.MaleButton.Text = "男性"
        Me.MaleButton.UseVisualStyleBackColor = True
        '
        'NotSureButton
        '
        Me.NotSureButton.AutoSize = True
        Me.NotSureButton.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.NotSureButton.Location = New System.Drawing.Point(32, 108)
        Me.NotSureButton.Name = "NotSureButton"
        Me.NotSureButton.Size = New System.Drawing.Size(91, 20)
        Me.NotSureButton.TabIndex = 142
        Me.NotSureButton.TabStop = True
        Me.NotSureButton.Text = "わからない"
        Me.NotSureButton.UseVisualStyleBackColor = True
        '
        'OtherButton
        '
        Me.OtherButton.AutoSize = True
        Me.OtherButton.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.OtherButton.Location = New System.Drawing.Point(32, 134)
        Me.OtherButton.Name = "OtherButton"
        Me.OtherButton.Size = New System.Drawing.Size(164, 20)
        Me.OtherButton.TabIndex = 143
        Me.OtherButton.TabStop = True
        Me.OtherButton.Text = "上記に当てはまらない"
        Me.OtherButton.UseVisualStyleBackColor = True
        '
        'GenderBox
        '
        Me.GenderBox.Controls.Add(Me.NotSureButton)
        Me.GenderBox.Controls.Add(Me.MaleButton)
        Me.GenderBox.Controls.Add(Me.OtherButton)
        Me.GenderBox.Controls.Add(Me.FemaleButton)
        Me.GenderBox.Controls.Add(Me.DonotwantButton)
        Me.GenderBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GenderBox.Location = New System.Drawing.Point(782, 573)
        Me.GenderBox.Name = "GenderBox"
        Me.GenderBox.Size = New System.Drawing.Size(263, 161)
        Me.GenderBox.TabIndex = 145
        Me.GenderBox.TabStop = False
        Me.GenderBox.Text = "ジェンダー・性別"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(521, 637)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 21)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "年齢"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Yu Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.Firebrick
        Me.TextBox3.Location = New System.Drawing.Point(162, 275)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(1215, 177)
        Me.TextBox3.TabIndex = 147
        Me.TextBox3.Text = "実験は全部で50日（50回）からなります。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "合計のカロリーを高くする（報酬を得る）には、" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "「矢尻のデザイン」と「狩り」の適切なバランスがあります。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "デザイン" &
    "ばかりしていても、カロリーは得られないのでご注意ください。"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FirstSeasonExp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1428, 826)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GenderBox)
        Me.Controls.Add(Me.AgeBox)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.CondLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FirstSeasonExp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        CType(Me.AgeBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GenderBox.ResumeLayout(False)
        Me.GenderBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CondLabel As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents AgeBox As NumericUpDown
    Friend WithEvents DonotwantButton As RadioButton
    Friend WithEvents FemaleButton As RadioButton
    Friend WithEvents MaleButton As RadioButton
    Friend WithEvents NotSureButton As RadioButton
    Friend WithEvents OtherButton As RadioButton
    Friend WithEvents GenderBox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
