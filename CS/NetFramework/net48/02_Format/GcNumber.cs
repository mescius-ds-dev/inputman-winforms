using System;
using System.Windows.Forms;
using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._02_Format
{
    public partial class GcNumber : InputManWin12_Demo.DemoBase_settings
    {
        public GcNumber()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            gcTextBox1.TextChanged += new EventHandler(Format_TextChanged);
            gcTextBox2.TextChanged += new EventHandler(Format_TextChanged);
            gcTextBox3.TextChanged += new EventHandler(Format_TextChanged);
            gcTextBox4.TextChanged += new EventHandler(Format_TextChanged);
            gcTextBox5.TextChanged += new EventHandler(DisplayFormat_TextChanged);
            gcTextBox6.TextChanged += new EventHandler(DisplayFormat_TextChanged);
            gcTextBox7.TextChanged += new EventHandler(DisplayFormat_TextChanged);
            gcTextBox8.TextChanged += new EventHandler(DisplayFormat_TextChanged);
            gcComboBox1.SelectedIndexChanged += new EventHandler(gcComboBox1_SelectedIndexChanged);
            gcComboBox2.SelectedIndexChanged += new EventHandler(gcComboBox2_SelectedIndexChanged);
            gcComboBox3.SelectedIndexChanged += new EventHandler(gcComboBox3_SelectedIndexChanged);
            gcComboBox4.SelectedIndexChanged += new EventHandler(gcComboBox4_SelectedIndexChanged);

            // ***** 初期値
            gcComboBox1.SelectedIndex = 0;
            gcComboBox2.SelectedIndex = 0;
            gcComboBox3.SelectedIndex = Convert.ToInt32(gcNumber1.AcceptsCrLf);
            gcComboBox4.SelectedIndex = 0;
        }

        private void gcComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            setFormat();
        }

        private void Format_TextChanged(object sender, EventArgs e)
        {
            setFormat();
        }

        private void setFormat()
        {
            // 入力書式の設定
            gcNumber1.Fields.SetFields(gcComboBox1.Text, gcTextBox1.Text, gcTextBox2.Text, gcTextBox3.Text, gcTextBox4.Text);
        }

        private void gcComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            setDisplayFormat();
        }

        private void DisplayFormat_TextChanged(object sender, EventArgs e)
        {
            setDisplayFormat();
        }

        private void setDisplayFormat()
        {
            // 表示書式の設定
            gcNumber1.DisplayFields.Clear();
            gcNumber1.DisplayFields.AddRange(gcComboBox4.Text, gcTextBox5.Text, gcTextBox6.Text, gcTextBox7.Text, gcTextBox8.Text);
        }

        private void gcComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // マイナスキー動作の設定
            gcShortcut1.GetShortcuts(gcNumber1).Remove(Keys.OemMinus);
            gcShortcut1.GetShortcuts(gcNumber1).Remove(Keys.Subtract);

            if (gcComboBox2.SelectedIndex == 0)
            {
                gcShortcut1.GetShortcuts(gcNumber1).Add(Keys.OemMinus, gcNumber1, "SwitchSign");
                gcShortcut1.GetShortcuts(gcNumber1).Add(Keys.Subtract, gcNumber1, "SwitchSign");
            }
        }

        private void gcComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // AcceptsCrLfプロパティ
            gcNumber1.AcceptsCrLf = (CrLfMode)gcComboBox3.SelectedIndex;
        }
    }
}
