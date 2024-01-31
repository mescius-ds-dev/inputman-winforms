using System;
using System.Windows.Forms;

namespace InputManWin12_Demo._04_Input
{
    public partial class RecommendedValue : InputManWin12_Demo.DemoBase_settings
    {
        public RecommendedValue()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);

            // ***** 初期値
            checkBox1.Checked = true;

            // xmlファイルからデータ取得
            System.String filePath = Application.StartupPath;
            this.dataSet1.ReadXml(filePath + "\\Resources\\prefecture.xml");
            gcComboBox1.DataSource = dataSet1.Tables[0];
            gcComboBox1.SelectedIndex = -1;

            for (int i = 1; i < gcComboBox1.ListColumns.Count; i++)
            {
                gcComboBox1.ListColumns[i].AutoWidth = true;
            }

            // xmlファイルからデータ取得（gcMaskedComboBox）
            this.dataSet2.ReadXml(filePath + "\\Resources\\pref.xml");
            gcMaskedComboBox1.DataSource = dataSet2.Tables[0];
            gcMaskedComboBox1.SelectedIndex = -1;

            for (int i = 1; i < gcMaskedComboBox1.ListColumns.Count; i++)
            {
                gcMaskedComboBox1.ListColumns[i].AutoWidth = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ApplyRecommendedValueメソッド
            gcTextBox1.Select();
            gcTextBox1.ApplyRecommendedValue();
            gcMask1.ApplyRecommendedValue();
            gcCharMask1.ApplyRecommendedValue();
            gcDateTime1.ApplyRecommendedValue();
            gcDate1.ApplyRecommendedValue();
            gcTime1.ApplyRecommendedValue();
            gcTimeSpan1.ApplyRecommendedValue();
            gcNumber1.Select();
            gcNumber1.ApplyRecommendedValue();
            gcComboBox1.Select();
            gcComboBox1.ApplyRecommendedValue();
            gcMaskedComboBox1.Select();
            gcMaskedComboBox1.ApplyRecommendedValue();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gcTextBox1.Clear();
            gcMask1.Clear();
            gcCharMask1.Clear();
            gcDateTime1.Clear();
            gcDate1.Clear();
            gcTime1.Clear();
            gcTimeSpan1.Clear();
            gcNumber1.Clear();
            gcComboBox1.Clear();
            gcMaskedComboBox1.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // ShowRecommendedValueプロパティ
            gcTextBox1.ShowRecommendedValue = checkBox1.Checked;
            gcMask1.ShowRecommendedValue = checkBox1.Checked;
            gcCharMask1.ShowRecommendedValue = checkBox1.Checked;
            gcDateTime1.ShowRecommendedValue = checkBox1.Checked;
            gcDate1.ShowRecommendedValue = checkBox1.Checked;
            gcTime1.ShowRecommendedValue = checkBox1.Checked;
            gcTimeSpan1.ShowRecommendedValue = checkBox1.Checked;
            gcNumber1.ShowRecommendedValue = checkBox1.Checked;
            gcComboBox1.ShowRecommendedValue = checkBox1.Checked;
            gcMaskedComboBox1.ShowRecommendedValue = checkBox1.Checked;
        }
    }
}
