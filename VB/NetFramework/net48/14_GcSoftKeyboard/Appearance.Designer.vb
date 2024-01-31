Namespace _14_GcSoftKeyboard
    Partial Class Appearance
        ''' <summary>
        ''' 必要なデザイナー変数です。
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' 使用中のリソースをすべてクリーンアップします。
        ''' </summary>
        ''' <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim NumberSignDisplayField1 As GrapeCity.Win.Editors.Fields.NumberSignDisplayField = New GrapeCity.Win.Editors.Fields.NumberSignDisplayField()
            Dim NumberIntegerPartDisplayField1 As GrapeCity.Win.Editors.Fields.NumberIntegerPartDisplayField = New GrapeCity.Win.Editors.Fields.NumberIntegerPartDisplayField()
            Dim NumberDecimalSeparatorDisplayField1 As GrapeCity.Win.Editors.Fields.NumberDecimalSeparatorDisplayField = New GrapeCity.Win.Editors.Fields.NumberDecimalSeparatorDisplayField()
            Dim NumberDecimalPartDisplayField1 As GrapeCity.Win.Editors.Fields.NumberDecimalPartDisplayField = New GrapeCity.Win.Editors.Fields.NumberDecimalPartDisplayField()
            Me.button1 = New System.Windows.Forms.Button()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.gcSoftKeyboard1 = New GrapeCity.Win.Editors.GcSoftKeyboard()
            Me.gcShortcut1 = New GrapeCity.Win.Editors.GcShortcut(Me.components)
            Me.gcNumber1 = New GrapeCity.Win.Editors.GcNumber(Me.components)
            Me.sideButton1 = New GrapeCity.Win.Editors.SideButton()
            Me.sideButton2 = New GrapeCity.Win.Editors.SideButton()
            Me.label4 = New System.Windows.Forms.Label()
            Me.checkBox1 = New System.Windows.Forms.CheckBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.gcColorPicker2 = New GrapeCity.Win.Editors.GcColorPicker(Me.components)
            Me.dropDownButton1 = New GrapeCity.Win.Editors.DropDownButton()
            Me.gcColorPicker1 = New GrapeCity.Win.Editors.GcColorPicker(Me.components)
            Me.dropDownButton11 = New GrapeCity.Win.Editors.DropDownButton()
            Me.label2 = New System.Windows.Forms.Label()
            CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainer1.Panel1.SuspendLayout()
            Me.splitContainer1.Panel2.SuspendLayout()
            Me.splitContainer1.SuspendLayout()
            CType(Me.gcNumber1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcColorPicker2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcColorPicker1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'splitContainer1
            '
            '
            'splitContainer1.Panel1
            '
            Me.splitContainer1.Panel1.Controls.Add(Me.button1)
            Me.splitContainer1.Panel1.Controls.Add(Me.textBox1)
            '
            'splitContainer1.Panel2
            '
            Me.splitContainer1.Panel2.Controls.Add(Me.label4)
            Me.splitContainer1.Panel2.Controls.Add(Me.gcNumber1)
            Me.splitContainer1.Panel2.Controls.Add(Me.checkBox1)
            Me.splitContainer1.Panel2.Controls.Add(Me.label3)
            Me.splitContainer1.Panel2.Controls.Add(Me.gcColorPicker2)
            Me.splitContainer1.Panel2.Controls.Add(Me.gcColorPicker1)
            Me.splitContainer1.Panel2.Controls.Add(Me.label2)
            '
            'button1
            '
            Me.button1.AutoSize = True
            Me.button1.Location = New System.Drawing.Point(14, 50)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(114, 28)
            Me.button1.TabIndex = 3
            Me.button1.Text = "キーボードを表示"
            Me.button1.UseVisualStyleBackColor = True
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(14, 19)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(200, 25)
            Me.textBox1.TabIndex = 2
            '
            'gcNumber1
            '
            Me.gcNumber1.AutoSize = True
            NumberIntegerPartDisplayField1.GroupSizes = New Integer() {0}
            NumberDecimalPartDisplayField1.MaxDigits = 2
            NumberDecimalPartDisplayField1.MinDigits = 2
            Me.gcNumber1.DisplayFields.AddRange(New GrapeCity.Win.Editors.Fields.NumberDisplayField() {NumberSignDisplayField1, NumberIntegerPartDisplayField1, NumberDecimalSeparatorDisplayField1, NumberDecimalPartDisplayField1})
            Me.gcNumber1.Fields.DecimalPart.MaxDigits = 2
            Me.gcNumber1.Fields.DecimalPart.MinDigits = 2
            Me.gcNumber1.Fields.IntegerPart.GroupSizes = New Integer() {0}
            Me.gcNumber1.Fields.IntegerPart.MaxDigits = 1
            Me.gcNumber1.Fields.IntegerPart.MinDigits = 1
            Me.gcNumber1.Location = New System.Drawing.Point(166, 105)
            Me.gcNumber1.MaxValue = New Decimal(New Integer() {10, 0, 0, 65536})
            Me.gcNumber1.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.gcNumber1.Name = "gcNumber1"
            Me.gcShortcut1.SetShortcuts(Me.gcNumber1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.Subtract, System.Windows.Forms.Keys.OemMinus, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {CType(Me.gcNumber1, Object), CType(Me.gcNumber1, Object), CType(Me.gcNumber1, Object), CType(Me.gcNumber1, Object)}, New String() {"SetZero", "SwitchSign", "SwitchSign", "ApplyRecommendedValue"}))
            Me.gcNumber1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.sideButton1, Me.sideButton2})
            Me.gcNumber1.Size = New System.Drawing.Size(100, 24)
            Me.gcNumber1.Spin.IncrementValue = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.gcNumber1.Spin.SpinMode = GrapeCity.Win.Editors.NumberSpinMode.Value
            Me.gcNumber1.Spin.Wrap = False
            Me.gcNumber1.TabIndex = 27
            Me.gcNumber1.Value = New Decimal(New Integer() {100, 0, 0, 131072})
            Me.gcNumber1.ValueSign = GrapeCity.Win.Editors.ValueSignControl.Positive
            '
            'sideButton1
            '
            Me.sideButton1.Behavior = GrapeCity.Win.Editors.SideButtonBehavior.SpinUp
            Me.sideButton1.Interval = 60
            Me.sideButton1.Name = "sideButton1"
            Me.sideButton1.Text = "+"
            '
            'sideButton2
            '
            Me.sideButton2.Behavior = GrapeCity.Win.Editors.SideButtonBehavior.SpinDown
            Me.sideButton2.Interval = 60
            Me.sideButton2.Name = "sideButton2"
            Me.sideButton2.Text = "-"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(5, 108)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(128, 18)
            Me.label4.TabIndex = 28
            Me.label4.Text = "キーボードの透過率："
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Location = New System.Drawing.Point(8, 76)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(159, 22)
            Me.checkBox1.TabIndex = 26
            Me.checkBox1.Text = "キーに境界線を表示する"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(5, 43)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(92, 18)
            Me.label3.TabIndex = 25
            Me.label3.Text = "切替キーの色："
            '
            'gcColorPicker2
            '
            Me.gcColorPicker2.AutoSize = True
            Me.gcColorPicker2.DropDown.AutoHideTouchKeyboard = GrapeCity.Win.Editors.AutoHideTouchKeyboard.None
            Me.gcColorPicker2.DropDown.AutoWidth = True
            Me.gcColorPicker2.Location = New System.Drawing.Point(131, 42)
            Me.gcColorPicker2.Name = "gcColorPicker2"
            Me.gcColorPicker2.ShowListBoxImage = True
            Me.gcColorPicker2.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.dropDownButton1})
            Me.gcColorPicker2.Size = New System.Drawing.Size(135, 26)
            Me.gcColorPicker2.TabIndex = 24
            Me.gcColorPicker2.UnSelectedImageIndex = 0
            '
            'dropDownButton1
            '
            Me.dropDownButton1.Name = "dropDownButton1"
            '
            'gcColorPicker1
            '
            Me.gcColorPicker1.AutoSize = True
            Me.gcColorPicker1.DropDown.AutoHideTouchKeyboard = GrapeCity.Win.Editors.AutoHideTouchKeyboard.None
            Me.gcColorPicker1.DropDown.AutoWidth = True
            Me.gcColorPicker1.Location = New System.Drawing.Point(131, 8)
            Me.gcColorPicker1.Name = "gcColorPicker1"
            Me.gcColorPicker1.ShowListBoxImage = True
            Me.gcColorPicker1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.dropDownButton11})
            Me.gcColorPicker1.Size = New System.Drawing.Size(135, 26)
            Me.gcColorPicker1.TabIndex = 23
            Me.gcColorPicker1.UnSelectedImageIndex = 0
            '
            'dropDownButton11
            '
            Me.dropDownButton11.Name = "dropDownButton11"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(5, 11)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(56, 18)
            Me.label2.TabIndex = 22
            Me.label2.Text = "基底色："
            '
            'Appearance
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
            Me.Description = "ソフトキーボードコンポーネントでは、基底となる色を指定することで、キー全体の文字色、背景色が調整されます。全角・半角や、キーレイアウトを切り替える、切替キーには個" & _
        "別の色を設定可能です。また、キーボード全体の透過表示もできます。"
            Me.Name = "Appearance"
            Me.Title = "スタイルの変更"
            Me.splitContainer1.Panel1.ResumeLayout(False)
            Me.splitContainer1.Panel1.PerformLayout()
            Me.splitContainer1.Panel2.ResumeLayout(False)
            Me.splitContainer1.Panel2.PerformLayout()
            CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainer1.ResumeLayout(False)
            CType(Me.gcNumber1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcColorPicker2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcColorPicker1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private WithEvents button1 As System.Windows.Forms.Button
        Private WithEvents textBox1 As System.Windows.Forms.TextBox
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents gcNumber1 As GrapeCity.Win.Editors.GcNumber
        Private WithEvents gcShortcut1 As GrapeCity.Win.Editors.GcShortcut
        Private WithEvents sideButton1 As GrapeCity.Win.Editors.SideButton
        Private WithEvents sideButton2 As GrapeCity.Win.Editors.SideButton
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents gcColorPicker2 As GrapeCity.Win.Editors.GcColorPicker
        Private WithEvents dropDownButton1 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents gcColorPicker1 As GrapeCity.Win.Editors.GcColorPicker
        Private WithEvents dropDownButton11 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents gcSoftKeyboard1 As GrapeCity.Win.Editors.GcSoftKeyboard
    End Class

End Namespace
