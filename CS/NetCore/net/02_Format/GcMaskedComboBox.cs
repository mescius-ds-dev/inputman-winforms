using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._02_Format;

public partial class GcMaskedComboBox : InputManWin12_Demo.DemoBase_settings
{
    public GcMaskedComboBox()
    {
        InitializeComponent();
        InitializeForm();

    }
    private void InitializeForm()
    {
        // ***** 初期設定
        gcComboBox1.SelectedIndexChanged += (s, e) =>
        {
            // 正規表現による書式設定
            gcMaskedComboBox1.Fields.Clear();
            gcMaskedComboBox1.Fields.AddRange(gcComboBox1.Text);
        };

        checkBox1.CheckedChanged += (s, e) =>
            // AutoConvertプロパティ
            gcMaskedComboBox1.AutoConvert = checkBox1.Checked;


        gcComboBox2.SelectedIndexChanged += (s, e) =>
            // AcceptsCrLfプロパティ
            gcMaskedComboBox1.AcceptsCrLf = (CrLfMode)gcComboBox2.SelectedIndex;


        gcComboBox3.SelectedIndexChanged += (s, e) =>
            // AcceptsTabCharプロパティ
            gcMaskedComboBox1.AcceptsTabChar = (TabCharMode)gcComboBox3.SelectedIndex;

        // ***** 初期設定
        gcComboBox1.SelectedIndex = 0;
        checkBox1.Checked = gcMaskedComboBox1.AutoConvert;
        gcComboBox2.SelectedIndex = Convert.ToInt32(gcMaskedComboBox1.AcceptsCrLf);
        gcComboBox3.SelectedIndex = Convert.ToInt32(gcMaskedComboBox1.AcceptsTabChar);
    }
}