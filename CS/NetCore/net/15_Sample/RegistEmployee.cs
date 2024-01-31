using GrapeCity.Win.Editors;
using GrapeCity.Win.Editors.Fields;

namespace InputManWin12_Demo._15_Sample;
public partial class RegistEmployee : InputManWin12_Demo.DemoBase
{

    public RegistEmployee()
    {
        InitializeComponent();

        Clear();

        button1.Click += (s, e) => Submit();
        button2.Click += (s, e) => Clear(); ;

        SetPropertyEmployeeNumber();
        SetPropertyEmployeeName();
        SetPropertyFurigana();
        SetPropertyDateOfBirth();
        SetPropertyTelephoneNumber();
        SetPropertyZipCode();
        SetPropertyAddress();
        SetPropertyDepartmentName();
        SetPropertyExtensionNumber();
        SetPropertyMessageColumn();

        SetPropertyFocus();

        gcNumber1.Focus();
    }

    /// <summary>
    /// コントロールクリア
    /// </summary>
    private void Clear()
    {
        gcNumber1.Clear();
        gcTextBox1.Clear();
        gcTextBox2.Clear();
        gcPostal1.Clear();
        gcAddressBox1.Clear();
        gcMask1.Clear();
        gcDate1.Clear();
        gcComboBox1.Clear();
        gcMask2.Clear();
        gcTextBox3.Clear();
    }

    /// <summary>
    /// 登録
    /// </summary>
    private void Submit()
    {
        if (!ValidateControls()) return;

        MessageBox.Show("登録しました。");
    }

    /// <summary>
    /// 各コントロール検証
    /// </summary>
    /// <returns></returns>
    private bool ValidateControls()
    {
        if (gcCommonValidator1.GetInvalidControls().Contains(gcTextBox1))
        {
            MessageBox.Show("社員名の入力値が不正です。");
            gcTextBox1.Focus();
            return false;
        }

        if (gcCustomValidator1.GetInvalidControls().Contains(gcDate1)
            || gcDateValidator1.GetInvalidControls().Contains(gcDate1))
        {
            MessageBox.Show("生年月日の入力値が不正です。");
            gcDate1.Focus();
            return false;
        }

        if (gcCustomValidator1.GetInvalidControls().Contains(gcMask1))
        {
            MessageBox.Show("電話番号の入力値が不正です。");
            gcMask1.Focus();
            return false;
        }

        if (gcCustomValidator1.GetInvalidControls().Contains(gcPostal1))
        {
            MessageBox.Show("郵便番号の入力値が不正です。");
            gcPostal1.Focus();
            return false;
        }

        if (gcCommonValidator1.GetInvalidControls().Contains(gcComboBox1))
        {
            MessageBox.Show("部署名の入力値が不正です。");
            gcComboBox1.Focus();
            return false;
        }

        return true;
    }

    /// <summary>
    /// 社員番号（GcNumber）へのプロパティ設定
    /// </summary>
    private void SetPropertyEmployeeNumber()
    {
        gcNumber1.DisplayFields.Clear();
        gcNumber1.Fields.SetFields("000000,,,,");
        gcNumber1.DisplayFields.AddRange("000000,,,,");
        gcNumber1.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft;
    }

    /// <summary>
    /// 社員名（GcTextBox）へのプロパティ設定
    /// </summary>
    private void SetPropertyEmployeeName()
    {
        gcTextBox1.MaxLength = 60;
        gcTextBox1.MaxLengthUnit = GrapeCity.Win.Editors.LengthUnit.Char;
        gcTextBox1.Format = "Ｚ";
        gcTextBox1.AlternateText.DisplayNull.Text = "全角文字を入力できます。";
        gcTextBox1.AlternateText.DisplayNull.ForeColor = Color.Gray;
        gcTextBox1.AllowSpace = GrapeCity.Win.Editors.AllowSpace.None;
        gcIme1.SetInputScope(gcTextBox1, InputScopeNameValue.Hiragana);

        SetCommonValidate(gcTextBox1);
    }

