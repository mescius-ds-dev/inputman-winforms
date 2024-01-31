using System;
using System.Windows.Forms;
using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._13_Touch
{
    public partial class TouchToolBar : InputManWin12_Demo.DemoBase_settings
    {
        public TouchToolBar()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            checkBox1.Click += new EventHandler(checkBox_Click);
            checkBox2.Click += new EventHandler(checkBox_Click);
            checkBox3.Click += new EventHandler(checkBox_Click);

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

        void checkBox_Click(object sender, EventArgs e)
        {
            int option = 0;

            if (checkBox1.Checked)
            {
                option = option | (int)TouchToolBarDisplayOptions.PressAndHold;
            }
            if (checkBox2.Checked)
            {
                option = option | (int)TouchToolBarDisplayOptions.TapSelection;
            }
            if (checkBox3.Checked)
            {
                option = option | (int)TouchToolBarDisplayOptions.TapGripper;
            }

            gcTextBox1.ShowTouchToolBar = (TouchToolBarDisplayOptions)option;
            gcMask1.ShowTouchToolBar = (TouchToolBarDisplayOptions)option;
            gcCharMask1.ShowTouchToolBar = (TouchToolBarDisplayOptions)option;
            gcDateTime1.ShowTouchToolBar = (TouchToolBarDisplayOptions)option;
            gcDate1.ShowTouchToolBar = (TouchToolBarDisplayOptions)option;
            gcTime1.ShowTouchToolBar = (TouchToolBarDisplayOptions)option;
            gcTimeSpan1.ShowTouchToolBar = (TouchToolBarDisplayOptions)option;
            gcNumber1.ShowTouchToolBar = (TouchToolBarDisplayOptions)option;
            gcComboBox1.ShowTouchToolBar = (TouchToolBarDisplayOptions)option;
            gcMaskedComboBox1.ShowTouchToolBar = (TouchToolBarDisplayOptions)option;
        }
    }
}
