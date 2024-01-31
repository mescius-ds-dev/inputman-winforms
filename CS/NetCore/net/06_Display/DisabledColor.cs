using System.Data;

namespace InputManWin12_Demo._06_Display;

public partial class DisabledColor : InputManWin12_Demo.DemoBase_settings
{
    public DisabledColor()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定

        // ForeColorプロパティ
        gcColorPicker1.SelectedIndexChanged += (s, e) => SetForeColor();
        // BackColorプロパティ
        gcColorPicker2.SelectedValueChanged += (s, e) => SetBackColor();
        // DisabledForeColorプロパティ
        gcColorPicker3.SelectedIndexChanged += (s, e) => SetDisabledForeColor();
        // DisabledBackColorプロパティ
        gcColorPicker4.SelectedIndexChanged += (s, e) => SetDisabledBackColor();
        // ForeColorプロパティ
        gcColorPicker5.SelectedIndexChanged += (s, e) => SetListDisabledForeColor();
        // BackColorプロパティ
        gcColorPicker6.SelectedIndexChanged += (s, e) => SetListDisabledBackColor();
        // Enabledプロパティ
        checkBox1.CheckedChanged += (s, e) => SetEnabled();

        // ***** 初期値
        gcColorPicker1.SelectedIndex = gcColorPicker1.FindStringExact(gcTextBox1.BackColor.Name, -1, 0);

        // xmlファイルからデータ取得
        this.dataSet1.ReadXml(Path.Combine(Application.StartupPath, @"Resources\prefecture.xml"));

        DataView dv1 = new(dataSet1.Tables[0]);
        gcComboBox1.DataSource = dv1;
        gcComboBox1.SelectedIndex = -1;

        for (int i = 1; i < gcComboBox1.ListColumns.Count; i++)
        {
            gcComboBox1.ListColumns[i].AutoWidth = true;
        }

        // xmlファイルからデータ取得（gcMaskedComboBox）
        this.dataSet2.ReadXml(Path.Combine(Application.StartupPath, @"Resources\pref.xml"));
        gcMaskedComboBox1.DataSource = dataSet2.Tables[0];
        gcMaskedComboBox1.SelectedIndex = -1;

        for (int i = 1; i < gcMaskedComboBox1.ListColumns.Count; i++)
        {
            gcMaskedComboBox1.ListColumns[i].AutoWidth = true;
        }

        // 選択不可項目の設定
        for (int i = 1; i < gcComboBox1.Items.Count; i += 2)
        {
            gcComboBox1.Items[i].Enabled = false;
        }

        for (int i = 1; i < gcMaskedComboBox1.Items.Count; i += 2)
        {
            gcMaskedComboBox1.Items[i].Enabled = false;
        }


        DataView dv2 = new(dataSet1.Tables[0]);
        gcListBox1.DataSource = dv2;
        gcListBox1.SelectedIndex = -1;

        for (int i = 1; i < gcListBox1.Columns.Count; i++)
        {
            gcListBox1.Columns[i].AutoWidth = true;
        }

