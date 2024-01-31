namespace InputManWin12_Demo._14_GcSoftKeyboard
{
    partial class Appearance
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            GrapeCity.Win.Editors.Fields.NumberSignDisplayField numberSignDisplayField1 = new GrapeCity.Win.Editors.Fields.NumberSignDisplayField();
            GrapeCity.Win.Editors.Fields.NumberIntegerPartDisplayField numberIntegerPartDisplayField1 = new GrapeCity.Win.Editors.Fields.NumberIntegerPartDisplayField();
            GrapeCity.Win.Editors.Fields.NumberDecimalSeparatorDisplayField numberDecimalSeparatorDisplayField1 = new GrapeCity.Win.Editors.Fields.NumberDecimalSeparatorDisplayField();
            GrapeCity.Win.Editors.Fields.NumberDecimalPartDisplayField numberDecimalPartDisplayField1 = new GrapeCity.Win.Editors.Fields.NumberDecimalPartDisplayField();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gcColorPicker1 = new GrapeCity.Win.Editors.GcColorPicker(this.components);
            this.dropDownButton11 = new GrapeCity.Win.Editors.DropDownButton();
            this.gcSoftKeyboard1 = new GrapeCity.Win.Editors.GcSoftKeyboard();
            this.gcColorPicker2 = new GrapeCity.Win.Editors.GcColorPicker(this.components);
            this.dropDownButton1 = new GrapeCity.Win.Editors.DropDownButton();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gcNumber1 = new GrapeCity.Win.Editors.GcNumber(this.components);
            this.sideButton1 = new GrapeCity.Win.Editors.SideButton();
            this.sideButton2 = new GrapeCity.Win.Editors.SideButton();
            this.gcShortcut1 = new GrapeCity.Win.Editors.GcShortcut(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcColorPicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcColorPicker2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNumber1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.gcNumber1);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.gcColorPicker2);
            this.splitContainer1.Panel2.Controls.Add(this.gcColorPicker1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 25);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(15, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "キーボードを表示";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "基底色：";
            // 
            // gcColorPicker1
            // 
            this.gcColorPicker1.AutoSize = true;
            this.gcColorPicker1.DropDown.AutoHideTouchKeyboard = GrapeCity.Win.Editors.AutoHideTouchKeyboard.None;
            this.gcColorPicker1.DropDown.AutoWidth = true;
            this.gcColorPicker1.Location = new System.Drawing.Point(131, 8);
            this.gcColorPicker1.Name = "gcColorPicker1";
            this.gcColorPicker1.ShowListBoxImage = true;
            this.gcColorPicker1.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] {
            this.dropDownButton11});
            this.gcColorPicker1.Size = new System.Drawing.Size(135, 26);
            this.gcColorPicker1.TabIndex = 16;
            this.gcColorPicker1.UnSelectedImageIndex = 0;
            this.gcColorPicker1.SelectedIndexChanged += new System.EventHandler(this.gcColorPicker1_SelectedIndexChanged);
            // 
            // dropDownButton11
            // 
            this.dropDownButton11.Name = "dropDownButton11";
            // 
            // gcColorPicker2
            // 
            this.gcColorPicker2.AutoSize = true;
            this.gcColorPicker2.DropDown.AutoHideTouchKeyboard = GrapeCity.Win.Editors.AutoHideTouchKeyboard.None;
            this.gcColorPicker2.DropDown.AutoWidth = true;
            this.gcColorPicker2.Location = new System.Drawing.Point(131, 42);
            this.gcColorPicker2.Name = "gcColorPicker2";
            this.gcColorPicker2.ShowListBoxImage = true;
            this.gcColorPicker2.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] {
            this.dropDownButton1});
            this.gcColorPicker2.Size = new System.Drawing.Size(135, 26);
            this.gcColorPicker2.TabIndex = 17;
            this.gcColorPicker2.UnSelectedImageIndex = 0;
            this.gcColorPicker2.SelectedIndexChanged += new System.EventHandler(this.gcColorPicker2_SelectedIndexChanged);
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Name = "dropDownButton1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "切替キーの色：";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 76);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(159, 22);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "キーに境界線を表示する";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // gcNumber1
            // 
            this.gcNumber1.AutoSize = true;
            numberIntegerPartDisplayField1.GroupSizes = new int[] {
        0};
            numberDecimalPartDisplayField1.MaxDigits = 2;
            numberDecimalPartDisplayField1.MinDigits = 2;
            this.gcNumber1.DisplayFields.AddRange(new GrapeCity.Win.Editors.Fields.NumberDisplayField[] {
            numberSignDisplayField1,
            numberIntegerPartDisplayField1,
            numberDecimalSeparatorDisplayField1,
            numberDecimalPartDisplayField1});
            this.gcNumber1.Fields.DecimalPart.MaxDigits = 2;
            this.gcNumber1.Fields.DecimalPart.MinDigits = 2;
            this.gcNumber1.Fields.IntegerPart.GroupSizes = new int[] {
        0};
            this.gcNumber1.Fields.IntegerPart.MaxDigits = 1;
            this.gcNumber1.Fields.IntegerPart.MinDigits = 1;
            this.gcNumber1.Location = new System.Drawing.Point(166, 105);
            this.gcNumber1.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.gcNumber1.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gcNumber1.Name = "gcNumber1";
            this.gcShortcut1.SetShortcuts(this.gcNumber1, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] {
                System.Windows.Forms.Keys.F2,
                System.Windows.Forms.Keys.Subtract,
                System.Windows.Forms.Keys.OemMinus,
                ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Return)))}, new object[] {
                ((object)(this.gcNumber1)),
                ((object)(this.gcNumber1)),
                ((object)(this.gcNumber1)),
                ((object)(this.gcNumber1))}, new string[] {
                "SetZero",
                "SwitchSign",
                "SwitchSign",
                "ApplyRecommendedValue"}));
            this.gcNumber1.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] {
            this.sideButton1,
            this.sideButton2});
            this.gcNumber1.Size = new System.Drawing.Size(100, 24);
            this.gcNumber1.Spin.IncrementValue = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.gcNumber1.Spin.SpinMode = GrapeCity.Win.Editors.NumberSpinMode.Value;
            this.gcNumber1.Spin.Wrap = false;
            this.gcNumber1.TabIndex = 20;
            this.gcNumber1.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            this.gcNumber1.ValueSign = GrapeCity.Win.Editors.ValueSignControl.Positive;
            this.gcNumber1.ValueChanged += new System.EventHandler(this.gcNumber1_ValueChanged);
            // 
            // sideButton1
            // 
            this.sideButton1.Behavior = GrapeCity.Win.Editors.SideButtonBehavior.SpinUp;
            this.sideButton1.Interval = 60;
            this.sideButton1.Name = "sideButton1";
            this.sideButton1.Text = "+";
            // 
            // sideButton2
            // 
            this.sideButton2.Behavior = GrapeCity.Win.Editors.SideButtonBehavior.SpinDown;
            this.sideButton2.Interval = 60;
            this.sideButton2.Name = "sideButton2";
            this.sideButton2.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "キーボードの透過率：";
            // 
            // Appearance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Description = "ソフトキーボードコンポーネントでは、基底となる色を指定することで、キー全体の文字色、背景色が調整されます。全角・半角や、キーレイアウトを切り替える、切替キーには個" +
    "別の色を設定可能です。また、キーボード全体の透過表示もできます。";
            this.Name = "Appearance";
            this.Title = "スタイルの変更";
            this.Load += new System.EventHandler(this.Appearance_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcColorPicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcColorPicker2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNumber1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private GrapeCity.Win.Editors.GcColorPicker gcColorPicker1;
        private GrapeCity.Win.Editors.DropDownButton dropDownButton11;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private GrapeCity.Win.Editors.GcColorPicker gcColorPicker2;
        private GrapeCity.Win.Editors.DropDownButton dropDownButton1;
        private GrapeCity.Win.Editors.GcSoftKeyboard gcSoftKeyboard1;
        private System.Windows.Forms.Label label4;
        private GrapeCity.Win.Editors.GcNumber gcNumber1;
        private GrapeCity.Win.Editors.GcShortcut gcShortcut1;
        private GrapeCity.Win.Editors.SideButton sideButton1;
        private GrapeCity.Win.Editors.SideButton sideButton2;
    }
}
