Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports GrapeCity.Win.Editors

Namespace _09_GcComboBox
    Partial Public Class AutoFilter
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            ' xmlファイルからショートカット機能一覧取得
            Dim filePath As System.String = Application.StartupPath
            Me.dataSet1.ReadXml(filePath & "\Resources\prefecture.xml")
            gcComboBox1.DataSource = dataSet1.Tables(0)
            gcComboBox1.ListColumns(0).AutoWidth = False

            ' ***** 初期値
            checkBox1.Checked = False
            checkBox2.Checked = False
            gcNumber1.Value = gcComboBox1.AutoFilter.Interval
            gcNumber2.Value = gcComboBox1.AutoFilter.MaxFilteredItems
            gcNumber3.Value = gcComboBox1.AutoFilter.MinimumPrefixLength
            gcComboBox2.SelectedIndex = Convert.ToInt32(gcComboBox1.AutoFilter.MatchingMode)
            gcComboBox3.SelectedIndex = Convert.ToInt32(gcComboBox1.AutoFilter.MatchingSource)

            For i As Integer = 1 To gcComboBox1.ListColumns.Count - 1
                gcComboBox1.ListColumns(i).AutoWidth = True
            Next
            gcComboBox1.DropDown.Direction = DropDownDirection.BelowLeft
        End Sub

        Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            ' AutoFilterプロパティ
            gcComboBox1.AutoFilter.Enabled = checkBox1.Checked
        End Sub

        Private Sub CheckBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
            ' AutoSelectプロパティ
            gcComboBox1.AutoSelect = checkBox2.Checked
        End Sub

        Private Sub GcNumber1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcNumber1.ValueChanged
            ' AutoFilter.Intervalプロパティ
            If gcNumber1.Value.HasValue Then
                gcComboBox1.AutoFilter.Interval = CInt(gcNumber1.Value.Value)
            Else
                gcNumber1.Value = gcNumber1.MinValue
                gcComboBox1.AutoFilter.Interval = CInt(gcNumber1.Value.Value)
            End If
        End Sub

        Private Sub GcNumber2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcNumber2.ValueChanged
            ' AutoFilter.MaxFilteredItemsプロパティ
            If gcNumber2.Value.HasValue Then
                gcComboBox1.AutoFilter.MaxFilteredItems = CInt(gcNumber2.Value.Value)
            Else
                gcNumber2.Value = gcNumber2.MinValue
                gcComboBox1.AutoFilter.MaxFilteredItems = CInt(gcNumber2.Value.Value)
            End If
        End Sub

        Private Sub GcNumber3_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcNumber3.ValueChanged
            ' AutoFilter.MinimumPrefixLengthプロパティ
            If gcNumber3.Value.HasValue Then
                If gcNumber3.Value.Value < 1 Then
                    gcNumber3.Value = gcNumber3.MinValue
                    gcComboBox1.AutoFilter.MinimumPrefixLength = CInt(gcNumber3.Value.Value)
                Else
                    gcComboBox1.AutoFilter.MinimumPrefixLength = CInt(gcNumber3.Value.Value)
                End If
            Else
                gcNumber3.Value = gcNumber3.MinValue
                gcComboBox1.AutoFilter.MinimumPrefixLength = CInt(gcNumber3.Value.Value)
            End If
        End Sub

        Private Sub GcComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            ' AutoFilter.MatchingModeプロパティ
            gcComboBox1.AutoFilter.MatchingMode = CType(gcComboBox2.SelectedIndex, AutoCompleteMatchingMode)
        End Sub

        Private Sub GcComboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox3.SelectedIndexChanged
            ' AutoFilter.MatchingSourceプロパティ
            gcComboBox1.AutoFilter.MatchingSource = CType(gcComboBox3.SelectedIndex, FilterMatchingSource)
        End Sub

        Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox3.CheckedChanged
            If checkBox3.Checked Then
                AddHandler gcComboBox1.ExtractedItemsIndicesChanged, AddressOf GcComboBox1_ExtractedItemsIndicesChanged
            Else
                RemoveHandler gcComboBox1.ExtractedItemsIndicesChanged, AddressOf GcComboBox1_ExtractedItemsIndicesChanged
            End If
        End Sub

        Private Sub GcComboBox1_ExtractedItemsIndicesChanged(sender As Object, e As EventArgs)
            Dim builder As StringBuilder = New StringBuilder()
            builder.Append(gcComboBox1.Items.Count)
            builder.Append("件中")
            builder.Append(gcComboBox1.ExtractedItemsIndices.Count)
            builder.Append("件表示")
            builder.Append(vbCrLf)
            builder.Append("表示中の項目のインデックス：")
            builder.Append(String.Join(",", gcComboBox1.ExtractedItemsIndices.ToArray()))

            MessageBox.Show(builder.ToString())
        End Sub
    End Class
End Namespace
