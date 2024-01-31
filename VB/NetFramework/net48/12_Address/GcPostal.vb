Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports GrapeCity.Win.Editors

Namespace _12_Address
    Partial Public Class GcPostal
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            ' ***** 初期設定
            AddHandler gcPostal1.TextChanged, New EventHandler(AddressOf gcPostal1_TextChanged)
            AddHandler gcComboBox1.SelectedIndexChanged, New EventHandler(AddressOf gcComboBox1_SelectedIndexChanged)
            AddHandler checkBox1.CheckedChanged, New EventHandler(AddressOf checkBox1_CheckedChanged)
            AddHandler checkBox2.CheckedChanged, New EventHandler(AddressOf checkBox2_CheckedChanged)
            AddHandler checkBox3.CheckedChanged, New EventHandler(AddressOf checkBox3_CheckedChanged)
            AddHandler checkBox4.CheckedChanged, New EventHandler(AddressOf checkBox4_CheckedChanged)
            AddHandler sideButton1.Click, New EventHandler(AddressOf sideButton1_Click)
            AddHandler gcColorPicker1.SelectedIndexChanged, New EventHandler(AddressOf gcColorPicker1_SelectedIndexChanged)
            AddHandler gcColorPicker2.SelectedIndexChanged, New EventHandler(AddressOf gcColorPicker2_SelectedIndexChanged)
            AddHandler sideButton2.Click, New EventHandler(AddressOf sideButton2_Click)

            ' ***** 初期値
            gcComboBox1.SelectedIndex = CType(gcPostal1.QueryMode, Int32) - 1
            checkBox1.Checked = gcPostal1.SplitAreaDetails
            checkBox2.Enabled = False
        End Sub

        Private Sub gcPostal1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcPostal1.TextChanged
            gcListBox1.DataSource = gcPostal1.Addresses
        End Sub

        Private Sub gcComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox1.SelectedIndexChanged
            ' QueryModeプロパティ
            gcPostal1.QueryMode = CType(gcComboBox1.SelectedIndex + 1, ZipCodeQueryMode)

            If gcComboBox1.SelectedIndex = 1 OrElse gcComboBox1.SelectedIndex = 2 Then
                checkBox2.Enabled = True
                checkBox2.Checked = gcPostal1.GenerateCompanyAddressKana
            Else
                checkBox2.Enabled = False
            End If

            gcPostal1.Clear()
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            Dim val As String = gcPostal1.Value

            ' SplitAreaDetailsプロパティ
            gcPostal1.SplitAreaDetails = checkBox1.Checked

            gcPostal1.Clear()
            gcPostal1.Value = val
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
            Dim val As String = gcPostal1.Value

            ' GenerateCompanyAddressKanaプロパティ
            gcPostal1.GenerateCompanyAddressKana = checkBox2.Checked

            gcPostal1.Clear()
            gcPostal1.Value = val
        End Sub

        Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox3.CheckedChanged
            Dim val As String = gcPostal1.Value

            ' AutoCompleteModeプロパティ
            If checkBox3.Checked Then
                gcPostal1.AutoCompleteMode = AutoCompleteMode.Suggest
            Else
                gcPostal1.AutoCompleteMode = AutoCompleteMode.None
            End If

            gcPostal1.Clear()
            gcPostal1.Value = val
        End Sub

        Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox4.CheckedChanged
            ' ハイライト表示
            gcPostal1.AutoComplete.HighlightMatchedText = checkBox4.Checked
        End Sub

        Private Sub sideButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sideButton1.Click
            ' 検索文字列のフォント
            Dim fd As New FontDialog()

            fd.Font = gcPostal1.AutoComplete.HighlightStyle.Font
            fd.ShowColor = False

            If fd.ShowDialog() <> DialogResult.Cancel Then
                gcPostal1.AutoComplete.HighlightStyle.Font = fd.Font
                gcTextBox1.Text = fd.Font.ToString()
            End If
        End Sub

        Private Sub gcColorPicker1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcColorPicker1.SelectedIndexChanged
            ' 検索文字列の前景色
            gcPostal1.AutoComplete.HighlightStyle.ForeColor = gcColorPicker1.SelectedColor
        End Sub

        Private Sub gcColorPicker2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcColorPicker2.SelectedIndexChanged
            ' 検索文字列の背景色
            gcPostal1.AutoComplete.HighlightStyle.BackColor = gcColorPicker2.SelectedColor
        End Sub

        Private Sub sideButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sideButton2.Click
            ' 候補リストのフォント
            Dim fd As New FontDialog()

            fd.Font = gcPostal1.AutoComplete.CandidateListItemFont
            fd.ShowColor = False

            If fd.ShowDialog() <> DialogResult.Cancel Then
                gcPostal1.AutoComplete.CandidateListItemFont = fd.Font
                gcTextBox2.Text = fd.Font.ToString()
            End If
        End Sub
    End Class
End Namespace
