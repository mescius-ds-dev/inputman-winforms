using GrapeCity.Win.Editors;
using GrapeCity.Win.Editors.Fields;

namespace InputManWin12_Demo._02_Format;

public partial class GcTimeSpan : InputManWin12_Demo.DemoBase_settings
{
    public GcTimeSpan()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定
        // 入力書式の設定
        gcComboBox1.SelectedIndexChanged += (s, e) => SetInputField();

        // 表示書式の設定
        gcComboBox2.SelectedIndexChanged += (s, e) => SetDisplayFields();

        gcComboBox3.SelectedIndexChanged += (s, e) =>
            // ValidateModeプロパティ
            gcTimeSpan1.ValidateMode = (ValidateMode)gcComboBox3.SelectedIndex;

        gcComboBox4.SelectedIndexChanged += (s, e) =>
            // AcceptsCrLfプロパティ
            gcTimeSpan1.AcceptsCrLf = (CrLfMode)gcComboBox4.SelectedIndex;

        gcComboBox5.SelectedIndexChanged += (s, e) =>
            // HighlightTextプロパティ
            gcTimeSpan1.HighlightText = (HighlightText)gcComboBox5.SelectedIndex;

        gcComboBox6.SelectedIndexChanged += (s, e) =>
            // DefaultActiveFieldプロパティ
            gcTimeSpan1.DefaultActiveField = GetDateField();

        // ***** 初期値
        gcComboBox1.SelectedIndex = 0;
        gcComboBox2.SelectedIndex = 0;
        gcComboBox3.SelectedIndex = Convert.ToInt32(gcTimeSpan1.ValidateMode);
        gcComboBox4.SelectedIndex = Convert.ToInt32(gcTimeSpan1.AcceptsCrLf);
        gcComboBox5.SelectedIndex = Convert.ToInt32(gcTimeSpan1.HighlightText);
        SetTimeSpanFieldstoCombo();
    }

    private void SetInputField()
    {
        gcTimeSpan1.Fields.Clear();
        gcTimeSpan1.Fields.AddRange(gcComboBox1.Text, 0, Convert.ToChar("."), "", "", "-", "");
        SetTimeSpanFieldstoCombo();
    }

    private void SetDisplayFields()
    {
        gcTimeSpan1.DisplayFields.Clear();
        gcTimeSpan1.DisplayFields.AddRange(gcComboBox2.Text, 0, Convert.ToChar("."), "", "", "-", "");
    }

    private TimeSpanField GetDateField() => gcComboBox6.Text switch
    {
        "TimeSpanSignField" => gcTimeSpan1.Fields.Find<TimeSpanSignField>(),
        "TimeSpanDayField" => gcTimeSpan1.Fields.Find<TimeSpanDayField>(),
        "TimeSpanHourField" => gcTimeSpan1.Fields.Find<TimeSpanHourField>(),
        "TimeSpanMinuteField" => gcTimeSpan1.Fields.Find<TimeSpanMinuteField>(),
        "TimeSpanSecondField" => gcTimeSpan1.Fields.Find<TimeSpanSecondField>(),
        "TimeSpanDecimalField" => gcTimeSpan1.Fields.Find<TimeSpanDecimalField>(),
        _ => null
    };

    readonly string[] fieldName = {
        "TimeSpanSignField"
            , "TimeSpanDayField"
            , "TimeSpanHourField"
            , "TimeSpanMinuteField"
            , "TimeSpanSecondField"
            , "TimeSpanDecimalField" };

    readonly string[] fieldValue = {
        "符号入力フィールドド"
            , "日入力フィールド"
            , "時間入力フィールド"
            , "分入力フィールド"
            , "秒入力フィールド"
            , "小数入力フィールド" };

    private void SetTimeSpanFieldstoCombo()
    {
        // 設定された書式からDefaultActiveFieldコンボに表示するフィールドを取得設定する
        gcComboBox6.SelectedIndex = -1;
        gcComboBox6.Items.Clear();
        foreach (TimeSpanField item in gcTimeSpan1.Fields)
        {
            if (item is TimeSpanSignField
                || item is TimeSpanDecimalField
                || item is TimeSpanLiteralField) continue;

            gcComboBox6.Items.Add(new ListItem(item.GetType().Name,
                fieldValue[Array.IndexOf(fieldName, item.GetType().Name)]));
        }
        gcComboBox6.SelectedIndex = 0;
    }
}
