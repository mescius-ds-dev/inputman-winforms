
Namespace _08_SideButton
	Public Partial Class SpinButton
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
			InitializeComponent()
			InitializeForm()
		End Sub

		Private Sub InitializeForm()
			' ***** 初期値
			checkBox1.Checked = gcMask1.Spin.AllowSpin
			checkBox2.Checked = gcMask1.Spin.SpinOnKeys
			checkBox3.Checked = gcMask1.Spin.Wrap
			checkBox4.Checked = gcMask1.Spin.SpinOnWheel

			gcNumber2.Value = Convert.ToDecimal(gcMask1.Spin.Increment)

			gcComboBox4.SelectedIndex = Convert.ToInt32(gcDateTime1.Spin.SpinMode)
			gcNumber3.Value = Convert.ToInt32(gcDateTime1.Spin.Increment)
			gcTimeSpan2.Value = gcDateTime1.Spin.IncrementValue

			gcComboBox5.SelectedIndex = Convert.ToInt32(gcDate1.Spin.SpinMode)
			gcNumber4.Value = Convert.ToInt32(gcDate1.Spin.Increment)
			gcTimeSpan3.Value = gcDate1.Spin.IncrementValue

			gcComboBox6.SelectedIndex = Convert.ToInt32(gcTime1.Spin.SpinMode)
			gcNumber5.Value = Convert.ToInt32(gcTime1.Spin.Increment)
			gcTimeSpan4.Value = gcTime1.Spin.IncrementValue

			gcComboBox7.SelectedIndex = Convert.ToInt32(gcTimeSpan1.Spin.SpinMode)
			gcNumber6.Value = Convert.ToInt32(gcTimeSpan1.Spin.Increment)
			gcTimeSpan5.Value = gcTimeSpan1.Spin.IncrementValue

			gcComboBox8.SelectedIndex = Convert.ToInt32(gcNumber1.Spin.SpinMode)
			gcNumber7.Value = Convert.ToDecimal(gcNumber1.Spin.Increment)
			gcNumber8.Value = Convert.ToDecimal(gcNumber1.Spin.IncrementValue)

            gcNumber9.Value = Convert.ToDecimal(gcComboBox1.Spin.Increment)
            gcNumber9.Value = Convert.ToDecimal(GcMaskedComboBox1.Spin.Increment)
		End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            ' AllowSpinプロパティ
            gcMask1.Spin.AllowSpin = checkBox1.Checked
            gcComboBox1.Spin.AllowSpin = checkBox1.Checked
            gcDateTime1.Spin.AllowSpin = checkBox1.Checked
            gcDate1.Spin.AllowSpin = checkBox1.Checked
            gcTime1.Spin.AllowSpin = checkBox1.Checked
            gcTimeSpan1.Spin.AllowSpin = checkBox1.Checked
            gcNumber1.Spin.AllowSpin = checkBox1.Checked
            GcMaskedComboBox1.Spin.AllowSpin = checkBox1.Checked
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
            ' SpinOnKeysプロパティ
            gcMask1.Spin.SpinOnKeys = checkBox2.Checked
            gcComboBox1.Spin.SpinOnKeys = checkBox2.Checked
            gcDateTime1.Spin.SpinOnKeys = checkBox2.Checked
            gcDate1.Spin.SpinOnKeys = checkBox2.Checked
            gcTime1.Spin.SpinOnKeys = checkBox2.Checked
            gcTimeSpan1.Spin.SpinOnKeys = checkBox2.Checked
            gcNumber1.Spin.SpinOnKeys = checkBox2.Checked
            GcMaskedComboBox1.Spin.SpinOnKeys = checkBox2.Checked
        End Sub

        Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox3.CheckedChanged
            ' Wrapプロパティ
            gcMask1.Spin.Wrap = checkBox3.Checked
            gcComboBox1.Spin.Wrap = checkBox3.Checked
            gcDateTime1.Spin.Wrap = checkBox3.Checked
            gcDate1.Spin.Wrap = checkBox3.Checked
            gcTime1.Spin.Wrap = checkBox3.Checked
            gcTimeSpan1.Spin.Wrap = checkBox3.Checked
            gcNumber1.Spin.Wrap = checkBox3.Checked
            GcMaskedComboBox1.Spin.Wrap = checkBox3.Checked
        End Sub

        Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox4.CheckedChanged
            ' SpinOnWheelプロパティ
            gcMask1.Spin.SpinOnWheel = checkBox4.Checked
            gcComboBox1.Spin.SpinOnWheel = checkBox4.Checked
            gcDateTime1.Spin.SpinOnWheel = checkBox4.Checked
            gcDate1.Spin.SpinOnWheel = checkBox4.Checked
            gcTime1.Spin.SpinOnWheel = checkBox4.Checked
            gcTimeSpan1.Spin.SpinOnWheel = checkBox4.Checked
            gcNumber1.Spin.SpinOnWheel = checkBox4.Checked
            GcMaskedComboBox1.Spin.SpinOnWheel = checkBox4.Checked
        End Sub

        Private Sub gcNumber2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcNumber2.ValueChanged
            ' マスクのIncrementプロパティ
            gcMask1.Spin.Increment = Convert.ToInt32(gcNumber2.Value)
        End Sub

        Private Sub gcComboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox4.SelectedIndexChanged
            ' 日付時刻のSpinModeプロパティ
            gcDateTime1.Spin.SpinMode = CType(gcComboBox4.SelectedIndex, GrapeCity.Win.Editors.DateSpinMode)
        End Sub

        Private Sub gcNumber3_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcNumber3.ValueChanged
            ' 日付時刻のIncrementプロパティ
            gcDateTime1.Spin.Increment = Convert.ToInt32(gcNumber3.Value)
        End Sub

        Private Sub gcTimeSpan2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcTimeSpan2.ValueChanged
            ' 日付時刻のIncrementValueプロパティ
            If gcTimeSpan2.Value IsNot Nothing Then
                gcDateTime1.Spin.IncrementValue = gcTimeSpan2.Value.Value
            End If
        End Sub

        Private Sub gcComboBox5_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox5.SelectedIndexChanged
            ' 日付のSpinModeプロパティ
            gcDate1.Spin.SpinMode = CType(gcComboBox5.SelectedIndex, GrapeCity.Win.Editors.DateSpinMode)
        End Sub

        Private Sub gcNumber4_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcNumber4.ValueChanged
            ' 日付のIncrementプロパティ
            gcDate1.Spin.Increment = Convert.ToInt32(gcNumber4.Value)
        End Sub

        Private Sub gcTimeSpan3_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcTimeSpan3.ValueChanged
            ' 日付のIncrementValueプロパティ
            If gcTimeSpan3.Value IsNot Nothing Then
                gcDate1.Spin.IncrementValue = gcTimeSpan3.Value.Value
            End If
        End Sub

        Private Sub gcComboBox6_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox6.SelectedIndexChanged
            ' 時刻のSpinModeプロパティ
            gcTime1.Spin.SpinMode = CType(gcComboBox6.SelectedIndex, GrapeCity.Win.Editors.DateSpinMode)
        End Sub

        Private Sub gcNumber5_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcNumber5.ValueChanged
            ' 時刻のIncrementプロパティ
            gcTime1.Spin.Increment = Convert.ToInt32(gcNumber5.Value)
        End Sub

        Private Sub gcTimeSpan4_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcTimeSpan4.ValueChanged
            ' 時刻のIncrementValueプロパティ
            If gcTimeSpan4.Value IsNot Nothing Then
                gcTime1.Spin.IncrementValue = gcTimeSpan4.Value.Value
            End If
        End Sub

        Private Sub gcComboBox7_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox7.SelectedIndexChanged
            ' タイムスパンのSpinModeプロパティ
            gcTimeSpan1.Spin.SpinMode = CType(gcComboBox7.SelectedIndex, GrapeCity.Win.Editors.DateSpinMode)
        End Sub

        Private Sub gcNumber6_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcNumber6.ValueChanged
            ' タイムスパンのIncrementプロパティ
            gcTimeSpan1.Spin.Increment = Convert.ToInt32(gcNumber6.Value)
        End Sub

        Private Sub gcTimeSpan5_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcTimeSpan5.ValueChanged
            ' タイムスパンのIncrementValueプロパティ
            If gcTimeSpan5.Value IsNot Nothing Then
                gcTimeSpan1.Spin.IncrementValue = gcTimeSpan5.Value.Value
            End If
        End Sub

        Private Sub gcComboBox8_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox8.SelectedIndexChanged
            ' 数値のSpinModeプロパティ
            gcNumber1.Spin.SpinMode = CType(gcComboBox8.SelectedIndex, GrapeCity.Win.Editors.NumberSpinMode)
        End Sub

        Private Sub gcNumber7_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcNumber7.ValueChanged
            ' 数値のIncrementプロパティ
            gcNumber1.Spin.Increment = Convert.ToInt32(gcNumber7.Value)
        End Sub

        Private Sub gcNumber8_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcNumber8.ValueChanged
            ' 数値のIncrementValueプロパティ
            gcNumber1.Spin.IncrementValue = Convert.ToInt32(gcNumber8.Value)
        End Sub

        Private Sub gcNumber9_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcNumber9.ValueChanged
            ' コンボのIncrementプロパティ
            gcComboBox1.Spin.Increment = Convert.ToInt32(gcNumber9.Value)
            GcMaskedComboBox1.Spin.Increment = Convert.ToInt32(gcNumber9.Value)
        End Sub
	End Class
End Namespace
