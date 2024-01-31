using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._05_Shortcuts
{
    public partial class SetShortcuts : InputManWin12_Demo.DemoBase_settings
    {
        public SetShortcuts()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            gcComboBox2.SelectedIndexChanged += new EventHandler(gcComboBox2_SelectedIndexChanged);
            gcComboBox3.SelectedIndexChanged += new EventHandler(gcComboBox3_SelectedIndexChanged);
            gcListBox1.SelectedIndexChanged += new EventHandler(gcListBox1_SelectedIndexChanged);

            button1.Click += new EventHandler(button_Click);
            button2.Click += new EventHandler(button_Click);

            // xmlファイルからショートカット機能一覧取得
            System.String filePath = Application.StartupPath;
            this.dataSet1.ReadXml(filePath + "\\Resources\\shortcuts.xml");

            // 設定されているショートカットをリストに表示
            getShortcutList(gcShortcut1.GetShortcuts(gcTextBox1));

            // ***** 初期値
            gcComboBox2.SelectedIndex = 0;
            gcListBox1.SelectedIndex = 0;

            // xmlファイルからデータ取得
            this.dataSet2.ReadXml(filePath + "\\Resources\\prefecture.xml");
            gcComboBox1.DataSource = dataSet2.Tables[0];
            gcComboBox1.SelectedIndex = -1;

            for (int i = 1; i < gcComboBox1.ListColumns.Count; i++)
            {
                gcComboBox1.ListColumns[i].AutoWidth = true;
            }

            // xmlファイルからデータ取得（gcMaskedComboBox）
            this.dataSet3.ReadXml(filePath + "\\Resources\\pref.xml");
            gcMaskedComboBox1.DataSource = dataSet3.Tables[0];
            gcMaskedComboBox1.SelectedIndex = -1;

            for (int i = 1; i < gcMaskedComboBox1.ListColumns.Count; i++)
            {
                gcMaskedComboBox1.ListColumns[i].AutoWidth = true;
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            // キー取得
            Keys selectedKey = new Keys();
            foreach (Keys keyval in Enum.GetValues(typeof(Keys)))
            {
                if (keyval.ToString() == gcComboBox3.Text)
                {
                    selectedKey = keyval;
                }
            }

            Control ctrl = null;
            switch (gcComboBox2.SelectedIndex)
            {
                case 0:
                    // テキストコントロール
                    ctrl = gcTextBox1;
                    break;
                case 1:
                    // マスクコントロール
                    ctrl = gcMask1;
                    break;
                case 2:
                    // キャラクタボックスコントロール
                    ctrl = gcCharMask1;
                    break;
                case 3:
                    // 日付時刻コントロール
                    ctrl = gcDateTime1;
                    break;
                case 4:
                    // 日付コントロール
                    ctrl = gcDate1;
                    break;
                case 5:
                    // 時刻コントロール
                    ctrl = gcTime1;
                    break;
                case 6:
                    // タイムスパンコントロール
                    ctrl = gcTimeSpan1;
                    break;
                case 7:
                    // 数値コントロール
                    ctrl = gcNumber1;
                    break;
                case 8:
                    // コンボコントロール
                    ctrl = gcComboBox1;
                    break;
                case 9:
                    // マスクコンボコントロール
                    ctrl = gcMaskedComboBox1;
                    break;
                default:
                    break;
            }

            if (sender == button1)
            {
                // ショートカットキーの追加
                try
                {
                    gcShortcut1.GetShortcuts(ctrl).Add(selectedKey, gcShortcut1, gcComboBox4.Text);
                }
                catch
                {
                    gcShortcut1.GetShortcuts(ctrl).Add(selectedKey, ctrl, gcComboBox4.Text);
                }
                // 追加したショートカットをリストに追加してフォーカスセット
                getShortcutList(gcShortcut1.GetShortcuts(ctrl));
                gcListBox1.SelectedIndex = gcListBox1.FindStringExact(gcComboBox3.Text, -1, 0);
                button1.Enabled = false;
                button2.Enabled = true;
            }
            else
            {
                // ショートカットキーの削除
                gcListBox1.SelectedIndex = -1;
                gcShortcut1.GetShortcuts(ctrl).Remove(selectedKey);
                // 削除したショートカットをリストからも削除
                gcListBox1.Items.RemoveAt(gcListBox1.FindStringExact(gcComboBox3.Text, -1, 0));
                if (gcListBox1.Items.Count == 0)
                {
                    button1.Enabled = true;
                    button2.Enabled = false;
                }
                else
                {
                    gcListBox1.SelectedIndex = 0;
                }
            }
        }

        private void getShortcutList(ShortcutCollection sc)
        {
            // コントロールのショートカットを取得
            gcListBox1.Items.Clear();
            ICollection<Keys> skeys = sc.Keys;
            foreach (Keys k in skeys)
            {
                gcListBox1.Items.Add(new ListItem(new string[] { k.ToString(), "" }));
            }
            Int32 i = 0;
            ICollection<MethodInvoker> smethods = sc.Values;
            foreach (MethodInvoker mi in smethods)
            {
                gcListBox1.Items[i].SubItems[1].Value = mi.Method.Name;
                i += 1;
            }
        }

        private void gcListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gcListBox1.SelectedItem != null)
            {
                gcComboBox3.SelectedIndex = gcComboBox3.FindStringExact(gcListBox1.SelectedItem.Text, -1, 0);
                gcComboBox4.SelectedIndex = gcComboBox4.FindStringExact(gcListBox1.SelectedValue.ToString(), -1, 0);
            }
        }

        private void gcComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 追加対象コントロールの変更
            DataView dv = new DataView(dataSet1.Tables[0]);

            switch (gcComboBox2.SelectedIndex)
            {
                case 0:
                    // テキストコントロール
                    getShortcutList(gcShortcut1.GetShortcuts(gcTextBox1));
                    dv.RowFilter = "gcTextBoxflg = 'true'";
                    break;
                case 1:
                    // マスクコントロール
                    getShortcutList(gcShortcut1.GetShortcuts(gcMask1));
                    dv.RowFilter = "gcMaskflg = 'true'";
                    break;
                case 2:
                    // キャラクタボックスコントロール
                    getShortcutList(gcShortcut1.GetShortcuts(gcCharMask1));
                    dv.RowFilter = "gcCharMaskflg = 'true'";
                    break;
                case 3:
                    // 日付時刻コントロール
                    getShortcutList(gcShortcut1.GetShortcuts(gcDateTime1));
                    dv.RowFilter = "gcDateTimeflg = 'true'";
                    break;
                case 4:
                    // 日付コントロール
                    getShortcutList(gcShortcut1.GetShortcuts(gcDate1));
                    dv.RowFilter = "gcDateflg = 'true'";
                    break;
                case 5:
                    // 時刻コントロール
                    getShortcutList(gcShortcut1.GetShortcuts(gcTime1));
                    dv.RowFilter = "gcTimeflg = 'true'";
                    break;
                case 6:
                    // タイムスパンコントロール
                    getShortcutList(gcShortcut1.GetShortcuts(gcTimeSpan1));
                    dv.RowFilter = "gcTimeSpanflg = 'true'";
                    break;
                case 7:
                    // 数値コントロール
                    getShortcutList(gcShortcut1.GetShortcuts(gcNumber1));
                    dv.RowFilter = "gcNumberflg = 'true'";
                    break;
                case 8:
                    // コンボコントロール
                    getShortcutList(gcShortcut1.GetShortcuts(gcComboBox1));
                    dv.RowFilter = "gcComboBoxflg = 'true'";
                    break;
                case 9:
                    // マスクコンボコントロール
                    getShortcutList(gcShortcut1.GetShortcuts(gcMaskedComboBox1));
                    dv.RowFilter = "gcMaskedComboBoxflg = 'true'";
                    break;
                default:
                    break;
            }
            gcComboBox4.DataSource = dv;

            gcComboBox4.ListColumns[0].AutoWidth = true;
            gcComboBox4.ListColumns[1].AutoWidth = true;
            gcComboBox4.ListColumns[2].Visible = false;
            gcComboBox4.ListColumns[3].Visible = false;
            gcComboBox4.ListColumns[4].Visible = false;
            gcComboBox4.ListColumns[5].Visible = false;
            gcComboBox4.ListColumns[6].Visible = false;
            gcComboBox4.ListColumns[7].Visible = false;
            gcComboBox4.ListColumns[8].Visible = false;
            gcComboBox4.ListColumns[9].Visible = false;
            gcComboBox4.ListColumns[10].Visible = false;
            gcComboBox4.ListColumns[11].Visible = false;

            gcListBox1.SelectedIndex = 0;
        }

        private void gcComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 割り当てキーの変更
            gcListBox1.SelectedIndex = gcListBox1.FindStringExact(gcComboBox3.Text, -1, 0);

            if (gcListBox1.FindStringExact(gcComboBox3.Text, -1, 0) == -1)
            {
                button1.Enabled = true;
                button2.Enabled = false;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = true;
            }
        }
    }
}
