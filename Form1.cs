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

namespace QRcodigo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string contenido = txtContenido.Text;

            QRCodeGenerator qrGEnerador = new QRCodeGenerator();
            QRCodeData qrDatos = qrGEnerador.CreateQrCode(contenido, QRCodeGenerator.ECCLevel.H);
            QRCode qrCodigo = new QRCode(qrDatos);

           Bitmap qrImagen = qrCodigo.GetGraphic(5, Color.Black, Color.White, true);
           pictureBox.Image = qrImagen;
        }
    }
}
