Imports System.Windows.Forms

Namespace _10_GcListBox
	Public Partial Class ListMultiColumns
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
			InitializeComponent()
			InitializeForm()
		End Sub

        Private Sub InitializeForm()
            ' ***** 初期設定
            AddHandler checkBox1.CheckedChanged, New EventHandler(AddressOf checkBox1_CheckedChanged)
            AddHandler checkBox2.CheckedChanged, New EventHandler(AddressOf checkBox2_CheckedChanged)
            AddHandler checkBox3.CheckedChanged, New EventHandler(AddressOf checkBox3_CheckedChanged)
            AddHandler checkBox4.CheckedChanged, New EventHandler(AddressOf checkBox4_CheckedChanged)
            AddHandler gcComboBox1.SelectedIndexChanged, New EventHandler(AddressOf gcComboBox1_SelectedIndexChanged)
            AddHandler gcColorPicker1.SelectedIndexChanged, New EventHandler(AddressOf gcColorPicker1_SelectedIndexChanged)
            AddHandler gcColorPicker2.SelectedIndexChanged, New EventHandler(AddressOf gcColorPicker2_SelectedIndexChanged)

            ' xmlファイルからショートカット機能一覧取得
            Dim filePath As System.String = Application.StartupPath
            Me.dataSet1.ReadXml(filePath & "\Resources\XMLDataFile.xml")
            gcListBox1.DataSource = dataSet1.Tables(0)

            ' ***** 初期値
            checkBox1.Checked = gcListBox1.ListHeaderPane.Visible
            checkBox2.Checked = gcListBox1.Columns(0).Header.AllowResize
            checkBox3.Checked = True
            checkBox4.Checked = gcListBox1.ShowCheckBox
            gcComboBox1.SelectedIndex = Convert.ToInt32(gcListBox1.SelectionMode)

            For i As Integer = 0 To gcListBox1.Columns.Count - 1
                gcListBox1.Columns(i).AutoWidth = True
                gcListBox1.Columns(i).Header.Image = 0
                If i > 3 Then
                    gcListBox1.Columns(i).Visible = False
                End If
            Next

            gcListBox1.StatusBar.Visible = True

        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            ' ヘッダの表示／非表示
            gcListBox1.ListHeaderPane.Visible = checkBox1.Checked
            checkBox2.Enabled = checkBox1.Checked
            checkBox3.Enabled = checkBox1.Checked
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
            ' ヘッダのリサイズ
            For i As Integer = 0 To gcListBox1.Columns.Count - 1
                gcListBox1.Columns(i).Header.AllowResize = checkBox2.Checked
            Next
        End Sub

        Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox3.CheckedChanged
            ' ヘッダの画像の表示
            If checkBox3.Checked Then
                gcListBox1.Columns(0).Header.Image = 4
                gcListBox1.Columns(1).Header.Image = 2
                gcListBox1.Columns(2).Header.Image = 1
                gcListBox1.Columns(3).Header.Image = 1
                gcListBox1.Columns(4).Header.Image = 3
                gcListBox1.Columns(5).Header.Image = 0
            Else
                gcListBox1.Columns(0).Header.Image = Nothing
                gcListBox1.Columns(1).Header.Image = Nothing
                gcListBox1.Columns(2).Header.Image = Nothing
                gcListBox1.Columns(3).Header.Image = Nothing
                gcListBox1.Columns(4).Header.Image = Nothing
                gcListBox1.Columns(5).Header.Image = Nothing
            End If
        End Sub

        Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox4.CheckedChanged
            ' チェックボックスの表示／非表示
            gcListBox1.ShowCheckBox = checkBox4.Checked
        End Sub

        Private Sub gcComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox1.SelectedIndexChanged
            ' 項目の選択状態
            gcListBox1.SelectionMode = CType(gcComboBox1.SelectedIndex, SelectionMode)
        End Sub

        Private Sub gcColorPicker1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcColorPicker1.SelectedIndexChanged
            ' 選択行の前景色
            gcListBox1.SelectedItemStyle.ForeColor = gcColorPicker1.SelectedColor
        End Sub

        Private Sub gcColorPicker2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcColorPicker2.SelectedIndexChanged
            ' 選択行の背景色
            gcListBox1.SelectedItemStyle.BackColor = gcColorPicker2.SelectedColor
        End Sub

        Private Sub gcComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            gcListBox1.DescriptionFormat = gcComboBox2.SelectedValue.ToString()
        End Sub
    End Class
End Namespace
