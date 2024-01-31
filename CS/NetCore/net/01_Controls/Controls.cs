namespace InputManWin12_Demo._01_Controls;
public partial class Controls : InputManWin12_Demo.DemoBase
{
    public Controls()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定

        // xmlファイルからデータ取得（gcMaskedComboBox）
        var filePath = Path.Combine(Application.StartupPath, @"Resources\pref.xml");
        this.dataSet1.ReadXml(filePath);

        gcMaskedComboBox1.DataSource = dataSet1.Tables[0];
        gcMaskedComboBox1.SelectedIndex = -1;

        for (int i = 1; i < gcMaskedComboBox1.ListColumns.Count; i++)
        {
            gcMaskedComboBox1.ListColumns[i].AutoWidth = true;
        }
    }
}
