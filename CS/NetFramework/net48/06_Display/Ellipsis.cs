using System;

namespace InputManWin12_Demo._06_Display
{
    public partial class Ellipsis : InputManWin12_Demo.DemoBase_settings
    {
        public Ellipsis()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            gcComboBox1.SelectedIndexChanged += new EventHandler(gcComboBox1_SelectedIndexChanged);
            gcTextBox2.TextChanged += new EventHandler(gcTextBox2_TextChanged);
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            checkBox2.CheckedChanged += new EventHandler(checkBox2_CheckedChanged);

            // ***** 初期値
            gcComboBox1.SelectedIndex = Convert.ToInt32(gcTextBox1.Ellipsis);
            gcTextBox2.Text = gcTextBox1.EllipsisString;
            checkBox1.Checked = gcComboBox2.ListColumns[0].Header.Ellipsis;

            gcComboBox2.ShowOverflowTip = false;
            gcComboBox2.DropDown.Width = gcComboBox2.Width;
            gcComboBox2.ListColumns[0].Width = gcComboBox2.Width;
        }

        private void gcComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ellipsisプロパティ
            gcTextBox1.Ellipsis = (GrapeCity.Win.Editors.EllipsisMode)gcComboBox1.SelectedIndex;
            gcTextBox3.Ellipsis = (GrapeCity.Win.Editors.EllipsisMode)gcComboBox1.SelectedIndex;
            gcComboBox2.Ellipsis = (GrapeCity.Win.Editors.EllipsisMode)gcComboBox1.SelectedIndex;
        }

        private void gcTextBox2_TextChanged(object sender, EventArgs e)
        {
            // EllipsisStringプロパティ
            gcTextBox1.EllipsisString = gcTextBox2.Text;
            gcTextBox3.EllipsisString = gcTextBox2.Text;
            gcComboBox2.EllipsisString = gcTextBox2.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // ヘッダの省略文字
            gcComboBox2.ListColumns[0].Header.Ellipsis = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // ヘッダの省略文字
            for (int i = 0; i < gcComboBox2.Items.Count; i++)
            {
                gcComboBox2.Items[i].SubItems[0].Ellipsis = checkBox2.Checked;
            }

        }
    }
}
