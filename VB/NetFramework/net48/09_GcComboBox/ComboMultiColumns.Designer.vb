Namespace _09_GcComboBox
	Partial Class ComboMultiColumns
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
			Dim listHeader1 As New GrapeCity.Win.Editors.ListHeader()
			Dim itemTemplate1 As New GrapeCity.Win.Editors.ItemTemplate()
			Dim itemTemplate2 As New GrapeCity.Win.Editors.ItemTemplate()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ComboMultiColumns))
			Dim listItem1 As New GrapeCity.Win.Editors.ListItem()
			Dim subItem1 As New GrapeCity.Win.Editors.SubItem()
			Dim subItem2 As New GrapeCity.Win.Editors.SubItem()
			Dim listItem2 As New GrapeCity.Win.Editors.ListItem()
			Dim subItem3 As New GrapeCity.Win.Editors.SubItem()
			Dim subItem4 As New GrapeCity.Win.Editors.SubItem()
			Dim listItem3 As New GrapeCity.Win.Editors.ListItem()
			Dim subItem5 As New GrapeCity.Win.Editors.SubItem()
			Dim subItem6 As New GrapeCity.Win.Editors.SubItem()
			Dim listItem4 As New GrapeCity.Win.Editors.ListItem()
			Dim subItem7 As New GrapeCity.Win.Editors.SubItem()
			Dim subItem8 As New GrapeCity.Win.Editors.SubItem()
			Dim listItem5 As New GrapeCity.Win.Editors.ListItem()
			Dim subItem9 As New GrapeCity.Win.Editors.SubItem()
			Dim subItem10 As New GrapeCity.Win.Editors.SubItem()
			Dim listItem6 As New GrapeCity.Win.Editors.ListItem()
			Dim subItem11 As New GrapeCity.Win.Editors.SubItem()
			Dim subItem12 As New GrapeCity.Win.Editors.SubItem()
			Me.gcComboBox1 = New GrapeCity.Win.Editors.GcComboBox(Me.components)
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.dropDownButton1 = New GrapeCity.Win.Editors.DropDownButton()
			Me.label2 = New System.Windows.Forms.Label()
			Me.gcShortcut1 = New GrapeCity.Win.Editors.GcShortcut(Me.components)
			Me.gcColorPicker2 = New GrapeCity.Win.Editors.GcColorPicker(Me.components)
			Me.dropDownButton6 = New GrapeCity.Win.Editors.DropDownButton()
			Me.gcColorPicker1 = New GrapeCity.Win.Editors.GcColorPicker(Me.components)
			Me.dropDownButton5 = New GrapeCity.Win.Editors.DropDownButton()
			Me.dataSet1 = New System.Data.DataSet()
			Me.checkBox1 = New System.Windows.Forms.CheckBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label6 = New System.Windows.Forms.Label()
			Me.gcComboBox2 = New GrapeCity.Win.Editors.GcComboBox(Me.components)
			Me.listColumn1 = New GrapeCity.Win.Editors.ListColumn()
			Me.listColumn2 = New GrapeCity.Win.Editors.ListColumn()
			Me.dropDownButton2 = New GrapeCity.Win.Editors.DropDownButton()
			Me.checkBox2 = New System.Windows.Forms.CheckBox()
			Me.label5 = New System.Windows.Forms.Label()
			Me.checkBox3 = New System.Windows.Forms.CheckBox()
			Me.checkBox4 = New System.Windows.Forms.CheckBox()
			Me.splitContainer1.Panel1.SuspendLayout()
			Me.splitContainer1.Panel2.SuspendLayout()
			Me.splitContainer1.SuspendLayout()
			DirectCast(Me.gcComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gcColorPicker2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gcColorPicker1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gcComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' splitContainer1
			' 
			' 
			' splitContainer1.Panel1
			' 
			Me.splitContainer1.Panel1.Controls.Add(Me.gcComboBox1)
			Me.splitContainer1.Panel1.Controls.Add(Me.label2)
			' 
			' splitContainer1.Panel2
			' 
			Me.splitContainer1.Panel2.Controls.Add(Me.gcComboBox2)
			Me.splitContainer1.Panel2.Controls.Add(Me.checkBox1)
			Me.splitContainer1.Panel2.Controls.Add(Me.gcColorPicker2)
			Me.splitContainer1.Panel2.Controls.Add(Me.label4)
			Me.splitContainer1.Panel2.Controls.Add(Me.label6)
			Me.splitContainer1.Panel2.Controls.Add(Me.gcColorPicker1)
			Me.splitContainer1.Panel2.Controls.Add(Me.checkBox2)
			Me.splitContainer1.Panel2.Controls.Add(Me.label5)
			Me.splitContainer1.Panel2.Controls.Add(Me.checkBox4)
			Me.splitContainer1.Panel2.Controls.Add(Me.checkBox3)
			' 
			' gcComboBox1
			' 
			Me.gcComboBox1.AutoSize = True
			Me.gcComboBox1.ImageList = Me.imageList1
			Me.gcComboBox1.ImeMode = System.Windows.Forms.ImeMode.[On]
			Me.gcComboBox1.ListDefaultColumn.AutoWidth = True
			listHeader1.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(248)), CInt(CByte(204)), CInt(CByte(124)))
			listHeader1.Text = "Column"
			Me.gcComboBox1.ListDefaultColumn.Header = listHeader1
			Me.gcComboBox1.ListGridLines.HorizontalLines = New GrapeCity.Win.Editors.Line(GrapeCity.Win.Editors.LineStyle.[Single], System.Drawing.Color.FromArgb(CInt(CByte(240)), CInt(CByte(177)), CInt(CByte(94))))
			Me.gcComboBox1.ListGridLines.VerticalLines = New GrapeCity.Win.Editors.Line(GrapeCity.Win.Editors.LineStyle.[Single], System.Drawing.Color.FromArgb(CInt(CByte(240)), CInt(CByte(177)), CInt(CByte(94))))
			Me.gcComboBox1.ListHeaderPane.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(248)), CInt(CByte(204)), CInt(CByte(124)))
			Me.gcComboBox1.ListHeaderPane.Height = 30
			itemTemplate1.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(251)), CInt(CByte(236)), CInt(CByte(208)))
			itemTemplate2.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(253)), CInt(CByte(248)), CInt(CByte(236)))
			Me.gcComboBox1.ListItemTemplates.Add(itemTemplate1)
			Me.gcComboBox1.ListItemTemplates.Add(itemTemplate2)
			Me.gcComboBox1.ListSelectedItemStyle.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(231)), CInt(CByte(167)), CInt(CByte(103)))
			Me.gcComboBox1.Location = New System.Drawing.Point(10, 37)
			Me.gcComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.gcComboBox1.Name = "gcComboBox1"
			Me.gcShortcut1.SetShortcuts(Me.gcComboBox1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {DirectCast(Me.gcComboBox1, Object), DirectCast(Me.gcComboBox1, Object)}, New String() {"ShortcutClear", "ApplyRecommendedValue"}))
			Me.gcComboBox1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.dropDownButton1})
			Me.gcComboBox1.Size = New System.Drawing.Size(334, 31)
			Me.gcComboBox1.TabIndex = 1
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = DirectCast(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "fax.png")
			Me.imageList1.Images.SetKeyName(1, "home.png")
			Me.imageList1.Images.SetKeyName(2, "pen.png")
			Me.imageList1.Images.SetKeyName(3, "phone.png")
			Me.imageList1.Images.SetKeyName(4, "user.png")
			' 
			' dropDownButton1
			' 
			Me.dropDownButton1.Name = "dropDownButton1"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(6, 10)
			Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(70, 23)
			Me.label2.TabIndex = 0
			Me.label2.Text = "コンボ："
			' 
			' gcColorPicker2
			' 
			Me.gcColorPicker2.AutoSize = True
			Me.gcColorPicker2.Location = New System.Drawing.Point(201, 236)
			Me.gcColorPicker2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.gcColorPicker2.Name = "gcColorPicker2"
			Me.gcShortcut1.SetShortcuts(Me.gcColorPicker2, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {DirectCast(Me.gcColorPicker2, Object), DirectCast(Me.gcColorPicker2, Object)}, New String() {"ShortcutClear", "ApplyRecommendedValue"}))
			Me.gcColorPicker2.ShowListBoxImage = True
			Me.gcColorPicker2.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.dropDownButton6})
			Me.gcColorPicker2.Size = New System.Drawing.Size(149, 31)
			Me.gcColorPicker2.TabIndex = 9
			Me.gcColorPicker2.UnSelectedImageIndex = 0
			' 
			' dropDownButton6
			' 
			Me.dropDownButton6.Name = "dropDownButton6"
			' 
			' gcColorPicker1
			' 
			Me.gcColorPicker1.AutoSize = True
			Me.gcColorPicker1.Location = New System.Drawing.Point(201, 196)
			Me.gcColorPicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.gcColorPicker1.Name = "gcColorPicker1"
			Me.gcShortcut1.SetShortcuts(Me.gcColorPicker1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {DirectCast(Me.gcColorPicker1, Object), DirectCast(Me.gcColorPicker1, Object)}, New String() {"ShortcutClear", "ApplyRecommendedValue"}))
			Me.gcColorPicker1.ShowListBoxImage = True
			Me.gcColorPicker1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.dropDownButton5})
			Me.gcColorPicker1.Size = New System.Drawing.Size(149, 31)
			Me.gcColorPicker1.TabIndex = 7
			Me.gcColorPicker1.UnSelectedImageIndex = 0
			' 
			' dropDownButton5
			' 
			Me.dropDownButton5.Name = "dropDownButton5"
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			' 
			' checkBox1
			' 
			Me.checkBox1.AutoSize = True
			Me.checkBox1.Location = New System.Drawing.Point(10, 10)
			Me.checkBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(152, 27)
			Me.checkBox1.TabIndex = 0
			Me.checkBox1.Text = "ヘッダを表示する"
			Me.checkBox1.UseVisualStyleBackColor = True
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(6, 149)
			Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(191, 46)
			Me.label4.TabIndex = 4
			Me.label4.Text = "Textプロパティで使用する" & vbCr & vbLf & "項目のインデックス："
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(6, 238)
			Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(130, 23)
			Me.label6.TabIndex = 8
			Me.label6.Text = "選択行の背景色："
			' 
			' gcComboBox2
			' 
			Me.gcComboBox2.AutoSize = True
			Me.gcComboBox2.DropDown.AutoWidth = True
			Me.gcComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.gcComboBox2.Ellipsis = GrapeCity.Win.Editors.EllipsisMode.EllipsisEnd
			subItem1.Value = "0"
			subItem2.Value = "会社名"
			listItem1.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {subItem1, subItem2})
			subItem3.Value = "1"
			subItem4.Value = "郵便番号"
			listItem2.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {subItem3, subItem4})
			subItem5.Value = "2"
			subItem6.Value = "住所1"
			listItem3.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {subItem5, subItem6})
			subItem7.Value = "3"
			subItem8.Value = "住所2"
			listItem4.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {subItem7, subItem8})
			subItem9.Value = "4"
			subItem10.Value = "電話番号"
			listItem5.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {subItem9, subItem10})
			subItem11.Value = "5"
			subItem12.Value = "FAX"
			listItem6.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {subItem11, subItem12})
			Me.gcComboBox2.Items.AddRange(New GrapeCity.Win.Editors.ListItem() {listItem1, listItem2, listItem3, listItem4, listItem5, listItem6})
			Me.gcComboBox2.ListColumns.AddRange(New GrapeCity.Win.Editors.ListColumn() {Me.listColumn1, Me.listColumn2})
			Me.gcComboBox2.ListHeaderPane.Height = 30
			Me.gcComboBox2.Location = New System.Drawing.Point(201, 156)
			Me.gcComboBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.gcComboBox2.Name = "gcComboBox2"
			Me.gcComboBox2.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.dropDownButton2})
			Me.gcComboBox2.Size = New System.Drawing.Size(149, 31)
			Me.gcComboBox2.TabIndex = 5
			Me.gcComboBox2.TextFormat = "[0]：[1]"
			Me.gcComboBox2.UseCompatibleDrawing = True
			' 
			' listColumn1
			' 
			Me.listColumn1.AutoWidth = False
			Me.listColumn1.Header.Text = "値"
			Me.listColumn1.Width = 84
			' 
			' listColumn2
			' 
			Me.listColumn2.AutoWidth = True
			Me.listColumn2.Header.Text = "説明"
			Me.listColumn2.Width = 65
			' 
			' dropDownButton2
			' 
			Me.dropDownButton2.Name = "dropDownButton2"
			' 
			' checkBox2
			' 
			Me.checkBox2.AutoSize = True
			Me.checkBox2.Location = New System.Drawing.Point(10, 45)
			Me.checkBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.checkBox2.Name = "checkBox2"
			Me.checkBox2.Size = New System.Drawing.Size(227, 27)
			Me.checkBox2.TabIndex = 1
			Me.checkBox2.Text = "ヘッダのリサイズを許可する"
			Me.checkBox2.UseVisualStyleBackColor = True
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(6, 199)
			Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(130, 23)
			Me.label5.TabIndex = 6
			Me.label5.Text = "選択行の前景色："
			' 
			' checkBox3
			' 
			Me.checkBox3.AutoSize = True
			Me.checkBox3.Location = New System.Drawing.Point(10, 81)
			Me.checkBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.checkBox3.Name = "checkBox3"
			Me.checkBox3.Size = New System.Drawing.Size(197, 27)
			Me.checkBox3.TabIndex = 2
			Me.checkBox3.Text = "ヘッダに画像を表示する"
			Me.checkBox3.UseVisualStyleBackColor = True
			' 
			' checkBox4
			' 
			Me.checkBox4.AutoSize = True
			Me.checkBox4.Location = New System.Drawing.Point(10, 116)
			Me.checkBox4.Margin = New System.Windows.Forms.Padding(4)
			Me.checkBox4.Name = "checkBox4"
			Me.checkBox4.Size = New System.Drawing.Size(332, 27)
			Me.checkBox4.TabIndex = 3
			Me.checkBox4.Text = "ドロップダウンリストの幅を自動で調整する"
			Me.checkBox4.UseVisualStyleBackColor = True
			' 
			' ComboMultiColumns
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(9F, 23F)
			Me.Description = "InputManのコンボコンボロールは、画像とテキストを表示できるテキストボックスと、マルチカラムリストボックスから構成されています。"
			Me.Name = "ComboMultiColumns"
			Me.Padding = New System.Windows.Forms.Padding(14, 20, 14, 4)
			Me.Title = "マルチカラムによるリスト表示"
			Me.splitContainer1.Panel1.ResumeLayout(False)
			Me.splitContainer1.Panel1.PerformLayout()
			Me.splitContainer1.Panel2.ResumeLayout(False)
			Me.splitContainer1.Panel2.PerformLayout()
			Me.splitContainer1.ResumeLayout(False)
			DirectCast(Me.gcComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gcColorPicker2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gcColorPicker1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gcComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

        Private WithEvents gcComboBox1 As GrapeCity.Win.Editors.GcComboBox
        Private WithEvents imageList1 As System.Windows.Forms.ImageList
        Private WithEvents gcShortcut1 As GrapeCity.Win.Editors.GcShortcut
        Private WithEvents dropDownButton1 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents dataSet1 As System.Data.DataSet
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
        Private WithEvents gcColorPicker2 As GrapeCity.Win.Editors.GcColorPicker
        Private WithEvents dropDownButton6 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents label6 As System.Windows.Forms.Label
        Private WithEvents gcComboBox2 As GrapeCity.Win.Editors.GcComboBox
        Private WithEvents listColumn1 As GrapeCity.Win.Editors.ListColumn
        Private WithEvents listColumn2 As GrapeCity.Win.Editors.ListColumn
        Private WithEvents dropDownButton2 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents gcColorPicker1 As GrapeCity.Win.Editors.GcColorPicker
        Private WithEvents dropDownButton5 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
        Private WithEvents checkBox4 As System.Windows.Forms.CheckBox
	End Class
End Namespace
