using System;
using System.Windows.Forms;

namespace InputManWin12_Demo._08_SideButton
{
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
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            sideButton1.Click += new EventHandler(sideButton1_Click);
            sideButton2.Click += new EventHandler(sideButton2_Click);
            sideButton3.Click += new EventHandler(sideButton3_Click);
            sideButton4.Click += new EventHandler(sideButton4_Click);
            sideButton5.Click += new EventHandler(sideButton5_Click);
            sideButton6.Click += new EventHandler(sideButton6_Click);
            sideButton7.Click += new EventHandler(sideButton7_Click);
            sideButton8.Click += new EventHandler(sideButton8_Click);
            sideButton9.Click += new EventHandler(sideButton9_Click);
            timer1.Tick += new System.EventHandler(timer1_Tick);

            // ***** 初期値
            checkBox1.Checked = ((GrapeCity.Win.Editors.SideButton)gcTextBox1.SideButtons[0]).CheckOnClick;

            timer1.Interval = 1000;

            // xmlファイルからデータ取得
            System.String filePath = Application.StartupPath;
            this.dataSet1.ReadXml(filePath + "\\Resources\\prefecture.xml");
            gcComboBox1.DataSource = dataSet1.Tables[0];
            gcComboBox1.SelectedIndex = -1;

            for (int i = 1; i < gcComboBox1.ListColumns.Count; i++)
            {
                gcComboBox1.ListColumns[i].AutoWidth = true;
            }

            // xmlファイルからデータ取得（gcMaskedComboBox）
            this.dataSet2.ReadXml(filePath + "\\Resources\\pref.xml");
            gcMaskedComboBox1.DataSource = dataSet2.Tables[0];
            gcMaskedComboBox1.SelectedIndex = -1;

            for (int i = 1; i < gcMaskedComboBox1.ListColumns.Count; i++)
            {
                gcMaskedComboBox1.ListColumns[i].AutoWidth = true;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // CheckOnClickプロパティ
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

        private void sideButton1_Click(object sender, EventArgs e)
        {
            // テキストコントロールのサイドボタン
            MessageBox.Show("正解はTrueです！", "メッセージ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sideButton2_Click(object sender, EventArgs e)
        {
            // マスクコントロールのサイドボタン
            MessageBox.Show("ここに住所検索処理を入れることができます");
        }

        private void sideButton3_Click(object sender, EventArgs e)
        {
            // 日付時刻コントロールのサイドボタン
            gcDateTime1.Value = DateTime.Now;
        }

        private void sideButton4_Click(object sender, EventArgs e)
        {
            // 日付コントロールのサイドボタン
            gcDate1.Value = DateTime.Now;
        }

        private void sideButton5_Click(object sender, EventArgs e)
        {
            // タイムスパンコントロールのサイドボタン
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            gcTimeSpan1.Value = gcTimeSpan1.Value + new TimeSpan(0, 0, 0, 1);
        }
        
        private void sideButton6_Click(object sender, EventArgs e)
        {
            // 数値コントロールのサイドボタン（下）
            if (gcNumber1.Value > 0)
            {
                gcNumber1.Value -= 1;
            }
        }

        private void sideButton7_Click(object sender, EventArgs e)
        {
            // 数値コントロールのサイドボタン（上）
            if (gcNumber1.Value < 999)
            {
                gcNumber1.Value += 1;
            }
        }

        private void sideButton8_Click(object sender, EventArgs e)
        {
            // コンボコントロールのサイドボタン
            gcComboBox1.SelectedIndex = -1;
            gcComboBox1.Clear();
        }

        private void sideButton9_Click(object sender, EventArgs e)
        {
            // マスクコンボコントロールのサイドボタン
            gcMaskedComboBox1.SelectedIndex = -1;
            gcMaskedComboBox1.Clear();
        }

    }
}
