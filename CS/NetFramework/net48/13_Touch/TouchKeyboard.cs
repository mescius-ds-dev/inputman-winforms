using System;
using System.Windows.Forms;
using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._13_Touch
{
    public partial class TouchKeyboard : InputManWin12_Demo.DemoBase_settings
    {
        public TouchKeyboard()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // xmlファイルからデータ取得
            System.String filePath = Application.StartupPath;
            this.dataSet1.ReadXml(filePath + "\\Resources\\prefecture.xml");
            gcComboBox1.DataSource = dataSet1.Tables[0];
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
            
            gcComboBox2.SelectedIndex = 2;
            gcComboBox2.SelectedIndexChanged += new EventHandler(gcComboBox2_SelectedIndexChanged);
            gcComboBox3.SelectedIndex = 1;
            gcComboBox3.SelectedIndexChanged += new EventHandler(gcComboBox3_SelectedIndexChanged);
            
            gcTextBox1.GotFocus += new EventHandler(Control_GotFocus);
            gcMask1.GotFocus += new EventHandler(Control_GotFocus);
            gcCharMask1.GotFocus += new EventHandler(Control_GotFocus);
            gcDateTime1.GotFocus += new EventHandler(Control_GotFocus);
            gcDate1.GotFocus += new EventHandler(Control_GotFocus);
            gcTime1.GotFocus += new EventHandler(Control_GotFocus);
            gcTimeSpan1.GotFocus += new EventHandler(Control_GotFocus);
            gcNumber1.GotFocus += new EventHandler(Control_GotFocus);
            gcComboBox1.GotFocus += new EventHandler(Control_GotFocus);
            gcMaskedComboBox1.GotFocus += new EventHandler(Control_GotFocus);

            gcTextBox1.LostFocus += new EventHandler(Control_LostFocus);
            gcMask1.LostFocus += new EventHandler(Control_LostFocus);
            gcCharMask1.LostFocus += new EventHandler(Control_LostFocus);
            gcDateTime1.LostFocus += new EventHandler(Control_LostFocus);
            gcDate1.LostFocus += new EventHandler(Control_LostFocus);
            gcTime1.LostFocus += new EventHandler(Control_LostFocus);
            gcTimeSpan1.LostFocus += new EventHandler(Control_LostFocus);
            gcNumber1.LostFocus += new EventHandler(Control_LostFocus);
            gcComboBox1.LostFocus += new EventHandler(Control_LostFocus);
            gcMaskedComboBox1.LostFocus += new EventHandler(Control_LostFocus);
        }

        void Control_GotFocus(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // タッチキーボードを表示
                gcIme1.ShowTouchKeyboard();
            }
        }

        void Control_LostFocus(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                // タッチキーボードを表示
                gcIme1.HideTouchKeyboard();
            }
        }

        void gcComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {            
            // InputScopeの設定
            InputScopeNameValue inputScope = (InputScopeNameValue)Enum.Parse(typeof(InputScopeNameValue), gcComboBox2.SelectedItem.Text);
            gcIme1.SetInputScope(gcTextBox1, inputScope);
            gcIme1.SetInputScope(gcMask1, inputScope);
            gcIme1.SetInputScope(gcCharMask1, inputScope);
            gcIme1.SetInputScope(gcDateTime1, inputScope);
            gcIme1.SetInputScope(gcDate1, inputScope);
            gcIme1.SetInputScope(gcTime1, inputScope);
            gcIme1.SetInputScope(gcTimeSpan1, inputScope);
            gcIme1.SetInputScope(gcNumber1, inputScope);
            gcIme1.SetInputScope(gcComboBox1, inputScope);
            gcIme1.SetInputScope(gcMaskedComboBox1, inputScope);
        }

        private void gcComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // AutoHideTouchKeyboardの設定
            gcTextBox1.DropDown.AutoHideTouchKeyboard = (AutoHideTouchKeyboard)gcComboBox3.SelectedIndex;
            gcDate1.DropDown.AutoHideTouchKeyboard = (AutoHideTouchKeyboard)gcComboBox3.SelectedIndex;
            gcDateTime1.DropDown.AutoHideTouchKeyboard = (AutoHideTouchKeyboard)gcComboBox3.SelectedIndex;
            gcTime1.DropDown.AutoHideTouchKeyboard = (AutoHideTouchKeyboard)gcComboBox3.SelectedIndex;
            gcNumber1.DropDown.AutoHideTouchKeyboard = (AutoHideTouchKeyboard)gcComboBox3.SelectedIndex;
            gcComboBox1.DropDown.AutoHideTouchKeyboard = (AutoHideTouchKeyboard)gcComboBox3.SelectedIndex;
            gcMaskedComboBox1.DropDown.AutoHideTouchKeyboard = (AutoHideTouchKeyboard)gcComboBox3.SelectedIndex;
        }

    }
}
