Imports System.Windows.Forms

Namespace _09_GcComboBox
	Public Partial Class AutoComplete
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
			InitializeComponent()
			InitializeForm()
		End Sub

		Private Sub InitializeForm()
			' xmlファイルからショートカット機能一覧取得
			Dim filePath As System.String = Application.StartupPath
			Me.dataSet1.ReadXml(filePath & "\Resources\XMLDataFile.xml")
			gcComboBox1.DataSource = dataSet1.Tables(0)

			' ***** 初期値
			gcComboBox1.AutoComplete.CandidateListItemFont = gcComboBox1.Font
			gcComboBox2.SelectedIndex = Convert.ToInt32(gcComboBox1.AutoComplete.MatchingMode)
			For i As Integer = 1 To gcComboBox1.ListColumns.Count - 1
				gcComboBox1.ListColumns(i).Visible = False
			Next

			gcComboBox1.ListColumns(0).Width = gcComboBox1.Width
			gcComboBox1.DropDown.Direction = GrapeCity.Win.Editors.DropDownDirection.BelowLeft
		End Sub

        Private Sub gcComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            ' 検索モード
            gcComboBox1.AutoComplete.MatchingMode = CType(gcComboBox2.SelectedIndex, GrapeCity.Win.Editors.AutoCompleteMatchingMode)
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            ' ハイライト表示
            gcComboBox1.AutoComplete.HighlightMatchedText = checkBox1.Checked
        End Sub

        Private Sub sideButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sideButton1.Click
            ' 検索文字列のフォント
            Dim fd As New FontDialog()

            fd.Font = gcComboBox1.AutoComplete.HighlightStyle.Font
            fd.ShowColor = False

            If fd.ShowDialog() <> DialogResult.Cancel Then
                gcComboBox1.AutoComplete.HighlightStyle.Font = fd.Font
                gcTextBox1.Text = fd.Font.ToString()
            End If
        End Sub

        Private Sub gcColorPicker1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcColorPicker1.SelectedIndexChanged
            ' 検索文字列の前景色
            gcComboBox1.AutoComplete.HighlightStyle.ForeColor = gcColorPicker1.SelectedColor
        End Sub

        Private Sub gcColorPicker2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcColorPicker2.SelectedIndexChanged
            ' 検索文字列の背景色
            gcComboBox1.AutoComplete.HighlightStyle.BackColor = gcColorPicker2.SelectedColor
        End Sub

        Private Sub sideButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sideButton2.Click
            ' 候補リストのフォント
            Dim fd As New FontDialog()

            fd.Font = gcComboBox2.AutoComplete.CandidateListItemFont
            fd.ShowColor = False

            If fd.ShowDialog() <> DialogResult.Cancel Then
                gcComboBox1.AutoComplete.CandidateListItemFont = fd.Font
                gcTextBox2.Text = fd.Font.ToString()
            End If
        End Sub
	End Class
End Namespace
