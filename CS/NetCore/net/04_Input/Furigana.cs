using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._04_Input;

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

        // 出力するカナの出力方法とアルファベットの出力の有無
        gcComboBox1.SelectedIndexChanged += (s, e) =>
            gcIme1.SetReadingStringOutput(
                gcTextBox1,
                new ReadingStringOutput(
                    gcTextBox2,
                    (ReadingStringOutputMode)gcComboBox1.SelectedIndex,
                    checkBox1.Checked));

        // 出力するカナの文字種
        gcComboBox2.SelectedIndexChanged += (s, e) =>
            gcIme1.SetKanaMode(gcTextBox1, (KanaMode)gcComboBox2.SelectedIndex);

        // 出力するカナの出力方法とアルファベットの出力の有無
        checkBox1.CheckedChanged += (s, e) =>
            gcIme1.SetReadingStringOutput(
                gcTextBox1,
                new ReadingStringOutput(
                    gcTextBox2,
                    (ReadingStringOutputMode)gcComboBox1.SelectedIndex,
                    checkBox1.Checked));

        // ***** 初期値
        gcComboBox1.SelectedIndex = Convert.ToInt32(gcIme1.GetReadingStringOutput(gcTextBox1).OutputMode);
        gcComboBox2.SelectedIndex = Convert.ToInt32(gcIme1.GetKanaMode(gcTextBox1));
        checkBox1.Checked = gcIme1.GetReadingStringOutput(gcTextBox1).EnableAlphabetReadingMapping;
    }
}
