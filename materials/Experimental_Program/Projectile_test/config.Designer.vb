<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class config
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
        Me.SetButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.UniButton = New System.Windows.Forms.RadioButton()
        Me.BiButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.G3Button = New System.Windows.Forms.RadioButton()
        Me.G2Button = New System.Windows.Forms.RadioButton()
        Me.G1Button = New System.Windows.Forms.RadioButton()
        Me.SppedButton = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LengthBox = New System.Windows.Forms.NumericUpDown()
        Me.WidthBox = New System.Windows.Forms.NumericUpDown()
        Me.ThickBox = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.VERButton = New System.Windows.Forms.RadioButton()
        Me.OBLBUtton = New System.Windows.Forms.RadioButton()
        Me.INDButton = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.QuadraticButton = New System.Windows.Forms.RadioButton()
        Me.NormalButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.LengthBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WidthBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ThickBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SetButton
        '
        Me.SetButton.Location = New System.Drawing.Point(992, 712)
        Me.SetButton.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.SetButton.Name = "SetButton"
        Me.SetButton.Size = New System.Drawing.Size(314, 100)
        Me.SetButton.TabIndex = 0
        Me.SetButton.Text = "Set"
        Me.SetButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 166)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(208, 948)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 38)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Moduality"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(483, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 38)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Gen"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(245, 160)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(199, 45)
        Me.TextBox1.TabIndex = 7
        '
        'UniButton
        '
        Me.UniButton.AutoSize = True
        Me.UniButton.Checked = True
        Me.UniButton.Location = New System.Drawing.Point(26, 16)
        Me.UniButton.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.UniButton.Name = "UniButton"
        Me.UniButton.Size = New System.Drawing.Size(53, 28)
        Me.UniButton.TabIndex = 8
        Me.UniButton.TabStop = True
        Me.UniButton.Text = "1"
        Me.UniButton.UseVisualStyleBackColor = True
        '
        'BiButton
        '
        Me.BiButton.AutoSize = True
        Me.BiButton.Enabled = False
        Me.BiButton.Location = New System.Drawing.Point(26, 60)
        Me.BiButton.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BiButton.Name = "BiButton"
        Me.BiButton.Size = New System.Drawing.Size(53, 28)
        Me.BiButton.TabIndex = 9
        Me.BiButton.TabStop = True
        Me.BiButton.Text = "2"
        Me.BiButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BiButton)
        Me.GroupBox1.Controls.Add(Me.UniButton)
        Me.GroupBox1.Location = New System.Drawing.Point(405, 932)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(238, 120)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.G3Button)
        Me.GroupBox2.Controls.Add(Me.G2Button)
        Me.GroupBox2.Controls.Add(Me.G1Button)
        Me.GroupBox2.Location = New System.Drawing.Point(492, 134)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox2.Size = New System.Drawing.Size(173, 144)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'G3Button
        '
        Me.G3Button.AutoSize = True
        Me.G3Button.Location = New System.Drawing.Point(26, 100)
        Me.G3Button.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.G3Button.Name = "G3Button"
        Me.G3Button.Size = New System.Drawing.Size(53, 28)
        Me.G3Button.TabIndex = 10
        Me.G3Button.Text = "3"
        Me.G3Button.UseVisualStyleBackColor = True
        '
        'G2Button
        '
        Me.G2Button.AutoSize = True
        Me.G2Button.Location = New System.Drawing.Point(26, 60)
        Me.G2Button.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.G2Button.Name = "G2Button"
        Me.G2Button.Size = New System.Drawing.Size(53, 28)
        Me.G2Button.TabIndex = 9
        Me.G2Button.Text = "2"
        Me.G2Button.UseVisualStyleBackColor = True
        '
        'G1Button
        '
        Me.G1Button.AutoSize = True
        Me.G1Button.Checked = True
        Me.G1Button.Location = New System.Drawing.Point(26, 16)
        Me.G1Button.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.G1Button.Name = "G1Button"
        Me.G1Button.Size = New System.Drawing.Size(53, 28)
        Me.G1Button.TabIndex = 8
        Me.G1Button.TabStop = True
        Me.G1Button.Text = "1"
        Me.G1Button.UseVisualStyleBackColor = True
        '
        'SppedButton
        '
        Me.SppedButton.AutoSize = True
        Me.SppedButton.Location = New System.Drawing.Point(26, 1020)
        Me.SppedButton.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.SppedButton.Name = "SppedButton"
        Me.SppedButton.Size = New System.Drawing.Size(158, 28)
        Me.SppedButton.TabIndex = 10
        Me.SppedButton.Text = "DebugMode"
        Me.SppedButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(908, 72)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 38)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "長さ"
        '
        'LengthBox
        '
        Me.LengthBox.Enabled = False
        Me.LengthBox.Font = New System.Drawing.Font("メイリオ", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LengthBox.Location = New System.Drawing.Point(895, 134)
        Me.LengthBox.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.LengthBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.LengthBox.Name = "LengthBox"
        Me.LengthBox.Size = New System.Drawing.Size(147, 70)
        Me.LengthBox.TabIndex = 15
        Me.LengthBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'WidthBox
        '
        Me.WidthBox.Enabled = False
        Me.WidthBox.Font = New System.Drawing.Font("メイリオ", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.WidthBox.Location = New System.Drawing.Point(1114, 134)
        Me.WidthBox.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.WidthBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.WidthBox.Name = "WidthBox"
        Me.WidthBox.Size = New System.Drawing.Size(145, 70)
        Me.WidthBox.TabIndex = 16
        Me.WidthBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ThickBox
        '
        Me.ThickBox.Enabled = False
        Me.ThickBox.Font = New System.Drawing.Font("メイリオ", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ThickBox.Location = New System.Drawing.Point(1328, 132)
        Me.ThickBox.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ThickBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ThickBox.Name = "ThickBox"
        Me.ThickBox.Size = New System.Drawing.Size(145, 70)
        Me.ThickBox.TabIndex = 17
        Me.ThickBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(1127, 72)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 38)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "幅広さ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(1343, 72)
        Me.Label6.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 38)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "厚さ"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.VERButton)
        Me.GroupBox3.Controls.Add(Me.OBLBUtton)
        Me.GroupBox3.Controls.Add(Me.INDButton)
        Me.GroupBox3.Location = New System.Drawing.Point(462, 384)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox3.Size = New System.Drawing.Size(258, 144)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'VERButton
        '
        Me.VERButton.AutoSize = True
        Me.VERButton.Location = New System.Drawing.Point(26, 100)
        Me.VERButton.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.VERButton.Name = "VERButton"
        Me.VERButton.Size = New System.Drawing.Size(85, 28)
        Me.VERButton.TabIndex = 10
        Me.VERButton.Text = "VER"
        Me.VERButton.UseVisualStyleBackColor = True
        '
        'OBLBUtton
        '
        Me.OBLBUtton.AutoSize = True
        Me.OBLBUtton.Location = New System.Drawing.Point(26, 60)
        Me.OBLBUtton.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.OBLBUtton.Name = "OBLBUtton"
        Me.OBLBUtton.Size = New System.Drawing.Size(86, 28)
        Me.OBLBUtton.TabIndex = 9
        Me.OBLBUtton.Text = "OBL"
        Me.OBLBUtton.UseVisualStyleBackColor = True
        '
        'INDButton
        '
        Me.INDButton.AutoSize = True
        Me.INDButton.Checked = True
        Me.INDButton.Location = New System.Drawing.Point(26, 16)
        Me.INDButton.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.INDButton.Name = "INDButton"
        Me.INDButton.Size = New System.Drawing.Size(78, 28)
        Me.INDButton.TabIndex = 8
        Me.INDButton.TabStop = True
        Me.INDButton.Text = "IND"
        Me.INDButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(262, 400)
        Me.Label7.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 38)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Condition"
        '
        'OKButton
        '
        Me.OKButton.Enabled = False
        Me.OKButton.Location = New System.Drawing.Point(992, 854)
        Me.OKButton.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(314, 100)
        Me.OKButton.TabIndex = 23
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(208, 812)
        Me.Label8.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 38)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Moduality"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.QuadraticButton)
        Me.GroupBox4.Controls.Add(Me.NormalButton)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Location = New System.Drawing.Point(405, 800)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox4.Size = New System.Drawing.Size(238, 120)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        '
        'QuadraticButton
        '
        Me.QuadraticButton.AutoSize = True
        Me.QuadraticButton.Checked = True
        Me.QuadraticButton.Location = New System.Drawing.Point(26, 60)
        Me.QuadraticButton.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.QuadraticButton.Name = "QuadraticButton"
        Me.QuadraticButton.Size = New System.Drawing.Size(137, 28)
        Me.QuadraticButton.TabIndex = 9
        Me.QuadraticButton.TabStop = True
        Me.QuadraticButton.Text = "Quadratic"
        Me.QuadraticButton.UseVisualStyleBackColor = True
        '
        'NormalButton
        '
        Me.NormalButton.AutoSize = True
        Me.NormalButton.Location = New System.Drawing.Point(26, 16)
        Me.NormalButton.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.NormalButton.Name = "NormalButton"
        Me.NormalButton.Size = New System.Drawing.Size(110, 28)
        Me.NormalButton.TabIndex = 8
        Me.NormalButton.Text = "Normal"
        Me.NormalButton.UseVisualStyleBackColor = True
        '
        'config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1603, 1076)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ThickBox)
        Me.Controls.Add(Me.WidthBox)
        Me.Controls.Add(Me.LengthBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SppedButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SetButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "config"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FirstScreen"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Khaki
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.LengthBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WidthBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ThickBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SetButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents UniButton As RadioButton
    Friend WithEvents BiButton As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents G2Button As RadioButton
    Friend WithEvents G1Button As RadioButton
    Friend WithEvents G3Button As RadioButton
    Friend WithEvents SppedButton As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents LengthBox As NumericUpDown
    Friend WithEvents WidthBox As NumericUpDown
    Friend WithEvents ThickBox As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents VERButton As RadioButton
    Friend WithEvents OBLBUtton As RadioButton
    Friend WithEvents INDButton As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents OKButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents QuadraticButton As RadioButton
    Friend WithEvents NormalButton As RadioButton
End Class
