using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._07_DropDown
{
    public partial class DropDownDateTimePicker : InputManWin12_Demo.DemoBase_settings
    {
        public DropDownDateTimePicker()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // 初期設定
            gcDateTime1.Value = DateTime.Now;
            gcDate1.Value = DateTime.Now;

            gcDateTime1.DropDown.DropDownType = DateDropDownType.Picker;
            gcDate1.DropDown.DropDownType = DateDropDownType.Picker;

            gcComboBox1.SelectedIndex = 1;
            gcComboBox2.SelectedIndex = 0;
            gcComboBox3.SelectedIndex = 0;
           
            gcComboBox4.SelectedIndex = 0;
            gcComboBox5.SelectedIndex = 0;
            gcComboBox6.SelectedIndex = 0;
        }

        private void gcColorPicker1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ピッカーのForeColorプロパティ
            gcDateTime1.DropDownPicker.ForeColor = gcColorPicker1.SelectedColor;
            gcDate1.DropDownPicker.ForeColor = gcColorPicker1.SelectedColor;
            gcTime1.DropDownPicker.ForeColor = gcColorPicker1.SelectedColor;
        }

        private void gcColorPicker2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ピッカーのBackColorプロパティ
            gcDateTime1.DropDownPicker.BackColor = gcColorPicker2.SelectedColor;
            gcDate1.DropDownPicker.BackColor = gcColorPicker2.SelectedColor;
            gcTime1.DropDownPicker.BackColor = gcColorPicker2.SelectedColor;            
        }

        private void gcComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ピッカーのBorderStyleプロパティ
            if (gcComboBox1.SelectedIndex ==0)
            {
                gcDateTime1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.None;
                gcDate1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.None;
                gcTime1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.None;
                gcColorPicker3.Enabled = false;
            }
            else if (gcComboBox1.SelectedIndex == 1)
            {
                gcDateTime1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                gcDate1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                gcTime1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                gcColorPicker3.Enabled = true ;
            }
            else if (gcComboBox1.SelectedIndex == 2)
            {
                gcDateTime1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                gcDate1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                gcTime1.DropDownPicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                gcColorPicker3.Enabled = false;
            }
        }

        private void gcColorPicker3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ピッカーのSingleBorderColorプロパティ
            gcDateTime1.DropDownPicker.SingleBorderColor = gcColorPicker3.SelectedColor;
            gcDate1.DropDownPicker.SingleBorderColor = gcColorPicker3.SelectedColor;
            gcTime1.DropDownPicker.SingleBorderColor = gcColorPicker3.SelectedColor;
        }

        private void gcComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 選択領域のSelectionRenderModeプロパティ
            if (gcComboBox2.SelectedIndex == 0)
            {
                gcDateTime1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.Border;
                gcDate1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.Border;
                gcTime1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.Border;
                gcColorPicker5.Enabled = false;
                gcColorPicker6.Enabled = true;
            }
            else if (gcComboBox2.SelectedIndex == 1)
            {
                gcDateTime1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.Fill;
                gcDate1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.Fill;
                gcTime1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.Fill;
                gcColorPicker5.Enabled = true;
                gcColorPicker6.Enabled = false;
            }
            else if (gcComboBox2.SelectedIndex == 2)
            {
                gcDateTime1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.BorderWithFill;
                gcDate1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.BorderWithFill;
                gcTime1.DropDownPicker.SelectionRenderMode = SelectionRenderMode.BorderWithFill;
                gcColorPicker5.Enabled = true;
                gcColorPicker6.Enabled = true;
            }
        }

        private void gcColorPicker4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 選択領域のSelectedForeColorプロパティ
            gcDateTime1.DropDownPicker.SelectedForeColor = gcColorPicker4.SelectedColor;
            gcDate1.DropDownPicker.SelectedForeColor = gcColorPicker4.SelectedColor;
            gcTime1.DropDownPicker.SelectedForeColor = gcColorPicker4.SelectedColor;
        }

        private void gcColorPicker5_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 選択領域のSelectedBackColorプロパティ
            gcDateTime1.DropDownPicker.SelectedBackColor = gcColorPicker5.SelectedColor;
            gcDate1.DropDownPicker.SelectedBackColor = gcColorPicker5.SelectedColor;
            gcTime1.DropDownPicker.SelectedBackColor = gcColorPicker5.SelectedColor;
        }

        private void gcColorPicker6_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 選択領域のSelectedBorderColorプロパティ
            gcDateTime1.DropDownPicker.SelectedBorderColor = gcColorPicker6.SelectedColor;
            gcDate1.DropDownPicker.SelectedBorderColor = gcColorPicker6.SelectedColor;
            gcTime1.DropDownPicker.SelectedBorderColor = gcColorPicker6.SelectedColor;
        }

        private void gcComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            gcDateTime1.DropDownPicker.YearFormat = gcComboBox3.SelectedValue.ToString();
            gcDate1.DropDownPicker.YearFormat = gcComboBox3.SelectedValue.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            gcDateTime1.DropDownPicker.ShowHours = checkBox1.Checked;
            gcTime1.DropDownPicker.ShowHours = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            gcDateTime1.DropDownPicker.ShowMinutes = checkBox2.Checked;
            gcTime1.DropDownPicker.ShowMinutes = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            gcDateTime1.DropDownPicker.ShowSeconds = checkBox3.Checked;
            gcTime1.DropDownPicker.ShowSeconds = checkBox3.Checked;
        }

        private void gcComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            gcDateTime1.DropDownPicker.HoursInterval = int.Parse(gcComboBox4.SelectedValue.ToString());
            gcTime1.DropDownPicker.HoursInterval =  int.Parse(gcComboBox4.SelectedValue.ToString());
        }

        private void gcComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            gcDateTime1.DropDownPicker.MinutesInterval = int.Parse(gcComboBox5.SelectedValue.ToString());
            gcTime1.DropDownPicker.MinutesInterval =  int.Parse(gcComboBox5.SelectedValue.ToString());
        }

        private void gcComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            gcDateTime1.DropDownPicker.SecondsInterval = int.Parse(gcComboBox6.SelectedValue.ToString());
            gcTime1.DropDownPicker.SecondsInterval =  int.Parse(gcComboBox6.SelectedValue.ToString());
        }
    }
}
