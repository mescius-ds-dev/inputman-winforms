using System;
using System.Drawing;
using System.Windows.Forms;

namespace InputManWin12_Demo._06_Display
{
    public partial class Alignment : InputManWin12_Demo.DemoBase_settings
    {
        public Alignment()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            gcComboBox1.SelectedIndexChanged += new EventHandler(gcComboBox1_SelectedIndexChanged);
            gcComboBox2.SelectedIndexChanged += new EventHandler(gcComboBox2_SelectedIndexChanged);
            gcNumber1.ValueChanged += new EventHandler(gcNumber_ValueChanged);
            gcNumber2.ValueChanged += new EventHandler(gcNumber_ValueChanged);
            gcNumber3.ValueChanged += new EventHandler(gcNumber_ValueChanged);
            gcNumber4.ValueChanged += new EventHandler(gcNumber_ValueChanged);

            // ***** 初期値
            gcComboBox1.SelectedIndex = 0;
            gcNumber1.Value = gcTextBox1.Padding.Top;
            gcNumber2.Value = gcTextBox1.Padding.Left;
            gcNumber3.Value = gcTextBox1.Padding.Right;
            gcNumber4.Value = gcTextBox1.Padding.Bottom;
            gcComboBox2.SelectedIndex = Convert.ToInt32(gcTextBox1.DisplayAlignment);
        }

        private void gcNumber_ValueChanged(object sender, EventArgs e)
        {
            // Paddingプロパティ
            gcTextBox1.Padding = new Padding((int)gcNumber2.Value
                                           , (int)gcNumber1.Value
                                           , (int)gcNumber3.Value
                                           , (int)gcNumber4.Value);
        }

        private void gcComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ContentAlignmentプロパティ
            switch (gcComboBox1.SelectedIndex)
            {
                case 0:
                    gcTextBox1.ContentAlignment = ContentAlignment.TopLeft;
                    break;
                case 1:
                    gcTextBox1.ContentAlignment = ContentAlignment.TopCenter;
                    break;
                case 2:
                    gcTextBox1.ContentAlignment = ContentAlignment.TopRight;
                    break;
                case 3:
                    gcTextBox1.ContentAlignment = ContentAlignment.MiddleLeft;
                    break;
                case 4:
                    gcTextBox1.ContentAlignment = ContentAlignment.MiddleCenter;
                    break;
                case 5:
                    gcTextBox1.ContentAlignment = ContentAlignment.MiddleRight;
                    break;
                case 6:
                    gcTextBox1.ContentAlignment = ContentAlignment.BottomLeft;
                    break;
                case 7:
                    gcTextBox1.ContentAlignment = ContentAlignment.BottomCenter;
                    break;
                case 8:
                    gcTextBox1.ContentAlignment = ContentAlignment.BottomRight;
                    break;
                default:
                    break;
            }
        }

        private void gcComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // DisplayAlignmentプロパティ
            gcTextBox1.DisplayAlignment = (GrapeCity.Win.Editors.DisplayAlignment)gcComboBox2.SelectedIndex;
        }
    }
}
