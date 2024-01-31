Imports System.Windows.Forms
Imports System.Data

Namespace _06_Display
    Partial Public Class ReadOnlyColor
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
            gcMaskedComboBox1.ForeColor = gcColorPicker1.SelectedColor
        End Sub

        Private Sub gcColorPicker2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcColorPicker2.SelectedIndexChanged
            ' BackColorプロパティ
            gcTextBox1.BackColor = gcColorPicker2.SelectedColor
            gcMask1.BackColor = gcColorPicker2.SelectedColor
            gcCharMask1.BackColor = gcColorPicker2.SelectedColor
            gcDateTime1.BackColor = gcColorPicker2.SelectedColor
            gcDate1.BackColor = gcColorPicker2.SelectedColor
            gcTime1.BackColor = gcColorPicker2.SelectedColor
            gcTimeSpan1.BackColor = gcColorPicker2.SelectedColor
            gcNumber1.BackColor = gcColorPicker2.SelectedColor
            gcComboBox1.BackColor = gcColorPicker2.SelectedColor
            gcMaskedComboBox1.BackColor = gcColorPicker2.SelectedColor
        End Sub

        Private Sub gcColorPicker3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcColorPicker3.SelectedIndexChanged
            ' ReadOnlyForeColorプロパティ
            gcTextBox1.ReadOnlyForeColor = gcColorPicker3.SelectedColor
            gcMask1.ReadOnlyForeColor = gcColorPicker3.SelectedColor
            gcCharMask1.ReadOnlyForeColor = gcColorPicker3.SelectedColor
            gcDateTime1.ReadOnlyForeColor = gcColorPicker3.SelectedColor
            gcDate1.ReadOnlyForeColor = gcColorPicker3.SelectedColor
            gcTime1.ReadOnlyForeColor = gcColorPicker3.SelectedColor
            gcTimeSpan1.ReadOnlyForeColor = gcColorPicker3.SelectedColor
            gcNumber1.ReadOnlyForeColor = gcColorPicker3.SelectedColor
            gcComboBox1.ReadOnlyForeColor = gcColorPicker3.SelectedColor
            gcMaskedComboBox1.ReadOnlyForeColor = gcColorPicker3.SelectedColor

        End Sub

        Private Sub gcColorPicker4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcColorPicker4.SelectedIndexChanged
            ' ReadOnlyBackColorプロパティ
            gcTextBox1.ReadOnlyBackColor = gcColorPicker4.SelectedColor
            gcMask1.ReadOnlyBackColor = gcColorPicker4.SelectedColor
            gcCharMask1.ReadOnlyBackColor = gcColorPicker4.SelectedColor
            gcDateTime1.ReadOnlyBackColor = gcColorPicker4.SelectedColor
            gcDate1.ReadOnlyBackColor = gcColorPicker4.SelectedColor
            gcTime1.ReadOnlyBackColor = gcColorPicker4.SelectedColor
            gcTimeSpan1.ReadOnlyBackColor = gcColorPicker4.SelectedColor
            gcNumber1.ReadOnlyBackColor = gcColorPicker4.SelectedColor
            gcComboBox1.ReadOnlyBackColor = gcColorPicker4.SelectedColor
            gcMaskedComboBox1.ReadOnlyBackColor = gcColorPicker4.SelectedColor
        End Sub

        Private Sub checkBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox1.CheckedChanged
            ' ReadOnlyプロパティ
            gcTextBox1.ReadOnly = checkBox1.Checked
            gcMask1.ReadOnly = checkBox1.Checked
            gcCharMask1.ReadOnly = checkBox1.Checked
            gcDateTime1.ReadOnly = checkBox1.Checked
            gcDate1.ReadOnly = checkBox1.Checked
            gcTime1.ReadOnly = checkBox1.Checked
            gcTimeSpan1.ReadOnly = checkBox1.Checked
            gcNumber1.ReadOnly = checkBox1.Checked
            gcComboBox1.ReadOnly = checkBox1.Checked
            gcMaskedComboBox1.ReadOnly = checkBox1.Checked
        End Sub
    End Class
End Namespace