Imports GrapeCity.Win.Editors

Namespace _04_Input
    Partial Public Class Furigana
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            ' ***** 初期値
            gcComboBox1.SelectedIndex = Convert.ToInt32(gcIme1.GetReadingStringOutput(gcTextBox1).OutputMode)
            gcComboBox2.SelectedIndex = Convert.ToInt32(gcIme1.GetKanaMode(gcTextBox1))
            checkBox1.Checked = gcIme1.GetReadingStringOutput(gcTextBox1).EnableAlphabetReadingMapping
        End Sub

        Private Sub gcComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox1.SelectedIndexChanged
            ' 出力するカナの出力方法とアルファベットの出力の有無
            gcIme1.SetReadingStringOutput(gcTextBox1, New ReadingStringOutput(gcTextBox2, CType(gcComboBox1.SelectedIndex, ReadingStringOutputMode), checkBox1.Checked))
        End Sub

        Private Sub gcComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            ' 出力するカナの文字種
            gcIme1.SetKanaMode(gcTextBox1, CType(gcComboBox2.SelectedIndex, KanaMode))
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            ' 出力するカナの出力方法とアルファベットの出力の有無
            gcIme1.SetReadingStringOutput(gcTextBox1, New ReadingStringOutput(gcTextBox2, CType(gcComboBox1.SelectedIndex, ReadingStringOutputMode), checkBox1.Checked))
        End Sub
    End Class
End Namespace
