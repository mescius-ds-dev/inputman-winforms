using System;
using System.Windows.Forms;

namespace InputManWin12_Demo._09_GcComboBox
{
    public partial class AutoComplete : InputManWin12_Demo.DemoBase_settings
    {
        public AutoComplete()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            gcComboBox2.SelectedIndexChanged += new EventHandler(gcComboBox2_SelectedIndexChanged);
            sideButton1.Click += new EventHandler(sideButton1_Click);
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            gcColorPicker1.SelectedIndexChanged += new EventHandler(gcColorPicker1_SelectedIndexChanged);
            gcColorPicker2.SelectedIndexChanged += new EventHandler(gcColorPicker2_SelectedIndexChanged);
            sideButton2.Click += new EventHandler(sideButton2_Click);

            // xmlファイルからショートカット機能一覧取得
            System.String filePath = Application.StartupPath;
            this.dataSet1.ReadXml(filePath + "\\Resources\\XMLDataFile.xml");
            gcComboBox1.DataSource = dataSet1.Tables[0];

            // ***** 初期値
            gcComboBox1.AutoComplete.CandidateListItemFont = gcComboBox1.Font;
            gcComboBox2.SelectedIndex = Convert.ToInt32(gcComboBox1.AutoComplete.MatchingMode);
            for (int i = 1; i < gcComboBox1.ListColumns.Count; i++)
            {
                gcComboBox1.ListColumns[i].Visible = false;
            }

            gcComboBox1.ListColumns[0].Width = gcComboBox1.Width;
            gcComboBox1.DropDown.Direction = GrapeCity.Win.Editors.DropDownDirection.BelowLeft;
        }

        private void gcComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 検索モード
            gcComboBox1.AutoComplete.MatchingMode = (GrapeCity.Win.Editors.AutoCompleteMatchingMode)gcComboBox2.SelectedIndex;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // ハイライト表示
            gcComboBox1.AutoComplete.HighlightMatchedText = checkBox1.Checked;
        }

        private void sideButton1_Click(object sender, EventArgs e)
        {
            // 検索文字列のフォント
            FontDialog fd = new FontDialog();

            fd.Font = gcComboBox1.AutoComplete.HighlightStyle.Font;
            fd.ShowColor = false;

            if (fd.ShowDialog() != DialogResult.Cancel)
            {
                gcComboBox1.AutoComplete.HighlightStyle.Font = fd.Font;
                gcTextBox1.Text = fd.Font.ToString();
            }
        }

        private void gcColorPicker1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 検索文字列の前景色
            gcComboBox1.AutoComplete.HighlightStyle.ForeColor = gcColorPicker1.SelectedColor;
        }

        private void gcColorPicker2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 検索文字列の背景色
            gcComboBox1.AutoComplete.HighlightStyle.BackColor = gcColorPicker2.SelectedColor;
        }

        private void sideButton2_Click(object sender, EventArgs e)
        {
            // 候補リストのフォント
            FontDialog fd = new FontDialog();

            fd.Font = gcComboBox2.AutoComplete.CandidateListItemFont;
            fd.ShowColor = false;

            if (fd.ShowDialog() != DialogResult.Cancel)
            {
                gcComboBox1.AutoComplete.CandidateListItemFont = fd.Font;
                gcTextBox2.Text = fd.Font.ToString();
            }
        }
    }
}
