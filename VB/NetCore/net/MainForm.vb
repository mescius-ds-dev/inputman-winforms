Imports System.Collections
Imports System.Drawing
Imports System.Windows.Forms

Partial Public Class MainForm
    Inherits Form
    Public Sub New()
        InitializeComponent()

        AddHandler Me.Load, New EventHandler(AddressOf MainForm_Load)
        AddHandler treemenu.AfterSelect, New TreeViewEventHandler(AddressOf treemenu_AfterSelect)
        AddHandler treemenu.AfterCollapse, New TreeViewEventHandler(AddressOf treemenu_AfterCollapse)
        AddHandler firstView.LinkClicked, New LinkLabelLinkClickedEventHandler(AddressOf firstView_LinkClicked)
        AddHandler searchtext.TextChanged, New EventHandler(AddressOf searchtext_TextChanged)
        AddHandler searchlist.SelectedIndexChanged, New EventHandler(AddressOf searchlist_SelectedIndexChanged)
        AddHandler myTabControl1.SelectedIndexChanged, New EventHandler(AddressOf myTabControl1_SelectedIndexChanged)

        ' VS2010のデザイナで入れ子のFixedPanelプロパティを設定すると
        ' デザイナを開くたびにサイズが大きくなるため、コードから設定して回避
        splitContainer3.FixedPanel = FixedPanel.Panel2
        ' デザイナを開くたびに位置が変わるため、コードから設定して回避
        grapecity_logo.Location = New Point(12, 27)
        copyright.Location = New Point(173, 35)

        ' ちらつき防止
        ' ヘッダ
        pictureBox1.Controls.Add(product_logo)
        pictureBox1.Controls.Add(product_title)
        pictureBox1.Controls.Add(firstView)

        ' フッタ
        pictureBox2.Controls.Add(grapecity_logo)
        pictureBox2.Controls.Add(copyright)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs)
        ' ファーストビューを開く
        Me.setMainPanel(New FirstViewPage())
    End Sub

    Private Sub treemenu_AfterSelect(sender As Object, e As TreeViewEventArgs)
        If e.Node.Parent Is Nothing Then
            Return
        End If

        Select Case e.Node.Parent.Text
            Case "コントロール一覧"
                Select Case e.Node.Text
                    Case "入力コントロール"
                        Me.setMainPanel(New InputManWin12_Demo._01_Controls.Controls())
                        Exit Select
                    Case "入力支援機能"
                        Me.setMainPanel(New InputManWin12_Demo._01_Controls.Components())
                        Exit Select
                    Case "継承コントロール"
                        Me.setMainPanel(New InputManWin12_Demo._01_Controls.CustomControls())
                        Exit Select
                    Case Else
                        Exit Select
                End Select
                Exit Select
            Case "タッチ機能"
                Select Case e.Node.Text
                    Case "タッチツールバー"
                        Me.setMainPanel(New InputManWin12_Demo._13_Touch.TouchToolBar())
                        Exit Select
                    Case "タッチキーボード"
                        Me.setMainPanel(New InputManWin12_Demo._13_Touch.TouchKeyboard())
                        Exit Select
                    Case "グリッパーの表示"
                        Me.setMainPanel(New InputManWin12_Demo._13_Touch.Gripper())
                        Exit Select
                    Case "ドロップダウンウィンドウの拡大表示"
                        Me.setMainPanel(New InputManWin12_Demo._13_Touch.DropDownScale())
                        Exit Select
                    Case "コンテキストメニューの拡大表示"
                        Me.setMainPanel(New InputManWin12_Demo._13_Touch.ContextMenuScale())
                        Exit Select
                    Case Else
                        Exit Select
                End Select
            Case "書式による入力制限"
                Select Case e.Node.Text
                    Case "テキストコントロール"
                        Me.setMainPanel(New InputManWin12_Demo._02_Format.GcTextBox())
                        Exit Select
                    Case "キャラクタボックスコントロール"
                        Me.setMainPanel(New InputManWin12_Demo._02_Format.GcCharMask())
                        Exit Select
                    Case "マスクコントロール"
                        Me.setMainPanel(New InputManWin12_Demo._02_Format.GcMask())
                        Exit Select
                    Case "日付時刻コントロール"
                        Me.setMainPanel(New InputManWin12_Demo._02_Format.GcDateTime())
                        Exit Select
                    Case "日付コントロール"
                        Me.setMainPanel(New InputManWin12_Demo._02_Format.GcDate())
                        Exit Select
                    Case "時刻コントロール"
                        Me.setMainPanel(New InputManWin12_Demo._02_Format.GcTime())
                        Exit Select
                    Case "数値コントロール"
                        Me.setMainPanel(New InputManWin12_Demo._02_Format.GcNumber())
                        Exit Select
                    Case "タイムスパンコントロール"
                        Me.setMainPanel(New InputManWin12_Demo._02_Format.GcTimeSpan())
                        Exit Select
                    Case "コンボコントロール"
                        Me.setMainPanel(New InputManWin12_Demo._02_Format.GcComboBox())
                        Exit Select
                    Case "マスクコンボコントロール"
                        Me.setMainPanel(New InputManWin12_Demo._02_Format.GcMaskedComboBox())
                        Exit Select
                    Case Else
                        Exit Select
                End Select
                Exit Select
            Case "ソフトキーボードコンポーネント"
                Select Case e.Node.Text
                    Case "キーレイアウトと表示位置"
                        Me.setMainPanel(New InputManWin12_Demo._14_GcSoftKeyboard.KeyLayout())
                        Exit Select
                    Case "スタイルの変更"
                        Me.setMainPanel(New InputManWin12_Demo._14_GcSoftKeyboard.Appearance())
                        Exit Select
                End Select
                Exit Select
            Case "フォーカスの移動制御"
                Select Case e.Node.Text
                    Case "Enterキーや矢印キーでのフォーカス移動"
                        Me.setMainPanel(New InputManWin12_Demo._03_Focus.Enter())
                        Exit Select
                    Case "Tabキー押下時の動作"
                        Me.setMainPanel(New InputManWin12_Demo._03_Focus.Tab())
                        Exit Select
                    Case Else
                        Exit Select
                End Select
                Exit Select
            Case "自動入力による入力補助"
                Select Case e.Node.Text
                    Case "ふりがなの自動取得"
                        Me.setMainPanel(New InputManWin12_Demo._04_Input.Furigana())
                        Exit Select
                    Case "入力候補値の表示"
                        Me.setMainPanel(New InputManWin12_Demo._04_Input.RecommendedValue())
                        Exit Select
                    Case Else
                        Exit Select
                End Select
                Exit Select
            Case "住所検索機能"
                Select Case e.Node.Text
                    Case "郵便番号／市外局番からの住所検索"
                        Me.setMainPanel(New InputManWin12_Demo._12_Address.GcAddress())
                        Exit Select
                    Case "郵便番号入力用コントロール"
                        Me.setMainPanel(New InputManWin12_Demo._12_Address.GcPostal())
                        Exit Select
                    Case "住所入力用コントロール"
                        Me.setMainPanel(New InputManWin12_Demo._12_Address.GcAddressBox())
                        Exit Select
                    Case Else
                        Exit Select
                End Select
            Case "ショートカット機能の設定"
                Select Case e.Node.Text
                    Case "ショートカット動作の確認"
                        Me.setMainPanel(New InputManWin12_Demo._05_Shortcuts.Shortcuts())
                        Exit Select
                    Case "ショートカットキーの設定"
                        Me.setMainPanel(New InputManWin12_Demo._05_Shortcuts.SetShortcuts())
                        Exit Select
                    Case Else
                        Exit Select
                End Select
                Exit Select
            Case "表示機能"
                Select Case e.Node.Text
                    Case "コントロール無効時のスタイル"
                        Me.setMainPanel(New InputManWin12_Demo._06_Display.DisabledColor())
                        Exit Select
                    Case "省略文字の表示"
                        Me.setMainPanel(New InputManWin12_Demo._06_Display.Ellipsis())
                        Exit Select
                    Case "オーバーフローチップの表示"
                        Me.setMainPanel(New InputManWin12_Demo._06_Display.ShowOverflowTip())
                        Exit Select
                    Case "テキストの配置"
                        Me.setMainPanel(New InputManWin12_Demo._06_Display.Alignment())
                        Exit Select
                    Case "アクティブコントロールのスタイル"
                        Me.setMainPanel(New InputManWin12_Demo._06_Display.ActiveColor())
                        Exit Select
                    Case "読み取り専用コントロールのスタイル"
                        Me.setMainPanel(New InputManWin12_Demo._06_Display.ReadOnlyColor())
                        Exit Select
                    Case "フローティングラベルの表示"
                        Me.setMainPanel(New InputManWin12_Demo._06_Display.PlaceHolder())
                        Exit Select
                    Case Else
                        Exit Select
                End Select
                Exit Select
            Case "ドロップダウンによる入力補助"
                Select Case e.Node.Text
                    Case "ドロップダウンのカスタマイズ"
                        Me.setMainPanel(New InputManWin12_Demo._07_DropDown.DropDown())
                        Exit Select
                    Case "ドロップダウンカレンダー"
                        Me.setMainPanel(New InputManWin12_Demo._07_DropDown.DropDownCalendar())
                        Exit Select
                    Case "ドロップダウン日付時刻／カレンダーピッカー"
                        Me.setMainPanel(New InputManWin12_Demo._07_DropDown.DropDownDateTimePicker())
                        Exit Select
                    Case Else
                        Exit Select
                End Select
                Exit Select
            Case "コントロールに追加可能なボタン"
                Select Case e.Node.Text
                    Case "ドロップダウンボタン"
                        Me.setMainPanel(New InputManWin12_Demo._08_SideButton.DropDownButton())
                        Exit Select
                    Case "スピンボタン"
                        Me.setMainPanel(New InputManWin12_Demo._08_SideButton.SpinButton())
                        Exit Select
                    Case "サイドボタン"
                        Me.setMainPanel(New InputManWin12_Demo._08_SideButton.SideButton())
                        Exit Select
                    Case "シンボルボタン"
                        Me.setMainPanel(New InputManWin12_Demo._08_SideButton.SymbolButton())
                        Exit Select
                    Case "スピン操作"
                        Me.setMainPanel(New InputManWin12_Demo._08_SideButton.SpinBehavior())
                        Exit Select
                    Case Else
                        Exit Select
                End Select
                Exit Select
            Case "コンボコントロール"
                Select Case e.Node.Text
                    Case "マルチカラムによるリスト表示"
                        Me.setMainPanel(New InputManWin12_Demo._09_GcComboBox.ComboMultiColumns())
                        Exit Select
                    Case "オートコンプリートによる補完機能"
                        Me.setMainPanel(New InputManWin12_Demo._09_GcComboBox.AutoComplete())
                        Exit Select
                    Case "リストのフィルタと自動選択"
                        Me.setMainPanel(New InputManWin12_Demo._09_GcComboBox.AutoFilter())
                        Exit Select
                    Case "表示テキストのカスタマイズ"
                        Me.setMainPanel(New InputManWin12_Demo._09_GcComboBox.TextFormat())
                        Exit Select
                    Case Else
                        Exit Select
                End Select
                Exit Select
            Case "リストコントロール"
                Select Case e.Node.Text
                    Case "マルチカラムによるリスト表示"
                        Me.setMainPanel(New InputManWin12_Demo._10_GcListBox.ListMultiColumns())
                        Exit Select
                    Case Else
                        Exit Select
                End Select
                Exit Select
            Case "入力値の検証"
                Select Case e.Node.Text
                    Case "入力範囲の設定"
                        Me.setMainPanel(New InputManWin12_Demo._11_Validate.MinMax())
                        Exit Select
                    Case "イベントを利用した検証"
                        Me.setMainPanel(New InputManWin12_Demo._11_Validate.InvalidInput())
                        Exit Select
                    Case "検証エラーの通知"
                        Me.setMainPanel(New InputManWin12_Demo._11_Validate.Validator())
                        Exit Select
                    Case Else
                        Exit Select
                End Select
            Case "実用例"
                Select Case e.Node.Text
                    Case "社員情報入力"
                        Me.setMainPanel(New InputManWin12_Demo._15_Sample.RegistEmployee())
                        Exit Select
                End Select
                Exit Select
        End Select
    End Sub

    Private Sub treemenu_AfterCollapse(sender As Object, e As TreeViewEventArgs)
        treemenu.SelectedNode = Nothing
    End Sub