    /// <summary>
    /// フリガナ（GcTextBox）へのプロパティ設定
    /// </summary>
    private void SetPropertyFurigana()
    {
        gcIme1.SetReadingStringOutput(gcTextBox1, new ReadingStringOutput(gcTextBox2, ReadingStringOutputMode.Append));
        gcTextBox2.Format = "Ｋ";
        gcTextBox2.AlternateText.DisplayNull.Text = "カタカナを入力できます。";
        gcTextBox2.AlternateText.DisplayNull.ForeColor = Color.Gray;
        gcTextBox2.AllowSpace = GrapeCity.Win.Editors.AllowSpace.None;
        gcIme1.SetInputScope(gcTextBox2, InputScopeNameValue.KatakanaFullWidth);
    }

    /// <summary>
    /// 郵便番号（GcPostal）へのプロパティ設定
    /// </summary>
    private void SetPropertyZipCode()
    {
        gcPostal1.Fields.ZipCodePrefix.Text = "〒";
        gcPostal1.SplitAreaDetails = true;
        gcPostal1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        SetCommonValidate(gcPostal1);
    }

    /// <summary>
    /// 住所（GcAddressBox）へのプロパティ設定
    /// </summary>
    private void SetPropertyAddress()
    {
        gcAddressBox1.AutoFilter = true;
        var addressOutputSetting1 = new AddressOutputSetting()
        {
            AddressOutput = gcAddressBox1
        };
        gcAddress1.SetAddressOutputSetting(gcPostal1, addressOutputSetting1);
    }

    /// <summary>
    /// 電話番号（GcMask)へのプロパティ設定
    /// </summary>
    private void SetPropertyTelephoneNumber()
    {
        gcMask1.Fields.AddRange(new MaskField[] {
                new MaskLiteralField("℡ ")
                , new MaskPatternField("\\D", 3, 4)
                , new MaskLiteralField("-")
                , new MaskPatternField("\\D", 3, 4)
                , new MaskLiteralField("-")
                , new MaskPatternField("\\D", 4, 4)
            });
        gcMask1.ImeMode = ImeMode.Off;

        SetCommonValidate(gcMask1);
    }

    /// <summary>
    /// 生年月日（GcDate）へのプロパティ設定
    /// </summary>
    private void SetPropertyDateOfBirth()
    {
        gcDate1.Fields.AddRange(new DateField[] {
                new DateEraField()
                , new DateLiteralField()
                , new DateEraYearField()
                , new DateLiteralField() { Text = "年" }
                , new DateMonthField()
                , new DateLiteralField() { Text = "月" }
                , new DateDayField()
                , new DateLiteralField() { Text = "日" }});
        gcDate1.DropDownCalendar.HeaderFormat = "ggg e年 M月";
        gcDate1.DropDownCalendar.UseHeaderFormat = true;

        GcDateValidator.InvalidRange gcDateInvalidRange1 = new GcDateValidator.InvalidRange()
        {
            MaxValue = DateTime.Today,
            MinValue = new DateTime(1926, 1, 1),
            InvalidMessage = "昭和１年 ～ 本日の範囲の日付を入力できます。"
        };

        gcDateValidator1.GetValidateItems(gcDate1).AddRange(new object[] { gcDateInvalidRange1 });
        gcDateValidator1.GetValidateActions(gcDate1).AddRange(new ValidateAction[] { new IconNotify() });

        SetCommonValidate(gcDate1);
    }

    /// <summary>
    /// 内線番号（GcMask）へのプロパティ設定
    /// </summary>
    private void SetPropertyExtensionNumber()
    {
        gcMask2.Fields.Add(new MaskPatternField("\\D", 4, 4));
    }

