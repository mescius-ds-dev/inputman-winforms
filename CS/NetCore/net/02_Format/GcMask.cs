using GrapeCity.Win.Editors;
using GrapeCity.Win.Editors.Fields;

namespace InputManWin12_Demo._02_Format;

public partial class GcMask : InputManWin12_Demo.DemoBase_settings
{
    public GcMask()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定
        gcComboBox1.SelectedIndexChanged += (s, e) =>
        {
            // 正規表現による書式設定
            gcMask1.Fields.Clear();
            gcMask1.Fields.AddRange(gcComboBox1.Text);
        };

        checkBox1.CheckedChanged += (s, e) =>
            // AutoConvertプロパティ
            gcMask1.AutoConvert = checkBox1.Checked;

        gcComboBox2.SelectedIndexChanged += (s, e) =>
            // AcceptsCrLfプロパティ    
            gcMask1.AcceptsCrLf = (CrLfMode)gcComboBox2.SelectedIndex;

        gcComboBox3.SelectedIndexChanged += (s, e) =>
            // AcceptsTabCharプロパティ
            gcMask1.AcceptsTabChar = (TabCharMode)gcComboBox3.SelectedIndex;

        // 入力書式の設定
        radioButton1.CheckedChanged += (s, e) => SetInputField();

        // 列挙型フィールドの設定
        radioButton2.CheckedChanged += (s, e) => SetEnumField();

        // 列挙型フィールドの追加（職種）
        gcListBox1.SelectedIndexChanged += (s, e) => SetJobEnumFieldText();

        // 列挙型フィールドのアイテム追加（職種）
        button1.Click += (s, e) => AddJobEnumFieldItem();

        // 列挙型フィールドのアイテム削除（職種）
        button2.Click += (s, e) => RemoveJobEnumFieldItem();

        // 列挙型フィールドの追加（役職）
        gcListBox2.SelectedIndexChanged += (s, e) => SetPositionEnumText();

        // 列挙型フィールドのアイテム追加（役職）
        button3.Click += (s, e) => AddPositionEnumItem();

        // 列挙型フィールドのアイテム削除（役職）
        button4.Click += (s, e) => RemovePositionEnumItem();

        // ***** 初期設定
        radioButton1.Checked = true;
        gcComboBox1.SelectedIndex = 0;
        checkBox1.Checked = gcMask1.AutoConvert;
        gcComboBox2.SelectedIndex = Convert.ToInt32(gcMask1.AcceptsCrLf);
        gcComboBox3.SelectedIndex = Convert.ToInt32(gcMask1.AcceptsTabChar);

        gcComboBox1.SelectedIndexChanged += (s, e) =>
        {
            // 正規表現による書式設定
            gcMask1.Fields.Clear();
            gcMask1.Fields.AddRange(gcComboBox1.Text);
        };
    }

    private void SetInputField()
    {
        if (radioButton1.Checked)
        {
            // 正規表現による書式設定
            gcMask1.Fields.Clear();
            gcMask1.Fields.AddRange(gcComboBox1.Text);
        }
        else
        {
            // 列挙型フィールドの設定
            SetEnumField();
        }

        groupBox1.Enabled = radioButton1.Checked;
        groupBox2.Enabled = !radioButton1.Checked;
    }

    private void SetEnumField()
    {
        gcMask1.Fields.Clear();

        gcMask1.Fields.AddRange(
            new MaskField[] {
                new MaskLiteralField("職種：")
                , GetMaskEnumerationField(gcListBox1)
                , new MaskLiteralField(" 役職：")
                , GetMaskEnumerationField(gcListBox2)
            });
    }

    private static MaskEnumerationField GetMaskEnumerationField(GcListBox listBox)
    {
        var items = listBox.Items.ToArray().Select(x => x.Text).ToArray();

        return new MaskEnumerationField()
        {
            AutoDropDown = true
            , DropDownEnabled = true
            , Items = items.Any() ? items : new string[] { " " }
        };
    }

    private void SetJobEnumFieldText()
    {
        if (gcListBox1.SelectedIndex <= -1) return;

        gcTextBox1.Text = gcListBox1.Items[gcListBox1.SelectedIndex].Text;
    }

    private void AddJobEnumFieldItem()
    {

        if (gcTextBox1.TextLength <= 0) return;

        gcListBox1.Items.Add(gcTextBox1.Text);
        SetEnumField();
    }

    private void RemoveJobEnumFieldItem()
    {
        if (gcListBox1.FindStringExact(gcTextBox1.Text, -1, 0) <= -1) return;

        gcListBox1.Items.RemoveAt(gcListBox1.FindStringExact(gcTextBox1.Text, -1, 0));
        SetEnumField();
        gcTextBox1.Clear();
    }

    private void SetPositionEnumText()
    {
        if (gcListBox2.SelectedIndex <= -1) return;

        gcTextBox2.Text = gcListBox2.Items[gcListBox2.SelectedIndex].Text;
    }

    private void AddPositionEnumItem()
    {

        if (gcTextBox2.TextLength <= 0) return;

        gcListBox2.Items.Add(gcTextBox2.Text);
        SetEnumField();
    }

    private void RemovePositionEnumItem()
    {
        if (gcListBox2.FindStringExact(gcTextBox2.Text, -1, 0) <= -1) return;

        gcListBox2.Items.RemoveAt(gcListBox2.FindStringExact(gcTextBox2.Text, -1, 0));
        SetEnumField();
        gcTextBox2.Clear();
    }
}