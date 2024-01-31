using GrapeCity.Win.Editors;
using GrapeCity.Win.Editors.Fields;

namespace InputManWin12_Demo._02_Format;

public partial class GcDateTime : InputManWin12_Demo.DemoBase_settings
{
    public GcDateTime()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定

        // 入力書式の設定
        gcComboBox1.SelectedIndexChanged += (s, e) => SetInputField();

        gcComboBox2.SelectedIndexChanged += (s, e) =>
        {
            // 表示書式の設定
            gcDateTime1.DisplayFields.Clear();
            gcDateTime1.DisplayFields.AddRange(gcComboBox2.Text);
        };

        gcComboBox3.SelectedIndexChanged += (s, e) =>
            // FieldsEditModeプロパティ
            gcDateTime1.FieldsEditMode = (FieldsEditMode)gcComboBox3.SelectedIndex;

        gcComboBox4.SelectedIndexChanged += (s, e) =>
            // ValidateModeプロパティ
            gcDateTime1.ValidateMode = (ValidateModeEx)gcComboBox4.SelectedIndex;

        gcComboBox5.SelectedIndexChanged += (s, e) =>
            // AcceptsCrLfプロパティ
            gcDateTime1.AcceptsCrLf = (CrLfMode)gcComboBox5.SelectedIndex;

        gcComboBox7.SelectedIndexChanged += (s, e) =>
            // HighlightTextプロパティ
            gcDateTime1.HighlightText = (HighlightText)gcComboBox7.SelectedIndex;

        gcComboBox6.SelectedIndexChanged += (s, e) =>
            // DefaultActiveFieldプロパティ
            gcDateTime1.DefaultActiveField = GetDateField();

        // ***** 初期値
        gcComboBox1.SelectedIndex = 0;
        gcComboBox2.SelectedIndex = 0;
        gcComboBox3.SelectedIndex = Convert.ToInt32(gcDateTime1.FieldsEditMode);
        gcComboBox4.SelectedIndex = Convert.ToInt32(gcDateTime1.ValidateMode);
        gcComboBox5.SelectedIndex = Convert.ToInt32(gcDateTime1.AcceptsCrLf);
        gcComboBox7.SelectedIndex = Convert.ToInt32(gcDateTime1.HighlightText);
        SetDateFieldstoCombo();
    }

    private DateField GetDateField() => gcComboBox6.Text switch
    {
        "DateEraField" => gcDateTime1.Fields.Find<DateEraField>(),
        "DateEraYearField" => gcDateTime1.Fields.Find<DateEraYearField>(),
        "DateYearField" => gcDateTime1.Fields.Find<DateYearField>(),
        "DateMonthField" => gcDateTime1.Fields.Find<DateMonthField>(),
        "DateDayField" => gcDateTime1.Fields.Find<DateDayField>(),
        "DateAmPmField" => gcDateTime1.Fields.Find<DateAmPmField>(),
        "DateShortHourField" => gcDateTime1.Fields.Find<DateShortHourField>(),
        "DateHourField" => gcDateTime1.Fields.Find<DateHourField>(),
        "DateMinuteField" => gcDateTime1.Fields.Find<DateMinuteField>(),
        "DateSecondField" => gcDateTime1.Fields.Find<DateSecondField>(),
        _ => null
    };

    readonly string[] fieldName = {
            "DateEraField"
            , "DateEraYearField"
            , "DateYearField"
            , "DateMonthField"
            , "DateDayField"
            , "DateAmPmField"
            , "DateShortHourField"
            , "DateHourField"
            , "DateMinuteField"
            , "DateSecondField"
    };

    readonly string[] fieldValue = {
            "年号入力フィールド"
            , "和暦入力フィールド"
            ,  "年入力フィールド"
            , "月入力フィールド"
            , "日入力フィールド"
            , "午前／午後入力フィールド"
            , "12時間制時刻入力フィールド"
            , "時間入力フィールド"
            , "分入力フィールド"
            , "秒入力フィールド"
    };

    private void SetInputField()
    {
        gcDateTime1.Fields.Clear();
        gcDateTime1.Fields.AddRange(gcComboBox1.Text);
        SetDateFieldstoCombo();
    }

    private void SetDateFieldstoCombo()
    {
        // 設定された書式からDefaultActiveFieldコンボに表示するフィールドを取得設定する
        gcComboBox6.SelectedIndex = -1;
        gcComboBox6.Items.Clear();
        foreach (DateField item in gcDateTime1.Fields)
        {
            if (item is DateLiteralField) continue;

            gcComboBox6.Items.Add(new ListItem(item.GetType().Name,
                fieldValue[Array.IndexOf(fieldName, item.GetType().Name)]));
        }
        gcComboBox6.SelectedIndex = 0;
    }
}