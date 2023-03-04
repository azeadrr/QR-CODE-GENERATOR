using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using System.IO;



namespace qr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            string qrData = TQrlink.Text;
            string qrImageFileName = TQrnamefile.Text;
            //check for textboxes
            if(string.IsNullOrEmpty(qrData) || string.IsNullOrEmpty(qrImageFileName))
            {
                MessageBox.Show("Provide data in textboxes!", "Error");
                return;
            }
            if(File.Exists(@"C:\Users\lenovo\Documents\qr\" + qrImageFileName + ".png"))
            {
                MessageBox.Show("File already exists!\nchoose another name", "Error");
                return;
            }
            BarcodeWriter barcodeW = new BarcodeWriter();
            barcodeW.Format = BarcodeFormat.QR_CODE;
            barcodeW.Write(qrData).Save(@"C:\Users\lenovo\Documents\qr\" + qrImageFileName + ".png");
            picgenerate.Image = Image.FromFile(@"C:\Users\lenovo\Documents\qr\" + qrImageFileName + ".png");
        }
    }
}
