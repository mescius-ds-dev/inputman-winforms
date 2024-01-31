Imports GrapeCity.Win.Editors
Imports GrapeCity.Win.Editors.Fields

Namespace _02_Format
	Public Partial Class GcTimeSpan
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
			InitializeComponent()
			InitializeForm()
		End Sub

		Private fieldName As String() = {"TimeSpanSignField", "TimeSpanDayField", "TimeSpanHourField", "TimeSpanMinuteField", "TimeSpanSecondField", "TimeSpanDecimalField"}
		Private fieldValue As String() = {"符号入力フィールドド", "日入力フィールド", "時間入力フィールド", "分入力フィールド", "秒入力フィールド", "小数入力フィールド"}

		Private Sub InitializeForm()
			' ***** 初期値
			gcComboBox1.SelectedIndex = 0
			gcComboBox2.SelectedIndex = 0
			gcComboBox3.SelectedIndex = Convert.ToInt32(gcTimeSpan1.ValidateMode)
			gcComboBox4.SelectedIndex = Convert.ToInt32(gcTimeSpan1.AcceptsCrLf)
			gcComboBox5.SelectedIndex = Convert.ToInt32(gcTimeSpan1.HighlightText)
			setTimeSpanFieldstoCombo()
		End Sub

        Private Sub gcComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox1.SelectedIndexChanged
            ' 入力書式の設定
            gcTimeSpan1.Fields.Clear()
            gcTimeSpan1.Fields.AddRange(gcComboBox1.Text, 0, Convert.ToChar("."), "", "", "-", _
             "")
            setTimeSpanFieldstoCombo()
        End Sub

        Private Sub gcComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            ' 表示書式の設定
            gcTimeSpan1.DisplayFields.Clear()
            gcTimeSpan1.DisplayFields.AddRange(gcComboBox2.Text, 0, Convert.ToChar("."), "", "", "-", _
             "")
        End Sub

        Private Sub gcComboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox3.SelectedIndexChanged
            ' ValidateModeプロパティ
            gcTimeSpan1.ValidateMode = CType(gcComboBox3.SelectedIndex, ValidateMode)
        End Sub

        Private Sub gcComboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox4.SelectedIndexChanged
            ' AcceptsCrLfプロパティ
            gcTimeSpan1.AcceptsCrLf = CType(gcComboBox4.SelectedIndex, CrLfMode)
        End Sub

        Private Sub gcComboBox5_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox5.SelectedIndexChanged
            ' HighlightTextプロパティ
            gcTimeSpan1.HighlightText = CType(gcComboBox5.SelectedIndex, HighlightText)
        End Sub

        Private Sub gcComboBox6_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox6.SelectedIndexChanged
            ' DefaultActiveFieldプロパティ
            Select Case gcComboBox6.Text
                Case "TimeSpanSignField"
                    gcTimeSpan1.DefaultActiveField = gcTimeSpan1.Fields.Find(Of TimeSpanSignField)()
                    Exit Select
                Case "TimeSpanDayField"
                    gcTimeSpan1.DefaultActiveField = gcTimeSpan1.Fields.Find(Of TimeSpanDayField)()
                    Exit Select
                Case "TimeSpanHourField"
                    gcTimeSpan1.DefaultActiveField = gcTimeSpan1.Fields.Find(Of TimeSpanHourField)()
                    Exit Select
                Case "TimeSpanMinuteField"
                    gcTimeSpan1.DefaultActiveField = gcTimeSpan1.Fields.Find(Of TimeSpanMinuteField)()
                    Exit Select
                Case "TimeSpanSecondField"
                    gcTimeSpan1.DefaultActiveField = gcTimeSpan1.Fields.Find(Of TimeSpanSecondField)()
                    Exit Select
                Case "TimeSpanDecimalField"
                    gcTimeSpan1.DefaultActiveField = gcTimeSpan1.Fields.Find(Of TimeSpanDecimalField)()
                    Exit Select
                Case Else
                    gcTimeSpan1.DefaultActiveField = Nothing
                    Exit Select
            End Select
        End Sub

		Private Sub setTimeSpanFieldstoCombo()
			' 設定された書式からDefaultActiveFieldコンボに表示するフィールドを取得設定する
			gcComboBox6.SelectedIndex = -1
			gcComboBox6.Items.Clear()
			Dim fieldCollection As TimeSpanFieldCollection = gcTimeSpan1.Fields
			For Each item As TimeSpanField In fieldCollection
				If TypeOf item Is TimeSpanSignField = False AndAlso TypeOf item Is TimeSpanDecimalField = False AndAlso TypeOf item Is TimeSpanLiteralField = False Then
					gcComboBox6.Items.Add(New ListItem(item.[GetType]().Name, fieldValue(Array.IndexOf(fieldName, item.[GetType]().Name))))
				End If
			Next
			gcComboBox6.SelectedIndex = 0
		End Sub
	End Class
End Namespace
