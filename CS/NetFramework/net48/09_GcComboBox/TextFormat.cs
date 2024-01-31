using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace InputManWin12_Demo._09_GcComboBox
{
    public partial class TextFormat : InputManWin12_Demo.DemoBase_settings
    {
        public TextFormat()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            gcComboBox2.SelectedIndexChanged += new EventHandler(gcComboBox2_SelectedIndexChanged);
            gcTextBox1.Validating += new CancelEventHandler(gcTextBox1_Validating);

            // xmlファイルからショートカット機能一覧取得
            System.String filePath = Application.StartupPath;
            this.dataSet1.ReadXml(filePath + "\\Resources\\XMLDataFile.xml");
            gcComboBox1.DataSource = dataSet1.Tables[0];

            // ***** 初期値
            gcComboBox1.TextFormat = gcTextBox1.Text;

            for (int i = 0; i < gcComboBox1.ListColumns.Count; i++)
            {
                gcComboBox1.ListColumns[i].AutoWidth = true;
                gcComboBox1.ListColumns[i].Header.Image = 0;
            }
            gcComboBox1.DropDown.Direction = GrapeCity.Win.Editors.DropDownDirection.BelowLeft;
        }

        private void gcComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TextSubItemIndexプロパティ
            gcComboBox1.TextSubItemIndex = gcComboBox2.SelectedIndex;
        }

        private void gcTextBox1_Validating(object sender, CancelEventArgs e)
        {
            // TextFormatプロパティ
            try
            {
                gcComboBox1.TextFormat = gcTextBox1.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "書式設定エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
    }
}
