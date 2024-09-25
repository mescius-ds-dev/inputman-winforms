Imports System.Windows.Forms
Imports GrapeCity.Win.Editors

Namespace _08_SideButton
    Partial Public Class DropDownButton
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            ' ***** 初期値
            gcComboBox2.SelectedIndex = Convert.ToInt32(gcTextBox1.FlatStyle)
            gcComboBox3.SelectedIndex = Convert.ToInt32(gcTextBox1.SideButtons(0).Position)
            checkBox1.Checked = DirectCast(gcTextBox1.SideButtons(0), GrapeCity.Win.Editors.DropDownButton).IsDefaultBehavior
            checkBox2.Checked = gcDateTime1.DropDownCalendar.NavigateOnWheel

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
        End Sub

        Private Sub gcComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            ' FlatStyleプロパティ
            gcTextBox1.FlatStyle = CType(gcComboBox2.SelectedIndex, FlatStyleEx)
            gcDateTime1.FlatStyle = CType(gcComboBox2.SelectedIndex, FlatStyleEx)
            gcDate1.FlatStyle = CType(gcComboBox2.SelectedIndex, FlatStyleEx)
            gcTime1.FlatStyle = CType(gcComboBox2.SelectedIndex, FlatStyleEx)
            gcNumber1.FlatStyle = CType(gcComboBox2.SelectedIndex, FlatStyleEx)
            gcComboBox1.FlatStyle = CType(gcComboBox2.SelectedIndex, FlatStyleEx)
            GcMaskedComboBox1.FlatStyle = CType(gcComboBox2.SelectedIndex, FlatStyleEx)
        End Sub

        Private Sub gcComboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox3.SelectedIndexChanged
            ' サイドボタンの位置
            gcTextBox1.SideButtons(0).Position = CType(gcComboBox3.SelectedIndex, ButtonPosition)
            gcDateTime1.SideButtons(0).Position = CType(gcComboBox3.SelectedIndex, ButtonPosition)
            gcDate1.SideButtons(0).Position = CType(gcComboBox3.SelectedIndex, ButtonPosition)
            gcTime1.SideButtons(0).Position = CType(gcComboBox3.SelectedIndex, ButtonPosition)
            gcNumber1.SideButtons(0).Position = CType(gcComboBox3.SelectedIndex, ButtonPosition)
            gcComboBox1.SideButtons(0).Position = CType(gcComboBox3.SelectedIndex, ButtonPosition)
            GcMaskedComboBox1.SideButtons(0).Position = CType(gcComboBox3.SelectedIndex, ButtonPosition)
        End Sub

        Private Sub gcColorPicker1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcColorPicker1.SelectedIndexChanged
            ' サイドボタンの前景色
            gcTextBox1.SideButtons(0).ForeColor = gcColorPicker1.SelectedColor
            gcDateTime1.SideButtons(0).ForeColor = gcColorPicker1.SelectedColor
            gcDate1.SideButtons(0).ForeColor = gcColorPicker1.SelectedColor
            gcTime1.SideButtons(0).ForeColor = gcColorPicker1.SelectedColor
            gcNumber1.SideButtons(0).ForeColor = gcColorPicker1.SelectedColor
            gcComboBox1.SideButtons(0).ForeColor = gcColorPicker1.SelectedColor
            GcMaskedComboBox1.SideButtons(0).ForeColor = gcColorPicker1.SelectedColor
        End Sub

        Private Sub gcColorPicker2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcColorPicker2.SelectedIndexChanged
            ' サイドボタンの背景色
            gcTextBox1.SideButtons(0).BackColor = gcColorPicker2.SelectedColor
            gcDateTime1.SideButtons(0).BackColor = gcColorPicker2.SelectedColor
            gcDate1.SideButtons(0).BackColor = gcColorPicker2.SelectedColor
            gcTime1.SideButtons(0).BackColor = gcColorPicker2.SelectedColor
            gcNumber1.SideButtons(0).BackColor = gcColorPicker2.SelectedColor
            gcComboBox1.SideButtons(0).BackColor = gcColorPicker2.SelectedColor
            GcMaskedComboBox1.SideButtons(0).BackColor = gcColorPicker2.SelectedColor
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            ' ドロップダウンの既定機能
            DirectCast(gcTextBox1.SideButtons(0), GrapeCity.Win.Editors.DropDownButton).IsDefaultBehavior = checkBox1.Checked
            DirectCast(gcDateTime1.SideButtons(0), GrapeCity.Win.Editors.DropDownButton).IsDefaultBehavior = checkBox1.Checked
            DirectCast(gcDate1.SideButtons(0), GrapeCity.Win.Editors.DropDownButton).IsDefaultBehavior = checkBox1.Checked
            DirectCast(gcTime1.SideButtons(0), GrapeCity.Win.Editors.DropDownButton).IsDefaultBehavior = checkBox1.Checked
            DirectCast(gcNumber1.SideButtons(0), GrapeCity.Win.Editors.DropDownButton).IsDefaultBehavior = checkBox1.Checked
            DirectCast(gcComboBox1.SideButtons(0), GrapeCity.Win.Editors.DropDownButton).IsDefaultBehavior = checkBox1.Checked
            DirectCast(GcMaskedComboBox1.SideButtons(0), GrapeCity.Win.Editors.DropDownButton).IsDefaultBehavior = checkBox1.Checked
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
            ' NavigateOnWheelプロパティ
            gcDateTime1.DropDownCalendar.NavigateOnWheel = checkBox2.Checked
            gcDate1.DropDownCalendar.NavigateOnWheel = checkBox2.Checked
        End Sub
    End Class
End Namespace
