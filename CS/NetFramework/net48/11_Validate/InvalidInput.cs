using System;
using System.Windows.Forms;

namespace InputManWin12_Demo._11_Validate
{
    public partial class InvalidInput : InputManWin12_Demo.DemoBase_settings
    {
        public InvalidInput()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            gcTextBox1.InvalidInput += new EventHandler(gcTextBox1_InvalidInput);
            gcMask1.InvalidInput += new EventHandler(gcMask1_InvalidInput);
            gcCharMask1.InvalidInput += new EventHandler(gcCharMask1_InvalidInput);
            gcDateTime1.InvalidInput += new EventHandler(gcDateTime1_InvalidInput);
            gcDate1.InvalidInput += new EventHandler(gcDate1_InvalidInput);
            gcTime1.InvalidInput += new EventHandler(gcTime1_InvalidInput);
            gcTimeSpan1.InvalidInput += new EventHandler(gcTimeSpan1_InvalidInput);
            gcNumber1.InvalidInput += new EventHandler(gcNumber1_InvalidInput);
            gcComboBox1.InvalidInput += new EventHandler(gcComboBox1_InvalidInput);
            gcMaskedComboBox1.InvalidInput += new EventHandler(gcMaskedComboBox1_InvalidInput);
            button1.Click += new EventHandler(button1_Click);

            // ***** 初期値
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

        }

        private void gcTextBox1_InvalidInput(object sender, EventArgs e)
        {
            addInvalidInputEventArgs("テキストコントロール", e);
        }

        private void gcMask1_InvalidInput(object sender, EventArgs e)
        {
            addInvalidInputEventArgs("マスクコントロール", e);
        }

        private void gcCharMask1_InvalidInput(object sender, EventArgs e)
        {
            addInvalidInputEventArgs("キャラクタボックスコントロール", e);
        }

        private void gcDateTime1_InvalidInput(object sender, EventArgs e)
        {
            addInvalidInputEventArgs("日付時刻コントロール", e);
        }

        private void gcDate1_InvalidInput(object sender, EventArgs e)
        {
            addInvalidInputEventArgs("日付コントロール", e);
        }

        private void gcTime1_InvalidInput(object sender, EventArgs e)
        {
            addInvalidInputEventArgs("時刻コントロール", e);
        }

        private void gcTimeSpan1_InvalidInput(object sender, EventArgs e)
        {
            addInvalidInputEventArgs("タイムスパンコントロール", e);
        }

        private void gcNumber1_InvalidInput(object sender, EventArgs e)
        {
            addInvalidInputEventArgs("数値コントロール", e);
        }

        private void gcComboBox1_InvalidInput(object sender, EventArgs e)
        {
            addInvalidInputEventArgs("コンボコントロール", e);
        }

        private void gcMaskedComboBox1_InvalidInput(object sender, EventArgs e)
        {
            addInvalidInputEventArgs("マスクコンボコントロール", e);
        }


        private void addInvalidInputEventArgs(string str, EventArgs e)
        {
            GrapeCity.Win.Editors.InvalidInputEventArgs invalidInputEventArgs = e as GrapeCity.Win.Editors.InvalidInputEventArgs;
            if (invalidInputEventArgs == null)
            {
                return;
            }

            // 入力された値が設定された書式に対して無効かどうか 
            if (invalidInputEventArgs.HasInvalidChar)
            {
                gcListBox1.Items.Add(str + " に入力された値は設定された書式に対して無効です。");
            }

            // 入力された値が設定された最大文字数を超えているかどうか 
            if (invalidInputEventArgs.MeetsLengthLimit)
            {
                gcListBox1.Items.Add(str + " に入力された値は設定された最大文字数を超えています。");
            }

            // 入力された値が設定された最大値よりも大きいかどうか 
            if (invalidInputEventArgs.ExceedMaxValue)
            {
                gcListBox1.Items.Add(str + " に入力された値は設定された最大値よりも大きい値です。");
            }

            // 入力された値が設定された最小値よりも小さいかどうか 
            if (invalidInputEventArgs.BelowMinValue)
            {
                gcListBox1.Items.Add(str + " に入力された値は設定された最小値よりも小さい値です。");
            }

            gcListBox1.SelectedIndex = gcListBox1.Items.Count - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gcListBox1.Items.Clear();
        }
    }
}