<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.HuntingPic = New System.Windows.Forms.PictureBox()
        Me.KnappingPic = New System.Windows.Forms.PictureBox()
        Me.KnappingPanel = New System.Windows.Forms.Panel()
        Me.KnappingLabel = New System.Windows.Forms.Label()
        Me.HunttingPanel = New System.Windows.Forms.Panel()
        Me.HuntingLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.HuntingPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnappingPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KnappingPanel.SuspendLayout()
        Me.HunttingPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'HuntingPic
        '
        Me.HuntingPic.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.HuntingPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HuntingPic.Image = Global.Projectile_test.My.Resources.Resources.hunting
        Me.HuntingPic.Location = New System.Drawing.Point(127, 187)
        Me.HuntingPic.Name = "HuntingPic"
        Me.HuntingPic.Size = New System.Drawing.Size(186, 191)
        Me.HuntingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HuntingPic.TabIndex = 4
        Me.HuntingPic.TabStop = False
        '
        'KnappingPic
        '
        Me.KnappingPic.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.KnappingPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KnappingPic.Image = Global.Projectile_test.My.Resources.Resources._1s
        Me.KnappingPic.Location = New System.Drawing.Point(121, 187)
        Me.KnappingPic.Name = "KnappingPic"
        Me.KnappingPic.Size = New System.Drawing.Size(186, 191)
        Me.KnappingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.KnappingPic.TabIndex = 3
        Me.KnappingPic.TabStop = False
        '
        'KnappingPanel
        '
        Me.KnappingPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.KnappingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KnappingPanel.Controls.Add(Me.KnappingLabel)
        Me.KnappingPanel.Controls.Add(Me.KnappingPic)
        Me.KnappingPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KnappingPanel.Location = New System.Drawing.Point(168, 279)
        Me.KnappingPanel.Name = "KnappingPanel"
        Me.KnappingPanel.Size = New System.Drawing.Size(444, 459)
        Me.KnappingPanel.TabIndex = 5
        '
        'KnappingLabel
        '
        Me.KnappingLabel.AutoSize = True
        Me.KnappingLabel.Font = New System.Drawing.Font("Yu Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.KnappingLabel.Location = New System.Drawing.Point(87, 63)
        Me.KnappingLabel.Name = "KnappingLabel"
        Me.KnappingLabel.Size = New System.Drawing.Size(278, 38)
        Me.KnappingLabel.TabIndex = 6
        Me.KnappingLabel.Text = "矢尻をデザインする"
        '
        'HunttingPanel
        '
        Me.HunttingPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.HunttingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HunttingPanel.Controls.Add(Me.HuntingLabel)
        Me.HunttingPanel.Controls.Add(Me.HuntingPic)
        Me.HunttingPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HunttingPanel.Location = New System.Drawing.Point(791, 279)
        Me.HunttingPanel.Name = "HunttingPanel"
        Me.HunttingPanel.Size = New System.Drawing.Size(444, 459)
        Me.HunttingPanel.TabIndex = 6
        '
        'HuntingLabel
        '
        Me.HuntingLabel.AutoSize = True
        Me.HuntingLabel.Font = New System.Drawing.Font("Yu Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.HuntingLabel.Location = New System.Drawing.Point(138, 63)
        Me.HuntingLabel.Name = "HuntingLabel"
        Me.HuntingLabel.Size = New System.Drawing.Size(162, 38)
        Me.HuntingLabel.TabIndex = 6
        Me.HuntingLabel.Text = "狩りに行く"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(479, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(481, 38)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "どちらかをひとつ選んでください。"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(463, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(481, 38)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "今日は、どのように行動しますか？"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1413, 821)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.HunttingPanel)
        Me.Controls.Add(Me.KnappingPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.HuntingPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnappingPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KnappingPanel.ResumeLayout(False)
        Me.KnappingPanel.PerformLayout()
        Me.HunttingPanel.ResumeLayout(False)
        Me.HunttingPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KnappingPic As PictureBox
    Friend WithEvents HuntingPic As PictureBox
    Friend WithEvents KnappingPanel As Panel
    Friend WithEvents KnappingLabel As Label
    Friend WithEvents HunttingPanel As Panel
    Friend WithEvents HuntingLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
