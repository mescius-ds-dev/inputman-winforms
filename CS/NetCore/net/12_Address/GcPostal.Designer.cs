namespace InputManWin12_Demo._12_Address
{
    partial class GcPostal
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            GrapeCity.Win.Editors.ListItem listItem1 = new GrapeCity.Win.Editors.ListItem();
            GrapeCity.Win.Editors.SubItem subItem1 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.SubItem subItem2 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.ListItem listItem2 = new GrapeCity.Win.Editors.ListItem();
            GrapeCity.Win.Editors.SubItem subItem3 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.SubItem subItem4 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.ListItem listItem3 = new GrapeCity.Win.Editors.ListItem();
            GrapeCity.Win.Editors.SubItem subItem5 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.SubItem subItem6 = new GrapeCity.Win.Editors.SubItem();
            this.label2 = new System.Windows.Forms.Label();
            this.gcPostal1 = new GrapeCity.Win.Editors.GcPostal(this.components);
            this.gcShortcut1 = new GrapeCity.Win.Editors.GcShortcut(this.components);
            this.gcComboBox1 = new GrapeCity.Win.Editors.GcComboBox(this.components);
            this.listColumn33 = new GrapeCity.Win.Editors.ListColumn();
            this.listColumn34 = new GrapeCity.Win.Editors.ListColumn();
            this.dropDownButton18 = new GrapeCity.Win.Editors.DropDownButton();
            this.gcColorPicker2 = new GrapeCity.Win.Editors.GcColorPicker(this.components);
            this.dropDownButton6 = new GrapeCity.Win.Editors.DropDownButton();
            this.gcColorPicker1 = new GrapeCity.Win.Editors.GcColorPicker(this.components);
            this.dropDownButton5 = new GrapeCity.Win.Editors.DropDownButton();
            this.gcTextBox1 = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this.sideButton1 = new GrapeCity.Win.Editors.SideButton();
            this.gcTextBox2 = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this.sideButton2 = new GrapeCity.Win.Editors.SideButton();
            this.gcListBox1 = new GrapeCity.Win.Editors.GcListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPostal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcColorPicker2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcColorPicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gcListBox1);
            this.splitContainer1.Panel1.Controls.Add(this.gcPostal1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcTextBox2);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox3);
            this.splitContainer1.Panel2.Controls.Add(this.gcComboBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox2);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox1);
            this.splitContainer1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "郵便番号：";
            // 
            // gcPostal1
            // 
            this.gcPostal1.AutoSize = true;
            this.gcPostal1.Fields.ZipCodeSeparator.Text = "-";
            this.gcPostal1.Location = new System.Drawing.Point(8, 29);
            this.gcPostal1.Name = "gcPostal1";
            this.gcShortcut1.SetShortcuts(this.gcPostal1, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] {
                System.Windows.Forms.Keys.F2}, new object[] {
                ((object)(this.gcPostal1))}, new string[] {
                "ShortcutClear"}));
            this.gcPostal1.Size = new System.Drawing.Size(120, 24);
            this.gcPostal1.TabIndex = 1;
            // 
            // gcComboBox1
            // 
            this.gcComboBox1.AutoSize = true;
            this.gcComboBox1.DropDown.AutoWidth = true;
            this.gcComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcComboBox1.Ellipsis = GrapeCity.Win.Editors.EllipsisMode.EllipsisEnd;
            subItem1.Value = "GeneralZipCode";
            subItem2.Value = "住所の郵便番号を対象に検索を行います。";
            listItem1.SubItems.AddRange(new GrapeCity.Win.Editors.SubItem[] {
            subItem1,
            subItem2});
            subItem3.Value = "CompanyZipCode";
            subItem4.Value = "事業所の個別郵便番号を対象に検索を行います。";
            listItem2.SubItems.AddRange(new GrapeCity.Win.Editors.SubItem[] {
            subItem3,
            subItem4});
            subItem5.Value = "Both";
            subItem6.Value = "住所の郵便番号と事業所の個別郵便番号の両方を対象に検索を行います。";
            listItem3.SubItems.AddRange(new GrapeCity.Win.Editors.SubItem[] {
            subItem5,
            subItem6});
            this.gcComboBox1.Items.AddRange(new GrapeCity.Win.Editors.ListItem[] {
            listItem1,
            listItem2,
            listItem3});
            this.gcComboBox1.ListColumns.AddRange(new GrapeCity.Win.Editors.ListColumn[] {
            this.listColumn33,
            this.listColumn34});
            this.gcComboBox1.ListHeaderPane.Height = 25;
            this.gcComboBox1.Location = new System.Drawing.Point(141, 5);
            this.gcComboBox1.Name = "gcComboBox1";
            this.gcShortcut1.SetShortcuts(this.gcComboBox1, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] {
                System.Windows.Forms.Keys.F2,
                ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Return)))}, new object[] {
                ((object)(this.gcComboBox1)),
                ((object)(this.gcComboBox1))}, new string[] {
                "ShortcutClear",
                "ApplyRecommendedValue"}));
            this.gcComboBox1.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] {
            this.dropDownButton18});
            this.gcComboBox1.Size = new System.Drawing.Size(122, 26);
            this.gcComboBox1.TabIndex = 1;
            this.gcComboBox1.UseCompatibleDrawing = true;
            // 
            // listColumn33
            // 
            this.listColumn33.AutoWidth = true;
            this.listColumn33.Header.Text = "値";
            // 
            // listColumn34
            // 
            this.listColumn34.AutoWidth = true;
            this.listColumn34.Header.Text = "説明";
            // 
            // dropDownButton18
            // 
            this.dropDownButton18.Name = "dropDownButton18";
            // 
            // gcColorPicker2
            // 
            this.gcColorPicker2.AutoSize = true;
            this.gcColorPicker2.Location = new System.Drawing.Point(142, 99);
            this.gcColorPicker2.Name = "gcColorPicker2";
            this.gcShortcut1.SetShortcuts(this.gcColorPicker2, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] {
                System.Windows.Forms.Keys.F2,
                ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Return)))}, new object[] {
                ((object)(this.gcColorPicker2)),
                ((object)(this.gcColorPicker2))}, new string[] {
                "ShortcutClear",
                "ApplyRecommendedValue"}));
            this.gcColorPicker2.ShowListBoxImage = true;
            this.gcColorPicker2.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] {
            this.dropDownButton6});
            this.gcColorPicker2.Size = new System.Drawing.Size(119, 26);
            this.gcColorPicker2.TabIndex = 6;
            this.gcColorPicker2.UnSelectedImageIndex = 0;
            // 
            // dropDownButton6
            // 
            this.dropDownButton6.Name = "dropDownButton6";
            // 
            // gcColorPicker1
            // 
            this.gcColorPicker1.AutoSize = true;
            this.gcColorPicker1.Location = new System.Drawing.Point(142, 68);
            this.gcColorPicker1.Name = "gcColorPicker1";
            this.gcShortcut1.SetShortcuts(this.gcColorPicker1, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] {
                System.Windows.Forms.Keys.F2,
                ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Return)))}, new object[] {
                ((object)(this.gcColorPicker1)),
                ((object)(this.gcColorPicker1))}, new string[] {
                "ShortcutClear",
                "ApplyRecommendedValue"}));
            this.gcColorPicker1.ShowListBoxImage = true;
            this.gcColorPicker1.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] {
            this.dropDownButton5});
            this.gcColorPicker1.Size = new System.Drawing.Size(119, 26);
            this.gcColorPicker1.TabIndex = 4;
            this.gcColorPicker1.UnSelectedImageIndex = 0;
            // 
            // dropDownButton5
            // 
            this.dropDownButton5.Name = "dropDownButton5";
            // 
            // gcTextBox1
            // 
            this.gcTextBox1.AutoSize = true;
            this.gcTextBox1.Location = new System.Drawing.Point(142, 39);
            this.gcTextBox1.Name = "gcTextBox1";
            this.gcTextBox1.ReadOnly = true;
            this.gcShortcut1.SetShortcuts(this.gcTextBox1, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] {
                System.Windows.Forms.Keys.F2}, new object[] {
                ((object)(this.gcTextBox1))}, new string[] {
                "ShortcutClear"}));
            this.gcTextBox1.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] {
            this.sideButton1});
            this.gcTextBox1.Size = new System.Drawing.Size(119, 24);
            this.gcTextBox1.TabIndex = 2;
            // 
            // sideButton1
            // 
            this.sideButton1.ButtonWidth = 60;
            this.sideButton1.Name = "sideButton1";
            this.sideButton1.Text = "設定";
            // 
            // gcTextBox2
            // 
            this.gcTextBox2.AutoSize = true;
            this.gcTextBox2.Location = new System.Drawing.Point(149, 254);
            this.gcTextBox2.Name = "gcTextBox2";
            this.gcTextBox2.ReadOnly = true;
            this.gcShortcut1.SetShortcuts(this.gcTextBox2, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] {
                System.Windows.Forms.Keys.F2}, new object[] {
                ((object)(this.gcTextBox2))}, new string[] {
                "ShortcutClear"}));
            this.gcTextBox2.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] {
            this.sideButton2});
            this.gcTextBox2.Size = new System.Drawing.Size(119, 24);
            this.gcTextBox2.TabIndex = 8;
            // 
            // sideButton2
            // 
            this.sideButton2.ButtonWidth = 60;
            this.sideButton2.Name = "sideButton2";
            this.sideButton2.Text = "設定";
            // 
            // gcListBox1
            // 
            this.gcListBox1.ListHeaderPane.Height = 25;
            this.gcListBox1.Location = new System.Drawing.Point(8, 59);
            this.gcListBox1.Name = "gcListBox1";
            this.gcListBox1.ShowOverflowTip = true;
            this.gcListBox1.Size = new System.Drawing.Size(260, 111);
            this.gcListBox1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "検索の対象：";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 69);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(243, 22);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "事業所の検索結果に住所のカナを含める";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(279, 40);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "同じ郵便番号に複数の丁目が含まれているとき\r\nにそれぞれを分割する";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("メイリオ", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(4, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 58);
            this.label5.TabIndex = 4;
            this.label5.Text = "※郵便番号コントロールの機能を有効にするには、JPAddressのインストールとプロジェクトへの追加が必要です。";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 94);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(219, 22);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "オートコンプリート機能を使用する";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gcColorPicker2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.gcColorPicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.gcTextBox1);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Location = new System.Drawing.Point(7, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 133);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "検索文字列の設定";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "検索文字列の背景色：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "検索文字列の前景色：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(2, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "検索文字列のフォント：";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 17);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(207, 22);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "検索文字列をハイライト表示する";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "候補リストのフォント：";
            // 
            // GcPostal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.Description = "郵便番号コントロールは、郵便番号から自動的に該当の住所情報を取得できる、郵便番号入力に特化したコントロールです。";
            this.Name = "GcPostal";
            this.Title = "郵便番号入力用コントロール";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPostal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcColorPicker2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcColorPicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private GrapeCity.Win.Editors.GcListBox gcListBox1;
        private GrapeCity.Win.Editors.GcPostal gcPostal1;
        private GrapeCity.Win.Editors.GcShortcut gcShortcut1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private GrapeCity.Win.Editors.GcComboBox gcComboBox1;
        private GrapeCity.Win.Editors.ListColumn listColumn33;
        private GrapeCity.Win.Editors.ListColumn listColumn34;
        private GrapeCity.Win.Editors.DropDownButton dropDownButton18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private GrapeCity.Win.Editors.GcColorPicker gcColorPicker2;
        private GrapeCity.Win.Editors.DropDownButton dropDownButton6;
        private System.Windows.Forms.Label label6;
        private GrapeCity.Win.Editors.GcColorPicker gcColorPicker1;
        private GrapeCity.Win.Editors.DropDownButton dropDownButton5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private GrapeCity.Win.Editors.GcTextBox gcTextBox1;
        private GrapeCity.Win.Editors.SideButton sideButton1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label8;
        private GrapeCity.Win.Editors.GcTextBox gcTextBox2;
        private GrapeCity.Win.Editors.SideButton sideButton2;
    }
}
