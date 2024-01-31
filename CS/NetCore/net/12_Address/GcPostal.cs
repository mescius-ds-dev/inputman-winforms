using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._12_Address;

public partial class GcPostal : InputManWin12_Demo.DemoBase_settings
{
    public GcPostal()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定
        gcPostal1.TextChanged += (s, e) => gcListBox1.DataSource = gcPostal1.Addresses;

        // QueryModeプロパティ
        gcComboBox1.SelectedIndexChanged += (s, e) => SetQueryMode();

        // SetSplitAreaDetailsプロパティ
        checkBox1.CheckedChanged += (s, e) => SetSplitAreaDetails();

        // GenerateCompanyAddressKanaプロパティ
        checkBox2.CheckedChanged += (s, e) => SetGenerateCompanyAddressKana();

        // AutoCompleteModeプロパティ
        checkBox3.CheckedChanged += (s, e) => SetAutoCompleteMode();

        // ハイライト表示
        checkBox4.CheckedChanged += (s, e) => gcPostal1.AutoComplete.HighlightMatchedText = checkBox4.Checked;

        // 検索文字列のフォント
        sideButton1.Click += (s, e) => SetFontSearchString();

        gcColorPicker1.SelectedIndexChanged += (s, e) =>
            // 検索文字列の前景色
            gcPostal1.AutoComplete.HighlightStyle.ForeColor = gcColorPicker1.SelectedColor;

        gcColorPicker2.SelectedIndexChanged += (s, e) =>
            // 検索文字列の背景色
            gcPostal1.AutoComplete.HighlightStyle.BackColor = gcColorPicker2.SelectedColor;

        // 候補リストのフォント
        sideButton2.Click += (s, e) => SetFontCandidateList();

        // ***** 初期値
        gcComboBox1.SelectedIndex = ((Int32)gcPostal1.QueryMode) - 1;
        checkBox1.Checked = gcPostal1.SplitAreaDetails;
        checkBox2.Enabled = false;
    }

    private void SetQueryMode()
    {
        gcPostal1.QueryMode = (ZipCodeQueryMode)gcComboBox1.SelectedIndex + 1;

        if (gcComboBox1.SelectedIndex == 1 || gcComboBox1.SelectedIndex == 2)
        {
            checkBox2.Enabled = true;
            checkBox2.Checked = gcPostal1.GenerateCompanyAddressKana;
        }
        else
        {
            checkBox2.Enabled = false;
        }

        gcPostal1.Clear();
    }

    private void SetSplitAreaDetails()
    {
        var val = gcPostal1.Value;

        gcPostal1.SplitAreaDetails = checkBox1.Checked;

        gcPostal1.Clear();
        gcPostal1.Value = val;
    }

    private void SetGenerateCompanyAddressKana()
    {
        var val = gcPostal1.Value;

        gcPostal1.GenerateCompanyAddressKana = checkBox2.Checked;

        gcPostal1.Clear();
        gcPostal1.Value = val;
    }

    private void SetAutoCompleteMode()
    {
        var val = gcPostal1.Value;

        if (checkBox3.Checked)
        {
            gcPostal1.AutoCompleteMode = AutoCompleteMode.Suggest;
        }
        else
        {
            gcPostal1.AutoCompleteMode = AutoCompleteMode.None;
        }

        gcPostal1.Clear();
        gcPostal1.Value = val;
    }

    private void SetFontSearchString()
    {
        var fd = new FontDialog();

        fd.Font = gcPostal1.AutoComplete.HighlightStyle.Font;
        fd.ShowColor = false;

        if (fd.ShowDialog() != DialogResult.Cancel)
        {
            gcPostal1.AutoComplete.HighlightStyle.Font = fd.Font;
            gcTextBox1.Text = fd.Font.ToString();
        }
    }

    private void SetFontCandidateList()
    {
        var fd = new FontDialog();

        fd.Font = gcPostal1.AutoComplete.CandidateListItemFont;
        fd.ShowColor = false;

        if (fd.ShowDialog() != DialogResult.Cancel)
        {
            gcPostal1.AutoComplete.CandidateListItemFont = fd.Font;
            gcTextBox2.Text = fd.Font.ToString();
        }
    }
}