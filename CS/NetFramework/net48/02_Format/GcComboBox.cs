using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._02_Format
{
    public partial class GcComboBox : InputManWin12_Demo.DemoBase_settings
    {
        public GcComboBox()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            gcNumber1.ValueChanged += new EventHandler(gcNumber1_ValueChanged);
            gcComboBox2.SelectedIndexChanged += new EventHandler(gcComboBox2_SelectedIndexChanged);
            gcListBox1.ItemCheck += new ItemCheckEventHandler(gcListBox1_ItemCheck);
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            gcComboBox3.SelectedIndexChanged += new EventHandler(gcComboBox3_SelectedIndexChanged);
            gcComboBox4.SelectedIndexChanged += new EventHandler(gcComboBox4_SelectedIndexChanged);
            gcComboBox5.SelectedIndexChanged += new EventHandler(gcComboBox5_SelectedIndexChanged);
            checkBox2.CheckedChanged += new EventHandler(checkBox2_CheckedChanged);

            // ***** 初期値
            gcNumber1.Value = gcComboBox1.MaxLength;
            gcComboBox2.SelectedIndex = Convert.ToInt32(gcComboBox1.MaxLengthUnit);
            checkBox1.Checked = gcComboBox1.AutoConvert;
            gcComboBox3.SelectedIndex = Convert.ToInt32(gcComboBox1.AllowSpace);
            gcComboBox4.SelectedIndex = Convert.ToInt32(gcComboBox1.AcceptsCrLf);
            gcComboBox5.SelectedIndex = Convert.ToInt32(gcComboBox1.AcceptsTabChar);
            checkBox2.Checked = gcComboBox1.HighlightText;
        }

        private void gcNumber1_ValueChanged(object sender, EventArgs e)
        {
            // MaxLenghtプロパティ
            gcComboBox1.MaxLength = Convert.ToInt32(gcNumber1.Value.Value);
        }

        private void gcComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MaxLengthUnitプロパティ
            gcComboBox1.MaxLengthUnit = (LengthUnit)gcComboBox2.SelectedIndex;
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
            gcComboBox1.Format = formatVal;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // AutoConvertプロパティ
            gcComboBox1.AutoConvert = checkBox1.Checked;
        }

        private void gcComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // AllowSpaceプロパティ
            gcComboBox1.AllowSpace = (AllowSpace)gcComboBox3.SelectedIndex;
        }

        private void gcComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // AcceptsCrLfプロパティ
            gcComboBox1.AcceptsCrLf = (CrLfMode)gcComboBox4.SelectedIndex;
        }

        private void gcComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            // AcceptsTabCharプロパティ
            gcComboBox1.AcceptsTabChar = (TabCharMode)gcComboBox5.SelectedIndex;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // HighlightTextプロパティ
            gcComboBox1.SelectionLength = 0;
            gcComboBox1.HighlightText = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            gcComboBox1.IsEditable = !checkBox3.Checked;
        }
    }
}
