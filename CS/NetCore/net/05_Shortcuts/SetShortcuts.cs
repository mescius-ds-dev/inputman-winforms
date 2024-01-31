using GrapeCity.Win.Editors;
using System.Data;

namespace InputManWin12_Demo._05_Shortcuts;

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
        gcComboBox2.SelectedIndexChanged += (s, e) => ChangeTargetControl();
        gcComboBox3.SelectedIndexChanged += (s, e) => ChangeAssignKey();
        gcListBox1.SelectedIndexChanged += (s, e) => SetSelectIndex();

        button1.Click += (s, e) => AddShortcutKey();
        button2.Click += (s, e) => DeleteShortcutKey();

        // xmlファイルからショートカット機能一覧取得
        this.dataSet1.ReadXml(Path.Combine(Application.StartupPath, @"Resources\shortcuts.xml"));

        // 設定されているショートカットをリストに表示
        GetShortcutList(gcShortcut1.GetShortcuts(gcTextBox1));

        // ***** 初期値
        gcComboBox2.SelectedIndex = 0;
        gcListBox1.SelectedIndex = 0;

        // xmlファイルからデータ取得
        this.dataSet2.ReadXml(Path.Combine(Application.StartupPath, @"Resources\prefecture.xml"));
        gcComboBox1.DataSource = dataSet2.Tables[0];
        gcComboBox1.SelectedIndex = -1;

        for (int i = 1; i < gcComboBox1.ListColumns.Count; i++)
        {
            gcComboBox1.ListColumns[i].AutoWidth = true;
        }

        // xmlファイルからデータ取得（gcMaskedComboBox）
        this.dataSet3.ReadXml(Path.Combine(Application.StartupPath, @"Resources\pref.xml"));
        gcMaskedComboBox1.DataSource = dataSet3.Tables[0];
        gcMaskedComboBox1.SelectedIndex = -1;

        for (int i = 1; i < gcMaskedComboBox1.ListColumns.Count; i++)
        {
            gcMaskedComboBox1.ListColumns[i].AutoWidth = true;
        }

    }

    private void GetShortcutList(ShortcutCollection sc)
    {
        // コントロールのショートカットを取得
        gcListBox1.Items.Clear();
        foreach (var k in sc.Keys)
        {
            gcListBox1.Items.Add(new ListItem(new string[] { k.ToString(), "" }));
        }
        var i = 0;
        foreach (var mi in sc.Values)
        {
            gcListBox1.Items[i].SubItems[1].Value = mi.Method.Name;
            i += 1;
        }
    }

    private void AddShortcutKey()
    {
        // キー取得
        var selectedKey = GetKeys().FirstOrDefault();
        // コントロール取得
        var ctrl = GetSelectControl();

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
        GetShortcutList(gcShortcut1.GetShortcuts(ctrl));
        gcListBox1.SelectedIndex = gcListBox1.FindStringExact(gcComboBox3.Text, -1, 0);
        button1.Enabled = false;
        button2.Enabled = true;
    }

    private void DeleteShortcutKey()
    {
        // キー取得
        var selectedKey = GetKeys().FirstOrDefault();
        // コントロール取得
        var ctrl = GetSelectControl();

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

    private IEnumerable<Keys> GetKeys()
    {
        // キー取得
        foreach (Keys keyval in Enum.GetValues(typeof(Keys)))
        {
            if (keyval.ToString() != gcComboBox3.Text) continue;

            yield return keyval;
        }
    }

    private Control GetSelectControl() => gcComboBox2.SelectedIndex switch
    {
        // テキストコントロール
        0 => gcTextBox1,
        // マスクコントロール
        1 => gcMask1,
        // キャラクタボックスコントロール
        2 => gcCharMask1,
        // 日付時刻コントロール
        3 => gcDateTime1,
        // 日付コントロール
        4 => gcDate1,
        // 時刻コントロール
        5 => gcTime1,
        // タイムスパンコントロール
        6 => gcTimeSpan1,
        // 数値コントロール
        7 => gcNumber1,
        // コンボコントロール
        8 => gcComboBox1,
        // マスクコンボコントロール
        9 => gcMaskedComboBox1,
        _ => null
    };

    private void ChangeTargetControl()
    {
        // 追加対象コントロールの変更
        var shortcut = GetShortcut();
        if (shortcut.HasValue)
        {
            GetShortcutList(gcShortcut1.GetShortcuts(shortcut.Value.Item1));
        }
        gcComboBox4.DataSource = GetDataView(shortcut.GetValueOrDefault().Item2);

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

    private (Control, string)? GetShortcut() => gcComboBox2.SelectedIndex switch
    {
        // テキストコントロール
        0 => (gcTextBox1, "gcTextBoxflg = 'true'"),
        // マスクコントロール
        1 => (gcMask1, "gcMaskflg = 'true'"),
        // キャラクタボックスコントロール
        2 => (gcCharMask1, "gcCharMaskflg = 'true'"),
        // 日付時刻コントロール
        3 => (gcDateTime1, "gcDateTimeflg = 'true'"),
        // 日付コントロール
        4 => (gcDate1, "gcDateflg = 'true'"),
        // 時刻コントロール
        5 => (gcTime1, "gcTimeflg = 'true'"),
        // タイムスパンコントロール
        6 => (gcTimeSpan1, "gcTimeSpanflg = 'true'"),
        // 数値コントロール
        7 => (gcNumber1, "gcNumberflg = 'true'"),
        // コンボコントロール
        8 => (gcComboBox1, "gcComboBoxflg = 'true'"),
        // マスクコンボコントロール
        9 => (gcMaskedComboBox1, "gcMaskedComboBoxflg = 'true'"),
        _ => null
    };

    private DataView GetDataView(string filter) => string.IsNullOrEmpty(filter)
            ? new DataView(dataSet1.Tables[0])
            : new DataView(dataSet1.Tables[0]) { RowFilter = filter };

    private void ChangeAssignKey()
    {
        // 割り当てキーの変更
        gcListBox1.SelectedIndex = gcListBox1.FindStringExact(gcComboBox3.Text, -1, 0);

        var enable = gcListBox1.FindStringExact(gcComboBox3.Text, -1, 0) == -1;
        button1.Enabled = enable;
        button2.Enabled = !enable;
    }

    private void SetSelectIndex()
    {
        if (gcListBox1.SelectedItem == null) return;

        gcComboBox3.SelectedIndex = gcComboBox3.FindStringExact(gcListBox1.SelectedItem.Text, -1, 0);
        gcComboBox4.SelectedIndex = gcComboBox4.FindStringExact(gcListBox1.SelectedValue.ToString(), -1, 0);
    }
}