#Region "ページ移動処理"
    Private Sub setMainPanel(ucontrol As FirstViewPage)
        ucontrol.Dock = DockStyle.Fill
        Me.splitContainer1.Panel2.Controls.Add(ucontrol)
        If Me.splitContainer1.Panel2.Controls.Count > 1 Then
            Me.splitContainer1.Panel2.Controls.RemoveAt(0)
        End If
    End Sub
    Private Sub setMainPanel(ucontrol As DemoBase)
        ucontrol.Dock = DockStyle.Fill
        Me.splitContainer1.Panel2.Controls.Add(ucontrol)
        If Me.splitContainer1.Panel2.Controls.Count > 1 Then
            Me.splitContainer1.Panel2.Controls.RemoveAt(0)
        End If
    End Sub
    Private Sub setMainPanel(ucontrol As DemoBase_settings)
        ucontrol.Dock = DockStyle.Fill
        Me.splitContainer1.Panel2.Controls.Add(ucontrol)
        If Me.splitContainer1.Panel2.Controls.Count > 1 Then
            Me.splitContainer1.Panel2.Controls.RemoveAt(0)
        End If
    End Sub
#End Region

#Region "リンク処理"
    Private Sub firstView_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        ' ファーストビューに戻る
        Me.setMainPanel(New FirstViewPage())
        treemenu.SelectedNode = Nothing
        treemenu.CollapseAll()
    End Sub
