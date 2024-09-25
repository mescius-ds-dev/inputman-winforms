using System.Data;

namespace InputManWin12_Demo._06_Display;

public partial class PlaceHolder : InputManWin12_Demo.DemoBase_settings
{
    public PlaceHolder()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // PlaceHolderプロパティ
        checkBox1.CheckedChanged += (s, e) => SetEnabled();

        // Fontプロパティ
        gcNumber2.ValueChanged += (s, e) => SetFont();

        // PlaceHolderAlignmentプロパティ
        gcComboBox2.SelectedIndexChanged += (s, e) => SetrAlignment();

        // xmlファイルからデータ取得
        this.dataSet1.ReadXml(Path.Combine(Application.StartupPath, @"Resources\prefecture.xml"));

        gcComboBox1.DataSource = new DataView(dataSet1.Tables[0]);
        gcComboBox1.SelectedIndex = 0;

        for (int i = 1; i < gcComboBox1.ListColumns.Count; i++)
        {
            gcComboBox1.ListColumns[i].AutoWidth = true;
        }

        // xmlファイルからデータ取得（gcMaskedComboBox）
        this.dataSet2.ReadXml(Path.Combine(Application.StartupPath, @"Resources\pref.xml"));

        gcComboBox2.SelectedIndex = 0;
    }

    private void SetEnabled()
    {
        // PlaceHolderプロパティ
        gcTextBox1.PlaceHolder.Enable = checkBox1.Checked;
        gcTextBox1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
        gcMask1.PlaceHolder.Enable = checkBox1.Checked;
        gcMask1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
        gcMask1.PlaceHolder.FloatingStyle.ForeColor = Color.Red;
        gcDateTime1.PlaceHolder.Enable = checkBox1.Checked;
        gcDateTime1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
        gcDateTime1.PlaceHolder.FloatingStyle.ForeColor = Color.Red;
        gcTime1.PlaceHolder.Enable = checkBox1.Checked;
        gcTime1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
        gcTime1.PlaceHolder.FloatingStyle.ForeColor = Color.Red;
        gcDate1.PlaceHolder.Enable = checkBox1.Checked;
        gcDate1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
        gcTimeSpan1.PlaceHolder.Enable = checkBox1.Checked;
        gcTimeSpan1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
        gcNumber1.PlaceHolder.Enable = checkBox1.Checked;
        gcNumber1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
        gcNumber1.PlaceHolder.FloatingStyle.ForeColor = Color.Red;
        gcComboBox1.PlaceHolder.Enable = checkBox1.Checked;
        gcComboBox1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
    }

    private void SetFont()
    {
        gcTextBox1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
        gcMask1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
        gcDateTime1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
        gcTime1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
        gcDate1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
        gcTimeSpan1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
        gcNumber1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
        gcComboBox1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
    }

    private void SetrAlignment()
    {
        // PlaceHolderAlignmentプロパティ
        gcTextBox1.PlaceHolder.FloatingStyle.PlaceHolderAlignment = (GrapeCity.Framework.Views.PlaceHolderAlignment)gcComboBox2.SelectedIndex;
        gcMask1.PlaceHolder.FloatingStyle.PlaceHolderAlignment = (GrapeCity.Framework.Views.PlaceHolderAlignment)gcComboBox2.SelectedIndex;
        gcDateTime1.PlaceHolder.FloatingStyle.PlaceHolderAlignment = (GrapeCity.Framework.Views.PlaceHolderAlignment)gcComboBox2.SelectedIndex;
        gcTime1.PlaceHolder.FloatingStyle.PlaceHolderAlignment = (GrapeCity.Framework.Views.PlaceHolderAlignment)gcComboBox2.SelectedIndex;
        gcDate1.PlaceHolder.FloatingStyle.PlaceHolderAlignment = (GrapeCity.Framework.Views.PlaceHolderAlignment)gcComboBox2.SelectedIndex;
        gcTimeSpan1.PlaceHolder.FloatingStyle.PlaceHolderAlignment = (GrapeCity.Framework.Views.PlaceHolderAlignment)gcComboBox2.SelectedIndex;
        gcNumber1.PlaceHolder.FloatingStyle.PlaceHolderAlignment = (GrapeCity.Framework.Views.PlaceHolderAlignment)gcComboBox2.SelectedIndex;
        gcComboBox1.PlaceHolder.FloatingStyle.PlaceHolderAlignment = (GrapeCity.Framework.Views.PlaceHolderAlignment)gcComboBox2.SelectedIndex;
    }
}
