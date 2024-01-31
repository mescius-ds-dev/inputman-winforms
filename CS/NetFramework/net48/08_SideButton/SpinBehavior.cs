using System;
using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._08_SideButton
{
    public partial class SpinBehavior : InputManWin12_Demo.DemoBase_settings
    {
        public SpinBehavior()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            gcComboBox2.SelectedIndex = 0;
            gcComboBox2.SelectedIndexChanged +=new EventHandler(gcComboBox2_SelectedIndexChanged);
            gcComboBox3.Enabled = false;
            gcComboBox3.SelectedIndex = 0;
            gcComboBox3.SelectedIndexChanged += new EventHandler(gcComboBox3_SelectedIndexChanged);
            gcComboBox4.Enabled = false;
            gcComboBox4.SelectedIndex = 0;
            gcComboBox4.SelectedIndexChanged += new EventHandler(gcComboBox4_SelectedIndexChanged);

            gcMaskedComboBox1.SelectedIndex = 0;
        }

        void gcComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // サイドボタンをクリア
            gcMask1.SideButtons.Clear();
            gcDateTime1.SideButtons.Clear();
            gcDate1.SideButtons.Clear();
            gcTime1.SideButtons.Clear();
            gcTimeSpan1.SideButtons.Clear();
            gcNumber1.SideButtons.Clear();
            gcComboBox1.SideButtons.Clear();
            gcMaskedComboBox1.SideButtons.Clear();

            if (gcComboBox2.SelectedIndex == 0)
            {
                gcComboBox3.Enabled = false;
                gcComboBox4.Enabled = false;

                // スピンボタンを追加
                gcMask1.SideButtons.Add(new GrapeCity.Win.Editors.SpinButton());
                gcDateTime1.SideButtons.Add(new GrapeCity.Win.Editors.SpinButton());
                gcDate1.SideButtons.Add(new GrapeCity.Win.Editors.SpinButton());
                gcTime1.SideButtons.Add(new GrapeCity.Win.Editors.SpinButton());
                gcTimeSpan1.SideButtons.Add(new GrapeCity.Win.Editors.SpinButton());
                gcNumber1.SideButtons.Add(new GrapeCity.Win.Editors.SpinButton());
                gcComboBox1.SideButtons.Add(new GrapeCity.Win.Editors.SpinButton());
                gcMaskedComboBox1.SideButtons.Add(new GrapeCity.Win.Editors.SpinButton());
            }
            else if (gcComboBox2.SelectedIndex == 1)
            {
                gcComboBox3.Enabled = true;
                gcComboBox4.Enabled = true;

                // スピン機能を割り当てたサイドボタンを追加
                AddSideButtons(gcMask1);
                AddSideButtons(gcDateTime1);
                AddSideButtons(gcDate1);
                AddSideButtons(gcTime1);
                AddSideButtons(gcTimeSpan1);
                AddSideButtons(gcNumber1);
                AddSideButtons(gcComboBox1);
                AddSideButtons(gcMaskedComboBox1);
            }
            else if (gcComboBox2.SelectedIndex == 2)
            {
                gcComboBox3.Enabled = true;
                gcComboBox4.Enabled = true;

                // スピン機能を割り当てたシンボルボタンを追加
                AddSymbolButtons(gcMask1);
                AddSymbolButtons(gcDateTime1);
                AddSymbolButtons(gcDate1);
                AddSymbolButtons(gcTime1);
                AddSymbolButtons(gcTimeSpan1);
                AddSymbolButtons(gcNumber1);
                AddSymbolButtons(gcComboBox1);
                AddSymbolButtons(gcMaskedComboBox1);
            }
        }

        void gcComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ボタンの表示位置を変更
            ChangePosition(gcMask1.SideButtons[0], gcMask1.SideButtons[1]);
            ChangePosition(gcDateTime1.SideButtons[0], gcDateTime1.SideButtons[1]);
            ChangePosition(gcDate1.SideButtons[0], gcDate1.SideButtons[1]);
            ChangePosition(gcTime1.SideButtons[0], gcTime1.SideButtons[1]);
            ChangePosition(gcTimeSpan1.SideButtons[0], gcTimeSpan1.SideButtons[1]);
            ChangePosition(gcNumber1.SideButtons[0], gcNumber1.SideButtons[1]);
            ChangePosition(gcComboBox1.SideButtons[0], gcComboBox1.SideButtons[1]);
            ChangePosition(gcMaskedComboBox1.SideButtons[0], gcMaskedComboBox1.SideButtons[1]);
        }

        void gcComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // サイドボタンをクリア
            gcMask1.SideButtons.Clear();
            gcDateTime1.SideButtons.Clear();
            gcDate1.SideButtons.Clear();
            gcTime1.SideButtons.Clear();
            gcTimeSpan1.SideButtons.Clear();
            gcNumber1.SideButtons.Clear();
            gcComboBox1.SideButtons.Clear();
            gcMaskedComboBox1.SideButtons.Clear();

            if (gcComboBox2.SelectedIndex == 1)
            {
                // スピン機能を割り当てたサイドボタンを追加
                AddSideButtons(gcMask1);
                AddSideButtons(gcDateTime1);
                AddSideButtons(gcDate1);
                AddSideButtons(gcTime1);
                AddSideButtons(gcTimeSpan1);
                AddSideButtons(gcNumber1);
                AddSideButtons(gcComboBox1);
                AddSideButtons(gcMaskedComboBox1);
            }
            else if (gcComboBox2.SelectedIndex == 2)
            {
                // スピン機能を割り当てたシンボルボタンを追加
                AddSymbolButtons(gcMask1);
                AddSymbolButtons(gcDateTime1);
                AddSymbolButtons(gcDate1);
                AddSymbolButtons(gcTime1);
                AddSymbolButtons(gcTimeSpan1);
                AddSymbolButtons(gcNumber1);
                AddSymbolButtons(gcComboBox1);
                AddSymbolButtons(gcMaskedComboBox1);
            }
        }
        
        // スピン機能を持つサイドボタンを追加
        void AddSideButtons(EditBase control)
        {
            GrapeCity.Win.Editors.SideButton leftButton = new GrapeCity.Win.Editors.SideButton();
            GrapeCity.Win.Editors.SideButton rightButton = new GrapeCity.Win.Editors.SideButton();

            // SideButtonBehaviorプロパティ
            if (gcComboBox4.SelectedIndex == 0)
            {
                leftButton.Behavior = SideButtonBehavior.SpinDown;
                rightButton.Behavior = SideButtonBehavior.SpinUp;
            }
            else
            {
                leftButton.Behavior = SideButtonBehavior.SpinUp;
                rightButton.Behavior = SideButtonBehavior.SpinDown;
            }
            AddButtons(leftButton, rightButton, control);
        }

        // スピン機能を持つシンボルボタンを追加
        void AddSymbolButtons(EditBase control)
        {
            GrapeCity.Win.Editors.SymbolButton leftButton = new GrapeCity.Win.Editors.SymbolButton();
            GrapeCity.Win.Editors.SymbolButton rightButton = new GrapeCity.Win.Editors.SymbolButton();

            // SideButtonBehaviorプロパティ
            if (gcComboBox4.SelectedIndex == 0)
            {
                leftButton.Behavior = SideButtonBehavior.SpinDown;
                rightButton.Behavior = SideButtonBehavior.SpinUp;
            }
            else
            {
                leftButton.Behavior = SideButtonBehavior.SpinUp;
                rightButton.Behavior = SideButtonBehavior.SpinDown;
            }
            AddButtons(leftButton, rightButton, control);
        }

        // コントロールにサイドボタンを追加
        void AddButtons(SideButtonBase leftButton, SideButtonBase rightButton, EditBase control)
        {
            ChangePosition(leftButton, rightButton);

            if (control is GcMask)
            {
                ((GcMask)control).SideButtons.Add(leftButton);
                ((GcMask)control).SideButtons.Add(rightButton);
            }
            else if (control is GcDateTime || control is GcDate || control is GcTime)
            {
                ((GcDateTime)control).SideButtons.Add(leftButton);
                ((GcDateTime)control).SideButtons.Add(rightButton);
            }
            else if (control is GcTimeSpan)
            {
                ((GcTimeSpan)control).SideButtons.Add(leftButton);
                ((GcTimeSpan)control).SideButtons.Add(rightButton);
            }
            else if (control is GcNumber)
            {
                ((GcNumber)control).SideButtons.Add(leftButton);
                ((GcNumber)control).SideButtons.Add(rightButton);
            }
            else if (control is GcComboBox)
            {
                ((GcComboBox)control).SideButtons.Add(leftButton);
                ((GcComboBox)control).SideButtons.Add(rightButton);
            }
            else if (control is GcMaskedComboBox )
            {
                ((GcMaskedComboBox)control).SideButtons.Add(leftButton);
                ((GcMaskedComboBox)control).SideButtons.Add(rightButton);
            }

        }

        // ボタンの表示位置
        void ChangePosition(SideButtonBase leftButton, SideButtonBase rightButton)
        {
            if (gcComboBox3.SelectedIndex == 0)
            {
                leftButton.Position = ButtonPosition.RightInside;
                rightButton.Position = ButtonPosition.RightInside;
            }
            else if (gcComboBox3.SelectedIndex == 1)
            {
                leftButton.Position = ButtonPosition.LeftInside;
                rightButton.Position = ButtonPosition.LeftInside;
            }
            else if (gcComboBox3.SelectedIndex == 2)
            {
                leftButton.Position = ButtonPosition.LeftInside;
                rightButton.Position = ButtonPosition.RightInside;
            }
        }
    }
}