        // 選択不可項目の設定
        for (int i = 1; i < gcListBox1.Items.Count; i += 2)
        {
            gcListBox1.Items[i].Enabled = false;
        }
    }

    private void SetForeColor()
    {
        gcTextBox1.ForeColor = gcColorPicker1.SelectedColor;
        gcMask1.ForeColor = gcColorPicker1.SelectedColor;
        gcCharMask1.ForeColor = gcColorPicker1.SelectedColor;
        gcDateTime1.ForeColor = gcColorPicker1.SelectedColor;
        gcDate1.ForeColor = gcColorPicker1.SelectedColor;
        gcTime1.ForeColor = gcColorPicker1.SelectedColor;
        gcTimeSpan1.ForeColor = gcColorPicker1.SelectedColor;
        gcNumber1.ForeColor = gcColorPicker1.SelectedColor;
        gcComboBox1.ForeColor = gcColorPicker1.SelectedColor;
        gcMaskedComboBox1.ForeColor = gcColorPicker1.SelectedColor;
        gcListBox1.ForeColor = gcColorPicker1.SelectedColor;
    }

    private void SetBackColor()
    {
        gcTextBox1.BackColor = gcColorPicker2.SelectedColor;
        gcMask1.BackColor = gcColorPicker2.SelectedColor;
        gcCharMask1.BackColor = gcColorPicker2.SelectedColor;
        gcDateTime1.BackColor = gcColorPicker2.SelectedColor;
        gcDate1.BackColor = gcColorPicker2.SelectedColor;
        gcTime1.BackColor = gcColorPicker2.SelectedColor;
        gcTimeSpan1.BackColor = gcColorPicker2.SelectedColor;
        gcNumber1.BackColor = gcColorPicker2.SelectedColor;
        gcComboBox1.BackColor = gcColorPicker2.SelectedColor;
        gcMaskedComboBox1.BackColor = gcColorPicker2.SelectedColor;
        gcListBox1.BackColor = gcColorPicker2.SelectedColor;
    }

    private void SetDisabledForeColor()
    {
        gcTextBox1.DisabledForeColor = gcColorPicker3.SelectedColor;
        gcMask1.DisabledForeColor = gcColorPicker3.SelectedColor;
        gcCharMask1.DisabledForeColor = gcColorPicker3.SelectedColor;
        gcDateTime1.DisabledForeColor = gcColorPicker3.SelectedColor;
        gcDate1.DisabledForeColor = gcColorPicker3.SelectedColor;
        gcTime1.DisabledForeColor = gcColorPicker3.SelectedColor;
        gcTimeSpan1.DisabledForeColor = gcColorPicker3.SelectedColor;
        gcNumber1.DisabledForeColor = gcColorPicker3.SelectedColor;
        gcComboBox1.DisabledForeColor = gcColorPicker3.SelectedColor;
        gcMaskedComboBox1.DisabledForeColor = gcColorPicker3.SelectedColor;
    }

    private void SetDisabledBackColor()
    {
        gcTextBox1.DisabledBackColor = gcColorPicker4.SelectedColor;
        gcMask1.DisabledBackColor = gcColorPicker4.SelectedColor;
        gcCharMask1.DisabledBackColor = gcColorPicker4.SelectedColor;
        gcDateTime1.DisabledBackColor = gcColorPicker4.SelectedColor;
        gcDate1.DisabledBackColor = gcColorPicker4.SelectedColor;
        gcTime1.DisabledBackColor = gcColorPicker4.SelectedColor;
        gcTimeSpan1.DisabledBackColor = gcColorPicker4.SelectedColor;
        gcNumber1.DisabledBackColor = gcColorPicker4.SelectedColor;
        gcComboBox1.DisabledBackColor = gcColorPicker4.SelectedColor;
        gcMaskedComboBox1.DisabledBackColor = gcColorPicker4.SelectedColor;
    }

    private void SetListDisabledForeColor()
    {
        // ListDisabledItemStyle.ForeColorプロパティ
        gcComboBox1.ListDisabledItemStyle.ForeColor = gcColorPicker5.SelectedColor;
        gcMaskedComboBox1.ListDisabledItemStyle.ForeColor = gcColorPicker5.SelectedColor;
        // DisabledItemStyle.ForeColorプロパティ
        gcListBox1.DisabledItemStyle.ForeColor = gcColorPicker5.SelectedColor;
    }

    private void SetListDisabledBackColor()
    {
        // ListDisabledItemStyle.BackColorプロパティ
        gcComboBox1.ListDisabledItemStyle.BackColor = gcColorPicker6.SelectedColor;
        gcMaskedComboBox1.ListDisabledItemStyle.BackColor = gcColorPicker6.SelectedColor;
        // DisabledItemStyle.BackColorプロパティ
        gcListBox1.DisabledItemStyle.BackColor = gcColorPicker6.SelectedColor;
    }

    private void SetEnabled()
    {
        gcTextBox1.Enabled = !checkBox1.Checked;
        gcMask1.Enabled = !checkBox1.Checked;
        gcCharMask1.Enabled = !checkBox1.Checked;
        gcDateTime1.Enabled = !checkBox1.Checked;
        gcDate1.Enabled = !checkBox1.Checked;
        gcTime1.Enabled = !checkBox1.Checked;
        gcTimeSpan1.Enabled = !checkBox1.Checked;
        gcNumber1.Enabled = !checkBox1.Checked;
        gcComboBox1.Enabled = !checkBox1.Checked;
        gcMaskedComboBox1.Enabled = !checkBox1.Checked;
        gcListBox1.Enabled = !checkBox1.Checked;
    }
}
