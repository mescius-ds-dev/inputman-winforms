namespace InputManWin12_Demo._13_Touch;

public partial class ContextMenuScale : InputManWin12_Demo.DemoBase_settings
{
    public ContextMenuScale()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // xmlファイルからデータ取得
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

        // TouchContextMenuScaleプロパティ
        gcNumber2.ValueChanged += (s, e) => SetTouchContextMenuScale();
    }

    private void SetTouchContextMenuScale()
    {
        gcTextBox1.TouchContextMenuScale = (float)gcNumber2.Value.GetValueOrDefault();
        gcMask1.TouchContextMenuScale = (float)gcNumber2.Value.GetValueOrDefault();
        gcCharMask1.TouchContextMenuScale = (float)gcNumber2.Value.GetValueOrDefault();
        gcDateTime1.TouchContextMenuScale = (float)gcNumber2.Value.GetValueOrDefault();
        gcDate1.TouchContextMenuScale = (float)gcNumber2.Value.GetValueOrDefault();
        gcTime1.TouchContextMenuScale = (float)gcNumber2.Value.GetValueOrDefault();
        gcTimeSpan1.TouchContextMenuScale = (float)gcNumber2.Value.GetValueOrDefault();
        gcNumber1.TouchContextMenuScale = (float)gcNumber2.Value.GetValueOrDefault();
        gcComboBox1.TouchContextMenuScale = (float)gcNumber2.Value.GetValueOrDefault();
        gcMaskedComboBox1.TouchContextMenuScale = (float)gcNumber2.Value.GetValueOrDefault();
    }
}
