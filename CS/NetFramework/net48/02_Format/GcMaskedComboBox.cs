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
    public partial class GcMaskedComboBox : InputManWin12_Demo.DemoBase_settings
    {
        public GcMaskedComboBox()
        {
            InitializeComponent();
            InitializeForm();

        }
        private void InitializeForm()
        {
            // ***** 初期設定
            gcComboBox1.SelectedIndexChanged += new EventHandler(gcComboBox1_SelectedIndexChanged);
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            gcComboBox2.SelectedIndexChanged += new EventHandler(gcComboBox2_SelectedIndexChanged);
            gcComboBox3.SelectedIndexChanged += new EventHandler(gcComboBox3_SelectedIndexChanged);

            // ***** 初期設定
            gcComboBox1.SelectedIndex = 0;
            checkBox1.Checked = gcMaskedComboBox1.AutoConvert;
            gcComboBox2.SelectedIndex = Convert.ToInt32(gcMaskedComboBox1.AcceptsCrLf);
            gcComboBox3.SelectedIndex = Convert.ToInt32(gcMaskedComboBox1.AcceptsTabChar);
        }

        private void gcComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 正規表現による書式設定
            gcMaskedComboBox1.Fields.Clear();
            gcMaskedComboBox1.Fields.AddRange(gcComboBox1.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // AutoConvertプロパティ
            gcMaskedComboBox1.AutoConvert = checkBox1.Checked;
        }

        private void gcComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // AcceptsCrLfプロパティ
            gcMaskedComboBox1.AcceptsCrLf = (CrLfMode)gcComboBox2.SelectedIndex;
        }

        private void gcComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // AcceptsTabCharプロパティ
            gcMaskedComboBox1.AcceptsTabChar = (TabCharMode)gcComboBox3.SelectedIndex;
        }


    }
}
