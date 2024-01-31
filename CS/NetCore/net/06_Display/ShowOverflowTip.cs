namespace InputManWin12_Demo._06_Display;

public partial class ShowOverflowTip : InputManWin12_Demo.DemoBase_settings
{
    public ShowOverflowTip()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定

        // ShowOverflowTipプロパティ
        checkBox1.CheckedChanged += (s, e) => SetShowOverflowTip();
        gcComboBox1.ListColumns[0].Width = gcComboBox1.Width;

        // ***** 初期値
        checkBox1.Checked = true;
        gcComboBox1.DropDown.AllowResize = false;
    }

    private void SetShowOverflowTip()
    {
        gcTextBox1.ShowOverflowTip = checkBox1.Checked;
        gcComboBox1.ShowOverflowTip = checkBox1.Checked;
        gcListBox1.ShowOverflowTip = checkBox1.Checked;
    }
}
