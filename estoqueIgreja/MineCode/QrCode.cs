using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace estoqueIgreja
{
    public partial class QrCode : Form
    {
        public QrCode()
        {
            InitializeComponent();
            GerarQrCode(); //O link do site ficaria aqui
           
        }

        private void GerarQrCode(string url)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);

            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrImage = qrCode.GetGraphic(20);

            pictureBox1.Image = qrImage;
        }
    }
}
