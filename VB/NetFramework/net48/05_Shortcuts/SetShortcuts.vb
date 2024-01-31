Imports System.Windows.Forms
Imports GrapeCity.Win.Editors
Imports System.Collections.Generic
Imports System.Data

Namespace _05_Shortcuts
    Partial Public Class SetShortcuts
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            ' xmlファイルからショートカット機能一覧取得
            Dim filePath As System.String = Application.StartupPath
            Me.dataSet1.ReadXml(filePath & "\Resources\shortcuts.xml")

            ' 設定されているショートカットをリストに表示
            getShortcutList(gcShortcut1.GetShortcuts(gcTextBox1))

            ' ***** 初期値
            gcComboBox2.SelectedIndex = 0
            gcListBox1.SelectedIndex = 0

            ' xmlファイルからデータ取得(GcComboBox)
            Me.dataSet2.ReadXml(filePath & "\Resources\prefecture.xml")
            gcComboBox1.DataSource = dataSet2.Tables(0)
            gcComboBox1.SelectedIndex = -1

            For i As Integer = 1 To gcComboBox1.ListColumns.Count - 1
                gcComboBox1.ListColumns(i).AutoWidth = True
            Next

            ' xmlファイルからデータ取得(GcMaskedComboBox)
            Me.DataSet3.ReadXml(filePath & "\Resources\pref.xml")
            GcMaskedComboBox1.DataSource = DataSet3.Tables(0)
            GcMaskedComboBox1.SelectedIndex = -1

            For i As Integer = 1 To GcMaskedComboBox1.ListColumns.Count - 1
                GcMaskedComboBox1.ListColumns(i).AutoWidth = True
            Next
        End Sub

        Private Sub button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click, button2.Click
            ' キー取得
            Dim selectedKey As New Keys()
            For Each keyval As Keys In [Enum].GetValues(GetType(Keys))
                If keyval.ToString() = gcComboBox3.Text Then
                    selectedKey = keyval
                End If
            Next

            Dim ctrl As Control = Nothing
            Select Case gcComboBox2.SelectedIndex
                Case 0
                    ' テキストコントロール
                    ctrl = gcTextBox1
                    Exit Select
                Case 1
                    ' マスクコントロール
                    ctrl = gcMask1
                    Exit Select
                Case 2
                    ' キャラクタボックスコントロール
                    ctrl = gcCharMask1
                    Exit Select
                Case 3
                    ' 日付時刻コントロール
                    ctrl = gcDateTime1
                    Exit Select
                Case 4
                    ' 日付コントロール
                    ctrl = gcDate1
                    Exit Select
                Case 5
                    ' 時刻コントロール
                    ctrl = gcTime1
                    Exit Select
                Case 6
                    ' タイムスパンコントロール
                    ctrl = gcTimeSpan1
                    Exit Select
                Case 7
                    ' 数値コントロール
                    ctrl = gcNumber1
                    Exit Select
                Case 8
                    ' コンボコントロール
                    ctrl = gcComboBox1
                    Exit Select
                Case 9
                    ' マスクコンボコントロール
                    ctrl = GcMaskedComboBox1
                    Exit Select
                Case Else
                    Exit Select
            End Select

            If sender Is button1 Then
                ' ショートカットキーの追加
                Try
                    gcShortcut1.GetShortcuts(ctrl).Add(selectedKey, gcShortcut1, gcComboBox4.Text)
                Catch
                    gcShortcut1.GetShortcuts(ctrl).Add(selectedKey, ctrl, gcComboBox4.Text)
                End Try
                ' 追加したショートカットをリストに追加してフォーカスセット
                getShortcutList(gcShortcut1.GetShortcuts(ctrl))
                gcListBox1.SelectedIndex = gcListBox1.FindStringExact(gcComboBox3.Text, -1, 0)
                button1.Enabled = False
                button2.Enabled = True
            Else
                ' ショートカットキーの削除
                gcListBox1.SelectedIndex = -1
                gcShortcut1.GetShortcuts(ctrl).Remove(selectedKey)
                ' 削除したショートカットをリストからも削除
                gcListBox1.Items.RemoveAt(gcListBox1.FindStringExact(gcComboBox3.Text, -1, 0))
                If gcListBox1.Items.Count = 0 Then
                    button1.Enabled = True
                    button2.Enabled = False
                Else
                    gcListBox1.SelectedIndex = 0
                End If
            End If
        End Sub

        Private Sub getShortcutList(ByVal sc As ShortcutCollection)
            ' コントロールのショートカットを取得
            gcListBox1.Items.Clear()
            Dim skeys As ICollection(Of Keys) = sc.Keys
            For Each k As Keys In skeys
                gcListBox1.Items.Add(New ListItem(New String() {k.ToString(), ""}))
            Next
            Dim i As Int32 = 0
            Dim smethods As ICollection(Of MethodInvoker) = sc.Values
            For Each mi As MethodInvoker In smethods
                gcListBox1.Items(i).SubItems(1).Value = mi.Method.Name
                i += 1
            Next
        End Sub

        Private Sub gcListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcListBox1.SelectedIndexChanged
            If gcListBox1.SelectedItem IsNot Nothing Then
                gcComboBox3.SelectedIndex = gcComboBox3.FindStringExact(gcListBox1.SelectedItem.Text, -1, 0)
                gcComboBox4.SelectedIndex = gcComboBox4.FindStringExact(gcListBox1.SelectedValue.ToString(), -1, 0)
            End If
        End Sub

        Private Sub gcComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            ' 追加対象コントロールの変更
            Dim dv As New DataView(dataSet1.Tables(0))

            Select Case gcComboBox2.SelectedIndex
                Case 0
                    ' テキストコントロール
                    getShortcutList(gcShortcut1.GetShortcuts(gcTextBox1))
                    dv.RowFilter = "gcTextBoxflg = 'true'"
                    Exit Select
                Case 1
                    ' マスクコントロール
                    getShortcutList(gcShortcut1.GetShortcuts(gcMask1))
                    dv.RowFilter = "gcMaskflg = 'true'"
                    Exit Select
                Case 2
                    ' キャラクタボックスコントロール
                    getShortcutList(gcShortcut1.GetShortcuts(gcCharMask1))
                    dv.RowFilter = "gcCharMaskflg = 'true'"
                    Exit Select
                Case 3
                    ' 日付時刻コントロール
                    getShortcutList(gcShortcut1.GetShortcuts(gcDateTime1))
                    dv.RowFilter = "gcDateTimeflg = 'true'"
                    Exit Select
                Case 4
                    ' 日付コントロール
                    getShortcutList(gcShortcut1.GetShortcuts(gcDate1))
                    dv.RowFilter = "gcDateflg = 'true'"
                    Exit Select
                Case 5
                    ' 時刻コントロール
                    getShortcutList(gcShortcut1.GetShortcuts(gcTime1))
                    dv.RowFilter = "gcTimeflg = 'true'"
                    Exit Select
                Case 6
                    ' タイムスパンコントロール
                    getShortcutList(gcShortcut1.GetShortcuts(gcTimeSpan1))
                    dv.RowFilter = "gcTimeSpanflg = 'true'"
                    Exit Select
                Case 7
                    ' 数値コントロール
                    getShortcutList(gcShortcut1.GetShortcuts(gcNumber1))
                    dv.RowFilter = "gcNumberflg = 'true'"
                    Exit Select
                Case 8
                    ' コンボコントロール
                    getShortcutList(gcShortcut1.GetShortcuts(gcComboBox1))
                    dv.RowFilter = "gcComboBoxflg = 'true'"
                    Exit Select
                Case 9
                    ' マスクコンボコントロール
                    getShortcutList(gcShortcut1.GetShortcuts(GcMaskedComboBox1))
                    dv.RowFilter = "gcMaskedComboBoxflg = 'true'"
                    Exit Select
                Case Else
                    Exit Select
            End Select
            gcComboBox4.DataSource = dv

            gcComboBox4.ListColumns(0).AutoWidth = True
            gcComboBox4.ListColumns(1).AutoWidth = True
            gcComboBox4.ListColumns(2).Visible = False
            gcComboBox4.ListColumns(3).Visible = False
            gcComboBox4.ListColumns(4).Visible = False
            gcComboBox4.ListColumns(5).Visible = False
            gcComboBox4.ListColumns(6).Visible = False
            gcComboBox4.ListColumns(7).Visible = False
            gcComboBox4.ListColumns(8).Visible = False
            gcComboBox4.ListColumns(9).Visible = False

            gcListBox1.SelectedIndex = 0
        End Sub

        Private Sub gcComboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox3.SelectedIndexChanged
            ' 割り当てキーの変更
            gcListBox1.SelectedIndex = gcListBox1.FindStringExact(gcComboBox3.Text, -1, 0)

            If gcListBox1.FindStringExact(gcComboBox3.Text, -1, 0) = -1 Then
                button1.Enabled = True
                button2.Enabled = False
            Else
                button1.Enabled = False
                button2.Enabled = True
            End If
        End Sub
    End Class
End Namespace
