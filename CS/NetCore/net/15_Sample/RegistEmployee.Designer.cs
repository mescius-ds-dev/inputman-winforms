namespace InputManWin12_Demo._15_Sample;

partial class RegistEmployee
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
        components = new System.ComponentModel.Container();
        label2 = new System.Windows.Forms.Label();
        gcNumber1 = new GrapeCity.Win.Editors.GcNumber(components);
        gcShortcut1 = new GrapeCity.Win.Editors.GcShortcut(components);
        gcTextBox1 = new GrapeCity.Win.Editors.GcTextBox(components);
        gcTextBox2 = new GrapeCity.Win.Editors.GcTextBox(components);
        gcDate1 = new GrapeCity.Win.Editors.GcDate(components);
        dropDownButton2 = new GrapeCity.Win.Editors.DropDownButton();
        gcMask1 = new GrapeCity.Win.Editors.GcMask(components);
        gcPostal1 = new GrapeCity.Win.Editors.GcPostal(components);
        gcAddressBox1 = new GrapeCity.Win.Editors.GcAddressBox(components);
        gcMask2 = new GrapeCity.Win.Editors.GcMask(components);
        gcComboBox1 = new GrapeCity.Win.Editors.GcComboBox(components);
        dropDownButton3 = new GrapeCity.Win.Editors.DropDownButton();
        gcTextBox3 = new GrapeCity.Win.Editors.GcTextBox(components);
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        gcjpAddress1 = new GrapeCity.Win.JPAddress.GcJPAddress();
        label8 = new System.Windows.Forms.Label();
        label9 = new System.Windows.Forms.Label();
        label10 = new System.Windows.Forms.Label();
        label11 = new System.Windows.Forms.Label();
        button2 = new System.Windows.Forms.Button();
        button1 = new System.Windows.Forms.Button();
        gcCommonValidator1 = new GrapeCity.Win.Editors.GcCommonValidator();
        gcIme1 = new GrapeCity.Win.Editors.GcIme();
        gcAddress1 = new GrapeCity.Win.Editors.GcAddress();
        gcDateValidator1 = new GrapeCity.Win.Editors.GcDateValidator();
        gcCustomValidator1 = new GrapeCity.Win.Editors.GcCustomValidator();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gcNumber1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)gcTextBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)gcTextBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)gcDate1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)gcMask1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)gcPostal1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)gcAddressBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)gcMask2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)gcComboBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)gcTextBox3).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(button1);
        panel1.Controls.Add(button2);
        panel1.Controls.Add(gcTextBox3);
        panel1.Controls.Add(label11);
        panel1.Controls.Add(gcComboBox1);
        panel1.Controls.Add(label10);
        panel1.Controls.Add(gcMask2);
        panel1.Controls.Add(label9);
        panel1.Controls.Add(gcAddressBox1);
        panel1.Controls.Add(label8);
        panel1.Controls.Add(gcPostal1);
        panel1.Controls.Add(label7);
        panel1.Controls.Add(gcMask1);
        panel1.Controls.Add(label6);
        panel1.Controls.Add(gcDate1);
        panel1.Controls.Add(label5);
        panel1.Controls.Add(gcTextBox2);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(gcTextBox1);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(gcNumber1);
        panel1.Controls.Add(label2);
        panel1.Size = new System.Drawing.Size(708, 392);
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new System.Drawing.Point(12, 9);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(68, 18);
        label2.TabIndex = 0;
        label2.Text = "社員番号：";
        // 
        // gcNumber1
        // 
        gcNumber1.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft;
        gcNumber1.Fields.IntegerPart.MinDigits = 1;
        gcNumber1.Location = new System.Drawing.Point(12, 30);
        gcNumber1.Name = "gcNumber1";
        gcShortcut1.SetShortcuts(gcNumber1, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] { System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.Subtract, System.Windows.Forms.Keys.OemMinus, System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Return }, new object[] { gcNumber1, gcNumber1, gcNumber1, gcNumber1 }, new string[] { "SetZero", "SwitchSign", "SwitchSign", "ApplyRecommendedValue" }));
        gcNumber1.Size = new System.Drawing.Size(100, 20);
        gcNumber1.TabIndex = 1;
        // 
        // gcTextBox1
        // 
        gcTextBox1.Location = new System.Drawing.Point(12, 74);
        gcTextBox1.MaxLength = 60;
        gcTextBox1.Name = "gcTextBox1";
        gcShortcut1.SetShortcuts(gcTextBox1, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] { System.Windows.Forms.Keys.F2 }, new object[] { gcTextBox1 }, new string[] { "ShortcutClear" }));
        gcTextBox1.Size = new System.Drawing.Size(170, 20);
        gcTextBox1.TabIndex = 3;
        gcTextBox1.Tag = "";
        // 
        // gcTextBox2
        // 
        gcTextBox2.Location = new System.Drawing.Point(188, 74);
        gcTextBox2.Name = "gcTextBox2";
        gcShortcut1.SetShortcuts(gcTextBox2, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] { System.Windows.Forms.Keys.F2 }, new object[] { gcTextBox2 }, new string[] { "ShortcutClear" }));
        gcTextBox2.Size = new System.Drawing.Size(170, 20);
        gcTextBox2.TabIndex = 5;
        gcTextBox2.Tag = "";
        // 
        // gcDate1
        // 
        gcDate1.Location = new System.Drawing.Point(12, 118);
        gcDate1.Name = "gcDate1";
        gcShortcut1.SetShortcuts(gcDate1, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] { System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.F5, System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Return }, new object[] { gcDate1, gcDate1, gcDate1 }, new string[] { "ShortcutClear", "SetNow", "ApplyRecommendedValue" }));
        gcDate1.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] { dropDownButton2 });
        gcDate1.Size = new System.Drawing.Size(170, 20);
        gcDate1.TabIndex = 7;
        gcDate1.Tag = "";
        gcDate1.Value = new System.DateTime(2023, 6, 21, 0, 0, 0, 0);
        // 
        // dropDownButton2
        // 
        dropDownButton2.Name = "dropDownButton2";
        // 
        // gcMask1
        // 
        gcMask1.Location = new System.Drawing.Point(188, 118);
        gcMask1.Name = "gcMask1";
        gcShortcut1.SetShortcuts(gcMask1, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] { System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Return }, new object[] { gcMask1, gcMask1 }, new string[] { "ShortcutClear", "ApplyRecommendedValue" }));
        gcMask1.Size = new System.Drawing.Size(170, 20);
        gcMask1.TabIndex = 9;
        gcMask1.Tag = "";
        // 
        // gcPostal1
        // 
        gcPostal1.Fields.ZipCodeSeparator.Text = "-";
        gcPostal1.Location = new System.Drawing.Point(12, 162);
        gcPostal1.Name = "gcPostal1";
        gcShortcut1.SetShortcuts(gcPostal1, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] { System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Return }, new object[] { gcPostal1, gcPostal1 }, new string[] { "ShortcutClear", "ApplyRecommendedValue" }));
        gcPostal1.Size = new System.Drawing.Size(170, 20);
        gcPostal1.TabIndex = 11;
        gcPostal1.Tag = "";
        // 
        // gcAddressBox1
        // 
        gcAddressBox1.Location = new System.Drawing.Point(188, 162);
        gcAddressBox1.Name = "gcAddressBox1";
        gcShortcut1.SetShortcuts(gcAddressBox1, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] { System.Windows.Forms.Keys.F2 }, new object[] { gcAddressBox1 }, new string[] { "ShortcutClear" }));
        gcAddressBox1.Size = new System.Drawing.Size(318, 20);
        gcAddressBox1.TabIndex = 13;
        gcAddressBox1.Tag = "";
        // 
        // gcMask2
        // 
        gcMask2.Location = new System.Drawing.Point(12, 206);
        gcMask2.Name = "gcMask2";
        gcShortcut1.SetShortcuts(gcMask2, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] { System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Return }, new object[] { gcMask2, gcMask2 }, new string[] { "ShortcutClear", "ApplyRecommendedValue" }));
        gcMask2.Size = new System.Drawing.Size(170, 20);
        gcMask2.TabIndex = 15;
        gcMask2.Tag = "";
        // 
        // gcComboBox1
        // 
        gcComboBox1.ListHeaderPane.Height = 25;
        gcComboBox1.Location = new System.Drawing.Point(188, 206);
        gcComboBox1.Name = "gcComboBox1";
        gcShortcut1.SetShortcuts(gcComboBox1, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] { System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Return }, new object[] { gcComboBox1, gcComboBox1 }, new string[] { "ShortcutClear", "ApplyRecommendedValue" }));
        gcComboBox1.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] { dropDownButton3 });
        gcComboBox1.Size = new System.Drawing.Size(224, 20);
        gcComboBox1.TabIndex = 17;
        gcComboBox1.Tag = "";
        // 
        // dropDownButton3
        // 
        dropDownButton3.Name = "dropDownButton3";
        // 
        // gcTextBox3
        // 
        gcTextBox3.Location = new System.Drawing.Point(12, 250);
        gcTextBox3.Name = "gcTextBox3";
        gcShortcut1.SetShortcuts(gcTextBox3, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] { System.Windows.Forms.Keys.F2 }, new object[] { gcTextBox3 }, new string[] { "ShortcutClear" }));
        gcTextBox3.Size = new System.Drawing.Size(495, 103);
        gcTextBox3.TabIndex = 19;
        gcTextBox3.Tag = "";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new System.Drawing.Point(12, 53);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(56, 18);
        label3.TabIndex = 2;
        label3.Text = "社員名：";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new System.Drawing.Point(188, 53);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(68, 18);
        label4.TabIndex = 4;
        label4.Text = "フリガナ：";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new System.Drawing.Point(12, 97);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(68, 18);
        label5.TabIndex = 6;
        label5.Text = "生年月日：";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new System.Drawing.Point(188, 97);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(68, 18);
        label6.TabIndex = 8;
        label6.Text = "電話番号：";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new System.Drawing.Point(12, 141);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(68, 18);
        label7.TabIndex = 10;
        label7.Text = "郵便番号：";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new System.Drawing.Point(188, 141);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(44, 18);
        label8.TabIndex = 12;
        label8.Text = "住所：";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new System.Drawing.Point(12, 185);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(44, 18);
        label9.TabIndex = 14;
        label9.Text = "内線：";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new System.Drawing.Point(188, 185);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(56, 18);
        label10.TabIndex = 16;
        label10.Text = "部署名：";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new System.Drawing.Point(12, 229);
        label11.Name = "label11";
        label11.Size = new System.Drawing.Size(56, 18);
        label11.TabIndex = 18;
        label11.Text = "通信欄：";
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(12, 359);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(166, 22);
        button2.TabIndex = 21;
        button2.Text = "クリア";
        button2.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(341, 359);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(166, 22);
        button1.TabIndex = 20;
        button1.Text = "登録";
        button1.UseVisualStyleBackColor = true;
        // 
        // RegistEmployee
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Description = "氏名や住所などの自動入力、フォーカス移動、エラーチェックなどの機能を備えた、社員情報入力画面を作成する方法を紹介します。";
        Name = "RegistEmployee";
        Size = new System.Drawing.Size(800, 503);
        Title = "社員情報入力";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)gcNumber1).EndInit();
        ((System.ComponentModel.ISupportInitialize)gcTextBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)gcTextBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)gcDate1).EndInit();
        ((System.ComponentModel.ISupportInitialize)gcMask1).EndInit();
        ((System.ComponentModel.ISupportInitialize)gcPostal1).EndInit();
        ((System.ComponentModel.ISupportInitialize)gcAddressBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)gcMask2).EndInit();
        ((System.ComponentModel.ISupportInitialize)gcComboBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)gcTextBox3).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private GrapeCity.Win.Editors.GcNumber gcNumber1;
    private GrapeCity.Win.Editors.GcShortcut gcShortcut1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label8;
    private GrapeCity.Win.Editors.GcPostal gcPostal1;
    private System.Windows.Forms.Label label7;
    private GrapeCity.Win.Editors.GcMask gcMask1;
    private System.Windows.Forms.Label label6;
    private GrapeCity.Win.Editors.GcDate gcDate1;
    private GrapeCity.Win.Editors.DropDownButton dropDownButton2;
    private System.Windows.Forms.Label label5;
    private GrapeCity.Win.Editors.GcTextBox gcTextBox2;
    private System.Windows.Forms.Label label4;
    private GrapeCity.Win.Editors.GcTextBox gcTextBox1;
    private System.Windows.Forms.Label label3;
    private GrapeCity.Win.JPAddress.GcJPAddress gcjpAddress1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private GrapeCity.Win.Editors.GcTextBox gcTextBox3;
    private System.Windows.Forms.Label label11;
    private GrapeCity.Win.Editors.GcComboBox gcComboBox1;
    private GrapeCity.Win.Editors.DropDownButton dropDownButton3;
    private System.Windows.Forms.Label label10;
    private GrapeCity.Win.Editors.GcMask gcMask2;
    private System.Windows.Forms.Label label9;
    private GrapeCity.Win.Editors.GcAddressBox gcAddressBox1;
    private GrapeCity.Win.Editors.GcCommonValidator gcCommonValidator1;
    private GrapeCity.Win.Editors.GcIme gcIme1;
    private GrapeCity.Win.Editors.GcAddress gcAddress1;
    private GrapeCity.Win.Editors.GcDateValidator gcDateValidator1;
    private GrapeCity.Win.Editors.GcCustomValidator gcCustomValidator1;
}