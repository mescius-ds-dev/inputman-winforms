using System;
using System.Windows.Forms;

namespace InputManWin12_Demo._13_Touch
{
    public partial class Gripper : InputManWin12_Demo.DemoBase_settings
    {
        public Gripper()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
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

            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
        }

        void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // ShowGrippersプロパティ
            gcTextBox1.ShowGrippers = checkBox1.Checked;
            gcMask1.ShowGrippers = checkBox1.Checked;
            gcCharMask1.ShowGrippers = checkBox1.Checked;
            gcDateTime1.ShowGrippers = checkBox1.Checked;
            gcDate1.ShowGrippers = checkBox1.Checked;
            gcTime1.ShowGrippers = checkBox1.Checked;
            gcTimeSpan1.ShowGrippers = checkBox1.Checked;
            gcNumber1.ShowGrippers = checkBox1.Checked;
            gcComboBox1.ShowGrippers = checkBox1.Checked;
            gcMaskedComboBox1.ShowGrippers = checkBox1.Checked;
        }
    }
}
