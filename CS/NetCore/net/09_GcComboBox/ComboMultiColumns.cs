namespace InputManWin12_Demo._09_GcComboBox;

public partial class ComboMultiColumns : InputManWin12_Demo.DemoBase_settings
{
    public ComboMultiColumns()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定
        // ヘッダの表示／非表示
        checkBox1.CheckedChanged += (s, e) => SetHeaderVisible();

        // ヘッダのリサイズ
        checkBox2.CheckedChanged += (s, e) => SetHeaderResize();

        // ヘッダの画像の表示
        checkBox3.CheckedChanged += (s, e) => SetHeaderImage();

        // AutoWidthプロパティ
        checkBox4.CheckedChanged += (s, e) => gcComboBox1.DropDown.AutoWidth = checkBox4.Checked;

        // TextSubItemIndexプロパティ
        gcComboBox2.SelectedIndexChanged += (s, e) => gcComboBox1.TextSubItemIndex = gcComboBox2.SelectedIndex;

        gcColorPicker1.SelectedIndexChanged += (s, e) =>
            // 選択行の前景色
            gcComboBox1.ListSelectedItemStyle.ForeColor = gcColorPicker1.SelectedColor;

        // 選択行の背景色
        gcColorPicker2.SelectedIndexChanged += (s, e) =>
        gcComboBox1.ListSelectedItemStyle.BackColor = gcColorPicker2.SelectedColor;

        // xmlファイルからショートカット機能一覧取得
        System.String filePath = Application.StartupPath;
        this.dataSet1.ReadXml(filePath + "\\Resources\\XMLDataFile.xml");
        gcComboBox1.DataSource = dataSet1.Tables[0];

        // ***** 初期値
        checkBox1.Checked = gcComboBox1.ListHeaderPane.Visible;
        checkBox2.Checked = gcComboBox1.ListColumns[0].Header.AllowResize;
        checkBox3.Checked = true;
        checkBox4.Checked = gcComboBox1.DropDown.AutoWidth;
        gcComboBox2.SelectedIndex = gcComboBox1.TextSubItemIndex;

        for (int i = 0; i < gcComboBox1.ListColumns.Count; i++)
        {
            gcComboBox1.ListColumns[i].AutoWidth = true;
            gcComboBox1.ListColumns[i].Header.Image = 0;
        }

        gcComboBox1.DropDown.Direction = GrapeCity.Win.Editors.DropDownDirection.BelowLeft;
    }

    private void SetHeaderVisible()
    {
        gcComboBox1.ListHeaderPane.Visible = checkBox1.Checked;
        checkBox2.Enabled = checkBox1.Checked;
        checkBox3.Enabled = checkBox1.Checked;
    }

    private void SetHeaderResize()
    {
        for (int i = 0; i < gcComboBox1.ListColumns.Count; i++)
        {
            gcComboBox1.ListColumns[i].Header.AllowResize = checkBox2.Checked;
        }
    }

    private void SetHeaderImage()
    {
        if (checkBox3.Checked)
        {
            gcComboBox1.ListColumns[0].Header.Image = 4;
            gcComboBox1.ListColumns[1].Header.Image = 2;
            gcComboBox1.ListColumns[2].Header.Image = 1;
            gcComboBox1.ListColumns[3].Header.Image = 1;
            gcComboBox1.ListColumns[4].Header.Image = 3;
            gcComboBox1.ListColumns[5].Header.Image = 0;
        }
        else
        {
            gcComboBox1.ListColumns[0].Header.Image = null;
            gcComboBox1.ListColumns[1].Header.Image = null;
            gcComboBox1.ListColumns[2].Header.Image = null;
            gcComboBox1.ListColumns[3].Header.Image = null;
            gcComboBox1.ListColumns[4].Header.Image = null;
            gcComboBox1.ListColumns[5].Header.Image = null;
        }
    }
}
