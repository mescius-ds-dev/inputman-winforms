using System;
using System.Windows.Forms;

namespace InputManWin12_Demo._01_Controls
{
    public partial class Controls : InputManWin12_Demo.DemoBase
    {
        public Controls()
        {
            InitializeComponent();
            InitializeForm();

        }
        private void InitializeForm()
        {
            // ***** 初期設定

            // xmlファイルからデータ取得（gcMaskedComboBox）
            System.String filePath = Application.StartupPath;
            this.dataSet1.ReadXml(filePath + "\\Resources\\pref.xml");
            gcMaskedComboBox1.DataSource = dataSet1.Tables[0];
            gcMaskedComboBox1.SelectedIndex = -1;

            for (int i = 1; i < gcMaskedComboBox1.ListColumns.Count; i++)
            {
                gcMaskedComboBox1.ListColumns[i].AutoWidth = true;
            }
        }

    }
}
