namespace InputManWin12_Demo._10_GcListBox;

public partial class ListMultiColumns : InputManWin12_Demo.DemoBase_settings
{
    public ListMultiColumns()
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
        checkBox2.CheckedChanged += (s, e) => SetHeaderAllowResize();
        // ヘッダの画像の表示
        checkBox3.CheckedChanged += (s, e) => SetHeaderImage();
        // チェックボックスの表示／非表示
        checkBox4.CheckedChanged += (s, e) => gcListBox1.ShowCheckBox = checkBox4.Checked;
        // 項目の選択状態
        gcComboBox1.SelectedIndexChanged += (s, e) => gcListBox1.SelectionMode = (SelectionMode)gcComboBox1.SelectedIndex;
        // 選択行の前景色
        gcColorPicker1.SelectedIndexChanged += (s, e) => gcListBox1.SelectedItemStyle.ForeColor = gcColorPicker1.SelectedColor;
        // 選択行の背景色
        gcColorPicker2.SelectedIndexChanged += (s, e) => gcListBox1.SelectedItemStyle.BackColor = gcColorPicker2.SelectedColor;

        gcComboBox2.SelectedIndexChanged += (s, e) => gcListBox1.DescriptionFormat = gcComboBox2.SelectedValue.ToString();

        // xmlファイルからショートカット機能一覧取得
        this.dataSet1.ReadXml(Path.Combine(Application.StartupPath, @"Resources\XMLDataFile.xml"));
        gcListBox1.DataSource = dataSet1.Tables[0];

        // ***** 初期値
        checkBox1.Checked = gcListBox1.ListHeaderPane.Visible;
        checkBox2.Checked = gcListBox1.Columns[0].Header.AllowResize;
        checkBox3.Checked = true;
        checkBox4.Checked = gcListBox1.ShowCheckBox;
        gcComboBox1.SelectedIndex = Convert.ToInt32(gcListBox1.SelectionMode);

        for (int i = 0; i < gcListBox1.Columns.Count; i++)
        {
            gcListBox1.Columns[i].AutoWidth = true;
            gcListBox1.Columns[i].Header.Image = 0;
            if (i > 3)
            {
                gcListBox1.Columns[i].Visible = false;
            }
        }

        gcListBox1.StatusBar.Visible = true;
    }

    private void SetHeaderVisible()
    {
        gcListBox1.ListHeaderPane.Visible = checkBox1.Checked;
        checkBox2.Enabled = checkBox1.Checked;
        checkBox3.Enabled = checkBox1.Checked;
    }

    private void SetHeaderAllowResize()
    {
        for (int i = 0; i < gcListBox1.Columns.Count; i++)
        {
            gcListBox1.Columns[i].Header.AllowResize = checkBox2.Checked;
        }
    }

    private void SetHeaderImage()
    {
        if (checkBox3.Checked)
        {
            gcListBox1.Columns[0].Header.Image = 4;
            gcListBox1.Columns[1].Header.Image = 2;
            gcListBox1.Columns[2].Header.Image = 1;
            gcListBox1.Columns[3].Header.Image = 1;
            gcListBox1.Columns[4].Header.Image = 3;
            gcListBox1.Columns[5].Header.Image = 0;
        }
        else
        {
            gcListBox1.Columns[0].Header.Image = null;
            gcListBox1.Columns[1].Header.Image = null;
            gcListBox1.Columns[2].Header.Image = null;
            gcListBox1.Columns[3].Header.Image = null;
            gcListBox1.Columns[4].Header.Image = null;
            gcListBox1.Columns[5].Header.Image = null;
        }
    }
}
