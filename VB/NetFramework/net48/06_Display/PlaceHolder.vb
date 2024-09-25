Imports System.Windows.Forms
Imports System.Data
Imports System.Drawing

Namespace _06_Display
    Partial Public Class PlaceHolder
        Inherits InputManWin12_Demo.DemoBase_settings

        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            ' xmlファイルからデータ取得(GcComboBox)
            Dim filePath As System.String = Application.StartupPath
            Me.dataSet1.ReadXml(filePath & "\Resources\prefecture.xml")

            Dim dv1 As New DataView(dataSet1.Tables(0))
            gcComboBox1.DataSource = dv1
            gcComboBox1.SelectedIndex = 0

            For i As Integer = 1 To gcComboBox1.ListColumns.Count - 1
                gcComboBox1.ListColumns(i).AutoWidth = True
            Next
            gcComboBox2.SelectedIndex = 0
        End Sub

        Private Sub checkBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox1.CheckedChanged
            gcTextBox1.PlaceHolder.Enable = checkBox1.Checked
            gcTextBox1.PlaceHolder.FloatingStyle.Font = New Font("メイリオ", CInt(gcNumber2.Value))
            gcMask1.PlaceHolder.Enable = checkBox1.Checked
            gcMask1.PlaceHolder.FloatingStyle.Font = New Font("メイリオ", CInt(gcNumber2.Value))
            gcMask1.PlaceHolder.FloatingStyle.ForeColor = Color.Red
            gcDateTime1.PlaceHolder.Enable = checkBox1.Checked
            gcDateTime1.PlaceHolder.FloatingStyle.Font = New Font("メイリオ", CInt(gcNumber2.Value))
            gcDateTime1.PlaceHolder.FloatingStyle.ForeColor = Color.Red
            gcTime1.PlaceHolder.Enable = checkBox1.Checked
            gcTime1.PlaceHolder.FloatingStyle.Font = New Font("メイリオ", CInt(gcNumber2.Value))
            gcTime1.PlaceHolder.FloatingStyle.ForeColor = Color.Red
            gcDate1.PlaceHolder.Enable = checkBox1.Checked
            gcDate1.PlaceHolder.FloatingStyle.Font = New Font("メイリオ", CInt(gcNumber2.Value))
            gcTimeSpan1.PlaceHolder.Enable = checkBox1.Checked
            gcTimeSpan1.PlaceHolder.FloatingStyle.Font = New Font("メイリオ", CInt(gcNumber2.Value))
            gcNumber1.PlaceHolder.Enable = checkBox1.Checked
            gcNumber1.PlaceHolder.FloatingStyle.Font = New Font("メイリオ", CInt(gcNumber2.Value))
            gcNumber1.PlaceHolder.FloatingStyle.ForeColor = Color.Red
            gcComboBox1.PlaceHolder.Enable = checkBox1.Checked
            gcComboBox1.PlaceHolder.FloatingStyle.Font = New Font("メイリオ", CInt(gcNumber2.Value))
        End Sub

        Private Sub gcNumber2_ValueChanged(sender As Object, e As EventArgs) Handles gcNumber2.ValueChanged
            gcTextBox1.PlaceHolder.FloatingStyle.Font = New Font("メイリオ", CInt(gcNumber2.Value))
            gcMask1.PlaceHolder.FloatingStyle.Font = New Font("メイリオ", CInt(gcNumber2.Value))
            gcDateTime1.PlaceHolder.FloatingStyle.Font = New Font("メイリオ", CInt(gcNumber2.Value))
            gcTime1.PlaceHolder.FloatingStyle.Font = New Font("メイリオ", CInt(gcNumber2.Value))
            gcDate1.PlaceHolder.FloatingStyle.Font = New Font("メイリオ", CInt(gcNumber2.Value))
            gcTimeSpan1.PlaceHolder.FloatingStyle.Font = New Font("メイリオ", CInt(gcNumber2.Value))
            gcNumber1.PlaceHolder.FloatingStyle.Font = New Font("メイリオ", CInt(gcNumber2.Value))
            gcComboBox1.PlaceHolder.FloatingStyle.Font = New Font("メイリオ", CInt(gcNumber2.Value))
        End Sub

        Private Sub gcComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            ' PlaceHolderAlignmentプロパティ
            gcTextBox1.PlaceHolder.FloatingStyle.PlaceHolderAlignment = CType(gcComboBox2.SelectedIndex, GrapeCity.Framework.Views.PlaceHolderAlignment)
            gcMask1.PlaceHolder.FloatingStyle.PlaceHolderAlignment = CType(gcComboBox2.SelectedIndex, GrapeCity.Framework.Views.PlaceHolderAlignment)
            gcDateTime1.PlaceHolder.FloatingStyle.PlaceHolderAlignment = CType(gcComboBox2.SelectedIndex, GrapeCity.Framework.Views.PlaceHolderAlignment)
            gcTime1.PlaceHolder.FloatingStyle.PlaceHolderAlignment = CType(gcComboBox2.SelectedIndex, GrapeCity.Framework.Views.PlaceHolderAlignment)
            gcDate1.PlaceHolder.FloatingStyle.PlaceHolderAlignment = CType(gcComboBox2.SelectedIndex, GrapeCity.Framework.Views.PlaceHolderAlignment)
            gcTimeSpan1.PlaceHolder.FloatingStyle.PlaceHolderAlignment = CType(gcComboBox2.SelectedIndex, GrapeCity.Framework.Views.PlaceHolderAlignment)
            gcNumber1.PlaceHolder.FloatingStyle.PlaceHolderAlignment = CType(gcComboBox2.SelectedIndex, GrapeCity.Framework.Views.PlaceHolderAlignment)
            gcComboBox1.PlaceHolder.FloatingStyle.PlaceHolderAlignment = CType(gcComboBox2.SelectedIndex, GrapeCity.Framework.Views.PlaceHolderAlignment)
        End Sub
    End Class
End Namespace

