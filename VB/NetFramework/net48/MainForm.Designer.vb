Partial Class MainForm
	''' <summary>
	''' 必要なデザイナ変数です。
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' 使用中のリソースをすべてクリーンアップします。
	''' </summary>
	''' <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows フォーム デザイナで生成されたコード"

	''' <summary>
	''' デザイナ サポートに必要なメソッドです。このメソッドの内容を
	''' コード エディタで変更しないでください。
	''' </summary>
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("入力コントロール")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("入力支援機能")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("継承コントロール")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("コントロール一覧", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("タッチツールバー")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("タッチキーボード")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("グリッパーの表示")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ドロップダウンウィンドウの拡大表示")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("コンテキストメニューの拡大表示")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("タッチ機能", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("テキストコントロール")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("キャラクタボックスコントロール")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("マスクコントロール")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("日付時刻コントロール")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("日付コントロール")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("時刻コントロール")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("数値コントロール")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("タイムスパンコントロール")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("コンボコントロール")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("マスクコンボコントロール")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("書式による入力制限", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12, TreeNode13, TreeNode14, TreeNode15, TreeNode16, TreeNode17, TreeNode18, TreeNode19, TreeNode20})
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("キーレイアウトと表示位置")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("スタイルの変更")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ソフトキーボードコンポーネント", New System.Windows.Forms.TreeNode() {TreeNode22, TreeNode23})
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Enterキーや矢印キーでのフォーカス移動")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tabキー押下時の動作")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("フォーカスの移動制御", New System.Windows.Forms.TreeNode() {TreeNode25, TreeNode26})
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ふりがなの自動取得")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("入力候補値の表示")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("自動入力による入力補助", New System.Windows.Forms.TreeNode() {TreeNode28, TreeNode29})
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("郵便番号／市外局番からの住所検索")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("郵便番号入力用コントロール")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("住所入力用コントロール")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("住所検索機能", New System.Windows.Forms.TreeNode() {TreeNode31, TreeNode32, TreeNode33})
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ショートカット動作の確認")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ショートカットキーの設定")
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ショートカット機能の設定", New System.Windows.Forms.TreeNode() {TreeNode35, TreeNode36})
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("コントロール無効時のスタイル")
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("アクティブコントロールのスタイル")
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("読み取り専用コントロールのスタイル")
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("省略文字の表示")
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("オーバーフローチップの表示")
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("テキストの配置")
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("表示機能", New System.Windows.Forms.TreeNode() {TreeNode38, TreeNode39, TreeNode40, TreeNode41, TreeNode42, TreeNode43})
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ドロップダウンのカスタマイズ")
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ドロップダウンカレンダー")
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ドロップダウン日付時刻ピッカー")
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ドロップダウンによる入力補助", New System.Windows.Forms.TreeNode() {TreeNode45, TreeNode46, TreeNode47})
        Dim TreeNode49 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ドロップダウンボタン")
        Dim TreeNode50 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("スピンボタン")
        Dim TreeNode51 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("サイドボタン")
        Dim TreeNode52 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("シンボルボタン")
        Dim TreeNode53 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("スピン操作")
        Dim TreeNode54 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("コントロールに追加可能なボタン", New System.Windows.Forms.TreeNode() {TreeNode49, TreeNode50, TreeNode51, TreeNode52, TreeNode53})
        Dim TreeNode55 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("マルチカラムによるリスト表示")
        Dim TreeNode56 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("オートコンプリートによる補完機能")
        Dim TreeNode57 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("リストのフィルタと自動選択")
        Dim TreeNode58 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("表示テキストのカスタマイズ")
        Dim TreeNode59 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("コンボコントロール", New System.Windows.Forms.TreeNode() {TreeNode55, TreeNode56, TreeNode57, TreeNode58})
        Dim TreeNode60 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("マルチカラムによるリスト表示")
        Dim TreeNode61 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("リストコントロール", New System.Windows.Forms.TreeNode() {TreeNode60})
        Dim TreeNode62 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("入力範囲の設定")
        Dim TreeNode63 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("イベントを利用した検証")
        Dim TreeNode64 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("検証エラーの通知")
        Dim TreeNode65 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("入力値の検証", New System.Windows.Forms.TreeNode() {TreeNode62, TreeNode63, TreeNode64})
        Dim TreeNode66 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("社員情報入力")
        Dim TreeNode67 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("実用例", New System.Windows.Forms.TreeNode() {TreeNode66})
        Me.splitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.product_logo = New System.Windows.Forms.PictureBox()
        Me.firstView = New System.Windows.Forms.LinkLabel()
        Me.product_title = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.splitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.menuheader = New System.Windows.Forms.PictureBox()
        Me.copyright = New System.Windows.Forms.Label()
        Me.grapecity_logo = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.myTabControl1 = New InputManWin12_Demo.MyTabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.treemenu = New InputManWin12_Demo.MyTreeView()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.label1 = New System.Windows.Forms.Label()
        Me.searchlist = New System.Windows.Forms.ListBox()
        Me.searchtext = New System.Windows.Forms.TextBox()
        CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer2.Panel1.SuspendLayout()
        Me.splitContainer2.Panel2.SuspendLayout()
        Me.splitContainer2.SuspendLayout()
        CType(Me.product_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer3.Panel1.SuspendLayout()
        Me.splitContainer3.Panel2.SuspendLayout()
        Me.splitContainer3.SuspendLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.panel1.SuspendLayout()
        CType(Me.menuheader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grapecity_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.myTabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitContainer2
        '
        Me.splitContainer2.BackColor = System.Drawing.Color.Transparent
        Me.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitContainer2.IsSplitterFixed = True
        Me.splitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.splitContainer2.Name = "splitContainer2"
        Me.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer2.Panel1
        '
        Me.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.splitContainer2.Panel1.Controls.Add(Me.product_logo)
        Me.splitContainer2.Panel1.Controls.Add(Me.firstView)
        Me.splitContainer2.Panel1.Controls.Add(Me.product_title)
        Me.splitContainer2.Panel1.Controls.Add(Me.pictureBox1)
        '
        'splitContainer2.Panel2
        '
        Me.splitContainer2.Panel2.Controls.Add(Me.splitContainer3)
        Me.splitContainer2.Size = New System.Drawing.Size(1008, 729)
        Me.splitContainer2.SplitterDistance = 80
        Me.splitContainer2.SplitterWidth = 6
        Me.splitContainer2.TabIndex = 0
        '
        'product_logo
        '
        Me.product_logo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.product_logo.BackgroundImage = Global.InputManWin12_Demo.Resources.product_logo
        Me.product_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.product_logo.Location = New System.Drawing.Point(12, 4)
        Me.product_logo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.product_logo.Name = "product_logo"
        Me.product_logo.Size = New System.Drawing.Size(288, 74)
        Me.product_logo.TabIndex = 8
        Me.product_logo.TabStop = False
        '
        'firstView
        '
        Me.firstView.ActiveLinkColor = System.Drawing.Color.White
        Me.firstView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.firstView.AutoSize = True
        Me.firstView.DisabledLinkColor = System.Drawing.Color.White
        Me.firstView.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.firstView.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.firstView.LinkColor = System.Drawing.Color.White
        Me.firstView.Location = New System.Drawing.Point(659, 48)
        Me.firstView.Name = "firstView"
        Me.firstView.Size = New System.Drawing.Size(165, 25)
        Me.firstView.TabIndex = 1
        Me.firstView.TabStop = True
        Me.firstView.Text = "イントロダクション"
        Me.firstView.VisitedLinkColor = System.Drawing.Color.White
        '
        'product_title
        '
        Me.product_title.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.product_title.AutoSize = True
        Me.product_title.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.product_title.ForeColor = System.Drawing.Color.White
        Me.product_title.Location = New System.Drawing.Point(309, 45)
        Me.product_title.Name = "product_title"
        Me.product_title.Size = New System.Drawing.Size(219, 30)
        Me.product_title.TabIndex = 0
        Me.product_title.Text = "for Windows Forms"
        '
        'pictureBox1
        '
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(1008, 80)
        Me.pictureBox1.TabIndex = 9
        Me.pictureBox1.TabStop = False
        '
        'splitContainer3
        '
        Me.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer3.IsSplitterFixed = True
        Me.splitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.splitContainer3.Name = "splitContainer3"
        Me.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer3.Panel1
        '
        Me.splitContainer3.Panel1.Controls.Add(Me.splitContainer1)
        Me.splitContainer3.Panel1.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        '
        'splitContainer3.Panel2
        '
        Me.splitContainer3.Panel2.BackgroundImage = Global.InputManWin12_Demo.Resources.fotter
        Me.splitContainer3.Panel2.Controls.Add(Me.copyright)
        Me.splitContainer3.Panel2.Controls.Add(Me.grapecity_logo)
        Me.splitContainer3.Panel2.Controls.Add(Me.pictureBox2)
        Me.splitContainer3.Size = New System.Drawing.Size(1008, 643)
        Me.splitContainer3.SplitterDistance = 553
        Me.splitContainer3.SplitterWidth = 6
        Me.splitContainer3.TabIndex = 0
        '
        'splitContainer1
        '
        Me.splitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitContainer1.IsSplitterFixed = True
        Me.splitContainer1.Location = New System.Drawing.Point(7, 0)
        Me.splitContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.splitContainer1.Panel1.Controls.Add(Me.panel1)
        Me.splitContainer1.Panel1.Controls.Add(Me.menuheader)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.splitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.splitContainer1.Size = New System.Drawing.Size(1001, 553)
        Me.splitContainer1.SplitterDistance = 253
        Me.splitContainer1.SplitterWidth = 1
        Me.splitContainer1.TabIndex = 0
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.panel1.Controls.Add(Me.myTabControl1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 38)
        Me.panel1.Name = "panel1"
        Me.panel1.Padding = New System.Windows.Forms.Padding(7, 7, 7, 5)
        Me.panel1.Size = New System.Drawing.Size(253, 515)
        Me.panel1.TabIndex = 0
        '
        'menuheader
        '
        Me.menuheader.BackgroundImage = CType(resources.GetObject("menuheader.BackgroundImage"), System.Drawing.Image)
        Me.menuheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.menuheader.Location = New System.Drawing.Point(0, 0)
        Me.menuheader.Name = "menuheader"
        Me.menuheader.Size = New System.Drawing.Size(253, 38)
        Me.menuheader.TabIndex = 1
        Me.menuheader.TabStop = False
        '
        'copyright
        '
        Me.copyright.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.copyright.AutoSize = True
        Me.copyright.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.copyright.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.copyright.Location = New System.Drawing.Point(173, -83)
        Me.copyright.Name = "copyright"
        Me.copyright.Size = New System.Drawing.Size(277, 21)
        Me.copyright.TabIndex = 0
        Me.copyright.Text = "©️ MESCIUS inc. All rights reserved."
        '
        'grapecity_logo
        '
        Me.grapecity_logo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grapecity_logo.BackgroundImage = CType(resources.GetObject("grapecity_logo.BackgroundImage"), System.Drawing.Image)
        Me.grapecity_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grapecity_logo.Location = New System.Drawing.Point(12, -89)
        Me.grapecity_logo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grapecity_logo.Name = "grapecity_logo"
        Me.grapecity_logo.Size = New System.Drawing.Size(155, 29)
        Me.grapecity_logo.TabIndex = 6
        Me.grapecity_logo.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(1008, 84)
        Me.pictureBox2.TabIndex = 9
        Me.pictureBox2.TabStop = False
        '
        'myTabControl1
        '
        Me.myTabControl1.Controls.Add(Me.tabPage1)
        Me.myTabControl1.Controls.Add(Me.tabPage2)
        Me.myTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.myTabControl1.Location = New System.Drawing.Point(7, 7)
        Me.myTabControl1.Multiline = True
        Me.myTabControl1.Name = "myTabControl1"
        Me.myTabControl1.SelectedIndex = 0
        Me.myTabControl1.Size = New System.Drawing.Size(239, 503)
        Me.myTabControl1.TabIndex = 0
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.treemenu)
        Me.tabPage1.Location = New System.Drawing.Point(4, 32)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Size = New System.Drawing.Size(231, 467)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "コンテンツ一覧"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'treemenu
        '
        Me.treemenu.BackColor = System.Drawing.Color.White
        Me.treemenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.treemenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treemenu.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.treemenu.ForeColor = System.Drawing.Color.Black
        Me.treemenu.HideSelection = False
        Me.treemenu.Indent = 15
        Me.treemenu.ItemHeight = 25
        Me.treemenu.Location = New System.Drawing.Point(0, 0)
        Me.treemenu.Name = "treemenu"
        TreeNode1.Name = "ノード1"
        TreeNode1.Tag = "テキスト マスク 日付 リスト コンボ マスクコンボ タイムスパン 時刻"
        TreeNode1.Text = "入力コントロール"
        TreeNode2.Name = "ノード1"
        TreeNode2.Tag = "検証 ソフトキーボード 住所検索 IME 汎用検証 日付時刻検証 日付検証 時刻検証 数値検証 フィールドスタイラー"
        TreeNode2.Text = "入力支援機能"
        TreeNode3.Name = "ノード1"
        TreeNode3.Text = "継承コントロール"
        TreeNode4.Name = "ノード0"
        TreeNode4.Tag = ""
        TreeNode4.Text = "コントロール一覧"
        TreeNode5.Name = "ノード3"
        TreeNode5.Tag = "タッチ タッチ機能"
        TreeNode5.Text = "タッチツールバー"
        TreeNode6.Name = "ノード4"
        TreeNode6.Tag = "タッチ タッチ機能"
        TreeNode6.Text = "タッチキーボード"
        TreeNode7.Name = "ノード5"
        TreeNode7.Tag = "タッチ タッチ機能"
        TreeNode7.Text = "グリッパーの表示"
        TreeNode8.Name = "ノード6"
        TreeNode8.Tag = "タッチ タッチ機能"
        TreeNode8.Text = "ドロップダウンウィンドウの拡大表示"
        TreeNode9.Name = "ノード7"
        TreeNode9.Tag = "タッチ タッチ機能"
        TreeNode9.Text = "コンテキストメニューの拡大表示"
        TreeNode10.Name = "ノード1"
        TreeNode10.Text = "タッチ機能"
        TreeNode11.Name = "ノード1"
        TreeNode11.Tag = "書式 文字種"
        TreeNode11.Text = "テキストコントロール"
        TreeNode12.Name = "ノード1"
        TreeNode12.Tag = "書式 文字種"
        TreeNode12.Text = "キャラクタボックスコントロール"
        TreeNode13.Name = "ノード1"
        TreeNode13.Tag = "書式"
        TreeNode13.Text = "マスクコントロール"
        TreeNode14.Name = "ノード1"
        TreeNode14.Tag = "書式 和暦"
        TreeNode14.Text = "日付時刻コントロール"
        TreeNode15.Name = "ノード1"
        TreeNode15.Tag = "書式 和暦"
        TreeNode15.Text = "日付コントロール"
        TreeNode16.Name = "ノード1"
        TreeNode16.Tag = "書式"
        TreeNode16.Text = "時刻コントロール"
        TreeNode17.Name = "ノード1"
        TreeNode17.Tag = "書式"
        TreeNode17.Text = "数値コントロール"
        TreeNode18.Name = "ノード1"
        TreeNode18.Tag = "書式"
        TreeNode18.Text = "タイムスパンコントロール"
        TreeNode19.Name = "ノード1"
        TreeNode19.Tag = "書式"
        TreeNode19.Text = "コンボコントロール"
        TreeNode20.Name = "ノード1"
        TreeNode20.Tag = "書式"
        TreeNode20.Text = "マスクコンボコントロール"
        TreeNode21.Name = "ノード0"
        TreeNode21.Text = "書式による入力制限"
        TreeNode22.Name = "ノード1"
        TreeNode22.Tag = "ソフトキーボード"
        TreeNode22.Text = "キーレイアウトと表示位置"
        TreeNode23.Name = "ノード2"
        TreeNode23.Tag = "ソフトキーボード"
        TreeNode23.Text = "スタイルの変更"
        TreeNode24.Name = "ノード0"
        TreeNode24.Text = "ソフトキーボードコンポーネント"
        TreeNode25.Name = "ノード1"
        TreeNode25.Tag = "フォーカス"
        TreeNode25.Text = "Enterキーや矢印キーでのフォーカス移動"
        TreeNode26.Name = "ノード1"
        TreeNode26.Tag = "フォーカス移動"
        TreeNode26.Text = "Tabキー押下時の動作"
        TreeNode27.Name = "ノード0"
        TreeNode27.Text = "フォーカスの移動制御"
        TreeNode28.Name = "ノード1"
        TreeNode28.Text = "ふりがなの自動取得"
        TreeNode29.Name = "ノード1"
        TreeNode29.Text = "入力候補値の表示"
        TreeNode30.Name = "ノード0"
        TreeNode30.Text = "自動入力による入力補助"
        TreeNode31.Name = "ノード1"
        TreeNode31.Text = "郵便番号／市外局番からの住所検索"
        TreeNode32.Name = "ノード1"
        TreeNode32.Tag = "住所 住所検索"
        TreeNode32.Text = "郵便番号入力用コントロール"
        TreeNode33.Name = "ノード2"
        TreeNode33.Tag = "住所検索"
        TreeNode33.Text = "住所入力用コントロール"
        TreeNode34.Name = "ノード0"
        TreeNode34.Text = "住所検索機能"
        TreeNode35.Name = "ノード1"
        TreeNode35.Text = "ショートカット動作の確認"
        TreeNode36.Name = "ノード1"
        TreeNode36.Text = "ショートカットキーの設定"
        TreeNode37.Name = "ノード0"
        TreeNode37.Text = "ショートカット機能の設定"
        TreeNode38.Name = "ノード1"
        TreeNode38.Text = "コントロール無効時のスタイル"
        TreeNode39.Name = "ノード1"
        TreeNode39.Text = "アクティブコントロールのスタイル"
        TreeNode40.Name = "ノード1"
        TreeNode40.Text = "読み取り専用コントロールのスタイル"
        TreeNode41.Name = "ノード1"
        TreeNode41.Text = "省略文字の表示"
        TreeNode42.Name = "ノード1"
        TreeNode42.Text = "オーバーフローチップの表示"
        TreeNode43.Name = "ノード1"
        TreeNode43.Text = "テキストの配置"
        TreeNode44.Name = "ノード0"
        TreeNode44.Text = "表示機能"
        TreeNode45.Name = "ノード1"
        TreeNode45.Text = "ドロップダウンのカスタマイズ"
        TreeNode46.Name = "ノード1"
        TreeNode46.Text = "ドロップダウンカレンダー"
        TreeNode47.Name = "ノード1"
        TreeNode47.Text = "ドロップダウン日付時刻ピッカー"
        TreeNode48.Name = "ノード0"
        TreeNode48.Text = "ドロップダウンによる入力補助"
        TreeNode49.Name = "ノード1"
        TreeNode49.Tag = "サイドボタン"
        TreeNode49.Text = "ドロップダウンボタン"
        TreeNode50.Name = "ノード1"
        TreeNode50.Tag = "サイドボタン"
        TreeNode50.Text = "スピンボタン"
        TreeNode51.Name = "ノード1"
        TreeNode51.Text = "サイドボタン"
        TreeNode52.Name = "ノード1"
        TreeNode52.Tag = "サイドボタン"
        TreeNode52.Text = "シンボルボタン"
        TreeNode53.Name = "ノード0"
        TreeNode53.Tag = "サイドボタン"
        TreeNode53.Text = "スピン操作"
        TreeNode54.Name = "ノード0"
        TreeNode54.Text = "コントロールに追加可能なボタン"
        TreeNode55.Name = "ノード1"
        TreeNode55.Tag = "コンボ"
        TreeNode55.Text = "マルチカラムによるリスト表示"
        TreeNode56.Name = "ノード1"
        TreeNode56.Tag = "コンボ"
        TreeNode56.Text = "オートコンプリートによる補完機能"
        TreeNode57.Name = "ノード1"
        TreeNode57.Tag = "コンボ"
        TreeNode57.Text = "リストのフィルタと自動選択"
        TreeNode58.Name = "ノード1"
        TreeNode58.Text = "表示テキストのカスタマイズ"
        TreeNode59.Name = "ノード0"
        TreeNode59.Text = "コンボコントロール"
        TreeNode60.Name = "ノード1"
        TreeNode60.Text = "マルチカラムによるリスト表示"
        TreeNode61.Name = "ノード0"
        TreeNode61.Text = "リストコントロール"
        TreeNode62.Name = "ノード1"
        TreeNode62.Tag = "検証"
        TreeNode62.Text = "入力範囲の設定"
        TreeNode63.Name = "ノード1"
        TreeNode63.Text = "イベントを利用した検証"
        TreeNode64.Name = "ノード1"
        TreeNode64.Text = "検証エラーの通知"
        TreeNode65.Name = "ノード0"
        TreeNode65.Text = "入力値の検証"
        TreeNode66.Name = "ノード1"
        TreeNode66.Text = "社員情報入力"
        TreeNode67.Name = "ノード0"
        TreeNode67.Text = "実用例"
        Me.treemenu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode10, TreeNode21, TreeNode24, TreeNode27, TreeNode30, TreeNode34, TreeNode37, TreeNode44, TreeNode48, TreeNode54, TreeNode59, TreeNode61, TreeNode65, TreeNode67})
        Me.treemenu.Size = New System.Drawing.Size(231, 467)
        Me.treemenu.TabIndex = 0
        '
        'tabPage2
        '
        Me.tabPage2.BackColor = System.Drawing.Color.White
        Me.tabPage2.Controls.Add(Me.label1)
        Me.tabPage2.Controls.Add(Me.searchlist)
        Me.tabPage2.Controls.Add(Me.searchtext)
        Me.tabPage2.Location = New System.Drawing.Point(4, 25)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(231, 474)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "キーワード検索"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(56, 23)
        Me.label1.TabIndex = 3
        Me.label1.Text = "検索 : "
        '
        'searchlist
        '
        Me.searchlist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchlist.BackColor = System.Drawing.Color.White
        Me.searchlist.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchlist.ForeColor = System.Drawing.Color.Black
        Me.searchlist.FormattingEnabled = True
        Me.searchlist.ItemHeight = 23
        Me.searchlist.Location = New System.Drawing.Point(9, 38)
        Me.searchlist.Name = "searchlist"
        Me.searchlist.Size = New System.Drawing.Size(216, 253)
        Me.searchlist.TabIndex = 2
        '
        'searchtext
        '
        Me.searchtext.Location = New System.Drawing.Point(62, 7)
        Me.searchtext.Name = "searchtext"
        Me.searchtext.Size = New System.Drawing.Size(163, 30)
        Me.searchtext.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.splitContainer2)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(1024, 728)
        Me.Name = "MainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InputMan for Windows Forms 12.0J Demonstration"
        Me.splitContainer2.Panel1.ResumeLayout(False)
        Me.splitContainer2.Panel1.PerformLayout()
        Me.splitContainer2.Panel2.ResumeLayout(False)
        CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer2.ResumeLayout(False)
        CType(Me.product_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer3.Panel1.ResumeLayout(False)
        Me.splitContainer3.Panel2.ResumeLayout(False)
        Me.splitContainer3.Panel2.PerformLayout()
        CType(Me.splitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer3.ResumeLayout(False)
        Me.splitContainer1.Panel1.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        CType(Me.menuheader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grapecity_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.myTabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage2.ResumeLayout(False)
        Me.tabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private splitContainer2 As System.Windows.Forms.SplitContainer
    Private splitContainer3 As System.Windows.Forms.SplitContainer
    Private splitContainer1 As System.Windows.Forms.SplitContainer
    Private product_title As System.Windows.Forms.Label
    Private firstView As System.Windows.Forms.LinkLabel
    Private product_logo As System.Windows.Forms.PictureBox
	Private copyright As System.Windows.Forms.Label
	Private grapecity_logo As System.Windows.Forms.PictureBox
	Private menuheader As System.Windows.Forms.PictureBox
	Private panel1 As System.Windows.Forms.Panel
	Private tabPage1 As System.Windows.Forms.TabPage
	Private treemenu As MyTreeView
	Private tabPage2 As System.Windows.Forms.TabPage
	Private label1 As System.Windows.Forms.Label
	Private searchlist As System.Windows.Forms.ListBox
	Private searchtext As System.Windows.Forms.TextBox
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private pictureBox2 As System.Windows.Forms.PictureBox
	Private myTabControl1 As MyTabControl
End Class

