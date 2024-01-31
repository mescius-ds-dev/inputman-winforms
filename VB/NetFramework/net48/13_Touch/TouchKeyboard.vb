Imports System.Windows.Forms
Imports GrapeCity.Win.Editors

Namespace _13_Touch
    Partial Public Class TouchKeyboard
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
           ' xmlファイルからデータ取得
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

            gcComboBox2.SelectedIndex = 2
            gcComboBox3.SelectedIndex = 1

        End Sub

        Private Sub Control_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles gcTextBox1.GotFocus, gcMask1.GotFocus, gcCharMask1.GotFocus, gcDateTime1.GotFocus, gcDate1.GotFocus, gcTime1.GotFocus, gcTimeSpan1.LostFocus, gcNumber1.GotFocus, gcComboBox1.GotFocus, GcMaskedComboBox1.GotFocus
            If checkBox1.Checked Then
                ' タッチキーボードを表示
                gcIme1.ShowTouchKeyboard()
            End If
        End Sub

        Private Sub Control_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles gcTextBox1.LostFocus, gcMask1.LostFocus, gcCharMask1.LostFocus, gcDateTime1.LostFocus, gcDate1.LostFocus, gcTime1.LostFocus, gcTimeSpan1.LostFocus, gcNumber1.LostFocus, gcComboBox1.LostFocus, GcMaskedComboBox1.LostFocus
            If checkBox2.Checked Then
                ' タッチキーボードを非表示
                gcIme1.HideTouchKeyboard()
            End If
        End Sub

        Private Sub gcComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gcComboBox2.SelectedIndexChanged
            ' InputScopeの設定
            Dim inputScope As InputScopeNameValue = DirectCast([Enum].Parse(GetType(InputScopeNameValue), gcComboBox2.SelectedItem.Text), InputScopeNameValue)
            gcIme1.SetInputScope(gcTextBox1, inputScope)
            gcIme1.SetInputScope(gcMask1, inputScope)
            gcIme1.SetInputScope(gcCharMask1, inputScope)
            gcIme1.SetInputScope(gcDateTime1, inputScope)
            gcIme1.SetInputScope(gcDate1, inputScope)
            gcIme1.SetInputScope(gcTime1, inputScope)
            gcIme1.SetInputScope(gcTimeSpan1, inputScope)
            gcIme1.SetInputScope(gcNumber1, inputScope)
            gcIme1.SetInputScope(gcComboBox1, inputScope)
            gcIme1.SetInputScope(GcMaskedComboBox1, inputScope)
        End Sub

        Private Sub gcComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox3.SelectedIndexChanged
            ' AutoHideTouchKeyboardの設定
            gcTextBox1.DropDown.AutoHideTouchKeyboard = DirectCast(gcComboBox3.SelectedIndex, AutoHideTouchKeyboard)
            gcDate1.DropDown.AutoHideTouchKeyboard = DirectCast(gcComboBox3.SelectedIndex, AutoHideTouchKeyboard)
            gcDateTime1.DropDown.AutoHideTouchKeyboard = DirectCast(gcComboBox3.SelectedIndex, AutoHideTouchKeyboard)
            gcTime1.DropDown.AutoHideTouchKeyboard = DirectCast(gcComboBox3.SelectedIndex, AutoHideTouchKeyboard)
            gcNumber1.DropDown.AutoHideTouchKeyboard = DirectCast(gcComboBox3.SelectedIndex, AutoHideTouchKeyboard)
            gcComboBox1.DropDown.AutoHideTouchKeyboard = DirectCast(gcComboBox3.SelectedIndex, AutoHideTouchKeyboard)
            GcMaskedComboBox1.DropDown.AutoHideTouchKeyboard = DirectCast(gcComboBox3.SelectedIndex, AutoHideTouchKeyboard)

        End Sub
    End Class
End Namespace