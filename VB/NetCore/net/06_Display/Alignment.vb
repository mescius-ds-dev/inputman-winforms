Imports System.Drawing
Imports System.Windows.Forms

Namespace _06_Display
    Partial Public Class Alignment
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            ' ***** 初期値
            gcComboBox1.SelectedIndex = 0
            gcNumber1.Value = gcTextBox1.Padding.Top
            gcNumber2.Value = gcTextBox1.Padding.Left
            gcNumber3.Value = gcTextBox1.Padding.Right
            gcNumber4.Value = gcTextBox1.Padding.Bottom
            gcComboBox2.SelectedIndex = Convert.ToInt32(gcTextBox1.DisplayAlignment)
        End Sub

        Private Sub gcNumber_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcNumber1.ValueChanged, gcNumber2.ValueChanged, gcNumber3.ValueChanged, gcNumber4.ValueChanged
            ' Paddingプロパティ
            gcTextBox1.Padding = New Padding(CInt(gcNumber2.Value), CInt(gcNumber1.Value), CInt(gcNumber3.Value), CInt(gcNumber4.Value))
        End Sub

        Private Sub gcComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox1.SelectedIndexChanged
            ' ContentAlignmentプロパティ
            Select Case gcComboBox1.SelectedIndex
                Case 0
                    gcTextBox1.ContentAlignment = ContentAlignment.TopLeft
                    Exit Select
                Case 1
                    gcTextBox1.ContentAlignment = ContentAlignment.TopCenter
                    Exit Select
                Case 2
                    gcTextBox1.ContentAlignment = ContentAlignment.TopRight
                    Exit Select
                Case 3
                    gcTextBox1.ContentAlignment = ContentAlignment.MiddleLeft
                    Exit Select
                Case 4
                    gcTextBox1.ContentAlignment = ContentAlignment.MiddleCenter
                    Exit Select
                Case 5
                    gcTextBox1.ContentAlignment = ContentAlignment.MiddleRight
                    Exit Select
                Case 6
                    gcTextBox1.ContentAlignment = ContentAlignment.BottomLeft
                    Exit Select
                Case 7
                    gcTextBox1.ContentAlignment = ContentAlignment.BottomCenter
                    Exit Select
                Case 8
                    gcTextBox1.ContentAlignment = ContentAlignment.BottomRight
                    Exit Select
                Case Else
                    Exit Select
            End Select
        End Sub

        Private Sub gcComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            ' DisplayAlignmentプロパティ
            gcTextBox1.DisplayAlignment = CType(gcComboBox2.SelectedIndex, GrapeCity.Win.Editors.DisplayAlignment)
        End Sub
    End Class
End Namespace
