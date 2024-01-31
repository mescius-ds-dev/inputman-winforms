using System;
using System.Windows.Forms;

namespace InputManWin12_Demo._08_SideButton
{
    public partial class DropDownButton : InputManWin12_Demo.DemoBase_settings
    {
        public DropDownButton()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            gcComboBox2.SelectedIndexChanged += new EventHandler(gcComboBox2_SelectedIndexChanged);
            gcComboBox3.SelectedIndexChanged += new EventHandler(gcComboBox3_SelectedIndexChanged);
            gcColorPicker1.SelectedIndexChanged += new EventHandler(gcColorPicker1_SelectedIndexChanged);
            gcColorPicker2.SelectedIndexChanged += new EventHandler(gcColorPicker2_SelectedIndexChanged);
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            checkBox2.CheckedChanged += new EventHandler(checkBox2_CheckedChanged);

            // ***** 初期値
            gcComboBox2.SelectedIndex = Convert.ToInt32(gcTextBox1.FlatStyle);
            gcComboBox3.SelectedIndex = Convert.ToInt32(gcTextBox1.SideButtons[0].Position);
            checkBox1.Checked = ((GrapeCity.Win.Editors.DropDownButton)gcTextBox1.SideButtons[0]).IsDefaultBehavior;
            checkBox2.Checked = gcDateTime1.DropDownCalendar.NavigateOnWheel;

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
            // FlatStyleプロパティ
            gcTextBox1.FlatStyle = (GrapeCity.Win.Editors.FlatStyleEx)gcComboBox2.SelectedIndex;
            gcDateTime1.FlatStyle = (GrapeCity.Win.Editors.FlatStyleEx)gcComboBox2.SelectedIndex;
            gcDate1.FlatStyle = (GrapeCity.Win.Editors.FlatStyleEx)gcComboBox2.SelectedIndex;
            gcTime1.FlatStyle = (GrapeCity.Win.Editors.FlatStyleEx)gcComboBox2.SelectedIndex;
            gcNumber1.FlatStyle = (GrapeCity.Win.Editors.FlatStyleEx)gcComboBox2.SelectedIndex;
            gcComboBox1.FlatStyle = (GrapeCity.Win.Editors.FlatStyleEx)gcComboBox2.SelectedIndex;
            gcMaskedComboBox1.FlatStyle = (GrapeCity.Win.Editors.FlatStyleEx)gcComboBox2.SelectedIndex;
        }

        private void gcComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // サイドボタンの位置
            gcTextBox1.SideButtons[0].Position = (GrapeCity.Win.Editors.ButtonPosition)gcComboBox3.SelectedIndex;
            gcDateTime1.SideButtons[0].Position = (GrapeCity.Win.Editors.ButtonPosition)gcComboBox3.SelectedIndex;
            gcDate1.SideButtons[0].Position = (GrapeCity.Win.Editors.ButtonPosition)gcComboBox3.SelectedIndex;
            gcTime1.SideButtons[0].Position = (GrapeCity.Win.Editors.ButtonPosition)gcComboBox3.SelectedIndex;
            gcNumber1.SideButtons[0].Position = (GrapeCity.Win.Editors.ButtonPosition)gcComboBox3.SelectedIndex;
            gcComboBox1.SideButtons[0].Position = (GrapeCity.Win.Editors.ButtonPosition)gcComboBox3.SelectedIndex;
            gcMaskedComboBox1.SideButtons[0].Position = (GrapeCity.Win.Editors.ButtonPosition)gcComboBox3.SelectedIndex;
        }

        private void gcColorPicker1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // サイドボタンの前景色
            gcTextBox1.SideButtons[0].ForeColor = gcColorPicker1.SelectedColor;
            gcDateTime1.SideButtons[0].ForeColor = gcColorPicker1.SelectedColor;
            gcDate1.SideButtons[0].ForeColor = gcColorPicker1.SelectedColor;
            gcTime1.SideButtons[0].ForeColor = gcColorPicker1.SelectedColor;
            gcNumber1.SideButtons[0].ForeColor = gcColorPicker1.SelectedColor;
            gcComboBox1.SideButtons[0].ForeColor = gcColorPicker1.SelectedColor;
            gcMaskedComboBox1.SideButtons[0].ForeColor = gcColorPicker1.SelectedColor;
        }

        private void gcColorPicker2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // サイドボタンの背景色
            gcTextBox1.SideButtons[0].BackColor = gcColorPicker2.SelectedColor;
            gcDateTime1.SideButtons[0].BackColor = gcColorPicker2.SelectedColor;
            gcDate1.SideButtons[0].BackColor = gcColorPicker2.SelectedColor;
            gcTime1.SideButtons[0].BackColor = gcColorPicker2.SelectedColor;
            gcNumber1.SideButtons[0].BackColor = gcColorPicker2.SelectedColor;
            gcComboBox1.SideButtons[0].BackColor = gcColorPicker2.SelectedColor;
            gcMaskedComboBox1.SideButtons[0].BackColor = gcColorPicker2.SelectedColor;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // ドロップダウンの既定機能
            ((GrapeCity.Win.Editors.DropDownButton)gcTextBox1.SideButtons[0]).IsDefaultBehavior = checkBox1.Checked;
            ((GrapeCity.Win.Editors.DropDownButton)gcDateTime1.SideButtons[0]).IsDefaultBehavior = checkBox1.Checked;
            ((GrapeCity.Win.Editors.DropDownButton)gcDate1.SideButtons[0]).IsDefaultBehavior = checkBox1.Checked;
            ((GrapeCity.Win.Editors.DropDownButton)gcTime1.SideButtons[0]).IsDefaultBehavior = checkBox1.Checked;
            ((GrapeCity.Win.Editors.DropDownButton)gcNumber1.SideButtons[0]).IsDefaultBehavior = checkBox1.Checked;
            ((GrapeCity.Win.Editors.DropDownButton)gcComboBox1.SideButtons[0]).IsDefaultBehavior = checkBox1.Checked;
            ((GrapeCity.Win.Editors.DropDownButton)gcMaskedComboBox1.SideButtons[0]).IsDefaultBehavior = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // NavigateOnWheelプロパティ
            gcDateTime1.DropDownCalendar.NavigateOnWheel = checkBox2.Checked;
            gcDate1.DropDownCalendar.NavigateOnWheel = checkBox2.Checked;
        }
    }
}
