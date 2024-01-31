Imports GrapeCity.Win.Editors

Namespace _02_Format
    Partial Public Class GcMaskedComboBox
        Inherits InputManWin12_Demo.DemoBase_settings

        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            ' ***** 初期設定
            gcComboBox1.SelectedIndex = 0
            checkBox1.Checked = GcMaskedComboBox1.AutoConvert
            gcComboBox2.SelectedIndex = Convert.ToInt32(GcMaskedComboBox1.AcceptsCrLf)
            gcComboBox3.SelectedIndex = Convert.ToInt32(GcMaskedComboBox1.AcceptsTabChar)
        End Sub

        Private Sub gcComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox1.SelectedIndexChanged
            ' 正規表現による書式設定
            GcMaskedComboBox1.Fields.Clear()
            GcMaskedComboBox1.Fields.AddRange(gcComboBox1.Text)
        End Sub

        Private Sub checkBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox1.CheckedChanged
            ' AutoConvertプロパティ
            GcMaskedComboBox1.AutoConvert = checkBox1.Checked
        End Sub

        Private Sub gcComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            ' AcceptsCrLfプロパティ
            GcMaskedComboBox1.AcceptsCrLf = CType(gcComboBox2.SelectedIndex, CrLfMode)
        End Sub

        Private Sub gcComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox3.SelectedIndexChanged
            ' AcceptsTabCharプロパティ
            GcMaskedComboBox1.AcceptsTabChar = CType(gcComboBox3.SelectedIndex, TabCharMode)
        End Sub
    End Class
End Namespace