using System;
using System.Windows.Forms;
using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._03_Focus
{
    public partial class Enter : InputManWin12_Demo.DemoBase_settings
    {
        public Enter()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            checkBox2.CheckedChanged += new EventHandler(checkBox2_CheckedChanged);
            gcComboBox2.SelectedIndexChanged += new EventHandler(gcComboBox2_SelectedIndexChanged);
            checkBox3.CheckedChanged += new EventHandler(checkBox3_CheckedChanged);

            // ***** 初期値
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            gcComboBox2.SelectedIndex = 3;
            checkBox3.Checked = true;

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
            // Enterキー動作の設定
            gcShortcut1.GetShortcuts(gcTextBox1).Remove(Keys.Return);
            gcShortcut1.GetShortcuts(gcMask1).Remove(Keys.Return);
            gcShortcut1.GetShortcuts(gcCharMask1).Remove(Keys.Return);
            gcShortcut1.GetShortcuts(gcDateTime1).Remove(Keys.Return);
            gcShortcut1.GetShortcuts(gcDate1).Remove(Keys.Return);
            gcShortcut1.GetShortcuts(gcTime1).Remove(Keys.Return);
            gcShortcut1.GetShortcuts(gcTimeSpan1).Remove(Keys.Return);
            gcShortcut1.GetShortcuts(gcNumber1).Remove(Keys.Return);
            gcShortcut1.GetShortcuts(gcComboBox1).Remove(Keys.Return);
            gcShortcut1.GetShortcuts(gcMaskedComboBox1).Remove(Keys.Return);

            if (checkBox1.Checked)
            {
                gcShortcut1.GetShortcuts(gcTextBox1).Add(Keys.Return, gcShortcut1, "NextControl");
                gcShortcut1.GetShortcuts(gcMask1).Add(Keys.Return, gcShortcut1, "NextControl");
                gcShortcut1.GetShortcuts(gcCharMask1).Add(Keys.Return, gcShortcut1, "NextControl");
                gcShortcut1.GetShortcuts(gcDateTime1).Add(Keys.Return, gcShortcut1, "NextControl");
                gcShortcut1.GetShortcuts(gcDate1).Add(Keys.Return, gcShortcut1, "NextControl");
                gcShortcut1.GetShortcuts(gcTime1).Add(Keys.Return, gcShortcut1, "NextControl");
                gcShortcut1.GetShortcuts(gcTimeSpan1).Add(Keys.Return, gcShortcut1, "NextControl");
                gcShortcut1.GetShortcuts(gcNumber1).Add(Keys.Return, gcShortcut1, "NextControl");
                gcShortcut1.GetShortcuts(gcComboBox1).Add(Keys.Return, gcShortcut1, "NextControl");
                gcShortcut1.GetShortcuts(gcMaskedComboBox1).Add(Keys.Return, gcShortcut1, "NextControl");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // ExitOnLastCharプロパティ
            gcTextBox1.ExitOnLastChar = checkBox2.Checked;
            gcMask1.ExitOnLastChar = checkBox2.Checked;
            gcCharMask1.ExitOnLastChar = checkBox2.Checked;
            gcDateTime1.ExitOnLastChar = checkBox2.Checked;
            gcDate1.ExitOnLastChar = checkBox2.Checked;
            gcTime1.ExitOnLastChar = checkBox2.Checked;
            gcTimeSpan1.ExitOnLastChar = checkBox2.Checked;
            gcNumber1.ExitOnLastChar = checkBox2.Checked;
            gcComboBox1.ExitOnLastChar = checkBox2.Checked;
            gcMaskedComboBox1.ExitOnLastChar = checkBox2.Checked;
        }

        private void gcComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            setLeftRight();
        }

        private void setLeftRight()
        {
            // ExitOnLeftRightKeyプロパティ
            gcTextBox1.ExitOnLeftRightKey = (ExitOnLeftRightKey)gcComboBox2.SelectedIndex;
            gcMask1.ExitOnLeftRightKey = (ExitOnLeftRightKey)gcComboBox2.SelectedIndex;
            gcCharMask1.ExitOnLeftRightKey = (ExitOnLeftRightKey)gcComboBox2.SelectedIndex;
            gcDateTime1.ExitOnLeftRightKey = (ExitOnLeftRightKey)gcComboBox2.SelectedIndex;
            gcDate1.ExitOnLeftRightKey = (ExitOnLeftRightKey)gcComboBox2.SelectedIndex;
            gcTime1.ExitOnLeftRightKey = (ExitOnLeftRightKey)gcComboBox2.SelectedIndex;
            gcTimeSpan1.ExitOnLeftRightKey = (ExitOnLeftRightKey)gcComboBox2.SelectedIndex;
            gcNumber1.ExitOnLeftRightKey = (ExitOnLeftRightKey)gcComboBox2.SelectedIndex;
            gcComboBox1.ExitOnLeftRightKey = (ExitOnLeftRightKey)gcComboBox2.SelectedIndex;
            gcMaskedComboBox1.ExitOnLeftRightKey = (ExitOnLeftRightKey)gcComboBox2.SelectedIndex;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            gcMask1.AutoMoveToNextField = checkBox3.Checked;
            gcDateTime1.AutoMoveToNextField = checkBox3.Checked;
            gcDate1.AutoMoveToNextField = checkBox3.Checked;
            gcTime1.AutoMoveToNextField = checkBox3.Checked;
            gcTimeSpan1.AutoMoveToNextField = checkBox3.Checked;
            gcMaskedComboBox1.AutoMoveToNextField = checkBox3.Checked;
        }
    }
}
