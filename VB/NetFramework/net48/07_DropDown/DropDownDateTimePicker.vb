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
            gcDate1.Value = DateTime.Now

            gcDateTime1.DropDown.DropDownType = DateDropDownType.Picker
            gcDate1.DropDown.DropDownType = DateDropDownType.Picker

            gcComboBox1.SelectedIndex = 1
            gcComboBox2.SelectedIndex = 0
            gcComboBox3.SelectedIndex = 0

            gcComboBox4.SelectedIndex = 0
            gcComboBox5.SelectedIndex = 0
            gcComboBox6.SelectedIndex = 0

        End Sub

        Private Sub gcColorPicker1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcColorPicker1.SelectedIndexChanged
            ' ピッカーのForeColorプロパティ
            GcDateTime1.DropDownPicker.ForeColor = gcColorPicker1.SelectedColor
            GcDate1.DropDownPicker.ForeColor = gcColorPicker1.SelectedColor
            GcTime1.DropDownPicker.ForeColor = gcColorPicker1.SelectedColor
        End Sub

        Private Sub gcColorPicker2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcColorPicker2.SelectedIndexChanged
            ' ピッカーのBackColorプロパティ
            GcDateTime1.DropDownPicker.BackColor = gcColorPicker2.SelectedColor
            GcDate1.DropDownPicker.BackColor = gcColorPicker2.SelectedColor
            GcTime1.DropDownPicker.BackColor = gcColorPicker2.SelectedColor

        End Sub

        Private Sub gcComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox1.SelectedIndexChanged
            ' ピッカーのBorderStyleプロパティ
            If gcComboBox1.SelectedIndex = 0 Then
                GcDateTime1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.None
                GcDate1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.None
                GcTime1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.None
                GcColorPicker3.Enabled = False
            ElseIf gcComboBox1.SelectedIndex = 1 Then
                GcDateTime1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                GcDate1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                GcTime1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                GcColorPicker3.Enabled = True
            ElseIf gcComboBox1.SelectedIndex = 2 Then
                GcDateTime1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
                GcDate1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
                GcTime1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
                GcColorPicker3.Enabled = False
            End If
        End Sub
        Private Sub GcColorPicker3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcColorPicker3.SelectedIndexChanged
            ' ピッカーのSingleBorderColorプロパティ
            GcDateTime1.DropDownPicker.SingleBorderColor = GcColorPicker3.SelectedColor
            GcDate1.DropDownPicker.SingleBorderColor = GcColorPicker3.SelectedColor
            GcTime1.DropDownPicker.SingleBorderColor = GcColorPicker3.SelectedColor
        End Sub

        Private Sub GcColorPicker4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcColorPicker4.SelectedIndexChanged
            ' 選択領域のSelectedForeColorプロパティ
            GcDateTime1.DropDownPicker.SelectedForeColor = GcColorPicker4.SelectedColor
            GcDate1.DropDownPicker.SelectedForeColor = GcColorPicker4.SelectedColor
            GcTime1.DropDownPicker.SelectedForeColor = GcColorPicker4.SelectedColor

        End Sub

        Private Sub GcColorPicker5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcColorPicker5.SelectedIndexChanged
            ' 選択領域のSelectedBackColorプロパティ
            GcDateTime1.DropDownPicker.SelectedBackColor = GcColorPicker5.SelectedColor
            GcDate1.DropDownPicker.SelectedBackColor = GcColorPicker5.SelectedColor
            GcTime1.DropDownPicker.SelectedBackColor = GcColorPicker5.SelectedColor

        End Sub

        Private Sub GcComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            ' 選択領域のSelectionRenderModeプロパティ
            If GcComboBox2.SelectedIndex = 0 Then
                GcDateTime1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.Border
                GcDate1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.Border
                GcTime1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.Border
                GcColorPicker5.Enabled = False
                GcColorPicker6.Enabled = True
            ElseIf GcComboBox2.SelectedIndex = 1 Then
                GcDateTime1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.Fill
                GcDate1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.Fill
                GcTime1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.Fill
                GcColorPicker5.Enabled = True
                GcColorPicker6.Enabled = False
            ElseIf GcComboBox2.SelectedIndex = 2 Then
                GcDateTime1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.BorderWithFill
                GcDate1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.BorderWithFill
                GcTime1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.BorderWithFill
                GcColorPicker5.Enabled = True
                GcColorPicker6.Enabled = True
            End If
        End Sub

        Private Sub GcColorPicker6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcColorPicker6.SelectedIndexChanged
            ' 選択領域のSelectedBorderColorプロパティ
            GcDateTime1.DropDownPicker.SelectedBorderColor = GcColorPicker6.SelectedColor
            GcDate1.DropDownPicker.SelectedBorderColor = GcColorPicker6.SelectedColor
            GcTime1.DropDownPicker.SelectedBorderColor = GcColorPicker6.SelectedColor
        End Sub

        Private Sub GcComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox3.SelectedIndexChanged
            gcDateTime1.DropDownPicker.YearFormat = gcComboBox3.SelectedValue.ToString()
            gcDate1.DropDownPicker.YearFormat = gcComboBox3.SelectedValue.ToString()
        End Sub

        Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox1.CheckedChanged
            gcDateTime1.DropDownPicker.ShowHours = checkBox1.Checked
            gcTime1.DropDownPicker.ShowHours = checkBox1.Checked
        End Sub

        Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox2.CheckedChanged
            gcDateTime1.DropDownPicker.ShowMinutes = checkBox2.Checked
            gcTime1.DropDownPicker.ShowMinutes = checkBox2.Checked
        End Sub

        Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox3.CheckedChanged
            gcDateTime1.DropDownPicker.ShowSeconds = checkBox3.Checked
            gcTime1.DropDownPicker.ShowSeconds = checkBox3.Checked
        End Sub

        Private Sub GcComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox4.SelectedIndexChanged
            gcDateTime1.DropDownPicker.HoursInterval = Integer.Parse(gcComboBox4.SelectedValue.ToString())
            gcTime1.DropDownPicker.HoursInterval = Integer.Parse(gcComboBox4.SelectedValue.ToString())
        End Sub

        Private Sub GcComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox5.SelectedIndexChanged
            gcDateTime1.DropDownPicker.MinutesInterval = Integer.Parse(gcComboBox5.SelectedValue.ToString())
            gcTime1.DropDownPicker.MinutesInterval = Integer.Parse(gcComboBox5.SelectedValue.ToString())
        End Sub

        Private Sub GcComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox6.SelectedIndexChanged
            gcDateTime1.DropDownPicker.SecondsInterval = Integer.Parse(gcComboBox6.SelectedValue.ToString())
            gcTime1.DropDownPicker.SecondsInterval = Integer.Parse(gcComboBox6.SelectedValue.ToString())
        End Sub
    End Class
End Namespace