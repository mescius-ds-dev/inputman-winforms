using GrapeCity.Win.Editors;
using GrapeCity.Win.Editors.Fields;

namespace InputManWin12_Demo._02_Format;

public partial class GcDate : InputManWin12_Demo.DemoBase_settings
{
    public GcDate()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定
        gcComboBox1.SelectedIndexChanged += (s, e) =>
        {
            // 入力書式の設定
            gcDate1.Fields.Clear();
            gcDate1.Fields.AddRange(gcComboBox1.Text);
            SetDateFieldstoCombo();
        };

        gcComboBox2.SelectedIndexChanged += (o, e) =>
        {
            // 表示書式の設定
            gcDate1.DisplayFields.Clear();
            gcDate1.DisplayFields.AddRange(gcComboBox2.Text);
        };

        gcComboBox3.SelectedIndexChanged += (s, e) =>
            // FieldsEditModeプロパティ
            gcDate1.FieldsEditMode = (FieldsEditMode)gcComboBox3.SelectedIndex;

        gcComboBox4.SelectedIndexChanged += (s, e) =>
            // ValidateModeプロパティ
            gcDate1.ValidateMode = (ValidateModeEx)gcComboBox4.SelectedIndex;

        gcComboBox5.SelectedIndexChanged += (s, e) =>
            // AcceptsCrLfプロパティ
            gcDate1.AcceptsCrLf = (CrLfMode)gcComboBox5.SelectedIndex;

        gcComboBox7.SelectedIndexChanged += (s, e) =>
            // HighlightTextプロパティ
            gcDate1.HighlightText = (HighlightText)gcComboBox7.SelectedIndex;

        gcComboBox6.SelectedIndexChanged += (s, e) =>
            // DefaultActiveFieldプロパティ
            gcDate1.DefaultActiveField = GetDateField();

        // ***** 初期値
        gcComboBox1.SelectedIndex = 0;
        gcComboBox2.SelectedIndex = 0;
        gcComboBox3.SelectedIndex = Convert.ToInt32(gcDate1.FieldsEditMode);
        gcComboBox4.SelectedIndex = Convert.ToInt32(gcDate1.ValidateMode);
        gcComboBox5.SelectedIndex = Convert.ToInt32(gcDate1.AcceptsCrLf);
        gcComboBox7.SelectedIndex = Convert.ToInt32(gcDate1.HighlightText);
        SetDateFieldstoCombo();
    }

    private DateField GetDateField() => gcComboBox6.Text switch
    {
        "DateEraField" => gcDate1.Fields.Find<DateEraField>(),
        "DateEraYearField" => gcDate1.Fields.Find<DateEraYearField>(),
        "DateYearField" => gcDate1.Fields.Find<DateYearField>(),
        "DateMonthField" => gcDate1.Fields.Find<DateMonthField>(),
        "DateDayField" => gcDate1.Fields.Find<DateDayField>(),
        _ => null
    };

    readonly string[] fieldName = {
            "DateEraField"
            , "DateEraYearField"
            , "DateYearField"
            , "DateMonthField"
            , "DateDayField" };

    readonly string[] fieldValue = {
            "年号入力フィールド"
            , "和暦入力フィールド"
            , "年入力フィールド"
            , "月入力フィールド"
            , "日入力フィールド" };

    private void SetDateFieldstoCombo()
    {
        // 設定された書式からDefaultActiveFieldコンボに表示するフィールドを取得設定する
        gcComboBox6.SelectedIndex = -1;
        gcComboBox6.Items.Clear();
        foreach (var item in gcDate1.Fields)
        {
            if (item is DateLiteralField) continue;

            gcComboBox6.Items.Add(new ListItem(item.GetType().Name,
                fieldValue[Array.IndexOf(fieldName, item.GetType().Name)]));
        }
        gcComboBox6.SelectedIndex = 0;
    }
}