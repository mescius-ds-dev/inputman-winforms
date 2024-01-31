Namespace _15_Sample
	Partial Class RegistEmployee
		''' <summary>
		''' 必要なデザイナー変数です。
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

		#Region "Windows フォーム デザイナーで生成されたコード"

		''' <summary>
		''' デザイナー サポートに必要なメソッドです。このメソッドの内容を
		''' コード エディターで変更しないでください。
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim AddressOutputSetting1 As GrapeCity.Win.Editors.AddressOutputSetting = New GrapeCity.Win.Editors.AddressOutputSetting()
            Me.gcAddressBox1 = New GrapeCity.Win.Editors.GcAddressBox(Me.components)
            Me.gcShortcut1 = New GrapeCity.Win.Editors.GcShortcut(Me.components)
            Me.gcDate1 = New GrapeCity.Win.Editors.GcDate(Me.components)
            Me.dropDownButton2 = New GrapeCity.Win.Editors.DropDownButton()
            Me.gcTextBox3 = New GrapeCity.Win.Editors.GcTextBox(Me.components)
            Me.gcMask2 = New GrapeCity.Win.Editors.GcMask(Me.components)
            Me.gcComboBox1 = New GrapeCity.Win.Editors.GcComboBox(Me.components)
            Me.dropDownButton3 = New GrapeCity.Win.Editors.DropDownButton()
            Me.gcMask1 = New GrapeCity.Win.Editors.GcMask(Me.components)
            Me.gcNumber1 = New GrapeCity.Win.Editors.GcNumber(Me.components)
            Me.gcPostal1 = New GrapeCity.Win.Editors.GcPostal(Me.components)
            Me.gcTextBox1 = New GrapeCity.Win.Editors.GcTextBox(Me.components)
            Me.gcTextBox2 = New GrapeCity.Win.Editors.GcTextBox(Me.components)
            Me.gcAddress1 = New GrapeCity.Win.Editors.GcAddress()
            Me.gcIme1 = New GrapeCity.Win.Editors.GcIme()
            Me.gcDateTimeValidator1 = New GrapeCity.Win.Editors.GcDateTimeValidator()
            Me.gcDateValidator1 = New GrapeCity.Win.Editors.GcDateValidator()
            Me.gcTimeValidator1 = New GrapeCity.Win.Editors.GcTimeValidator()
            Me.gcTimeSpanValidator1 = New GrapeCity.Win.Editors.GcTimeSpanValidator()
            Me.gcNumberValidator1 = New GrapeCity.Win.Editors.GcNumberValidator()
            Me.gcCommonValidator1 = New GrapeCity.Win.Editors.GcCommonValidator()
            Me.gcFieldStyler1 = New GrapeCity.Win.Editors.GcFieldStyler(Me.components)
            Me.GcSoftKeyboard1 = New GrapeCity.Win.Editors.GcSoftKeyboard(Me.components)
            Me.label10 = New System.Windows.Forms.Label()
            Me.label8 = New System.Windows.Forms.Label()
            Me.label15 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label14 = New System.Windows.Forms.Label()
            Me.label6 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label19 = New System.Windows.Forms.Label()
            Me.label13 = New System.Windows.Forms.Label()
            Me.button2 = New System.Windows.Forms.Button()
            Me.button1 = New System.Windows.Forms.Button()
            Me.gcCustomValidator1 = New GrapeCity.Win.Editors.GcCustomValidator()
            Me.panel1.SuspendLayout()
            CType(Me.gcAddressBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcDate1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcTextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcMask2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcMask1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcNumber1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcPostal1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.button2)
            Me.panel1.Controls.Add(Me.button1)
            Me.panel1.Controls.Add(Me.gcDate1)
            Me.panel1.Controls.Add(Me.gcTextBox3)
            Me.panel1.Controls.Add(Me.label10)
            Me.panel1.Controls.Add(Me.label8)
            Me.panel1.Controls.Add(Me.gcMask2)
            Me.panel1.Controls.Add(Me.label15)
            Me.panel1.Controls.Add(Me.gcComboBox1)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.label4)
            Me.panel1.Controls.Add(Me.label14)
            Me.panel1.Controls.Add(Me.label6)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Controls.Add(Me.gcMask1)
            Me.panel1.Controls.Add(Me.label19)
            Me.panel1.Controls.Add(Me.gcNumber1)
            Me.panel1.Controls.Add(Me.gcAddressBox1)
            Me.panel1.Controls.Add(Me.gcPostal1)
            Me.panel1.Controls.Add(Me.label13)
            Me.panel1.Controls.Add(Me.gcTextBox1)
            Me.panel1.Controls.Add(Me.gcTextBox2)
            Me.panel1.Size = New System.Drawing.Size(690, 400)
            Me.panel1.TabIndex = 3
            '
            'gcAddressBox1
            '
            Me.gcAddressBox1.Location = New System.Drawing.Point(183, 163)
            Me.gcAddressBox1.Name = "gcAddressBox1"
            Me.gcShortcut1.SetShortcuts(Me.gcAddressBox1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2}, New Object() {CType(Me.gcAddressBox1, Object)}, New String() {"ShortcutClear"}))
            Me.gcAddressBox1.Size = New System.Drawing.Size(318, 20)
            Me.gcAddressBox1.TabIndex = 41
            Me.gcAddressBox1.Tag = ""
            '
            'gcDate1
            '
            Me.gcDate1.Location = New System.Drawing.Point(7, 119)
            Me.gcDate1.MaxDate = New Date(2023, 3, 13, 23, 59, 59, 0)
            Me.gcDate1.MaxValue = New Date(2023, 3, 13, 23, 59, 59, 0)
            Me.gcDate1.Name = "gcDate1"
            Me.gcShortcut1.SetShortcuts(Me.gcDate1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.F5, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {CType(Me.gcDate1, Object), CType(Me.gcDate1, Object), CType(Me.gcDate1, Object)}, New String() {"ShortcutClear", "SetNow", "ApplyRecommendedValue"}))
            Me.gcDate1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.dropDownButton2})
            Me.gcDate1.Size = New System.Drawing.Size(170, 20)
            Me.gcDate1.TabIndex = 37
            Me.gcDate1.Tag = ""
            Me.gcDate1.Value = New Date(2023, 3, 13, 0, 0, 0, 0)
            '
            'dropDownButton2
            '
            Me.dropDownButton2.Name = "dropDownButton2"
            '
            'gcTextBox3
            '
            Me.gcTextBox3.AllowSpace = GrapeCity.Win.Editors.AllowSpace.None
            Me.gcTextBox3.LineSpace = 2
            Me.gcTextBox3.Location = New System.Drawing.Point(6, 251)
            Me.gcTextBox3.MaxLineCount = 5
            Me.gcTextBox3.Multiline = True
            Me.gcTextBox3.Name = "gcTextBox3"
            Me.gcShortcut1.SetShortcuts(Me.gcTextBox3, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2}, New Object() {CType(Me.gcTextBox3, Object)}, New String() {"ShortcutClear"}))
            Me.gcTextBox3.Size = New System.Drawing.Size(495, 103)
            Me.gcTextBox3.TabIndex = 45
            Me.gcTextBox3.Tag = ""
            '
            'gcMask2
            '
            Me.gcMask2.Location = New System.Drawing.Point(6, 207)
            Me.gcMask2.Name = "gcMask2"
            Me.gcShortcut1.SetShortcuts(Me.gcMask2, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {CType(Me.gcMask2, Object), CType(Me.gcMask2, Object)}, New String() {"ShortcutClear", "ApplyRecommendedValue"}))
            Me.gcMask2.ShowRecommendedValue = True
            Me.gcMask2.Size = New System.Drawing.Size(170, 20)
            Me.gcMask2.TabIndex = 42
            Me.gcMask2.Tag = ""
            '
            'gcComboBox1
            '
            Me.gcComboBox1.ListHeaderPane.Height = 25
            Me.gcComboBox1.Location = New System.Drawing.Point(183, 207)
            Me.gcComboBox1.Name = "gcComboBox1"
            Me.gcShortcut1.SetShortcuts(Me.gcComboBox1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {CType(Me.gcComboBox1, Object), CType(Me.gcComboBox1, Object)}, New String() {"ShortcutClear", "ApplyRecommendedValue"}))
            Me.gcComboBox1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.dropDownButton3})
            Me.gcComboBox1.Size = New System.Drawing.Size(224, 20)
            Me.gcComboBox1.TabIndex = 43
            Me.gcComboBox1.Tag = ""
            '
            'dropDownButton3
            '
            Me.dropDownButton3.Name = "dropDownButton3"
            '
            'gcMask1
            '
            Me.gcMask1.Location = New System.Drawing.Point(183, 119)
            Me.gcMask1.Name = "gcMask1"
            Me.gcShortcut1.SetShortcuts(Me.gcMask1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {CType(Me.gcMask1, Object), CType(Me.gcMask1, Object)}, New String() {"ShortcutClear", "ApplyRecommendedValue"}))
            Me.gcMask1.Size = New System.Drawing.Size(170, 20)
            Me.gcMask1.TabIndex = 38
            Me.gcMask1.Tag = ""
            '
            'gcNumber1
            '
            Me.gcNumber1.Fields.IntegerPart.MinDigits = 1
            Me.gcNumber1.Location = New System.Drawing.Point(6, 31)
            Me.gcNumber1.Name = "gcNumber1"
            Me.gcShortcut1.SetShortcuts(Me.gcNumber1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.Subtract, System.Windows.Forms.Keys.OemMinus, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {CType(Me.gcNumber1, Object), CType(Me.gcNumber1, Object), CType(Me.gcNumber1, Object), CType(Me.gcNumber1, Object)}, New String() {"SetZero", "SwitchSign", "SwitchSign", "ApplyRecommendedValue"}))
            Me.gcNumber1.Size = New System.Drawing.Size(100, 20)
            Me.gcNumber1.TabIndex = 33
            Me.gcNumber1.Tag = ""
            '
            'gcPostal1
            '
            AddressOutputSetting1.AddressOutput = Me.gcAddressBox1
            Me.gcAddress1.SetAddressOutputSetting(Me.gcPostal1, AddressOutputSetting1)
            Me.gcPostal1.Fields.ZipCodeSeparator.Text = "-"
            Me.gcPostal1.Location = New System.Drawing.Point(6, 163)
            Me.gcPostal1.Name = "gcPostal1"
            Me.gcShortcut1.SetShortcuts(Me.gcPostal1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {CType(Me.gcPostal1, Object), CType(Me.gcPostal1, Object)}, New String() {"ShortcutClear", "ApplyRecommendedValue"}))
            Me.gcPostal1.Size = New System.Drawing.Size(170, 20)
            Me.gcPostal1.TabIndex = 40
            Me.gcPostal1.Tag = ""
            '
            'gcTextBox1
            '
            Me.gcTextBox1.AllowSpace = GrapeCity.Win.Editors.AllowSpace.None
            Me.gcIme1.SetKanaMode(Me.gcTextBox1, GrapeCity.Win.Editors.KanaMode.Katakana)
            Me.gcTextBox1.Location = New System.Drawing.Point(6, 75)
            Me.gcTextBox1.MaxLength = 60
            Me.gcTextBox1.Name = "gcTextBox1"
            Me.gcShortcut1.SetShortcuts(Me.gcTextBox1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2}, New Object() {CType(Me.gcTextBox1, Object)}, New String() {"ShortcutClear"}))
            Me.gcTextBox1.Size = New System.Drawing.Size(170, 20)
            Me.gcTextBox1.TabIndex = 34
            Me.gcTextBox1.Tag = ""
            '
            'gcTextBox2
            '
            Me.gcTextBox2.ImeMode = System.Windows.Forms.ImeMode.Katakana
            Me.gcIme1.SetKanaMode(Me.gcTextBox2, GrapeCity.Win.Editors.KanaMode.Katakana)
            Me.gcTextBox2.Location = New System.Drawing.Point(182, 75)
            Me.gcTextBox2.Name = "gcTextBox2"
            Me.gcShortcut1.SetShortcuts(Me.gcTextBox2, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2}, New Object() {CType(Me.gcTextBox2, Object)}, New String() {"ShortcutClear"}))
            Me.gcTextBox2.Size = New System.Drawing.Size(170, 20)
            Me.gcTextBox2.TabIndex = 35
            Me.gcTextBox2.Tag = ""
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.BackColor = System.Drawing.Color.White
            Me.label10.Location = New System.Drawing.Point(3, 230)
            Me.label10.Margin = New System.Windows.Forms.Padding(0)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(56, 18)
            Me.label10.TabIndex = 50
            Me.label10.Text = "通信欄："
            Me.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.BackColor = System.Drawing.Color.White
            Me.label8.Location = New System.Drawing.Point(3, 186)
            Me.label8.Margin = New System.Windows.Forms.Padding(0)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(44, 18)
            Me.label8.TabIndex = 49
            Me.label8.Text = "内線："
            Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label15
            '
            Me.label15.AutoSize = True
            Me.label15.BackColor = System.Drawing.Color.White
            Me.label15.Location = New System.Drawing.Point(184, 186)
            Me.label15.Margin = New System.Windows.Forms.Padding(0)
            Me.label15.Name = "label15"
            Me.label15.Size = New System.Drawing.Size(56, 18)
            Me.label15.TabIndex = 48
            Me.label15.Text = "部署名："
            Me.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.BackColor = System.Drawing.Color.White
            Me.label2.Location = New System.Drawing.Point(179, 54)
            Me.label2.Margin = New System.Windows.Forms.Padding(0)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(68, 18)
            Me.label2.TabIndex = 36
            Me.label2.Text = "フリガナ："
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.BackColor = System.Drawing.Color.White
            Me.label4.Location = New System.Drawing.Point(184, 142)
            Me.label4.Margin = New System.Windows.Forms.Padding(0)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(44, 18)
            Me.label4.TabIndex = 44
            Me.label4.Text = "住所："
            Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label14
            '
            Me.label14.AutoSize = True
            Me.label14.BackColor = System.Drawing.Color.White
            Me.label14.Location = New System.Drawing.Point(3, 98)
            Me.label14.Margin = New System.Windows.Forms.Padding(0)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(68, 18)
            Me.label14.TabIndex = 47
            Me.label14.Text = "生年月日："
            Me.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.BackColor = System.Drawing.Color.White
            Me.label6.Location = New System.Drawing.Point(180, 98)
            Me.label6.Margin = New System.Windows.Forms.Padding(0)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(68, 18)
            Me.label6.TabIndex = 46
            Me.label6.Text = "電話番号："
            Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.BackColor = System.Drawing.Color.White
            Me.label3.Location = New System.Drawing.Point(3, 142)
            Me.label3.Margin = New System.Windows.Forms.Padding(0)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(68, 18)
            Me.label3.TabIndex = 39
            Me.label3.Text = "郵便番号："
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label19
            '
            Me.label19.AutoSize = True
            Me.label19.BackColor = System.Drawing.Color.White
            Me.label19.Location = New System.Drawing.Point(3, 10)
            Me.label19.Margin = New System.Windows.Forms.Padding(0)
            Me.label19.Name = "label19"
            Me.label19.Size = New System.Drawing.Size(68, 18)
            Me.label19.TabIndex = 51
            Me.label19.Text = "社員番号："
            Me.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label13
            '
            Me.label13.AutoSize = True
            Me.label13.BackColor = System.Drawing.Color.White
            Me.label13.Location = New System.Drawing.Point(3, 54)
            Me.label13.Margin = New System.Windows.Forms.Padding(0)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(56, 18)
            Me.label13.TabIndex = 32
            Me.label13.Text = "社員名："
            Me.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'button2
            '
            Me.button2.Location = New System.Drawing.Point(6, 372)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(166, 22)
            Me.button2.TabIndex = 53
            Me.button2.Text = "クリア"
            Me.button2.UseVisualStyleBackColor = True
            '
            'button1
            '
            Me.button1.Location = New System.Drawing.Point(339, 372)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(166, 22)
            Me.button1.TabIndex = 52
            Me.button1.Text = "登録"
            Me.button1.UseVisualStyleBackColor = True
            '
            'RegistEmployee
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
            Me.Description = "氏名や住所などの自動入力、フォーカス移動、エラーチェックなどの機能を備えた、社員情報入力画面を作成する方法を紹介します。"
            Me.Name = "RegistEmployee"
            Me.Title = "社員情報入力"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.gcAddressBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcDate1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcTextBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcMask2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcMask1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcNumber1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcPostal1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region
        Private WithEvents gcAddress1 As GrapeCity.Win.Editors.GcAddress
        Private WithEvents gcShortcut1 As GrapeCity.Win.Editors.GcShortcut
        Private WithEvents gcIme1 As GrapeCity.Win.Editors.GcIme
        Private WithEvents gcDateTimeValidator1 As GrapeCity.Win.Editors.GcDateTimeValidator
        Private WithEvents gcDateValidator1 As GrapeCity.Win.Editors.GcDateValidator
        Private WithEvents gcTimeValidator1 As GrapeCity.Win.Editors.GcTimeValidator
        Private WithEvents gcNumberValidator1 As GrapeCity.Win.Editors.GcNumberValidator
        Private WithEvents gcTimeSpanValidator1 As GrapeCity.Win.Editors.GcTimeSpanValidator
        Private WithEvents gcFieldStyler1 As GrapeCity.Win.Editors.GcFieldStyler
        Private WithEvents gcCommonValidator1 As GrapeCity.Win.Editors.GcCommonValidator
        Friend WithEvents GcSoftKeyboard1 As GrapeCity.Win.Editors.GcSoftKeyboard
        Private WithEvents gcDate1 As GrapeCity.Win.Editors.GcDate
        Private WithEvents dropDownButton2 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents gcTextBox3 As GrapeCity.Win.Editors.GcTextBox
        Private WithEvents label10 As Windows.Forms.Label
        Private WithEvents label8 As Windows.Forms.Label
        Private WithEvents gcMask2 As GrapeCity.Win.Editors.GcMask
        Private WithEvents label15 As Windows.Forms.Label
        Private WithEvents gcComboBox1 As GrapeCity.Win.Editors.GcComboBox
        Private WithEvents dropDownButton3 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents label2 As Windows.Forms.Label
        Private WithEvents label4 As Windows.Forms.Label
        Private WithEvents label14 As Windows.Forms.Label
        Private WithEvents label6 As Windows.Forms.Label
        Private WithEvents label3 As Windows.Forms.Label
        Private WithEvents gcMask1 As GrapeCity.Win.Editors.GcMask
        Private WithEvents label19 As Windows.Forms.Label
        Private WithEvents gcNumber1 As GrapeCity.Win.Editors.GcNumber
        Private WithEvents gcAddressBox1 As GrapeCity.Win.Editors.GcAddressBox
        Private WithEvents gcPostal1 As GrapeCity.Win.Editors.GcPostal
        Private WithEvents label13 As Windows.Forms.Label
        Private WithEvents gcTextBox1 As GrapeCity.Win.Editors.GcTextBox
        Private WithEvents gcTextBox2 As GrapeCity.Win.Editors.GcTextBox
        Private WithEvents button2 As Windows.Forms.Button
        Private WithEvents button1 As Windows.Forms.Button
        Private WithEvents gcCustomValidator1 As GrapeCity.Win.Editors.GcCustomValidator
    End Class
End Namespace