#End Region

#Region "検索機能"
    ' 検索ノードのコレクション               
    Private myNode As New ArrayList()

    Private Sub searchtext_TextChanged(sender As Object, e As EventArgs)
        ' 検索結果(searchlist)をクリア
        searchlist.Items.Clear()
        myNode.Clear()

        If searchtext.Text = "" Then
            Return
        End If

        ' ツリーコントロールのノードを取得
        For Each node As TreeNode In GetAllNodes(treemenu.Nodes)
            If node.Parent IsNot Nothing Then
                Dim s As String = node.Text
                If node.Tag IsNot Nothing Then
                    s += node.Tag.ToString()
                End If

                ' 検索ワードを含むノードのみ抽出
                If s.Contains(searchtext.Text) Then
                    myNode.Add(node)
                    searchlist.Items.Add(node.Text)
                End If
            End If
        Next
    End Sub

    Private Function GetAllNodes(Nodes As TreeNodeCollection) As ArrayList
        Dim Ar As New ArrayList()
        ' ツリーコントロールのノードを取得
        For Each Node As TreeNode In Nodes
            Ar.Add(Node)
            If Node.GetNodeCount(False) > 0 Then
                Ar.AddRange(GetAllNodes(Node.Nodes))
            End If
        Next
        Return Ar
    End Function

    Private Sub searchlist_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' リストボックスで選択されたページを表示
        treemenu.SelectedNode = DirectCast(myNode(searchlist.SelectedIndex), TreeNode)
    End Sub

    Private Sub myTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' ツリービューにフォーカスを設定して選択状態にする
        If myTabControl1.SelectedIndex = 0 Then
            treemenu.[Select]()
        End If
    End Sub
#End Region

End Class

' ツリービューのシングルクリックでの開閉
Class MyTreeView
    Inherits TreeView
    Public Sub New()
        MyBase.New()
        AddHandler NodeMouseClick, New TreeNodeMouseClickEventHandler(AddressOf MyTreeView_NodeMouseClick)
    End Sub

    Private Sub MyTreeView_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs)
        If e.Node IsNot Nothing Then
            If HitTest(e.Location).Location = TreeViewHitTestLocations.Label OrElse HitTest(e.Location).Location = TreeViewHitTestLocations.Image Then
                e.Node.Toggle()
            End If
        End If
    End Sub
End Class

' タブコントロール内のちらつきを抑える
Class MyTabControl
    Inherits TabControl
    ' リサイズ途中のちらつきを抑える処理
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
End Class
