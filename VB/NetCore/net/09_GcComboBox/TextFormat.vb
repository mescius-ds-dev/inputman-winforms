Imports System.ComponentModel
Imports System.Windows.Forms

Namespace _09_GcComboBox
    Partial Public Class TextFormat
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
           ' xmlファイルからショートカット機能一覧取得
            Dim filePath As System.String = Application.StartupPath
            Me.dataSet1.ReadXml(filePath & "\Resources\XMLDataFile.xml")
            gcComboBox1.DataSource = dataSet1.Tables(0)

            ' ***** 初期値
            gcComboBox1.TextFormat = gcTextBox1.Text

            For i As Integer = 0 To gcComboBox1.ListColumns.Count - 1
                gcComboBox1.ListColumns(i).AutoWidth = True
                gcComboBox1.ListColumns(i).Header.Image = 0
            Next
            gcComboBox1.DropDown.Direction = GrapeCity.Win.Editors.DropDownDirection.BelowLeft
        End Sub

        Private Sub gcComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            ' TextSubItemIndexプロパティ
            gcComboBox1.TextSubItemIndex = gcComboBox2.SelectedIndex
        End Sub

        Private Sub gcTextBox1_Validating(ByVal sender As Object, ByVal e As CancelEventArgs) Handles gcTextBox1.Validating
            ' TextFormatプロパティ
            Try
                gcComboBox1.TextFormat = gcTextBox1.Text
            Catch ex As Exception
                MessageBox.Show(ex.Message, "書式設定エラー", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                e.Cancel = True
            End Try
        End Sub
    End Class
End Namespace
