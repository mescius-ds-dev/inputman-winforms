using System;
using GrapeCity.Win.Editors;
using GrapeCity.Win.Editors.Fields;

namespace InputManWin12_Demo._02_Format
{
    public partial class GcMask : InputManWin12_Demo.DemoBase_settings
    {
        public GcMask()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            gcComboBox1.SelectedIndexChanged += new EventHandler(gcComboBox1_SelectedIndexChanged);
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            gcComboBox2.SelectedIndexChanged += new EventHandler(gcComboBox2_SelectedIndexChanged);
            gcComboBox3.SelectedIndexChanged += new EventHandler(gcComboBox3_SelectedIndexChanged);
            radioButton1.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(radioButton2_CheckedChanged);
            gcListBox1.SelectedIndexChanged += new EventHandler(gcListBox1_SelectedIndexChanged);
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
            gcListBox2.SelectedIndexChanged += new EventHandler(gcListBox2_SelectedIndexChanged);
            button3.Click += new EventHandler(button3_Click);
            button4.Click += new EventHandler(button4_Click);

            // ***** 初期設定
            radioButton1.Checked = true;
            gcComboBox1.SelectedIndex = 0;
            checkBox1.Checked = gcMask1.AutoConvert;
            gcComboBox2.SelectedIndex = Convert.ToInt32(gcMask1.AcceptsCrLf);
            gcComboBox3.SelectedIndex = Convert.ToInt32(gcMask1.AcceptsTabChar);
        }

        private void gcComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 正規表現による書式設定
            gcMask1.Fields.Clear();
            gcMask1.Fields.AddRange(gcComboBox1.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // AutoConvertプロパティ
            gcMask1.AutoConvert = checkBox1.Checked;
        }

        private void gcComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // AcceptsCrLfプロパティ
            gcMask1.AcceptsCrLf = (CrLfMode)gcComboBox2.SelectedIndex;
        }

        private void gcComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // AcceptsTabCharプロパティ
            gcMask1.AcceptsTabChar = (TabCharMode)gcComboBox3.SelectedIndex;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // 正規表現による書式設定
                gcMask1.Fields.Clear();
                gcMask1.Fields.AddRange(gcComboBox1.Text);

                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
            }
            else
            {
                // 列挙型フィールドの設定
                setEnumField();

                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // 列挙型フィールドの設定
            setEnumField();
        }

        private void gcListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 列挙型フィールドの追加（職種）
            if (gcListBox1.SelectedIndex > -1)
            {
                gcTextBox1.Text = gcListBox1.Items[gcListBox1.SelectedIndex].Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 列挙型フィールドの追加（職種）
            if (gcTextBox1.TextLength > 0)
            {
                gcListBox1.Items.Add(gcTextBox1.Text);
                setEnumField();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 列挙型フィールドの削除（職種）
            if (gcListBox1.FindStringExact(gcTextBox1.Text, -1, 0) > -1)
            {
                gcListBox1.Items.RemoveAt(gcListBox1.FindStringExact(gcTextBox1.Text, -1, 0));
                setEnumField();
                gcTextBox1.Clear();
            }
        }

        private void gcListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 列挙型フィールドの追加（役職）
            if (gcListBox2.SelectedIndex > -1)
            {
                gcTextBox2.Text = gcListBox2.Items[gcListBox2.SelectedIndex].Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 列挙型フィールドの追加（役職）
            if (gcTextBox2.TextLength > 0)
            {
                gcListBox2.Items.Add(gcTextBox2.Text);
                setEnumField();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 列挙型フィールドの削除（役職）
            if (gcListBox2.FindStringExact(gcTextBox2.Text, -1, 0) > -1)
            {
                gcListBox2.Items.RemoveAt(gcListBox2.FindStringExact(gcTextBox2.Text, -1, 0));
                setEnumField();
                gcTextBox2.Clear();
            }
        }

        private void setEnumField()
        {
            gcMask1.Fields.Clear();

            string[] item0 = new string[gcListBox1.Items.Count];
            for (Int32 i = 0; i < gcListBox1.Items.Count; i++)
            {
                item0[i] = gcListBox1.Items[i].Text;
            }

            string[] item1 = new string[gcListBox2.Items.Count];
            for (Int32 i = 0; i < gcListBox2.Items.Count; i++)
            {
                item1[i] = gcListBox2.Items[i].Text;
            }

            MaskLiteralField mlf0 = new MaskLiteralField("職種：");
            MaskLiteralField mlf1 = new MaskLiteralField(" 役職：");
            MaskEnumerationField mef0 = new MaskEnumerationField();
            MaskEnumerationField mef1 = new MaskEnumerationField();
            gcMask1.Fields.AddRange(new MaskField[] { mlf0, mef0, mlf1, mef1 });
            if (item0.Length == 0)
            {
                mef0.Items = new string[] { " " };
            }
            else
            {
                mef0.Items = item0;
            }
            if (item1.Length == 0)
            {
                mef1.Items = new string[] { " " };
            }
            else
            {
                mef1.Items = item1;
            }

            mef0.AutoDropDown = true;
            mef0.DropDownEnabled = true;
            mef1.AutoDropDown = true;
            mef1.DropDownEnabled = true;
        }
    }
}