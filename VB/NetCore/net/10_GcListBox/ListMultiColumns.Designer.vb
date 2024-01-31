Namespace _10_GcListBox
	Partial Class ListMultiColumns
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
            Dim ListHeader1 As GrapeCity.Win.Editors.ListHeader = New GrapeCity.Win.Editors.ListHeader()
            Dim ItemTemplate1 As GrapeCity.Win.Editors.ItemTemplate = New GrapeCity.Win.Editors.ItemTemplate()
            Dim ItemTemplate2 As GrapeCity.Win.Editors.ItemTemplate = New GrapeCity.Win.Editors.ItemTemplate()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListMultiColumns))
            Dim ListItem5 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem()
            Dim SubItem5 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem()
            Dim SubItem6 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem()
            Dim ListItem6 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem()
            Dim SubItem7 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem()
            Dim SubItem8 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem()
            Dim ListItem7 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem()
            Dim SubItem9 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem()
            Dim SubItem10 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem()
            Dim ListItem8 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem()
            Dim SubItem11 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem()
            Dim SubItem12 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem()
            Dim ListItem1 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem()
            Dim SubItem1 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem()
            Dim ListItem2 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem()
            Dim SubItem2 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem()
            Dim ListItem3 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem()
            Dim SubItem3 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem()
            Dim ListItem4 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem()
            Dim SubItem4 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem()
            Me.gcListBox1 = New GrapeCity.Win.Editors.GcListBox()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.label2 = New System.Windows.Forms.Label()
            Me.gcShortcut1 = New GrapeCity.Win.Editors.GcShortcut(Me.components)
            Me.gcColorPicker2 = New GrapeCity.Win.Editors.GcColorPicker(Me.components)
            Me.dropDownButton6 = New GrapeCity.Win.Editors.DropDownButton()
            Me.gcColorPicker1 = New GrapeCity.Win.Editors.GcColorPicker(Me.components)
            Me.dropDownButton5 = New GrapeCity.Win.Editors.DropDownButton()
            Me.dataSet1 = New System.Data.DataSet()
            Me.checkBox1 = New System.Windows.Forms.CheckBox()
            Me.checkBox2 = New System.Windows.Forms.CheckBox()
            Me.checkBox3 = New System.Windows.Forms.CheckBox()
            Me.label6 = New System.Windows.Forms.Label()
            Me.checkBox4 = New System.Windows.Forms.CheckBox()
            Me.gcComboBox1 = New GrapeCity.Win.Editors.GcComboBox(Me.components)
            Me.listColumn3 = New GrapeCity.Win.Editors.ListColumn()
            Me.listColumn4 = New GrapeCity.Win.Editors.ListColumn()
            Me.dropDownButton1 = New GrapeCity.Win.Editors.DropDownButton()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label5 = New System.Windows.Forms.Label()
            Me.gcComboBox2 = New GrapeCity.Win.Editors.GcComboBox(Me.components)
            Me.dropDownButton2 = New GrapeCity.Win.Editors.DropDownButton()
            Me.label4 = New System.Windows.Forms.Label()
            CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainer1.Panel1.SuspendLayout()
            Me.splitContainer1.Panel2.SuspendLayout()
            Me.splitContainer1.SuspendLayout()
            CType(Me.gcListBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcColorPicker2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcColorPicker1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'splitContainer1
            '
            '
            'splitContainer1.Panel1
            '
            Me.splitContainer1.Panel1.Controls.Add(Me.gcListBox1)
            Me.splitContainer1.Panel1.Controls.Add(Me.label2)
            '
            'splitContainer1.Panel2
            '
            Me.splitContainer1.Panel2.Controls.Add(Me.gcComboBox2)
            Me.splitContainer1.Panel2.Controls.Add(Me.checkBox1)
            Me.splitContainer1.Panel2.Controls.Add(Me.label4)
            Me.splitContainer1.Panel2.Controls.Add(Me.checkBox2)
            Me.splitContainer1.Panel2.Controls.Add(Me.gcColorPicker2)
            Me.splitContainer1.Panel2.Controls.Add(Me.checkBox3)
            Me.splitContainer1.Panel2.Controls.Add(Me.label6)
            Me.splitContainer1.Panel2.Controls.Add(Me.checkBox4)
            Me.splitContainer1.Panel2.Controls.Add(Me.gcComboBox1)
            Me.splitContainer1.Panel2.Controls.Add(Me.gcColorPicker1)
            Me.splitContainer1.Panel2.Controls.Add(Me.label3)
            Me.splitContainer1.Panel2.Controls.Add(Me.label5)
            Me.splitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(8, 0, 8, 4)
            '
            'gcListBox1
            '
            Me.gcListBox1.DefaultColumn.AutoWidth = True
            ListHeader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(115, Byte), Integer))
            ListHeader1.Text = "Column"
            Me.gcListBox1.DefaultColumn.Header = ListHeader1
            Me.gcListBox1.GridLines.HorizontalLines = New GrapeCity.Win.Editors.Line(GrapeCity.Win.Editors.LineStyle.[Single], System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer)))
            Me.gcListBox1.GridLines.VerticalLines = New GrapeCity.Win.Editors.Line(GrapeCity.Win.Editors.LineStyle.[Single], System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer)))
            Me.gcListBox1.ImageList = Me.imageList1
            ItemTemplate1.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
            ItemTemplate2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.gcListBox1.ItemTemplates.Add(ItemTemplate1)
            Me.gcListBox1.ItemTemplates.Add(ItemTemplate2)
            Me.gcListBox1.ListHeaderPane.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(115, Byte), Integer))
            Me.gcListBox1.ListHeaderPane.Height = 25
            Me.gcListBox1.Location = New System.Drawing.Point(8, 29)
            Me.gcListBox1.Name = "gcListBox1"
            Me.gcListBox1.SelectedItemStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.gcListBox1.Size = New System.Drawing.Size(260, 275)
            Me.gcListBox1.TabIndex = 1
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "fax.png")
            Me.imageList1.Images.SetKeyName(1, "home.png")
            Me.imageList1.Images.SetKeyName(2, "pen.png")
            Me.imageList1.Images.SetKeyName(3, "phone.png")
            Me.imageList1.Images.SetKeyName(4, "user.png")
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(5, 8)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(128, 18)
            Me.label2.TabIndex = 0
            Me.label2.Text = "リストコントロール："
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'gcColorPicker2
            '
            Me.gcColorPicker2.AutoSize = True
            Me.gcColorPicker2.Location = New System.Drawing.Point(136, 178)
            Me.gcColorPicker2.Name = "gcColorPicker2"
            Me.gcShortcut1.SetShortcuts(Me.gcColorPicker2, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {CType(Me.gcColorPicker2, Object), CType(Me.gcColorPicker2, Object)}, New String() {"ShortcutClear", "ApplyRecommendedValue"}))
            Me.gcColorPicker2.ShowListBoxImage = True
            Me.gcColorPicker2.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.dropDownButton6})
            Me.gcColorPicker2.Size = New System.Drawing.Size(127, 26)
            Me.gcColorPicker2.TabIndex = 9
            Me.gcColorPicker2.UnSelectedImageIndex = 0
            '
            'dropDownButton6
            '
            Me.dropDownButton6.Name = "dropDownButton6"
            '
            'gcColorPicker1
            '
            Me.gcColorPicker1.AutoSize = True
            Me.gcColorPicker1.Location = New System.Drawing.Point(136, 148)
            Me.gcColorPicker1.Name = "gcColorPicker1"
            Me.gcShortcut1.SetShortcuts(Me.gcColorPicker1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {CType(Me.gcColorPicker1, Object), CType(Me.gcColorPicker1, Object)}, New String() {"ShortcutClear", "ApplyRecommendedValue"}))
            Me.gcColorPicker1.ShowListBoxImage = True
            Me.gcColorPicker1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.dropDownButton5})
            Me.gcColorPicker1.Size = New System.Drawing.Size(127, 26)
            Me.gcColorPicker1.TabIndex = 7
            Me.gcColorPicker1.UnSelectedImageIndex = 0
            '
            'dropDownButton5
            '
            Me.dropDownButton5.Name = "dropDownButton5"
            '
            'dataSet1
            '
            Me.dataSet1.DataSetName = "NewDataSet"
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Location = New System.Drawing.Point(8, 8)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(123, 22)
            Me.checkBox1.TabIndex = 0
            Me.checkBox1.Text = "ヘッダを表示する"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'checkBox2
            '
            Me.checkBox2.AutoSize = True
            Me.checkBox2.Location = New System.Drawing.Point(8, 35)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(183, 22)
            Me.checkBox2.TabIndex = 1
            Me.checkBox2.Text = "ヘッダのリサイズを許可する"
            Me.checkBox2.UseVisualStyleBackColor = True
            '
            'checkBox3
            '
            Me.checkBox3.AutoSize = True
            Me.checkBox3.Location = New System.Drawing.Point(8, 63)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(159, 22)
            Me.checkBox3.TabIndex = 2
            Me.checkBox3.Text = "ヘッダに画像を表示する"
            Me.checkBox3.UseVisualStyleBackColor = True
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(5, 181)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(104, 18)
            Me.label6.TabIndex = 8
            Me.label6.Text = "選択行の背景色："
            '
            'checkBox4
            '
            Me.checkBox4.AutoSize = True
            Me.checkBox4.Location = New System.Drawing.Point(8, 90)
            Me.checkBox4.Name = "checkBox4"
            Me.checkBox4.Size = New System.Drawing.Size(183, 22)
            Me.checkBox4.TabIndex = 3
            Me.checkBox4.Text = "チェックボックスを表示する"
            Me.checkBox4.UseVisualStyleBackColor = True
            '
            'gcComboBox1
            '
            Me.gcComboBox1.AutoSize = True
            Me.gcComboBox1.DropDown.AutoWidth = True
            Me.gcComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.gcComboBox1.Ellipsis = GrapeCity.Win.Editors.EllipsisMode.EllipsisEnd
            SubItem5.Value = "None"
            SubItem6.Value = "選択できる項目はありません。"
            ListItem5.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem5, SubItem6})
            SubItem7.Value = "One"
            SubItem8.Value = "1 つの項目だけ選択できます。"
            ListItem6.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem7, SubItem8})
            SubItem9.Value = "MultiSimple"
            SubItem10.Value = "複数の項目を選択できます。"
            ListItem7.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem9, SubItem10})
            SubItem11.Value = "MultiExtended"
            SubItem12.Value = "複数の項目を選択できます。また、Shift キー、Ctrl キー、および方向キーを使用して項目を選択できます。 "
            ListItem8.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem11, SubItem12})
            Me.gcComboBox1.Items.AddRange(New GrapeCity.Win.Editors.ListItem() {ListItem5, ListItem6, ListItem7, ListItem8})
            Me.gcComboBox1.ListColumns.AddRange(New GrapeCity.Win.Editors.ListColumn() {Me.listColumn3, Me.listColumn4})
            Me.gcComboBox1.ListHeaderPane.Height = 25
            Me.gcComboBox1.Location = New System.Drawing.Point(136, 117)
            Me.gcComboBox1.Name = "gcComboBox1"
            Me.gcComboBox1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.dropDownButton1})
            Me.gcComboBox1.Size = New System.Drawing.Size(127, 26)
            Me.gcComboBox1.TabIndex = 5
            Me.gcComboBox1.UseCompatibleDrawing = True
            '
            'listColumn3
            '
            Me.listColumn3.AutoWidth = True
            Me.listColumn3.Header.Text = "値"
            Me.listColumn3.Width = 87
            '
            'listColumn4
            '
            Me.listColumn4.AutoWidth = True
            Me.listColumn4.Header.Text = "説明"
            Me.listColumn4.Width = 593
            '
            'dropDownButton1
            '
            Me.dropDownButton1.Name = "dropDownButton1"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(5, 120)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(104, 18)
            Me.label3.TabIndex = 4
            Me.label3.Text = "項目の選択状態："
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(5, 150)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(104, 18)
            Me.label5.TabIndex = 6
            Me.label5.Text = "選択行の前景色："
            '
            'gcComboBox2
            '
            Me.gcComboBox2.AutoSize = True
            Me.gcComboBox2.DropDown.AutoWidth = True
            Me.gcComboBox2.DropDown.Width = 227
            Me.gcComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.gcComboBox2.Ellipsis = GrapeCity.Win.Editors.EllipsisMode.EllipsisEnd
            SubItem1.Value = "総件数：[instance.Items.Count]"
            SubItem1.WordWrap = True
            ListItem1.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem1})
            SubItem2.Value = "選択中インデックス: [instance.SelectedIndex]"
            SubItem2.WordWrap = False
            ListItem2.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem2})
            SubItem3.Value = "[0] - [1]"
            ListItem3.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem3})
            SubItem4.Value = "\[0\]: [0]"
            ListItem4.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem4})
            Me.gcComboBox2.Items.AddRange(New GrapeCity.Win.Editors.ListItem() {ListItem1, ListItem2, ListItem3, ListItem4})
            Me.gcComboBox2.ListHeaderPane.Height = 25
            Me.gcComboBox2.Location = New System.Drawing.Point(136, 210)
            Me.gcComboBox2.Name = "gcComboBox2"
            Me.gcComboBox2.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.dropDownButton2})
            Me.gcComboBox2.Size = New System.Drawing.Size(127, 26)
            Me.gcComboBox2.TabIndex = 13
            Me.gcComboBox2.UseCompatibleDrawing = True
            '
            'dropDownButton2
            '
            Me.dropDownButton2.Name = "dropDownButton2"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(5, 205)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(128, 36)
            Me.label4.TabIndex = 12
            Me.label4.Text = "リスト説明部の" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "表示のカスタマイズ："
            '
            'ListMultiColumns
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
            Me.Description = "リストコントロールは、マルチカラムリストボックスから構成されています。ヘッダ、チェックボックスや画像、テキストの表示機能を提供しています。"
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "ListMultiColumns"
            Me.Padding = New System.Windows.Forms.Padding(11, 16, 11, 3)
            Me.Title = "マルチカラムによるリスト表示"
            Me.splitContainer1.Panel1.ResumeLayout(False)
            Me.splitContainer1.Panel1.PerformLayout()
            Me.splitContainer1.Panel2.ResumeLayout(False)
            Me.splitContainer1.Panel2.PerformLayout()
            CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainer1.ResumeLayout(False)
            CType(Me.gcListBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcColorPicker2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcColorPicker1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private WithEvents gcListBox1 As GrapeCity.Win.Editors.GcListBox
        Private WithEvents imageList1 As System.Windows.Forms.ImageList
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents gcShortcut1 As GrapeCity.Win.Editors.GcShortcut
        Private WithEvents dataSet1 As System.Data.DataSet
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
        Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
        Private WithEvents gcColorPicker2 As GrapeCity.Win.Editors.GcColorPicker
        Private WithEvents dropDownButton6 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
        Private WithEvents label6 As System.Windows.Forms.Label
        Private WithEvents checkBox4 As System.Windows.Forms.CheckBox
        Private WithEvents gcComboBox1 As GrapeCity.Win.Editors.GcComboBox
        Private WithEvents listColumn3 As GrapeCity.Win.Editors.ListColumn
        Private WithEvents listColumn4 As GrapeCity.Win.Editors.ListColumn
        Private WithEvents dropDownButton1 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents gcColorPicker1 As GrapeCity.Win.Editors.GcColorPicker
        Private WithEvents dropDownButton5 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents label3 As System.Windows.Forms.Label
		Private WithEvents label5 As System.Windows.Forms.Label
		Private WithEvents gcComboBox2 As GrapeCity.Win.Editors.GcComboBox
		Private WithEvents dropDownButton2 As GrapeCity.Win.Editors.DropDownButton
		Private WithEvents label4 As Windows.Forms.Label
	End Class
End Namespace
