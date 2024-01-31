namespace InputManWin12_Demo._08_SideButton;

public partial class SideButton : InputManWin12_Demo.DemoBase_settings
{
    public SideButton()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定

        // CheckOnClickプロパティ
        checkBox1.CheckedChanged += (s, e) => SetCheckOnClick();

        // テキストコントロールのサイドボタン
        sideButton1.Click += (s, e) => ShowTextSideButtonPushMessage();

        // マスクコントロールのサイドボタン
        sideButton2.Click += (s, e) => ShowMaskSideButtonPushMessage();

        // 日付時刻コントロールのサイドボタン
        sideButton3.Click += (s, e) => SetNowToDateTimeValue();

        // 日付コントロールのサイドボタン
        sideButton4.Click += (s, e) => SetNowToDateValue();

        // タイムスパンコントロールのサイドボタン
        sideButton5.Click += (s, e) => SetStartOrStop();

        // 数値コントロールのサイドボタン（下）
        sideButton6.Click += (s, e) => SetNumberDown();

        // 数値コントロールのサイドボタン（上）
        sideButton7.Click += (s, e) => SetNumberUp();

        // コンボコントロールのサイドボタン
        sideButton8.Click += (s, e) => ClearComboBox();

        // マスクコンボコントロールのサイドボタン
        sideButton9.Click += (s, e) => ClearMask();
        timer1.Tick += (s, e) => SetTickTimer();

        // ***** 初期値
        checkBox1.Checked = ((GrapeCity.Win.Editors.SideButton)gcTextBox1.SideButtons[0]).CheckOnClick;

        timer1.Interval = 1000;

        // xmlファイルからデータ取得
        this.dataSet1.ReadXml(Path.Combine(Application.StartupPath, @"Resources\\prefecture.xml"));
        gcComboBox1.DataSource = dataSet1.Tables[0];
        gcComboBox1.SelectedIndex = -1;

        for (int i = 1; i < gcComboBox1.ListColumns.Count; i++)
        {
            gcComboBox1.ListColumns[i].AutoWidth = true;
        }

        // xmlファイルからデータ取得（gcMaskedComboBox）
        this.dataSet2.ReadXml(Path.Combine(Application.StartupPath, @"Resources\\pref.xml"));
        gcMaskedComboBox1.DataSource = dataSet2.Tables[0];
        gcMaskedComboBox1.SelectedIndex = -1;

        for (int i = 1; i < gcMaskedComboBox1.ListColumns.Count; i++)
        {
            gcMaskedComboBox1.ListColumns[i].AutoWidth = true;
        }
    }

    private void SetCheckOnClick()
    {
        ((GrapeCity.Win.Editors.SideButton)gcTextBox1.SideButtons[0]).CheckOnClick = checkBox1.Checked;
        ((GrapeCity.Win.Editors.SideButton)gcMask1.SideButtons[0]).CheckOnClick = checkBox1.Checked;
        ((GrapeCity.Win.Editors.SideButton)gcDateTime1.SideButtons[0]).CheckOnClick = checkBox1.Checked;
        ((GrapeCity.Win.Editors.SideButton)gcDate1.SideButtons[0]).CheckOnClick = checkBox1.Checked;
        ((GrapeCity.Win.Editors.SideButton)gcTimeSpan1.SideButtons[0]).CheckOnClick = checkBox1.Checked;
        ((GrapeCity.Win.Editors.SideButton)gcNumber1.SideButtons[0]).CheckOnClick = checkBox1.Checked;
        ((GrapeCity.Win.Editors.SideButton)gcNumber1.SideButtons[1]).CheckOnClick = checkBox1.Checked;
        ((GrapeCity.Win.Editors.SideButton)gcComboBox1.SideButtons[0]).CheckOnClick = checkBox1.Checked;
        ((GrapeCity.Win.Editors.SideButton)gcMaskedComboBox1.SideButtons[0]).CheckOnClick = checkBox1.Checked;

        if (!checkBox1.Checked)
        {
            ((GrapeCity.Win.Editors.SideButton)gcTextBox1.SideButtons[0]).Checked = false;
            ((GrapeCity.Win.Editors.SideButton)gcMask1.SideButtons[0]).Checked = false;
            ((GrapeCity.Win.Editors.SideButton)gcDateTime1.SideButtons[0]).Checked = false;
            ((GrapeCity.Win.Editors.SideButton)gcDate1.SideButtons[0]).Checked = false;
            ((GrapeCity.Win.Editors.SideButton)gcTimeSpan1.SideButtons[0]).Checked = false;
            ((GrapeCity.Win.Editors.SideButton)gcNumber1.SideButtons[0]).Checked = false;
            ((GrapeCity.Win.Editors.SideButton)gcNumber1.SideButtons[1]).Checked = false;
            ((GrapeCity.Win.Editors.SideButton)gcComboBox1.SideButtons[0]).Checked = false;
            ((GrapeCity.Win.Editors.SideButton)gcMaskedComboBox1.SideButtons[0]).Checked = false;
        }
    }

    private static void ShowTextSideButtonPushMessage() => MessageBox.Show("正解はTrueです！", "メッセージ", MessageBoxButtons.OK, MessageBoxIcon.Information);

    private static void ShowMaskSideButtonPushMessage() => MessageBox.Show("ここに住所検索処理を入れることができます");

    private void SetNowToDateTimeValue()
    {
        gcDateTime1.Value = DateTime.Now;
    }

    private void SetNowToDateValue()
    {
        gcDate1.Value = DateTime.Now;
    }

    private void SetStartOrStop()
    {
        if (timer1.Enabled)
        {
            timer1.Enabled = false;
            sideButton5.Text = "Start";
        }
        else
        {
            timer1.Enabled = true;
            sideButton5.Text = "Stop";
            if (gcTimeSpan1.Value == null)
            {
                gcTimeSpan1.Value = new TimeSpan(0);
            }
            gcTimeSpan1.Value = gcTimeSpan1.Value + new TimeSpan(0, 0, 0, 1);
        }
    }

    private void SetNumberDown()
    {
        if (gcNumber1.Value > 0)
        {
            gcNumber1.Value -= 1;
        }
    }

    private void SetNumberUp()
    {
        if (gcNumber1.Value < 999)
        {
            gcNumber1.Value += 1;
        }
    }

    private void ClearComboBox()
    {
        gcComboBox1.SelectedIndex = -1;
        gcComboBox1.Clear();
    }

    private void ClearMask()
    {
        gcMaskedComboBox1.SelectedIndex = -1;
        gcMaskedComboBox1.Clear();
    }
    private void SetTickTimer()
    {
        gcTimeSpan1.Value = gcTimeSpan1.Value + new TimeSpan(0, 0, 0, 1);
    }
}
