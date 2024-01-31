namespace InputManWin12_Demo._12_Address
{
    partial class GcAddressBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            GrapeCity.Win.Editors.ListItem listItem1 = new GrapeCity.Win.Editors.ListItem();
            GrapeCity.Win.Editors.SubItem subItem1 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.ListItem listItem2 = new GrapeCity.Win.Editors.ListItem();
            GrapeCity.Win.Editors.SubItem subItem2 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.ListItem listItem3 = new GrapeCity.Win.Editors.ListItem();
            GrapeCity.Win.Editors.SubItem subItem3 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.ListItem listItem4 = new GrapeCity.Win.Editors.ListItem();
            GrapeCity.Win.Editors.SubItem subItem4 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.ListItem listItem5 = new GrapeCity.Win.Editors.ListItem();
            GrapeCity.Win.Editors.SubItem subItem5 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.ListItem listItem6 = new GrapeCity.Win.Editors.ListItem();
            GrapeCity.Win.Editors.SubItem subItem6 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.ListItem listItem7 = new GrapeCity.Win.Editors.ListItem();
            GrapeCity.Win.Editors.SubItem subItem7 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.ListItem listItem8 = new GrapeCity.Win.Editors.ListItem();
            GrapeCity.Win.Editors.SubItem subItem8 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.ListItem listItem9 = new GrapeCity.Win.Editors.ListItem();
            GrapeCity.Win.Editors.SubItem subItem9 = new GrapeCity.Win.Editors.SubItem();
            this.label2 = new System.Windows.Forms.Label();
            this.gcShortcut1 = new GrapeCity.Win.Editors.GcShortcut(this.components);
            this.gcAddressBox1 = new GrapeCity.Win.Editors.GcAddressBox(this.components);
            this.gcComboBox1 = new GrapeCity.Win.Editors.GcComboBox(this.components);
            this.dropDownButton1 = new GrapeCity.Win.Editors.DropDownButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAddressBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gcAddressBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcComboBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox1);
            this.splitContainer1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "住所：";
            // 
            // gcAddressBox1
            // 
            this.gcAddressBox1.Location = new System.Drawing.Point(8, 33);
            this.gcAddressBox1.Name = "gcAddressBox1";
            this.gcShortcut1.SetShortcuts(this.gcAddressBox1, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] {
                System.Windows.Forms.Keys.F2}, new object[] {
                ((object)(this.gcAddressBox1))}, new string[] {
                "ShortcutClear"}));
            this.gcAddressBox1.Size = new System.Drawing.Size(260, 20);
            this.gcAddressBox1.TabIndex = 1;
            // 
            // gcComboBox1
            // 
            this.gcComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            subItem1.Value = "指定なし";
            listItem1.SubItems.AddRange(new GrapeCity.Win.Editors.SubItem[] {
            subItem1});
            subItem2.Value = "北海道地方";
            listItem2.SubItems.AddRange(new GrapeCity.Win.Editors.SubItem[] {
            subItem2});
            subItem3.Value = "東北地方";
            listItem3.SubItems.AddRange(new GrapeCity.Win.Editors.SubItem[] {
            subItem3});
            subItem4.Value = "関東地方";
            listItem4.SubItems.AddRange(new GrapeCity.Win.Editors.SubItem[] {
            subItem4});
            subItem5.Value = "中部地方";
            listItem5.SubItems.AddRange(new GrapeCity.Win.Editors.SubItem[] {
            subItem5});
            subItem6.Value = "近畿地方";
            listItem6.SubItems.AddRange(new GrapeCity.Win.Editors.SubItem[] {
            subItem6});
            subItem7.Value = "中国地方";
            listItem7.SubItems.AddRange(new GrapeCity.Win.Editors.SubItem[] {
            subItem7});
            subItem8.Value = "四国地方";
            listItem8.SubItems.AddRange(new GrapeCity.Win.Editors.SubItem[] {
            subItem8});
            subItem9.Value = "九州地方";
            listItem9.SubItems.AddRange(new GrapeCity.Win.Editors.SubItem[] {
            subItem9});
            this.gcComboBox1.Items.AddRange(new GrapeCity.Win.Editors.ListItem[] {
            listItem1,
            listItem2,
            listItem3,
            listItem4,
            listItem5,
            listItem6,
            listItem7,
            listItem8,
            listItem9});
            this.gcComboBox1.ListHeaderPane.Height = 25;
            this.gcComboBox1.ListHeaderPane.Visible = false;
            this.gcComboBox1.Location = new System.Drawing.Point(150, 37);
            this.gcComboBox1.MaxDropDownItems = 9;
            this.gcComboBox1.Name = "gcComboBox1";
            this.gcShortcut1.SetShortcuts(this.gcComboBox1, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] {
                System.Windows.Forms.Keys.F2,
                ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Return)))}, new object[] {
                ((object)(this.gcComboBox1)),
                ((object)(this.gcComboBox1))}, new string[] {
                "ShortcutClear",
                "ApplyRecommendedValue"}));
            this.gcComboBox1.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] {
            this.dropDownButton1});
            this.gcComboBox1.Size = new System.Drawing.Size(120, 26);
            this.gcComboBox1.TabIndex = 4;
            this.gcComboBox1.UseCompatibleDrawing = true;
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Name = "dropDownButton1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(13, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(207, 22);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "オートフィルタ機能を有効にする";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("メイリオ", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(10, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 58);
            this.label4.TabIndex = 3;
            this.label4.Text = "※住所コントロールの機能を有効にするには、JPAddressのインストールとプロジェクトへの追加が必要です。";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 43);
            this.label3.TabIndex = 1;
            this.label3.Text = "検索対象の都道府県を絞り込む：";
            // 
            // GcAddressBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Description = "住所コントロールは、都道府県から市区町村などの候補を絞り込みながら住所を選択および入力していく、住所入力に特化したコントロールです。";
            this.Name = "GcAddressBox";
            this.Title = "住所入力用コントロール";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAddressBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private GrapeCity.Win.Editors.GcShortcut gcShortcut1;
        private System.Windows.Forms.CheckBox checkBox1;
        private GrapeCity.Win.Editors.GcAddressBox gcAddressBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private GrapeCity.Win.Editors.GcComboBox gcComboBox1;
        private GrapeCity.Win.Editors.DropDownButton dropDownButton1;
    }
}