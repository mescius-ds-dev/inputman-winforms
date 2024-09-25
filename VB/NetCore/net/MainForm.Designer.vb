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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("入力コントロール")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("入力支援機能")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("継承コントロール")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("コントロール一覧", New Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("タッチツールバー")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("タッチキーボード")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("グリッパーの表示")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ドロップダウンウィンドウの拡大表示")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("コンテキストメニューの拡大表示")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("タッチ機能", New Windows.Forms.TreeNode() {TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9})
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
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("書式による入力制限", New Windows.Forms.TreeNode() {TreeNode11, TreeNode12, TreeNode13, TreeNode14, TreeNode15, TreeNode16, TreeNode17, TreeNode18, TreeNode19, TreeNode20})
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("キーレイアウトと表示位置")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("スタイルの変更")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ソフトキーボードコンポーネント", New Windows.Forms.TreeNode() {TreeNode22, TreeNode23})
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Enterキーや矢印キーでのフォーカス移動")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tabキー押下時の動作")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("フォーカスの移動制御", New Windows.Forms.TreeNode() {TreeNode25, TreeNode26})
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ふりがなの自動取得")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("入力候補値の表示")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("自動入力による入力補助", New Windows.Forms.TreeNode() {TreeNode28, TreeNode29})
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("郵便番号／市外局番からの住所検索")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("郵便番号入力用コントロール")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("住所入力用コントロール")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("住所検索機能", New Windows.Forms.TreeNode() {TreeNode31, TreeNode32, TreeNode33})
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ショートカット動作の確認")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ショートカットキーの設定")
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ショートカット機能の設定", New Windows.Forms.TreeNode() {TreeNode35, TreeNode36})
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("コントロール無効時のスタイル")
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("アクティブコントロールのスタイル")
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("読み取り専用コントロールのスタイル")
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("省略文字の表示")
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("オーバーフローチップの表示")
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("テキストの配置")
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("フローティングラベルの表示")
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("表示機能", New Windows.Forms.TreeNode() {TreeNode38, TreeNode39, TreeNode40, TreeNode41, TreeNode42, TreeNode43, TreeNode44})
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ドロップダウンのカスタマイズ")
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ドロップダウンカレンダー")
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ドロップダウン日付時刻／カレンダーピッカー")
        Dim TreeNode49 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ドロップダウンによる入力補助", New Windows.Forms.TreeNode() {TreeNode46, TreeNode47, TreeNode48})
        Dim TreeNode50 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ドロップダウンボタン")
        Dim TreeNode51 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("スピンボタン")
        Dim TreeNode52 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("サイドボタン")
        Dim TreeNode53 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("シンボルボタン")
        Dim TreeNode54 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("スピン操作")
        Dim TreeNode55 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("コントロールに追加可能なボタン", New Windows.Forms.TreeNode() {TreeNode50, TreeNode51, TreeNode52, TreeNode53, TreeNode54})
        Dim TreeNode56 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("マルチカラムによるリスト表示")
        Dim TreeNode57 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("オートコンプリートによる補完機能")
        Dim TreeNode58 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("リストのフィルタと自動選択")
        Dim TreeNode59 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("表示テキストのカスタマイズ")
        Dim TreeNode60 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("コンボコントロール", New Windows.Forms.TreeNode() {TreeNode56, TreeNode57, TreeNode58, TreeNode59})
        Dim TreeNode61 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("マルチカラムによるリスト表示")
        Dim TreeNode62 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("リストコントロール", New Windows.Forms.TreeNode() {TreeNode61})
        Dim TreeNode63 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("入力範囲の設定")
        Dim TreeNode64 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("イベントを利用した検証")
        Dim TreeNode65 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("検証エラーの通知")
        Dim TreeNode66 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("入力値の検証", New Windows.Forms.TreeNode() {TreeNode63, TreeNode64, TreeNode65})
        Dim TreeNode67 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("社員情報入力")
        Dim TreeNode68 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("実用例", New Windows.Forms.TreeNode() {TreeNode67})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        splitContainer2 = New Windows.Forms.SplitContainer()
        product_logo = New Windows.Forms.PictureBox()
        firstView = New Windows.Forms.LinkLabel()
        product_title = New Windows.Forms.Label()
        pictureBox1 = New Windows.Forms.PictureBox()
        splitContainer3 = New Windows.Forms.SplitContainer()
        splitContainer1 = New Windows.Forms.SplitContainer()
        panel1 = New Windows.Forms.Panel()
        myTabControl1 = New MyTabControl()
        tabPage1 = New Windows.Forms.TabPage()
        treemenu = New MyTreeView()
        tabPage2 = New Windows.Forms.TabPage()
        label1 = New Windows.Forms.Label()
        searchlist = New Windows.Forms.ListBox()
        searchtext = New Windows.Forms.TextBox()
        menuheader = New Windows.Forms.PictureBox()
        copyright = New Windows.Forms.Label()
        grapecity_logo = New Windows.Forms.PictureBox()
        pictureBox2 = New Windows.Forms.PictureBox()
        CType(splitContainer2, ComponentModel.ISupportInitialize).BeginInit()
        splitContainer2.Panel1.SuspendLayout()
        splitContainer2.Panel2.SuspendLayout()
        splitContainer2.SuspendLayout()
        CType(product_logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(splitContainer3, ComponentModel.ISupportInitialize).BeginInit()
        splitContainer3.Panel1.SuspendLayout()
        splitContainer3.Panel2.SuspendLayout()
        splitContainer3.SuspendLayout()
        CType(splitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        splitContainer1.Panel1.SuspendLayout()
        splitContainer1.SuspendLayout()
        panel1.SuspendLayout()
        myTabControl1.SuspendLayout()
        tabPage1.SuspendLayout()
        tabPage2.SuspendLayout()
        CType(menuheader, ComponentModel.ISupportInitialize).BeginInit()
        CType(grapecity_logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(pictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' splitContainer2
        ' 
        splitContainer2.BackColor = Drawing.Color.Transparent
        splitContainer2.Dock = Windows.Forms.DockStyle.Fill
        splitContainer2.FixedPanel = Windows.Forms.FixedPanel.Panel1
        splitContainer2.IsSplitterFixed = True
        splitContainer2.Location = New System.Drawing.Point(0, 0)
        splitContainer2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        splitContainer2.Name = "splitContainer2"
        splitContainer2.Orientation = Windows.Forms.Orientation.Horizontal
        ' 
        ' splitContainer2.Panel1
        ' 
        splitContainer2.Panel1.BackColor = Drawing.Color.FromArgb(CByte(79), CByte(60), CByte(139))
        splitContainer2.Panel1.Controls.Add(product_logo)
        splitContainer2.Panel1.Controls.Add(firstView)
        splitContainer2.Panel1.Controls.Add(product_title)
        splitContainer2.Panel1.Controls.Add(pictureBox1)
        ' 
        ' splitContainer2.Panel2
        ' 
        splitContainer2.Panel2.Controls.Add(splitContainer3)
        splitContainer2.Size = New System.Drawing.Size(1008, 729)
        splitContainer2.SplitterDistance = 80
        splitContainer2.SplitterWidth = 6
        splitContainer2.TabIndex = 0
        ' 
        ' product_logo
        ' 
        product_logo.Anchor = Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left
        product_logo.BackgroundImage = InputManWin12_Demo.Resources.product_logo
        product_logo.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        product_logo.Location = New System.Drawing.Point(12, 4)
        product_logo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        product_logo.Name = "product_logo"
        product_logo.Size = New System.Drawing.Size(288, 74)
        product_logo.TabIndex = 8
        product_logo.TabStop = False
        ' 
        ' firstView
        ' 
        firstView.ActiveLinkColor = Drawing.Color.White
        firstView.Anchor = Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Right
        firstView.AutoSize = True
        firstView.DisabledLinkColor = Drawing.Color.White
        firstView.Font = New System.Drawing.Font("メイリオ", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        firstView.LinkBehavior = Windows.Forms.LinkBehavior.NeverUnderline
        firstView.LinkColor = Drawing.Color.White
        firstView.Location = New System.Drawing.Point(659, 48)
        firstView.Name = "firstView"
        firstView.Size = New System.Drawing.Size(126, 20)
        firstView.TabIndex = 1
        firstView.TabStop = True
        firstView.Text = "イントロダクション"
        firstView.VisitedLinkColor = Drawing.Color.White
        ' 
        ' product_title
        ' 
        product_title.Anchor = Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left
        product_title.AutoSize = True
        product_title.Font = New System.Drawing.Font("メイリオ", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        product_title.ForeColor = Drawing.Color.White
        product_title.Location = New System.Drawing.Point(309, 45)
        product_title.Name = "product_title"
        product_title.Size = New System.Drawing.Size(174, 24)
        product_title.TabIndex = 0
        product_title.Text = "for Windows Forms"
        ' 
        ' pictureBox1
        ' 
        pictureBox1.Dock = Windows.Forms.DockStyle.Fill
        pictureBox1.Location = New System.Drawing.Point(0, 0)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.Size = New System.Drawing.Size(1008, 80)
        pictureBox1.TabIndex = 9
        pictureBox1.TabStop = False
        ' 
        ' splitContainer3
        ' 
        splitContainer3.Dock = Windows.Forms.DockStyle.Fill
        splitContainer3.IsSplitterFixed = True
        splitContainer3.Location = New System.Drawing.Point(0, 0)
        splitContainer3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        splitContainer3.Name = "splitContainer3"
        splitContainer3.Orientation = Windows.Forms.Orientation.Horizontal
        ' 
        ' splitContainer3.Panel1
        ' 
        splitContainer3.Panel1.Controls.Add(splitContainer1)
        splitContainer3.Panel1.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        ' 
        ' splitContainer3.Panel2
        ' 
        splitContainer3.Panel2.BackgroundImage = InputManWin12_Demo.Resources.fotter
        splitContainer3.Panel2.Controls.Add(copyright)
        splitContainer3.Panel2.Controls.Add(grapecity_logo)
        splitContainer3.Panel2.Controls.Add(pictureBox2)
        splitContainer3.Size = New System.Drawing.Size(1008, 643)
        splitContainer3.SplitterDistance = 553
        splitContainer3.SplitterWidth = 6
        splitContainer3.TabIndex = 0
        ' 
        ' splitContainer1
        ' 
        splitContainer1.BackColor = Drawing.Color.Transparent
        splitContainer1.Dock = Windows.Forms.DockStyle.Fill
        splitContainer1.FixedPanel = Windows.Forms.FixedPanel.Panel1
        splitContainer1.IsSplitterFixed = True
        splitContainer1.Location = New System.Drawing.Point(7, 0)
        splitContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        splitContainer1.Name = "splitContainer1"
        ' 
        ' splitContainer1.Panel1
        ' 
        splitContainer1.Panel1.BackColor = Drawing.Color.FromArgb(CByte(240), CByte(240), CByte(240))
        splitContainer1.Panel1.Controls.Add(panel1)
        splitContainer1.Panel1.Controls.Add(menuheader)
        ' 
        ' splitContainer1.Panel2
        ' 
        splitContainer1.Panel2.BackColor = Drawing.Color.Transparent
        splitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        splitContainer1.Size = New System.Drawing.Size(1001, 553)
        splitContainer1.SplitterDistance = 253
        splitContainer1.SplitterWidth = 1
        splitContainer1.TabIndex = 0
        ' 
        ' panel1
        ' 
        panel1.BackColor = Drawing.Color.Gainsboro
        panel1.Controls.Add(myTabControl1)
        panel1.Dock = Windows.Forms.DockStyle.Fill
        panel1.Location = New System.Drawing.Point(0, 38)
        panel1.Name = "panel1"
        panel1.Padding = New System.Windows.Forms.Padding(7, 7, 7, 5)
        panel1.Size = New System.Drawing.Size(253, 515)
        panel1.TabIndex = 0
        ' 
        ' myTabControl1
        ' 
        myTabControl1.Controls.Add(tabPage1)
        myTabControl1.Controls.Add(tabPage2)
        myTabControl1.Dock = Windows.Forms.DockStyle.Fill
        myTabControl1.Location = New System.Drawing.Point(7, 7)
        myTabControl1.Multiline = True
        myTabControl1.Name = "myTabControl1"
        myTabControl1.SelectedIndex = 0
        myTabControl1.Size = New System.Drawing.Size(239, 503)
        myTabControl1.TabIndex = 0
        ' 
        ' tabPage1
        ' 
        tabPage1.Controls.Add(treemenu)
        tabPage1.Location = New System.Drawing.Point(4, 27)
        tabPage1.Name = "tabPage1"
        tabPage1.Size = New System.Drawing.Size(231, 472)
        tabPage1.TabIndex = 0
        tabPage1.Text = "コンテンツ一覧"
        tabPage1.UseVisualStyleBackColor = True
        ' 
        ' treemenu
        ' 
        treemenu.BackColor = Drawing.Color.White
        treemenu.BorderStyle = Windows.Forms.BorderStyle.None
        treemenu.Dock = Windows.Forms.DockStyle.Fill
        treemenu.Font = New System.Drawing.Font("メイリオ", 9F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        treemenu.ForeColor = Drawing.Color.Black
        treemenu.HideSelection = False
        treemenu.Indent = 15
        treemenu.ItemHeight = 25
        treemenu.Location = New System.Drawing.Point(0, 0)
        treemenu.Name = "treemenu"
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
        TreeNode44.Name = "ノード10"
        TreeNode44.Text = "フローティングラベルの表示"
        TreeNode45.Name = "ノード0"
        TreeNode45.Text = "表示機能"
        TreeNode46.Name = "ノード1"
        TreeNode46.Text = "ドロップダウンのカスタマイズ"
        TreeNode47.Name = "ノード1"
        TreeNode47.Text = "ドロップダウンカレンダー"
        TreeNode48.Name = "ノード1"
        TreeNode48.Text = "ドロップダウン日付時刻／カレンダーピッカー"
        TreeNode49.Name = "ノード0"
        TreeNode49.Text = "ドロップダウンによる入力補助"
        TreeNode50.Name = "ノード1"
        TreeNode50.Tag = "サイドボタン"
        TreeNode50.Text = "ドロップダウンボタン"
        TreeNode51.Name = "ノード1"
        TreeNode51.Tag = "サイドボタン"
        TreeNode51.Text = "スピンボタン"
        TreeNode52.Name = "ノード1"
        TreeNode52.Text = "サイドボタン"
        TreeNode53.Name = "ノード1"
        TreeNode53.Tag = "サイドボタン"
        TreeNode53.Text = "シンボルボタン"
        TreeNode54.Name = "ノード0"
        TreeNode54.Tag = "サイドボタン"
        TreeNode54.Text = "スピン操作"
        TreeNode55.Name = "ノード0"
        TreeNode55.Text = "コントロールに追加可能なボタン"
        TreeNode56.Name = "ノード1"
        TreeNode56.Tag = "コンボ"
        TreeNode56.Text = "マルチカラムによるリスト表示"
        TreeNode57.Name = "ノード1"
        TreeNode57.Tag = "コンボ"
        TreeNode57.Text = "オートコンプリートによる補完機能"
        TreeNode58.Name = "ノード1"
        TreeNode58.Tag = "コンボ"
        TreeNode58.Text = "リストのフィルタと自動選択"
        TreeNode59.Name = "ノード1"
        TreeNode59.Text = "表示テキストのカスタマイズ"
        TreeNode60.Name = "ノード0"
        TreeNode60.Text = "コンボコントロール"
        TreeNode61.Name = "ノード1"
        TreeNode61.Text = "マルチカラムによるリスト表示"
        TreeNode62.Name = "ノード0"
        TreeNode62.Text = "リストコントロール"
        TreeNode63.Name = "ノード1"
        TreeNode63.Tag = "検証"
        TreeNode63.Text = "入力範囲の設定"
        TreeNode64.Name = "ノード1"
        TreeNode64.Text = "イベントを利用した検証"
        TreeNode65.Name = "ノード1"
        TreeNode65.Text = "検証エラーの通知"
        TreeNode66.Name = "ノード0"
        TreeNode66.Text = "入力値の検証"
        TreeNode67.Name = "ノード9"
        TreeNode67.Text = "社員情報入力"
        TreeNode68.Name = "ノード8"
        TreeNode68.Text = "実用例"
        treemenu.Nodes.AddRange(New Windows.Forms.TreeNode() {TreeNode4, TreeNode10, TreeNode21, TreeNode24, TreeNode27, TreeNode30, TreeNode34, TreeNode37, TreeNode45, TreeNode49, TreeNode55, TreeNode60, TreeNode62, TreeNode66, TreeNode68})
        treemenu.Size = New System.Drawing.Size(231, 472)
        treemenu.TabIndex = 0
        ' 
        ' tabPage2
        ' 
        tabPage2.BackColor = Drawing.Color.White
        tabPage2.Controls.Add(label1)
        tabPage2.Controls.Add(searchlist)
        tabPage2.Controls.Add(searchtext)
        tabPage2.Location = New System.Drawing.Point(4, 24)
        tabPage2.Name = "tabPage2"
        tabPage2.Padding = New System.Windows.Forms.Padding(3)
        tabPage2.Size = New System.Drawing.Size(231, 475)
        tabPage2.TabIndex = 1
        tabPage2.Text = "キーワード検索"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New System.Drawing.Point(6, 10)
        label1.Name = "label1"
        label1.Size = New System.Drawing.Size(45, 18)
        label1.TabIndex = 3
        label1.Text = "検索 : "
        ' 
        ' searchlist
        ' 
        searchlist.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
        searchlist.BackColor = Drawing.Color.White
        searchlist.BorderStyle = Windows.Forms.BorderStyle.None
        searchlist.ForeColor = Drawing.Color.Black
        searchlist.FormattingEnabled = True
        searchlist.ItemHeight = 18
        searchlist.Location = New System.Drawing.Point(9, 38)
        searchlist.Name = "searchlist"
        searchlist.Size = New System.Drawing.Size(216, 270)
        searchlist.TabIndex = 2
        ' 
        ' searchtext
        ' 
        searchtext.Location = New System.Drawing.Point(62, 7)
        searchtext.Name = "searchtext"
        searchtext.Size = New System.Drawing.Size(163, 25)
        searchtext.TabIndex = 0
        ' 
        ' menuheader
        ' 
        menuheader.Dock = Windows.Forms.DockStyle.Top
        menuheader.Image = InputManWin12_Demo.Resources.menuheader
        menuheader.Location = New Drawing.Point(0, 0)
        menuheader.Name = "menuheader"
        menuheader.Size = New System.Drawing.Size(253, 38)
        menuheader.TabIndex = 1
        menuheader.TabStop = False
        ' 
        ' copyright
        ' 
        copyright.Anchor = Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left
        copyright.AutoSize = True
        copyright.Font = New System.Drawing.Font("メイリオ", 8.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        copyright.ForeColor = Drawing.Color.FromArgb(CByte(195), CByte(195), CByte(195))
        copyright.Location = New System.Drawing.Point(173, -81)
        copyright.Name = "copyright"
        copyright.Size = New System.Drawing.Size(215, 17)
        copyright.TabIndex = 0
        copyright.Text = "©️ MESCIUS inc. All rights reserved."
        ' 
        ' grapecity_logo
        ' 
        grapecity_logo.Anchor = Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left
        grapecity_logo.BackgroundImage = InputManWin12_Demo.Resources.grapecity_logo
        grapecity_logo.BackgroundImageLayout = Windows.Forms.ImageLayout.None
        grapecity_logo.Location = New System.Drawing.Point(12, -89)
        grapecity_logo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        grapecity_logo.Name = "grapecity_logo"
        grapecity_logo.Size = New System.Drawing.Size(155, 29)
        grapecity_logo.TabIndex = 6
        grapecity_logo.TabStop = False
        ' 
        ' pictureBox2
        ' 
        pictureBox2.Dock = Windows.Forms.DockStyle.Fill
        pictureBox2.Location = New System.Drawing.Point(0, 0)
        pictureBox2.Name = "pictureBox2"
        pictureBox2.Size = New System.Drawing.Size(1008, 84)
        pictureBox2.TabIndex = 9
        pictureBox2.TabStop = False
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7F, 18F)
        AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        BackColor = Drawing.Color.FromArgb(CByte(240), CByte(240), CByte(240))
        ClientSize = New System.Drawing.Size(1008, 729)
        Controls.Add(splitContainer2)
        Font = New System.Drawing.Font("メイリオ", 9F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Drawing.Icon)
        Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        MinimumSize = New System.Drawing.Size(1024, 728)
        Name = "MainForm"
        SizeGripStyle = Windows.Forms.SizeGripStyle.Show
        StartPosition = Windows.Forms.FormStartPosition.CenterScreen
        Text = "InputMan for Windows Forms 12.0J Demonstration"
        splitContainer2.Panel1.ResumeLayout(False)
        splitContainer2.Panel1.PerformLayout()
        splitContainer2.Panel2.ResumeLayout(False)
        CType(splitContainer2, ComponentModel.ISupportInitialize).EndInit()
        splitContainer2.ResumeLayout(False)
        CType(product_logo, ComponentModel.ISupportInitialize).EndInit()
        CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
        splitContainer3.Panel1.ResumeLayout(False)
        splitContainer3.Panel2.ResumeLayout(False)
        splitContainer3.Panel2.PerformLayout()
        CType(splitContainer3, ComponentModel.ISupportInitialize).EndInit()
        splitContainer3.ResumeLayout(False)
        splitContainer1.Panel1.ResumeLayout(False)
        CType(splitContainer1, ComponentModel.ISupportInitialize).EndInit()
        splitContainer1.ResumeLayout(False)
        panel1.ResumeLayout(False)
        myTabControl1.ResumeLayout(False)
        tabPage1.ResumeLayout(False)
        tabPage2.ResumeLayout(False)
        tabPage2.PerformLayout()
        CType(menuheader, ComponentModel.ISupportInitialize).EndInit()
        CType(grapecity_logo, ComponentModel.ISupportInitialize).EndInit()
        CType(pictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
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

