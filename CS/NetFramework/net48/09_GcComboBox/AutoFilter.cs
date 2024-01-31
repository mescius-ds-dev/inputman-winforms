using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._09_GcComboBox
{
    public partial class AutoFilter : InputManWin12_Demo.DemoBase_settings
    {
        public AutoFilter()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            checkBox2.CheckedChanged += new EventHandler(checkBox2_CheckedChanged);
            gcNumber1.ValueChanged += new EventHandler(gcNumber1_ValueChanged);
            gcNumber2.ValueChanged += new EventHandler(gcNumber2_ValueChanged);
            gcNumber3.ValueChanged += new EventHandler(gcNumber3_ValueChanged);
            gcComboBox2.SelectedIndexChanged += new EventHandler(gcComboBox2_SelectedIndexChanged);
            gcComboBox3.SelectedIndexChanged += new EventHandler(gcComboBox3_SelectedIndexChanged);

            // xmlファイルからショートカット機能一覧取得
            System.String filePath = Application.StartupPath;
            this.dataSet1.ReadXml(filePath + "\\Resources\\prefecture.xml");
            gcComboBox1.DataSource = dataSet1.Tables[0];
            gcComboBox1.ListColumns[0].AutoWidth = false;

            // ***** 初期値
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            gcNumber1.Value = gcComboBox1.AutoFilter.Interval;
            gcNumber2.Value = gcComboBox1.AutoFilter.MaxFilteredItems;
            gcNumber3.Value = gcComboBox1.AutoFilter.MinimumPrefixLength;
            gcComboBox2.SelectedIndex = Convert.ToInt32(gcComboBox1.AutoFilter.MatchingMode);
            gcComboBox3.SelectedIndex = Convert.ToInt32(gcComboBox1.AutoFilter.MatchingSource);

            for (int i = 1; i < gcComboBox1.ListColumns.Count; i++)
            {
                gcComboBox1.ListColumns[i].AutoWidth = true;
            }
            gcComboBox1.DropDown.Direction = DropDownDirection.BelowLeft;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // AutoFilterプロパティ
            gcComboBox1.AutoFilter.Enabled = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // AutoSelectプロパティ
            gcComboBox1.AutoSelect = checkBox2.Checked;
        }

        private void gcNumber1_ValueChanged(object sender, EventArgs e)
        {
            // AutoFilter.Intervalプロパティ
            if(gcNumber1.Value.HasValue)
            {
                gcComboBox1.AutoFilter.Interval = (int)gcNumber1.Value.Value;
            }
            else
            {
                gcNumber1.Value = gcNumber1.MinValue;
                gcComboBox1.AutoFilter.Interval = (int)gcNumber1.Value.Value;
            }
        }

        private void gcNumber2_ValueChanged(object sender, EventArgs e)
        {
            // AutoFilter.MaxFilteredItemsプロパティ
            if (gcNumber2.Value.HasValue)
            {
                gcComboBox1.AutoFilter.MaxFilteredItems = (int)gcNumber2.Value.Value;
            }
            else
            {
                gcNumber2.Value = gcNumber2.MinValue;
                gcComboBox1.AutoFilter.MaxFilteredItems = (int)gcNumber2.Value.Value;
            }
        }

        private void gcNumber3_ValueChanged(object sender, EventArgs e)
        {
            // AutoFilter.MinimumPrefixLengthプロパティ
            if (gcNumber3.Value.HasValue)
            {
                if (gcNumber3.Value.Value < 1)
                {
                    gcNumber3.Value = gcNumber3.MinValue;
                    gcComboBox1.AutoFilter.MinimumPrefixLength = (int)gcNumber3.Value.Value;
                }
                else
                {
                    gcComboBox1.AutoFilter.MinimumPrefixLength = (int)gcNumber3.Value.Value;
                }
            }
            else
            {
                gcNumber3.Value = gcNumber3.MinValue;
                gcComboBox1.AutoFilter.MinimumPrefixLength = (int)gcNumber3.Value.Value;
            }
        }

        private void gcComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // AutoFilter.MatchingModeプロパティ
            gcComboBox1.AutoFilter.MatchingMode = (AutoCompleteMatchingMode)gcComboBox2.SelectedIndex;
        }

        private void gcComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // AutoFilter.MatchingSourceプロパティ
            gcComboBox1.AutoFilter.MatchingSource = (FilterMatchingSource)gcComboBox3.SelectedIndex;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                gcComboBox1.ExtractedItemsIndicesChanged += GcComboBox1_ExtractedItemsIndicesChanged;
            }
            else
            {
                gcComboBox1.ExtractedItemsIndicesChanged -= GcComboBox1_ExtractedItemsIndicesChanged;
            }
        }

        private void GcComboBox1_ExtractedItemsIndicesChanged(object sender, EventArgs e)
        {
            var builder = new StringBuilder();
            builder.Append(gcComboBox1.Items.Count);
            builder.Append("件中");
            builder.Append(gcComboBox1.ExtractedItemsIndices.Count);
            builder.Append("件表示");
            builder.Append("\r\n表示中の項目のインデックス：");
            builder.Append(String.Join(",", gcComboBox1.ExtractedItemsIndices.ToArray()));
            
            MessageBox.Show(builder.ToString());
        }
    }
}
