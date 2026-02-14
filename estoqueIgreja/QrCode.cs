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
            GerarQrCode("https://onedrive.live.com/:x:/g/personal/B1504845243E51DC/IQC6FT95Ole1R4EcAED0wjlKAVjUD9t0xB_IYl76ox-TSrE?resid=B1504845243E51DC!s793f15ba573a47b5811c0040f4c2394a&ithint=file%2Cxlsx&e=cymKRm&migratedtospo=true&redeem=aHR0cHM6Ly8xZHJ2Lm1zL3gvYy9iMTUwNDg0NTI0M2U1MWRjL0lRQzZGVDk1T2xlMVI0RWNBRUQwd2psS0FWalVEOXQweEJfSVlsNzZveC1UU3JFP2U9Y3ltS1Jt");
           
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
