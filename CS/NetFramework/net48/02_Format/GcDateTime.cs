using System;
using GrapeCity.Win.Editors;
using GrapeCity.Win.Editors.Fields;

namespace InputManWin12_Demo._02_Format
{
    public partial class GcDateTime : InputManWin12_Demo.DemoBase_settings
    {
        public GcDateTime()
        {
            InitializeComponent();
            InitializeForm();
        }

        string[] fieldName = {"DateEraField", "DateEraYearField",
                                  "DateYearField", "DateMonthField", "DateDayField",
                                  "DateAmPmField", "DateShortHourField", 
                                  "DateHourField", "DateMinuteField", "DateSecondField"};
        string[] fieldValue = {"年号入力フィールド", "和暦入力フィールド",
                                  "年入力フィールド", "月入力フィールド", "日入力フィールド",
                                  "午前／午後入力フィールド", "12時間制時刻入力フィールド", 
                                  "時間入力フィールド", "分入力フィールド", "秒入力フィールド"};

        private void InitializeForm()
        {
            // ***** 初期設定
            gcComboBox1.SelectedIndexChanged += new EventHandler(gcComboBox1_SelectedIndexChanged);
            gcComboBox2.SelectedIndexChanged += new EventHandler(gcComboBox2_SelectedIndexChanged);
            gcComboBox3.SelectedIndexChanged += new EventHandler(gcComboBox3_SelectedIndexChanged);
            gcComboBox4.SelectedIndexChanged += new EventHandler(gcComboBox4_SelectedIndexChanged);
            gcComboBox5.SelectedIndexChanged += new EventHandler(gcComboBox5_SelectedIndexChanged);
            gcComboBox7.SelectedIndexChanged += new EventHandler(gcComboBox7_SelectedIndexChanged);
            gcComboBox6.SelectedIndexChanged += new EventHandler(gcComboBox6_SelectedIndexChanged);

            // ***** 初期値
            gcComboBox1.SelectedIndex = 0;
            gcComboBox2.SelectedIndex = 0;
            gcComboBox3.SelectedIndex = Convert.ToInt32(gcDateTime1.FieldsEditMode);
            gcComboBox4.SelectedIndex = Convert.ToInt32(gcDateTime1.ValidateMode);
            gcComboBox5.SelectedIndex = Convert.ToInt32(gcDateTime1.AcceptsCrLf);
            gcComboBox7.SelectedIndex = Convert.ToInt32(gcDateTime1.HighlightText);
            setDateFieldstoCombo();
        }

        private void gcComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 入力書式の設定
            gcDateTime1.Fields.Clear();
            gcDateTime1.Fields.AddRange(gcComboBox1.Text);
            setDateFieldstoCombo();
        }

        private void gcComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 表示書式の設定
            gcDateTime1.DisplayFields.Clear();
            gcDateTime1.DisplayFields.AddRange(gcComboBox2.Text);
        }

        private void gcComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // FieldsEditModeプロパティ
            gcDateTime1.FieldsEditMode = (FieldsEditMode)gcComboBox3.SelectedIndex;
        }

        private void gcComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ValidateModeプロパティ
            gcDateTime1.ValidateMode = (ValidateModeEx)gcComboBox4.SelectedIndex;
        }

        private void gcComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            // AcceptsCrLfプロパティ
            gcDateTime1.AcceptsCrLf = (CrLfMode)gcComboBox5.SelectedIndex;
        }

        private void gcComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            // HighlightTextプロパティ
            gcDateTime1.HighlightText = (HighlightText)gcComboBox7.SelectedIndex;
        }

        private void gcComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            // DefaultActiveFieldプロパティ
            switch (gcComboBox6.Text)
            {
                case "DateEraField":
                    gcDateTime1.DefaultActiveField = gcDateTime1.Fields.Find<DateEraField>();
                    break;
                case "DateEraYearField":
                    gcDateTime1.DefaultActiveField = gcDateTime1.Fields.Find<DateEraYearField>();
                    break;
                case "DateYearField":
                    gcDateTime1.DefaultActiveField = gcDateTime1.Fields.Find<DateYearField>();
                    break;
                case "DateMonthField":
                    gcDateTime1.DefaultActiveField = gcDateTime1.Fields.Find<DateMonthField>();
                    break;
                case "DateDayField":
                    gcDateTime1.DefaultActiveField = gcDateTime1.Fields.Find<DateDayField>();
                    break;
                case "DateAmPmField":
                    gcDateTime1.DefaultActiveField = gcDateTime1.Fields.Find<DateAmPmField>();
                    break;
                case "DateShortHourField":
                    gcDateTime1.DefaultActiveField = gcDateTime1.Fields.Find<DateShortHourField>();
                    break;
                case "DateHourField":
                    gcDateTime1.DefaultActiveField = gcDateTime1.Fields.Find<DateHourField>();
                    break;
                case "DateMinuteField":
                    gcDateTime1.DefaultActiveField = gcDateTime1.Fields.Find<DateMinuteField>();
                    break;
                case "DateSecondField":
                    gcDateTime1.DefaultActiveField = gcDateTime1.Fields.Find<DateSecondField>();
                    break;
                default:
                    gcDateTime1.DefaultActiveField = null;
                    break;
            }
        }

        private void setDateFieldstoCombo()
        {
            // 設定された書式からDefaultActiveFieldコンボに表示するフィールドを取得設定する
            gcComboBox6.SelectedIndex = -1;
            gcComboBox6.Items.Clear();
            DateTimeFieldCollection fieldCollection = gcDateTime1.Fields;
            foreach (DateField item in fieldCollection)
            {
                if (item is DateLiteralField == false)
                {
                    gcComboBox6.Items.Add(new ListItem(item.GetType().Name, fieldValue[Array.IndexOf(fieldName, item.GetType().Name)]));
                }
            }
            gcComboBox6.SelectedIndex = 0;
        }
    }
}