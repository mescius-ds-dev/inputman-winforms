namespace InputManWin12_Demo._08_SideButton;

public partial class SymbolButton : InputManWin12_Demo.DemoBase_settings
{
    public SymbolButton()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        //// ***** 初期設定

        //  ボタンに表示するイメージ
        gcComboBox2.SelectedIndexChanged += (s, e) => SetSymbolButton();

        //  シンボルの表示方向
        gcComboBox3.SelectedIndexChanged += (s, e) => SetSymbolDirection();

        symbolButton1.Click += (s, e) => gcTextBox1.Clear();
        symbolButton2.Click += (s, e) => gcMask1.Value = "99999999999";
        symbolButton3.Click += (s, e) => gcDateTime1.DroppedDown = !gcDateTime1.DroppedDown;
        symbolButton4.Click += (s, e) => gcDate1.DroppedDown = !gcDate1.DroppedDown;
        symbolButton5.Click += (s, e) => gcTime1.Value = DateTime.Now.TimeOfDay;
        symbolButton6.Click += (s, e) => gcTimeSpan1.Clear();
        symbolButton7.Click += (s, e) => gcNumber1.Value = 999;
        symbolButton8.Click += (s, e) => gcComboBox1.DroppedDown = !gcComboBox1.DroppedDown;
        symbolButton9.Click += (s, e) => gcMaskedComboBox1.DroppedDown = !gcComboBox1.DroppedDown;

        // ***** 初期値
        gcComboBox2.SelectedIndex = Convert.ToInt32(((GrapeCity.Win.Editors.SymbolButton)gcTextBox1.SideButtons[0]).Symbol) + 1;
        gcComboBox3.SelectedIndex = Convert.ToInt32(((GrapeCity.Win.Editors.SymbolButton)gcTextBox1.SideButtons[0]).SymbolDirection);

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

    }

    private void SetSymbolButton()
    {
        ((GrapeCity.Win.Editors.SymbolButton)gcTextBox1.SideButtons[0]).Symbol = (GrapeCity.Win.Editors.Symbols)gcComboBox2.SelectedIndex - 1;
        ((GrapeCity.Win.Editors.SymbolButton)gcMask1.SideButtons[0]).Symbol = (GrapeCity.Win.Editors.Symbols)gcComboBox2.SelectedIndex - 1;
        ((GrapeCity.Win.Editors.SymbolButton)gcDateTime1.SideButtons[0]).Symbol = (GrapeCity.Win.Editors.Symbols)gcComboBox2.SelectedIndex - 1;
        ((GrapeCity.Win.Editors.SymbolButton)gcDate1.SideButtons[0]).Symbol = (GrapeCity.Win.Editors.Symbols)gcComboBox2.SelectedIndex - 1;
        ((GrapeCity.Win.Editors.SymbolButton)gcTime1.SideButtons[0]).Symbol = (GrapeCity.Win.Editors.Symbols)gcComboBox2.SelectedIndex - 1;
        ((GrapeCity.Win.Editors.SymbolButton)gcTimeSpan1.SideButtons[0]).Symbol = (GrapeCity.Win.Editors.Symbols)gcComboBox2.SelectedIndex - 1;
        ((GrapeCity.Win.Editors.SymbolButton)gcNumber1.SideButtons[0]).Symbol = (GrapeCity.Win.Editors.Symbols)gcComboBox2.SelectedIndex - 1;
        ((GrapeCity.Win.Editors.SymbolButton)gcComboBox1.SideButtons[0]).Symbol = (GrapeCity.Win.Editors.Symbols)gcComboBox2.SelectedIndex - 1;
        ((GrapeCity.Win.Editors.SymbolButton)gcMaskedComboBox1.SideButtons[0]).Symbol = (GrapeCity.Win.Editors.Symbols)gcComboBox2.SelectedIndex - 1;
    }

    private void SetSymbolDirection()
    {
        ((GrapeCity.Win.Editors.SymbolButton)gcTextBox1.SideButtons[0]).SymbolDirection = (GrapeCity.Win.Editors.SymbolDirection)gcComboBox3.SelectedIndex;
        ((GrapeCity.Win.Editors.SymbolButton)gcMask1.SideButtons[0]).SymbolDirection = (GrapeCity.Win.Editors.SymbolDirection)gcComboBox3.SelectedIndex;
        ((GrapeCity.Win.Editors.SymbolButton)gcDateTime1.SideButtons[0]).SymbolDirection = (GrapeCity.Win.Editors.SymbolDirection)gcComboBox3.SelectedIndex;
        ((GrapeCity.Win.Editors.SymbolButton)gcDate1.SideButtons[0]).SymbolDirection = (GrapeCity.Win.Editors.SymbolDirection)gcComboBox3.SelectedIndex;
        ((GrapeCity.Win.Editors.SymbolButton)gcTime1.SideButtons[0]).SymbolDirection = (GrapeCity.Win.Editors.SymbolDirection)gcComboBox3.SelectedIndex;
        ((GrapeCity.Win.Editors.SymbolButton)gcTimeSpan1.SideButtons[0]).SymbolDirection = (GrapeCity.Win.Editors.SymbolDirection)gcComboBox3.SelectedIndex;
        ((GrapeCity.Win.Editors.SymbolButton)gcNumber1.SideButtons[0]).SymbolDirection = (GrapeCity.Win.Editors.SymbolDirection)gcComboBox3.SelectedIndex;
        ((GrapeCity.Win.Editors.SymbolButton)gcComboBox1.SideButtons[0]).SymbolDirection = (GrapeCity.Win.Editors.SymbolDirection)gcComboBox3.SelectedIndex;
        ((GrapeCity.Win.Editors.SymbolButton)gcMaskedComboBox1.SideButtons[0]).SymbolDirection = (GrapeCity.Win.Editors.SymbolDirection)gcComboBox3.SelectedIndex;
    }
}
