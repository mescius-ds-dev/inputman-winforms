using GrapeCity.Win.Editors;
using System.Text;

namespace InputManWin12_Demo._09_GcComboBox;

public partial class AutoFilter : InputManWin12_Demo.DemoBase_settings
{
    public AutoFilter()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定

        // AutoFilterプロパティ
        checkBox1.CheckedChanged += (s, e) => gcComboBox1.AutoFilter.Enabled = checkBox1.Checked;

        // AutoSelectプロパティ
        checkBox2.CheckedChanged += (s, e) => gcComboBox1.AutoSelect = checkBox2.Checked;

        // Intervalプロパティ
        gcNumber1.ValueChanged += (s, e) => SetInterval();

        // MaxFilteredItemsプロパティ
        gcNumber2.ValueChanged += (s, e) => SetMaxFilteredItems();

        // MinimumPrefixLengthプロパティ
        gcNumber3.ValueChanged += (s, e) => SetMinimumPrefixLength();

        gcComboBox2.SelectedIndexChanged += (s, e) =>
            // MatchingModeプロパティ
            gcComboBox1.AutoFilter.MatchingMode = (AutoCompleteMatchingMode)gcComboBox2.SelectedIndex;

        gcComboBox3.SelectedIndexChanged += (s, e) =>
            // MatchingSourceプロパティ
            gcComboBox1.AutoFilter.MatchingSource = (FilterMatchingSource)gcComboBox3.SelectedIndex;

        checkBox3.CheckedChanged += (s, e) => SetExtractedItemsIndicesChanged();

        // xmlファイルからショートカット機能一覧取得
        this.dataSet1.ReadXml(Path.Combine(Application.StartupPath, @"Resources\prefecture.xml"));
        gcComboBox1.DataSource = dataSet1.Tables[0];
        gcComboBox1.ListColumns[0].AutoWidth = false;

        // ***** 初期値
        checkBox1.Checked = false;
        checkBox2.Checked = false;
        gcNumber1.Value = gcComboBox1.AutoFilter.Interval;
        gcNumber2.Value = gcComboBox1.AutoFilter.MaxFilteredItems;
        gcNumber3.Value = gcComboBox1.AutoFilter.MinimumPrefixLength;
        gcComboBox2.SelectedIndex = Convert.ToInt32(gcComboBox1.AutoFilter.MatchingMode);
        gcComboBox3.SelectedIndex = Convert.ToInt32(gcComboBox1.AutoFilter.MatchingSource);

        for (int i = 1; i < gcComboBox1.ListColumns.Count; i++)
        {
            gcComboBox1.ListColumns[i].AutoWidth = true;
        }
        gcComboBox1.DropDown.Direction = DropDownDirection.BelowLeft;
    }

    private void SetInterval()
    {
        // AutoFilter.Intervalプロパティ
        if (gcNumber1.Value.HasValue)
        {
            gcComboBox1.AutoFilter.Interval = (int)gcNumber1.Value.Value;
        }
        else
        {
            gcNumber1.Value = gcNumber1.MinValue;
            gcComboBox1.AutoFilter.Interval = (int)gcNumber1.Value.Value;
        }
    }

    private void SetMaxFilteredItems()
    {
        // AutoFilter.MaxFilteredItemsプロパティ
        if (gcNumber2.Value.HasValue)
        {
            gcComboBox1.AutoFilter.MaxFilteredItems = (int)gcNumber2.Value.Value;
        }
        else
        {
            gcNumber2.Value = gcNumber2.MinValue;
            gcComboBox1.AutoFilter.MaxFilteredItems = (int)gcNumber2.Value.Value;
        }
    }

    private void SetMinimumPrefixLength()
    {
        // AutoFilter.MinimumPrefixLengthプロパティ
        if (gcNumber3.Value.HasValue)
        {
            if (gcNumber3.Value.Value < 1)
            {
                gcNumber3.Value = gcNumber3.MinValue;
                gcComboBox1.AutoFilter.MinimumPrefixLength = (int)gcNumber3.Value.Value;
            }
            else
            {
                gcComboBox1.AutoFilter.MinimumPrefixLength = (int)gcNumber3.Value.Value;
            }
        }
        else
        {
            gcNumber3.Value = gcNumber3.MinValue;
            gcComboBox1.AutoFilter.MinimumPrefixLength = (int)gcNumber3.Value.Value;
        }
    }

    private void SetExtractedItemsIndicesChanged()
    {
        if (checkBox3.Checked)
        {
            gcComboBox1.ExtractedItemsIndicesChanged += GcComboBox1_ExtractedItemsIndicesChanged;
        }
        else
        {
            gcComboBox1.ExtractedItemsIndicesChanged -= GcComboBox1_ExtractedItemsIndicesChanged;
        }
    }

    private void GcComboBox1_ExtractedItemsIndicesChanged(object sender, EventArgs e)
    {
        var builder = new StringBuilder();
        builder.Append(gcComboBox1.Items.Count);
        builder.Append("件中");
        builder.Append(gcComboBox1.ExtractedItemsIndices.Count);
        builder.Append("件表示");
        builder.Append("\r\n表示中の項目のインデックス：");
        builder.Append(String.Join(",", gcComboBox1.ExtractedItemsIndices.ToArray()));

        MessageBox.Show(builder.ToString());
    }
}
