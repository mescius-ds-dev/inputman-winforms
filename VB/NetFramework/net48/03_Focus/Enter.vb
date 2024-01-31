Imports GrapeCity.Win.Editors
Imports System.Windows.Forms

Namespace _03_Focus
    Partial Public Class Enter
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            ' ***** 初期値
            checkBox1.Checked = True
            checkBox2.Checked = True
            gcComboBox2.SelectedIndex = 3
            checkBox3.Checked = True

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

        Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            ' Enterキー動作の設定
            gcShortcut1.GetShortcuts(gcTextBox1).Remove(Keys.[Return])
            gcShortcut1.GetShortcuts(gcMask1).Remove(Keys.[Return])
            gcShortcut1.GetShortcuts(gcCharMask1).Remove(Keys.[Return])
            gcShortcut1.GetShortcuts(gcDateTime1).Remove(Keys.[Return])
            gcShortcut1.GetShortcuts(gcDate1).Remove(Keys.[Return])
            gcShortcut1.GetShortcuts(gcTime1).Remove(Keys.[Return])
            gcShortcut1.GetShortcuts(gcTimeSpan1).Remove(Keys.[Return])
            gcShortcut1.GetShortcuts(gcNumber1).Remove(Keys.[Return])
            gcShortcut1.GetShortcuts(gcComboBox1).Remove(Keys.[Return])
            gcShortcut1.GetShortcuts(GcMaskedComboBox1).Remove(Keys.[Return])

            If checkBox1.Checked Then
                gcShortcut1.GetShortcuts(gcTextBox1).Add(Keys.[Return], gcShortcut1, "NextControl")
                gcShortcut1.GetShortcuts(gcMask1).Add(Keys.[Return], gcShortcut1, "NextControl")
                gcShortcut1.GetShortcuts(gcCharMask1).Add(Keys.[Return], gcShortcut1, "NextControl")
                gcShortcut1.GetShortcuts(gcDateTime1).Add(Keys.[Return], gcShortcut1, "NextControl")
                gcShortcut1.GetShortcuts(gcDate1).Add(Keys.[Return], gcShortcut1, "NextControl")
                gcShortcut1.GetShortcuts(gcTime1).Add(Keys.[Return], gcShortcut1, "NextControl")
                gcShortcut1.GetShortcuts(gcTimeSpan1).Add(Keys.[Return], gcShortcut1, "NextControl")
                gcShortcut1.GetShortcuts(gcNumber1).Add(Keys.[Return], gcShortcut1, "NextControl")
                gcShortcut1.GetShortcuts(gcComboBox1).Add(Keys.[Return], gcShortcut1, "NextControl")
                gcShortcut1.GetShortcuts(GcMaskedComboBox1).Add(Keys.[Return], gcShortcut1, "NextControl")
            End If
        End Sub

        Private Sub CheckBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
            ' ExitOnLastCharプロパティ
            gcTextBox1.ExitOnLastChar = checkBox2.Checked
            gcMask1.ExitOnLastChar = checkBox2.Checked
            gcCharMask1.ExitOnLastChar = checkBox2.Checked
            gcDateTime1.ExitOnLastChar = checkBox2.Checked
            gcDate1.ExitOnLastChar = checkBox2.Checked
            gcTime1.ExitOnLastChar = checkBox2.Checked
            gcTimeSpan1.ExitOnLastChar = checkBox2.Checked
            gcNumber1.ExitOnLastChar = checkBox2.Checked
            gcComboBox1.ExitOnLastChar = checkBox2.Checked
            GcMaskedComboBox1.ExitOnLastChar = checkBox2.Checked
        End Sub

        Private Sub GcComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            SetLeftRight()
        End Sub

        Private Sub SetLeftRight()
            ' ExitOnLeftRightKeyプロパティ
            gcTextBox1.ExitOnLeftRightKey = CType(gcComboBox2.SelectedIndex, ExitOnLeftRightKey)
            gcMask1.ExitOnLeftRightKey = CType(gcComboBox2.SelectedIndex, ExitOnLeftRightKey)
            gcCharMask1.ExitOnLeftRightKey = CType(gcComboBox2.SelectedIndex, ExitOnLeftRightKey)
            gcDateTime1.ExitOnLeftRightKey = CType(gcComboBox2.SelectedIndex, ExitOnLeftRightKey)
            gcDate1.ExitOnLeftRightKey = CType(gcComboBox2.SelectedIndex, ExitOnLeftRightKey)
            gcTime1.ExitOnLeftRightKey = CType(gcComboBox2.SelectedIndex, ExitOnLeftRightKey)
            gcTimeSpan1.ExitOnLeftRightKey = CType(gcComboBox2.SelectedIndex, ExitOnLeftRightKey)
            gcNumber1.ExitOnLeftRightKey = CType(gcComboBox2.SelectedIndex, ExitOnLeftRightKey)
            gcComboBox1.ExitOnLeftRightKey = CType(gcComboBox2.SelectedIndex, ExitOnLeftRightKey)
            GcMaskedComboBox1.ExitOnLeftRightKey = CType(gcComboBox2.SelectedIndex, ExitOnLeftRightKey)
        End Sub

        Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox3.CheckedChanged
            gcMask1.AutoMoveToNextField = checkBox3.Checked
            gcDateTime1.AutoMoveToNextField = checkBox3.Checked
            gcDate1.AutoMoveToNextField = checkBox3.Checked
            gcTime1.AutoMoveToNextField = checkBox3.Checked
            gcTimeSpan1.AutoMoveToNextField = checkBox3.Checked
            GcMaskedComboBox1.AutoMoveToNextField = checkBox3.Checked
        End Sub
    End Class
End Namespace
