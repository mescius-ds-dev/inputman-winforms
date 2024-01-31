using System;
using System.Windows.Forms;
using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._02_Format
{
    public partial class GcCharMask : InputManWin12_Demo.DemoBase_settings
    {
        public GcCharMask()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            gcComboBox1.SelectedIndexChanged += new EventHandler(gcComboBox1_SelectedIndexChanged);
            gcComboBox2.SelectedIndexChanged += new EventHandler(gcComboBox2_SelectedIndexChanged);
            gcListBox1.ItemCheck += new ItemCheckEventHandler(gcListBox1_ItemCheck);
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            gcComboBox3.SelectedIndexChanged += new EventHandler(gcComboBox3_SelectedIndexChanged);
            gcComboBox4.SelectedIndexChanged += new EventHandler(gcComboBox4_SelectedIndexChanged);
            checkBox2.CheckedChanged += new EventHandler(checkBox2_CheckedChanged);

            // ***** 初期値
            gcComboBox1.SelectedIndex = Convert.ToInt32(gcCharMask1.InputDirection);
            gcComboBox2.SelectedIndex = Convert.ToInt32(gcCharMask1.EditMode);
            checkBox1.Checked = gcCharMask1.AutoConvert;
            gcComboBox3.SelectedIndex = Convert.ToInt32(gcCharMask1.AllowSpace);
            gcComboBox4.SelectedIndex = Convert.ToInt32(gcCharMask1.AcceptsCrLf);
            checkBox2.Checked = gcCharMask1.HighlightText;
        }

        private void gcComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // InputDirectionプロパティ
            gcCharMask1.InputDirection = (CharMaskInputDirection)gcComboBox1.SelectedIndex;

        }

        private void gcComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // EditModeプロパティ
            gcCharMask1.EditMode = (EditMode)gcComboBox2.SelectedIndex;
        }

        private void gcListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Formatプロパティ
            string formatVal = string.Empty;
            for (Int16 i = 0; i < gcListBox1.Items.Count; i++)
            {
                if (i == e.Index)
                {
                    if (e.NewValue == CheckState.Checked)
                    {
                        formatVal += gcListBox1.Items[e.Index].Text;
                    }
                }
                else
                {
                    if (gcListBox1.Items[i].Checked)
                    {
                        formatVal += gcListBox1.Items[i].Text;
                    }
                }
            }
            gcCharMask1.Format = formatVal;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // AutoConvertプロパティ
            gcCharMask1.AutoConvert = checkBox1.Checked;
        }

        private void gcComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // AllowSpaceプロパティ
            gcCharMask1.AllowSpace = (AllowSpace)gcComboBox3.SelectedIndex;
        }

        private void gcComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // AcceptsCrLfプロパティ
            gcCharMask1.AcceptsCrLf = (CrLfMode)gcComboBox4.SelectedIndex;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // HighlightTextプロパティ
            gcCharMask1.SelectionLength = 0;
            gcCharMask1.HighlightText = checkBox2.Checked;
        }
    }
}