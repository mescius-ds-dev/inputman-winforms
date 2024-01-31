using System;

namespace InputManWin12_Demo._14_GcSoftKeyboard
{
    public partial class Appearance : InputManWin12_Demo.DemoBase_settings
    {
        public Appearance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gcSoftKeyboard1.Show(textBox1, true);
        }

        private void gcColorPicker1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 基底カラーの設定
            gcSoftKeyboard1.BaseColor = gcColorPicker1.SelectedColor;
        }

        private void gcColorPicker2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 切替キーの色
            gcSoftKeyboard1.ToggledButtonBackColor = gcColorPicker2.SelectedColor;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // キーの境界線
            gcSoftKeyboard1.ShowButtonBorder = checkBox1.Checked;
        }

        private void gcNumber1_ValueChanged(object sender, EventArgs e)
        {
            // 透過率
            gcSoftKeyboard1.Opacity = (double)gcNumber1.Value;
        }

        private void Appearance_Load(object sender, EventArgs e)
        {
            
        }


    }
}
