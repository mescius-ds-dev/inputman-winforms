using System.Collections;
using System.Diagnostics;

namespace InputManWin12_Demo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // ファーストビューを開く
            this.Load += (s, e) => this.SetMainPanel(new FirstViewPage());

            // ツリー選択のコントロール表示
            treemenu.AfterSelect += (s, e) => OpenSelectControl(e);

            treemenu.AfterCollapse += (s, e) => treemenu.SelectedNode = null;

            // ファーストビューに戻る
            firstView.LinkClicked += (s, e) => SetFirstView();

            // トライアル版へのリンク
            trial.LinkClicked += (s, e) => Navigate("https://developer.mescius.jp/download#input");

            // フッタから製品情報へのリンク
            product_info.LinkClicked += (s, e) => Navigate("https://developer.mescius.jp/inputmanplus-winforms");

            // ツイッターへのリンク
            twitter.LinkClicked += (s, e) => Navigate("https://twitter.com/MESCIUS_dev");

            searchtext.TextChanged += new EventHandler(searchtext_TextChanged);
            searchlist.SelectedIndexChanged += new EventHandler(searchlist_SelectedIndexChanged);
            myTabControl1.SelectedIndexChanged += new EventHandler(myTabControl1_SelectedIndexChanged);

            // VS2010のデザイナで入れ子のFixedPanelプロパティを設定すると
            // デザイナを開くたびにサイズが大きくなるため、コードから設定して回避
            splitContainer3.FixedPanel = FixedPanel.Panel2;
            // デザイナを開くたびに位置が変わるため、コードから設定して回避
            grapecity_logo.Location = new Point(12, 27);
            copyright.Location = new Point(173, 35);

            // ちらつき防止
            // ヘッダ
            pictureBox1.Controls.Add(product_logo);
            pictureBox1.Controls.Add(product_title);
            pictureBox1.Controls.Add(firstView);

            // フッタ
            pictureBox2.Controls.Add(grapecity_logo);
            pictureBox2.Controls.Add(copyright);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // ファーストビューを開く
            this.SetMainPanel(new FirstViewPage());
        }

        private void OpenSelectControl(TreeViewEventArgs e)
        {
            if (e.Node.Parent == null) return;

            switch (e.Node.Parent.Text)
            {
                case "コントロール一覧":
                    switch (e.Node.Text)
                    {
                        case "入力コントロール":
                            this.SetMainPanel(new InputManWin12_Demo._01_Controls.Controls());
                            break;
                        case "入力支援機能":
                            this.SetMainPanel(new InputManWin12_Demo._01_Controls.Components());
                            break;
                        case "継承コントロール":
                            this.SetMainPanel(new InputManWin12_Demo._01_Controls.CustomControls());
                            break;
                        default:
                            break;
                    }
                    break;
                case "タッチ機能":
                    switch (e.Node.Text)
                    {
                        case "タッチツールバー":
                            this.SetMainPanel(new InputManWin12_Demo._13_Touch.TouchToolBar());
                            break;
                        case "タッチキーボード":
                            this.SetMainPanel(new InputManWin12_Demo._13_Touch.TouchKeyboard());
                            break;
                        case "グリッパーの表示":
                            this.SetMainPanel(new InputManWin12_Demo._13_Touch.Gripper());
                            break;
                        case "ドロップダウンウィンドウの拡大表示":
                            this.SetMainPanel(new InputManWin12_Demo._13_Touch.DropDownScale());
                            break;
                        case "コンテキストメニューの拡大表示":
                            this.SetMainPanel(new InputManWin12_Demo._13_Touch.ContextMenuScale());
                            break;
                    }
                    break;
                case "書式による入力制限":
                    switch (e.Node.Text)
                    {
                        case "テキストコントロール":
                            this.SetMainPanel(new InputManWin12_Demo._02_Format.GcTextBox());
                            break;
                        case "キャラクタボックスコントロール":
                            this.SetMainPanel(new InputManWin12_Demo._02_Format.GcCharMask());
                            break;
                        case "マスクコントロール":
                            this.SetMainPanel(new InputManWin12_Demo._02_Format.GcMask());
                            break;
                        case "日付時刻コントロール":
                            this.SetMainPanel(new InputManWin12_Demo._02_Format.GcDateTime());
                            break;
                        case "日付コントロール":
                            this.SetMainPanel(new InputManWin12_Demo._02_Format.GcDate());
                            break;
                        case "時刻コントロール":
                            this.SetMainPanel(new InputManWin12_Demo._02_Format.GcTime());
                            break;
                        case "数値コントロール":
                            this.SetMainPanel(new InputManWin12_Demo._02_Format.GcNumber());
                            break;
                        case "タイムスパンコントロール":
                            this.SetMainPanel(new InputManWin12_Demo._02_Format.GcTimeSpan());
                            break;
                        case "コンボコントロール":
                            this.SetMainPanel(new InputManWin12_Demo._02_Format.GcComboBox());
                            break;
                        case "マスクコンボコントロール":
                            this.SetMainPanel(new InputManWin12_Demo._02_Format.GcMaskedComboBox());
                            break;
                        default:
                            break;
                    }
                    break;
                case "フォーカスの移動制御":
                    switch (e.Node.Text)
                    {
                        case "Enterキーや矢印キーでのフォーカス移動":
                            this.SetMainPanel(new InputManWin12_Demo._03_Focus.Enter());
                            break;
                        case "Tabキー押下時の動作":
                            this.SetMainPanel(new InputManWin12_Demo._03_Focus.Tab());
                            break;
                        default:
                            break;
                    }
                    break;
                case "自動入力による入力補助":
                    switch (e.Node.Text)
                    {
                        case "ふりがなの自動取得":
                            this.SetMainPanel(new InputManWin12_Demo._04_Input.Furigana());
                            break;
                        case "入力候補値の表示":
                            this.SetMainPanel(new InputManWin12_Demo._04_Input.RecommendedValue());
                            break;
                        default:
                            break;
                    }
                    break;
                case "住所検索機能":
                    switch (e.Node.Text)
                    {
                        case "郵便番号／市外局番からの住所検索":
                            this.SetMainPanel(new InputManWin12_Demo._12_Address.GcAddress());
                            break;
                        case "郵便番号入力用コントロール":
                            this.SetMainPanel(new InputManWin12_Demo._12_Address.GcPostal());
                            break;
                        case "住所入力用コントロール":
                            this.SetMainPanel(new InputManWin12_Demo._12_Address.GcAddressBox());
                            break;
                        default:
                            break;
                    }
                    break;
                case "ショートカット機能の設定":
                    switch (e.Node.Text)
                    {
                        case "ショートカット動作の確認":
                            this.SetMainPanel(new InputManWin12_Demo._05_Shortcuts.Shortcuts());
                            break;
                        case "ショートカットキーの設定":
                            this.SetMainPanel(new InputManWin12_Demo._05_Shortcuts.SetShortcuts());
                            break;
                        default:
                            break;
                    }
                    break;
                case "表示機能":
                    switch (e.Node.Text)
                    {
                        case "コントロール無効時のスタイル":
                            this.SetMainPanel(new InputManWin12_Demo._06_Display.DisabledColor());
                            break;
                        case "省略文字の表示":
                            this.SetMainPanel(new InputManWin12_Demo._06_Display.Ellipsis());
                            break;
                        case "オーバーフローチップの表示":
                            this.SetMainPanel(new InputManWin12_Demo._06_Display.ShowOverflowTip());
                            break;
                        case "テキストの配置":
                            this.SetMainPanel(new InputManWin12_Demo._06_Display.Alignment());
                            break;
                        case "アクティブコントロールのスタイル":
                            this.SetMainPanel(new InputManWin12_Demo._06_Display.ActiveColor());
                            break;
                        case "読み取り専用コントロールのスタイル":
                            this.SetMainPanel(new InputManWin12_Demo._06_Display.ReadOnlyColor());
                            break;
                        default:
                            break;
                    }
                    break;
                case "ドロップダウンによる入力補助":
                    switch (e.Node.Text)
                    {
                        case "ドロップダウンのカスタマイズ":
                            this.SetMainPanel(new InputManWin12_Demo._07_DropDown.DropDown());
                            break;
                        case "ドロップダウンカレンダー":
                            this.SetMainPanel(new InputManWin12_Demo._07_DropDown.DropDownCalendar());
                            break;
                        case "ドロップダウン日付時刻ピッカー":
                            this.SetMainPanel(new InputManWin12_Demo._07_DropDown.DropDownDateTimePicker());
                            break;
                        default:
                            break;
                    }
                    break;
                case "コントロールに追加可能なボタン":
                    switch (e.Node.Text)
                    {
                        case "ドロップダウンボタン":
                            this.SetMainPanel(new InputManWin12_Demo._08_SideButton.DropDownButton());
                            break;
                        case "スピンボタン":
                            this.SetMainPanel(new InputManWin12_Demo._08_SideButton.SpinButton());
                            break;
                        case "サイドボタン":
                            this.SetMainPanel(new InputManWin12_Demo._08_SideButton.SideButton());
                            break;
                        case "シンボルボタン":
                            this.SetMainPanel(new InputManWin12_Demo._08_SideButton.SymbolButton());
                            break;
                        case "スピン操作":
                            this.SetMainPanel(new InputManWin12_Demo._08_SideButton.SpinBehavior());
                            break;
                        default:
                            break;
                    }
                    break;
                case "コンボコントロール":
                    switch (e.Node.Text)
                    {
                        case "マルチカラムによるリスト表示":
                            this.SetMainPanel(new InputManWin12_Demo._09_GcComboBox.ComboMultiColumns());
                            break;
                        case "オートコンプリートによる補完機能":
                            this.SetMainPanel(new InputManWin12_Demo._09_GcComboBox.AutoComplete());
                            break;
                        case "リストのフィルタと自動選択":
                            this.SetMainPanel(new InputManWin12_Demo._09_GcComboBox.AutoFilter());
                            break;
                        case "表示テキストのカスタマイズ":
                            this.SetMainPanel(new InputManWin12_Demo._09_GcComboBox.TextFormat());
                            break;
                        default:
                            break;
                    }
                    break;
                case "リストコントロール":
                    switch (e.Node.Text)
                    {
                        case "マルチカラムによるリスト表示":
                            this.SetMainPanel(new InputManWin12_Demo._10_GcListBox.ListMultiColumns());
                            break;
                        default:
                            break;
                    }
                    break;
                case "入力値の検証":
                    switch (e.Node.Text)
                    {
                        case "入力範囲の設定":
                            this.SetMainPanel(new InputManWin12_Demo._11_Validate.MinMax());
                            break;
                        case "イベントを利用した検証":
                            this.SetMainPanel(new InputManWin12_Demo._11_Validate.InvalidInput());
                            break;
                        case "検証エラーの通知":
                            this.SetMainPanel(new InputManWin12_Demo._11_Validate.Validator());
                            break;
                        default:
                            break;
                    }
                    break;
                case "ソフトキーボードコンポーネント":
                    switch (e.Node.Text)
                    {
                        case "キーレイアウトと表示位置":
                            this.SetMainPanel(new InputManWin12_Demo._14_GcSoftKeyboard.KeyLayout());
                            break;
                        case "スタイルの変更":
                            this.SetMainPanel(new InputManWin12_Demo._14_GcSoftKeyboard.Appearance());
                            break;
                        default:
                            break;
                    }
                    break;
                case "実用例":
                    switch (e.Node.Text)
                    {
                        case "社員情報入力":
                            this.SetMainPanel(new InputManWin12_Demo._15_Sample.RegistEmployee());
                            break;
                        default:
                            break;
                    }
                    break;
            }
        }

        private void treemenu_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            treemenu.SelectedNode = null;
        }

        #region ページ移動処理
        private void SetMainPanel(FirstViewPage ucontrol)
        {
            ucontrol.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(ucontrol);
            if (this.splitContainer1.Panel2.Controls.Count > 1)
            {
                this.splitContainer1.Panel2.Controls.RemoveAt(0);
            }
        }
        private void SetMainPanel(DemoBase ucontrol)
        {
            ucontrol.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(ucontrol);
            if (this.splitContainer1.Panel2.Controls.Count > 1)
            {
                this.splitContainer1.Panel2.Controls.RemoveAt(0);
            }
        }
        private void SetMainPanel(DemoBase_settings ucontrol)
        {
            ucontrol.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(ucontrol);
            if (this.splitContainer1.Panel2.Controls.Count > 1)
            {
                this.splitContainer1.Panel2.Controls.RemoveAt(0);
            }
        }
        #endregion

        #region リンク処理
        private void SetFirstView()
        {
            // ファーストビューに戻る
            this.SetMainPanel(new FirstViewPage());
            treemenu.SelectedNode = null;
            treemenu.CollapseAll();
        }

        private void Navigate(string Url)
        {
            Process.Start(new ProcessStartInfo { FileName = Url, UseShellExecute = true });
        }
        #endregion

        #region 検索機能
        // 検索ノードのコレクション               
        ArrayList myNode = new ArrayList();

        private void searchtext_TextChanged(object sender, EventArgs e)
        {
            // 検索結果(searchlist)をクリア
            searchlist.Items.Clear();
            myNode.Clear();

            if (searchtext.Text == "") return;

            // ツリーコントロールのノードを取得
            foreach (TreeNode node in GetAllNodes(treemenu.Nodes))
            {
                if (node.Parent != null)
                {
                    string s = node.Text;
                    if (node.Tag != null) s += node.Tag.ToString();

                    // 検索ワードを含むノードのみ抽出
                    if (s.Contains(searchtext.Text))
                    {
                        myNode.Add(node);
                        searchlist.Items.Add(node.Text);
                    }
                }
            }
        }

        private ArrayList GetAllNodes(TreeNodeCollection Nodes)
        {
            var ar = new ArrayList();
            // ツリーコントロールのノードを取得
            foreach (TreeNode Node in Nodes)
            {
                ar.Add(Node);
                if (Node.GetNodeCount(false) > 0) ar.AddRange(GetAllNodes(Node.Nodes));
            }
            return ar;
        }

        private void searchlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            // リストボックスで選択されたページを表示
            treemenu.SelectedNode = (TreeNode)myNode[searchlist.SelectedIndex];
        }

        private void myTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ツリービューにフォーカスを設定して選択状態にする
            if (myTabControl1.SelectedIndex == 0)
            {
                treemenu.Select();
            }
        }
        #endregion

    }

    // ツリービューのシングルクリックでの開閉
    class MyTreeView : TreeView
    {
        public MyTreeView()
            : base()
        {
            NodeMouseClick += new TreeNodeMouseClickEventHandler(MyTreeView_NodeMouseClick);
        }

        void MyTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node != null)
            {
                if (HitTest(e.Location).Location == TreeViewHitTestLocations.Label ||
                    HitTest(e.Location).Location == TreeViewHitTestLocations.Image)
                {
                    e.Node.Toggle();
                }
            }
        }
    }

    // タブコントロール内のちらつきを抑える
    class MyTabControl : TabControl
    {
        // リサイズ途中のちらつきを抑える処理
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}