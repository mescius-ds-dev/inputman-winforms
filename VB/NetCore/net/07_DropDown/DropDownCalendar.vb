Imports System.Drawing
Imports System.Windows.Forms
Imports GrapeCity.Win.Editors

Namespace _07_DropDown
	Public Partial Class DropDownCalendar
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
			InitializeComponent()
			InitializeForm()
		End Sub

		Private Sub InitializeForm()
			' ***** 初期設定
			AddHandler gcComboBox1.SelectedIndexChanged, New EventHandler(AddressOf gcComboBox1_SelectedIndexChanged)
			AddHandler gcNumber1.TextChanging, New TextChangingEventHandler(AddressOf gcNumber1_TextChanging)
			AddHandler gcNumber2.TextChanging, New TextChangingEventHandler(AddressOf gcNumber2_TextChanging)
			AddHandler checkBox1.CheckedChanged, New EventHandler(AddressOf checkBox1_CheckedChanged)
			AddHandler checkBox2.CheckedChanged, New EventHandler(AddressOf checkBox2_CheckedChanged)
			AddHandler checkBox3.CheckedChanged, New EventHandler(AddressOf checkBox3_CheckedChanged)
			AddHandler checkBox4.CheckedChanged, New EventHandler(AddressOf checkBox4_CheckedChanged)
			AddHandler checkBox5.CheckedChanged, New EventHandler(AddressOf checkBox5_CheckedChanged)
			AddHandler checkBox6.CheckedChanged, New EventHandler(AddressOf checkBox6_CheckedChanged)

			' ***** 初期値
			gcComboBox1.SelectedIndex = Convert.ToInt32(gcDate1.DropDownCalendar.CalendarType)
			checkBox3.Checked = gcDate1.DropDownCalendar.ShowTrailing
			checkBox4.Checked = gcDate1.DropDownCalendar.ShowToday
			checkBox5.Checked = gcDate1.DropDownCalendar.ShowWeekNumber
			gcDateTime1.Value = DateTime.Now
			gcDate1.Value = DateTime.Now
			gcDateTime1.DropDownCalendar.HeaderFormat = "ggge年MMMM"
			gcDate1.DropDownCalendar.HeaderFormat = "ggge年MMMM"

			' xmlファイルから祝日データ取得
			Dim filePath As System.String = Application.StartupPath
			gcDateTime1.DropDownCalendar.HolidayStyles = HolidayStyleCollection.Load(filePath & "\Resources\Holiday.xml")
			gcDate1.DropDownCalendar.HolidayStyles = HolidayStyleCollection.Load(filePath & "\Resources\Holiday.xml")
		End Sub

        Private Sub gcComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox1.SelectedIndexChanged
            ' カレンダーのタイプ
            gcDateTime1.DropDownCalendar.CalendarType = CType(gcComboBox1.SelectedIndex, CalendarType)
            gcDate1.DropDownCalendar.CalendarType = CType(gcComboBox1.SelectedIndex, CalendarType)
            If gcComboBox1.SelectedIndex = 0 Then
                checkBox1.Enabled = True
                checkBox2.Enabled = True
                checkBox3.Enabled = True
                checkBox5.Enabled = True
            Else
                checkBox1.Enabled = False
                checkBox2.Enabled = False
                checkBox3.Enabled = False
                checkBox5.Enabled = False
            End If
        End Sub

        Private Sub gcNumber1_TextChanging(ByVal sender As Object, ByVal e As TextChangingEventArgs) Handles gcNumber1.TextChanging
            ' カレンダーに表示する月数／年数
            If e.Result = "0" Then
                e.Cancel = True
                Return
            End If

            If (Convert.ToInt32(e.Result) * gcNumber2.Value.Value) > 12 Then
                e.Cancel = True
            Else
                gcDateTime1.DropDownCalendar.CalendarDimensions = New Size(Convert.ToInt32(e.Result), Convert.ToInt32(gcNumber2.Value.Value))
                gcDate1.DropDownCalendar.CalendarDimensions = New Size(Convert.ToInt32(e.Result), Convert.ToInt32(gcNumber2.Value.Value))
            End If
        End Sub

        Private Sub gcNumber2_TextChanging(ByVal sender As Object, ByVal e As TextChangingEventArgs) Handles gcNumber2.TextChanging
            ' カレンダーに表示する月数／年数
            If e.Result = "0" Then
                e.Cancel = True
                Return
            End If

            If gcNumber1.Value.Value * (Convert.ToInt32(e.Result)) > 12 Then
                e.Cancel = True
            Else
                gcDateTime1.DropDownCalendar.CalendarDimensions = New Size(Convert.ToInt32(gcNumber1.Value.Value), Convert.ToInt32(e.Result))
                gcDate1.DropDownCalendar.CalendarDimensions = New Size(Convert.ToInt32(gcNumber1.Value.Value), Convert.ToInt32(e.Result))
            End If
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            ' 土日の色の変更
            If checkBox1.Checked Then
                gcDateTime1.DropDownCalendar.Weekdays = New WeekdaysStyle(New DayOfWeekStyle("日", ReflectTitle.ForeColor, New SubStyle(SystemColors.Window, Color.Red, False, False), WeekFlags.All), New DayOfWeekStyle("月", ReflectTitle.ForeColor, New SubStyle(SystemColors.Window, SystemColors.WindowText, False, False), WeekFlags.None), New DayOfWeekStyle("火", ReflectTitle.ForeColor, New SubStyle(SystemColors.Window, SystemColors.WindowText, False, False), WeekFlags.None), New DayOfWeekStyle("水", ReflectTitle.ForeColor, New SubStyle(SystemColors.Window, SystemColors.WindowText, False, False), WeekFlags.None), New DayOfWeekStyle("木", ReflectTitle.ForeColor, New SubStyle(SystemColors.Window, SystemColors.WindowText, False, False), WeekFlags.None), New DayOfWeekStyle("金", ReflectTitle.ForeColor, New SubStyle(SystemColors.Window, SystemColors.WindowText, False, False), WeekFlags.None), _
                 New DayOfWeekStyle("土", ReflectTitle.ForeColor, New SubStyle(SystemColors.Window, Color.Blue, False, False), WeekFlags.All))
                gcDate1.DropDownCalendar.Weekdays = New WeekdaysStyle(New DayOfWeekStyle("日", ReflectTitle.ForeColor, New SubStyle(SystemColors.Window, Color.Red, False, False), WeekFlags.All), New DayOfWeekStyle("月", ReflectTitle.ForeColor, New SubStyle(SystemColors.Window, SystemColors.WindowText, False, False), WeekFlags.None), New DayOfWeekStyle("火", ReflectTitle.ForeColor, New SubStyle(SystemColors.Window, SystemColors.WindowText, False, False), WeekFlags.None), New DayOfWeekStyle("水", ReflectTitle.ForeColor, New SubStyle(SystemColors.Window, SystemColors.WindowText, False, False), WeekFlags.None), New DayOfWeekStyle("木", ReflectTitle.ForeColor, New SubStyle(SystemColors.Window, SystemColors.WindowText, False, False), WeekFlags.None), New DayOfWeekStyle("金", ReflectTitle.ForeColor, New SubStyle(SystemColors.Window, SystemColors.WindowText, False, False), WeekFlags.None), _
                 New DayOfWeekStyle("土", ReflectTitle.ForeColor, New SubStyle(SystemColors.Window, Color.Blue, False, False), WeekFlags.All))
            Else
                gcDateTime1.DropDownCalendar.Weekdays = Nothing
                gcDate1.DropDownCalendar.Weekdays = Nothing
            End If
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
            ' 祝日の表示
            If checkBox2.Checked Then
                gcDateTime1.DropDownCalendar.ActiveHolidayStyles = New String() {"NationalHoliday"}
                gcDate1.DropDownCalendar.ActiveHolidayStyles = New String() {"NationalHoliday"}
            Else
                gcDateTime1.DropDownCalendar.ActiveHolidayStyles = New String() {""}
                gcDate1.DropDownCalendar.ActiveHolidayStyles = New String() {""}
            End If

        End Sub

        Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox3.CheckedChanged
            ' 隣接日の表示
            gcDateTime1.DropDownCalendar.ShowTrailing = checkBox3.Checked
            gcDate1.DropDownCalendar.ShowTrailing = checkBox3.Checked
        End Sub

        Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox4.CheckedChanged
            ' 今日の日付の表示
            gcDateTime1.DropDownCalendar.ShowToday = checkBox4.Checked
            gcDate1.DropDownCalendar.ShowToday = checkBox4.Checked
        End Sub

        Private Sub checkBox5_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox5.CheckedChanged
            ' 週番号の表示
            gcDateTime1.DropDownCalendar.ShowWeekNumber = checkBox5.Checked
            gcDate1.DropDownCalendar.ShowWeekNumber = checkBox5.Checked
        End Sub

        Private Sub checkBox6_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox6.CheckedChanged
            ' ヘッダを和暦で表示
            gcDateTime1.DropDownCalendar.UseHeaderFormat = checkBox6.Checked
            gcDate1.DropDownCalendar.UseHeaderFormat = checkBox6.Checked

            If checkBox6.Checked Then
                gcDateTime1.DropDownCalendar.YearMonthFormat.YearFormat = "ggge年"
                gcDate1.DropDownCalendar.YearMonthFormat.YearFormat = "ggge年"
            Else
                gcDateTime1.DropDownCalendar.YearMonthFormat.YearFormat = "yyy"
                gcDate1.DropDownCalendar.YearMonthFormat.YearFormat = "yyy"
            End If
        End Sub
	End Class
End Namespace
