Imports System.Drawing
Imports GrapeCity.Win.Editors

Namespace _12_Address
    Partial Public Class GcAddress
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            ' ***** 初期値
            checkBox1.Checked = gcAddress1.GetAddressOutputSetting(gcCharMask1).ClearTarget
            gcComboBox1.SelectedIndex = CType(gcAddress1.GetAddressOutputSetting(gcCharMask1).AddressQuerymode, Int32) - 1
            checkBox3.Enabled = False

            gcTextBox1.Enabled = False
            gcTextBox2.Enabled = False
            gcTextBox3.Enabled = False
            gcTextBox4.Enabled = False
            gcTextBox5.Enabled = False
            gcTextBox1.DisabledForeColor = Color.Black
            gcTextBox2.DisabledForeColor = Color.Black
            gcTextBox3.DisabledForeColor = Color.Black
            gcTextBox4.DisabledForeColor = Color.Black
            gcTextBox5.DisabledForeColor = Color.Black
        End Sub

        Private Sub gcComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox1.SelectedIndexChanged
            ' AddressQueryMode プロパティ
            gcAddress1.GetAddressOutputSetting(gcCharMask1).AddressQuerymode = CType(gcComboBox1.SelectedIndex + 1, AddressQuerymode)

            gcCharMask1.CharBoxes.Clear()
            gcCharMask1.AutoSize = True

            Dim borderSingle As New CharBoxBorder(New Line(LineStyle.[Single], Color.Black))
            Dim borderNone As New CharBoxBorder(New Line(LineStyle.None, Color.Empty))

            ' 郵便番号の前の3桁用の枠を作成します。  
            Dim aInputBoxl As New InputBox()
            aInputBoxl.AutoSize = False
            aInputBoxl.Size = New System.Drawing.Size(17, 20)
            aInputBoxl.Border = borderSingle
            aInputBoxl.Margin = New System.Windows.Forms.Padding(2)

            ' ハイフンを作成します。  
            Dim aSeparatorBox As New SeparatorBox()
            aSeparatorBox.AutoSize = False
            aSeparatorBox.Size = New System.Drawing.Size(8, 20)
            aSeparatorBox.Border = borderNone
            aSeparatorBox.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
            aSeparatorBox.ResetFont()

            ' 郵便番号の後の4桁用の枠を作成します。  
            Dim aInputBoxs As New InputBox()
            aInputBoxs.AutoSize = False
            aInputBoxs.Size = New System.Drawing.Size(15, 17)
            aInputBoxs.Border = borderSingle
            aInputBoxs.Margin = New System.Windows.Forms.Padding(2)

            Select Case gcComboBox1.SelectedIndex
                Case 0, 1, 2
                    ' 郵便番号
                    gcCharMask1.CharBoxes.Add(DirectCast(aInputBoxl.Clone(), CharBox))
                    gcCharMask1.CharBoxes.Add(DirectCast(aInputBoxl.Clone(), CharBox))
                    gcCharMask1.CharBoxes.Add(DirectCast(aInputBoxl.Clone(), CharBox))
                    gcCharMask1.CharBoxes.Add(aSeparatorBox)
                    gcCharMask1.CharBoxes.Add(DirectCast(aInputBoxs.Clone(), CharBox))
                    gcCharMask1.CharBoxes.Add(DirectCast(aInputBoxs.Clone(), CharBox))
                    gcCharMask1.CharBoxes.Add(DirectCast(aInputBoxs.Clone(), CharBox))
                    gcCharMask1.CharBoxes.Add(DirectCast(aInputBoxs.Clone(), CharBox))
                    Exit Select
                Case 3
                    ' 市外局番
                    gcCharMask1.CharBoxes.Add(DirectCast(aInputBoxl.Clone(), CharBox))
                    gcCharMask1.CharBoxes.Add(DirectCast(aInputBoxl.Clone(), CharBox))
                    gcCharMask1.CharBoxes.Add(DirectCast(aInputBoxl.Clone(), CharBox))
                    gcCharMask1.CharBoxes.Add(DirectCast(aInputBoxl.Clone(), CharBox))
                    Exit Select
                Case 4
                    ' 全国地方公共団体コード
                    gcCharMask1.CharBoxes.Add(DirectCast(aInputBoxl.Clone(), CharBox))
                    gcCharMask1.CharBoxes.Add(DirectCast(aInputBoxl.Clone(), CharBox))
                    gcCharMask1.CharBoxes.Add(DirectCast(aInputBoxl.Clone(), CharBox))
                    gcCharMask1.CharBoxes.Add(DirectCast(aInputBoxl.Clone(), CharBox))
                    gcCharMask1.CharBoxes.Add(DirectCast(aInputBoxl.Clone(), CharBox))
                    Exit Select
                Case Else
                    Exit Select
            End Select

            Select Case gcComboBox1.SelectedIndex
                Case 0
                    label2.Text = "住所の郵便番号："
                    Exit Select
                Case 1
                    label2.Text = "事業所の個別郵便番号："
                    Exit Select
                Case 2
                    label2.Text = "住所の郵便番号／事業所の個別郵便番号："
                    Exit Select
                Case 3
                    label2.Text = "市外局番："
                    Exit Select
                Case 4
                    label2.Text = "全国地方公共団体コード："
                    Exit Select
                Case Else
                    Exit Select
            End Select

            ' 出力／未出力対象のコントロールの色を変えます。
            Dim cOut As Color = gcTextBox1.DisabledBackColor
            Dim cNon As Color = Color.Silver
            Select Case gcComboBox1.SelectedIndex
                Case 0, 1, 2
                    gcTextBox1.DisabledBackColor = cOut
                    gcTextBox2.DisabledBackColor = cOut
                    gcTextBox3.DisabledBackColor = cOut
                    gcTextBox4.DisabledBackColor = cOut
                    gcTextBox5.DisabledBackColor = cNon
                    Exit Select
                Case 3
                    gcTextBox1.DisabledBackColor = cOut
                    gcTextBox2.DisabledBackColor = cNon
                    gcTextBox3.DisabledBackColor = cNon
                    gcTextBox4.DisabledBackColor = cNon
                    gcTextBox5.DisabledBackColor = cOut
                    Exit Select
                Case 4
                    gcTextBox1.DisabledBackColor = cOut
                    gcTextBox2.DisabledBackColor = cOut
                    gcTextBox3.DisabledBackColor = cNon
                    gcTextBox4.DisabledBackColor = cOut
                    gcTextBox5.DisabledBackColor = cNon
                    Exit Select
                Case Else
                    Exit Select
            End Select

            If gcComboBox1.SelectedIndex = 1 OrElse gcComboBox1.SelectedIndex = 2 Then
                checkBox3.Enabled = True
                checkBox3.Checked = gcAddress1.GetAddressOutputSetting(gcCharMask1).GenerateCompanyAddressKana
            Else
                checkBox3.Enabled = False
            End If

            gcTextBox1.Clear()
            gcTextBox2.Clear()
            gcTextBox3.Clear()
            gcTextBox4.Clear()
            gcTextBox5.Clear()
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            ' ClearTargetプロパティ
            gcAddress1.GetAddressOutputSetting(gcCharMask1).ClearTarget = checkBox1.Checked
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
            Dim val As String = gcCharMask1.Value

            ' SplitAreaDetailsプロパティ
            gcAddress1.GetAddressOutputSetting(gcCharMask1).SplitAreaDetails = checkBox2.Checked

            gcCharMask1.Clear()
            gcCharMask1.Value = val
        End Sub

        Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox3.CheckedChanged
            Dim val As String = gcCharMask1.Value

            ' GenerateCompanyAddressKanaプロパティ
            gcAddress1.GetAddressOutputSetting(gcCharMask1).GenerateCompanyAddressKana = checkBox3.Checked

            gcCharMask1.Clear()
            gcCharMask1.Value = val
        End Sub
    End Class
End Namespace
