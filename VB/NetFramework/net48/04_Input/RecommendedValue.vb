Imports System.Windows.Forms

Namespace _04_Input
    Partial Public Class RecommendedValue
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
           ' ***** 初期値
            checkBox1.Checked = True

            ' xmlファイルからデータ取得
            Dim filePath As System.String = Application.StartupPath
            Me.dataSet1.ReadXml(filePath & "\Resources\prefecture.xml")
            gcComboBox1.DataSource = dataSet1.Tables(0)
            gcComboBox1.SelectedIndex = -1

            For i As Integer = 1 To gcComboBox1.ListColumns.Count - 1
                gcComboBox1.ListColumns(i).AutoWidth = True
            Next
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            ' ApplyRecommendedValueメソッド
            gcTextBox1.[Select]()
            gcTextBox1.ApplyRecommendedValue()
            gcMask1.ApplyRecommendedValue()
            gcCharMask1.ApplyRecommendedValue()
            gcDate1.ApplyRecommendedValue()
            gcTimeSpan1.ApplyRecommendedValue()
            gcNumber1.[Select]()
            gcNumber1.ApplyRecommendedValue()
            gcComboBox1.[Select]()
            gcComboBox1.ApplyRecommendedValue()
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
            gcTextBox1.Clear()
            gcMask1.Clear()
            gcCharMask1.Clear()
            gcDateTime1.Clear()
            gcDate1.Clear()
            gcTime1.Clear()
            gcTimeSpan1.Clear()
            gcNumber1.Clear()
            gcComboBox1.Clear()
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            ' ShowRecommendedValueプロパティ
            gcTextBox1.ShowRecommendedValue = checkBox1.Checked
            gcMask1.ShowRecommendedValue = checkBox1.Checked
            gcCharMask1.ShowRecommendedValue = checkBox1.Checked
            gcDateTime1.ShowRecommendedValue = checkBox1.Checked
            gcDate1.ShowRecommendedValue = checkBox1.Checked
            gcTime1.ShowRecommendedValue = checkBox1.Checked
            gcTimeSpan1.ShowRecommendedValue = checkBox1.Checked
            gcNumber1.ShowRecommendedValue = checkBox1.Checked
            gcComboBox1.ShowRecommendedValue = checkBox1.Checked
        End Sub
    End Class
End Namespace
