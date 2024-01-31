namespace InputManWin12_Demo._09_GcComboBox;

public partial class AutoComplete : InputManWin12_Demo.DemoBase_settings
{
    public AutoComplete()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定
        gcComboBox2.SelectedIndexChanged += (s, e) =>
            // 検索モード
            gcComboBox1.AutoComplete.MatchingMode = (GrapeCity.Win.Editors.AutoCompleteMatchingMode)gcComboBox2.SelectedIndex;

        // 検索文字列のフォント
        sideButton1.Click += (s, e) => SetFontHighlightStyle();
        // ハイライト表示
        checkBox1.CheckedChanged += (s, e) => gcComboBox1.AutoComplete.HighlightMatchedText = checkBox1.Checked;

        gcColorPicker1.SelectedIndexChanged += (s, e) =>
            // 検索文字列の前景色
            gcComboBox1.AutoComplete.HighlightStyle.ForeColor = gcColorPicker1.SelectedColor;


        gcColorPicker2.SelectedIndexChanged += (s, e) =>
            // 検索文字列の背景色
            gcComboBox1.AutoComplete.HighlightStyle.BackColor = gcColorPicker2.SelectedColor;

        // 候補リストのフォント
        sideButton2.Click += (s, e) => SetFontCandidateList();

        // xmlファイルからショートカット機能一覧取得
        this.dataSet1.ReadXml(Path.Combine(Application.StartupPath, @"Resources\XMLDataFile.xml"));
        gcComboBox1.DataSource = dataSet1.Tables[0];

        // ***** 初期値
        gcComboBox1.AutoComplete.CandidateListItemFont = gcComboBox1.Font;
        gcComboBox2.SelectedIndex = Convert.ToInt32(gcComboBox1.AutoComplete.MatchingMode);
        for (int i = 1; i < gcComboBox1.ListColumns.Count; i++)
        {
            gcComboBox1.ListColumns[i].Visible = false;
        }

        gcComboBox1.ListColumns[0].Width = gcComboBox1.Width;
        gcComboBox1.DropDown.Direction = GrapeCity.Win.Editors.DropDownDirection.BelowLeft;
    }

    private void SetFontHighlightStyle()
    {
        // 検索文字列のフォント
        var fd = new FontDialog()
        {
            Font = gcComboBox1.AutoComplete.HighlightStyle.Font,
            ShowColor = false
        };

        if (fd.ShowDialog() != DialogResult.Cancel)
        {
            gcComboBox1.AutoComplete.HighlightStyle.Font = fd.Font;
            gcTextBox1.Text = fd.Font.ToString();
        }
    }

    private void SetFontCandidateList()
    {
        // 候補リストのフォント
        var fd = new FontDialog()
        {
            Font = gcComboBox2.AutoComplete.CandidateListItemFont,
            ShowColor = false
        };

        if (fd.ShowDialog() != DialogResult.Cancel)
        {
            gcComboBox1.AutoComplete.CandidateListItemFont = fd.Font;
            gcTextBox2.Text = fd.Font.ToString();
        }
    }
}
