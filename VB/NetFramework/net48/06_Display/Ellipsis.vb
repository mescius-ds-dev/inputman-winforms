Namespace _06_Display
    Partial Public Class Ellipsis
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
           ' ***** 初期値
            gcComboBox1.SelectedIndex = Convert.ToInt32(gcTextBox1.Ellipsis)
            gcTextBox2.Text = gcTextBox1.EllipsisString
            checkBox1.Checked = gcComboBox2.ListColumns(0).Header.Ellipsis

            gcComboBox2.ShowOverflowTip = False
            gcComboBox2.DropDown.Width = gcComboBox2.Width
            gcComboBox2.ListColumns(0).Width = gcComboBox2.Width
        End Sub

        Private Sub gcComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox1.SelectedIndexChanged
            ' Ellipsisプロパティ
            gcTextBox1.Ellipsis = CType(gcComboBox1.SelectedIndex, GrapeCity.Win.Editors.EllipsisMode)
            gcTextBox3.Ellipsis = CType(gcComboBox1.SelectedIndex, GrapeCity.Win.Editors.EllipsisMode)
            gcComboBox2.Ellipsis = CType(gcComboBox1.SelectedIndex, GrapeCity.Win.Editors.EllipsisMode)
        End Sub

        Private Sub gcTextBox2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcTextBox2.TextChanged
            ' EllipsisStringプロパティ
            gcTextBox1.EllipsisString = gcTextBox2.Text
            gcTextBox3.EllipsisString = gcTextBox2.Text
            gcComboBox2.EllipsisString = gcTextBox2.Text
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            ' ヘッダの省略文字
            gcComboBox2.ListColumns(0).Header.Ellipsis = checkBox1.Checked
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
            ' ヘッダの省略文字
            For i As Integer = 0 To gcComboBox2.Items.Count - 1
                gcComboBox2.Items(i).SubItems(0).Ellipsis = checkBox2.Checked
            Next

        End Sub
    End Class
End Namespace
