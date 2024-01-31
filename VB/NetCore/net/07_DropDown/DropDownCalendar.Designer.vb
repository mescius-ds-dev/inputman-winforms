Namespace _07_DropDown
	Partial Class DropDownCalendar
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
            Dim DateYearField2 As GrapeCity.Win.Editors.Fields.DateYearField = New GrapeCity.Win.Editors.Fields.DateYearField()
            Dim DateLiteralField3 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
            Dim DateMonthField2 As GrapeCity.Win.Editors.Fields.DateMonthField = New GrapeCity.Win.Editors.Fields.DateMonthField()
            Dim DateLiteralField4 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
            Dim DateDayField2 As GrapeCity.Win.Editors.Fields.DateDayField = New GrapeCity.Win.Editors.Fields.DateDayField()
            Dim DateLiteralField5 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
            Dim DateHourField1 As GrapeCity.Win.Editors.Fields.DateHourField = New GrapeCity.Win.Editors.Fields.DateHourField()
            Dim DateLiteralField6 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
            Dim DateMinuteField1 As GrapeCity.Win.Editors.Fields.DateMinuteField = New GrapeCity.Win.Editors.Fields.DateMinuteField()
            Dim DateLiteralField7 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
            Dim DateSecondField1 As GrapeCity.Win.Editors.Fields.DateSecondField = New GrapeCity.Win.Editors.Fields.DateSecondField()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DropDownCalendar))
            Dim DateYearField1 As GrapeCity.Win.Editors.Fields.DateYearField = New GrapeCity.Win.Editors.Fields.DateYearField()
            Dim DateLiteralField1 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
            Dim DateMonthField1 As GrapeCity.Win.Editors.Fields.DateMonthField = New GrapeCity.Win.Editors.Fields.DateMonthField()
            Dim DateLiteralField2 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
            Dim DateDayField1 As GrapeCity.Win.Editors.Fields.DateDayField = New GrapeCity.Win.Editors.Fields.DateDayField()
            Dim ListItem1 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem()
            Dim SubItem1 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem()
            Dim SubItem2 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem()
            Dim ListItem2 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem()
            Dim SubItem3 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem()
            Dim SubItem4 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem()
            Me.gcDateTime1 = New GrapeCity.Win.Editors.GcDateTime(Me.components)
            Me.dropDownButton1 = New GrapeCity.Win.Editors.DropDownButton()
            Me.label2 = New System.Windows.Forms.Label()
            Me.gcShortcut1 = New GrapeCity.Win.Editors.GcShortcut(Me.components)
            Me.gcDate1 = New GrapeCity.Win.Editors.GcDate(Me.components)
            Me.dropDownButton2 = New GrapeCity.Win.Editors.DropDownButton()
            Me.gcNumber1 = New GrapeCity.Win.Editors.GcNumber(Me.components)
            Me.spinButton1 = New GrapeCity.Win.Editors.SpinButton()
            Me.label3 = New System.Windows.Forms.Label()
            Me.gcNumber2 = New GrapeCity.Win.Editors.GcNumber(Me.components)
            Me.spinButton2 = New GrapeCity.Win.Editors.SpinButton()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label5 = New System.Windows.Forms.Label()
            Me.gcComboBox1 = New GrapeCity.Win.Editors.GcComboBox(Me.components)
            Me.listColumn1 = New GrapeCity.Win.Editors.ListColumn()
            Me.listColumn2 = New GrapeCity.Win.Editors.ListColumn()
            Me.dropDownButton7 = New GrapeCity.Win.Editors.DropDownButton()
            Me.label6 = New System.Windows.Forms.Label()
            Me.checkBox1 = New System.Windows.Forms.CheckBox()
            Me.checkBox2 = New System.Windows.Forms.CheckBox()
            Me.checkBox5 = New System.Windows.Forms.CheckBox()
            Me.checkBox4 = New System.Windows.Forms.CheckBox()
            Me.checkBox3 = New System.Windows.Forms.CheckBox()
            Me.checkBox6 = New System.Windows.Forms.CheckBox()
            CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainer1.Panel1.SuspendLayout()
            Me.splitContainer1.Panel2.SuspendLayout()
            Me.splitContainer1.SuspendLayout()
            CType(Me.gcDateTime1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcDate1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcNumber1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcNumber2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'splitContainer1
            '
            '
            'splitContainer1.Panel1
            '
            Me.splitContainer1.Panel1.Controls.Add(Me.gcDate1)
            Me.splitContainer1.Panel1.Controls.Add(Me.gcDateTime1)
            Me.splitContainer1.Panel1.Controls.Add(Me.label3)
            Me.splitContainer1.Panel1.Controls.Add(Me.label2)
            '
            'splitContainer1.Panel2
            '
            Me.splitContainer1.Panel2.Controls.Add(Me.checkBox6)
            Me.splitContainer1.Panel2.Controls.Add(Me.gcNumber2)
            Me.splitContainer1.Panel2.Controls.Add(Me.label4)
            Me.splitContainer1.Panel2.Controls.Add(Me.gcNumber1)
            Me.splitContainer1.Panel2.Controls.Add(Me.label5)
            Me.splitContainer1.Panel2.Controls.Add(Me.gcComboBox1)
            Me.splitContainer1.Panel2.Controls.Add(Me.label6)
            Me.splitContainer1.Panel2.Controls.Add(Me.checkBox1)
            Me.splitContainer1.Panel2.Controls.Add(Me.checkBox2)
            Me.splitContainer1.Panel2.Controls.Add(Me.checkBox5)
            Me.splitContainer1.Panel2.Controls.Add(Me.checkBox4)
            Me.splitContainer1.Panel2.Controls.Add(Me.checkBox3)
            Me.splitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(8, 0, 8, 4)
            '
            'gcDateTime1
            '
            Me.gcDateTime1.AutoSize = True
            Me.gcDateTime1.DropDownCalendar.TodayImage = CType(resources.GetObject("gcDateTime1.DropDownCalendar.TodayImage"), System.Drawing.Image)
            DateLiteralField3.Text = "/"
            DateLiteralField4.Text = "/"
            DateLiteralField6.Text = ":"
            DateLiteralField7.Text = ":"
            Me.gcDateTime1.Fields.AddRange(New GrapeCity.Win.Editors.Fields.DateField() {DateYearField2, DateLiteralField3, DateMonthField2, DateLiteralField4, DateDayField2, DateLiteralField5, DateHourField1, DateLiteralField6, DateMinuteField1, DateLiteralField7, DateSecondField1})
            Me.gcDateTime1.ImeMode = System.Windows.Forms.ImeMode.Off
            Me.gcDateTime1.Location = New System.Drawing.Point(8, 27)
            Me.gcDateTime1.Name = "gcDateTime1"
            Me.gcDateTime1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.dropDownButton1})
            Me.gcDateTime1.Size = New System.Drawing.Size(227, 24)
            Me.gcDateTime1.TabIndex = 1
            Me.gcDateTime1.Value = New Date(2015, 1, 1, 0, 0, 0, 0)
            '
            'dropDownButton1
            '
            Me.dropDownButton1.Name = "dropDownButton1"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(5, 8)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(236, 18)
            Me.label2.TabIndex = 0
            Me.label2.Text = "日付時刻：（ドロップダウンカレンダー）"
            '
            'gcDate1
            '
            Me.gcDate1.AutoSize = True
            Me.gcDate1.DropDownCalendar.TodayImage = CType(resources.GetObject("gcDate1.DropDownCalendar.TodayImage"), System.Drawing.Image)
            DateLiteralField1.Text = "/"
            DateLiteralField2.Text = "/"
            Me.gcDate1.Fields.AddRange(New GrapeCity.Win.Editors.Fields.DateField() {DateYearField1, DateLiteralField1, DateMonthField1, DateLiteralField2, DateDayField1})
            Me.gcDate1.Location = New System.Drawing.Point(8, 77)
            Me.gcDate1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.gcDate1.Name = "gcDate1"
            Me.gcShortcut1.SetShortcuts(Me.gcDate1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.F5, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {CType(Me.gcDate1, Object), CType(Me.gcDate1, Object), CType(Me.gcDate1, Object)}, New String() {"ShortcutClear", "SetNow", "ApplyRecommendedValue"}))
            Me.gcDate1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.dropDownButton2})
            Me.gcDate1.Size = New System.Drawing.Size(93, 24)
            Me.gcDate1.TabIndex = 3
            Me.gcDate1.Value = New Date(2015, 1, 1, 0, 0, 0, 0)
            '
            'dropDownButton2
            '
            Me.dropDownButton2.Name = "dropDownButton2"
            '
            'gcNumber1
            '
            Me.gcNumber1.AutoSize = True
            Me.gcNumber1.Fields.IntegerPart.MinDigits = 1
            Me.gcNumber1.ImeMode = System.Windows.Forms.ImeMode.Off
            Me.gcNumber1.Location = New System.Drawing.Point(215, 36)
            Me.gcNumber1.MaxValue = New Decimal(New Integer() {12, 0, 0, 0})
            Me.gcNumber1.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.gcNumber1.Name = "gcNumber1"
            Me.gcShortcut1.SetShortcuts(Me.gcNumber1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.Subtract, System.Windows.Forms.Keys.OemMinus, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {CType(Me.gcNumber1, Object), CType(Me.gcNumber1, Object), CType(Me.gcNumber1, Object), CType(Me.gcNumber1, Object)}, New String() {"SetZero", "SwitchSign", "SwitchSign", "ApplyRecommendedValue"}))
            Me.gcNumber1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.spinButton1})
            Me.gcNumber1.Size = New System.Drawing.Size(48, 24)
            Me.gcNumber1.Spin.Wrap = False
            Me.gcNumber1.TabIndex = 3
            Me.gcNumber1.Value = New Decimal(New Integer() {1, 0, 0, 0})
            Me.gcNumber1.ValueSign = GrapeCity.Win.Editors.ValueSignControl.Positive
            '
            'spinButton1
            '
            Me.spinButton1.Name = "spinButton1"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(5, 54)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(212, 18)
            Me.label3.TabIndex = 2
            Me.label3.Text = "日付：（ドロップダウンカレンダー）"
            '
            'gcNumber2
            '
            Me.gcNumber2.AutoSize = True
            Me.gcNumber2.Fields.IntegerPart.MinDigits = 1
            Me.gcNumber2.ImeMode = System.Windows.Forms.ImeMode.Off
            Me.gcNumber2.Location = New System.Drawing.Point(215, 65)
            Me.gcNumber2.MaxValue = New Decimal(New Integer() {12, 0, 0, 0})
            Me.gcNumber2.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.gcNumber2.Name = "gcNumber2"
            Me.gcNumber2.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.spinButton2})
            Me.gcNumber2.Size = New System.Drawing.Size(48, 24)
            Me.gcNumber2.Spin.Wrap = False
            Me.gcNumber2.TabIndex = 5
            Me.gcNumber2.Value = New Decimal(New Integer() {1, 0, 0, 0})
            Me.gcNumber2.ValueSign = GrapeCity.Win.Editors.ValueSignControl.Positive
            '
            'spinButton2
            '
            Me.spinButton2.Name = "spinButton2"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(5, 65)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(176, 36)
            Me.label4.TabIndex = 4
            Me.label4.Text = "カレンダに表示する月数／年数" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "（縦）："
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(5, 33)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(176, 36)
            Me.label5.TabIndex = 2
            Me.label5.Text = "カレンダに表示する月数／年数" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "（横）："
            '
            'gcComboBox1
            '
            Me.gcComboBox1.AutoSize = True
            Me.gcComboBox1.DropDown.AutoWidth = True
            Me.gcComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.gcComboBox1.Ellipsis = GrapeCity.Win.Editors.EllipsisMode.EllipsisEnd
            SubItem1.Value = "MonthDay"
            SubItem2.Value = "月-日カレンダー形式で表示します。"
            ListItem1.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem1, SubItem2})
            SubItem3.Value = "YearMonth"
            SubItem4.Value = "年-月カレンダー形式で表示します。"
            ListItem2.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem3, SubItem4})
            Me.gcComboBox1.Items.AddRange(New GrapeCity.Win.Editors.ListItem() {ListItem1, ListItem2})
            Me.gcComboBox1.ListColumns.AddRange(New GrapeCity.Win.Editors.ListColumn() {Me.listColumn1, Me.listColumn2})
            Me.gcComboBox1.ListHeaderPane.Height = 25
            Me.gcComboBox1.Location = New System.Drawing.Point(135, 5)
            Me.gcComboBox1.Name = "gcComboBox1"
            Me.gcComboBox1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.dropDownButton7})
            Me.gcComboBox1.Size = New System.Drawing.Size(128, 26)
            Me.gcComboBox1.TabIndex = 1
            Me.gcComboBox1.UseCompatibleDrawing = True
            '
            'listColumn1
            '
            Me.listColumn1.AutoWidth = True
            Me.listColumn1.Header.Text = "値"
            '
            'listColumn2
            '
            Me.listColumn2.AutoWidth = True
            Me.listColumn2.Header.Text = "説明"
            '
            'dropDownButton7
            '
            Me.dropDownButton7.Name = "dropDownButton7"
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(5, 8)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(128, 18)
            Me.label6.TabIndex = 0
            Me.label6.Text = "カレンダーのタイプ："
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Location = New System.Drawing.Point(8, 104)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(135, 22)
            Me.checkBox1.TabIndex = 6
            Me.checkBox1.Text = "土日の色を変更する"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'checkBox2
            '
            Me.checkBox2.AutoSize = True
            Me.checkBox2.Location = New System.Drawing.Point(8, 131)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(111, 22)
            Me.checkBox2.TabIndex = 7
            Me.checkBox2.Text = "休日を表示する"
            Me.checkBox2.UseVisualStyleBackColor = True
            '
            'checkBox5
            '
            Me.checkBox5.AutoSize = True
            Me.checkBox5.Location = New System.Drawing.Point(8, 232)
            Me.checkBox5.Name = "checkBox5"
            Me.checkBox5.Size = New System.Drawing.Size(123, 22)
            Me.checkBox5.TabIndex = 10
            Me.checkBox5.Text = "週番号を表示する"
            Me.checkBox5.UseVisualStyleBackColor = True
            '
            'checkBox4
            '
            Me.checkBox4.AutoSize = True
            Me.checkBox4.Location = New System.Drawing.Point(8, 186)
            Me.checkBox4.Name = "checkBox4"
            Me.checkBox4.Size = New System.Drawing.Size(171, 40)
            Me.checkBox4.TabIndex = 9
            Me.checkBox4.Text = "カレンダーの下側の領域に" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "今日の日付を表示する"
            Me.checkBox4.UseVisualStyleBackColor = True
            '
            'checkBox3
            '
            Me.checkBox3.AutoSize = True
            Me.checkBox3.Location = New System.Drawing.Point(8, 159)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(123, 22)
            Me.checkBox3.TabIndex = 8
            Me.checkBox3.Text = "隣接日を表示する"
            Me.checkBox3.UseVisualStyleBackColor = True
            '
            'checkBox6
            '
            Me.checkBox6.AutoSize = True
            Me.checkBox6.Location = New System.Drawing.Point(8, 259)
            Me.checkBox6.Name = "checkBox6"
            Me.checkBox6.Size = New System.Drawing.Size(147, 22)
            Me.checkBox6.TabIndex = 11
            Me.checkBox6.Text = "ヘッダを和暦表示する"
            Me.checkBox6.UseVisualStyleBackColor = True
            '
            'DropDownCalendar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
            Me.Description = "日付時刻、日付コントロールに搭載されているドロップダウンカレンダーは、土日のスタイルの変更や休日の設定、外観スタイルの変更が可能です。"
            Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.Name = "DropDownCalendar"
            Me.Padding = New System.Windows.Forms.Padding(11, 16, 11, 3)
            Me.Title = "ドロップダウンカレンダー"
            Me.splitContainer1.Panel1.ResumeLayout(False)
            Me.splitContainer1.Panel1.PerformLayout()
            Me.splitContainer1.Panel2.ResumeLayout(False)
            Me.splitContainer1.Panel2.PerformLayout()
            CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainer1.ResumeLayout(False)
            CType(Me.gcDateTime1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcDate1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcNumber1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcNumber2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

        Private WithEvents gcDateTime1 As GrapeCity.Win.Editors.GcDateTime
        Private WithEvents dropDownButton1 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents gcShortcut1 As GrapeCity.Win.Editors.GcShortcut
        Private WithEvents gcDate1 As GrapeCity.Win.Editors.GcDate
        Private WithEvents dropDownButton2 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents gcNumber2 As GrapeCity.Win.Editors.GcNumber
        Private WithEvents spinButton2 As GrapeCity.Win.Editors.SpinButton
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents gcNumber1 As GrapeCity.Win.Editors.GcNumber
        Private WithEvents spinButton1 As GrapeCity.Win.Editors.SpinButton
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents gcComboBox1 As GrapeCity.Win.Editors.GcComboBox
        Private WithEvents listColumn1 As GrapeCity.Win.Editors.ListColumn
        Private WithEvents listColumn2 As GrapeCity.Win.Editors.ListColumn
        Private WithEvents dropDownButton7 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents label6 As System.Windows.Forms.Label
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
        Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
        Private WithEvents checkBox5 As System.Windows.Forms.CheckBox
        Private WithEvents checkBox4 As System.Windows.Forms.CheckBox
        Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
        Private WithEvents checkBox6 As System.Windows.Forms.CheckBox
	End Class
End Namespace
