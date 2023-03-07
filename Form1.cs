using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PictureBox pc=new PictureBox();
            
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
