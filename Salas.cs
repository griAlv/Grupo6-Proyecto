using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo6Proyecto
{
    public partial class Salas : Form
    {
        public Salas()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnH1_Click(object sender, EventArgs e)
        {
            Form1 principal = (Form1)this.ParentForm; // Obtiene Form1
            principal.abrirFormHija(new Registro()); // Abre Form3
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Salas_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void BtnH6_Click(object sender, EventArgs e)
        {
            Form1 principal = (Form1)this.ParentForm; // Obtiene Form1
            principal.abrirFormHija(new Registro()); // Abre Form3
        }

        private void BtnH5_Click(object sender, EventArgs e)
        {
            Form1 principal = (Form1)this.ParentForm; // Obtiene Form1
            principal.abrirFormHija(new Registro()); // Abre Form3
        }

        private void BtnH4_Click(object sender, EventArgs e)
        {
            Form1 principal = (Form1)this.ParentForm; // Obtiene Form1
            principal.abrirFormHija(new Registro()); // Abre Form3
        }

        private void BtnH3_Click(object sender, EventArgs e)
        {
            Form1 principal = (Form1)this.ParentForm; // Obtiene Form1
            principal.abrirFormHija(new Registro()); // Abre Form3
        }

        private void BtnH2_Click(object sender, EventArgs e)
        {
            Form1 principal = (Form1)this.ParentForm; // Obtiene Form1
            principal.abrirFormHija(new Registro()); // Abre Form3
        }
    }
}
