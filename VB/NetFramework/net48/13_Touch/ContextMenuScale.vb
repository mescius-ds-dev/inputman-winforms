Imports System.Windows.Forms

Namespace _13_Touch
    Partial Public Class ContextMenuScale
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            ' xmlファイルからデータ取得(GcComboBox)
            Dim filePath As System.String = Application.StartupPath
            Me.dataSet1.ReadXml(filePath & "\Resources\prefecture.xml")
            gcComboBox1.DataSource = dataSet1.Tables(0)
            gcComboBox1.SelectedIndex = -1

            For i As Integer = 1 To gcComboBox1.ListColumns.Count - 1
                gcComboBox1.ListColumns(i).AutoWidth = True
            Next

            ' xmlファイルからデータ取得(GcMaskedComboBox)
            Me.DataSet2.ReadXml(filePath & "\Resources\pref.xml")
            GcMaskedComboBox1.DataSource = DataSet2.Tables(0)
            GcMaskedComboBox1.SelectedIndex = -1

            For i As Integer = 1 To GcMaskedComboBox1.ListColumns.Count - 1
                GcMaskedComboBox1.ListColumns(i).AutoWidth = True
            Next
        End Sub

        Private Sub gcNumber2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcNumber2.ValueChanged
            ' TouchContextMenuScaleプロパティ
            gcTextBox1.TouchContextMenuScale = CSng(gcNumber2.Value)
            gcMask1.TouchContextMenuScale = CSng(gcNumber2.Value)
            gcCharMask1.TouchContextMenuScale = CSng(gcNumber2.Value)
            gcDateTime1.TouchContextMenuScale = CSng(gcNumber2.Value)
            gcDate1.TouchContextMenuScale = CSng(gcNumber2.Value)
            gcTime1.TouchContextMenuScale = CSng(gcNumber2.Value)
            gcTimeSpan1.TouchContextMenuScale = CSng(gcNumber2.Value)
            gcNumber1.TouchContextMenuScale = CSng(gcNumber2.Value)
            gcComboBox1.TouchContextMenuScale = CSng(gcNumber2.Value)
            GcMaskedComboBox1.TouchContextMenuScale = CSng(gcNumber2.Value)
        End Sub

    End Class
End Namespace
