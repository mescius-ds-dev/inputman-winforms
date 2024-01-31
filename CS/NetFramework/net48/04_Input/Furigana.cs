using System;
using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._04_Input
{
    public partial class Furigana : InputManWin12_Demo.DemoBase_settings
    {
        public Furigana()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            gcComboBox1.SelectedIndexChanged += new EventHandler(gcComboBox1_SelectedIndexChanged);
            gcComboBox2.SelectedIndexChanged += new EventHandler(gcComboBox2_SelectedIndexChanged);
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);

            // ***** 初期値
            gcComboBox1.SelectedIndex = Convert.ToInt32(gcIme1.GetReadingStringOutput(gcTextBox1).OutputMode);
            gcComboBox2.SelectedIndex = Convert.ToInt32(gcIme1.GetKanaMode(gcTextBox1));
            checkBox1.Checked = gcIme1.GetReadingStringOutput(gcTextBox1).EnableAlphabetReadingMapping;
        }

        private void gcComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 出力するカナの出力方法とアルファベットの出力の有無
            gcIme1.SetReadingStringOutput(gcTextBox1, new ReadingStringOutput(gcTextBox2, (ReadingStringOutputMode)gcComboBox1.SelectedIndex,checkBox1.Checked));
        }

        private void gcComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 出力するカナの文字種
            gcIme1.SetKanaMode(gcTextBox1, (KanaMode)gcComboBox2.SelectedIndex);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // 出力するカナの出力方法とアルファベットの出力の有無
            gcIme1.SetReadingStringOutput(gcTextBox1, new ReadingStringOutput(gcTextBox2, (ReadingStringOutputMode)gcComboBox1.SelectedIndex, checkBox1.Checked));
        }
    }
}
