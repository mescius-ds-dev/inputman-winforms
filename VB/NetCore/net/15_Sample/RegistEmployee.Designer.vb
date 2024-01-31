Namespace _15_Sample
    Partial Class RegistEmployee

        'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Windows フォーム デザイナーで必要です。
        Private components As System.ComponentModel.IContainer

        'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
        'Windows フォーム デザイナーを使用して変更できます。  
        'コード エディターを使って変更しないでください。
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            components = New ComponentModel.Container()
            button2 = New Windows.Forms.Button()
            button1 = New Windows.Forms.Button()
            GcTextBox3 = New GrapeCity.Win.Editors.GcTextBox(components)
            label11 = New Windows.Forms.Label()
            GcComboBox1 = New GrapeCity.Win.Editors.GcComboBox(components)
            dropDownButton3 = New GrapeCity.Win.Editors.DropDownButton()
            label10 = New Windows.Forms.Label()
            GcMask2 = New GrapeCity.Win.Editors.GcMask(components)
            label9 = New Windows.Forms.Label()
            GcAddressBox1 = New GrapeCity.Win.Editors.GcAddressBox(components)
            label8 = New Windows.Forms.Label()
            GcPostal1 = New GrapeCity.Win.Editors.GcPostal(components)
            label7 = New Windows.Forms.Label()
            GcMask1 = New GrapeCity.Win.Editors.GcMask(components)
            label6 = New Windows.Forms.Label()
            GcDate1 = New GrapeCity.Win.Editors.GcDate(components)
            dropDownButton2 = New GrapeCity.Win.Editors.DropDownButton()
            label5 = New Windows.Forms.Label()
            GcTextBox2 = New GrapeCity.Win.Editors.GcTextBox(components)
            label4 = New Windows.Forms.Label()
            GcTextBox1 = New GrapeCity.Win.Editors.GcTextBox(components)
            label3 = New Windows.Forms.Label()
            GcNumber1 = New GrapeCity.Win.Editors.GcNumber(components)
            label2 = New Windows.Forms.Label()
            GcShortcut1 = New GrapeCity.Win.Editors.GcShortcut(components)
            GcJpAddress1 = New GrapeCity.Win.JPAddress.GcJPAddress()
            GcCommonValidator1 = New GrapeCity.Win.Editors.GcCommonValidator()
            GcIme1 = New GrapeCity.Win.Editors.GcIme()
            GcAddress1 = New GrapeCity.Win.Editors.GcAddress()
            GcDateValidator1 = New GrapeCity.Win.Editors.GcDateValidator()
            GcCustomValidator1 = New GrapeCity.Win.Editors.GcCustomValidator()
            panel1.SuspendLayout()
            CType(GcTextBox3, ComponentModel.ISupportInitialize).BeginInit()
            CType(GcComboBox1, ComponentModel.ISupportInitialize).BeginInit()
            CType(GcMask2, ComponentModel.ISupportInitialize).BeginInit()
            CType(GcAddressBox1, ComponentModel.ISupportInitialize).BeginInit()
            CType(GcPostal1, ComponentModel.ISupportInitialize).BeginInit()
            CType(GcMask1, ComponentModel.ISupportInitialize).BeginInit()
            CType(GcDate1, ComponentModel.ISupportInitialize).BeginInit()
            CType(GcTextBox2, ComponentModel.ISupportInitialize).BeginInit()
            CType(GcTextBox1, ComponentModel.ISupportInitialize).BeginInit()
            CType(GcNumber1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' panel1
            ' 
            panel1.Controls.Add(button2)
            panel1.Controls.Add(button1)
            panel1.Controls.Add(GcTextBox3)
            panel1.Controls.Add(label11)
            panel1.Controls.Add(GcComboBox1)
            panel1.Controls.Add(label10)
            panel1.Controls.Add(GcMask2)
            panel1.Controls.Add(label9)
            panel1.Controls.Add(GcAddressBox1)
            panel1.Controls.Add(label8)
            panel1.Controls.Add(GcPostal1)
            panel1.Controls.Add(label7)
            panel1.Controls.Add(GcMask1)
            panel1.Controls.Add(label6)
            panel1.Controls.Add(GcDate1)
            panel1.Controls.Add(label5)
            panel1.Controls.Add(GcTextBox2)
            panel1.Controls.Add(label4)
            panel1.Controls.Add(GcTextBox1)
            panel1.Controls.Add(label3)
            panel1.Controls.Add(GcNumber1)
            panel1.Controls.Add(label2)
            panel1.Size = New Drawing.Size(708, 392)
            ' 
            ' button2
            ' 
            button2.Location = New Drawing.Point(341, 359)
            button2.Name = "button2"
            button2.Size = New Drawing.Size(166, 22)
            button2.TabIndex = 42
            button2.Text = "登録"
            button2.UseVisualStyleBackColor = True
            ' 
            ' button1
            ' 
            button1.Location = New Drawing.Point(12, 359)
            button1.Name = "button1"
            button1.Size = New Drawing.Size(166, 22)
            button1.TabIndex = 43
            button1.Text = "クリア"
            button1.UseVisualStyleBackColor = True
            ' 
            ' GcTextBox3
            ' 
            GcTextBox3.Location = New Drawing.Point(12, 250)
            GcTextBox3.Name = "GcTextBox3"
            GcTextBox3.Size = New Drawing.Size(495, 103)
            GcTextBox3.TabIndex = 41
            GcTextBox3.Tag = ""
            ' 
            ' label11
            ' 
            label11.AutoSize = True
            label11.Location = New Drawing.Point(12, 229)
            label11.Name = "label11"
            label11.Size = New Drawing.Size(56, 18)
            label11.TabIndex = 40
            label11.Text = "通信欄："
            ' 
            ' GcComboBox1
            ' 
            GcComboBox1.ListHeaderPane.Height = 25
            GcComboBox1.Location = New Drawing.Point(188, 206)
            GcComboBox1.Name = "GcComboBox1"
            GcComboBox1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {dropDownButton3})
            GcComboBox1.Size = New Drawing.Size(224, 20)
            GcComboBox1.TabIndex = 39
            GcComboBox1.Tag = ""
            ' 
            ' dropDownButton3
            ' 
            dropDownButton3.Name = "dropDownButton3"
            ' 
            ' label10
            ' 
            label10.AutoSize = True
            label10.Location = New Drawing.Point(188, 185)
            label10.Name = "label10"
            label10.Size = New Drawing.Size(56, 18)
            label10.TabIndex = 38
            label10.Text = "部署名："
            ' 
            ' GcMask2
            ' 
            GcMask2.Location = New Drawing.Point(12, 206)
            GcMask2.Name = "GcMask2"
            GcMask2.Size = New Drawing.Size(170, 20)
            GcMask2.TabIndex = 37
            GcMask2.Tag = ""
            ' 
            ' label9
            ' 
            label9.AutoSize = True
            label9.Location = New Drawing.Point(12, 185)
            label9.Name = "label9"
            label9.Size = New Drawing.Size(44, 18)
            label9.TabIndex = 36
            label9.Text = "内線："
            ' 
            ' GcAddressBox1
            ' 
            GcAddressBox1.Location = New Drawing.Point(188, 162)
            GcAddressBox1.Name = "GcAddressBox1"
            GcAddressBox1.Size = New Drawing.Size(318, 20)
            GcAddressBox1.TabIndex = 35
            GcAddressBox1.Tag = ""
            ' 
            ' label8
            ' 
            label8.AutoSize = True
            label8.Location = New Drawing.Point(188, 141)
            label8.Name = "label8"
            label8.Size = New Drawing.Size(44, 18)
            label8.TabIndex = 34
            label8.Text = "住所："
            ' 
            ' GcPostal1
            ' 
            GcPostal1.Fields.ZipCodeSeparator.Text = "-"
            GcPostal1.Location = New Drawing.Point(12, 162)
            GcPostal1.Name = "GcPostal1"
            GcPostal1.Size = New Drawing.Size(170, 20)
            GcPostal1.TabIndex = 33
            GcPostal1.Tag = ""
            ' 
            ' label7
            ' 
            label7.AutoSize = True
            label7.Location = New Drawing.Point(12, 141)
            label7.Name = "label7"
            label7.Size = New Drawing.Size(68, 18)
            label7.TabIndex = 32
            label7.Text = "郵便番号："
            ' 
            ' GcMask1
            ' 
            GcMask1.Location = New Drawing.Point(188, 118)
            GcMask1.Name = "GcMask1"
            GcMask1.Size = New Drawing.Size(170, 20)
            GcMask1.TabIndex = 31
            GcMask1.Tag = ""
            ' 
            ' label6
            ' 
            label6.AutoSize = True
            label6.Location = New Drawing.Point(188, 97)
            label6.Name = "label6"
            label6.Size = New Drawing.Size(68, 18)
            label6.TabIndex = 30
            label6.Text = "電話番号："
            ' 
            ' GcDate1
            ' 
            GcDate1.Location = New Drawing.Point(12, 118)
            GcDate1.Name = "GcDate1"
            GcDate1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {dropDownButton2})
            GcDate1.Size = New Drawing.Size(170, 20)
            GcDate1.TabIndex = 29
            GcDate1.Tag = ""
            GcDate1.Value = New Date(2023, 6, 21, 0, 0, 0, 0)
            ' 
            ' dropDownButton2
            ' 
            dropDownButton2.Name = "dropDownButton2"
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.Location = New Drawing.Point(12, 97)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(68, 18)
            label5.TabIndex = 28
            label5.Text = "生年月日："
            ' 
            ' GcTextBox2
            ' 
            GcTextBox2.Location = New Drawing.Point(188, 74)
            GcTextBox2.Name = "GcTextBox2"
            GcTextBox2.Size = New Drawing.Size(170, 20)
            GcTextBox2.TabIndex = 27
            GcTextBox2.Tag = ""
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.Location = New Drawing.Point(188, 53)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(68, 18)
            label4.TabIndex = 26
            label4.Text = "フリガナ："
            ' 
            ' GcTextBox1
            ' 
            GcTextBox1.Location = New Drawing.Point(12, 74)
            GcTextBox1.Name = "GcTextBox1"
            GcTextBox1.Size = New Drawing.Size(170, 20)
            GcTextBox1.TabIndex = 25
            GcTextBox1.Tag = ""
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.Location = New Drawing.Point(12, 53)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(56, 18)
            label3.TabIndex = 24
            label3.Text = "社員名："
            ' 
            ' GcNumber1
            ' 
            GcNumber1.Fields.IntegerPart.MinDigits = 1
            GcNumber1.Location = New Drawing.Point(12, 30)
            GcNumber1.Name = "GcNumber1"
            GcNumber1.Size = New Drawing.Size(100, 20)
            GcNumber1.TabIndex = 23
            GcNumber1.Tag = ""
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Location = New Drawing.Point(12, 9)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(68, 18)
            label2.TabIndex = 22
            label2.Text = "社員番号："
            ' 
            ' RegistEmployee
            ' 
            AutoScaleDimensions = New Drawing.SizeF(7F, 18F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            Description = "氏名や住所などの自動入力、フォーカス移動、エラーチェックなどの機能を備えた、社員情報入力画面を作成する方法を紹介します。"
            Name = "RegistEmployee"
            Size = New Drawing.Size(800, 503)
            Title = "社員情報入力"
            panel1.ResumeLayout(False)
            panel1.PerformLayout()
            CType(GcTextBox3, ComponentModel.ISupportInitialize).EndInit()
            CType(GcComboBox1, ComponentModel.ISupportInitialize).EndInit()
            CType(GcMask2, ComponentModel.ISupportInitialize).EndInit()
            CType(GcAddressBox1, ComponentModel.ISupportInitialize).EndInit()
            CType(GcPostal1, ComponentModel.ISupportInitialize).EndInit()
            CType(GcMask1, ComponentModel.ISupportInitialize).EndInit()
            CType(GcDate1, ComponentModel.ISupportInitialize).EndInit()
            CType(GcTextBox2, ComponentModel.ISupportInitialize).EndInit()
            CType(GcTextBox1, ComponentModel.ISupportInitialize).EndInit()
            CType(GcNumber1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Private WithEvents button2 As Windows.Forms.Button
        Private WithEvents button1 As Windows.Forms.Button
        Private WithEvents GcTextBox3 As GrapeCity.Win.Editors.GcTextBox
        Private WithEvents label11 As Windows.Forms.Label
        Private WithEvents GcComboBox1 As GrapeCity.Win.Editors.GcComboBox
        Private WithEvents dropDownButton3 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents label10 As Windows.Forms.Label
        Private WithEvents GcMask2 As GrapeCity.Win.Editors.GcMask
        Private WithEvents label9 As Windows.Forms.Label
        Private WithEvents GcAddressBox1 As GrapeCity.Win.Editors.GcAddressBox
        Private WithEvents label8 As Windows.Forms.Label
        Private WithEvents GcPostal1 As GrapeCity.Win.Editors.GcPostal
        Private WithEvents label7 As Windows.Forms.Label
        Private WithEvents GcMask1 As GrapeCity.Win.Editors.GcMask
        Private WithEvents label6 As Windows.Forms.Label
        Private WithEvents GcDate1 As GrapeCity.Win.Editors.GcDate
        Private WithEvents dropDownButton2 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents label5 As Windows.Forms.Label
        Private WithEvents GcTextBox2 As GrapeCity.Win.Editors.GcTextBox
        Private WithEvents label4 As Windows.Forms.Label
        Private WithEvents GcTextBox1 As GrapeCity.Win.Editors.GcTextBox
        Private WithEvents label3 As Windows.Forms.Label
        Private WithEvents GcNumber1 As GrapeCity.Win.Editors.GcNumber
        Private WithEvents label2 As Windows.Forms.Label
        Private WithEvents GcShortcut1 As GrapeCity.Win.Editors.GcShortcut
        Private WithEvents GcJpAddress1 As GrapeCity.Win.JPAddress.GcJPAddress
        Private WithEvents GcCommonValidator1 As GrapeCity.Win.Editors.GcCommonValidator
        Private WithEvents GcIme1 As GrapeCity.Win.Editors.GcIme
        Private WithEvents GcAddress1 As GrapeCity.Win.Editors.GcAddress
        Private WithEvents GcDateValidator1 As GrapeCity.Win.Editors.GcDateValidator
        Private WithEvents GcCustomValidator1 As GrapeCity.Win.Editors.GcCustomValidator
    End Class
End Namespace
