using System;
using System.Windows.Forms;
using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._12_Address
{
    public partial class GcPostal : InputManWin12_Demo.DemoBase_settings
    {
        public GcPostal()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            gcPostal1.TextChanged += new EventHandler(gcPostal1_TextChanged);
            gcComboBox1.SelectedIndexChanged += new EventHandler(gcComboBox1_SelectedIndexChanged);
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            checkBox2.CheckedChanged += new EventHandler(checkBox2_CheckedChanged);
            checkBox3.CheckedChanged += new EventHandler(checkBox3_CheckedChanged);
            checkBox4.CheckedChanged += new EventHandler(checkBox4_CheckedChanged);
            sideButton1.Click += new EventHandler(sideButton1_Click);
            gcColorPicker1.SelectedIndexChanged += new EventHandler(gcColorPicker1_SelectedIndexChanged);
            gcColorPicker2.SelectedIndexChanged += new EventHandler(gcColorPicker2_SelectedIndexChanged);
            sideButton2.Click += new EventHandler(sideButton2_Click);

            // ***** 初期値
            gcComboBox1.SelectedIndex = ((Int32)gcPostal1.QueryMode) - 1;
            checkBox1.Checked = gcPostal1.SplitAreaDetails;
            checkBox2.Enabled = false;
        }

        private void gcPostal1_TextChanged(object sender, EventArgs e)
        {
            gcListBox1.DataSource = gcPostal1.Addresses;
        }

        private void gcComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // QueryModeプロパティ
            gcPostal1.QueryMode = (ZipCodeQueryMode)gcComboBox1.SelectedIndex + 1;

            if (gcComboBox1.SelectedIndex == 1 || gcComboBox1.SelectedIndex == 2)
            {
                checkBox2.Enabled = true;
                checkBox2.Checked = gcPostal1.GenerateCompanyAddressKana;
            }
            else
            {
                checkBox2.Enabled = false;
            }

            gcPostal1.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string val = gcPostal1.Value;

            // SplitAreaDetailsプロパティ
            gcPostal1.SplitAreaDetails = checkBox1.Checked;

            gcPostal1.Clear();
            gcPostal1.Value = val;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string val = gcPostal1.Value;

            // GenerateCompanyAddressKanaプロパティ
            gcPostal1.GenerateCompanyAddressKana = checkBox2.Checked;

            gcPostal1.Clear();
            gcPostal1.Value = val;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            string val = gcPostal1.Value;

            // AutoCompleteModeプロパティ
            if (checkBox3.Checked)
            {
                gcPostal1.AutoCompleteMode = AutoCompleteMode.Suggest;
            }
            else
            {
                gcPostal1.AutoCompleteMode = AutoCompleteMode.None;
            }

            gcPostal1.Clear();
            gcPostal1.Value = val;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            // ハイライト表示
            gcPostal1.AutoComplete.HighlightMatchedText = checkBox4.Checked;
        }

        private void sideButton1_Click(object sender, EventArgs e)
        {
            // 検索文字列のフォント
            FontDialog fd = new FontDialog();

            fd.Font = gcPostal1.AutoComplete.HighlightStyle.Font;
            fd.ShowColor = false;

            if (fd.ShowDialog() != DialogResult.Cancel)
            {
                gcPostal1.AutoComplete.HighlightStyle.Font = fd.Font;
                gcTextBox1.Text = fd.Font.ToString();
            }
        }

        private void gcColorPicker1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 検索文字列の前景色
            gcPostal1.AutoComplete.HighlightStyle.ForeColor = gcColorPicker1.SelectedColor;
        }

        private void gcColorPicker2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 検索文字列の背景色
            gcPostal1.AutoComplete.HighlightStyle.BackColor = gcColorPicker2.SelectedColor;
        }

        private void sideButton2_Click(object sender, EventArgs e)
        {
            // 候補リストのフォント
            FontDialog fd = new FontDialog();

            fd.Font = gcPostal1.AutoComplete.CandidateListItemFont;
            fd.ShowColor = false;

            if (fd.ShowDialog() != DialogResult.Cancel)
            {
                gcPostal1.AutoComplete.CandidateListItemFont = fd.Font;
                gcTextBox2.Text = fd.Font.ToString();
            }
        }
    }
}