Imports System.Windows.Forms
Imports System.Data

Namespace _06_Display
    Partial Public Class ActiveColor
        Inherits InputManWin12_Demo.DemoBase_settings

        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            ' ***** 初期値
            gcColorPicker1.SelectedIndex = gcColorPicker1.FindStringExact(gcTextBox1.BackColor.Name, -1, 0)

            ' xmlファイルからデータ取得(GcComboBox)
            Dim filePath As System.String = Application.StartupPath
            Me.dataSet1.ReadXml(filePath & "\Resources\prefecture.xml")

            Dim dv1 As New DataView(dataSet1.Tables(0))
            gcComboBox1.DataSource = dv1
            gcComboBox1.SelectedIndex = -1

            For i As Integer = 1 To gcComboBox1.ListColumns.Count - 1
                gcComboBox1.ListColumns(i).AutoWidth = True
            Next

            ' xmlファイルからデータ取得(GcMaskedComboBox)
            Me.dataSet2.ReadXml(filePath & "\Resources\pref.xml")
            gcMaskedComboBox1.DataSource = dataSet2.Tables(0)
            gcMaskedComboBox1.SelectedIndex = -1

            For i As Integer = 1 To gcMaskedComboBox1.ListColumns.Count - 1
                gcMaskedComboBox1.ListColumns(i).AutoWidth = True
            Next
        End Sub

        Private Sub gcColorPicker1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcColorPicker1.SelectedIndexChanged
            ' ForeColorプロパティ
            gcTextBox1.ForeColor = gcColorPicker1.SelectedColor
            gcMask1.ForeColor = gcColorPicker1.SelectedColor
            gcCharMask1.ForeColor = gcColorPicker1.SelectedColor
            gcDateTime1.ForeColor = gcColorPicker1.SelectedColor
            gcDate1.ForeColor = gcColorPicker1.SelectedColor
            gcTime1.ForeColor = gcColorPicker1.SelectedColor
            gcTimeSpan1.ForeColor = gcColorPicker1.SelectedColor
            gcNumber1.ForeColor = gcColorPicker1.SelectedColor
            gcComboBox1.ForeColor = gcColorPicker1.SelectedColor
            GcMaskedComboBox1.ForeColor = gcColorPicker1.SelectedColor

        End Sub

        Private Sub GcColorPicker2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcColorPicker2.SelectedIndexChanged
            ' BackColorプロパティ
            gcTextBox1.BackColor = GcColorPicker2.SelectedColor
            gcMask1.BackColor = GcColorPicker2.SelectedColor
            gcCharMask1.BackColor = GcColorPicker2.SelectedColor
            gcDateTime1.BackColor = GcColorPicker2.SelectedColor
            gcDate1.BackColor = GcColorPicker2.SelectedColor
            gcTime1.BackColor = GcColorPicker2.SelectedColor
            gcTimeSpan1.BackColor = GcColorPicker2.SelectedColor
            gcNumber1.BackColor = GcColorPicker2.SelectedColor
            gcComboBox1.BackColor = GcColorPicker2.SelectedColor
            GcMaskedComboBox1.BackColor = GcColorPicker2.SelectedColor
        End Sub

        Private Sub GcColorPicker3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcColorPicker3.SelectedIndexChanged
            ' ActiveForeColorプロパティ
            gcTextBox1.ActiveForeColor = GcColorPicker3.SelectedColor
            gcMask1.ActiveForeColor = GcColorPicker3.SelectedColor
            gcCharMask1.ActiveForeColor = GcColorPicker3.SelectedColor
            gcDateTime1.ActiveForeColor = GcColorPicker3.SelectedColor
            gcDate1.ActiveForeColor = GcColorPicker3.SelectedColor
            gcTime1.ActiveForeColor = GcColorPicker3.SelectedColor
            gcTimeSpan1.ActiveForeColor = GcColorPicker3.SelectedColor
            gcNumber1.ActiveForeColor = GcColorPicker3.SelectedColor
            gcComboBox1.ActiveForeColor = GcColorPicker3.SelectedColor
            GcMaskedComboBox1.ActiveForeColor = GcColorPicker3.SelectedColor
        End Sub

        Private Sub GcColorPicker4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcColorPicker4.SelectedIndexChanged
            ' ActiveBackColorプロパティ
            gcTextBox1.ActiveBackColor = GcColorPicker4.SelectedColor
            gcMask1.ActiveBackColor = GcColorPicker4.SelectedColor
            gcCharMask1.ActiveBackColor = GcColorPicker4.SelectedColor
            gcDateTime1.ActiveBackColor = GcColorPicker4.SelectedColor
            gcDate1.ActiveBackColor = GcColorPicker4.SelectedColor
            gcTime1.ActiveBackColor = GcColorPicker4.SelectedColor
            gcTimeSpan1.ActiveBackColor = GcColorPicker4.SelectedColor
            gcNumber1.ActiveBackColor = GcColorPicker4.SelectedColor
            gcComboBox1.ActiveBackColor = GcColorPicker4.SelectedColor
            GcMaskedComboBox1.ActiveBackColor = GcColorPicker4.SelectedColor
        End Sub

        Private Sub gcComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            gcCharMask1.ActiveBackColorArea = GetActiveBackColorArea(gcComboBox2.SelectedValue.ToString())
        End Sub

        Private Function GetActiveBackColorArea(controlName As String) As GrapeCity.Win.Editors.ActiveBackColorArea

            Select Case controlName

                Case "Control"
                    ' コントロール全体を対象
                    Return GrapeCity.Win.Editors.ActiveBackColorArea.Control
                Case "SingleInputBox"
                    ' 入力枠を対象
                    Return GrapeCity.Win.Editors.ActiveBackColorArea.SingleInputBox
                    ' 入力枠すべてを対象
                Case "InputBoxes"
                    Return GrapeCity.Win.Editors.ActiveBackColorArea.InputBoxes
                Case "InputBoxesCoverBackColor"
                    ' 入力枠を対象（CharBoxのBackColorより優先）
                    Return GrapeCity.Win.Editors.ActiveBackColorArea.InputBoxesCoverBackColor
                Case "SingleInputBoxCoverBackColor"
                    ' 入力枠すべてを対象（CharBoxのBackColorより優先）
                    Return GrapeCity.Win.Editors.ActiveBackColorArea.SingleInputBoxCoverBackColor
            End Select

            Return GrapeCity.Win.Editors.ActiveBackColorArea.Control

        End Function
    End Class
End Namespace

