using System;
using GrapeCity.Win.Editors;
using GrapeCity.Win.Editors.Fields;

namespace InputManWin12_Demo._02_Format
{
    public partial class GcTimeSpan : InputManWin12_Demo.DemoBase_settings
    {
        public GcTimeSpan()
        {
            InitializeComponent();
            InitializeForm();
        }

        string[] fieldName = {"TimeSpanSignField", "TimeSpanDayField", "TimeSpanHourField", 
                                  "TimeSpanMinuteField", "TimeSpanSecondField", "TimeSpanDecimalField"};
        string[] fieldValue = {"符号入力フィールドド", "日入力フィールド", "時間入力フィールド", 
                                  "分入力フィールド", "秒入力フィールド", "小数入力フィールド"};

        private void InitializeForm()
        {
            // ***** 初期設定
            gcComboBox1.SelectedIndexChanged += new EventHandler(gcComboBox1_SelectedIndexChanged);
            gcComboBox2.SelectedIndexChanged += new EventHandler(gcComboBox2_SelectedIndexChanged);
            gcComboBox3.SelectedIndexChanged += new EventHandler(gcComboBox3_SelectedIndexChanged);
            gcComboBox4.SelectedIndexChanged += new EventHandler(gcComboBox4_SelectedIndexChanged);
            gcComboBox5.SelectedIndexChanged += new EventHandler(gcComboBox5_SelectedIndexChanged);
            gcComboBox6.SelectedIndexChanged += new EventHandler(gcComboBox6_SelectedIndexChanged);

            // ***** 初期値
            gcComboBox1.SelectedIndex = 0;
            gcComboBox2.SelectedIndex = 0;
            gcComboBox3.SelectedIndex = Convert.ToInt32(gcTimeSpan1.ValidateMode);
            gcComboBox4.SelectedIndex = Convert.ToInt32(gcTimeSpan1.AcceptsCrLf);
            gcComboBox5.SelectedIndex = Convert.ToInt32(gcTimeSpan1.HighlightText);
            setTimeSpanFieldstoCombo();
        }

        private void gcComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 入力書式の設定
            gcTimeSpan1.Fields.Clear();
            gcTimeSpan1.Fields.AddRange(gcComboBox1.Text, 0, Convert.ToChar("."), "", "", "-", "");
            setTimeSpanFieldstoCombo();
        }

        private void gcComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 表示書式の設定
            gcTimeSpan1.DisplayFields.Clear();
            gcTimeSpan1.DisplayFields.AddRange(gcComboBox2.Text, 0, Convert.ToChar("."), "", "", "-", "");
        }

        private void gcComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ValidateModeプロパティ
            gcTimeSpan1.ValidateMode = (ValidateMode)gcComboBox3.SelectedIndex;
        }

        private void gcComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // AcceptsCrLfプロパティ
            gcTimeSpan1.AcceptsCrLf = (CrLfMode)gcComboBox4.SelectedIndex;
        }

        private void gcComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            // HighlightTextプロパティ
            gcTimeSpan1.HighlightText = (HighlightText)gcComboBox5.SelectedIndex;
        }

        private void gcComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            // DefaultActiveFieldプロパティ
            switch (gcComboBox6.Text)
            {
                case "TimeSpanSignField":
                    gcTimeSpan1.DefaultActiveField = gcTimeSpan1.Fields.Find<TimeSpanSignField>();
                    break;
                case "TimeSpanDayField":
                    gcTimeSpan1.DefaultActiveField = gcTimeSpan1.Fields.Find<TimeSpanDayField>();
                    break;
                case "TimeSpanHourField":
                    gcTimeSpan1.DefaultActiveField = gcTimeSpan1.Fields.Find<TimeSpanHourField>();
                    break;
                case "TimeSpanMinuteField":
                    gcTimeSpan1.DefaultActiveField = gcTimeSpan1.Fields.Find<TimeSpanMinuteField>();
                    break;
                case "TimeSpanSecondField":
                    gcTimeSpan1.DefaultActiveField = gcTimeSpan1.Fields.Find<TimeSpanSecondField>();
                    break;
                case "TimeSpanDecimalField":
                    gcTimeSpan1.DefaultActiveField = gcTimeSpan1.Fields.Find<TimeSpanDecimalField>();
                    break;
                default:
                    gcTimeSpan1.DefaultActiveField = null;
                    break;
            }
        }

        private void setTimeSpanFieldstoCombo()
        {
            // 設定された書式からDefaultActiveFieldコンボに表示するフィールドを取得設定する
            gcComboBox6.SelectedIndex = -1;
            gcComboBox6.Items.Clear();
            TimeSpanFieldCollection fieldCollection = gcTimeSpan1.Fields;
            foreach (TimeSpanField item in fieldCollection)
            {
                if (item is TimeSpanSignField == false && item is TimeSpanDecimalField == false && item is TimeSpanLiteralField == false)
                {
                    gcComboBox6.Items.Add(new ListItem(item.GetType().Name, fieldValue[Array.IndexOf(fieldName, item.GetType().Name)]));
                }
            }
            gcComboBox6.SelectedIndex = 0;
        }
    }
}
