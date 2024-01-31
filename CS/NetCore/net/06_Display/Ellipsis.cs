namespace InputManWin12_Demo._06_Display;

public partial class Ellipsis : InputManWin12_Demo.DemoBase_settings
{
    public Ellipsis()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定

        // Ellipsisプロパティ
        gcComboBox1.SelectedIndexChanged += (s, e) => SetEllipsis();

        // EllipsisStringプロパティ
        gcTextBox2.TextChanged += (s, e) => SetEllipsisString();

        // ヘッダの省略文字
        checkBox1.CheckedChanged += (s, e) => SetListColumnsEllipsis();

        // リストの省略文字
        checkBox2.CheckedChanged += (s, e) => SetListItemsEllipsis();

        // ***** 初期値
        gcComboBox1.SelectedIndex = Convert.ToInt32(gcTextBox1.Ellipsis);
        gcTextBox2.Text = gcTextBox1.EllipsisString;
        checkBox1.Checked = gcComboBox2.ListColumns[0].Header.Ellipsis;

        gcComboBox2.ShowOverflowTip = false;
        gcComboBox2.DropDown.Width = gcComboBox2.Width;
        gcComboBox2.ListColumns[0].Width = gcComboBox2.Width;
    }

    private void SetEllipsis()
    {
        gcTextBox1.Ellipsis = (GrapeCity.Win.Editors.EllipsisMode)gcComboBox1.SelectedIndex;
        gcTextBox3.Ellipsis = (GrapeCity.Win.Editors.EllipsisMode)gcComboBox1.SelectedIndex;
        gcComboBox2.Ellipsis = (GrapeCity.Win.Editors.EllipsisMode)gcComboBox1.SelectedIndex;
    }

    private void SetEllipsisString()
    {

        gcTextBox1.EllipsisString = gcTextBox2.Text;
        gcTextBox3.EllipsisString = gcTextBox2.Text;
        gcComboBox2.EllipsisString = gcTextBox2.Text;
    }

    private void SetListColumnsEllipsis()
    {
        gcComboBox2.ListColumns[0].Header.Ellipsis = checkBox1.Checked;
    }

    private void SetListItemsEllipsis()
    {
        for (int i = 0; i < gcComboBox2.Items.Count; i++)
        {
            gcComboBox2.Items[i].SubItems[0].Ellipsis = checkBox2.Checked;
        }
    }
}
