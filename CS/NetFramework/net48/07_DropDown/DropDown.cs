using System;
using System.Windows.Forms;
using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._07_DropDown
{
    public partial class DropDown : InputManWin12_Demo.DemoBase_settings
    {
        public DropDown()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            gcComboBox2.SelectedIndexChanged += new EventHandler(gcComboBox2_SelectedIndexChanged);
            gcComboBox3.SelectedIndexChanged += new EventHandler(gcComboBox3_SelectedIndexChanged);
            gcComboBox4.SelectedIndexChanged += new EventHandler(gcComboBox4_SelectedIndexChanged);
            gcComboBox5.SelectedIndexChanged += new EventHandler(gcComboBox5_SelectedIndexChanged);
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            checkBox2.CheckedChanged += new EventHandler(checkBox2_CheckedChanged);
            checkBox3.CheckedChanged += new EventHandler(checkBox3_CheckedChanged);

            // ***** 初期値
            gcComboBox2.SelectedIndex = 6;
            gcComboBox3.SelectedIndex = Convert.ToInt32(gcTextBox1.DropDown.OpeningAnimation);
            gcComboBox4.SelectedIndex = Convert.ToInt32(gcTextBox1.DropDown.ClosingAnimation);
            gcComboBox5.SelectedIndex = 0;
            gcDateTime1.Value = DateTime.Now;
            gcDate1.Value = DateTime.Now;

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

        private void gcComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 表示方向
            if (gcComboBox2.SelectedIndex == 6)
            {
                gcTextBox1.DropDown.Direction = DropDownDirection.Default;
                gcDateTime1.DropDown.Direction = DropDownDirection.Default;
                gcDate1.DropDown.Direction = DropDownDirection.Default;
                gcTime1.DropDown.Direction = DropDownDirection.Default;
                gcNumber1.DropDown.Direction = DropDownDirection.Default;
                gcComboBox1.DropDown.Direction = DropDownDirection.Default;
                gcMaskedComboBox1.DropDown.Direction = DropDownDirection.Default;
            }
            else
            {
                gcTextBox1.DropDown.Direction = (DropDownDirection)gcComboBox2.SelectedIndex;
                gcDateTime1.DropDown.Direction = (DropDownDirection)gcComboBox2.SelectedIndex;
                gcDate1.DropDown.Direction = (DropDownDirection)gcComboBox2.SelectedIndex;
                gcTime1.DropDown.Direction = (DropDownDirection)gcComboBox2.SelectedIndex;
                gcNumber1.DropDown.Direction = (DropDownDirection)gcComboBox2.SelectedIndex;
                gcComboBox1.DropDown.Direction = (DropDownDirection)gcComboBox2.SelectedIndex;
                gcMaskedComboBox1.DropDown.Direction = (DropDownDirection)gcComboBox2.SelectedIndex;
            }
        }

        private void gcComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 開くときのアニメーション
            gcTextBox1.DropDown.OpeningAnimation = (DropDownAnimation)gcComboBox3.SelectedIndex;
            gcDateTime1.DropDown.OpeningAnimation = (DropDownAnimation)gcComboBox3.SelectedIndex;
            gcDate1.DropDown.OpeningAnimation = (DropDownAnimation)gcComboBox3.SelectedIndex;
            gcTime1.DropDown.OpeningAnimation = (DropDownAnimation)gcComboBox3.SelectedIndex;
            gcNumber1.DropDown.OpeningAnimation = (DropDownAnimation)gcComboBox3.SelectedIndex;
            gcComboBox1.DropDown.OpeningAnimation = (DropDownAnimation)gcComboBox3.SelectedIndex;
            gcMaskedComboBox1.DropDown.OpeningAnimation = (DropDownAnimation)gcComboBox3.SelectedIndex;
        }

        private void gcComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 閉じるときのアニメーション
            gcTextBox1.DropDown.ClosingAnimation = (DropDownAnimation)gcComboBox4.SelectedIndex;
            gcDateTime1.DropDown.ClosingAnimation = (DropDownAnimation)gcComboBox4.SelectedIndex;
            gcDate1.DropDown.ClosingAnimation = (DropDownAnimation)gcComboBox4.SelectedIndex;
            gcTime1.DropDown.ClosingAnimation = (DropDownAnimation)gcComboBox4.SelectedIndex;
            gcNumber1.DropDown.ClosingAnimation = (DropDownAnimation)gcComboBox4.SelectedIndex;
            gcComboBox1.DropDown.ClosingAnimation = (DropDownAnimation)gcComboBox4.SelectedIndex;
            gcMaskedComboBox1.DropDown.ClosingAnimation = (DropDownAnimation)gcComboBox4.SelectedIndex;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // ShowShadowプロパティ
            gcTextBox1.DropDown.ShowShadow = checkBox1.Checked;
            gcDateTime1.DropDown.ShowShadow = checkBox1.Checked;
            gcDate1.DropDown.ShowShadow = checkBox1.Checked;
            gcTime1.DropDown.ShowShadow = checkBox1.Checked;
            gcNumber1.DropDown.ShowShadow = checkBox1.Checked;
            gcComboBox1.DropDown.ShowShadow = checkBox1.Checked;
            gcMaskedComboBox1.DropDown.ShowShadow = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // AutoDropDownプロパティ
            gcTextBox1.DropDown.AutoDropDown = checkBox2.Checked;
            gcDateTime1.DropDown.AutoDropDown = checkBox2.Checked;
            gcDate1.DropDown.AutoDropDown = checkBox2.Checked;
            gcTime1.DropDown.AutoDropDown = checkBox2.Checked;
            gcNumber1.DropDown.AutoDropDown = checkBox2.Checked;
            gcComboBox1.DropDown.AutoDropDown = checkBox2.Checked;
            gcMaskedComboBox1.DropDown.AutoDropDown = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            // AllowDropプロパティ
            gcTextBox1.DropDown.AllowDrop = !checkBox3.Checked;
            gcDateTime1.DropDown.AllowDrop = !checkBox3.Checked;
            gcDate1.DropDown.AllowDrop = !checkBox3.Checked;
            gcTime1.DropDown.AllowDrop = !checkBox3.Checked;
            gcNumber1.DropDown.AllowDrop = !checkBox3.Checked;
            gcComboBox1.DropDown.AllowDrop = !checkBox3.Checked;
            gcMaskedComboBox1.DropDown.AllowDrop = !checkBox3.Checked;
        }

        private void gcComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            // DropDownTypeプロパティ
            gcDateTime1.DropDown.DropDownType = (DateDropDownType)gcComboBox5.SelectedIndex;
            gcDate1.DropDown.DropDownType = (DateDropDownType)gcComboBox5.SelectedIndex;
        }
    }
}
