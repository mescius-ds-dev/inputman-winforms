Imports GrapeCity.Win.Editors
Imports GrapeCity.Win.Editors.Fields

Namespace _02_Format
	Public Partial Class GcDate
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
			InitializeComponent()
			InitializeForm()
		End Sub

		Private fieldName As String() = {"DateEraField", "DateEraYearField", "DateYearField", "DateMonthField", "DateDayField"}
		Private fieldValue As String() = {"年号入力フィールド", "和暦入力フィールド", "年入力フィールド", "月入力フィールド", "日入力フィールド"}

		Private Sub InitializeForm()
			' ***** 初期値
			gcComboBox1.SelectedIndex = 0
			gcComboBox2.SelectedIndex = 0
			gcComboBox3.SelectedIndex = Convert.ToInt32(gcDate1.FieldsEditMode)
			gcComboBox4.SelectedIndex = Convert.ToInt32(gcDate1.ValidateMode)
			gcComboBox5.SelectedIndex = Convert.ToInt32(gcDate1.AcceptsCrLf)
			gcComboBox7.SelectedIndex = Convert.ToInt32(gcDate1.HighlightText)
			setDateFieldstoCombo()
		End Sub

        Private Sub gcComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox1.SelectedIndexChanged
            ' 入力書式の設定
            gcDate1.Fields.Clear()
            gcDate1.Fields.AddRange(gcComboBox1.Text)
            setDateFieldstoCombo()
        End Sub

        Private Sub gcComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            ' 表示書式の設定
            gcDate1.DisplayFields.Clear()
            gcDate1.DisplayFields.AddRange(gcComboBox2.Text)
        End Sub

        Private Sub gcComboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox3.SelectedIndexChanged
            ' FieldsEditModeプロパティ
            gcDate1.FieldsEditMode = CType(gcComboBox3.SelectedIndex, FieldsEditMode)
        End Sub

        Private Sub gcComboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox4.SelectedIndexChanged
            ' ValidateModeプロパティ
            gcDate1.ValidateMode = CType(gcComboBox4.SelectedIndex, ValidateModeEx)
        End Sub

        Private Sub gcComboBox5_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox5.SelectedIndexChanged
            ' AcceptsCrLfプロパティ
            gcDate1.AcceptsCrLf = CType(gcComboBox5.SelectedIndex, CrLfMode)
        End Sub

        Private Sub gcComboBox7_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox7.SelectedIndexChanged
            ' HighlightTextプロパティ
            gcDate1.HighlightText = CType(gcComboBox7.SelectedIndex, HighlightText)
        End Sub

        Private Sub gcComboBox6_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox6.SelectedIndexChanged
            ' DefaultActiveFieldプロパティ
            Select Case gcComboBox6.Text
                Case "DateEraField"
                    gcDate1.DefaultActiveField = gcDate1.Fields.Find(Of DateEraField)()
                    Exit Select
                Case "DateEraYearField"
                    gcDate1.DefaultActiveField = gcDate1.Fields.Find(Of DateEraYearField)()
                    Exit Select
                Case "DateYearField"
                    gcDate1.DefaultActiveField = gcDate1.Fields.Find(Of DateYearField)()
                    Exit Select
                Case "DateMonthField"
                    gcDate1.DefaultActiveField = gcDate1.Fields.Find(Of DateMonthField)()
                    Exit Select
                Case "DateDayField"
                    gcDate1.DefaultActiveField = gcDate1.Fields.Find(Of DateDayField)()
                    Exit Select
                Case Else
                    gcDate1.DefaultActiveField = Nothing
                    Exit Select
            End Select
        End Sub

		Private Sub setDateFieldstoCombo()
			' 設定された書式からDefaultActiveFieldコンボに表示するフィールドを取得設定する
			gcComboBox6.SelectedIndex = -1
			gcComboBox6.Items.Clear()
			Dim fieldCollection As DateTimeFieldCollection = gcDate1.Fields
			For Each item As DateField In fieldCollection
				If TypeOf item Is DateLiteralField = False Then
					gcComboBox6.Items.Add(New ListItem(item.[GetType]().Name, fieldValue(Array.IndexOf(fieldName, item.[GetType]().Name))))
				End If
			Next
			gcComboBox6.SelectedIndex = 0
		End Sub
	End Class
End Namespace
