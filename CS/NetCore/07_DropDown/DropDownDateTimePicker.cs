using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._07_DropDown;

public partial class DropDownDateTimePicker : InputManWin12_Demo.DemoBase_settings
{
    public DropDownDateTimePicker()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // 初期設定

        // ピッカーのForeColorプロパティ
        gcColorPicker1.SelectedIndexChanged += (s, e) => SetForeColor();

        // ピッカーのBackColorプロパティ
        gcColorPicker2.SelectedIndexChanged += (s, e) => SetBackColor();

        // ピッカーのBorderStyleプロパティ
        gcComboBox1.SelectedIndexChanged += (s, e) => SetBorderStyle();

        // ピッカーのSingleBorderColorプロパティ
        gcColorPicker3.SelectedIndexChanged += (s, e) => SetSingleBorderColor();

        // 選択領域のSelectionRenderModeプロパティ
        gcComboBox2.SelectedIndexChanged += (s, e) => SetSelectionRenderMode();

        // 選択領域のSelectedForeColorプロパティ
        gcColorPicker4.SelectedIndexChanged += (s, e) => SetSelectedForeColor();

        // 選択領域のSelectedBackColorプロパティ
        gcColorPicker5.SelectedIndexChanged += (s, e) => SetSelectedBackColor();

        // 選択領域のSelectedBorderColorプロパティ
        gcColorPicker6.SelectedIndexChanged += (s, e) => SetSelectedBorderColor();

        gcComboBox3.SelectedIndexChanged += (s, e) => SetYearFormat();
        checkBox1.CheckedChanged += (s, e) => SetShowHours();
        checkBox2.CheckedChanged += (s, e) => SetShowMinutes();
        checkBox3.CheckedChanged += (s, e) => SetShowSeconds();
        gcComboBox4.SelectedIndexChanged += (s, e) => SetHoursInterval();
        gcComboBox5.SelectedIndexChanged += (s, e) => SetMinutesInterval();
        gcComboBox6.SelectedIndexChanged += (s, e) => SetSecondsInterval();

        // Show12Hours／Show12HoursFormatプロパティ
        gcComboBox7.SelectedIndexChanged += (s, e) => Set12Hours();

        // 初期値
        gcDateTime1.Value = DateTime.Now;
        gcDateTime2.Value = DateTime.Now;
        gcDate1.Value = DateTime.Now;

        gcDateTime1.DropDown.DropDownType = DateDropDownType.Picker;
        gcDateTime2.DropDown.DropDownType = DateDropDownType.CalendarPicker;
        gcDate1.DropDown.DropDownType = DateDropDownType.Picker;

        gcComboBox1.SelectedIndex = 1;
        gcComboBox2.SelectedIndex = 0;
        gcComboBox3.SelectedIndex = 0;

