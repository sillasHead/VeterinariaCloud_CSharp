using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            opdImg.FileName = "imagem";
            opdImg.Title = "SELECIONE UMA IMAGEM";
            opdImg.Filter = "JPEG|*.JPG|PNG|*.png";
            opdImg.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.Image = Image.FromFile(opdImg.FileName);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ApiTeste.FuncaoApi();
        }
    }
}
