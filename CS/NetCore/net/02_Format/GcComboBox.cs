using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._02_Format;

public partial class GcComboBox : InputManWin12_Demo.DemoBase_settings
{
    public GcComboBox()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定

        gcNumber1.ValueChanged += (s, e) =>
            // MaxLenghtプロパティ
            gcComboBox1.MaxLength = Convert.ToInt32(gcNumber1.Value.GetValueOrDefault());

        gcComboBox2.SelectedIndexChanged += (s, e) =>
            // MaxLengthUnitプロパティ
            gcComboBox1.MaxLengthUnit = (LengthUnit)gcComboBox2.SelectedIndex;

        gcListBox1.ItemCheck += (s, e) =>
            // Formatプロパティ
            gcComboBox1.Format = String.Concat(GetFormatValue(e).ToList());

        checkBox1.CheckedChanged += (s, e) =>
            // AutoConvertプロパティ
            gcComboBox1.AutoConvert = checkBox1.Checked;

        gcComboBox3.SelectedIndexChanged += (s, e) =>
            // AllowSpaceプロパティ
            gcComboBox1.AllowSpace = (AllowSpace)gcComboBox3.SelectedIndex;

        gcComboBox4.SelectedIndexChanged += (s, e) =>
            // AcceptsCrLfプロパティ
            gcComboBox1.AcceptsCrLf = (CrLfMode)gcComboBox4.SelectedIndex;

        gcComboBox5.SelectedIndexChanged += (s, e) =>
            // AcceptsTabCharプロパティ
            gcComboBox1.AcceptsTabChar = (TabCharMode)gcComboBox5.SelectedIndex;

        checkBox2.CheckedChanged += (s, e) =>
        {
            // HighlightTextプロパティ
            gcComboBox1.SelectionLength = 0;
            gcComboBox1.HighlightText = checkBox2.Checked;
        };

        checkBox3.CheckedChanged += (s, e) => gcComboBox1.IsEditable = !checkBox3.Checked;

        // ***** 初期値
        gcNumber1.Value = gcComboBox1.MaxLength;
        gcComboBox2.SelectedIndex = Convert.ToInt32(gcComboBox1.MaxLengthUnit);
        checkBox1.Checked = gcComboBox1.AutoConvert;
        gcComboBox3.SelectedIndex = Convert.ToInt32(gcComboBox1.AllowSpace);
        gcComboBox4.SelectedIndex = Convert.ToInt32(gcComboBox1.AcceptsCrLf);
        gcComboBox5.SelectedIndex = Convert.ToInt32(gcComboBox1.AcceptsTabChar);
        checkBox2.Checked = gcComboBox1.HighlightText;
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
