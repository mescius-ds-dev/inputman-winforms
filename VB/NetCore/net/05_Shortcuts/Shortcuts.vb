Imports System.Windows.Forms

Namespace _05_Shortcuts
    Partial Public Class Shortcuts
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            ' ***** 初期設定

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
    End Class
End Namespace
