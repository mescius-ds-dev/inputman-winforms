using System;
using System.Windows.Forms;

namespace InputManWin12_Demo._10_GcListBox
{
    public partial class ListMultiColumns : InputManWin12_Demo.DemoBase_settings
    {
        public ListMultiColumns()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            checkBox2.CheckedChanged += new EventHandler(checkBox2_CheckedChanged);
            checkBox3.CheckedChanged += new EventHandler(checkBox3_CheckedChanged);
            checkBox4.CheckedChanged += new EventHandler(checkBox4_CheckedChanged);
            gcComboBox1.SelectedIndexChanged += new EventHandler(gcComboBox1_SelectedIndexChanged);
            gcColorPicker1.SelectedIndexChanged += new EventHandler(gcColorPicker1_SelectedIndexChanged);
            gcColorPicker2.SelectedIndexChanged += new EventHandler(gcColorPicker2_SelectedIndexChanged);

            // xmlファイルからショートカット機能一覧取得
            System.String filePath = Application.StartupPath;
            this.dataSet1.ReadXml(filePath + "\\Resources\\XMLDataFile.xml");
            gcListBox1.DataSource = dataSet1.Tables[0];

            // ***** 初期値
            checkBox1.Checked = gcListBox1.ListHeaderPane.Visible;
            checkBox2.Checked = gcListBox1.Columns[0].Header.AllowResize;
            checkBox3.Checked = true;
            checkBox4.Checked = gcListBox1.ShowCheckBox;
            gcComboBox1.SelectedIndex = Convert.ToInt32(gcListBox1.SelectionMode);

            for (int i = 0; i < gcListBox1.Columns.Count; i++)
            {
                gcListBox1.Columns[i].AutoWidth = true;
                gcListBox1.Columns[i].Header.Image = 0;
                if (i > 3)
                {
                    gcListBox1.Columns[i].Visible = false;
                }
            }
            gcListBox1.StatusBar.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // ヘッダの表示／非表示
            gcListBox1.ListHeaderPane.Visible = checkBox1.Checked;
            checkBox2.Enabled = checkBox1.Checked;
            checkBox3.Enabled = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // ヘッダのリサイズ
            for (int i = 0; i < gcListBox1.Columns.Count; i++)
            {
                gcListBox1.Columns[i].Header.AllowResize = checkBox2.Checked;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            // ヘッダの画像の表示
            if (checkBox3.Checked)
            {
                gcListBox1.Columns[0].Header.Image = 4;
                gcListBox1.Columns[1].Header.Image = 2;
                gcListBox1.Columns[2].Header.Image = 1;
                gcListBox1.Columns[3].Header.Image = 1;
                gcListBox1.Columns[4].Header.Image = 3;
                gcListBox1.Columns[5].Header.Image = 0;
            }
            else
            {
                gcListBox1.Columns[0].Header.Image = null;
                gcListBox1.Columns[1].Header.Image = null;
                gcListBox1.Columns[2].Header.Image = null;
                gcListBox1.Columns[3].Header.Image = null;
                gcListBox1.Columns[4].Header.Image = null;
                gcListBox1.Columns[5].Header.Image = null;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            // チェックボックスの表示／非表示
            gcListBox1.ShowCheckBox = checkBox4.Checked;
        }

        private void gcComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 項目の選択状態
            gcListBox1.SelectionMode = (SelectionMode)gcComboBox1.SelectedIndex;
        }

        private void gcColorPicker1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 選択行の前景色
            gcListBox1.SelectedItemStyle.ForeColor = gcColorPicker1.SelectedColor;
        }

        private void gcColorPicker2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 選択行の背景色
            gcListBox1.SelectedItemStyle.BackColor = gcColorPicker2.SelectedColor;
        }

        private void gcComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            gcListBox1.DescriptionFormat = gcComboBox2.SelectedValue.ToString();
        }
    }
}
