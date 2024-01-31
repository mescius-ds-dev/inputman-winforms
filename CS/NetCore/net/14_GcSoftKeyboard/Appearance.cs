namespace InputManWin12_Demo._14_GcSoftKeyboard;

public partial class Appearance : InputManWin12_Demo.DemoBase_settings
{
    public Appearance()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        button1.Click += (s, e) => gcSoftKeyboard1.Show(textBox1, true);

        // 基底カラーの設定
        gcColorPicker1.SelectedIndexChanged += (s, e) => gcSoftKeyboard1.BaseColor = gcColorPicker1.SelectedColor;

        // 切替キーの色
        gcColorPicker2.SelectedIndexChanged += (s, e) => gcSoftKeyboard1.ToggledButtonBackColor = gcColorPicker2.SelectedColor;

        // キーの境界線
        checkBox1.CheckedChanged += (s, e) => gcSoftKeyboard1.ShowButtonBorder = checkBox1.Checked;

        // 透過率
        gcNumber1.ValueChanged += (s, e) => gcSoftKeyboard1.Opacity = (double)gcNumber1.Value.GetValueOrDefault();
    }
}
