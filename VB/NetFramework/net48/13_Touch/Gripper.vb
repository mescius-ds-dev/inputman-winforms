Imports System.Windows.Forms

Namespace _13_Touch
    Partial Public Class Gripper
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

        Private Sub checkBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
            ' ShowGrippersプロパティ
            gcTextBox1.ShowGrippers = checkBox1.Checked
            gcMask1.ShowGrippers = checkBox1.Checked
            gcCharMask1.ShowGrippers = checkBox1.Checked
            gcDateTime1.ShowGrippers = checkBox1.Checked
            gcDate1.ShowGrippers = checkBox1.Checked
            gcTime1.ShowGrippers = checkBox1.Checked
            gcTimeSpan1.ShowGrippers = checkBox1.Checked
            gcNumber1.ShowGrippers = checkBox1.Checked
            gcComboBox1.ShowGrippers = checkBox1.Checked
            GcMaskedComboBox1.ShowGrippers = checkBox1.Checked
        End Sub
    End Class
End Namespace
