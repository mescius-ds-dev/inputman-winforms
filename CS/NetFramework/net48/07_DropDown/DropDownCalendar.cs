using System;
using System.Drawing;
using System.Windows.Forms;
using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._07_DropDown
{
    public partial class DropDownCalendar : InputManWin12_Demo.DemoBase_settings
    {
        public DropDownCalendar()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            gcComboBox1.SelectedIndexChanged += new EventHandler(gcComboBox1_SelectedIndexChanged);
            gcNumber1.TextChanging += new TextChangingEventHandler(gcNumber1_TextChanging);
            gcNumber2.TextChanging += new TextChangingEventHandler(gcNumber2_TextChanging);
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            checkBox2.CheckedChanged += new EventHandler(checkBox2_CheckedChanged);
            checkBox3.CheckedChanged += new EventHandler(checkBox3_CheckedChanged);
            checkBox4.CheckedChanged += new EventHandler(checkBox4_CheckedChanged);
            checkBox5.CheckedChanged += new EventHandler(checkBox5_CheckedChanged);
            checkBox6.CheckedChanged += new EventHandler(checkBox6_CheckedChanged);

            // ***** 初期値
            gcComboBox1.SelectedIndex = Convert.ToInt32(gcDate1.DropDownCalendar.CalendarType);
            checkBox3.Checked = gcDate1.DropDownCalendar.ShowTrailing;
            checkBox4.Checked = gcDate1.DropDownCalendar.ShowToday;
            checkBox5.Checked = gcDate1.DropDownCalendar.ShowWeekNumber;
            gcDateTime1.Value = DateTime.Now;
            gcDate1.Value = DateTime.Now;
            gcDateTime1.DropDownCalendar.HeaderFormat = "ggge年MMMM";
            gcDate1.DropDownCalendar.HeaderFormat = "ggge年MMMM";

            // xmlファイルから祝日データ取得
            System.String filePath = Application.StartupPath;
            gcDateTime1.DropDownCalendar.HolidayStyles = HolidayStyleCollection.Load(filePath + "\\Resources\\Holiday.xml");
            gcDate1.DropDownCalendar.HolidayStyles = HolidayStyleCollection.Load(filePath + "\\Resources\\Holiday.xml");
        }

        private void gcComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // カレンダーのタイプ
            gcDateTime1.DropDownCalendar.CalendarType = (CalendarType)gcComboBox1.SelectedIndex;
            gcDate1.DropDownCalendar.CalendarType = (CalendarType)gcComboBox1.SelectedIndex;
            if (gcComboBox1.SelectedIndex == 0)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox5.Enabled = true;
            }
            else
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox5.Enabled = false;
            }
        }

        private void gcNumber1_TextChanging(object sender, TextChangingEventArgs e)
        {
            // カレンダーに表示する月数／年数
            if (e.Result == "0")
            {
                e.Cancel = true;
                return;
            }

            if ((Convert.ToInt32(e.Result) * gcNumber2.Value.Value) > 12)
            {
                e.Cancel = true;
            }
            else
            {
                gcDateTime1.DropDownCalendar.CalendarDimensions = new Size(Convert.ToInt32(e.Result), Convert.ToInt32(gcNumber2.Value.Value));
                gcDate1.DropDownCalendar.CalendarDimensions = new Size(Convert.ToInt32(e.Result), Convert.ToInt32(gcNumber2.Value.Value));
            }
        }

        private void gcNumber2_TextChanging(object sender, TextChangingEventArgs e)
        {
            // カレンダーに表示する月数／年数
            if (e.Result == "0")
            {
                e.Cancel = true;
                return;
            }

            if (gcNumber1.Value.Value * (Convert.ToInt32(e.Result)) > 12)
            {
                e.Cancel = true;
            }
            else
            {
                gcDateTime1.DropDownCalendar.CalendarDimensions = new Size(Convert.ToInt32(gcNumber1.Value.Value), Convert.ToInt32(e.Result));
                gcDate1.DropDownCalendar.CalendarDimensions = new Size(Convert.ToInt32(gcNumber1.Value.Value), Convert.ToInt32(e.Result));
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // 土日の色の変更
            if (checkBox1.Checked)
            {
                gcDateTime1.DropDownCalendar.Weekdays = new WeekdaysStyle(
                    new DayOfWeekStyle("日", ReflectTitle.ForeColor, new SubStyle(SystemColors.Window, Color.Red, false, false), WeekFlags.All)
                  , new DayOfWeekStyle("月", ReflectTitle.ForeColor, new SubStyle(SystemColors.Window, SystemColors.WindowText, false, false), WeekFlags.None)
                  , new DayOfWeekStyle("火", ReflectTitle.ForeColor, new SubStyle(SystemColors.Window, SystemColors.WindowText, false, false), WeekFlags.None)
                  , new DayOfWeekStyle("水", ReflectTitle.ForeColor, new SubStyle(SystemColors.Window, SystemColors.WindowText, false, false), WeekFlags.None)
                  , new DayOfWeekStyle("木", ReflectTitle.ForeColor, new SubStyle(SystemColors.Window, SystemColors.WindowText, false, false), WeekFlags.None)
                  , new DayOfWeekStyle("金", ReflectTitle.ForeColor, new SubStyle(SystemColors.Window, SystemColors.WindowText, false, false), WeekFlags.None)
                  , new DayOfWeekStyle("土", ReflectTitle.ForeColor, new SubStyle(SystemColors.Window, Color.Blue, false, false), WeekFlags.All));
                gcDate1.DropDownCalendar.Weekdays = new WeekdaysStyle(
                    new DayOfWeekStyle("日", ReflectTitle.ForeColor, new SubStyle(SystemColors.Window, Color.Red, false, false), WeekFlags.All)
                  , new DayOfWeekStyle("月", ReflectTitle.ForeColor, new SubStyle(SystemColors.Window, SystemColors.WindowText, false, false), WeekFlags.None)
                  , new DayOfWeekStyle("火", ReflectTitle.ForeColor, new SubStyle(SystemColors.Window, SystemColors.WindowText, false, false), WeekFlags.None)
                  , new DayOfWeekStyle("水", ReflectTitle.ForeColor, new SubStyle(SystemColors.Window, SystemColors.WindowText, false, false), WeekFlags.None)
                  , new DayOfWeekStyle("木", ReflectTitle.ForeColor, new SubStyle(SystemColors.Window, SystemColors.WindowText, false, false), WeekFlags.None)
                  , new DayOfWeekStyle("金", ReflectTitle.ForeColor, new SubStyle(SystemColors.Window, SystemColors.WindowText, false, false), WeekFlags.None)
                  , new DayOfWeekStyle("土", ReflectTitle.ForeColor, new SubStyle(SystemColors.Window, Color.Blue, false, false), WeekFlags.All));
            }
            else
            {
                gcDateTime1.DropDownCalendar.Weekdays = null;
                gcDate1.DropDownCalendar.Weekdays = null;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // 祝日の表示
            if (checkBox2.Checked)
            {
                gcDateTime1.DropDownCalendar.ActiveHolidayStyles = new string[] { "NationalHoliday" };
                gcDate1.DropDownCalendar.ActiveHolidayStyles = new string[] { "NationalHoliday" };
            }
            else
            {
                gcDateTime1.DropDownCalendar.ActiveHolidayStyles = new string[] { "" };
                gcDate1.DropDownCalendar.ActiveHolidayStyles = new string[] { "" };
            }

        }

        void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            // 隣接日の表示
            gcDateTime1.DropDownCalendar.ShowTrailing = checkBox3.Checked;
            gcDate1.DropDownCalendar.ShowTrailing = checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            // 今日の日付の表示
            gcDateTime1.DropDownCalendar.ShowToday = checkBox4.Checked;
            gcDate1.DropDownCalendar.ShowToday = checkBox4.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            // 週番号の表示
            gcDateTime1.DropDownCalendar.ShowWeekNumber = checkBox5.Checked;
            gcDate1.DropDownCalendar.ShowWeekNumber = checkBox5.Checked;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            // ヘッダを和暦で表示
            gcDateTime1.DropDownCalendar.UseHeaderFormat = checkBox6.Checked;
            gcDate1.DropDownCalendar.UseHeaderFormat = checkBox6.Checked;

            if (checkBox6.Checked)
            {
                gcDateTime1.DropDownCalendar.YearMonthFormat.YearFormat = "ggge年";
                gcDate1.DropDownCalendar.YearMonthFormat.YearFormat = "ggge年";
            }
            else
            {
                gcDateTime1.DropDownCalendar.YearMonthFormat.YearFormat = "yyy";
                gcDate1.DropDownCalendar.YearMonthFormat.YearFormat = "yyy";
            }
        }
    }
}
