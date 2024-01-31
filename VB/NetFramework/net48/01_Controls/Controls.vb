Imports System.Windows.Forms

Namespace _01_Controls
    Partial Public Class Controls
        Inherits InputManWin12_Demo.DemoBase
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            ' xmlファイルからデータ取得
            Dim filePath As System.String = Application.StartupPath
            Me.DataSet1.ReadXml(filePath & "\Resources\pref.xml")
            GcMaskedComboBox1.DataSource = DataSet1.Tables(0)
            GcMaskedComboBox1.SelectedIndex = -1

            For i As Integer = 1 To GcMaskedComboBox1.ListColumns.Count - 1
                GcMaskedComboBox1.ListColumns(i).AutoWidth = True
            Next
        End Sub


    End Class
End Namespace
