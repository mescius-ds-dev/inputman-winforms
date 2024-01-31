using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace InputManWin12_Demo
{
    public partial class FirstViewPage : UserControl
    {
        public FirstViewPage()
        {
            InitializeComponent();

            this.Load += new System.EventHandler(this.FirstViewPage_Load);
        }

        private void FirstViewPage_Load(object sender, EventArgs e)
        {
            // ラベルの背景をPictureBoxコントロールに対して透過にする
            mainvisual.Controls.Add(product1);
            mainvisual.Controls.Add(product2);
            mainvisual.Controls.Add(product3);
            mainvisual.Controls.Add(product_body);
            mainvisual.Controls.Add(product_title);
        }
    }
}
