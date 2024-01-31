Namespace _06_Display
    Partial Public Class ShowOverflowTip
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            ' ***** 初期設定
            gcComboBox1.ListColumns(0).Width = gcComboBox1.Width

            ' ***** 初期値
            checkBox1.Checked = True
            gcComboBox1.DropDown.AllowResize = False
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            ' ShowOverflowTipプロパティ
            gcTextBox1.ShowOverflowTip = checkBox1.Checked
            gcComboBox1.ShowOverflowTip = checkBox1.Checked
            gcListBox1.ShowOverflowTip = checkBox1.Checked
        End Sub
    End Class
End Namespace
