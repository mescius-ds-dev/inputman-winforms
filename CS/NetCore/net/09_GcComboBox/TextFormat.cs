using System.ComponentModel;

namespace InputManWin12_Demo._09_GcComboBox;

public partial class TextFormat : InputManWin12_Demo.DemoBase_settings
{
    public TextFormat()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定
        // TextSubItemIndexプロパティ
        gcComboBox2.SelectedIndexChanged += (s, e) => gcComboBox1.TextSubItemIndex = gcComboBox2.SelectedIndex;
        // TextFormatプロパティ
        gcTextBox1.Validating += (s, e) => SetTextFormat(e);

        // xmlファイルからショートカット機能一覧取得
        this.dataSet1.ReadXml(Path.Combine(Application.StartupPath, @"Resources\XMLDataFile.xml"));
        gcComboBox1.DataSource = dataSet1.Tables[0];

        // ***** 初期値
        gcComboBox1.TextFormat = gcTextBox1.Text;

        for (int i = 0; i < gcComboBox1.ListColumns.Count; i++)
        {
            gcComboBox1.ListColumns[i].AutoWidth = true;
            gcComboBox1.ListColumns[i].Header.Image = 0;
        }
        gcComboBox1.DropDown.Direction = GrapeCity.Win.Editors.DropDownDirection.BelowLeft;
    }

    private void SetTextFormat(CancelEventArgs e)
    {
        try
        {
            gcComboBox1.TextFormat = gcTextBox1.Text;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "書式設定エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Cancel = true;
        }
    }
}
