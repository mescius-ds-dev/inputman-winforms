Imports System.Windows.Forms
Imports GrapeCity.Win.Editors

Namespace _13_Touch
    Partial Public Class TouchToolBar
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

        Private Sub checkBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged, checkBox3.CheckedChanged, checkBox2.CheckedChanged

            Dim DisplayOption As Integer = 0

            If checkBox1.Checked Then
                DisplayOption = DisplayOption Or TouchToolBarDisplayOptions.PressAndHold
            End If
            If checkBox2.Checked Then
                DisplayOption = DisplayOption Or TouchToolBarDisplayOptions.TapSelection
            End If
            If checkBox3.Checked Then
                DisplayOption = DisplayOption Or TouchToolBarDisplayOptions.TapGripper
            End If

            gcTextBox1.ShowTouchToolBar = CType(DisplayOption, TouchToolBarDisplayOptions)
            gcMask1.ShowTouchToolBar = CType(DisplayOption, TouchToolBarDisplayOptions)
            gcCharMask1.ShowTouchToolBar = CType(DisplayOption, TouchToolBarDisplayOptions)
            gcDateTime1.ShowTouchToolBar = CType(DisplayOption, TouchToolBarDisplayOptions)
            gcDate1.ShowTouchToolBar = CType(DisplayOption, TouchToolBarDisplayOptions)
            gcTime1.ShowTouchToolBar = CType(DisplayOption, TouchToolBarDisplayOptions)
            gcTimeSpan1.ShowTouchToolBar = CType(DisplayOption, TouchToolBarDisplayOptions)
            gcNumber1.ShowTouchToolBar = CType(DisplayOption, TouchToolBarDisplayOptions)
            gcComboBox1.ShowTouchToolBar = CType(DisplayOption, TouchToolBarDisplayOptions)
            GcMaskedComboBox1.ShowTouchToolBar = CType(DisplayOption, TouchToolBarDisplayOptions)
        End Sub
    End Class
End Namespace

