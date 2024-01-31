using GrapeCity.Win.Editors;
using GrapeCity.Win.Editors.Fields;

namespace InputManWin12_Demo._02_Format;

public partial class GcTime : InputManWin12_Demo.DemoBase_settings
{
    public GcTime()
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
            // FieldsEditModeプロパティ
            gcTime1.FieldsEditMode = (FieldsEditMode)gcComboBox3.SelectedIndex;

        gcComboBox4.SelectedIndexChanged += (s, e) =>
            // ValidateModeプロパティ
            gcTime1.ValidateMode = (ValidateModeEx)gcComboBox4.SelectedIndex;

        gcComboBox5.SelectedIndexChanged += (s, e) =>
            // AcceptsCrLfプロパティ
            gcTime1.AcceptsCrLf = (CrLfMode)gcComboBox5.SelectedIndex;

        gcComboBox7.SelectedIndexChanged += (s, e) =>
            // HighlightTextプロパティ
            gcTime1.HighlightText = (HighlightText)gcComboBox7.SelectedIndex;

        gcComboBox6.SelectedIndexChanged += (s, e) =>
            // DefaultActiveFieldプロパティ
            gcTime1.DefaultActiveField = GetDateField();

        // ***** 初期値
        gcComboBox1.SelectedIndex = 0;
        gcComboBox2.SelectedIndex = 0;
        gcComboBox3.SelectedIndex = Convert.ToInt32(gcTime1.FieldsEditMode);
        gcComboBox4.SelectedIndex = Convert.ToInt32(gcTime1.ValidateMode);
        gcComboBox5.SelectedIndex = Convert.ToInt32(gcTime1.AcceptsCrLf);
        gcComboBox7.SelectedIndex = Convert.ToInt32(gcTime1.HighlightText);
        SetDateFieldstoCombo();
    }

    private void SetInputField()
    {
        gcTime1.Fields.Clear();
        gcTime1.Fields.AddRange(gcComboBox1.Text);
        SetDateFieldstoCombo();
    }

    private void SetDisplayFields()
    {
        gcTime1.DisplayFields.Clear();
        gcTime1.DisplayFields.AddRange(gcComboBox2.Text);
    }

    private DateField GetDateField() => gcComboBox6.Text switch
    {
        "DateAmPmField" => gcTime1.Fields.Find<DateAmPmField>(),
        "DateShortHourField" => gcTime1.Fields.Find<DateShortHourField>(),
        "DateHourField" => gcTime1.Fields.Find<DateHourField>(),
        "DateMinuteField" => gcTime1.Fields.Find<DateMinuteField>(),
        "DateSecondField" => gcTime1.Fields.Find<DateSecondField>(),
        _ => null
    };

    readonly string[] fieldName = {
        "DateAmPmField"
            , "DateShortHourField"
            , "DateHourField"
            , "DateMinuteField"
            , "DateSecondField" };

    readonly string[] fieldValue = {
        "午前／午後入力フィールド"
            , "12時間制時刻入力フィールド"
            , "時間入力フィールド"
            , "分入力フィールド"
            , "秒入力フィールド" };

    private void SetDateFieldstoCombo()
    {
        // 設定された書式からDefaultActiveFieldコンボに表示するフィールドを取得設定する
        gcComboBox6.SelectedIndex = -1;
        gcComboBox6.Items.Clear();
        foreach (DateField item in gcTime1.Fields)
        {
            if (item is DateLiteralField) continue;

            gcComboBox6.Items.Add(new ListItem(item.GetType().Name,
                fieldValue[Array.IndexOf(fieldName, item.GetType().Name)]));
        }
        gcComboBox6.SelectedIndex = 0;
    }
}