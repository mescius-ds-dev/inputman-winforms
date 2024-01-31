using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._02_Format;

public partial class GcTextBox : InputManWin12_Demo.DemoBase_settings
{
    public GcTextBox()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定
        gcNumber1.ValueChanged += (s, e) =>
            // MaxLenghtプロパティ
            gcTextBox1.MaxLength = Convert.ToInt32(gcNumber1.Value.GetValueOrDefault());

        gcComboBox1.SelectedIndexChanged += (s, e) =>
            // MaxLengthUnitプロパティ
            gcTextBox1.MaxLengthUnit = (LengthUnit)gcComboBox1.SelectedIndex;

        gcListBox1.ItemCheck += (s, e) =>
            // Formatプロパティ
            gcTextBox1.Format = String.Concat(GetFormatValue(e).ToList());

        checkBox1.CheckedChanged += (s, e) =>
            // AutoConvertプロパティ
            gcTextBox1.AutoConvert = checkBox1.Checked;

        gcComboBox2.SelectedIndexChanged += (s, e) =>
            // AllowSpaceプロパティ
            gcTextBox1.AllowSpace = (AllowSpace)gcComboBox2.SelectedIndex;

        gcComboBox3.SelectedIndexChanged += (s, e) =>
            // AcceptsCrLfプロパティ
            gcTextBox1.AcceptsCrLf = (CrLfMode)gcComboBox3.SelectedIndex;

        gcComboBox4.SelectedIndexChanged += (s, e) =>
            // AcceptsTabCharプロパティ
            gcTextBox1.AcceptsTabChar = (TabCharMode)gcComboBox4.SelectedIndex;

        checkBox2.CheckedChanged += (s, e) =>
        {
            // HighlightTextプロパティ
            gcTextBox1.SelectionLength = 0;
            gcTextBox1.HighlightText = checkBox2.Checked;
        };

        // ***** 初期値
        gcNumber1.Value = gcTextBox1.MaxLength;
        gcComboBox1.SelectedIndex = Convert.ToInt32(gcTextBox1.MaxLengthUnit);
        checkBox1.Checked = gcTextBox1.AutoConvert;
        gcComboBox2.SelectedIndex = Convert.ToInt32(gcTextBox1.AllowSpace);
        gcComboBox3.SelectedIndex = Convert.ToInt32(gcTextBox1.AcceptsCrLf);
        gcComboBox4.SelectedIndex = Convert.ToInt32(gcTextBox1.AcceptsTabChar);
        checkBox2.Checked = gcTextBox1.HighlightText;
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

