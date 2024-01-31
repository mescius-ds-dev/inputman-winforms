Imports GrapeCity.Win.Editors
Imports GrapeCity.Win.Editors.Fields

Namespace _02_Format
	Public Partial Class GcTime
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
			InitializeComponent()
			InitializeForm()
		End Sub

		Private fieldName As String() = {"DateAmPmField", "DateShortHourField", "DateHourField", "DateMinuteField", "DateSecondField"}
		Private fieldValue As String() = {"午前／午後入力フィールド", "12時間制時刻入力フィールド", "時間入力フィールド", "分入力フィールド", "秒入力フィールド"}

		Private Sub InitializeForm()
			' ***** 初期値
			gcComboBox1.SelectedIndex = 0
			gcComboBox2.SelectedIndex = 0
			gcComboBox3.SelectedIndex = Convert.ToInt32(gcTime1.FieldsEditMode)
			gcComboBox4.SelectedIndex = Convert.ToInt32(gcTime1.ValidateMode)
			gcComboBox5.SelectedIndex = Convert.ToInt32(gcTime1.AcceptsCrLf)
			gcComboBox7.SelectedIndex = Convert.ToInt32(gcTime1.HighlightText)
			setDateFieldstoCombo()
		End Sub

        Private Sub gcComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox1.SelectedIndexChanged
            ' 入力書式の設定
            gcTime1.Fields.Clear()
            gcTime1.Fields.AddRange(gcComboBox1.Text)
            setDateFieldstoCombo()
        End Sub

        Private Sub gcComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            ' 表示書式の設定
            gcTime1.DisplayFields.Clear()
            gcTime1.DisplayFields.AddRange(gcComboBox2.Text)
        End Sub

        Private Sub gcComboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox3.SelectedIndexChanged
            ' FieldsEditModeプロパティ
            gcTime1.FieldsEditMode = CType(gcComboBox3.SelectedIndex, FieldsEditMode)
        End Sub

        Private Sub gcComboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox4.SelectedIndexChanged
            ' ValidateModeプロパティ
            gcTime1.ValidateMode = CType(gcComboBox4.SelectedIndex, ValidateModeEx)
        End Sub

        Private Sub gcComboBox5_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox5.SelectedIndexChanged
            ' AcceptsCrLfプロパティ
            gcTime1.AcceptsCrLf = CType(gcComboBox5.SelectedIndex, CrLfMode)
        End Sub

        Private Sub gcComboBox7_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox7.SelectedIndexChanged
            ' HighlightTextプロパティ
            gcTime1.HighlightText = CType(gcComboBox7.SelectedIndex, HighlightText)
        End Sub

        Private Sub gcComboBox6_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox6.SelectedIndexChanged
            ' DefaultActiveFieldプロパティ
            Select Case gcComboBox6.Text
                Case "DateAmPmField"
                    gcTime1.DefaultActiveField = gcTime1.Fields.Find(Of DateAmPmField)()
                    Exit Select
                Case "DateShortHourField"
                    gcTime1.DefaultActiveField = gcTime1.Fields.Find(Of DateShortHourField)()
                    Exit Select
                Case "DateHourField"
                    gcTime1.DefaultActiveField = gcTime1.Fields.Find(Of DateHourField)()
                    Exit Select
                Case "DateMinuteField"
                    gcTime1.DefaultActiveField = gcTime1.Fields.Find(Of DateMinuteField)()
                    Exit Select
                Case "DateSecondField"
                    gcTime1.DefaultActiveField = gcTime1.Fields.Find(Of DateSecondField)()
                    Exit Select
                Case Else
                    gcTime1.DefaultActiveField = Nothing
                    Exit Select
            End Select
        End Sub

		Private Sub setDateFieldstoCombo()
			' 設定された書式からDefaultActiveFieldコンボに表示するフィールドを取得設定する
			gcComboBox6.SelectedIndex = -1
			gcComboBox6.Items.Clear()
			Dim fieldCollection As DateTimeFieldCollection = gcTime1.Fields
			For Each item As DateField In fieldCollection
				If TypeOf item Is DateLiteralField = False Then
					gcComboBox6.Items.Add(New ListItem(item.[GetType]().Name, fieldValue(Array.IndexOf(fieldName, item.[GetType]().Name))))
				End If
			Next
			gcComboBox6.SelectedIndex = 0
		End Sub
	End Class
End Namespace
