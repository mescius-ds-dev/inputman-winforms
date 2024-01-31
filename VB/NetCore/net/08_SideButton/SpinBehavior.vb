Imports GrapeCity.Win.Editors

Namespace _08_SideButton
    Partial Public Class SpinBehavior
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            ' ***** 初期設定
            gcComboBox2.SelectedIndex = 0
            gcComboBox3.SelectedIndex = 0
            gcComboBox3.Enabled = False
            gcComboBox4.SelectedIndex = 0
            gcComboBox4.Enabled = False

            GcMaskedComboBox1.SelectedIndex = 0

        End Sub

        Private Sub gcComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            ' サイドボタンをクリア
            gcMask1.SideButtons.Clear()
            gcDateTime1.SideButtons.Clear()
            gcDate1.SideButtons.Clear()
            gcTime1.SideButtons.Clear()
            gcTimeSpan1.SideButtons.Clear()
            gcNumber1.SideButtons.Clear()
            gcComboBox1.SideButtons.Clear()
            GcMaskedComboBox1.SideButtons.Clear()

            If gcComboBox2.SelectedIndex = 0 Then
                gcComboBox3.Enabled = False
                gcComboBox4.Enabled = False

                ' スピンボタンを追加
                gcMask1.SideButtons.Add(New GrapeCity.Win.Editors.SpinButton())
                gcDateTime1.SideButtons.Add(New GrapeCity.Win.Editors.SpinButton())
                gcDate1.SideButtons.Add(New GrapeCity.Win.Editors.SpinButton())
                gcTime1.SideButtons.Add(New GrapeCity.Win.Editors.SpinButton())
                gcTimeSpan1.SideButtons.Add(New GrapeCity.Win.Editors.SpinButton())
                gcNumber1.SideButtons.Add(New GrapeCity.Win.Editors.SpinButton())
                gcComboBox1.SideButtons.Add(New GrapeCity.Win.Editors.SpinButton())
                GcMaskedComboBox1.SideButtons.Add(New GrapeCity.Win.Editors.SpinButton())
            ElseIf gcComboBox2.SelectedIndex = 1 Then
                gcComboBox3.Enabled = True
                gcComboBox4.Enabled = True

                ' スピン機能を割り当てたサイドボタンを追加
                AddSideButtons(gcMask1)
                AddSideButtons(gcDateTime1)
                AddSideButtons(gcDate1)
                AddSideButtons(gcTime1)
                AddSideButtons(gcTimeSpan1)
                AddSideButtons(gcNumber1)
                AddSideButtons(gcComboBox1)
                AddSideButtons(GcMaskedComboBox1)
            ElseIf gcComboBox2.SelectedIndex = 2 Then
                gcComboBox3.Enabled = True
                gcComboBox4.Enabled = True

                ' スピン機能を割り当てたシンボルボタンを追加
                AddSymbolButtons(gcMask1)
                AddSymbolButtons(gcDateTime1)
                AddSymbolButtons(gcDate1)
                AddSymbolButtons(gcTime1)
                AddSymbolButtons(gcTimeSpan1)
                AddSymbolButtons(gcNumber1)
                AddSymbolButtons(gcComboBox1)
                AddSymbolButtons(GcMaskedComboBox1)
            End If
        End Sub

        Private Sub gcComboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox3.SelectedIndexChanged
            If gcComboBox2.SelectedIndex = 0 Then
                Return
            End If

            ' ボタンの表示位置を変更
            ChangePosition(gcMask1.SideButtons(0), gcMask1.SideButtons(1))
            ChangePosition(gcDateTime1.SideButtons(0), gcDateTime1.SideButtons(1))
            ChangePosition(gcDate1.SideButtons(0), gcDate1.SideButtons(1))
            ChangePosition(gcTime1.SideButtons(0), gcTime1.SideButtons(1))
            ChangePosition(gcTimeSpan1.SideButtons(0), gcTimeSpan1.SideButtons(1))
            ChangePosition(gcNumber1.SideButtons(0), gcNumber1.SideButtons(1))
            ChangePosition(gcComboBox1.SideButtons(0), gcComboBox1.SideButtons(1))
            ChangePosition(GcMaskedComboBox1.SideButtons(0), GcMaskedComboBox1.SideButtons(1))
        End Sub

        Private Sub gcComboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox4.SelectedIndexChanged
            If gcComboBox2.SelectedIndex = 0 Then
                Return
            End If

            ' サイドボタンをクリア
            gcMask1.SideButtons.Clear()
            gcDateTime1.SideButtons.Clear()
            gcDate1.SideButtons.Clear()
            gcTime1.SideButtons.Clear()
            gcTimeSpan1.SideButtons.Clear()
            gcNumber1.SideButtons.Clear()
            gcComboBox1.SideButtons.Clear()
            GcMaskedComboBox1.SideButtons.Clear()

            If gcComboBox2.SelectedIndex = 1 Then
                ' スピン機能を割り当てたサイドボタンを追加
                AddSideButtons(gcMask1)
                AddSideButtons(gcDateTime1)
                AddSideButtons(gcDate1)
                AddSideButtons(gcTime1)
                AddSideButtons(gcTimeSpan1)
                AddSideButtons(gcNumber1)
                AddSideButtons(gcComboBox1)
                AddSideButtons(GcMaskedComboBox1)
            ElseIf gcComboBox2.SelectedIndex = 2 Then
                ' スピン機能を割り当てたシンボルボタンを追加
                AddSymbolButtons(gcMask1)
                AddSymbolButtons(gcDateTime1)
                AddSymbolButtons(gcDate1)
                AddSymbolButtons(gcTime1)
                AddSymbolButtons(gcTimeSpan1)
                AddSymbolButtons(gcNumber1)
                AddSymbolButtons(gcComboBox1)
                AddSymbolButtons(GcMaskedComboBox1)
            End If
        End Sub

        ' スピン機能を持つサイドボタンを追加
        Private Sub AddSideButtons(ByVal control As EditBase)
            Dim leftButton As GrapeCity.Win.Editors.SideButton = New GrapeCity.Win.Editors.SideButton()
            Dim rightButton As GrapeCity.Win.Editors.SideButton = New GrapeCity.Win.Editors.SideButton()

            ' SideButtonBehaviorプロパティ
            If gcComboBox4.SelectedIndex = 0 Then
                leftButton.Behavior = SideButtonBehavior.SpinDown
                rightButton.Behavior = SideButtonBehavior.SpinUp
            Else
                leftButton.Behavior = SideButtonBehavior.SpinUp
                rightButton.Behavior = SideButtonBehavior.SpinDown
            End If

            AddButtons(leftButton, rightButton, control)
        End Sub

        ' スピン機能を持つシンボルボタンを追加
        Private Sub AddSymbolButtons(ByVal control As EditBase)
            Dim leftButton As GrapeCity.Win.Editors.SymbolButton = New GrapeCity.Win.Editors.SymbolButton()
            Dim rightButton As GrapeCity.Win.Editors.SymbolButton = New GrapeCity.Win.Editors.SymbolButton()

            ' SideButtonBehaviorプロパティ
            If gcComboBox4.SelectedIndex = 0 Then
                leftButton.Behavior = SideButtonBehavior.SpinDown
                rightButton.Behavior = SideButtonBehavior.SpinUp
            Else
                leftButton.Behavior = SideButtonBehavior.SpinUp
                rightButton.Behavior = SideButtonBehavior.SpinDown
            End If

            AddButtons(leftButton, rightButton, control)
        End Sub

        ' コントロールにサイドボタンを追加
        Private Sub AddButtons(ByVal leftButton As SideButtonBase, ByVal rightButton As SideButtonBase, ByVal control As EditBase)
            ChangePosition(leftButton, rightButton)

            If TypeOf control Is GcMask Then
                TryCast(control, GcMask).SideButtons.Add(leftButton)
                TryCast(control, GcMask).SideButtons.Add(rightButton)
            ElseIf TypeOf control Is GcDateTime Or TypeOf control Is GcDate Or TypeOf control Is GcTime Then
                TryCast(control, GcDateTime).SideButtons.Add(leftButton)
                TryCast(control, GcDateTime).SideButtons.Add(rightButton)
            ElseIf TypeOf control Is GcTimeSpan Then
                TryCast(control, GcTimeSpan).SideButtons.Add(leftButton)
                TryCast(control, GcTimeSpan).SideButtons.Add(rightButton)
            ElseIf TypeOf control Is GcNumber Then
                TryCast(control, GcNumber).SideButtons.Add(leftButton)
                TryCast(control, GcNumber).SideButtons.Add(rightButton)
            ElseIf TypeOf control Is GrapeCity.Win.Editors.GcComboBox Then
                TryCast(control, GrapeCity.Win.Editors.GcComboBox).SideButtons.Add(leftButton)
                TryCast(control, GrapeCity.Win.Editors.GcComboBox).SideButtons.Add(rightButton)
            ElseIf TypeOf control Is GrapeCity.Win.Editors.GcMaskedComboBox Then
                TryCast(control, GrapeCity.Win.Editors.GcMaskedComboBox).SideButtons.Add(leftButton)
                TryCast(control, GrapeCity.Win.Editors.GcMaskedComboBox).SideButtons.Add(rightButton)
            End If
        End Sub

        ' ボタンの表示位置
        Private Sub ChangePosition(ByVal leftButton As SideButtonBase, ByVal rightButton As SideButtonBase)
            If gcComboBox3.SelectedIndex = 0 Then
                leftButton.Position = ButtonPosition.RightInside
                rightButton.Position = ButtonPosition.RightInside
            ElseIf gcComboBox3.SelectedIndex = 1 Then
                leftButton.Position = ButtonPosition.LeftInside
                rightButton.Position = ButtonPosition.LeftInside
            ElseIf gcComboBox3.SelectedIndex = 2 Then
                leftButton.Position = ButtonPosition.LeftInside
                rightButton.Position = ButtonPosition.RightInside
            End If
        End Sub
    End Class
End Namespace
