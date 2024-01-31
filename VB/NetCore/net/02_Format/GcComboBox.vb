Imports GrapeCity.Win.Editors
Imports System.Windows.Forms

Namespace _02_Format
    Partial Public Class GcComboBox
        Inherits InputManWin12_Demo.DemoBase_settings

        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            ' ***** 初期値
            gcNumber1.Value = GcComboBox1.MaxLength
            GcComboBox2.SelectedIndex = Convert.ToInt32(GcComboBox1.MaxLengthUnit)
            checkBox1.Checked = GcComboBox1.AutoConvert
            GcComboBox3.SelectedIndex = Convert.ToInt32(GcComboBox1.AllowSpace)
            GcComboBox4.SelectedIndex = Convert.ToInt32(GcComboBox1.AcceptsCrLf)
            GcComboBox5.SelectedIndex = Convert.ToInt32(GcComboBox1.AcceptsTabChar)
            checkBox2.Checked = GcComboBox1.HighlightText
        End Sub

        Private Sub gcNumber1_ValueChanged(sender As Object, e As EventArgs) Handles gcNumber1.ValueChanged
            ' MaxLenghtプロパティ
            GcComboBox1.MaxLength = Convert.ToInt32(gcNumber1.Value.Value)
        End Sub

        Private Sub GcComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GcComboBox2.SelectedIndexChanged
            ' MaxLengthUnitプロパティ
            GcComboBox1.MaxLengthUnit = CType(GcComboBox2.SelectedIndex, LengthUnit)
        End Sub

        Private Sub gcListBox1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles gcListBox1.ItemCheck
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
            GcComboBox1.Format = formatVal

        End Sub

        Private Sub checkBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox1.CheckedChanged
            ' AutoConvertプロパティ
            GcComboBox1.AutoConvert = checkBox1.Checked
        End Sub

        Private Sub GcComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GcComboBox3.SelectedIndexChanged
            ' AllowSpaceプロパティ
            GcComboBox1.AllowSpace = CType(GcComboBox3.SelectedIndex, AllowSpace)
        End Sub

        Private Sub GcComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GcComboBox4.SelectedIndexChanged
            ' AcceptsCrLfプロパティ
            GcComboBox1.AcceptsCrLf = CType(GcComboBox4.SelectedIndex, CrLfMode)
        End Sub

        Private Sub GcComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GcComboBox5.SelectedIndexChanged
            ' AcceptsTabCharプロパティ
            GcComboBox1.AcceptsTabChar = CType(GcComboBox5.SelectedIndex, TabCharMode)
        End Sub

        Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox2.CheckedChanged
            ' HighlightTextプロパティ
            GcComboBox1.SelectionLength = 0
            GcComboBox1.HighlightText = checkBox2.Checked
        End Sub

        Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox3.CheckedChanged
            GcComboBox1.IsEditable = Not checkBox3.Checked
        End Sub
    End Class
End Namespace
