Imports System.Windows.Forms

Namespace _09_GcComboBox
	Public Partial Class ComboMultiColumns
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
			checkBox1.Checked = gcComboBox1.ListHeaderPane.Visible
			checkBox2.Checked = gcComboBox1.ListColumns(0).Header.AllowResize
			checkBox3.Checked = True
			checkBox4.Checked = gcComboBox1.DropDown.AutoWidth
			gcComboBox2.SelectedIndex = gcComboBox1.TextSubItemIndex

			For i As Integer = 0 To gcComboBox1.ListColumns.Count - 1
				gcComboBox1.ListColumns(i).AutoWidth = True
				gcComboBox1.ListColumns(i).Header.Image = 0
			Next

			gcComboBox1.DropDown.Direction = GrapeCity.Win.Editors.DropDownDirection.BelowLeft
		End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            ' ヘッダの表示／非表示
            gcComboBox1.ListHeaderPane.Visible = checkBox1.Checked
            checkBox2.Enabled = checkBox1.Checked
            checkBox3.Enabled = checkBox1.Checked
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
            ' ヘッダのリサイズ
            For i As Integer = 0 To gcComboBox1.ListColumns.Count - 1
                gcComboBox1.ListColumns(i).Header.AllowResize = checkBox2.Checked
            Next
        End Sub

        Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox3.CheckedChanged
            ' ヘッダの画像の表示
            If checkBox3.Checked Then
                gcComboBox1.ListColumns(0).Header.Image = 4
                gcComboBox1.ListColumns(1).Header.Image = 2
                gcComboBox1.ListColumns(2).Header.Image = 1
                gcComboBox1.ListColumns(3).Header.Image = 1
                gcComboBox1.ListColumns(4).Header.Image = 3
                gcComboBox1.ListColumns(5).Header.Image = 0
            Else
                gcComboBox1.ListColumns(0).Header.Image = Nothing
                gcComboBox1.ListColumns(1).Header.Image = Nothing
                gcComboBox1.ListColumns(2).Header.Image = Nothing
                gcComboBox1.ListColumns(3).Header.Image = Nothing
                gcComboBox1.ListColumns(4).Header.Image = Nothing
                gcComboBox1.ListColumns(5).Header.Image = Nothing
            End If
        End Sub

        Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox4.CheckedChanged
            ' AutoWidthプロパティ
            gcComboBox1.DropDown.AutoWidth = checkBox4.Checked
        End Sub

        Private Sub gcComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            gcComboBox1.TextSubItemIndex = gcComboBox2.SelectedIndex
        End Sub

        Private Sub gcColorPicker1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcColorPicker1.SelectedIndexChanged
            ' 選択行の前景色
            gcComboBox1.ListSelectedItemStyle.ForeColor = gcColorPicker1.SelectedColor
        End Sub

        Private Sub gcColorPicker2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcColorPicker2.SelectedIndexChanged
            ' 選択行の背景色
            gcComboBox1.ListSelectedItemStyle.BackColor = gcColorPicker2.SelectedColor
        End Sub
	End Class
End Namespace
