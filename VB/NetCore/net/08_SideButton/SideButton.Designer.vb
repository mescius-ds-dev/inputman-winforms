Namespace _08_SideButton
	Partial Class SideButton
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
            Dim TimeSpanSignField1 As GrapeCity.Win.Editors.Fields.TimeSpanSignField = New GrapeCity.Win.Editors.Fields.TimeSpanSignField()
            Dim TimeSpanDayField1 As GrapeCity.Win.Editors.Fields.TimeSpanDayField = New GrapeCity.Win.Editors.Fields.TimeSpanDayField()
            Dim TimeSpanLiteralField1 As GrapeCity.Win.Editors.Fields.TimeSpanLiteralField = New GrapeCity.Win.Editors.Fields.TimeSpanLiteralField()
            Dim TimeSpanHourField1 As GrapeCity.Win.Editors.Fields.TimeSpanHourField = New GrapeCity.Win.Editors.Fields.TimeSpanHourField()
            Dim TimeSpanLiteralField2 As GrapeCity.Win.Editors.Fields.TimeSpanLiteralField = New GrapeCity.Win.Editors.Fields.TimeSpanLiteralField()
            Dim TimeSpanMinuteField1 As GrapeCity.Win.Editors.Fields.TimeSpanMinuteField = New GrapeCity.Win.Editors.Fields.TimeSpanMinuteField()
            Dim TimeSpanLiteralField3 As GrapeCity.Win.Editors.Fields.TimeSpanLiteralField = New GrapeCity.Win.Editors.Fields.TimeSpanLiteralField()
            Dim TimeSpanSecondField1 As GrapeCity.Win.Editors.Fields.TimeSpanSecondField = New GrapeCity.Win.Editors.Fields.TimeSpanSecondField()
            Dim MaskLiteralField3 As GrapeCity.Win.Editors.Fields.MaskLiteralField = New GrapeCity.Win.Editors.Fields.MaskLiteralField()
            Dim MaskPatternField4 As GrapeCity.Win.Editors.Fields.MaskPatternField = New GrapeCity.Win.Editors.Fields.MaskPatternField()
            Dim MaskLiteralField4 As GrapeCity.Win.Editors.Fields.MaskLiteralField = New GrapeCity.Win.Editors.Fields.MaskLiteralField()
            Dim MaskPatternField5 As GrapeCity.Win.Editors.Fields.MaskPatternField = New GrapeCity.Win.Editors.Fields.MaskPatternField()
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SideButton))
            Dim DateYearField1 As GrapeCity.Win.Editors.Fields.DateYearField = New GrapeCity.Win.Editors.Fields.DateYearField()
            Dim DateLiteralField1 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
            Dim DateMonthField1 As GrapeCity.Win.Editors.Fields.DateMonthField = New GrapeCity.Win.Editors.Fields.DateMonthField()
            Dim DateLiteralField2 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
            Dim DateDayField1 As GrapeCity.Win.Editors.Fields.DateDayField = New GrapeCity.Win.Editors.Fields.DateDayField()
            Dim MaskPatternField1 As GrapeCity.Win.Editors.Fields.MaskPatternField = New GrapeCity.Win.Editors.Fields.MaskPatternField()
            Dim MaskLiteralField1 As GrapeCity.Win.Editors.Fields.MaskLiteralField = New GrapeCity.Win.Editors.Fields.MaskLiteralField()
            Dim MaskPatternField2 As GrapeCity.Win.Editors.Fields.MaskPatternField = New GrapeCity.Win.Editors.Fields.MaskPatternField()
            Dim MaskLiteralField2 As GrapeCity.Win.Editors.Fields.MaskLiteralField = New GrapeCity.Win.Editors.Fields.MaskLiteralField()
            Dim MaskPatternField3 As GrapeCity.Win.Editors.Fields.MaskPatternField = New GrapeCity.Win.Editors.Fields.MaskPatternField()
            Me.gcTextBox1 = New GrapeCity.Win.Editors.GcTextBox(Me.components)
            Me.sideButton1 = New GrapeCity.Win.Editors.SideButton()
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.label2 = New System.Windows.Forms.Label()
            Me.gcShortcut1 = New GrapeCity.Win.Editors.GcShortcut(Me.components)
            Me.gcComboBox1 = New GrapeCity.Win.Editors.GcComboBox(Me.components)
            Me.sideButton8 = New GrapeCity.Win.Editors.SideButton()
            Me.gcTimeSpan1 = New GrapeCity.Win.Editors.GcTimeSpan(Me.components)
            Me.sideButton5 = New GrapeCity.Win.Editors.SideButton()
            Me.gcMask1 = New GrapeCity.Win.Editors.GcMask(Me.components)
            Me.sideButton2 = New GrapeCity.Win.Editors.SideButton()
            Me.gcDateTime1 = New GrapeCity.Win.Editors.GcDateTime(Me.components)
            Me.sideButton3 = New GrapeCity.Win.Editors.SideButton()
            Me.gcNumber1 = New GrapeCity.Win.Editors.GcNumber(Me.components)
            Me.sideButton6 = New GrapeCity.Win.Editors.SideButton()
            Me.sideButton7 = New GrapeCity.Win.Editors.SideButton()
            Me.gcDate1 = New GrapeCity.Win.Editors.GcDate(Me.components)
            Me.sideButton4 = New GrapeCity.Win.Editors.SideButton()
            Me.GcMaskedComboBox1 = New GrapeCity.Win.Editors.GcMaskedComboBox(Me.components)
            Me.SideButton9 = New GrapeCity.Win.Editors.SideButton()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label9 = New System.Windows.Forms.Label()
            Me.label6 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.dataSet1 = New System.Data.DataSet()
            Me.label5 = New System.Windows.Forms.Label()
            Me.label7 = New System.Windows.Forms.Label()
            Me.checkBox1 = New System.Windows.Forms.CheckBox()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.DataSet2 = New System.Data.DataSet()
            CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainer1.Panel1.SuspendLayout()
            Me.splitContainer1.Panel2.SuspendLayout()
            Me.splitContainer1.SuspendLayout()
            CType(Me.gcTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcTimeSpan1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcMask1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcDateTime1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcNumber1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcDate1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GcMaskedComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'splitContainer1
            '
            '
            'splitContainer1.Panel1
            '
            Me.splitContainer1.Panel1.Controls.Add(Me.Label15)
            Me.splitContainer1.Panel1.Controls.Add(Me.GcMaskedComboBox1)
            Me.splitContainer1.Panel1.Controls.Add(Me.gcDate1)
            Me.splitContainer1.Panel1.Controls.Add(Me.gcTextBox1)
            Me.splitContainer1.Panel1.Controls.Add(Me.label2)
            Me.splitContainer1.Panel1.Controls.Add(Me.gcComboBox1)
            Me.splitContainer1.Panel1.Controls.Add(Me.label7)
            Me.splitContainer1.Panel1.Controls.Add(Me.label3)
            Me.splitContainer1.Panel1.Controls.Add(Me.label9)
            Me.splitContainer1.Panel1.Controls.Add(Me.label6)
            Me.splitContainer1.Panel1.Controls.Add(Me.label4)
            Me.splitContainer1.Panel1.Controls.Add(Me.gcTimeSpan1)
            Me.splitContainer1.Panel1.Controls.Add(Me.label5)
            Me.splitContainer1.Panel1.Controls.Add(Me.gcMask1)
            Me.splitContainer1.Panel1.Controls.Add(Me.gcDateTime1)
            Me.splitContainer1.Panel1.Controls.Add(Me.gcNumber1)
            '
            'splitContainer1.Panel2
            '
            Me.splitContainer1.Panel2.Controls.Add(Me.checkBox1)
            Me.splitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(8, 0, 8, 4)
            '
            'gcTextBox1
            '
            Me.gcTextBox1.AutoSize = True
            Me.gcTextBox1.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.gcTextBox1.ImeMode = System.Windows.Forms.ImeMode.[On]
            Me.gcTextBox1.Location = New System.Drawing.Point(8, 29)
            Me.gcTextBox1.Name = "gcTextBox1"
            Me.gcShortcut1.SetShortcuts(Me.gcTextBox1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2}, New Object() {CType(Me.gcTextBox1, Object)}, New String() {"ShortcutClear"}))
            Me.gcTextBox1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.sideButton1})
            Me.gcTextBox1.Size = New System.Drawing.Size(260, 24)
            Me.gcTextBox1.TabIndex = 1
            '
            'sideButton1
            '
            Me.sideButton1.ButtonWidth = 110
            Me.sideButton1.Image = Global.InputManWin12_Demo.Resources.question
            Me.sideButton1.Name = "sideButton1"
            Me.sideButton1.Position = GrapeCity.Win.Editors.ButtonPosition.RightOutside
            Me.sideButton1.Text = "正解は"
            Me.sideButton1.TextAlignment = System.Windows.Forms.LeftRightAlignment.Left
            '
            'timer1
            '
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(5, 56)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(56, 18)
            Me.label2.TabIndex = 2
            Me.label2.Text = "マスク："
            '
            'gcComboBox1
            '
            Me.gcComboBox1.AlternateText.DisplayNull.ForeColor = System.Drawing.Color.Gray
            Me.gcComboBox1.AlternateText.DisplayNull.Text = "F4でドロップダウンします"
            Me.gcComboBox1.AutoSize = True
            Me.gcComboBox1.DropDown.AutoWidth = True
            Me.gcComboBox1.ImeMode = System.Windows.Forms.ImeMode.[On]
            Me.gcComboBox1.ListHeaderPane.Height = 25
            Me.gcComboBox1.Location = New System.Drawing.Point(7, 272)
            Me.gcComboBox1.MaxLength = 10
            Me.gcComboBox1.Name = "gcComboBox1"
            Me.gcComboBox1.RecommendedValue = "檜木工所"
            Me.gcShortcut1.SetShortcuts(Me.gcComboBox1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {CType(Me.gcComboBox1, Object), CType(Me.gcComboBox1, Object)}, New String() {"ShortcutClear", "ApplyRecommendedValue"}))
            Me.gcComboBox1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.sideButton8})
            Me.gcComboBox1.Size = New System.Drawing.Size(261, 26)
            Me.gcComboBox1.TabIndex = 13
            Me.gcComboBox1.TextSubItemIndex = 1
            '
            'sideButton8
            '
            Me.sideButton8.ButtonWidth = 110
            Me.sideButton8.Image = Global.InputManWin12_Demo.Resources.eraser
            Me.sideButton8.Name = "sideButton8"
            Me.sideButton8.Text = "値をクリア"
            '
            'gcTimeSpan1
            '
            Me.gcTimeSpan1.AutoSize = True
            TimeSpanLiteralField1.Text = "."
            TimeSpanHourField1.Digits = 2
            TimeSpanLiteralField2.Text = ":"
            TimeSpanMinuteField1.Digits = 2
            TimeSpanLiteralField3.Text = ":"
            TimeSpanSecondField1.Digits = 2
            Me.gcTimeSpan1.Fields.AddRange(New GrapeCity.Win.Editors.Fields.TimeSpanField() {TimeSpanSignField1, TimeSpanDayField1, TimeSpanLiteralField1, TimeSpanHourField1, TimeSpanLiteralField2, TimeSpanMinuteField1, TimeSpanLiteralField3, TimeSpanSecondField1})
            Me.gcTimeSpan1.ImeMode = System.Windows.Forms.ImeMode.Off
            Me.gcTimeSpan1.Location = New System.Drawing.Point(8, 224)
            Me.gcTimeSpan1.Name = "gcTimeSpan1"
            Me.gcShortcut1.SetShortcuts(Me.gcTimeSpan1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.Subtract, System.Windows.Forms.Keys.OemMinus, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {CType(Me.gcTimeSpan1, Object), CType(Me.gcTimeSpan1, Object), CType(Me.gcTimeSpan1, Object), CType(Me.gcTimeSpan1, Object)}, New String() {"ShortcutClear", "SwitchSign", "SwitchSign", "ApplyRecommendedValue"}))
            Me.gcTimeSpan1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.sideButton5})
            Me.gcTimeSpan1.Size = New System.Drawing.Size(182, 24)
            Me.gcTimeSpan1.TabIndex = 9
            Me.gcTimeSpan1.Value = System.TimeSpan.Parse("00:00:00")
            '
            'sideButton5
            '
            Me.sideButton5.ButtonWidth = 70
            Me.sideButton5.Image = Global.InputManWin12_Demo.Resources.stopwatch
            Me.sideButton5.Name = "sideButton5"
            Me.sideButton5.Position = GrapeCity.Win.Editors.ButtonPosition.LeftOutside
            Me.sideButton5.Text = "Start"
            '
            'gcMask1
            '
            Me.gcMask1.AutoSize = True
            MaskLiteralField3.Text = "〒 "
            MaskPatternField4.MaxLength = 3
            MaskPatternField4.MinLength = 3
            MaskPatternField4.Pattern = "\D"
            MaskLiteralField4.Text = "-"
            MaskPatternField5.MaxLength = 4
            MaskPatternField5.MinLength = 4
            MaskPatternField5.Pattern = "\D"
            Me.gcMask1.Fields.AddRange(New GrapeCity.Win.Editors.Fields.MaskField() {MaskLiteralField3, MaskPatternField4, MaskLiteralField4, MaskPatternField5})
            Me.gcMask1.ImeMode = System.Windows.Forms.ImeMode.Off
            Me.gcMask1.Location = New System.Drawing.Point(5, 77)
            Me.gcMask1.Name = "gcMask1"
            Me.gcShortcut1.SetShortcuts(Me.gcMask1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {CType(Me.gcMask1, Object), CType(Me.gcMask1, Object)}, New String() {"ShortcutClear", "ApplyRecommendedValue"}))
            Me.gcMask1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.sideButton2})
            Me.gcMask1.Size = New System.Drawing.Size(205, 24)
            Me.gcMask1.TabIndex = 3
            '
            'sideButton2
            '
            Me.sideButton2.ButtonWidth = 120
            Me.sideButton2.Image = Global.InputManWin12_Demo.Resources.find
            Me.sideButton2.Name = "sideButton2"
            Me.sideButton2.Position = GrapeCity.Win.Editors.ButtonPosition.RightOutside
            Me.sideButton2.Text = "住所を検索"
            Me.sideButton2.TextAlignment = System.Windows.Forms.LeftRightAlignment.Left
            '
            'gcDateTime1
            '
            Me.gcDateTime1.AutoSize = True
            Me.gcDateTime1.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.gcDateTime1.DropDownCalendar.TodayImage = CType(resources.GetObject("gcDateTime1.DropDownCalendar.TodayImage"), System.Drawing.Image)
            DateLiteralField3.Text = "/"
            DateLiteralField4.Text = "/"
            DateLiteralField6.Text = ":"
            DateLiteralField7.Text = ":"
            Me.gcDateTime1.Fields.AddRange(New GrapeCity.Win.Editors.Fields.DateField() {DateYearField2, DateLiteralField3, DateMonthField2, DateLiteralField4, DateDayField2, DateLiteralField5, DateHourField1, DateLiteralField6, DateMinuteField1, DateLiteralField7, DateSecondField1})
            Me.gcDateTime1.ImeMode = System.Windows.Forms.ImeMode.Off
            Me.gcDateTime1.Location = New System.Drawing.Point(5, 130)
            Me.gcDateTime1.Name = "gcDateTime1"
            Me.gcShortcut1.SetShortcuts(Me.gcDateTime1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.F5}, New Object() {CType(Me.gcDateTime1, Object), CType(Me.gcDateTime1, Object)}, New String() {"ShortcutClear", "SetNow"}))
            Me.gcDateTime1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.sideButton3})
            Me.gcDateTime1.Size = New System.Drawing.Size(263, 24)
            Me.gcDateTime1.TabIndex = 5
            Me.gcDateTime1.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
            '
            'sideButton3
            '
            Me.sideButton3.ButtonWidth = 120
            Me.sideButton3.Image = Global.InputManWin12_Demo.Resources.now
            Me.sideButton3.Name = "sideButton3"
            Me.sideButton3.Position = GrapeCity.Win.Editors.ButtonPosition.LeftOutside
            Me.sideButton3.Text = "現在日時"
            '
            'gcNumber1
            '
            Me.gcNumber1.AutoSize = True
            Me.gcNumber1.Fields.DecimalPart.MaxDigits = 0
            Me.gcNumber1.Fields.IntegerPart.GroupSizes = New Integer() {0}
            Me.gcNumber1.Fields.IntegerPart.MaxDigits = 3
            Me.gcNumber1.Fields.IntegerPart.MinDigits = 1
            Me.gcNumber1.Fields.SignSuffix.PositivePattern = " 歳 "
            Me.gcNumber1.ImeMode = System.Windows.Forms.ImeMode.Off
            Me.gcNumber1.Location = New System.Drawing.Point(196, 224)
            Me.gcNumber1.Name = "gcNumber1"
            Me.gcShortcut1.SetShortcuts(Me.gcNumber1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.Subtract, System.Windows.Forms.Keys.OemMinus}, New Object() {CType(Me.gcNumber1, Object), CType(Me.gcNumber1, Object), CType(Me.gcNumber1, Object)}, New String() {"SetZero", "SwitchSign", "SwitchSign"}))
            Me.gcNumber1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.sideButton6, Me.sideButton7})
            Me.gcNumber1.Size = New System.Drawing.Size(72, 24)
            Me.gcNumber1.TabIndex = 11
            Me.gcNumber1.ValueSign = GrapeCity.Win.Editors.ValueSignControl.Positive
            '
            'sideButton6
            '
            Me.sideButton6.Image = Global.InputManWin12_Demo.Resources.allowdown
            Me.sideButton6.Name = "sideButton6"
            Me.sideButton6.Position = GrapeCity.Win.Editors.ButtonPosition.LeftInside
            '
            'sideButton7
            '
            Me.sideButton7.Image = Global.InputManWin12_Demo.Resources.allowup
            Me.sideButton7.Name = "sideButton7"
            '
            'gcDate1
            '
            Me.gcDate1.AutoSize = True
            Me.gcDate1.DropDownCalendar.TodayImage = CType(resources.GetObject("gcDate1.DropDownCalendar.TodayImage"), System.Drawing.Image)
            DateLiteralField1.Text = "/"
            DateLiteralField2.Text = "/"
            Me.gcDate1.Fields.AddRange(New GrapeCity.Win.Editors.Fields.DateField() {DateYearField1, DateLiteralField1, DateMonthField1, DateLiteralField2, DateDayField1})
            Me.gcDate1.Location = New System.Drawing.Point(8, 178)
            Me.gcDate1.Margin = New System.Windows.Forms.Padding(2)
            Me.gcDate1.Name = "gcDate1"
            Me.gcShortcut1.SetShortcuts(Me.gcDate1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.F5, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {CType(Me.gcDate1, Object), CType(Me.gcDate1, Object), CType(Me.gcDate1, Object)}, New String() {"ShortcutClear", "SetNow", "ApplyRecommendedValue"}))
            Me.gcDate1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.sideButton4})
            Me.gcDate1.Size = New System.Drawing.Size(202, 24)
            Me.gcDate1.TabIndex = 7
            Me.gcDate1.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
            '
            'sideButton4
            '
            Me.sideButton4.ButtonWidth = 120
            Me.sideButton4.Image = Global.InputManWin12_Demo.Resources.calendar
            Me.sideButton4.Name = "sideButton4"
            Me.sideButton4.Position = GrapeCity.Win.Editors.ButtonPosition.LeftInside
            Me.sideButton4.Text = "今日を設定"
            '
            'GcMaskedComboBox1
            '
            Me.GcMaskedComboBox1.AlternateText.DisplayNull.ForeColor = System.Drawing.Color.Gray
            Me.GcMaskedComboBox1.AlternateText.DisplayNull.Text = "F4でドロップダウンします"
            Me.GcMaskedComboBox1.AutoSize = True
            MaskPatternField1.MaxLength = 4
            MaskPatternField1.MinLength = 2
            MaskPatternField1.Pattern = "\D"
            MaskLiteralField1.Text = "-"
            MaskPatternField2.MaxLength = 4
            MaskPatternField2.MinLength = 2
            MaskPatternField2.Pattern = "\D"
            MaskLiteralField2.Text = "-"
            MaskPatternField3.MaxLength = 4
            MaskPatternField3.MinLength = 4
            MaskPatternField3.Pattern = "\D"
            Me.GcMaskedComboBox1.Fields.AddRange(New GrapeCity.Win.Editors.Fields.MaskField() {MaskPatternField1, MaskLiteralField1, MaskPatternField2, MaskLiteralField2, MaskPatternField3})
            Me.GcMaskedComboBox1.ListHeaderPane.Height = 25
            Me.GcMaskedComboBox1.Location = New System.Drawing.Point(8, 320)
            Me.GcMaskedComboBox1.Name = "GcMaskedComboBox1"
            Me.gcShortcut1.SetShortcuts(Me.GcMaskedComboBox1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {CType(Me.GcMaskedComboBox1, Object), CType(Me.GcMaskedComboBox1, Object)}, New String() {"ShortcutClear", "ApplyRecommendedValue"}))
            Me.GcMaskedComboBox1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.SideButton9})
            Me.GcMaskedComboBox1.Size = New System.Drawing.Size(260, 26)
            Me.GcMaskedComboBox1.TabIndex = 32
            Me.GcMaskedComboBox1.TextSubItemIndex = 1
            '
            'SideButton9
            '
            Me.SideButton9.ButtonWidth = 110
            Me.SideButton9.Image = Global.InputManWin12_Demo.Resources.eraser
            Me.SideButton9.Name = "SideButton9"
            Me.SideButton9.Text = "値をクリア"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(5, 109)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(68, 18)
            Me.label3.TabIndex = 4
            Me.label3.Text = "日付時刻："
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Location = New System.Drawing.Point(5, 203)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(92, 18)
            Me.label9.TabIndex = 8
            Me.label9.Text = "タイムスパン："
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(5, 8)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(68, 18)
            Me.label6.TabIndex = 0
            Me.label6.Text = "テキスト："
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(193, 203)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(44, 18)
            Me.label4.TabIndex = 10
            Me.label4.Text = "数値："
            '
            'dataSet1
            '
            Me.dataSet1.DataSetName = "NewDataSet"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(4, 251)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(56, 18)
            Me.label5.TabIndex = 12
            Me.label5.Text = "コンボ："
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(5, 157)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(44, 18)
            Me.label7.TabIndex = 6
            Me.label7.Text = "日付："
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Location = New System.Drawing.Point(8, 8)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(207, 40)
            Me.checkBox1.TabIndex = 0
            Me.checkBox1.Text = "クリックによってチェック状態と" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "非チェック状態を切り替える"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(5, 301)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(92, 18)
            Me.Label15.TabIndex = 33
            Me.Label15.Text = "マスクコンボ："
            '
            'DataSet2
            '
            Me.DataSet2.DataSetName = "NewDataSet"
            '
            'SideButton
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
            Me.Description = "サイドボタンは標準のButtonコントロールのような外観を持つボタンです。デザインは任意のイメージとテキストでカスタマイズできます。"
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "SideButton"
            Me.Padding = New System.Windows.Forms.Padding(11, 16, 11, 3)
            Me.Title = "サイドボタン"
            Me.splitContainer1.Panel1.ResumeLayout(False)
            Me.splitContainer1.Panel1.PerformLayout()
            Me.splitContainer1.Panel2.ResumeLayout(False)
            Me.splitContainer1.Panel2.PerformLayout()
            CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainer1.ResumeLayout(False)
            CType(Me.gcTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcTimeSpan1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcMask1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcDateTime1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcNumber1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcDate1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GcMaskedComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

        Private WithEvents gcTextBox1 As GrapeCity.Win.Editors.GcTextBox
        Private WithEvents gcShortcut1 As GrapeCity.Win.Editors.GcShortcut
        Private WithEvents sideButton1 As GrapeCity.Win.Editors.SideButton
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents gcComboBox1 As GrapeCity.Win.Editors.GcComboBox
        Private WithEvents sideButton8 As GrapeCity.Win.Editors.SideButton
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents label9 As System.Windows.Forms.Label
        Private WithEvents label6 As System.Windows.Forms.Label
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents gcTimeSpan1 As GrapeCity.Win.Editors.GcTimeSpan
        Private WithEvents sideButton5 As GrapeCity.Win.Editors.SideButton
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents gcMask1 As GrapeCity.Win.Editors.GcMask
        Private WithEvents sideButton2 As GrapeCity.Win.Editors.SideButton
        Private WithEvents gcDateTime1 As GrapeCity.Win.Editors.GcDateTime
        Private WithEvents gcNumber1 As GrapeCity.Win.Editors.GcNumber
        Private WithEvents timer1 As System.Windows.Forms.Timer
        Private WithEvents dataSet1 As System.Data.DataSet
        Private WithEvents gcDate1 As GrapeCity.Win.Editors.GcDate
        Private WithEvents label7 As System.Windows.Forms.Label
        Private WithEvents sideButton4 As GrapeCity.Win.Editors.SideButton
        Private WithEvents sideButton3 As GrapeCity.Win.Editors.SideButton
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
        Private WithEvents sideButton6 As GrapeCity.Win.Editors.SideButton
        Private WithEvents sideButton7 As GrapeCity.Win.Editors.SideButton
        Private WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents GcMaskedComboBox1 As GrapeCity.Win.Editors.GcMaskedComboBox
        Friend WithEvents SideButton9 As GrapeCity.Win.Editors.SideButton
        Friend WithEvents DataSet2 As System.Data.DataSet

	End Class
End Namespace
