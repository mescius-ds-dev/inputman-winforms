using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._07_DropDown;

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

        // カレンダーのタイプの設定
        gcComboBox1.SelectedIndexChanged += (s, e) => SetCalendarType();

        // カレンダー表示範囲の設定
        gcNumber1.TextChanging += (s, e) => SetCalendarDimensions(e, e.Result, gcNumber2.Value.GetValueOrDefault());
        gcNumber2.TextChanging += (s, e) => SetCalendarDimensions(e, gcNumber1.Value.GetValueOrDefault(), e.Result);

        // 土日の色の変更
        checkBox1.CheckedChanged += (s, e) => SetWeekdays();

        // 祝日の表示
        checkBox2.CheckedChanged += (s, e) => SetActiveHolidayStyles();

        // 隣接日の表示
        checkBox3.CheckedChanged += (s, e) => SetShowTrailing();

        // 今日の日付の表示
        checkBox4.CheckedChanged += (s, e) => SetShowToday();

        // 週番号の表示
        checkBox5.CheckedChanged += (s, e) => SetShowWeekNumber();

        // ヘッダを和暦で表示
        checkBox6.CheckedChanged += (s, e) => SetUseHeaderFormat();

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

        gcDateTime1.DropDownCalendar.HolidayStyles = HolidayStyleCollection.Load(Path.Combine(Application.StartupPath, @"Resources\Holiday.xml"));
        gcDate1.DropDownCalendar.HolidayStyles = HolidayStyleCollection.Load(Path.Combine(Application.StartupPath, @"Resources\Holiday.xml"));
    }

    private void SetCalendarType()
    {
        gcDateTime1.DropDownCalendar.CalendarType = (CalendarType)gcComboBox1.SelectedIndex;
        gcDate1.DropDownCalendar.CalendarType = (CalendarType)gcComboBox1.SelectedIndex;

        var isNoSelect = gcComboBox1.SelectedIndex == 0;

        checkBox1.Enabled = isNoSelect;
        checkBox2.Enabled = isNoSelect;
        checkBox3.Enabled = isNoSelect;
        checkBox5.Enabled = isNoSelect;
    }

    private void SetCalendarDimensions<T, U>(TextChangingEventArgs e, T sourceWidth, U sourceHeight)
    {
        var width = Convert.ToInt32(sourceWidth);
        var height = Convert.ToInt32(sourceHeight);

        if (e.Result == "0" || width * height > 12)
        {
            e.Cancel = true;
            return;
        }

        gcDateTime1.DropDownCalendar.CalendarDimensions = new Size(width, height);
        gcDate1.DropDownCalendar.CalendarDimensions = new Size(width, height);
    }

    private void SetWeekdays()
    {
        if (checkBox1.Checked)
        {
            gcDateTime1.DropDownCalendar.Weekdays = GetWeekdaysStyle();
            gcDate1.DropDownCalendar.Weekdays = GetWeekdaysStyle();
        }
        else
        {
            gcDateTime1.DropDownCalendar.Weekdays = null;
            gcDate1.DropDownCalendar.Weekdays = null;
        }
    }


    private WeekdaysStyle GetWeekdaysStyle() => new(
            new DayOfWeekStyle("日", ReflectTitle.ForeColor, new SubStyle(SystemColors.Window, Color.Red, false, false), WeekFlags.All)
          , new DayOfWeekStyle("月", ReflectTitle.ForeColor, new SubStyle(SystemColors.Window, SystemColors.WindowText, false, false), WeekFlags.None)
          , new DayOfWeekStyle("火", ReflectTitle.ForeColor, new SubStyle(SystemColors.Window, SystemColors.WindowText, false, false), WeekFlags.None)
          , new DayOfWeekStyle("水", ReflectTitle.ForeColor, new SubStyle(SystemColors.Window, SystemColors.WindowText, false, false), WeekFlags.None)
          , new DayOfWeekStyle("木", ReflectTitle.ForeColor, new SubStyle(SystemColors.Window, SystemColors.WindowText, false, false), WeekFlags.None)
          , new DayOfWeekStyle("金", ReflectTitle.ForeColor, new SubStyle(SystemColors.Window, SystemColors.WindowText, false, false), WeekFlags.None)
          , new DayOfWeekStyle("土", ReflectTitle.ForeColor, new SubStyle(SystemColors.Window, Color.Blue, false, false), WeekFlags.All));


    private void SetActiveHolidayStyles()
    {
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

    void SetShowTrailing()
    {
        gcDateTime1.DropDownCalendar.ShowTrailing = checkBox3.Checked;
        gcDate1.DropDownCalendar.ShowTrailing = checkBox3.Checked;
    }

    private void SetShowToday()
    {

        gcDateTime1.DropDownCalendar.ShowToday = checkBox4.Checked;
        gcDate1.DropDownCalendar.ShowToday = checkBox4.Checked;
    }

    private void SetShowWeekNumber()
    {

        gcDateTime1.DropDownCalendar.ShowWeekNumber = checkBox5.Checked;
        gcDate1.DropDownCalendar.ShowWeekNumber = checkBox5.Checked;
    }

    private void SetUseHeaderFormat()
    {
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
