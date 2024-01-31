Imports System.Windows.Forms
Imports GrapeCity.Win.Editors
Imports GrapeCity.Win.Editors.Fields

Namespace _02_Format
	Public Partial Class GcDateTime
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
			InitializeComponent()
			InitializeForm()
		End Sub

		Private fieldName As String() = {"DateEraField", "DateEraYearField", "DateYearField", "DateMonthField", "DateDayField", "DateAmPmField", _
			"DateShortHourField", "DateHourField", "DateMinuteField", "DateSecondField"}
		Private fieldValue As String() = {"年号入力フィールド", "和暦入力フィールド", "年入力フィールド", "月入力フィールド", "日入力フィールド", "午前／午後入力フィールド", _
			"12時間制時刻入力フィールド", "時間入力フィールド", "分入力フィールド", "秒入力フィールド"}

		Private Sub InitializeForm()
			' ***** 初期値
			gcComboBox1.SelectedIndex = 0
			gcComboBox2.SelectedIndex = 0
			gcComboBox3.SelectedIndex = Convert.ToInt32(gcDateTime1.FieldsEditMode)
			gcComboBox4.SelectedIndex = Convert.ToInt32(gcDateTime1.ValidateMode)
			gcComboBox5.SelectedIndex = Convert.ToInt32(gcDateTime1.AcceptsCrLf)
			gcComboBox7.SelectedIndex = Convert.ToInt32(gcDateTime1.HighlightText)
			setDateFieldstoCombo()
		End Sub

        Private Sub gcComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox1.SelectedIndexChanged
            ' 入力書式の設定
            gcDateTime1.Fields.Clear()
            gcDateTime1.Fields.AddRange(gcComboBox1.Text)
            setDateFieldstoCombo()
        End Sub

        Private Sub gcComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            ' 表示書式の設定
            gcDateTime1.DisplayFields.Clear()
            gcDateTime1.DisplayFields.AddRange(gcComboBox2.Text)
        End Sub

        Private Sub gcComboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox3.SelectedIndexChanged
            ' FieldsEditModeプロパティ
            gcDateTime1.FieldsEditMode = CType(gcComboBox3.SelectedIndex, FieldsEditMode)
        End Sub

        Private Sub gcComboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox4.SelectedIndexChanged
            ' ValidateModeプロパティ
            gcDateTime1.ValidateMode = CType(gcComboBox4.SelectedIndex, ValidateModeEx)
        End Sub

        Private Sub gcComboBox5_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox5.SelectedIndexChanged
            ' AcceptsCrLfプロパティ
            gcDateTime1.AcceptsCrLf = CType(gcComboBox5.SelectedIndex, CrLfMode)
        End Sub

        Private Sub gcComboBox7_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox7.SelectedIndexChanged
            ' HighlightTextプロパティ
            gcDateTime1.HighlightText = CType(gcComboBox7.SelectedIndex, HighlightText)
        End Sub

        Private Sub gcComboBox6_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox6.SelectedIndexChanged
            ' DefaultActiveFieldプロパティ
            Select Case gcComboBox6.Text
                Case "DateEraField"
                    gcDateTime1.DefaultActiveField = gcDateTime1.Fields.Find(Of DateEraField)()
                    Exit Select
                Case "DateEraYearField"
                    gcDateTime1.DefaultActiveField = gcDateTime1.Fields.Find(Of DateEraYearField)()
                    Exit Select
                Case "DateYearField"
                    gcDateTime1.DefaultActiveField = gcDateTime1.Fields.Find(Of DateYearField)()
                    Exit Select
                Case "DateMonthField"
                    gcDateTime1.DefaultActiveField = gcDateTime1.Fields.Find(Of DateMonthField)()
                    Exit Select
                Case "DateDayField"
                    gcDateTime1.DefaultActiveField = gcDateTime1.Fields.Find(Of DateDayField)()
                    Exit Select
                Case "DateAmPmField"
                    gcDateTime1.DefaultActiveField = gcDateTime1.Fields.Find(Of DateAmPmField)()
                    Exit Select
                Case "DateShortHourField"
                    gcDateTime1.DefaultActiveField = gcDateTime1.Fields.Find(Of DateShortHourField)()
                    Exit Select
                Case "DateHourField"
                    gcDateTime1.DefaultActiveField = gcDateTime1.Fields.Find(Of DateHourField)()
                    Exit Select
                Case "DateMinuteField"
                    gcDateTime1.DefaultActiveField = gcDateTime1.Fields.Find(Of DateMinuteField)()
                    Exit Select
                Case "DateSecondField"
                    gcDateTime1.DefaultActiveField = gcDateTime1.Fields.Find(Of DateSecondField)()
                    Exit Select
                Case Else
                    gcDateTime1.DefaultActiveField = Nothing
                    Exit Select
            End Select
        End Sub

		Private Sub setDateFieldstoCombo()
			' 設定された書式からDefaultActiveFieldコンボに表示するフィールドを取得設定する
			gcComboBox6.SelectedIndex = -1
			gcComboBox6.Items.Clear()
			Dim fieldCollection As DateTimeFieldCollection = gcDateTime1.Fields
			For Each item As DateField In fieldCollection
				If TypeOf item Is DateLiteralField = False Then
					gcComboBox6.Items.Add(New ListItem(item.[GetType]().Name, fieldValue(Array.IndexOf(fieldName, item.[GetType]().Name))))
				End If
			Next
			gcComboBox6.SelectedIndex = 0
		End Sub
	End Class
End Namespace
