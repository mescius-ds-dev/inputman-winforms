namespace InputManWin12_Demo
{
    partial class FirstViewPage
    {
        /// <summary> 
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナで生成されたコード

        /// <summary> 
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.product1 = new System.Windows.Forms.Label();
            this.product2 = new System.Windows.Forms.Label();
            this.product3 = new System.Windows.Forms.Label();
            this.product_body = new System.Windows.Forms.Label();
            this.mainvisual = new System.Windows.Forms.PictureBox();
            this.product_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainvisual)).BeginInit();
            this.SuspendLayout();
            // 
            // product1
            // 
            this.product1.AutoSize = true;
            this.product1.BackColor = System.Drawing.Color.Transparent;
            this.product1.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.product1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.product1.Location = new System.Drawing.Point(32, 267);
            this.product1.Name = "product1";
            this.product1.Size = new System.Drawing.Size(259, 28);
            this.product1.TabIndex = 1;
            this.product1.Text = "日本仕様入力コンポーネント";
            // 
            // product2
            // 
            this.product2.AutoSize = true;
            this.product2.BackColor = System.Drawing.Color.Transparent;
            this.product2.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.product2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.product2.Location = new System.Drawing.Point(29, 295);
            this.product2.Name = "product2";
            this.product2.Size = new System.Drawing.Size(170, 48);
            this.product2.TabIndex = 1;
            this.product2.Text = "InputMan";
            // 
            // product3
            // 
            this.product3.AutoSize = true;
            this.product3.BackColor = System.Drawing.Color.Transparent;
            this.product3.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.product3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.product3.Location = new System.Drawing.Point(197, 309);
            this.product3.Name = "product3";
            this.product3.Size = new System.Drawing.Size(190, 28);
            this.product3.TabIndex = 1;
            this.product3.Text = "for Windows Forms";
            // 
            // product_body
            // 
            this.product_body.AutoSize = true;
            this.product_body.BackColor = System.Drawing.Color.Transparent;
            this.product_body.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.product_body.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.product_body.Location = new System.Drawing.Point(34, 378);
            this.product_body.Name = "product_body";
            this.product_body.Size = new System.Drawing.Size(556, 72);
            this.product_body.TabIndex = 1;
            this.product_body.Text = "InputMan for Windows Formsは、入力インタフェース構築を支援するコンポーネントセットです。 \r\nテキスト、マスク、日付、数値などの用途別に" +
                "最適化された入力コントロールと、\r\nノンコーディングでチェック機能を実装できる検証コンポーネント。\r\n入力に欠かせないIME制御や住所検索機能を提供するコンポー" +
                "ネント群から構成されています。 ";
            // 
            // mainvisual
            // 
            this.mainvisual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.mainvisual.BackgroundImage = global::InputManWin12_Demo.Properties.Resources.mainvisual;
            this.mainvisual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainvisual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainvisual.Location = new System.Drawing.Point(0, 0);
            this.mainvisual.Name = "mainvisual";
            this.mainvisual.Size = new System.Drawing.Size(724, 500);
            this.mainvisual.TabIndex = 0;
            this.mainvisual.TabStop = false;
            // 
            // product_title
            // 
            this.product_title.AutoSize = true;
            this.product_title.BackColor = System.Drawing.Color.Transparent;
            this.product_title.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.product_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(54)))), ((int)(((byte)(107)))));
            this.product_title.Location = new System.Drawing.Point(32, 350);
            this.product_title.Name = "product_title";
            this.product_title.Size = new System.Drawing.Size(505, 23);
            this.product_title.TabIndex = 1;
            this.product_title.Text = "日本の業務アプリケーション支援する、日本生まれの入力コンポーネント";
            // 
            // FirstViewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.product2);
            this.Controls.Add(this.product3);
            this.Controls.Add(this.product_body);
            this.Controls.Add(this.product_title);
            this.Controls.Add(this.product1);
            this.Controls.Add(this.mainvisual);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "FirstViewPage";
            this.Size = new System.Drawing.Size(724, 500);
            ((System.ComponentModel.ISupportInitialize)(this.mainvisual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainvisual;
        private System.Windows.Forms.Label product1;
        private System.Windows.Forms.Label product2;
        private System.Windows.Forms.Label product3;
        private System.Windows.Forms.Label product_body;
        private System.Windows.Forms.Label product_title;

    }
}
