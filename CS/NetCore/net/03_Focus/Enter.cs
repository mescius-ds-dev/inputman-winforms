using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._03_Focus;

public partial class Enter : InputManWin12_Demo.DemoBase_settings
{
    public Enter()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定
        checkBox1.CheckedChanged += (s, e) => SetNextControl();
        checkBox2.CheckedChanged += (s, e) => SetExitOnLastChar();
        checkBox3.CheckedChanged += (s, e) => SetAutoMoveToNextField();
        gcComboBox2.SelectedIndexChanged += (s, e) => SetLeftRight();

        // ***** 初期値
        checkBox1.Checked = true;
        checkBox2.Checked = true;
        checkBox3.Checked = true;
        gcComboBox2.SelectedIndex = 3;

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

    private void SetNextControl()
    {
        // Enterキー動作の設定
        gcShortcut1.GetShortcuts(gcTextBox1).Remove(Keys.Return);
        gcShortcut1.GetShortcuts(gcMask1).Remove(Keys.Return);
        gcShortcut1.GetShortcuts(gcCharMask1).Remove(Keys.Return);
        gcShortcut1.GetShortcuts(gcDateTime1).Remove(Keys.Return);
        gcShortcut1.GetShortcuts(gcDate1).Remove(Keys.Return);
        gcShortcut1.GetShortcuts(gcTime1).Remove(Keys.Return);
        gcShortcut1.GetShortcuts(gcTimeSpan1).Remove(Keys.Return);
        gcShortcut1.GetShortcuts(gcNumber1).Remove(Keys.Return);
        gcShortcut1.GetShortcuts(gcComboBox1).Remove(Keys.Return);
        gcShortcut1.GetShortcuts(gcMaskedComboBox1).Remove(Keys.Return);

        if (checkBox1.Checked)
        {
            gcShortcut1.GetShortcuts(gcTextBox1).Add(Keys.Return, gcShortcut1, "NextControl");
            gcShortcut1.GetShortcuts(gcMask1).Add(Keys.Return, gcShortcut1, "NextControl");
            gcShortcut1.GetShortcuts(gcCharMask1).Add(Keys.Return, gcShortcut1, "NextControl");
            gcShortcut1.GetShortcuts(gcDateTime1).Add(Keys.Return, gcShortcut1, "NextControl");
            gcShortcut1.GetShortcuts(gcDate1).Add(Keys.Return, gcShortcut1, "NextControl");
            gcShortcut1.GetShortcuts(gcTime1).Add(Keys.Return, gcShortcut1, "NextControl");
            gcShortcut1.GetShortcuts(gcTimeSpan1).Add(Keys.Return, gcShortcut1, "NextControl");
            gcShortcut1.GetShortcuts(gcNumber1).Add(Keys.Return, gcShortcut1, "NextControl");
            gcShortcut1.GetShortcuts(gcComboBox1).Add(Keys.Return, gcShortcut1, "NextControl");
            gcShortcut1.GetShortcuts(gcMaskedComboBox1).Add(Keys.Return, gcShortcut1, "NextControl");
        }
    }

    private void SetExitOnLastChar()
    {
        // ExitOnLastCharプロパティ
        gcTextBox1.ExitOnLastChar = checkBox2.Checked;
        gcMask1.ExitOnLastChar = checkBox2.Checked;
        gcCharMask1.ExitOnLastChar = checkBox2.Checked;
        gcDateTime1.ExitOnLastChar = checkBox2.Checked;
        gcDate1.ExitOnLastChar = checkBox2.Checked;
        gcTime1.ExitOnLastChar = checkBox2.Checked;
        gcTimeSpan1.ExitOnLastChar = checkBox2.Checked;
        gcNumber1.ExitOnLastChar = checkBox2.Checked;
        gcComboBox1.ExitOnLastChar = checkBox2.Checked;
        gcMaskedComboBox1.ExitOnLastChar = checkBox2.Checked;
    }

    private void SetLeftRight()
    {
        // ExitOnLeftRightKeyプロパティ
        gcTextBox1.ExitOnLeftRightKey = (ExitOnLeftRightKey)gcComboBox2.SelectedIndex;
        gcMask1.ExitOnLeftRightKey = (ExitOnLeftRightKey)gcComboBox2.SelectedIndex;
        gcCharMask1.ExitOnLeftRightKey = (ExitOnLeftRightKey)gcComboBox2.SelectedIndex;
        gcDateTime1.ExitOnLeftRightKey = (ExitOnLeftRightKey)gcComboBox2.SelectedIndex;
        gcDate1.ExitOnLeftRightKey = (ExitOnLeftRightKey)gcComboBox2.SelectedIndex;
        gcTime1.ExitOnLeftRightKey = (ExitOnLeftRightKey)gcComboBox2.SelectedIndex;
        gcTimeSpan1.ExitOnLeftRightKey = (ExitOnLeftRightKey)gcComboBox2.SelectedIndex;
        gcNumber1.ExitOnLeftRightKey = (ExitOnLeftRightKey)gcComboBox2.SelectedIndex;
        gcComboBox1.ExitOnLeftRightKey = (ExitOnLeftRightKey)gcComboBox2.SelectedIndex;
        gcMaskedComboBox1.ExitOnLeftRightKey = (ExitOnLeftRightKey)gcComboBox2.SelectedIndex;
    }

    private void SetAutoMoveToNextField()
    {
        // AutoMoveToNextFieldプロパティ
        gcMask1.AutoMoveToNextField = checkBox3.Checked;
        gcDateTime1.AutoMoveToNextField = checkBox3.Checked;
        gcDate1.AutoMoveToNextField = checkBox3.Checked;
        gcTime1.AutoMoveToNextField = checkBox3.Checked;
        gcTimeSpan1.AutoMoveToNextField = checkBox3.Checked;
        gcMaskedComboBox1.AutoMoveToNextField = checkBox3.Checked;
    }
}
