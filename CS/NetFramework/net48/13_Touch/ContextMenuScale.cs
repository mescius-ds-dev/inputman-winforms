using System;
using System.Windows.Forms;

namespace InputManWin12_Demo._13_Touch
{
    public partial class ContextMenuScale : InputManWin12_Demo.DemoBase_settings
    {
        public ContextMenuScale()
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


            gcNumber2.ValueChanged += new EventHandler(gcNumber2_ValueChanged);
        }

        void gcNumber2_ValueChanged(object sender, EventArgs e)
        {
            // TouchContextMenuScaleプロパティ
            gcTextBox1.TouchContextMenuScale = (float)gcNumber2.Value;
            gcMask1.TouchContextMenuScale = (float)gcNumber2.Value;
            gcCharMask1.TouchContextMenuScale = (float)gcNumber2.Value;
            gcDateTime1.TouchContextMenuScale = (float)gcNumber2.Value;
            gcDate1.TouchContextMenuScale = (float)gcNumber2.Value;
            gcTime1.TouchContextMenuScale = (float)gcNumber2.Value;
            gcTimeSpan1.TouchContextMenuScale = (float)gcNumber2.Value;
            gcNumber1.TouchContextMenuScale = (float)gcNumber2.Value;
            gcComboBox1.TouchContextMenuScale = (float)gcNumber2.Value;
            gcMaskedComboBox1.TouchContextMenuScale = (float)gcNumber2.Value;
        }
    }
}
