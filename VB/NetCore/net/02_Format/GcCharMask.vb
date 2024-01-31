Imports GrapeCity.Win.Editors
Imports System.Windows.Forms

Namespace _02_Format
    Partial Public Class GcCharMask
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
           ' ***** 初期値
            gcComboBox1.SelectedIndex = Convert.ToInt32(gcCharMask1.InputDirection)
            gcComboBox2.SelectedIndex = Convert.ToInt32(gcCharMask1.EditMode)
            checkBox1.Checked = gcCharMask1.AutoConvert
            gcComboBox3.SelectedIndex = Convert.ToInt32(gcCharMask1.AllowSpace)
            gcComboBox4.SelectedIndex = Convert.ToInt32(gcCharMask1.AcceptsCrLf)
            checkBox2.Checked = gcCharMask1.HighlightText
        End Sub

        Private Sub gcComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox1.SelectedIndexChanged
            ' InputDirectionプロパティ
            gcCharMask1.InputDirection = CType(gcComboBox1.SelectedIndex, CharMaskInputDirection)

        End Sub

        Private Sub gcComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            ' EditModeプロパティ
            gcCharMask1.EditMode = CType(gcComboBox2.SelectedIndex, EditMode)
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
            gcCharMask1.Format = formatVal
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            ' AutoConvertプロパティ
            gcCharMask1.AutoConvert = checkBox1.Checked
        End Sub

        Private Sub gcComboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox3.SelectedIndexChanged
            ' AllowSpaceプロパティ
            gcCharMask1.AllowSpace = CType(gcComboBox3.SelectedIndex, AllowSpace)
        End Sub

        Private Sub gcComboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox4.SelectedIndexChanged
            ' AcceptsCrLfプロパティ
            gcCharMask1.AcceptsCrLf = CType(gcComboBox4.SelectedIndex, CrLfMode)
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
            ' HighlightTextプロパティ
            gcCharMask1.SelectionLength = 0
            gcCharMask1.HighlightText = checkBox2.Checked
        End Sub
    End Class
End Namespace
