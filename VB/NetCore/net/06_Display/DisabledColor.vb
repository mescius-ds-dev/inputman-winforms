Imports System.Data
Imports System.Windows.Forms

Namespace _06_Display
    Partial Public Class DisabledColor
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            ' ***** 初期値
            gcColorPicker1.SelectedIndex = gcColorPicker1.FindStringExact(gcTextBox1.BackColor.Name, -1, 0)

            ' xmlファイルからデータ取得(GcComboBox)
            Dim filePath As System.String = Application.StartupPath
            Me.dataSet1.ReadXml(filePath & "\Resources\prefecture.xml")

            Dim dv1 As New DataView(dataSet1.Tables(0))
            gcComboBox1.DataSource = dv1
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

            ' 選択不可項目の設定（GcComboBox）
            For i As Integer = 1 To gcComboBox1.Items.Count - 1 Step 2
                gcComboBox1.Items(i).Enabled = False
            Next

            ' 選択不可項目の設定（GcMaskedComboBox）
            For i As Integer = 1 To GcMaskedComboBox1.Items.Count - 1 Step 2
                GcMaskedComboBox1.Items(i).Enabled = False
            Next


            Dim dv2 As New DataView(dataSet1.Tables(0))
            gcListBox1.DataSource = dv2
            gcListBox1.SelectedIndex = -1

            For i As Integer = 1 To gcListBox1.Columns.Count - 1
                gcListBox1.Columns(i).AutoWidth = True
            Next

            ' 選択不可項目の設定
            For i As Integer = 1 To gcListBox1.Items.Count - 1 Step 2
                gcListBox1.Items(i).Enabled = False
            Next
        End Sub

        Private Sub gcColorPicker1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcColorPicker1.SelectedIndexChanged
            ' ForeColorプロパティ
            gcTextBox1.ForeColor = gcColorPicker1.SelectedColor
            gcMask1.ForeColor = gcColorPicker1.SelectedColor
            gcCharMask1.ForeColor = gcColorPicker1.SelectedColor
            gcDateTime1.ForeColor = gcColorPicker1.SelectedColor
            gcDate1.ForeColor = gcColorPicker1.SelectedColor
            gcTime1.ForeColor = gcColorPicker1.SelectedColor
            gcTimeSpan1.ForeColor = gcColorPicker1.SelectedColor
            gcNumber1.ForeColor = gcColorPicker1.SelectedColor
            gcComboBox1.ForeColor = gcColorPicker1.SelectedColor
            GcMaskedComboBox1.ForeColor = gcColorPicker1.SelectedColor
            gcListBox1.ForeColor = gcColorPicker1.SelectedColor
        End Sub

        Private Sub gcColorPicker2_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcColorPicker2.SelectedValueChanged
            ' BackColorプロパティ
            gcTextBox1.BackColor = gcColorPicker2.SelectedColor
            gcMask1.BackColor = gcColorPicker2.SelectedColor
            gcCharMask1.BackColor = gcColorPicker2.SelectedColor
            gcDateTime1.BackColor = gcColorPicker2.SelectedColor
            gcDate1.BackColor = gcColorPicker2.SelectedColor
            gcTime1.BackColor = gcColorPicker2.SelectedColor
            gcTimeSpan1.BackColor = gcColorPicker2.SelectedColor
            gcNumber1.BackColor = gcColorPicker2.SelectedColor
            gcComboBox1.BackColor = gcColorPicker2.SelectedColor
            GcMaskedComboBox1.BackColor = gcColorPicker2.SelectedColor
            gcListBox1.BackColor = gcColorPicker2.SelectedColor
        End Sub

        Private Sub gcColorPicker3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcColorPicker3.SelectedIndexChanged
            ' DisabledForeColorプロパティ
            gcTextBox1.DisabledForeColor = gcColorPicker3.SelectedColor
            gcMask1.DisabledForeColor = gcColorPicker3.SelectedColor
            gcCharMask1.DisabledForeColor = gcColorPicker3.SelectedColor
            gcDateTime1.DisabledForeColor = gcColorPicker3.SelectedColor
            gcDate1.DisabledForeColor = gcColorPicker3.SelectedColor
            gcTime1.DisabledForeColor = gcColorPicker3.SelectedColor
            gcTimeSpan1.DisabledForeColor = gcColorPicker3.SelectedColor
            gcNumber1.DisabledForeColor = gcColorPicker3.SelectedColor
            gcComboBox1.DisabledForeColor = gcColorPicker3.SelectedColor
            GcMaskedComboBox1.DisabledForeColor = gcColorPicker3.SelectedColor
        End Sub

        Private Sub gcColorPicker4_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcColorPicker4.SelectedIndexChanged
            ' DisabledBackColorプロパティ
            gcTextBox1.DisabledBackColor = gcColorPicker4.SelectedColor
            gcMask1.DisabledBackColor = gcColorPicker4.SelectedColor
            gcCharMask1.DisabledBackColor = gcColorPicker4.SelectedColor
            gcDateTime1.DisabledBackColor = gcColorPicker4.SelectedColor
            gcDate1.DisabledBackColor = gcColorPicker4.SelectedColor
            gcTime1.DisabledBackColor = gcColorPicker4.SelectedColor
            gcTimeSpan1.DisabledBackColor = gcColorPicker4.SelectedColor
            gcNumber1.DisabledBackColor = gcColorPicker4.SelectedColor
            gcComboBox1.DisabledBackColor = gcColorPicker4.SelectedColor
            GcMaskedComboBox1.DisabledBackColor = gcColorPicker4.SelectedColor
        End Sub

        Private Sub gcColorPicker5_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcColorPicker5.SelectedIndexChanged
            ' ListDisabledItemStyle.ForeColorプロパティ
            gcComboBox1.ListDisabledItemStyle.ForeColor = gcColorPicker5.SelectedColor
            GcMaskedComboBox1.ListDisabledItemStyle.ForeColor = gcColorPicker5.SelectedColor
            ' DisabledItemStyle.ForeColorプロパティ
            gcListBox1.DisabledItemStyle.ForeColor = gcColorPicker5.SelectedColor
        End Sub

        Private Sub gcColorPicker6_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcColorPicker6.SelectedIndexChanged
            ' ListDisabledItemStyle.BackColorプロパティ
            gcComboBox1.ListDisabledItemStyle.BackColor = gcColorPicker6.SelectedColor
            GcMaskedComboBox1.ListDisabledItemStyle.BackColor = gcColorPicker6.SelectedColor
            ' DisabledItemStyle.BackColorプロパティ
            gcListBox1.DisabledItemStyle.BackColor = gcColorPicker6.SelectedColor
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            ' Enabledプロパティ
            gcTextBox1.Enabled = Not checkBox1.Checked
            gcMask1.Enabled = Not checkBox1.Checked
            gcCharMask1.Enabled = Not checkBox1.Checked
            gcDateTime1.Enabled = Not checkBox1.Checked
            gcDate1.Enabled = Not checkBox1.Checked
            gcTime1.Enabled = Not checkBox1.Checked
            gcTimeSpan1.Enabled = Not checkBox1.Checked
            gcNumber1.Enabled = Not checkBox1.Checked
            gcComboBox1.Enabled = Not checkBox1.Checked
            GcMaskedComboBox1.Enabled = Not checkBox1.Checked
            gcListBox1.Enabled = Not checkBox1.Checked
        End Sub
    End Class
End Namespace
