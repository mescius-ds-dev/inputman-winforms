using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InputManWin12_Demo._06_Display
{
    public partial class ReadOnlyColor : InputManWin12_Demo.DemoBase_settings
    {
        public ReadOnlyColor()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期値
            gcColorPicker1.SelectedIndex = gcColorPicker1.FindStringExact(gcTextBox1.BackColor.Name, -1, 0);

            // xmlファイルからデータ取得
            System.String filePath = Application.StartupPath;
            this.dataSet1.ReadXml(filePath + "\\Resources\\prefecture.xml");

            DataView dv1 = new DataView(dataSet1.Tables[0]);
            gcComboBox1.DataSource = dv1;
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

        private void gcColorPicker1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ForeColorプロパティ
            gcTextBox1.ForeColor = gcColorPicker1.SelectedColor;
            gcMask1.ForeColor = gcColorPicker1.SelectedColor;
            gcCharMask1.ForeColor = gcColorPicker1.SelectedColor;
            gcDateTime1.ForeColor = gcColorPicker1.SelectedColor;
            gcDate1.ForeColor = gcColorPicker1.SelectedColor;
            gcTime1.ForeColor = gcColorPicker1.SelectedColor;
            gcTimeSpan1.ForeColor = gcColorPicker1.SelectedColor;
            gcNumber1.ForeColor = gcColorPicker1.SelectedColor;
            gcComboBox1.ForeColor = gcColorPicker1.SelectedColor;
            gcMaskedComboBox1.ForeColor = gcColorPicker1.SelectedColor;
        }

        private void gcColorPicker2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // BackColorプロパティ
            gcTextBox1.BackColor = gcColorPicker2.SelectedColor;
            gcMask1.BackColor = gcColorPicker2.SelectedColor;
            gcCharMask1.BackColor = gcColorPicker2.SelectedColor;
            gcDateTime1.BackColor = gcColorPicker2.SelectedColor;
            gcDate1.BackColor = gcColorPicker2.SelectedColor;
            gcTime1.BackColor = gcColorPicker2.SelectedColor;
            gcTimeSpan1.BackColor = gcColorPicker2.SelectedColor;
            gcNumber1.BackColor = gcColorPicker2.SelectedColor;
            gcComboBox1.BackColor = gcColorPicker2.SelectedColor;
            gcMaskedComboBox1.BackColor = gcColorPicker2.SelectedColor;
        }

        private void gcColorPicker3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ReadOnlyForeColorプロパティ
            gcTextBox1.ReadOnlyForeColor = gcColorPicker3.SelectedColor;
            gcMask1.ReadOnlyForeColor = gcColorPicker3.SelectedColor;
            gcCharMask1.ReadOnlyForeColor = gcColorPicker3.SelectedColor;
            gcDateTime1.ReadOnlyForeColor = gcColorPicker3.SelectedColor;
            gcDate1.ReadOnlyForeColor = gcColorPicker3.SelectedColor;
            gcTime1.ReadOnlyForeColor = gcColorPicker3.SelectedColor;
            gcTimeSpan1.ReadOnlyForeColor = gcColorPicker3.SelectedColor;
            gcNumber1.ReadOnlyForeColor = gcColorPicker3.SelectedColor;
            gcComboBox1.ReadOnlyForeColor = gcColorPicker3.SelectedColor;
            gcMaskedComboBox1.ReadOnlyForeColor = gcColorPicker3.SelectedColor;
        }

        private void gcColorPicker4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ReadOnlyBackColorプロパティ
            gcTextBox1.ReadOnlyBackColor = gcColorPicker4.SelectedColor;
            gcMask1.ReadOnlyBackColor = gcColorPicker4.SelectedColor;
            gcCharMask1.ReadOnlyBackColor = gcColorPicker4.SelectedColor;
            gcDateTime1.ReadOnlyBackColor = gcColorPicker4.SelectedColor;
            gcDate1.ReadOnlyBackColor = gcColorPicker4.SelectedColor;
            gcTime1.ReadOnlyBackColor = gcColorPicker4.SelectedColor;
            gcTimeSpan1.ReadOnlyBackColor = gcColorPicker4.SelectedColor;
            gcNumber1.ReadOnlyBackColor = gcColorPicker4.SelectedColor;
            gcComboBox1.ReadOnlyBackColor = gcColorPicker4.SelectedColor;
            gcMaskedComboBox1.ReadOnlyBackColor = gcColorPicker4.SelectedColor;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // ReadOnlyプロパティ
            gcTextBox1.ReadOnly = checkBox1.Checked;
            gcMask1.ReadOnly = checkBox1.Checked;
            gcCharMask1.ReadOnly = checkBox1.Checked;
            gcDateTime1.ReadOnly = checkBox1.Checked;
            gcDate1.ReadOnly = checkBox1.Checked;
            gcTime1.ReadOnly = checkBox1.Checked;
            gcTimeSpan1.ReadOnly = checkBox1.Checked;
            gcNumber1.ReadOnly = checkBox1.Checked;
            gcComboBox1.ReadOnly = checkBox1.Checked;
            gcMaskedComboBox1.ReadOnly = checkBox1.Checked;
        }
    }
}