        gcComboBox4.SelectedIndex = 0;
        gcComboBox5.SelectedIndex = 0;
        gcComboBox6.SelectedIndex = 0;
        gcComboBox7.SelectedIndex = 0;
    }

    private void SetForeColor()
    {
        gcDateTime1.DropDownPicker.ForeColor = gcColorPicker1.SelectedColor;
        gcDateTime2.DropDownCalendarPicker.TimePicker.ForeColor = gcColorPicker1.SelectedColor;
        gcDate1.DropDownPicker.ForeColor = gcColorPicker1.SelectedColor;
        gcTime1.DropDownPicker.ForeColor = gcColorPicker1.SelectedColor;
    }

    private void SetBackColor()
    {
        gcDateTime1.DropDownPicker.BackColor = gcColorPicker2.SelectedColor;
        gcDateTime2.DropDownCalendarPicker.CalendarPicker.BackColor = gcColorPicker2.SelectedColor;
        gcDateTime2.DropDownCalendarPicker.TimePicker.BackColor = gcColorPicker2.SelectedColor;
        gcDate1.DropDownPicker.BackColor = gcColorPicker2.SelectedColor;
        gcTime1.DropDownPicker.BackColor = gcColorPicker2.SelectedColor;
    }

    private void SetBorderStyle()
    {

        if (gcComboBox1.SelectedIndex == 0)
        {
            gcDateTime1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            gcDateTime2.DropDownCalendarPicker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            gcDate1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            gcTime1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            gcColorPicker3.Enabled = false;
        }
        else if (gcComboBox1.SelectedIndex == 1)
        {
            gcDateTime1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            gcDateTime2.DropDownCalendarPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            gcDate1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            gcTime1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            gcColorPicker3.Enabled = true;
        }
        else if (gcComboBox1.SelectedIndex == 2)
        {
            gcDateTime1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            gcDateTime2.DropDownCalendarPicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            gcDate1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            gcTime1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            gcColorPicker3.Enabled = false;
        }
    }

    private void SetSingleBorderColor()
    {
        gcDateTime1.DropDownPicker.SingleBorderColor = gcColorPicker3.SelectedColor;
        gcDateTime2.DropDownCalendarPicker.SingleBorderColor = gcColorPicker3.SelectedColor;
        gcDate1.DropDownPicker.SingleBorderColor = gcColorPicker3.SelectedColor;
        gcTime1.DropDownPicker.SingleBorderColor = gcColorPicker3.SelectedColor;
    }

    private void SetSelectionRenderMode()
    {

        if (gcComboBox2.SelectedIndex == 0)
        {
            gcDateTime1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.Border;
            gcDateTime2.DropDownCalendarPicker.TimePicker.SelectionRenderMode = SelectionRenderMode.Border;
            gcDate1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.Border;
            gcTime1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.Border;
            gcColorPicker5.Enabled = false;
            gcColorPicker6.Enabled = true;
        }
        else if (gcComboBox2.SelectedIndex == 1)
        {
            gcDateTime1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.Fill;
            gcDateTime2.DropDownCalendarPicker.TimePicker.SelectionRenderMode = SelectionRenderMode.Fill;
            gcDate1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.Fill;
            gcTime1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.Fill;
            gcColorPicker5.Enabled = true;
            gcColorPicker6.Enabled = false;
        }
        else if (gcComboBox2.SelectedIndex == 2)
        {
            gcDateTime1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.BorderWithFill;
            gcDateTime2.DropDownCalendarPicker.TimePicker.SelectionRenderMode = SelectionRenderMode.BorderWithFill;
            gcDate1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.BorderWithFill;
            gcTime1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.BorderWithFill;
            gcColorPicker5.Enabled = true;
            gcColorPicker6.Enabled = true;
        }
    }

    private void SetSelectedForeColor()
    {
        gcDateTime1.DropDownPicker.SelectedForeColor = gcColorPicker4.SelectedColor;
        gcDateTime2.DropDownCalendarPicker.TimePicker.SelectedForeColor = gcColorPicker4.SelectedColor;
        gcDate1.DropDownPicker.SelectedForeColor = gcColorPicker4.SelectedColor;
        gcTime1.DropDownPicker.SelectedForeColor = gcColorPicker4.SelectedColor;
    }

    private void SetSelectedBackColor()
    {
        gcDateTime1.DropDownPicker.SelectedBackColor = gcColorPicker5.SelectedColor;
        gcDateTime2.DropDownCalendarPicker.TimePicker.SelectedBackColor = gcColorPicker5.SelectedColor;
        gcDate1.DropDownPicker.SelectedBackColor = gcColorPicker5.SelectedColor;
        gcTime1.DropDownPicker.SelectedBackColor = gcColorPicker5.SelectedColor;
    }

    private void SetSelectedBorderColor()
    {
        gcDateTime1.DropDownPicker.SelectedBorderColor = gcColorPicker6.SelectedColor;
        gcDateTime2.DropDownCalendarPicker.TimePicker.SelectedBorderColor = gcColorPicker6.SelectedColor;
        gcDate1.DropDownPicker.SelectedBorderColor = gcColorPicker6.SelectedColor;
        gcTime1.DropDownPicker.SelectedBorderColor = gcColorPicker6.SelectedColor;
    }

    private void SetYearFormat()
    {
        gcDateTime1.DropDownPicker.YearFormat = gcComboBox3.SelectedValue.ToString();
        gcDate1.DropDownPicker.YearFormat = gcComboBox3.SelectedValue.ToString();
    }

    private void SetShowHours()
    {
        gcDateTime1.DropDownPicker.ShowHours = checkBox1.Checked;
        gcDateTime2.DropDownCalendarPicker.TimePicker.ShowHours = checkBox1.Checked;
        gcTime1.DropDownPicker.ShowHours = checkBox1.Checked;
    }

    private void SetShowMinutes()
    {
        gcDateTime1.DropDownPicker.ShowMinutes = checkBox2.Checked;
        gcDateTime2.DropDownCalendarPicker.TimePicker.ShowMinutes = checkBox2.Checked;
        gcTime1.DropDownPicker.ShowMinutes = checkBox2.Checked;
    }

    private void SetShowSeconds()
    {
        gcDateTime1.DropDownPicker.ShowSeconds = checkBox3.Checked;
        gcDateTime2.DropDownCalendarPicker.TimePicker.ShowSeconds = checkBox3.Checked;
        gcTime1.DropDownPicker.ShowSeconds = checkBox3.Checked;
    }

    private void SetHoursInterval()
    {
        gcDateTime1.DropDownPicker.HoursInterval = int.Parse(gcComboBox4.SelectedValue.ToString());
        gcDateTime2.DropDownCalendarPicker.TimePicker.HoursInterval = int.Parse(gcComboBox4.SelectedValue.ToString());
        gcTime1.DropDownPicker.HoursInterval = int.Parse(gcComboBox4.SelectedValue.ToString());
    }

    private void SetMinutesInterval()
    {
        gcDateTime1.DropDownPicker.MinutesInterval = int.Parse(gcComboBox5.SelectedValue.ToString());
        gcDateTime2.DropDownCalendarPicker.TimePicker.MinutesInterval = int.Parse(gcComboBox5.SelectedValue.ToString());
        gcTime1.DropDownPicker.MinutesInterval = int.Parse(gcComboBox5.SelectedValue.ToString());
    }

    private void SetSecondsInterval()
    {
        gcDateTime1.DropDownPicker.SecondsInterval = int.Parse(gcComboBox6.SelectedValue.ToString());
        gcDateTime2.DropDownCalendarPicker.TimePicker.SecondsInterval = int.Parse(gcComboBox6.SelectedValue.ToString());
        gcTime1.DropDownPicker.SecondsInterval = int.Parse(gcComboBox6.SelectedValue.ToString());
    }

    private void Set12Hours()
    {
        if (gcComboBox7.SelectedIndex == 0)
        {
            gcDateTime1.DropDownPicker.Show12Hours = false;
            gcDateTime2.DropDownCalendarPicker.TimePicker.Show12Hours = false;
            gcTime1.DropDownPicker.Show12Hours = false;
        }
        else if (gcComboBox7.SelectedIndex == 1)
        {
            gcDateTime1.DropDownPicker.Show12Hours = true;
            gcDateTime1.DropDownPicker.Show12HoursFormat = Show12HoursFormat.EN;
            gcDateTime2.DropDownCalendarPicker.TimePicker.Show12Hours = true;
            gcDateTime2.DropDownCalendarPicker.TimePicker.Show12HoursFormat = Show12HoursFormat.EN;
            gcTime1.DropDownPicker.Show12Hours = true;
            gcTime1.DropDownPicker.Show12HoursFormat = Show12HoursFormat.EN;
        }
        else if (gcComboBox7.SelectedIndex == 2)
        {
            gcDateTime1.DropDownPicker.Show12Hours = true;
            gcDateTime1.DropDownPicker.Show12HoursFormat = Show12HoursFormat.JP;
            gcDateTime2.DropDownCalendarPicker.TimePicker.Show12Hours = true;
            gcDateTime2.DropDownCalendarPicker.TimePicker.Show12HoursFormat = Show12HoursFormat.JP;
            gcTime1.DropDownPicker.Show12Hours = true;
            gcTime1.DropDownPicker.Show12HoursFormat = Show12HoursFormat.JP;
        }
    }
}
