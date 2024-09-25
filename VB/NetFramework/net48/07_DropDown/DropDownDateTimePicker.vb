Imports GrapeCity.Win.Editors

Namespace _07_DropDown
    Partial Public Class DropDownDateTimePicker
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            ' ***** 初期値
            gcDateTime1.Value = DateTime.Now
            gcDateTime2.Value = DateTime.Now
            gcDate1.Value = DateTime.Now

            gcDateTime1.DropDown.DropDownType = DateDropDownType.Picker
            gcDateTime2.DropDown.DropDownType = DateDropDownType.CalendarPicker
            gcDate1.DropDown.DropDownType = DateDropDownType.Picker

            gcComboBox1.SelectedIndex = 1
            gcComboBox2.SelectedIndex = 0
            gcComboBox3.SelectedIndex = 0

            gcComboBox4.SelectedIndex = 0
            gcComboBox5.SelectedIndex = 0
            gcComboBox6.SelectedIndex = 0
            gcComboBox7.SelectedIndex = 0
        End Sub

        Private Sub gcColorPicker1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcColorPicker1.SelectedIndexChanged
            ' ピッカーのForeColorプロパティ
            GcDateTime1.DropDownPicker.ForeColor = gcColorPicker1.SelectedColor
            gcDateTime2.DropDownCalendarPicker.TimePicker.ForeColor = gcColorPicker1.SelectedColor
            gcDate1.DropDownPicker.ForeColor = gcColorPicker1.SelectedColor
            gcTime1.DropDownPicker.ForeColor = gcColorPicker1.SelectedColor
        End Sub

        Private Sub gcColorPicker2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcColorPicker2.SelectedIndexChanged
            ' ピッカーのBackColorプロパティ
            GcDateTime1.DropDownPicker.BackColor = gcColorPicker2.SelectedColor
            gcDateTime2.DropDownCalendarPicker.TimePicker.BackColor = gcColorPicker2.SelectedColor
            gcDate1.DropDownPicker.BackColor = gcColorPicker2.SelectedColor
            gcTime1.DropDownPicker.BackColor = gcColorPicker2.SelectedColor

        End Sub

        Private Sub gcComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox1.SelectedIndexChanged
            ' ピッカーのBorderStyleプロパティ
            If gcComboBox1.SelectedIndex = 0 Then
                GcDateTime1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.None
                gcDateTime2.DropDownCalendarPicker.BorderStyle = System.Windows.Forms.BorderStyle.None
                gcDate1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.None
                gcTime1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.None
                GcColorPicker3.Enabled = False
            ElseIf gcComboBox1.SelectedIndex = 1 Then
                GcDateTime1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                gcDateTime2.DropDownCalendarPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                gcDate1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                gcTime1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                GcColorPicker3.Enabled = True
            ElseIf gcComboBox1.SelectedIndex = 2 Then
                GcDateTime1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
                gcDateTime2.DropDownCalendarPicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
                gcDate1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
                gcTime1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
                GcColorPicker3.Enabled = False
            End If
        End Sub
        Private Sub GcColorPicker3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcColorPicker3.SelectedIndexChanged
            ' ピッカーのSingleBorderColorプロパティ
            GcDateTime1.DropDownPicker.SingleBorderColor = GcColorPicker3.SelectedColor
            gcDateTime2.DropDownCalendarPicker.SingleBorderColor = gcColorPicker3.SelectedColor
            gcDate1.DropDownPicker.SingleBorderColor = gcColorPicker3.SelectedColor
            gcTime1.DropDownPicker.SingleBorderColor = GcColorPicker3.SelectedColor
        End Sub

        Private Sub GcColorPicker4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcColorPicker4.SelectedIndexChanged
            ' 選択領域のSelectedForeColorプロパティ
            GcDateTime1.DropDownPicker.SelectedForeColor = GcColorPicker4.SelectedColor
            gcDateTime2.DropDownCalendarPicker.TimePicker.SelectedForeColor = gcColorPicker4.SelectedColor
            gcDate1.DropDownPicker.SelectedForeColor = gcColorPicker4.SelectedColor
            gcTime1.DropDownPicker.SelectedForeColor = GcColorPicker4.SelectedColor

        End Sub

        Private Sub GcColorPicker5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcColorPicker5.SelectedIndexChanged
            ' 選択領域のSelectedBackColorプロパティ
            GcDateTime1.DropDownPicker.SelectedBackColor = GcColorPicker5.SelectedColor
            gcDateTime2.DropDownCalendarPicker.TimePicker.SelectedBackColor = gcColorPicker5.SelectedColor
            gcDate1.DropDownPicker.SelectedBackColor = gcColorPicker5.SelectedColor
            gcTime1.DropDownPicker.SelectedBackColor = GcColorPicker5.SelectedColor

        End Sub

        Private Sub GcComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            ' 選択領域のSelectionRenderModeプロパティ
            If GcComboBox2.SelectedIndex = 0 Then
                GcDateTime1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.Border
                gcDateTime1.DropDownCalendarPicker.TimePicker.SelectionRenderMode = SelectionRenderMode.Border
                gcDate1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.Border
                gcTime1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.Border
                GcColorPicker5.Enabled = False
                GcColorPicker6.Enabled = True
            ElseIf GcComboBox2.SelectedIndex = 1 Then
                GcDateTime1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.Fill
                gcDateTime1.DropDownCalendarPicker.TimePicker.SelectionRenderMode = SelectionRenderMode.Fill
                gcDate1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.Fill
                gcTime1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.Fill
                GcColorPicker5.Enabled = True
                GcColorPicker6.Enabled = False
            ElseIf GcComboBox2.SelectedIndex = 2 Then
                GcDateTime1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.BorderWithFill
                gcDateTime1.DropDownCalendarPicker.TimePicker.SelectionRenderMode = SelectionRenderMode.BorderWithFill
                gcDate1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.BorderWithFill
                gcTime1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.BorderWithFill
                GcColorPicker5.Enabled = True
                GcColorPicker6.Enabled = True
            End If
        End Sub

        Private Sub GcColorPicker6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcColorPicker6.SelectedIndexChanged
            ' 選択領域のSelectedBorderColorプロパティ
            GcDateTime1.DropDownPicker.SelectedBorderColor = GcColorPicker6.SelectedColor
            gcDateTime2.DropDownCalendarPicker.TimePicker.SelectedBorderColor = gcColorPicker6.SelectedColor
            gcDate1.DropDownPicker.SelectedBorderColor = gcColorPicker6.SelectedColor
            gcTime1.DropDownPicker.SelectedBorderColor = GcColorPicker6.SelectedColor
        End Sub

        Private Sub GcComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox3.SelectedIndexChanged
            gcDateTime1.DropDownPicker.YearFormat = gcComboBox3.SelectedValue.ToString()
            gcDate1.DropDownPicker.YearFormat = gcComboBox3.SelectedValue.ToString()
        End Sub

        Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox1.CheckedChanged
            gcDateTime1.DropDownPicker.ShowHours = checkBox1.Checked
            gcDateTime2.DropDownCalendarPicker.TimePicker.ShowHours = checkBox1.Checked
            gcTime1.DropDownPicker.ShowHours = checkBox1.Checked
        End Sub

        Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox2.CheckedChanged
            gcDateTime1.DropDownPicker.ShowMinutes = checkBox2.Checked
            gcDateTime2.DropDownCalendarPicker.TimePicker.ShowMinutes = checkBox2.Checked
            gcTime1.DropDownPicker.ShowMinutes = checkBox2.Checked
        End Sub

        Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox3.CheckedChanged
            gcDateTime1.DropDownPicker.ShowSeconds = checkBox3.Checked
            gcDateTime2.DropDownCalendarPicker.TimePicker.ShowSeconds = checkBox3.Checked
            gcTime1.DropDownPicker.ShowSeconds = checkBox3.Checked
        End Sub

        Private Sub GcComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox4.SelectedIndexChanged
            gcDateTime1.DropDownPicker.HoursInterval = Integer.Parse(gcComboBox4.SelectedValue.ToString())
            gcDateTime2.DropDownCalendarPicker.TimePicker.HoursInterval = Integer.Parse(gcComboBox4.SelectedValue.ToString())
            gcTime1.DropDownPicker.HoursInterval = Integer.Parse(gcComboBox4.SelectedValue.ToString())
        End Sub

        Private Sub GcComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox5.SelectedIndexChanged
            gcDateTime1.DropDownPicker.MinutesInterval = Integer.Parse(gcComboBox5.SelectedValue.ToString())
            gcDateTime2.DropDownCalendarPicker.TimePicker.MinutesInterval = Integer.Parse(gcComboBox5.SelectedValue.ToString())
            gcTime1.DropDownPicker.MinutesInterval = Integer.Parse(gcComboBox5.SelectedValue.ToString())
        End Sub

        Private Sub GcComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox6.SelectedIndexChanged
            gcDateTime1.DropDownPicker.SecondsInterval = Integer.Parse(gcComboBox6.SelectedValue.ToString())
            gcDateTime2.DropDownCalendarPicker.TimePicker.SecondsInterval = Integer.Parse(gcComboBox6.SelectedValue.ToString())
            gcTime1.DropDownPicker.SecondsInterval = Integer.Parse(gcComboBox6.SelectedValue.ToString())
        End Sub

        Private Sub gcComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox7.SelectedIndexChanged
            If gcComboBox7.SelectedIndex = 0 Then
                gcDateTime1.DropDownPicker.Show12Hours = False
                gcDateTime2.DropDownCalendarPicker.TimePicker.Show12Hours = False
                gcTime1.DropDownPicker.Show12Hours = False
            ElseIf gcComboBox7.SelectedIndex = 1 Then
                gcDateTime1.DropDownPicker.Show12Hours = True
                gcDateTime1.DropDownPicker.Show12HoursFormat = Show12HoursFormat.EN
                gcDateTime2.DropDownCalendarPicker.TimePicker.Show12Hours = True
                gcDateTime2.DropDownCalendarPicker.TimePicker.Show12HoursFormat = Show12HoursFormat.EN
                gcTime1.DropDownPicker.Show12Hours = True
                gcTime1.DropDownPicker.Show12HoursFormat = Show12HoursFormat.EN
            ElseIf gcComboBox7.SelectedIndex = 2 Then
                gcDateTime1.DropDownPicker.Show12Hours = True
                gcDateTime1.DropDownPicker.Show12HoursFormat = Show12HoursFormat.JP
                gcDateTime2.DropDownCalendarPicker.TimePicker.Show12Hours = True
                gcDateTime2.DropDownCalendarPicker.TimePicker.Show12HoursFormat = Show12HoursFormat.JP
                gcTime1.DropDownPicker.Show12Hours = True
                gcTime1.DropDownPicker.Show12HoursFormat = Show12HoursFormat.JP
            End If
        End Sub
    End Class
End Namespace