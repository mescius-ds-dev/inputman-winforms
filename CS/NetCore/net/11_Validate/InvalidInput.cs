namespace InputManWin12_Demo._11_Validate;

public partial class InvalidInput : InputManWin12_Demo.DemoBase_settings
{
    public InvalidInput()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定
        gcTextBox1.InvalidInput += (s, e) => AddInvalidInputEventArgs("テキストコントロール", e);
        gcMask1.InvalidInput += (s, e) => AddInvalidInputEventArgs("マスクコントロール", e);
        gcCharMask1.InvalidInput += (s, e) => AddInvalidInputEventArgs("キャラクタボックスコントロール", e);
        gcDateTime1.InvalidInput += (s, e) => AddInvalidInputEventArgs("日付時刻コントロール", e);
        gcDate1.InvalidInput += (s, e) => AddInvalidInputEventArgs("日付コントロール", e);
        gcTime1.InvalidInput += (s, e) => AddInvalidInputEventArgs("時刻コントロール", e);
        gcTimeSpan1.InvalidInput += (s, e) => AddInvalidInputEventArgs("タイムスパンコントロール", e);
        gcNumber1.InvalidInput += (s, e) => AddInvalidInputEventArgs("数値コントロール", e);
        gcComboBox1.InvalidInput += (s, e) => AddInvalidInputEventArgs("コンボコントロール", e);
        gcMaskedComboBox1.InvalidInput += (s, e) => AddInvalidInputEventArgs("マスクコンボコントロール", e);
        button1.Click += (s, e) => gcListBox1.Items.Clear();

        // ***** 初期値
        // xmlファイルからデータ取得
        this.dataSet1.ReadXml(Path.Combine(Application.StartupPath, @"Resources\prefecture.xml"));
        gcComboBox1.DataSource = dataSet1.Tables[0];
        gcComboBox1.SelectedIndex = -1;

        for (int i = 1; i < gcComboBox1.ListColumns.Count; i++)
        {
            gcComboBox1.ListColumns[i].AutoWidth = true;
        }

        // xmlファイルからデータ取得（gcMaskedComboBox）
        this.dataSet2.ReadXml(Path.Combine(Application.StartupPath, @"Resources\pref.xml"));
        gcMaskedComboBox1.DataSource = dataSet2.Tables[0];
        gcMaskedComboBox1.SelectedIndex = -1;

        for (int i = 1; i < gcMaskedComboBox1.ListColumns.Count; i++)
        {
            gcMaskedComboBox1.ListColumns[i].AutoWidth = true;
        }
    }

    private void AddInvalidInputEventArgs(string str, EventArgs e)
    {
        if (e is not GrapeCity.Win.Editors.InvalidInputEventArgs invalidInputEventArgs)
        {
            return;
        }

        // 入力された値が設定された書式に対して無効かどうか 
        if (invalidInputEventArgs.HasInvalidChar)
        {
            gcListBox1.Items.Add(str + " に入力された値は設定された書式に対して無効です。");
        }

        // 入力された値が設定された最大文字数を超えているかどうか 
        if (invalidInputEventArgs.MeetsLengthLimit)
        {
            gcListBox1.Items.Add(str + " に入力された値は設定された最大文字数を超えています。");
        }

        // 入力された値が設定された最大値よりも大きいかどうか 
        if (invalidInputEventArgs.ExceedMaxValue)
        {
            gcListBox1.Items.Add(str + " に入力された値は設定された最大値よりも大きい値です。");
        }

        // 入力された値が設定された最小値よりも小さいかどうか 
        if (invalidInputEventArgs.BelowMinValue)
        {
            gcListBox1.Items.Add(str + " に入力された値は設定された最小値よりも小さい値です。");
        }

        gcListBox1.SelectedIndex = gcListBox1.Items.Count - 1;
    }
}