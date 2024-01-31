Imports System.Windows.Forms
Imports GrapeCity.Win.Editors

Namespace _02_Format
	Public Partial Class GcNumber
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
			InitializeComponent()
			InitializeForm()
		End Sub

		Private Sub InitializeForm()
			' ***** 初期値
			gcComboBox1.SelectedIndex = 0
			gcComboBox2.SelectedIndex = 0
			gcComboBox3.SelectedIndex = Convert.ToInt32(gcNumber1.AcceptsCrLf)
			gcComboBox4.SelectedIndex = 0
		End Sub

        Private Sub gcComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox1.SelectedIndexChanged
            setFormat()
        End Sub

        Private Sub Format_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcTextBox1.TextChanged, gcTextBox2.TextChanged, gcTextBox3.TextChanged, gcTextBox4.TextChanged
            setFormat()
        End Sub

		Private Sub setFormat()
			' 入力書式の設定
			gcNumber1.Fields.SetFields(gcComboBox1.Text, gcTextBox1.Text, gcTextBox2.Text, gcTextBox3.Text, gcTextBox4.Text)
		End Sub

        Private Sub gcComboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox4.SelectedIndexChanged
            setDisplayFormat()
        End Sub

        Private Sub DisplayFormat_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcTextBox5.TextChanged, gcTextBox6.TextChanged, gcTextBox7.TextChanged, gcTextBox8.TextChanged
            setDisplayFormat()
        End Sub

		Private Sub setDisplayFormat()
			' 表示書式の設定
			gcNumber1.DisplayFields.Clear()
			gcNumber1.DisplayFields.AddRange(gcComboBox4.Text, gcTextBox5.Text, gcTextBox6.Text, gcTextBox7.Text, gcTextBox8.Text)
		End Sub

        Private Sub gcComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            ' マイナスキー動作の設定
            gcShortcut1.GetShortcuts(gcNumber1).Remove(Keys.OemMinus)
            gcShortcut1.GetShortcuts(gcNumber1).Remove(Keys.Subtract)

            If gcComboBox2.SelectedIndex = 0 Then
                gcShortcut1.GetShortcuts(gcNumber1).Add(Keys.OemMinus, gcNumber1, "SwitchSign")
                gcShortcut1.GetShortcuts(gcNumber1).Add(Keys.Subtract, gcNumber1, "SwitchSign")
            End If
        End Sub

        Private Sub gcComboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox3.SelectedIndexChanged
            ' AcceptsCrLfプロパティ
            gcNumber1.AcceptsCrLf = CType(gcComboBox3.SelectedIndex, CrLfMode)
        End Sub
	End Class
End Namespace
