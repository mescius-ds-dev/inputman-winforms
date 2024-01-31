namespace InputManWin12_Demo._09_GcComboBox
{
    partial class TextFormat
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
            GrapeCity.Win.Editors.ItemTemplate itemTemplate1 = new GrapeCity.Win.Editors.ItemTemplate();
            GrapeCity.Win.Editors.ListItem listItem1 = new GrapeCity.Win.Editors.ListItem();
            GrapeCity.Win.Editors.SubItem subItem1 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.SubItem subItem2 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.ListItem listItem2 = new GrapeCity.Win.Editors.ListItem();
            GrapeCity.Win.Editors.SubItem subItem3 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.SubItem subItem4 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.ListItem listItem3 = new GrapeCity.Win.Editors.ListItem();
            GrapeCity.Win.Editors.SubItem subItem5 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.SubItem subItem6 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.ListItem listItem4 = new GrapeCity.Win.Editors.ListItem();
            GrapeCity.Win.Editors.SubItem subItem7 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.SubItem subItem8 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.ListItem listItem5 = new GrapeCity.Win.Editors.ListItem();
            GrapeCity.Win.Editors.SubItem subItem9 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.SubItem subItem10 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.ListItem listItem6 = new GrapeCity.Win.Editors.ListItem();
            GrapeCity.Win.Editors.SubItem subItem11 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.SubItem subItem12 = new GrapeCity.Win.Editors.SubItem();
            this.dataSet1 = new System.Data.DataSet();
            this.gcShortcut1 = new GrapeCity.Win.Editors.GcShortcut(this.components);
            this.gcTextBox1 = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this.gcComboBox1 = new GrapeCity.Win.Editors.GcComboBox(this.components);
            this.dropDownButton1 = new GrapeCity.Win.Editors.DropDownButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gcComboBox2 = new GrapeCity.Win.Editors.GcComboBox(this.components);
            this.listColumn1 = new GrapeCity.Win.Editors.ListColumn();
            this.listColumn2 = new GrapeCity.Win.Editors.ListColumn();
            this.dropDownButton2 = new GrapeCity.Win.Editors.DropDownButton();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcComboBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gcComboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcComboBox2);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.gcTextBox1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(8, 0, 8, 4);
            this.splitContainer1.TabIndex = 3;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // gcTextBox1
            // 
            this.gcTextBox1.AutoSize = true;
            this.gcTextBox1.Location = new System.Drawing.Point(155, 130);
            this.gcTextBox1.Name = "gcTextBox1";
            this.gcShortcut1.SetShortcuts(this.gcTextBox1, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] {
                System.Windows.Forms.Keys.F2}, new object[] {
                ((object)(this.gcTextBox1))}, new string[] {
                "ShortcutClear"}));
            this.gcTextBox1.Size = new System.Drawing.Size(113, 24);
            this.gcTextBox1.TabIndex = 4;
            this.gcTextBox1.Text = "[0]：[2]";
            // 
            // gcComboBox1
            // 
            this.gcComboBox1.DropDown.AutoWidth = true;
            this.gcComboBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.gcComboBox1.ListDefaultColumn.AutoWidth = true;
            this.gcComboBox1.ListHeaderPane.Height = 25;
            this.gcComboBox1.ListItemTemplates.Add(itemTemplate1);
            this.gcComboBox1.Location = new System.Drawing.Point(8, 29);
            this.gcComboBox1.Name = "gcComboBox1";
            this.gcComboBox1.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] {
            this.dropDownButton1});
            this.gcComboBox1.Size = new System.Drawing.Size(260, 23);
            this.gcComboBox1.TabIndex = 1;
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Name = "dropDownButton1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "コンボ：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Textプロパティで使用する\r\n項目のインデックス：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "テキスト部の表示の\r\nカスタマイズ：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 54);
            this.label5.TabIndex = 2;
            this.label5.Text = "「テキスト部の表示のカスタマイズ」が\r\n設定されている場合には、\r\nそちらが優先されます。";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 72);
            this.label6.TabIndex = 5;
            this.label6.Text = "項目のインデックスは\r\n\"[ ]\"で囲んで記述します。\r\n例）最初と3番目の項目をコロンで区切って\r\n表示させる場合 -> [0]：[2]";
            // 
            // gcComboBox2
            // 
            this.gcComboBox2.AutoSize = true;
            this.gcComboBox2.DropDown.AutoWidth = true;
            this.gcComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcComboBox2.Ellipsis = GrapeCity.Win.Editors.EllipsisMode.EllipsisEnd;
            subItem1.Value = "0";
            subItem2.Value = "name";
            listItem1.SubItems.AddRange(new GrapeCity.Win.Editors.SubItem[] {
            subItem1,
            subItem2});
            subItem3.Value = "1";
            subItem4.Value = "zip";
            listItem2.SubItems.AddRange(new GrapeCity.Win.Editors.SubItem[] {
            subItem3,
            subItem4});
            subItem5.Value = "2";
            subItem6.Value = "address1";
            listItem3.SubItems.AddRange(new GrapeCity.Win.Editors.SubItem[] {
            subItem5,
            subItem6});
            subItem7.Value = "3";
            subItem8.Value = "address2";
            listItem4.SubItems.AddRange(new GrapeCity.Win.Editors.SubItem[] {
            subItem7,
            subItem8});
            subItem9.Value = "4";
            subItem10.Value = "tel";
            listItem5.SubItems.AddRange(new GrapeCity.Win.Editors.SubItem[] {
            subItem9,
            subItem10});
            subItem11.Value = "5";
            subItem12.Value = "fax";
            listItem6.SubItems.AddRange(new GrapeCity.Win.Editors.SubItem[] {
            subItem11,
            subItem12});
            this.gcComboBox2.Items.AddRange(new GrapeCity.Win.Editors.ListItem[] {
            listItem1,
            listItem2,
            listItem3,
            listItem4,
            listItem5,
            listItem6});
            this.gcComboBox2.ListColumns.AddRange(new GrapeCity.Win.Editors.ListColumn[] {
            this.listColumn1,
            this.listColumn2});
            this.gcComboBox2.ListHeaderPane.Height = 25;
            this.gcComboBox2.Location = new System.Drawing.Point(155, 13);
            this.gcComboBox2.Name = "gcComboBox2";
            this.gcComboBox2.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] {
            this.dropDownButton2});
            this.gcComboBox2.Size = new System.Drawing.Size(113, 26);
            this.gcComboBox2.TabIndex = 1;
            this.gcComboBox2.TextFormat = "[0]：[1]";
            this.gcComboBox2.UseCompatibleDrawing = true;
            // 
            // listColumn1
            // 
            this.listColumn1.AutoWidth = false;
            this.listColumn1.Header.Text = "値";
            this.listColumn1.Width = 84;
            // 
            // listColumn2
            // 
            this.listColumn2.AutoWidth = true;
            this.listColumn2.Header.Text = "説明";
            this.listColumn2.Width = 57;
            // 
            // dropDownButton2
            // 
            this.dropDownButton2.Name = "dropDownButton2";
            // 
            // TextFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.Description = "コンボコントロールのテキスト部は、TextSubItemIndexプロパティを指定するほかにTextFormatプロパティによるカスタマイズをサポートしています。" +
                "";
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TextFormat";
            this.Padding = new System.Windows.Forms.Padding(11, 16, 11, 3);
            this.Title = "表示テキストのカスタマイズ";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcComboBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GrapeCity.Win.Editors.GcComboBox gcComboBox1;
        private GrapeCity.Win.Editors.DropDownButton dropDownButton1;
        private System.Windows.Forms.Label label2;
        private System.Data.DataSet dataSet1;
        private GrapeCity.Win.Editors.GcShortcut gcShortcut1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private GrapeCity.Win.Editors.GcTextBox gcTextBox1;
        private GrapeCity.Win.Editors.GcComboBox gcComboBox2;
        private GrapeCity.Win.Editors.ListColumn listColumn1;
        private GrapeCity.Win.Editors.ListColumn listColumn2;
        private GrapeCity.Win.Editors.DropDownButton dropDownButton2;
    }
}
