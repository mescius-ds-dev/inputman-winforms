Namespace _14_GcSoftKeyboard
    Partial Public Class Appearance
        Inherits InputManWin12_Demo.DemoBase_settings

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
            gcSoftKeyboard1.Show(textBox1, True)
        End Sub

        Private Sub gcColorPicker1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcColorPicker1.SelectedIndexChanged
            ' 基底カラーの設定
            gcSoftKeyboard1.BaseColor = gcColorPicker1.SelectedColor
        End Sub

        Private Sub gcColorPicker2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcColorPicker2.SelectedIndexChanged
            ' 切替キーの色
            gcSoftKeyboard1.ToggledButtonBackColor = gcColorPicker2.SelectedColor
        End Sub

        Private Sub checkBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox1.CheckedChanged
            ' キーの境界線
            gcSoftKeyboard1.ShowButtonBorder = checkBox1.Checked
        End Sub

        Private Sub gcNumber1_ValueChanged(sender As Object, e As EventArgs) Handles gcNumber1.ValueChanged
            ' 透過率
            gcSoftKeyboard1.Opacity = CSng(gcNumber1.Value)
        End Sub
    End Class
End Namespace