    /// <summary>
    /// 部署名（GcComboBox）へのプロパティ設定
    /// </summary>
    private void SetPropertyDepartmentName()
    {
        gcComboBox1.ListColumns.AddRange(new ListColumn[] {
                new ListColumn("部名")
                , new ListColumn("課名")
                , new ListColumn("部課名")
                , new ListColumn("部課名コード")
            });

        gcComboBox1.TextSubItemIndex = 2;

        gcComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
        gcComboBox1.IsEditable = false;

        gcComboBox1.ListColumns[0].AutoWidth = true;
        gcComboBox1.ListColumns[1].AutoWidth = true;
        gcComboBox1.ListColumns[2].Visible = false;
        gcComboBox1.ListColumns[3].Visible = false;

        var list = new List<ListItem>();
        foreach (var item in GetData())
        {
            list.Add(new ListItem(new SubItem[] {
                        new SubItem(item.DepartmentName)
                        , new SubItem(item.DivisionName)
                        , new SubItem(item.Name)
                        , new SubItem(item.Code)
                }));
        }

        gcComboBox1.Items.AddRange(list.ToArray());

        gcComboBox1.SelectedIndex = -1;

        SetCommonValidate(gcComboBox1);
    }

    /// <summary>
    /// 通信欄（GcTextBox)へのプロパティ設定
    /// </summary>
    private void SetPropertyMessageColumn()
    {
        gcTextBox3.Multiline = true;
        gcTextBox3.WrapMode = WrapMode.CharWrap;
        gcTextBox3.LineSpace = 2;
        gcTextBox3.MaxLineCount = 5;
    }

    /// <summary>
    /// 各コントロールのフォーカス移動の設定
    /// </summary>
    private void SetPropertyFocus()
    {
        SetPropertyFocus(gcNumber1);
        SetPropertyFocus(gcTextBox1);
        SetPropertyFocus(gcTextBox2);
        SetPropertyFocus(gcPostal1);
        SetPropertyFocus(gcAddressBox1);
        SetPropertyFocus(gcMask1);
        SetPropertyFocus(gcDate1);
        SetPropertyFocus(gcComboBox1);
        SetPropertyFocus(gcMask2);
        SetPropertyFocus(gcTextBox3);
    }

    /// <summary>
    /// フォーカス移動の設定
    /// </summary>
    /// <param name="control"></param>
    private void SetPropertyFocus(EditBase control)
    {
        control.ExitOnLastChar = true;
        control.ExitOnLeftRightKey = ExitOnLeftRightKey.Both;
        gcShortcut1.SetShortcuts(control, new ShortcutCollection(new Keys[] { Keys.Enter, Keys.Enter | Keys.Shift }
                                , new object[] { gcShortcut1, gcShortcut1 }
                                , new string[] { "NextControl", "PreviousControl" }));
    }

    /// <summary>
    /// 汎用検証（必須入力）の設定
    /// </summary>
    /// <param name="control"></param>
    private void SetCommonValidate(EditBase control)
    {
        gcCommonValidator1.GetValidateItems(control).AddRange(new object[] { new EmptyText { 
            InvalidMessage = "入力必須項目です"
            , FieldsExclude =true 
        } });
        gcCommonValidator1.GetValidateActions(control).AddRange(new ValidateAction[] { new IconNotify() });
    }
    #region サンプル用データ
    /// <summary>
    /// 部署クラス
    /// </summary>
    private class Department
    {
        public string DepartmentName { get; set; }
        public string DivisionName { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }

    /// <summary>
    /// 部署データ取得
    /// </summary>
    /// <returns></returns>

    private IEnumerable<Department> GetData()
    {
        return new List<Department> {
                new Department(){ DepartmentName = "総務部", DivisionName="総務課", Name="総務部総務課", Code="0101" }
                , new Department(){ DepartmentName = "総務部", DivisionName="人事課", Name="総務部人事課", Code="0102"}
                , new Department(){ DepartmentName = "総務部", DivisionName = "福祉課", Name = "総務部福祉課", Code = "0103"}
                , new Department(){ DepartmentName = "企画部", DivisionName="総合企画課", Name="企画部総合企画課", Code="0201"}
                , new Department(){ DepartmentName = "企画部", DivisionName="事業計画課", Name="企画部事業計画課", Code="0202"}
                , new Department(){ DepartmentName = "情報システム部", DivisionName = "システム管理課", Name = "情報システム部システム管理課", Code = "0301"}
                , new Department(){ DepartmentName = "情報システム部", DivisionName = "情報システム課", Name = "情報システム部情報システム課", Code = "0302"}
            };
    }
    #endregion
}
