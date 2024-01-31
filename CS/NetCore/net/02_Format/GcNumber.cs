using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._02_Format;

public partial class GcNumber : InputManWin12_Demo.DemoBase_settings
{
    public GcNumber()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定
        // 入力書式の設定
        gcTextBox1.TextChanged += (s, e) => SetFormat();
        gcTextBox2.TextChanged += (s, e) => SetFormat();
        gcTextBox3.TextChanged += (s, e) => SetFormat();
        gcTextBox4.TextChanged += (s, e) => SetFormat();
        // 表示書式の設定
        gcTextBox5.TextChanged += (s, e) => SetDisplayFormat();
        gcTextBox6.TextChanged += (s, e) => SetDisplayFormat();
        gcTextBox7.TextChanged += (s, e) => SetDisplayFormat();
        gcTextBox8.TextChanged += (s, e) => SetDisplayFormat();
        gcComboBox1.SelectedIndexChanged += (s, e) => SetFormat();

        // マイナスキー動作の設定
        gcComboBox2.SelectedIndexChanged += (s, e) => SetShortcuts();

        // AcceptsCrLfプロパティ
        gcComboBox3.SelectedIndexChanged += (s, e) => gcNumber1.AcceptsCrLf = (CrLfMode)gcComboBox3.SelectedIndex;

        gcComboBox4.SelectedIndexChanged += (s, e) => SetDisplayFormat();

        // ***** 初期値
        gcComboBox1.SelectedIndex = 0;
        gcComboBox2.SelectedIndex = 0;
        gcComboBox3.SelectedIndex = Convert.ToInt32(gcNumber1.AcceptsCrLf);
        gcComboBox4.SelectedIndex = 0;
    }

    private void SetFormat()
    {
        gcNumber1.Fields.SetFields(gcComboBox1.Text, gcTextBox1.Text, gcTextBox2.Text, gcTextBox3.Text, gcTextBox4.Text);
    }

    private void SetDisplayFormat()
    {
        gcNumber1.DisplayFields.Clear();
        gcNumber1.DisplayFields.AddRange(gcComboBox4.Text, gcTextBox5.Text, gcTextBox6.Text, gcTextBox7.Text, gcTextBox8.Text);
    }

    private void SetShortcuts()
    {
        gcShortcut1.GetShortcuts(gcNumber1).Remove(Keys.OemMinus);
        gcShortcut1.GetShortcuts(gcNumber1).Remove(Keys.Subtract);

        if (gcComboBox2.SelectedIndex == 0)
        {
            gcShortcut1.GetShortcuts(gcNumber1).Add(Keys.OemMinus, gcNumber1, "SwitchSign");
            gcShortcut1.GetShortcuts(gcNumber1).Add(Keys.Subtract, gcNumber1, "SwitchSign");
        }
    }
}
