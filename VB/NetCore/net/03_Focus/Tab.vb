Imports GrapeCity.Win.Editors
Imports System.Windows.Forms

Namespace _03_Focus
    Partial Public Class Tab
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            ' ***** 初期値
            gcComboBox1.SelectedIndex = If((gcTextBox1.AcceptsTab = True), 0, 1)
            gcComboBox2.SelectedIndex = Convert.ToInt32(gcMask1.TabAction)

            ' xmlファイルからデータ取得(GcMaskedComboBox)
            Dim filePath As System.String = Application.StartupPath
            Me.DataSet1.ReadXml(filePath & "\Resources\pref.xml")
            GcMaskedComboBox1.DataSource = DataSet1.Tables(0)
            GcMaskedComboBox1.SelectedIndex = -1

            For i As Integer = 1 To GcMaskedComboBox1.ListColumns.Count - 1
                GcMaskedComboBox1.ListColumns(i).AutoWidth = True
            Next
        End Sub

        Private Sub gcComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox1.SelectedIndexChanged
            ' AcceptsTabプロパティ
            gcTextBox1.AcceptsTab = If((gcComboBox1.SelectedIndex = 0), True, False)
        End Sub

        Private Sub gcComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            ' TabActionプロパティ
            gcMask1.TabAction = CType(gcComboBox2.SelectedIndex, TabAction)
            gcDateTime1.TabAction = CType(gcComboBox2.SelectedIndex, TabAction)
            gcDate1.TabAction = CType(gcComboBox2.SelectedIndex, TabAction)
            gcTime1.TabAction = CType(gcComboBox2.SelectedIndex, TabAction)
            gcTimeSpan1.TabAction = CType(gcComboBox2.SelectedIndex, TabAction)
            GcMaskedComboBox1.TabAction = CType(gcComboBox2.SelectedIndex, TabAction)
        End Sub
    End Class
End Namespace
