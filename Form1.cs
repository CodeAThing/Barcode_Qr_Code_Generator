using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;

namespace Barcode_Qr_Code_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn_QrCode_Click_1(object sender, EventArgs e)
        {
            CodeQrBarcodeDraw QrCode = BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = QrCode.Draw(txt_code.Text, 60);
        }
        private void btn_barcode_Click(object sender, EventArgs e)
        {
            Code128BarcodeDraw barcode = BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = barcode.Draw(txt_code.Text, 60);
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
          colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
            menuStrip1.BackColor = colorDialog1.Color;
            
        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.ForeColor= colorDialog1.Color;
            menuStrip1.ForeColor = colorDialog1.Color;
            
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
