Namespace _12_Address
    Partial Class GcAddressBox
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

#Region "Windows フォーム デザイナーで生成されたコード"

        ''' <summary>
        ''' デザイナー サポートに必要なメソッドです。このメソッドの内容を
        ''' コード エディターで変更しないでください。
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim ListItem1 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem
            Dim SubItem1 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Dim ListItem2 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem
            Dim SubItem2 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Dim ListItem3 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem
            Dim SubItem3 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Dim ListItem4 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem
            Dim SubItem4 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Dim ListItem5 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem
            Dim SubItem5 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Dim ListItem6 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem
            Dim SubItem6 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Dim ListItem7 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem
            Dim SubItem7 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Dim ListItem8 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem
            Dim SubItem8 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Dim ListItem9 As GrapeCity.Win.Editors.ListItem = New GrapeCity.Win.Editors.ListItem
            Dim SubItem9 As GrapeCity.Win.Editors.SubItem = New GrapeCity.Win.Editors.SubItem
            Me.gcShortcut1 = New GrapeCity.Win.Editors.GcShortcut(Me.components)
            Me.gcAddressBox1 = New GrapeCity.Win.Editors.GcAddressBox(Me.components)
            Me.gcComboBox1 = New GrapeCity.Win.Editors.GcComboBox(Me.components)
            Me.dropDownButton1 = New GrapeCity.Win.Editors.DropDownButton
            Me.label2 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.splitContainer1.Panel1.SuspendLayout()
            Me.splitContainer1.Panel2.SuspendLayout()
            Me.splitContainer1.SuspendLayout()
            CType(Me.gcAddressBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'splitContainer1
            '
            '
            'splitContainer1.Panel1
            '
            Me.splitContainer1.Panel1.Controls.Add(Me.gcAddressBox1)
            Me.splitContainer1.Panel1.Controls.Add(Me.label2)
            '
            'splitContainer1.Panel2
            '
            Me.splitContainer1.Panel2.Controls.Add(Me.gcComboBox1)
            Me.splitContainer1.Panel2.Controls.Add(Me.label3)
            Me.splitContainer1.Panel2.Controls.Add(Me.label4)
            Me.splitContainer1.Panel2.Controls.Add(Me.checkBox1)
            '
            'gcAddressBox1
            '
            Me.gcAddressBox1.Location = New System.Drawing.Point(8, 34)
            Me.gcAddressBox1.Name = "gcAddressBox1"
            Me.gcShortcut1.SetShortcuts(Me.gcAddressBox1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2}, New Object() {CType(Me.gcAddressBox1, Object)}, New String() {"ShortcutClear"}))
            Me.gcAddressBox1.Size = New System.Drawing.Size(260, 20)
            Me.gcAddressBox1.TabIndex = 3
            '
            'gcComboBox1
            '
            Me.gcComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            SubItem1.Value = "指定なし"
            ListItem1.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem1})
            SubItem2.Value = "北海道地方"
            ListItem2.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem2})
            SubItem3.Value = "東北地方"
            ListItem3.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem3})
            SubItem4.Value = "関東地方"
            ListItem4.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem4})
            SubItem5.Value = "中部地方"
            ListItem5.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem5})
            SubItem6.Value = "近畿地方"
            ListItem6.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem6})
            SubItem7.Value = "中国地方"
            ListItem7.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem7})
            SubItem8.Value = "四国地方"
            ListItem8.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem8})
            SubItem9.Value = "九州地方"
            ListItem9.SubItems.AddRange(New GrapeCity.Win.Editors.SubItem() {SubItem9})
            Me.gcComboBox1.Items.AddRange(New GrapeCity.Win.Editors.ListItem() {ListItem1, ListItem2, ListItem3, ListItem4, ListItem5, ListItem6, ListItem7, ListItem8, ListItem9})
            Me.gcComboBox1.ListHeaderPane.Height = 25
            Me.gcComboBox1.ListHeaderPane.Visible = False
            Me.gcComboBox1.Location = New System.Drawing.Point(150, 37)
            Me.gcComboBox1.MaxDropDownItems = 9
            Me.gcComboBox1.Name = "gcComboBox1"
            Me.gcShortcut1.SetShortcuts(Me.gcComboBox1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {CType(Me.gcComboBox1, Object), CType(Me.gcComboBox1, Object)}, New String() {"ShortcutClear", "ApplyRecommendedValue"}))
            Me.gcComboBox1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.dropDownButton1})
            Me.gcComboBox1.Size = New System.Drawing.Size(120, 26)
            Me.gcComboBox1.TabIndex = 8
            Me.gcComboBox1.UseCompatibleDrawing = True
            '
            'dropDownButton1
            '
            Me.dropDownButton1.Name = "dropDownButton1"
            '
            'label2
            '
            Me.label2.AutoEllipsis = True
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(5, 13)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(44, 18)
            Me.label2.TabIndex = 2
            Me.label2.Text = "住所："
            '
            'label3
            '
            Me.label3.Location = New System.Drawing.Point(10, 37)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(134, 43)
            Me.label3.TabIndex = 5
            Me.label3.Text = "検索対象の都道府県を絞り込む："
            '
            'label4
            '
            Me.label4.BackColor = System.Drawing.Color.White
            Me.label4.Font = New System.Drawing.Font("メイリオ", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.label4.Location = New System.Drawing.Point(10, 195)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(261, 58)
            Me.label4.TabIndex = 7
            Me.label4.Text = "※住所コントロールの機能を有効にするには、JPAddressのインストールとプロジェクトへの追加が必要です。"
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Checked = True
            Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox1.Location = New System.Drawing.Point(13, 12)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(207, 22)
            Me.checkBox1.TabIndex = 4
            Me.checkBox1.Text = "オートフィルタ機能を有効にする"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'GcAddressBox
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
            Me.Description = "住所コントロールは、都道府県から市区町村などの候補を絞り込みながら住所を選択および入力していく、住所入力に特化したコントロールです。"
            Me.Name = "GcAddressBox"
            Me.Title = "住所入力用コントロール"
            Me.splitContainer1.Panel1.ResumeLayout(False)
            Me.splitContainer1.Panel1.PerformLayout()
            Me.splitContainer1.Panel2.ResumeLayout(False)
            Me.splitContainer1.Panel2.PerformLayout()
            Me.splitContainer1.ResumeLayout(False)
            CType(Me.gcAddressBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Private WithEvents gcShortcut1 As GrapeCity.Win.Editors.GcShortcut
        Private WithEvents gcAddressBox1 As GrapeCity.Win.Editors.GcAddressBox
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
        Private WithEvents gcComboBox1 As GrapeCity.Win.Editors.GcComboBox
        Private WithEvents dropDownButton1 As GrapeCity.Win.Editors.DropDownButton
#End Region
    End Class
End Namespace
