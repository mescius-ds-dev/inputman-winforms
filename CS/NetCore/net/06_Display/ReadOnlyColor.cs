using System.Data;

namespace InputManWin12_Demo._06_Display;

public partial class ReadOnlyColor : InputManWin12_Demo.DemoBase_settings
{
    public ReadOnlyColor()
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
        gcColorPicker2.SelectedIndexChanged += (s, e) => SetBackColor();

        // ReadOnlyForeColorプロパティ
        gcColorPicker3.SelectedIndexChanged += (s, e) => SetReadOnlyForeColor();

        // ReadOnlyBackColorプロパティ
        gcColorPicker4.SelectedIndexChanged += (s, e) => SetReadOnlyBackColor();

        // ReadOnlyプロパティ
        checkBox1.CheckedChanged += (s, e) => SetReadOnly();

        // ***** 初期値
        gcColorPicker1.SelectedIndex = gcColorPicker1.FindStringExact(gcTextBox1.BackColor.Name, -1, 0);

        // xmlファイルからデータ取得
        this.dataSet1.ReadXml(Path.Combine(Application.StartupPath, @"Resources\prefecture.xml"));

        gcComboBox1.DataSource = new DataView(dataSet1.Tables[0]);
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
    }

    private void SetReadOnlyForeColor()
    {
        gcTextBox1.ReadOnlyForeColor = gcColorPicker3.SelectedColor;
        gcMask1.ReadOnlyForeColor = gcColorPicker3.SelectedColor;
        gcCharMask1.ReadOnlyForeColor = gcColorPicker3.SelectedColor;
        gcDateTime1.ReadOnlyForeColor = gcColorPicker3.SelectedColor;
        gcDate1.ReadOnlyForeColor = gcColorPicker3.SelectedColor;
        gcTime1.ReadOnlyForeColor = gcColorPicker3.SelectedColor;
        gcTimeSpan1.ReadOnlyForeColor = gcColorPicker3.SelectedColor;
        gcNumber1.ReadOnlyForeColor = gcColorPicker3.SelectedColor;
        gcComboBox1.ReadOnlyForeColor = gcColorPicker3.SelectedColor;
        gcMaskedComboBox1.ReadOnlyForeColor = gcColorPicker3.SelectedColor;
    }

    private void SetReadOnlyBackColor()
    {
        gcTextBox1.ReadOnlyBackColor = gcColorPicker4.SelectedColor;
        gcMask1.ReadOnlyBackColor = gcColorPicker4.SelectedColor;
        gcCharMask1.ReadOnlyBackColor = gcColorPicker4.SelectedColor;
        gcDateTime1.ReadOnlyBackColor = gcColorPicker4.SelectedColor;
        gcDate1.ReadOnlyBackColor = gcColorPicker4.SelectedColor;
        gcTime1.ReadOnlyBackColor = gcColorPicker4.SelectedColor;
        gcTimeSpan1.ReadOnlyBackColor = gcColorPicker4.SelectedColor;
        gcNumber1.ReadOnlyBackColor = gcColorPicker4.SelectedColor;
        gcComboBox1.ReadOnlyBackColor = gcColorPicker4.SelectedColor;
        gcMaskedComboBox1.ReadOnlyBackColor = gcColorPicker4.SelectedColor;
    }

    private void SetReadOnly()
    {
        gcTextBox1.ReadOnly = checkBox1.Checked;
        gcMask1.ReadOnly = checkBox1.Checked;
        gcCharMask1.ReadOnly = checkBox1.Checked;
        gcDateTime1.ReadOnly = checkBox1.Checked;
        gcDate1.ReadOnly = checkBox1.Checked;
        gcTime1.ReadOnly = checkBox1.Checked;
        gcTimeSpan1.ReadOnly = checkBox1.Checked;
        gcNumber1.ReadOnly = checkBox1.Checked;
        gcComboBox1.ReadOnly = checkBox1.Checked;
        gcMaskedComboBox1.ReadOnly = checkBox1.Checked;
    }
}
