using System;
using System.Windows.Forms;
using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._02_Format
{
    public partial class GcTextBox : InputManWin12_Demo.DemoBase_settings
    {
        public GcTextBox()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            gcNumber1.ValueChanged += new EventHandler(gcNumber1_ValueChanged);
            gcComboBox1.SelectedIndexChanged += new EventHandler(gcComboBox1_SelectedIndexChanged);
            gcListBox1.ItemCheck += new ItemCheckEventHandler(gcListBox1_ItemCheck);
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            gcComboBox2.SelectedIndexChanged += new EventHandler(gcComboBox2_SelectedIndexChanged);
            gcComboBox3.SelectedIndexChanged += new EventHandler(gcComboBox3_SelectedIndexChanged);
            gcComboBox4.SelectedIndexChanged += new EventHandler(gcComboBox4_SelectedIndexChanged);
            checkBox2.CheckedChanged += new EventHandler(checkBox2_CheckedChanged);

            // ***** 初期値
            gcNumber1.Value = gcTextBox1.MaxLength;
            gcComboBox1.SelectedIndex = Convert.ToInt32(gcTextBox1.MaxLengthUnit);
            checkBox1.Checked = gcTextBox1.AutoConvert;
            gcComboBox2.SelectedIndex = Convert.ToInt32(gcTextBox1.AllowSpace);
            gcComboBox3.SelectedIndex = Convert.ToInt32(gcTextBox1.AcceptsCrLf);
            gcComboBox4.SelectedIndex = Convert.ToInt32(gcTextBox1.AcceptsTabChar);
            checkBox2.Checked = gcTextBox1.HighlightText;
        }

        private void gcNumber1_ValueChanged(object sender, EventArgs e)
        {
            // MaxLenghtプロパティ
            gcTextBox1.MaxLength = Convert.ToInt32(gcNumber1.Value.Value);
        }

        private void gcComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MaxLengthUnitプロパティ
            gcTextBox1.MaxLengthUnit = (LengthUnit)gcComboBox1.SelectedIndex;
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
            gcTextBox1.Format = formatVal;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // AutoConvertプロパティ
            gcTextBox1.AutoConvert = checkBox1.Checked;
        }

        private void gcComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // AllowSpaceプロパティ
            gcTextBox1.AllowSpace = (AllowSpace)gcComboBox2.SelectedIndex;
        }

        private void gcComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // AcceptsCrLfプロパティ
            gcTextBox1.AcceptsCrLf = (CrLfMode)gcComboBox3.SelectedIndex;
        }

        private void gcComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // AcceptsTabCharプロパティ
            gcTextBox1.AcceptsTabChar = (TabCharMode)gcComboBox4.SelectedIndex;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // HighlightTextプロパティ
            gcTextBox1.SelectionLength = 0;
            gcTextBox1.HighlightText = checkBox2.Checked;
        }

    }
}

