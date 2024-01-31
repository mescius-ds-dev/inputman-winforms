Namespace _12_Address
    Partial Class GcPostal
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
            Dim ListItem1 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem
            Dim SubItem1 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Dim SubItem2 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Dim ListItem2 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem
            Dim SubItem3 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Dim SubItem4 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Dim ListItem3 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem
            Dim SubItem5 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Dim SubItem6 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Me.label2 = New System.Windows.Forms.Label
            Me.gcPostal1 = New GrapeCity.Win.Editors.GcPostal(Me.components)
            Me.gcShortcut1 = New GrapeCity.Win.Editors.GcShortcut(Me.components)
            Me.gcComboBox1 = New GrapeCity.Win.Editors.GcComboBox(Me.components)
            Me.listColumn33 = New GrapeCity.Win.Editors.ListColumn
            Me.listColumn34 = New GrapeCity.Win.Editors.ListColumn
            Me.dropDownButton18 = New GrapeCity.Win.Editors.DropDownButton
            Me.gcColorPicker2 = New GrapeCity.Win.Editors.GcColorPicker(Me.components)
            Me.dropDownButton6 = New GrapeCity.Win.Editors.DropDownButton
            Me.gcColorPicker1 = New GrapeCity.Win.Editors.GcColorPicker(Me.components)
            Me.dropDownButton5 = New GrapeCity.Win.Editors.DropDownButton
            Me.gcTextBox1 = New GrapeCity.Win.Editors.GcTextBox(Me.components)
            Me.sideButton1 = New GrapeCity.Win.Editors.SideButton
            Me.gcTextBox2 = New GrapeCity.Win.Editors.GcTextBox(Me.components)
            Me.sideButton2 = New GrapeCity.Win.Editors.SideButton
            Me.gcListBox1 = New GrapeCity.Win.Editors.GcListBox
            Me.label9 = New System.Windows.Forms.Label
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.label5 = New System.Windows.Forms.Label
            Me.checkBox3 = New System.Windows.Forms.CheckBox
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.label6 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.checkBox4 = New System.Windows.Forms.CheckBox
            Me.label8 = New System.Windows.Forms.Label
            Me.splitContainer1.Panel1.SuspendLayout()
            Me.splitContainer1.Panel2.SuspendLayout()
            Me.splitContainer1.SuspendLayout()
            CType(Me.gcPostal1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcColorPicker2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcColorPicker1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcListBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'splitContainer1
            '
            '
            'splitContainer1.Panel1
            '
            Me.splitContainer1.Panel1.Controls.Add(Me.gcListBox1)
            Me.splitContainer1.Panel1.Controls.Add(Me.gcPostal1)
            Me.splitContainer1.Panel1.Controls.Add(Me.label2)
            '
            'splitContainer1.Panel2
            '
            Me.splitContainer1.Panel2.Controls.Add(Me.gcTextBox2)
            Me.splitContainer1.Panel2.Controls.Add(Me.label8)
            Me.splitContainer1.Panel2.Controls.Add(Me.label5)
            Me.splitContainer1.Panel2.Controls.Add(Me.groupBox1)
            Me.splitContainer1.Panel2.Controls.Add(Me.checkBox3)
            Me.splitContainer1.Panel2.Controls.Add(Me.gcComboBox1)
            Me.splitContainer1.Panel2.Controls.Add(Me.label9)
            Me.splitContainer1.Panel2.Controls.Add(Me.checkBox2)
            Me.splitContainer1.Panel2.Controls.Add(Me.checkBox1)
            '
            'label2
            '
            Me.label2.AutoEllipsis = True
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(5, 8)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(68, 18)
            Me.label2.TabIndex = 0
            Me.label2.Text = "郵便番号："
            '
            'gcPostal1
            '
            Me.gcPostal1.AutoSize = True
            Me.gcPostal1.Fields.ZipCodeSeparator.Text = "-"
            Me.gcPostal1.Location = New System.Drawing.Point(8, 29)
            Me.gcPostal1.Name = "gcPostal1"
            Me.gcShortcut1.SetShortcuts(Me.gcPostal1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2}, New Object() {CType(Me.gcPostal1, Object)}, New String() {"ShortcutClear"}))
            Me.gcPostal1.Size = New System.Drawing.Size(120, 24)
            Me.gcPostal1.TabIndex = 1
            '
            'gcComboBox1
            '
            Me.gcComboBox1.AutoSize = True
            Me.gcComboBox1.DropDown.AutoWidth = True
            Me.gcComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.gcComboBox1.Ellipsis = GrapeCity.Win.Editors.EllipsisMode.EllipsisEnd
            SubItem1.Value = "GeneralZipCode"
            SubItem2.Value = "住所の郵便番号を対象に検索を行います。"
            ListItem1.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem1, SubItem2})
            SubItem3.Value = "CompanyZipCode"
            SubItem4.Value = "事業所の個別郵便番号を対象に検索を行います。"
            ListItem2.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem3, SubItem4})
            SubItem5.Value = "Both"
            SubItem6.Value = "住所の郵便番号と事業所の個別郵便番号の両方を対象に検索を行います。"
            ListItem3.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem5, SubItem6})
            Me.gcComboBox1.Items.AddRange(New GrapeCity.Win.Editors.ListItem() {ListItem1, ListItem2, ListItem3})
            Me.gcComboBox1.ListColumns.AddRange(New GrapeCity.Win.Editors.ListColumn() {Me.listColumn33, Me.listColumn34})
            Me.gcComboBox1.ListHeaderPane.Height = 25
            Me.gcComboBox1.Location = New System.Drawing.Point(141, 5)
            Me.gcComboBox1.Name = "gcComboBox1"
            Me.gcShortcut1.SetShortcuts(Me.gcComboBox1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {CType(Me.gcComboBox1, Object), CType(Me.gcComboBox1, Object)}, New String() {"ShortcutClear", "ApplyRecommendedValue"}))
            Me.gcComboBox1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.dropDownButton18})
            Me.gcComboBox1.Size = New System.Drawing.Size(122, 26)
            Me.gcComboBox1.TabIndex = 1
            Me.gcComboBox1.UseCompatibleDrawing = True
            '
            'listColumn33
            '
            Me.listColumn33.AutoWidth = True
            Me.listColumn33.Header.Text = "値"
            '
            'listColumn34
            '
            Me.listColumn34.AutoWidth = True
            Me.listColumn34.Header.Text = "説明"
            '
            'dropDownButton18
            '
            Me.dropDownButton18.Name = "dropDownButton18"
            '
            'gcColorPicker2
            '
            Me.gcColorPicker2.AutoSize = True
            Me.gcColorPicker2.Location = New System.Drawing.Point(142, 99)
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
            Me.gcColorPicker1.Location = New System.Drawing.Point(142, 68)
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
            Me.gcTextBox1.Location = New System.Drawing.Point(142, 39)
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
            'gcTextBox2
            '
            Me.gcTextBox2.AutoSize = True
            Me.gcTextBox2.Location = New System.Drawing.Point(149, 254)
            Me.gcTextBox2.Name = "gcTextBox2"
            Me.gcTextBox2.ReadOnly = True
            Me.gcShortcut1.SetShortcuts(Me.gcTextBox2, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2}, New Object() {CType(Me.gcTextBox2, Object)}, New String() {"ShortcutClear"}))
            Me.gcTextBox2.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.sideButton2})
            Me.gcTextBox2.Size = New System.Drawing.Size(119, 24)
            Me.gcTextBox2.TabIndex = 8
            '
            'sideButton2
            '
            Me.sideButton2.ButtonWidth = 60
            Me.sideButton2.Name = "sideButton2"
            Me.sideButton2.Text = "設定"
            '
            'gcListBox1
            '
            Me.gcListBox1.ListHeaderPane.Height = 25
            Me.gcListBox1.Location = New System.Drawing.Point(8, 59)
            Me.gcListBox1.Name = "gcListBox1"
            Me.gcListBox1.ShowOverflowTip = True
            Me.gcListBox1.Size = New System.Drawing.Size(260, 111)
            Me.gcListBox1.TabIndex = 2
            '
            'label9
            '
            Me.label9.AutoEllipsis = True
            Me.label9.AutoSize = True
            Me.label9.Location = New System.Drawing.Point(5, 10)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(80, 18)
            Me.label9.TabIndex = 0
            Me.label9.Text = "検索の対象："
            '
            'checkBox2
            '
            Me.checkBox2.AutoSize = True
            Me.checkBox2.Location = New System.Drawing.Point(7, 69)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(243, 22)
            Me.checkBox2.TabIndex = 3
            Me.checkBox2.Text = "事業所の検索結果に住所のカナを含める"
            Me.checkBox2.UseVisualStyleBackColor = True
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Location = New System.Drawing.Point(7, 31)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(279, 40)
            Me.checkBox1.TabIndex = 2
            Me.checkBox1.Text = "同じ郵便番号に複数の丁目が含まれているとき" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "にそれぞれを分割する"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'label5
            '
            Me.label5.BackColor = System.Drawing.Color.White
            Me.label5.Font = New System.Drawing.Font("メイリオ", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.label5.Location = New System.Drawing.Point(5, 279)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(261, 58)
            Me.label5.TabIndex = 4
            Me.label5.Text = "※郵便番号コントロールの機能を有効にするには、JPAddressのインストールとプロジェクトへの追加が必要です。"
            '
            'checkBox3
            '
            Me.checkBox3.AutoSize = True
            Me.checkBox3.Location = New System.Drawing.Point(7, 94)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(219, 22)
            Me.checkBox3.TabIndex = 5
            Me.checkBox3.Text = "オートコンプリート機能を使用する"
            Me.checkBox3.UseVisualStyleBackColor = True
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.gcColorPicker2)
            Me.groupBox1.Controls.Add(Me.label6)
            Me.groupBox1.Controls.Add(Me.gcColorPicker1)
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.label7)
            Me.groupBox1.Controls.Add(Me.gcTextBox1)
            Me.groupBox1.Controls.Add(Me.checkBox4)
            Me.groupBox1.Location = New System.Drawing.Point(7, 117)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(264, 133)
            Me.groupBox1.TabIndex = 6
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "検索文字列の設定"
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(2, 101)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(128, 18)
            Me.label6.TabIndex = 5
            Me.label6.Text = "検索文字列の背景色："
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(2, 70)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(128, 18)
            Me.label4.TabIndex = 3
            Me.label4.Text = "検索文字列の前景色："
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.BackColor = System.Drawing.Color.White
            Me.label7.Location = New System.Drawing.Point(2, 41)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(140, 18)
            Me.label7.TabIndex = 1
            Me.label7.Text = "検索文字列のフォント："
            '
            'checkBox4
            '
            Me.checkBox4.AutoSize = True
            Me.checkBox4.Location = New System.Drawing.Point(6, 17)
            Me.checkBox4.Name = "checkBox4"
            Me.checkBox4.Size = New System.Drawing.Size(207, 22)
            Me.checkBox4.TabIndex = 0
            Me.checkBox4.Text = "検索文字列をハイライト表示する"
            Me.checkBox4.UseVisualStyleBackColor = True
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Location = New System.Drawing.Point(5, 256)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(140, 18)
            Me.label8.TabIndex = 7
            Me.label8.Text = "候補リストのフォント："
            '
            'GcPostal
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
            Me.Description = "郵便番号コントロールは、郵便番号から自動的に該当の住所情報を取得できる、郵便番号入力に特化したコントロールです。"
            Me.Name = "GcPostal"
            Me.Title = "郵便番号入力用コントロール"
            Me.splitContainer1.Panel1.ResumeLayout(False)
            Me.splitContainer1.Panel1.PerformLayout()
            Me.splitContainer1.Panel2.ResumeLayout(False)
            Me.splitContainer1.Panel2.PerformLayout()
            Me.splitContainer1.ResumeLayout(False)
            CType(Me.gcPostal1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcColorPicker2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcColorPicker1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcListBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents gcListBox1 As GrapeCity.Win.Editors.GcListBox
        Private WithEvents gcPostal1 As GrapeCity.Win.Editors.GcPostal
        Private WithEvents gcShortcut1 As GrapeCity.Win.Editors.GcShortcut
        Private WithEvents label9 As System.Windows.Forms.Label
        Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
        Private WithEvents gcComboBox1 As GrapeCity.Win.Editors.GcComboBox
        Private WithEvents listColumn33 As GrapeCity.Win.Editors.ListColumn
        Private WithEvents listColumn34 As GrapeCity.Win.Editors.ListColumn
        Private WithEvents dropDownButton18 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents gcColorPicker2 As GrapeCity.Win.Editors.GcColorPicker
        Private WithEvents dropDownButton6 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents label6 As System.Windows.Forms.Label
        Private WithEvents gcColorPicker1 As GrapeCity.Win.Editors.GcColorPicker
        Private WithEvents dropDownButton5 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents label7 As System.Windows.Forms.Label
        Private WithEvents gcTextBox1 As GrapeCity.Win.Editors.GcTextBox
        Private WithEvents sideButton1 As GrapeCity.Win.Editors.SideButton
        Private WithEvents checkBox4 As System.Windows.Forms.CheckBox
        Private WithEvents label8 As System.Windows.Forms.Label
        Private WithEvents gcTextBox2 As GrapeCity.Win.Editors.GcTextBox
        Private WithEvents sideButton2 As GrapeCity.Win.Editors.SideButton
    End Class
End Namespace
