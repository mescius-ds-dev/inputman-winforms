using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._13_Touch;

public partial class TouchKeyboard : InputManWin12_Demo.DemoBase_settings
{
    public TouchKeyboard()
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

        gcComboBox2.SelectedIndex = 2;
        // InputScopeの設定
        gcComboBox2.SelectedIndexChanged += (s, e) => SetInputScope();
        gcComboBox3.SelectedIndex = 1;
        // AutoHideTouchKeyboardの設定
        gcComboBox3.SelectedIndexChanged += (s, e) => SetAutoHideTouchKeyboard();

        gcTextBox1.GotFocus += (s, e) => ShowTouchKeyboard();
        gcMask1.GotFocus += (s, e) => ShowTouchKeyboard();
        gcCharMask1.GotFocus += (s, e) => ShowTouchKeyboard();
        gcDateTime1.GotFocus += (s, e) => ShowTouchKeyboard();
        gcDate1.GotFocus += (s, e) => ShowTouchKeyboard();
        gcTime1.GotFocus += (s, e) => ShowTouchKeyboard();
        gcTimeSpan1.GotFocus += (s, e) => ShowTouchKeyboard();
        gcNumber1.GotFocus += (s, e) => ShowTouchKeyboard();
        gcComboBox1.GotFocus += (s, e) => ShowTouchKeyboard();
        gcMaskedComboBox1.GotFocus += (s, e) => ShowTouchKeyboard();

        gcTextBox1.LostFocus += (s, e) => HideTouchKeyboard();
        gcMask1.LostFocus += (s, e) => HideTouchKeyboard();
        gcCharMask1.LostFocus += (s, e) => HideTouchKeyboard();
        gcDateTime1.LostFocus += (s, e) => HideTouchKeyboard();
        gcDate1.LostFocus += (s, e) => HideTouchKeyboard();
        gcTime1.LostFocus += (s, e) => HideTouchKeyboard();
        gcTimeSpan1.LostFocus += (s, e) => HideTouchKeyboard();
        gcNumber1.LostFocus += (s, e) => HideTouchKeyboard();
        gcComboBox1.LostFocus += (s, e) => HideTouchKeyboard();
        gcMaskedComboBox1.LostFocus += (s, e) => HideTouchKeyboard();
    }

    private void ShowTouchKeyboard()
    {
        if (checkBox1.Checked)
        {
            // タッチキーボードを表示
            gcIme1.ShowTouchKeyboard();
        }
    }

    private void HideTouchKeyboard()
    {
        if (checkBox2.Checked)
        {
            // タッチキーボードを表示
            gcIme1.HideTouchKeyboard();
        }
    }

    private void SetInputScope()
    {
        InputScopeNameValue inputScope = (InputScopeNameValue)Enum.Parse(typeof(InputScopeNameValue), gcComboBox2.SelectedItem.Text);
        gcIme1.SetInputScope(gcTextBox1, inputScope);
        gcIme1.SetInputScope(gcMask1, inputScope);
        gcIme1.SetInputScope(gcCharMask1, inputScope);
        gcIme1.SetInputScope(gcDateTime1, inputScope);
        gcIme1.SetInputScope(gcDate1, inputScope);
        gcIme1.SetInputScope(gcTime1, inputScope);
        gcIme1.SetInputScope(gcTimeSpan1, inputScope);
        gcIme1.SetInputScope(gcNumber1, inputScope);
        gcIme1.SetInputScope(gcComboBox1, inputScope);
        gcIme1.SetInputScope(gcMaskedComboBox1, inputScope);
    }

    private void SetAutoHideTouchKeyboard()
    {
        gcTextBox1.DropDown.AutoHideTouchKeyboard = (AutoHideTouchKeyboard)gcComboBox3.SelectedIndex;
        gcDate1.DropDown.AutoHideTouchKeyboard = (AutoHideTouchKeyboard)gcComboBox3.SelectedIndex;
        gcDateTime1.DropDown.AutoHideTouchKeyboard = (AutoHideTouchKeyboard)gcComboBox3.SelectedIndex;
        gcTime1.DropDown.AutoHideTouchKeyboard = (AutoHideTouchKeyboard)gcComboBox3.SelectedIndex;
        gcNumber1.DropDown.AutoHideTouchKeyboard = (AutoHideTouchKeyboard)gcComboBox3.SelectedIndex;
        gcComboBox1.DropDown.AutoHideTouchKeyboard = (AutoHideTouchKeyboard)gcComboBox3.SelectedIndex;
        gcMaskedComboBox1.DropDown.AutoHideTouchKeyboard = (AutoHideTouchKeyboard)gcComboBox3.SelectedIndex;
    }
}
