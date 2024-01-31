Imports System.Windows.Forms
Imports GrapeCity.Win.Editors

Namespace _07_DropDown
	Public Partial Class DropDown
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
			InitializeComponent()
			InitializeForm()
		End Sub

		Private Sub InitializeForm()
			' ***** 初期値
			gcComboBox2.SelectedIndex = 6
			gcComboBox3.SelectedIndex = Convert.ToInt32(gcTextBox1.DropDown.OpeningAnimation)
			gcComboBox4.SelectedIndex = Convert.ToInt32(gcTextBox1.DropDown.ClosingAnimation)
			gcDateTime1.Value = DateTime.Now
			gcDate1.Value = DateTime.Now

			' xmlファイルからデータ取得
			Dim filePath As System.String = Application.StartupPath
			Me.dataSet1.ReadXml(filePath & "\Resources\prefecture.xml")
			gcComboBox1.DataSource = dataSet1.Tables(0)
			gcComboBox1.SelectedIndex = -1

			For i As Integer = 1 To gcComboBox1.ListColumns.Count - 1
				gcComboBox1.ListColumns(i).AutoWidth = True
            Next

            ' xmlファイルからデータ取得(GcMaskedComboBox)
            Me.DataSet2.ReadXml(filePath & "\Resources\pref.xml")
            GcMaskedComboBox1.DataSource = DataSet2.Tables(0)
            GcMaskedComboBox1.SelectedIndex = -1

            For i As Integer = 1 To GcMaskedComboBox1.ListColumns.Count - 1
                GcMaskedComboBox1.ListColumns(i).AutoWidth = True
            Next
		End Sub

        Private Sub gcComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            ' 表示方向
            If gcComboBox2.SelectedIndex = 6 Then
                gcTextBox1.DropDown.Direction = DropDownDirection.[Default]
                gcDateTime1.DropDown.Direction = DropDownDirection.[Default]
                gcDate1.DropDown.Direction = DropDownDirection.[Default]
                gcTime1.DropDown.Direction = DropDownDirection.[Default]
                gcNumber1.DropDown.Direction = DropDownDirection.[Default]
                gcComboBox1.DropDown.Direction = DropDownDirection.[Default]
                GcMaskedComboBox1.DropDown.Direction = DropDownDirection.[Default]
            Else
                gcTextBox1.DropDown.Direction = CType(gcComboBox2.SelectedIndex, DropDownDirection)
                gcDateTime1.DropDown.Direction = CType(gcComboBox2.SelectedIndex, DropDownDirection)
                gcDate1.DropDown.Direction = CType(gcComboBox2.SelectedIndex, DropDownDirection)
                gcTime1.DropDown.Direction = CType(gcComboBox2.SelectedIndex, DropDownDirection)
                gcNumber1.DropDown.Direction = CType(gcComboBox2.SelectedIndex, DropDownDirection)
                gcComboBox1.DropDown.Direction = CType(gcComboBox2.SelectedIndex, DropDownDirection)
                GcMaskedComboBox1.DropDown.Direction = CType(gcComboBox2.SelectedIndex, DropDownDirection)
            End If
        End Sub

        Private Sub gcComboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox3.SelectedIndexChanged
            ' 開くときのアニメーション
            gcTextBox1.DropDown.OpeningAnimation = CType(gcComboBox3.SelectedIndex, DropDownAnimation)
            gcDateTime1.DropDown.OpeningAnimation = CType(gcComboBox3.SelectedIndex, DropDownAnimation)
            gcDate1.DropDown.OpeningAnimation = CType(gcComboBox3.SelectedIndex, DropDownAnimation)
            gcTime1.DropDown.OpeningAnimation = CType(gcComboBox3.SelectedIndex, DropDownAnimation)
            gcNumber1.DropDown.OpeningAnimation = CType(gcComboBox3.SelectedIndex, DropDownAnimation)
            gcComboBox1.DropDown.OpeningAnimation = CType(gcComboBox3.SelectedIndex, DropDownAnimation)
            GcMaskedComboBox1.DropDown.OpeningAnimation = CType(gcComboBox3.SelectedIndex, DropDownAnimation)
        End Sub

        Private Sub gcComboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox4.SelectedIndexChanged
            ' 閉じるときのアニメーション
            gcTextBox1.DropDown.ClosingAnimation = CType(gcComboBox4.SelectedIndex, DropDownAnimation)
            gcDateTime1.DropDown.ClosingAnimation = CType(gcComboBox4.SelectedIndex, DropDownAnimation)
            gcDate1.DropDown.ClosingAnimation = CType(gcComboBox4.SelectedIndex, DropDownAnimation)
            gcTime1.DropDown.ClosingAnimation = CType(gcComboBox4.SelectedIndex, DropDownAnimation)
            gcNumber1.DropDown.ClosingAnimation = CType(gcComboBox4.SelectedIndex, DropDownAnimation)
            gcComboBox1.DropDown.ClosingAnimation = CType(gcComboBox4.SelectedIndex, DropDownAnimation)
            GcMaskedComboBox1.DropDown.ClosingAnimation = CType(gcComboBox4.SelectedIndex, DropDownAnimation)
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            ' ShowShadowプロパティ
            gcTextBox1.DropDown.ShowShadow = checkBox1.Checked
            gcDateTime1.DropDown.ShowShadow = checkBox1.Checked
            gcDate1.DropDown.ShowShadow = checkBox1.Checked
            gcTime1.DropDown.ShowShadow = checkBox1.Checked
            gcNumber1.DropDown.ShowShadow = checkBox1.Checked
            gcComboBox1.DropDown.ShowShadow = checkBox1.Checked
            GcMaskedComboBox1.DropDown.ShowShadow = checkBox1.Checked
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
            ' AutoDropDownプロパティ
            gcTextBox1.DropDown.AutoDropDown = checkBox2.Checked
            gcDateTime1.DropDown.AutoDropDown = checkBox2.Checked
            gcDate1.DropDown.AutoDropDown = checkBox2.Checked
            gcTime1.DropDown.AutoDropDown = checkBox2.Checked
            gcNumber1.DropDown.AutoDropDown = checkBox2.Checked
            gcComboBox1.DropDown.AutoDropDown = checkBox2.Checked
            GcMaskedComboBox1.DropDown.AutoDropDown = checkBox2.Checked
        End Sub

        Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox3.CheckedChanged
            ' AllowDropプロパティ
            gcTextBox1.DropDown.AllowDrop = Not checkBox3.Checked
            gcDateTime1.DropDown.AllowDrop = Not checkBox3.Checked
            gcDate1.DropDown.AllowDrop = Not checkBox3.Checked
            gcTime1.DropDown.AllowDrop = Not checkBox3.Checked
            gcNumber1.DropDown.AllowDrop = Not checkBox3.Checked
            gcComboBox1.DropDown.AllowDrop = Not checkBox3.Checked
            GcMaskedComboBox1.DropDown.AllowDrop = Not checkBox3.Checked
        End Sub

        Private Sub gcComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox5.SelectedIndexChanged
            ' DropDownTypeプロパティ
            gcDateTime1.DropDown.DropDownType = CType(gcComboBox5.SelectedIndex, DateDropDownType)
            gcDate1.DropDown.DropDownType = CType(gcComboBox5.SelectedIndex, DateDropDownType)

        End Sub
    End Class
End Namespace
