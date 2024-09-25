Namespace _06_Display
    Partial Class PlaceHolder

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

        'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
        'Windows フォーム デザイナーを使用して変更できます。  
        'コード エディターを使って変更しないでください。
        Private Sub InitializeComponent()
            components = New ComponentModel.Container()
            Dim DateHourField1 As GrapeCity.Win.Editors.Fields.DateHourField = New GrapeCity.Win.Editors.Fields.DateHourField()
            Dim DateLiteralField1 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
            Dim DateMinuteField1 As GrapeCity.Win.Editors.Fields.DateMinuteField = New GrapeCity.Win.Editors.Fields.DateMinuteField()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlaceHolder))
            Dim DateYearField1 As GrapeCity.Win.Editors.Fields.DateYearField = New GrapeCity.Win.Editors.Fields.DateYearField()
            Dim DateLiteralField2 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
            Dim DateMonthField1 As GrapeCity.Win.Editors.Fields.DateMonthField = New GrapeCity.Win.Editors.Fields.DateMonthField()
            Dim DateLiteralField3 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
            Dim DateDayField1 As GrapeCity.Win.Editors.Fields.DateDayField = New GrapeCity.Win.Editors.Fields.DateDayField()
            Dim TimeSpanHourField1 As GrapeCity.Win.Editors.Fields.TimeSpanHourField = New GrapeCity.Win.Editors.Fields.TimeSpanHourField()
            Dim TimeSpanLiteralField1 As GrapeCity.Win.Editors.Fields.TimeSpanLiteralField = New GrapeCity.Win.Editors.Fields.TimeSpanLiteralField()
            Dim DateYearField2 As GrapeCity.Win.Editors.Fields.DateYearField = New GrapeCity.Win.Editors.Fields.DateYearField()
            Dim DateLiteralField4 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
            Dim DateMonthField2 As GrapeCity.Win.Editors.Fields.DateMonthField = New GrapeCity.Win.Editors.Fields.DateMonthField()
            Dim DateLiteralField5 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
            Dim DateDayField2 As GrapeCity.Win.Editors.Fields.DateDayField = New GrapeCity.Win.Editors.Fields.DateDayField()
            Dim DateLiteralField6 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
            Dim DateHourField2 As GrapeCity.Win.Editors.Fields.DateHourField = New GrapeCity.Win.Editors.Fields.DateHourField()
            Dim DateLiteralField7 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
            Dim DateMinuteField2 As GrapeCity.Win.Editors.Fields.DateMinuteField = New GrapeCity.Win.Editors.Fields.DateMinuteField()
            Dim MaskLiteralField1 As GrapeCity.Win.Editors.Fields.MaskLiteralField = New GrapeCity.Win.Editors.Fields.MaskLiteralField()
            Dim MaskPatternField1 As GrapeCity.Win.Editors.Fields.MaskPatternField = New GrapeCity.Win.Editors.Fields.MaskPatternField()
            Dim MaskLiteralField2 As GrapeCity.Win.Editors.Fields.MaskLiteralField = New GrapeCity.Win.Editors.Fields.MaskLiteralField()
            Dim MaskPatternField2 As GrapeCity.Win.Editors.Fields.MaskPatternField = New GrapeCity.Win.Editors.Fields.MaskPatternField()
            Dim NumberSignDisplayField1 As GrapeCity.Win.Editors.Fields.NumberSignDisplayField = New GrapeCity.Win.Editors.Fields.NumberSignDisplayField()
            Dim NumberIntegerPartDisplayField1 As GrapeCity.Win.Editors.Fields.NumberIntegerPartDisplayField = New GrapeCity.Win.Editors.Fields.NumberIntegerPartDisplayField()
            Dim ListItem1 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem()
            Dim SubItem1 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem()
            Dim SubItem2 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem()
            Dim ListItem2 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem()
            Dim SubItem3 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem()
            Dim SubItem4 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem()
            Dim ListItem3 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem()
            Dim SubItem5 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem()
            Dim SubItem6 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem()
            dataSet2 = New Data.DataSet()
            dataSet1 = New Data.DataSet()
            label10 = New Windows.Forms.Label()
            gcComboBox1 = New GrapeCity.Win.Editors.GcComboBox(components)
            dropDownButton4 = New GrapeCity.Win.Editors.DropDownButton()
            label7 = New Windows.Forms.Label()
            gcTime1 = New GrapeCity.Win.Editors.GcTime(components)
            gcDate1 = New GrapeCity.Win.Editors.GcDate(components)
            dropDownButton3 = New GrapeCity.Win.Editors.DropDownButton()
            gcTimeSpan1 = New GrapeCity.Win.Editors.GcTimeSpan(components)
            label2 = New Windows.Forms.Label()
            label6 = New Windows.Forms.Label()
            gcDateTime1 = New GrapeCity.Win.Editors.GcDateTime(components)
            dropDownButton1 = New GrapeCity.Win.Editors.DropDownButton()
            gcMask1 = New GrapeCity.Win.Editors.GcMask(components)
            gcTextBox1 = New GrapeCity.Win.Editors.GcTextBox(components)
            label3 = New Windows.Forms.Label()
            gcNumber1 = New GrapeCity.Win.Editors.GcNumber(components)
            label9 = New Windows.Forms.Label()
            label8 = New Windows.Forms.Label()
            label5 = New Windows.Forms.Label()
            gcComboBox2 = New GrapeCity.Win.Editors.GcComboBox(components)
            listColumn39 = New GrapeCity.Win.Editors.ListColumn()
            listColumn40 = New GrapeCity.Win.Editors.ListColumn()
            dropDownButton21 = New GrapeCity.Win.Editors.DropDownButton()
            gcNumber2 = New GrapeCity.Win.Editors.GcNumber(components)
            spinButton1 = New GrapeCity.Win.Editors.SpinButton()
            label11 = New Windows.Forms.Label()
            label4 = New Windows.Forms.Label()
            checkBox1 = New Windows.Forms.CheckBox()
            CType(splitContainer1, ComponentModel.ISupportInitialize).BeginInit()
            splitContainer1.Panel1.SuspendLayout()
            splitContainer1.Panel2.SuspendLayout()
            splitContainer1.SuspendLayout()
            CType(dataSet2, ComponentModel.ISupportInitialize).BeginInit()
            CType(dataSet1, ComponentModel.ISupportInitialize).BeginInit()
            CType(gcComboBox1, ComponentModel.ISupportInitialize).BeginInit()
            CType(gcTime1, ComponentModel.ISupportInitialize).BeginInit()
            CType(gcDate1, ComponentModel.ISupportInitialize).BeginInit()
            CType(gcTimeSpan1, ComponentModel.ISupportInitialize).BeginInit()
            CType(gcDateTime1, ComponentModel.ISupportInitialize).BeginInit()
            CType(gcMask1, ComponentModel.ISupportInitialize).BeginInit()
            CType(gcTextBox1, ComponentModel.ISupportInitialize).BeginInit()
            CType(gcNumber1, ComponentModel.ISupportInitialize).BeginInit()
            CType(gcComboBox2, ComponentModel.ISupportInitialize).BeginInit()
            CType(gcNumber2, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' splitContainer1
            ' 
            ' 
            ' splitContainer1.Panel1
            ' 
            splitContainer1.Panel1.Controls.Add(label10)
            splitContainer1.Panel1.Controls.Add(gcComboBox1)
            splitContainer1.Panel1.Controls.Add(label7)
            splitContainer1.Panel1.Controls.Add(gcTime1)
            splitContainer1.Panel1.Controls.Add(gcDate1)
            splitContainer1.Panel1.Controls.Add(gcTimeSpan1)
            splitContainer1.Panel1.Controls.Add(label2)
            splitContainer1.Panel1.Controls.Add(label6)
            splitContainer1.Panel1.Controls.Add(gcDateTime1)
            splitContainer1.Panel1.Controls.Add(gcMask1)
            splitContainer1.Panel1.Controls.Add(gcTextBox1)
            splitContainer1.Panel1.Controls.Add(label3)
            splitContainer1.Panel1.Controls.Add(gcNumber1)
            splitContainer1.Panel1.Controls.Add(label9)
            splitContainer1.Panel1.Controls.Add(label8)
            splitContainer1.Panel1.Controls.Add(label5)
            ' 
            ' splitContainer1.Panel2
            ' 
            splitContainer1.Panel2.Controls.Add(gcComboBox2)
            splitContainer1.Panel2.Controls.Add(gcNumber2)
            splitContainer1.Panel2.Controls.Add(label11)
            splitContainer1.Panel2.Controls.Add(label4)
            splitContainer1.Panel2.Controls.Add(checkBox1)
            ' 
            ' dataSet2
            ' 
            dataSet2.DataSetName = "NewDataSet"
            ' 
            ' dataSet1
            ' 
            dataSet1.DataSetName = "NewDataSet"
            ' 
            ' label10
            ' 
            label10.AutoSize = True
            label10.Location = New System.Drawing.Point(6, 248)
            label10.Name = "label10"
            label10.Size = New System.Drawing.Size(56, 18)
            label10.TabIndex = 32
            label10.Text = "コンボ："
            ' 
            ' gcComboBox1
            ' 
            gcComboBox1.DropDown.AutoWidth = True
            gcComboBox1.ImeMode = Windows.Forms.ImeMode.On
            gcComboBox1.ListHeaderPane.Height = 25
            gcComboBox1.Location = New System.Drawing.Point(9, 269)
            gcComboBox1.MaxLength = 10
            gcComboBox1.Name = "gcComboBox1"
            gcComboBox1.PlaceHolder.Text = "県名"
            gcComboBox1.RecommendedValue = "檜木工所"
            gcComboBox1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {dropDownButton4})
            gcComboBox1.Size = New System.Drawing.Size(124, 50)
            gcComboBox1.TabIndex = 33
            gcComboBox1.TextSubItemIndex = 1
            ' 
            ' dropDownButton4
            ' 
            dropDownButton4.Name = "dropDownButton4"
            ' 
            ' label7
            ' 
            label7.AutoSize = True
            label7.Location = New System.Drawing.Point(135, 248)
            label7.Name = "label7"
            label7.Size = New System.Drawing.Size(44, 18)
            label7.TabIndex = 30
            label7.Text = "数値："
            ' 
            ' gcTime1
            ' 
            DateLiteralField1.Text = ":"
            gcTime1.Fields.AddRange(New GrapeCity.Win.Editors.Fields.DateField() {DateHourField1, DateLiteralField1, DateMinuteField1})
            gcTime1.Location = New System.Drawing.Point(136, 189)
            gcTime1.Margin = New System.Windows.Forms.Padding(2)
            gcTime1.Name = "gcTime1"
            gcTime1.PlaceHolder.Text = "終了時刻"
            gcTime1.Size = New System.Drawing.Size(124, 50)
            gcTime1.TabIndex = 27
            gcTime1.Value = TimeSpan.Parse("16:50:00")
            ' 
            ' gcDate1
            ' 
            gcDate1.DropDownCalendar.TodayImage = CType(resources.GetObject("gcDate1.DropDownCalendar.TodayImage"), Drawing.Image)
            DateLiteralField2.Text = "/"
            DateLiteralField3.Text = "/"
            gcDate1.Fields.AddRange(New GrapeCity.Win.Editors.Fields.DateField() {DateYearField1, DateLiteralField2, DateMonthField1, DateLiteralField3, DateDayField1})
            gcDate1.Location = New System.Drawing.Point(8, 108)
            gcDate1.Margin = New System.Windows.Forms.Padding(2)
            gcDate1.Name = "gcDate1"
            gcDate1.PlaceHolder.Text = "生年月日"
            gcDate1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {dropDownButton3})
            gcDate1.Size = New System.Drawing.Size(124, 50)
            gcDate1.TabIndex = 25
            gcDate1.Value = New Date(2015, 5, 1, 0, 0, 0, 0)
            ' 
            ' dropDownButton3
            ' 
            dropDownButton3.Name = "dropDownButton3"
            ' 
            ' gcTimeSpan1
            ' 
            TimeSpanLiteralField1.Text = " 時間"
            gcTimeSpan1.Fields.AddRange(New GrapeCity.Win.Editors.Fields.TimeSpanField() {TimeSpanHourField1, TimeSpanLiteralField1})
            gcTimeSpan1.ImeMode = Windows.Forms.ImeMode.Off
            gcTimeSpan1.Location = New System.Drawing.Point(8, 189)
            gcTimeSpan1.Name = "gcTimeSpan1"
            gcTimeSpan1.PlaceHolder.Text = "時間"
            gcTimeSpan1.Size = New System.Drawing.Size(124, 50)
            gcTimeSpan1.TabIndex = 29
            gcTimeSpan1.Value = TimeSpan.Parse("02:00:00")
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Location = New System.Drawing.Point(5, 8)
            label2.Name = "label2"
            label2.Size = New System.Drawing.Size(68, 18)
            label2.TabIndex = 18
            label2.Text = "テキスト："
            ' 
            ' label6
            ' 
            label6.AutoSize = True
            label6.Location = New System.Drawing.Point(5, 168)
            label6.Name = "label6"
            label6.Size = New System.Drawing.Size(92, 18)
            label6.TabIndex = 28
            label6.Text = "タイムスパン："
            ' 
            ' gcDateTime1
            ' 
            gcDateTime1.DropDownCalendar.TodayImage = CType(resources.GetObject("gcDateTime1.DropDownCalendar.TodayImage"), Drawing.Image)
            DateLiteralField4.Text = "/"
            DateLiteralField5.Text = "/"
            DateLiteralField7.Text = ":"
            gcDateTime1.Fields.AddRange(New GrapeCity.Win.Editors.Fields.DateField() {DateYearField2, DateLiteralField4, DateMonthField2, DateLiteralField5, DateDayField2, DateLiteralField6, DateHourField2, DateLiteralField7, DateMinuteField2})
            gcDateTime1.ImeMode = Windows.Forms.ImeMode.Off
            gcDateTime1.Location = New System.Drawing.Point(137, 108)
            gcDateTime1.Name = "gcDateTime1"
            gcDateTime1.PlaceHolder.Text = "開始日時"
            gcDateTime1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {dropDownButton1})
            gcDateTime1.Size = New System.Drawing.Size(124, 50)
            gcDateTime1.TabIndex = 23
            gcDateTime1.Value = New Date(2015, 5, 1, 17, 0, 0, 0)
            ' 
            ' dropDownButton1
            ' 
            dropDownButton1.Name = "dropDownButton1"
            ' 
            ' gcMask1
            ' 
            MaskLiteralField1.Text = "〒 "
            MaskPatternField1.MaxLength = 3
            MaskPatternField1.MinLength = 3
            MaskPatternField1.Pattern = "\D"
            MaskLiteralField2.Text = "-"
            MaskPatternField2.MaxLength = 4
            MaskPatternField2.MinLength = 4
            MaskPatternField2.Pattern = "\D"
            gcMask1.Fields.AddRange(New GrapeCity.Win.Editors.Fields.MaskField() {MaskLiteralField1, MaskPatternField1, MaskLiteralField2, MaskPatternField2})
            gcMask1.ImeMode = Windows.Forms.ImeMode.Off
            gcMask1.Location = New System.Drawing.Point(138, 29)
            gcMask1.Name = "gcMask1"
            gcMask1.PlaceHolder.Text = "郵便番号"
            gcMask1.Size = New System.Drawing.Size(124, 50)
            gcMask1.TabIndex = 21
            gcMask1.Value = "0110001"
            ' 
            ' gcTextBox1
            ' 
            gcTextBox1.ImeMode = Windows.Forms.ImeMode.On
            gcTextBox1.Location = New System.Drawing.Point(8, 29)
            gcTextBox1.Name = "gcTextBox1"
            gcTextBox1.PlaceHolder.Text = "氏名"
            gcTextBox1.Size = New System.Drawing.Size(124, 50)
            gcTextBox1.TabIndex = 19
            gcTextBox1.Text = "仙台太郎"
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.Location = New System.Drawing.Point(135, 8)
            label3.Name = "label3"
            label3.Size = New System.Drawing.Size(56, 18)
            label3.TabIndex = 20
            label3.Text = "マスク："
            ' 
            ' gcNumber1
            ' 
            NumberSignDisplayField1.NegativePattern = "\-"
            NumberSignDisplayField1.PositivePattern = "\"
            NumberIntegerPartDisplayField1.GroupSizes = New Integer() {3}
            gcNumber1.DisplayFields.AddRange(New GrapeCity.Win.Editors.Fields.NumberDisplayField() {NumberSignDisplayField1, NumberIntegerPartDisplayField1})
            gcNumber1.Fields.DecimalPart.MaxDigits = 0
            gcNumber1.Fields.IntegerPart.GroupSizes = New Integer() {0}
            gcNumber1.Fields.IntegerPart.MaxDigits = 9
            gcNumber1.Fields.IntegerPart.MinDigits = 9
            gcNumber1.ImeMode = Windows.Forms.ImeMode.Off
            gcNumber1.Location = New System.Drawing.Point(136, 269)
            gcNumber1.Name = "gcNumber1"
            gcNumber1.PlaceHolder.Text = "価格"
            gcNumber1.Size = New System.Drawing.Size(124, 50)
            gcNumber1.TabIndex = 31
            gcNumber1.Value = New Decimal(New Integer() {10000, 0, 0, 0})
            ' 
            ' label9
            ' 
            label9.AutoSize = True
            label9.Location = New System.Drawing.Point(135, 168)
            label9.Name = "label9"
            label9.Size = New System.Drawing.Size(44, 18)
            label9.TabIndex = 26
            label9.Text = "時刻："
            ' 
            ' label8
            ' 
            label8.AutoSize = True
            label8.Location = New System.Drawing.Point(5, 88)
            label8.Name = "label8"
            label8.Size = New System.Drawing.Size(44, 18)
            label8.TabIndex = 24
            label8.Text = "日付："
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.Location = New System.Drawing.Point(135, 88)
            label5.Name = "label5"
            label5.Size = New System.Drawing.Size(68, 18)
            label5.TabIndex = 22
            label5.Text = "日付時刻："
            ' 
            ' gcComboBox2
            ' 
            gcComboBox2.AutoSize = True
            gcComboBox2.DropDown.AutoWidth = True
            gcComboBox2.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
            gcComboBox2.Ellipsis = GrapeCity.Win.Editors.EllipsisMode.EllipsisEnd
            SubItem1.Value = "Left"
            SubItem2.Value = "左に配置します。"
            ListItem1.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem1, SubItem2})
            SubItem3.Value = "Center"
            SubItem4.Value = "中央に配置します。"
            ListItem2.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem3, SubItem4})
            SubItem5.Value = "Right"
            SubItem6.Value = "右に配置します。"
            ListItem3.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem5, SubItem6})
            gcComboBox2.Items.AddRange(New GrapeCity.Win.Editors.ListItem() {ListItem1, ListItem2, ListItem3})
            gcComboBox2.ListColumns.AddRange(New GrapeCity.Win.Editors.ListColumn() {listColumn39, listColumn40})
            gcComboBox2.ListHeaderPane.Height = 25
            gcComboBox2.Location = New System.Drawing.Point(111, 58)
            gcComboBox2.Name = "gcComboBox2"
            gcComboBox2.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {dropDownButton21})
            gcComboBox2.Size = New System.Drawing.Size(128, 26)
            gcComboBox2.TabIndex = 11
            gcComboBox2.UseCompatibleDrawing = True
            ' 
            ' listColumn39
            ' 
            listColumn39.AutoWidth = True
            listColumn39.Header.Text = "値"
            ' 
            ' listColumn40
            ' 
            listColumn40.AutoWidth = True
            listColumn40.Header.Text = "説明"
            ' 
            ' dropDownButton21
            ' 
            dropDownButton21.Name = "dropDownButton21"
            ' 
            ' gcNumber2
            ' 
            gcNumber2.AutoSize = True
            gcNumber2.Fields.IntegerPart.MinDigits = 1
            gcNumber2.ImeMode = Windows.Forms.ImeMode.Off
            gcNumber2.Location = New System.Drawing.Point(111, 32)
            gcNumber2.MaxValue = New Decimal(New Integer() {15, 0, 0, 0})
            gcNumber2.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            gcNumber2.Name = "gcNumber2"
            gcNumber2.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {spinButton1})
            gcNumber2.Size = New System.Drawing.Size(45, 24)
            gcNumber2.Spin.Wrap = False
            gcNumber2.TabIndex = 10
            gcNumber2.Value = New Decimal(New Integer() {7, 0, 0, 0})
            gcNumber2.ValueSign = GrapeCity.Win.Editors.ValueSignControl.Positive
            ' 
            ' spinButton1
            ' 
            spinButton1.Name = "spinButton1"
            ' 
            ' label11
            ' 
            label11.AutoSize = True
            label11.Location = New System.Drawing.Point(13, 61)
            label11.Name = "label11"
            label11.Size = New System.Drawing.Size(56, 18)
            label11.TabIndex = 9
            label11.Text = "表示位置"
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.Location = New System.Drawing.Point(13, 35)
            label4.Name = "label4"
            label4.Size = New System.Drawing.Size(92, 18)
            label4.TabIndex = 8
            label4.Text = "フォントサイズ"
            ' 
            ' checkBox1
            ' 
            checkBox1.AutoSize = True
            checkBox1.Location = New System.Drawing.Point(8, 8)
            checkBox1.Name = "checkBox1"
            checkBox1.Size = New System.Drawing.Size(207, 22)
            checkBox1.TabIndex = 7
            checkBox1.Text = "フローティングラベルを表示する"
            checkBox1.UseVisualStyleBackColor = True
            ' 
            ' PlaceHolder
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(7F, 18F)
            Description = "入力コントロール内にラベルを表示しコントロールに入力を開始するとラベルは上部に移動します。"
            Name = "PlaceHolder"
            Title = "フローティングラベルの表示"
            splitContainer1.Panel1.ResumeLayout(False)
            splitContainer1.Panel1.PerformLayout()
            splitContainer1.Panel2.ResumeLayout(False)
            splitContainer1.Panel2.PerformLayout()
            CType(splitContainer1, ComponentModel.ISupportInitialize).EndInit()
            splitContainer1.ResumeLayout(False)
            CType(dataSet2, ComponentModel.ISupportInitialize).EndInit()
            CType(dataSet1, ComponentModel.ISupportInitialize).EndInit()
            CType(gcComboBox1, ComponentModel.ISupportInitialize).EndInit()
            CType(gcTime1, ComponentModel.ISupportInitialize).EndInit()
            CType(gcDate1, ComponentModel.ISupportInitialize).EndInit()
            CType(gcTimeSpan1, ComponentModel.ISupportInitialize).EndInit()
            CType(gcDateTime1, ComponentModel.ISupportInitialize).EndInit()
            CType(gcMask1, ComponentModel.ISupportInitialize).EndInit()
            CType(gcTextBox1, ComponentModel.ISupportInitialize).EndInit()
            CType(gcNumber1, ComponentModel.ISupportInitialize).EndInit()
            CType(gcComboBox2, ComponentModel.ISupportInitialize).EndInit()
            CType(gcNumber2, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub
        Private WithEvents dataSet2 As System.Data.DataSet
        Private WithEvents dataSet1 As System.Data.DataSet
        Private WithEvents label10 As Windows.Forms.Label
        Private WithEvents gcComboBox1 As GrapeCity.Win.Editors.GcComboBox
        Private WithEvents dropDownButton4 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents label7 As Windows.Forms.Label
        Private WithEvents gcTime1 As GrapeCity.Win.Editors.GcTime
        Private WithEvents gcDate1 As GrapeCity.Win.Editors.GcDate
        Private WithEvents dropDownButton3 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents gcTimeSpan1 As GrapeCity.Win.Editors.GcTimeSpan
        Private WithEvents label2 As Windows.Forms.Label
        Private WithEvents label6 As Windows.Forms.Label
        Private WithEvents gcDateTime1 As GrapeCity.Win.Editors.GcDateTime
        Private WithEvents dropDownButton1 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents gcMask1 As GrapeCity.Win.Editors.GcMask
        Private WithEvents gcTextBox1 As GrapeCity.Win.Editors.GcTextBox
        Private WithEvents label3 As Windows.Forms.Label
        Private WithEvents gcNumber1 As GrapeCity.Win.Editors.GcNumber
        Private WithEvents label9 As Windows.Forms.Label
        Private WithEvents label8 As Windows.Forms.Label
        Private WithEvents label5 As Windows.Forms.Label
        Private WithEvents gcComboBox2 As GrapeCity.Win.Editors.GcComboBox
        Private WithEvents listColumn39 As GrapeCity.Win.Editors.ListColumn
        Private WithEvents listColumn40 As GrapeCity.Win.Editors.ListColumn
        Private WithEvents dropDownButton21 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents gcNumber2 As GrapeCity.Win.Editors.GcNumber
        Private WithEvents spinButton1 As GrapeCity.Win.Editors.SpinButton
        Private WithEvents label11 As Windows.Forms.Label
        Private WithEvents label4 As Windows.Forms.Label
        Private WithEvents checkBox1 As Windows.Forms.CheckBox
    End Class

End Namespace