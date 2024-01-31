namespace InputManWin12_Demo._04_Input;

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
        checkBox1.CheckedChanged += (s, e) => SetShowRecommendedValue();
        button1.Click += (s, e) => SetApplyRecommendedValue();
        button2.Click += (s, e) => ClearControls();

        // ***** 初期値
        checkBox1.Checked = true;

        // xmlファイルからデータ取
        this.dataSet1.ReadXml(Path.Combine(Application.StartupPath, @"Resources\prefecture.xml"));
        gcComboBox1.DataSource = dataSet1.Tables[0];
        gcComboBox1.SelectedIndex = -1;

        for (int i = 1; i < gcComboBox1.ListColumns.Count; i++)
        {
            gcComboBox1.ListColumns[i].AutoWidth = true;
        }

        // xmlファイルからデータ取得（gcMaskedComboBox）
        this.dataSet2.ReadXml(Path.Combine(Application.StartupPath, @"Resources\pref.xml"));
        gcMaskedComboBox1.DataSource = dataSet2.Tables[0];
        gcMaskedComboBox1.SelectedIndex = -1;

        for (int i = 1; i < gcMaskedComboBox1.ListColumns.Count; i++)
        {
            gcMaskedComboBox1.ListColumns[i].AutoWidth = true;
        }
    }

    private void SetShowRecommendedValue()
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

    private void SetApplyRecommendedValue()
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

    private void ClearControls()
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
}
