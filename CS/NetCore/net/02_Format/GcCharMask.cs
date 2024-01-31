using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._02_Format;

public partial class GcCharMask : InputManWin12_Demo.DemoBase_settings
{
    public GcCharMask()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定
        gcComboBox1.SelectedIndexChanged += (s, e) =>
            // InputDirectionプロパティ
            gcCharMask1.InputDirection = (CharMaskInputDirection)gcComboBox1.SelectedIndex;

        gcComboBox2.SelectedIndexChanged += (s, e) =>
            // EditModeプロパティ
            gcCharMask1.EditMode = (EditMode)gcComboBox2.SelectedIndex;

        gcListBox1.ItemCheck += (s, e) =>
            // Formatプロパティ
            gcCharMask1.Format = String.Concat(GetFormatValue(e).ToList());

        checkBox1.CheckedChanged += (s, e) =>
            // AutoConvertプロパティ
            gcCharMask1.AutoConvert = checkBox1.Checked;

        gcComboBox3.SelectedIndexChanged += (s, e) =>
            // AllowSpaceプロパティ
            gcCharMask1.AllowSpace = (AllowSpace)gcComboBox3.SelectedIndex;

        gcComboBox4.SelectedIndexChanged += (s, e) =>
            // AcceptsCrLfプロパティ
            gcCharMask1.AcceptsCrLf = (CrLfMode)gcComboBox4.SelectedIndex;

        checkBox2.CheckedChanged += (s, e) =>
        {
            // HighlightTextプロパティ
            gcCharMask1.SelectionLength = 0;
            gcCharMask1.HighlightText = checkBox2.Checked;
        };

        // ***** 初期値
        gcComboBox1.SelectedIndex = Convert.ToInt32(gcCharMask1.InputDirection);
        gcComboBox2.SelectedIndex = Convert.ToInt32(gcCharMask1.EditMode);
        checkBox1.Checked = gcCharMask1.AutoConvert;
        gcComboBox3.SelectedIndex = Convert.ToInt32(gcCharMask1.AllowSpace);
        gcComboBox4.SelectedIndex = Convert.ToInt32(gcCharMask1.AcceptsCrLf);
        checkBox2.Checked = gcCharMask1.HighlightText;
    }

    private IEnumerable<string> GetFormatValue(ItemCheckEventArgs e)
    {
        for (var i = 0; i < gcListBox1.Items.Count; i++)
        {
            if (i == e.Index)
            {
                if (e.NewValue != CheckState.Checked) continue;
            }
            else
            {
                if (!gcListBox1.Items[i].Checked) continue;
            }

            yield return gcListBox1.Items[i].Text;
        }
    }
}
