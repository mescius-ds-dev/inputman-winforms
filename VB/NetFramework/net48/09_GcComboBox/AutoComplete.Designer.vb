Namespace _09_GcComboBox
	Partial Class AutoComplete
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
            Me.components = New System.ComponentModel.Container
            Dim GradientEffect1 As GrapeCity.Win.Editors.GradientEffect = New GrapeCity.Win.Editors.GradientEffect
            Dim ListItem1 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem
            Dim SubItem1 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Dim SubItem2 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Dim ListItem2 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem
            Dim SubItem3 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Dim SubItem4 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Dim ListItem3 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem
            Dim SubItem5 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Dim SubItem6 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Dim ListItem4 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem
            Dim SubItem7 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Dim SubItem8 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Dim ListItem5 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem
            Dim SubItem9 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Dim SubItem10 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Dim ListItem6 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem
            Dim SubItem11 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Dim SubItem12 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Me.gcComboBox1 = New GrapeCity.Win.Editors.GcComboBox(Me.components)
            Me.dropDownButton1 = New GrapeCity.Win.Editors.DropDownButton
            Me.label2 = New System.Windows.Forms.Label
            Me.dataSet1 = New System.Data.DataSet
            Me.gcShortcut1 = New GrapeCity.Win.Editors.GcShortcut(Me.components)
            Me.gcTextBox2 = New GrapeCity.Win.Editors.GcTextBox(Me.components)
            Me.sideButton2 = New GrapeCity.Win.Editors.SideButton
            Me.gcColorPicker2 = New GrapeCity.Win.Editors.GcColorPicker(Me.components)
            Me.dropDownButton6 = New GrapeCity.Win.Editors.DropDownButton
            Me.gcColorPicker1 = New GrapeCity.Win.Editors.GcColorPicker(Me.components)
            Me.dropDownButton5 = New GrapeCity.Win.Editors.DropDownButton
            Me.gcTextBox1 = New GrapeCity.Win.Editors.GcTextBox(Me.components)
            Me.sideButton1 = New GrapeCity.Win.Editors.SideButton
            Me.fontDialog1 = New System.Windows.Forms.FontDialog
            Me.label7 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.label6 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.gcComboBox2 = New GrapeCity.Win.Editors.GcComboBox(Me.components)
            Me.listColumn39 = New GrapeCity.Win.Editors.ListColumn
            Me.listColumn40 = New GrapeCity.Win.Editors.ListColumn
            Me.dropDownButton21 = New GrapeCity.Win.Editors.DropDownButton
            Me.splitContainer1.Panel1.SuspendLayout()
            Me.splitContainer1.Panel2.SuspendLayout()
            Me.splitContainer1.SuspendLayout()
            CType(Me.gcComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcColorPicker2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcColorPicker1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            CType(Me.gcComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'splitContainer1
            '
            '
            'splitContainer1.Panel1
            '
            Me.splitContainer1.Panel1.Controls.Add(Me.gcComboBox1)
            Me.splitContainer1.Panel1.Controls.Add(Me.label2)
            '
            'splitContainer1.Panel2
            '
            Me.splitContainer1.Panel2.Controls.Add(Me.label7)
            Me.splitContainer1.Panel2.Controls.Add(Me.label3)
            Me.splitContainer1.Panel2.Controls.Add(Me.gcTextBox2)
            Me.splitContainer1.Panel2.Controls.Add(Me.groupBox1)
            Me.splitContainer1.Panel2.Controls.Add(Me.gcComboBox2)
            Me.splitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(8, 0, 8, 4)
            '
            'gcComboBox1
            '
            Me.gcComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.gcComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.gcComboBox1.AutoSize = True
            Me.gcComboBox1.DropDown.AutoWidth = True
            Me.gcComboBox1.ImeMode = System.Windows.Forms.ImeMode.[On]
            GradientEffect1.Direction = GrapeCity.Win.Editors.GradientDirection.Center
            GradientEffect1.EndColor = System.Drawing.Color.Yellow
            Me.gcComboBox1.ListHeaderPane.GradientEffect = GradientEffect1
            Me.gcComboBox1.ListHeaderPane.Height = 25
            Me.gcComboBox1.Location = New System.Drawing.Point(8, 29)
            Me.gcComboBox1.Name = "gcComboBox1"
            Me.gcComboBox1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.dropDownButton1})
            Me.gcComboBox1.Size = New System.Drawing.Size(260, 26)
            Me.gcComboBox1.TabIndex = 1
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
            Me.label2.Size = New System.Drawing.Size(56, 18)
            Me.label2.TabIndex = 0
            Me.label2.Text = "コンボ："
            '
            'dataSet1
            '
            Me.dataSet1.DataSetName = "NewDataSet"
            '
            'gcTextBox2
            '
            Me.gcTextBox2.AutoSize = True
            Me.gcTextBox2.Location = New System.Drawing.Point(149, 185)
            Me.gcTextBox2.Name = "gcTextBox2"
            Me.gcTextBox2.ReadOnly = True
            Me.gcShortcut1.SetShortcuts(Me.gcTextBox2, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2}, New Object() {CType(Me.gcTextBox2, Object)}, New String() {"ShortcutClear"}))
            Me.gcTextBox2.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.sideButton2})
            Me.gcTextBox2.Size = New System.Drawing.Size(119, 24)
            Me.gcTextBox2.TabIndex = 4
            '
            'sideButton2
            '
            Me.sideButton2.ButtonWidth = 60
            Me.sideButton2.Name = "sideButton2"
            Me.sideButton2.Text = "設定"
            '
            'gcColorPicker2
            '
            Me.gcColorPicker2.AutoSize = True
            Me.gcColorPicker2.Location = New System.Drawing.Point(142, 111)
            Me.gcColorPicker2.Name = "gcColorPicker2"
            Me.gcShortcut1.SetShortcuts(Me.gcColorPicker2, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {CType(Me.gcColorPicker2, Object), CType(Me.gcColorPicker2, Object)}, New String() {"ShortcutClear", "ApplyRecommendedValue"}))
            Me.gcColorPicker2.ShowListBoxImage = True
            Me.gcColorPicker2.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.dropDownButton6})
            Me.gcColorPicker2.Size = New System.Drawing.Size(119, 26)
            Me.gcColorPicker2.TabIndex = 6
            Me.gcColorPicker2.UnSelectedImageIndex = 0
            '
            'dropDownButton6
            '
            Me.dropDownButton6.Name = "dropDownButton6"
            '
            'gcColorPicker1
            '
            Me.gcColorPicker1.AutoSize = True
            Me.gcColorPicker1.Location = New System.Drawing.Point(142, 81)
            Me.gcColorPicker1.Name = "gcColorPicker1"
            Me.gcShortcut1.SetShortcuts(Me.gcColorPicker1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {CType(Me.gcColorPicker1, Object), CType(Me.gcColorPicker1, Object)}, New String() {"ShortcutClear", "ApplyRecommendedValue"}))
            Me.gcColorPicker1.ShowListBoxImage = True
            Me.gcColorPicker1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.dropDownButton5})
            Me.gcColorPicker1.Size = New System.Drawing.Size(119, 26)
            Me.gcColorPicker1.TabIndex = 4
            Me.gcColorPicker1.UnSelectedImageIndex = 0
            '
            'dropDownButton5
            '
            Me.dropDownButton5.Name = "dropDownButton5"
            '
            'gcTextBox1
            '
            Me.gcTextBox1.AutoSize = True
            Me.gcTextBox1.Location = New System.Drawing.Point(142, 52)
            Me.gcTextBox1.Name = "gcTextBox1"
            Me.gcTextBox1.ReadOnly = True
            Me.gcShortcut1.SetShortcuts(Me.gcTextBox1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2}, New Object() {CType(Me.gcTextBox1, Object)}, New String() {"ShortcutClear"}))
            Me.gcTextBox1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.sideButton1})
            Me.gcTextBox1.Size = New System.Drawing.Size(119, 24)
            Me.gcTextBox1.TabIndex = 2
            '
            'sideButton1
            '
            Me.sideButton1.ButtonWidth = 60
            Me.sideButton1.Name = "sideButton1"
            Me.sideButton1.Text = "設定"
            '
            'fontDialog1
            '
            Me.fontDialog1.Color = System.Drawing.SystemColors.ControlText
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(5, 8)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(80, 18)
            Me.label7.TabIndex = 0
            Me.label7.Text = "検索モード："
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(5, 188)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(140, 18)
            Me.label3.TabIndex = 3
            Me.label3.Text = "候補リストのフォント："
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.gcColorPicker2)
            Me.groupBox1.Controls.Add(Me.label6)
            Me.groupBox1.Controls.Add(Me.gcColorPicker1)
            Me.groupBox1.Controls.Add(Me.label5)
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.gcTextBox1)
            Me.groupBox1.Controls.Add(Me.checkBox1)
            Me.groupBox1.Location = New System.Drawing.Point(7, 36)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(264, 143)
            Me.groupBox1.TabIndex = 2
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "検索文字列の設定"
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(2, 113)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(128, 18)
            Me.label6.TabIndex = 5
            Me.label6.Text = "検索文字列の背景色："
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(2, 83)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(128, 18)
            Me.label5.TabIndex = 3
            Me.label5.Text = "検索文字列の前景色："
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(2, 54)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(140, 18)
            Me.label4.TabIndex = 1
            Me.label4.Text = "検索文字列のフォント："
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Location = New System.Drawing.Point(6, 24)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(207, 22)
            Me.checkBox1.TabIndex = 0
            Me.checkBox1.Text = "検索文字列をハイライト表示する"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'gcComboBox2
            '
            Me.gcComboBox2.AutoSize = True
            Me.gcComboBox2.DropDown.AutoWidth = True
            Me.gcComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.gcComboBox2.Ellipsis = GrapeCity.Win.Editors.EllipsisMode.EllipsisEnd
            SubItem1.Value = "MatchStartWith"
            SubItem2.Value = "候補リスト内を大文字／小文字の区別なし、かつ文字種の区別ありの前方一致で検索します。"
            ListItem1.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem1, SubItem2})
            SubItem3.Value = "MatchAll"
            SubItem4.Value = "候補リスト内を大文字／小文字の区別なし、かつ文字種の区別ありの部分一致で検索します。"
            ListItem2.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem3, SubItem4})
            SubItem5.Value = "AmbiguousMatchStartWith"
            SubItem6.Value = "候補リスト内を大文字／小文字の区別なし、かつ文字種の区別なしの前方一致で検索します。"
            ListItem3.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem5, SubItem6})
            SubItem7.Value = "AmbiguousMatchAll"
            SubItem8.Value = "候補リスト内を大文字／小文字の区別なし、かつ文字種の区別なしの部分一致で検索します。"
            ListItem4.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem7, SubItem8})
            SubItem9.Value = "ExactMatchStartWith"
            SubItem10.Value = "候補リスト内を大文字／小文字の区別あり、かつ文字種の区別ありの前方一致で検索します。"
            ListItem5.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem9, SubItem10})
            SubItem11.Value = "ExactMatchAll"
            SubItem12.Value = "候補リスト内を大文字／小文字の区別あり、かつ文字種の区別ありの部分一致で検索します。"
            ListItem6.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem11, SubItem12})
            Me.gcComboBox2.Items.AddRange(New GrapeCity.Win.Editors.ListItem() {ListItem1, ListItem2, ListItem3, ListItem4, ListItem5, ListItem6})
            Me.gcComboBox2.ListColumns.AddRange(New GrapeCity.Win.Editors.ListColumn() {Me.listColumn39, Me.listColumn40})
            Me.gcComboBox2.ListHeaderPane.Height = 25
            Me.gcComboBox2.Location = New System.Drawing.Point(89, 5)
            Me.gcComboBox2.Name = "gcComboBox2"
            Me.gcComboBox2.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.dropDownButton21})
            Me.gcComboBox2.Size = New System.Drawing.Size(179, 26)
            Me.gcComboBox2.TabIndex = 1
            Me.gcComboBox2.UseCompatibleDrawing = True
            '
            'listColumn39
            '
            Me.listColumn39.AutoWidth = True
            Me.listColumn39.Header.Text = "値"
            '
            'listColumn40
            '
            Me.listColumn40.AutoWidth = True
            Me.listColumn40.Header.Text = "説明"
            '
            'dropDownButton21
            '
            Me.dropDownButton21.Name = "dropDownButton21"
            '
            'AutoComplete
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
            Me.Description = "オートコンプリートは入力された文字が指定したデータソース内にあるかどうかを検索し、マッチする文字列を入力候補として一覧表示する機能です。"
            Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.Name = "AutoComplete"
            Me.Padding = New System.Windows.Forms.Padding(11, 16, 11, 3)
            Me.Title = "オートコンプリートによる補完機能"
            Me.splitContainer1.Panel1.ResumeLayout(False)
            Me.splitContainer1.Panel1.PerformLayout()
            Me.splitContainer1.Panel2.ResumeLayout(False)
            Me.splitContainer1.Panel2.PerformLayout()
            Me.splitContainer1.ResumeLayout(False)
            CType(Me.gcComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcColorPicker2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcColorPicker1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.gcComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

        Private WithEvents gcComboBox1 As GrapeCity.Win.Editors.GcComboBox
        Private WithEvents dropDownButton1 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents dataSet1 As System.Data.DataSet
        Private WithEvents gcShortcut1 As GrapeCity.Win.Editors.GcShortcut
        Private WithEvents fontDialog1 As System.Windows.Forms.FontDialog
        Private WithEvents label7 As System.Windows.Forms.Label
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents gcTextBox2 As GrapeCity.Win.Editors.GcTextBox
        Private WithEvents sideButton2 As GrapeCity.Win.Editors.SideButton
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents gcColorPicker2 As GrapeCity.Win.Editors.GcColorPicker
        Private WithEvents dropDownButton6 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents label6 As System.Windows.Forms.Label
        Private WithEvents gcColorPicker1 As GrapeCity.Win.Editors.GcColorPicker
        Private WithEvents dropDownButton5 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents gcTextBox1 As GrapeCity.Win.Editors.GcTextBox
        Private WithEvents sideButton1 As GrapeCity.Win.Editors.SideButton
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
        Private WithEvents gcComboBox2 As GrapeCity.Win.Editors.GcComboBox
        Private WithEvents listColumn39 As GrapeCity.Win.Editors.ListColumn
        Private WithEvents listColumn40 As GrapeCity.Win.Editors.ListColumn
        Private WithEvents dropDownButton21 As GrapeCity.Win.Editors.DropDownButton
	End Class
End Namespace
