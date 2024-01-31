using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._03_Focus;

public partial class Tab : InputManWin12_Demo.DemoBase_settings
{
    public Tab()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定
        gcComboBox1.SelectedIndexChanged += (s, e) =>
            // AcceptsTabプロパティ
            gcTextBox1.AcceptsTab = gcComboBox1.SelectedIndex == 0;

        // TabActionプロパティ
        gcComboBox2.SelectedIndexChanged += (s, e) => SetTabAction();

        // ***** 初期値
        gcComboBox1.SelectedIndex = gcTextBox1.AcceptsTab ? 0 : 1;
        gcComboBox2.SelectedIndex = Convert.ToInt32(gcMask1.TabAction);

        // xmlファイルからデータ取得（gcMaskedComboBox）
        this.dataSet1.ReadXml(Path.Combine(Application.StartupPath, @"Resources\pref.xml"));
        gcMaskedComboBox1.DataSource = dataSet1.Tables[0];
        gcMaskedComboBox1.SelectedIndex = -1;

        for (int i = 1; i < gcMaskedComboBox1.ListColumns.Count; i++)
        {
            gcMaskedComboBox1.ListColumns[i].AutoWidth = true;
        }
    }

    private void SetTabAction()
    {
        // TabActionプロパティ
        gcMask1.TabAction = (TabAction)gcComboBox2.SelectedIndex;
        gcDateTime1.TabAction = (TabAction)gcComboBox2.SelectedIndex;
        gcDate1.TabAction = (TabAction)gcComboBox2.SelectedIndex;
        gcTime1.TabAction = (TabAction)gcComboBox2.SelectedIndex;
        gcTimeSpan1.TabAction = (TabAction)gcComboBox2.SelectedIndex;
        gcMaskedComboBox1.TabAction = (TabAction)gcComboBox2.SelectedIndex;
    }
}