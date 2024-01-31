Partial Class FirstViewPage
	''' <summary> 
	''' 必要なデザイナ変数です。
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary> 
	''' 使用中のリソースをすべてクリーンアップします。
	''' </summary>
	''' <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "コンポーネント デザイナで生成されたコード"

	''' <summary> 
	''' デザイナ サポートに必要なメソッドです。このメソッドの内容を 
	''' コード エディタで変更しないでください。
	''' </summary>
	Private Sub InitializeComponent()
        Me.product1 = New System.Windows.Forms.Label
        Me.product2 = New System.Windows.Forms.Label
        Me.product3 = New System.Windows.Forms.Label
        Me.product_body = New System.Windows.Forms.Label
        Me.mainvisual = New System.Windows.Forms.PictureBox
        Me.product_title = New System.Windows.Forms.Label
        CType(Me.mainvisual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'product1
        '
        Me.product1.AutoSize = True
        Me.product1.BackColor = System.Drawing.Color.Transparent
        Me.product1.Font = New System.Drawing.Font("メイリオ", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.product1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.product1.Location = New System.Drawing.Point(32, 267)
        Me.product1.Name = "product1"
        Me.product1.Size = New System.Drawing.Size(259, 28)
        Me.product1.TabIndex = 1
        Me.product1.Text = "日本仕様入力コンポーネント"
        '
        'product2
        '
        Me.product2.AutoSize = True
        Me.product2.BackColor = System.Drawing.Color.Transparent
        Me.product2.Font = New System.Drawing.Font("メイリオ", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.product2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.product2.Location = New System.Drawing.Point(29, 295)
        Me.product2.Name = "product2"
        Me.product2.Size = New System.Drawing.Size(170, 48)
        Me.product2.TabIndex = 1
        Me.product2.Text = "InputMan"
        '
        'product3
        '
        Me.product3.AutoSize = True
        Me.product3.BackColor = System.Drawing.Color.Transparent
        Me.product3.Font = New System.Drawing.Font("メイリオ", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.product3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.product3.Location = New System.Drawing.Point(197, 309)
        Me.product3.Name = "product3"
        Me.product3.Size = New System.Drawing.Size(190, 28)
        Me.product3.TabIndex = 1
        Me.product3.Text = "for Windows Forms"
        '
        'product_body
        '
        Me.product_body.AutoSize = True
        Me.product_body.BackColor = System.Drawing.Color.Transparent
        Me.product_body.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.product_body.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.product_body.Location = New System.Drawing.Point(34, 378)
        Me.product_body.Name = "product_body"
        Me.product_body.Size = New System.Drawing.Size(556, 72)
        Me.product_body.TabIndex = 1
        Me.product_body.Text = "InputMan for Windows Formsは、入力インタフェース構築を支援するコンポーネントセットです。 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "テキスト、マスク、日付、数値などの用途別に" & _
            "最適化された入力コントロールと、" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ノンコーディングでチェック機能を実装できる検証コンポーネント。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "入力に欠かせないIME制御や住所検索機能を提供するコンポー" & _
            "ネント群から構成されています。 "
        '
        'mainvisual
        '
        Me.mainvisual.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.mainvisual.BackgroundImage = Global.InputManWin12_Demo.Resources.mainvisual
        Me.mainvisual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.mainvisual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainvisual.Location = New System.Drawing.Point(0, 0)
        Me.mainvisual.Name = "mainvisual"
        Me.mainvisual.Size = New System.Drawing.Size(724, 500)
        Me.mainvisual.TabIndex = 0
        Me.mainvisual.TabStop = False
        '
        'product_title
        '
        Me.product_title.AutoSize = True
        Me.product_title.BackColor = System.Drawing.Color.Transparent
        Me.product_title.Font = New System.Drawing.Font("メイリオ", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.product_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.product_title.Location = New System.Drawing.Point(32, 350)
        Me.product_title.Name = "product_title"
        Me.product_title.Size = New System.Drawing.Size(505, 23)
        Me.product_title.TabIndex = 1
        Me.product_title.Text = "日本の業務アプリケーション支援する、日本生まれの入力コンポーネント"
        '
        'FirstViewPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.product2)
        Me.Controls.Add(Me.product3)
        Me.Controls.Add(Me.product_body)
        Me.Controls.Add(Me.product_title)
        Me.Controls.Add(Me.product1)
        Me.Controls.Add(Me.mainvisual)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Name = "FirstViewPage"
        Me.Size = New System.Drawing.Size(724, 500)
        CType(Me.mainvisual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

	#End Region

	Private mainvisual As System.Windows.Forms.PictureBox
	Private product1 As System.Windows.Forms.Label
	Private product2 As System.Windows.Forms.Label
	Private product3 As System.Windows.Forms.Label
	Private product_body As System.Windows.Forms.Label
	Private product_title As System.Windows.Forms.Label

End Class
