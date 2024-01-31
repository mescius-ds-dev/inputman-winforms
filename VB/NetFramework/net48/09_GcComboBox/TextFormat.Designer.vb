Namespace _09_GcComboBox
	Partial Class TextFormat
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
			Dim itemTemplate1 As New GrapeCity.Win.Editors.ItemTemplate()
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
			Me.dataSet1 = New System.Data.DataSet()
			Me.gcShortcut1 = New GrapeCity.Win.Editors.GcShortcut(Me.components)
			Me.gcTextBox1 = New GrapeCity.Win.Editors.GcTextBox(Me.components)
			Me.gcComboBox1 = New GrapeCity.Win.Editors.GcComboBox(Me.components)
			Me.dropDownButton1 = New GrapeCity.Win.Editors.DropDownButton()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.label6 = New System.Windows.Forms.Label()
			Me.gcComboBox2 = New GrapeCity.Win.Editors.GcComboBox(Me.components)
			Me.listColumn1 = New GrapeCity.Win.Editors.ListColumn()
			Me.listColumn2 = New GrapeCity.Win.Editors.ListColumn()
			Me.dropDownButton2 = New GrapeCity.Win.Editors.DropDownButton()
			Me.splitContainer1.Panel1.SuspendLayout()
			Me.splitContainer1.Panel2.SuspendLayout()
			Me.splitContainer1.SuspendLayout()
			DirectCast(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gcTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gcComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
			Me.splitContainer1.Panel2.Controls.Add(Me.label3)
			Me.splitContainer1.Panel2.Controls.Add(Me.label4)
			Me.splitContainer1.Panel2.Controls.Add(Me.label5)
			Me.splitContainer1.Panel2.Controls.Add(Me.label6)
			Me.splitContainer1.Panel2.Controls.Add(Me.gcTextBox1)
			Me.splitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(8, 0, 8, 4)
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			' 
			' gcTextBox1
			' 
			Me.gcTextBox1.AutoSize = True
			Me.gcTextBox1.Location = New System.Drawing.Point(155, 130)
			Me.gcTextBox1.Name = "gcTextBox1"
			Me.gcShortcut1.SetShortcuts(Me.gcTextBox1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2}, New Object() {DirectCast(Me.gcTextBox1, Object)}, New String() {"ShortcutClear"}))
			Me.gcTextBox1.Size = New System.Drawing.Size(113, 24)
			Me.gcTextBox1.TabIndex = 4
			Me.gcTextBox1.Text = "[0]：[2]"
			' 
			' gcComboBox1
			' 
			Me.gcComboBox1.DropDown.AutoWidth = True
			Me.gcComboBox1.ImeMode = System.Windows.Forms.ImeMode.[On]
			Me.gcComboBox1.ListDefaultColumn.AutoWidth = True
			Me.gcComboBox1.ListHeaderPane.Height = 25
			Me.gcComboBox1.ListItemTemplates.Add(itemTemplate1)
			Me.gcComboBox1.Location = New System.Drawing.Point(8, 29)
			Me.gcComboBox1.Name = "gcComboBox1"
			Me.gcComboBox1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.dropDownButton1})
			Me.gcComboBox1.Size = New System.Drawing.Size(260, 23)
			Me.gcComboBox1.TabIndex = 1
			' 
			' dropDownButton1
			' 
			Me.dropDownButton1.Name = "dropDownButton1"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(5, 8)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(56, 18)
			Me.label2.TabIndex = 0
			Me.label2.Text = "コンボ："
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(5, 8)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(154, 36)
			Me.label3.TabIndex = 0
			Me.label3.Text = "Textプロパティで使用する" & vbCr & vbLf & "項目のインデックス："
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(5, 126)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(116, 36)
			Me.label4.TabIndex = 3
			Me.label4.Text = "テキスト部の表示の" & vbCr & vbLf & "カスタマイズ："
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(48, 56)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(224, 54)
			Me.label5.TabIndex = 2
			Me.label5.Text = "「テキスト部の表示のカスタマイズ」が" & vbCr & vbLf & "設定されている場合には、" & vbCr & vbLf & "そちらが優先されます。"
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(30, 162)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(243, 72)
			Me.label6.TabIndex = 5
			Me.label6.Text = "項目のインデックスは" & vbCr & vbLf & """[ ]""で囲んで記述します。" & vbCr & vbLf & "例）最初と3番目の項目をコロンで区切って" & vbCr & vbLf & "表示させる場合 -> [0]：[2]"
			' 
			' gcComboBox2
			' 
			Me.gcComboBox2.AutoSize = True
			Me.gcComboBox2.DropDown.AutoWidth = True
			Me.gcComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.gcComboBox2.Ellipsis = GrapeCity.Win.Editors.EllipsisMode.EllipsisEnd
			subItem1.Value = "0"
			subItem2.Value = "name"
			listItem1.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {subItem1, subItem2})
			subItem3.Value = "1"
			subItem4.Value = "zip"
			listItem2.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {subItem3, subItem4})
			subItem5.Value = "2"
			subItem6.Value = "address1"
			listItem3.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {subItem5, subItem6})
			subItem7.Value = "3"
			subItem8.Value = "address2"
			listItem4.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {subItem7, subItem8})
			subItem9.Value = "4"
			subItem10.Value = "tel"
			listItem5.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {subItem9, subItem10})
			subItem11.Value = "5"
			subItem12.Value = "fax"
			listItem6.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {subItem11, subItem12})
			Me.gcComboBox2.Items.AddRange(New GrapeCity.Win.Editors.ListItem() {listItem1, listItem2, listItem3, listItem4, listItem5, listItem6})
			Me.gcComboBox2.ListColumns.AddRange(New GrapeCity.Win.Editors.ListColumn() {Me.listColumn1, Me.listColumn2})
			Me.gcComboBox2.ListHeaderPane.Height = 25
			Me.gcComboBox2.Location = New System.Drawing.Point(155, 13)
			Me.gcComboBox2.Name = "gcComboBox2"
			Me.gcComboBox2.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.dropDownButton2})
			Me.gcComboBox2.Size = New System.Drawing.Size(113, 26)
			Me.gcComboBox2.TabIndex = 1
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
			Me.listColumn2.Width = 57
			' 
			' dropDownButton2
			' 
			Me.dropDownButton2.Name = "dropDownButton2"
			' 
			' TextFormat
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 18F)
			Me.Description = "コンボコントロールのテキスト部は、TextSubItemIndexプロパティを指定するほかにTextFormatプロパティによるカスタマイズをサポートしています。" & ""
			Me.Margin = New System.Windows.Forms.Padding(2)
			Me.Name = "TextFormat"
			Me.Padding = New System.Windows.Forms.Padding(11, 16, 11, 3)
			Me.Title = "表示テキストのカスタマイズ"
			Me.splitContainer1.Panel1.ResumeLayout(False)
			Me.splitContainer1.Panel1.PerformLayout()
			Me.splitContainer1.Panel2.ResumeLayout(False)
			Me.splitContainer1.Panel2.PerformLayout()
			Me.splitContainer1.ResumeLayout(False)
			DirectCast(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gcTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gcComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gcComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

        Private WithEvents gcComboBox1 As GrapeCity.Win.Editors.GcComboBox
        Private WithEvents dropDownButton1 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents dataSet1 As System.Data.DataSet
        Private WithEvents gcShortcut1 As GrapeCity.Win.Editors.GcShortcut
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents label6 As System.Windows.Forms.Label
        Private WithEvents gcTextBox1 As GrapeCity.Win.Editors.GcTextBox
        Private WithEvents gcComboBox2 As GrapeCity.Win.Editors.GcComboBox
        Private WithEvents listColumn1 As GrapeCity.Win.Editors.ListColumn
        Private WithEvents listColumn2 As GrapeCity.Win.Editors.ListColumn
        Private WithEvents dropDownButton2 As GrapeCity.Win.Editors.DropDownButton
	End Class
End Namespace
