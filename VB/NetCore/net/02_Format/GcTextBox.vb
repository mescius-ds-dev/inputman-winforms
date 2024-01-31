Imports System.Windows.Forms
Imports GrapeCity.Win.Editors

Namespace _02_Format
	Public Partial Class GcTextBox
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
			InitializeComponent()
			InitializeForm()
		End Sub

		Private Sub InitializeForm()
			' ***** 初期値
			gcNumber1.Value = gcTextBox1.MaxLength
			gcComboBox1.SelectedIndex = Convert.ToInt32(gcTextBox1.MaxLengthUnit)
			checkBox1.Checked = gcTextBox1.AutoConvert
			gcComboBox2.SelectedIndex = Convert.ToInt32(gcTextBox1.AllowSpace)
			gcComboBox3.SelectedIndex = Convert.ToInt32(gcTextBox1.AcceptsCrLf)
			gcComboBox4.SelectedIndex = Convert.ToInt32(gcTextBox1.AcceptsTabChar)
			checkBox2.Checked = gcTextBox1.HighlightText
		End Sub

        Private Sub gcNumber1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcNumber1.ValueChanged
            ' MaxLenghtプロパティ
            gcTextBox1.MaxLength = Convert.ToInt32(gcNumber1.Value.Value)
        End Sub

        Private Sub gcComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox1.SelectedIndexChanged
            ' MaxLengthUnitプロパティ
            gcTextBox1.MaxLengthUnit = CType(gcComboBox1.SelectedIndex, LengthUnit)
        End Sub

        Private Sub gcListBox1_ItemCheck(ByVal sender As Object, ByVal e As ItemCheckEventArgs) Handles gcListBox1.ItemCheck
            ' Formatプロパティ
            Dim formatVal As String = String.Empty
            For i As Integer = 0 To gcListBox1.Items.Count - 1
                If i = e.Index Then
                    If e.NewValue = CheckState.Checked Then
                        formatVal += gcListBox1.Items(e.Index).Text
                    End If
                Else
                    If gcListBox1.Items(i).Checked Then
                        formatVal += gcListBox1.Items(i).Text
                    End If
                End If
            Next
            gcTextBox1.Format = formatVal
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            ' AutoConvertプロパティ
            gcTextBox1.AutoConvert = checkBox1.Checked
        End Sub

        Private Sub gcComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            ' AllowSpaceプロパティ
            gcTextBox1.AllowSpace = CType(gcComboBox2.SelectedIndex, AllowSpace)
        End Sub

        Private Sub gcComboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox3.SelectedIndexChanged
            ' AcceptsCrLfプロパティ
            gcTextBox1.AcceptsCrLf = CType(gcComboBox3.SelectedIndex, CrLfMode)
        End Sub

        Private Sub gcComboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox4.SelectedIndexChanged
            ' AcceptsTabCharプロパティ
            gcTextBox1.AcceptsTabChar = CType(gcComboBox4.SelectedIndex, TabCharMode)
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
            ' HighlightTextプロパティ
            gcTextBox1.SelectionLength = 0
            gcTextBox1.HighlightText = checkBox2.Checked
        End Sub
	End Class
End Namespace

