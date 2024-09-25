using GrapeCity.Win.Editors;
using InputManWin12_Demo._02_Format;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InputManWin12_Demo._06_Display
{
    public partial class PlaceHolder : InputManWin12_Demo.DemoBase_settings
    {
        public PlaceHolder()
        {
            InitializeComponent();
            InitializeForm();
        }
        private void InitializeForm()
        {
            // xmlファイルからデータ取得
            System.String filePath = Application.StartupPath;
            this.dataSet1.ReadXml(filePath + "\\Resources\\prefecture.xml");

            DataView dv1 = new DataView(dataSet1.Tables[0]);
            gcComboBox1.DataSource = dv1;
            gcComboBox1.SelectedIndex = 0;

            for (int i = 1; i < gcComboBox1.ListColumns.Count; i++)
            {
                gcComboBox1.ListColumns[i].AutoWidth = true;
            }
            gcComboBox2.SelectedIndex = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // PlaceHolderプロパティ
            gcTextBox1.PlaceHolder.Enable = checkBox1.Checked;
            gcTextBox1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
            gcMask1.PlaceHolder.Enable = checkBox1.Checked;
            gcMask1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
            gcMask1.PlaceHolder.FloatingStyle.ForeColor = Color.Red;
            gcDateTime1.PlaceHolder.Enable = checkBox1.Checked;
            gcDateTime1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
            gcDateTime1.PlaceHolder.FloatingStyle.ForeColor = Color.Red;
            gcTime1.PlaceHolder.Enable = checkBox1.Checked;
            gcTime1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
            gcTime1.PlaceHolder.FloatingStyle.ForeColor = Color.Red;
            gcDate1.PlaceHolder.Enable = checkBox1.Checked;
            gcDate1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
            gcTimeSpan1.PlaceHolder.Enable = checkBox1.Checked;
            gcTimeSpan1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
            gcNumber1.PlaceHolder.Enable = checkBox1.Checked;
            gcNumber1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
            gcNumber1.PlaceHolder.FloatingStyle.ForeColor = Color.Red;
            gcComboBox1.PlaceHolder.Enable = checkBox1.Checked;
            gcComboBox1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
        }

        private void gcNumber2_ValueChanged(object sender, EventArgs e)
        {
            gcTextBox1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
            gcMask1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
            gcDateTime1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
            gcTime1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
            gcDate1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
            gcTimeSpan1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
            gcNumber1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
            gcComboBox1.PlaceHolder.FloatingStyle.Font = new Font("メイリオ", int.Parse(gcNumber2.Value.ToString()));
        }

        private void gcComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // PlaceHolderAlignmentプロパティ
            gcTextBox1.PlaceHolder.FloatingStyle.PlaceHolderAlignment = (GrapeCity.Framework.Views.PlaceHolderAlignment)gcComboBox2.SelectedIndex;
            gcMask1.PlaceHolder.FloatingStyle.PlaceHolderAlignment = (GrapeCity.Framework.Views.PlaceHolderAlignment)gcComboBox2.SelectedIndex;
            gcDateTime1.PlaceHolder.FloatingStyle.PlaceHolderAlignment = (GrapeCity.Framework.Views.PlaceHolderAlignment)gcComboBox2.SelectedIndex;
            gcTime1.PlaceHolder.FloatingStyle.PlaceHolderAlignment = (GrapeCity.Framework.Views.PlaceHolderAlignment)gcComboBox2.SelectedIndex;
            gcDate1.PlaceHolder.FloatingStyle.PlaceHolderAlignment = (GrapeCity.Framework.Views.PlaceHolderAlignment)gcComboBox2.SelectedIndex;
            gcTimeSpan1.PlaceHolder.FloatingStyle.PlaceHolderAlignment = (GrapeCity.Framework.Views.PlaceHolderAlignment)gcComboBox2.SelectedIndex;
            gcNumber1.PlaceHolder.FloatingStyle.PlaceHolderAlignment = (GrapeCity.Framework.Views.PlaceHolderAlignment)gcComboBox2.SelectedIndex;
            gcComboBox1.PlaceHolder.FloatingStyle.PlaceHolderAlignment = (GrapeCity.Framework.Views.PlaceHolderAlignment)gcComboBox2.SelectedIndex;
        }
    }
}
