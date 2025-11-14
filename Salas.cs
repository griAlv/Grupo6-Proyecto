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
        public string SalaSeleccionada { get; set; }
        public Salas()
        {
            InitializeComponent();

        }

        private void BtnH1_Click(object sender, EventArgs e)
        {
            string Sala = "Sala 1";

            Form1 principal = (Form1)this.ParentForm; // Obtiene Form1

            Registro formRegistro = new Registro();
            formRegistro.SalaSeleccionada = Sala;

            principal.abrirFormHija(formRegistro); // Abre Form3

          
            
        }

        private void BtnH6_Click(object sender, EventArgs e)
        {
            string Sala = "Sala 6";
            Form1 principal = (Form1)this.ParentForm; // Obtiene Form1
            Registro formRegistro = new Registro();
            formRegistro.SalaSeleccionada = Sala;
            principal.abrirFormHija(formRegistro); // Abre Form3
        }

        private void BtnH5_Click(object sender, EventArgs e)
        {
            string Sala = "Sala 5";
            Form1 principal = (Form1)this.ParentForm; // Obtiene Form1
            Registro formRegistro = new Registro();
            formRegistro.SalaSeleccionada = Sala;
            principal.abrirFormHija(formRegistro); // Abre Form3
        }

        private void BtnH4_Click(object sender, EventArgs e)
        {
            string Sala = "Sala 4";
            Form1 principal = (Form1)this.ParentForm; // Obtiene Form1
            Registro formRegistro = new Registro();
            formRegistro.SalaSeleccionada = Sala;
            principal.abrirFormHija(formRegistro); // Abre Form3
        }

        private void BtnH3_Click(object sender, EventArgs e)
        {
            string Sala = "Sala 3";
            Form1 principal = (Form1)this.ParentForm; // Obtiene Form1
            Registro formRegistro = new Registro();
            formRegistro.SalaSeleccionada = Sala;
            principal.abrirFormHija(formRegistro); // Abre Form3
        }

        private void BtnH2_Click(object sender, EventArgs e)
        {
            string Sala = "Sala 2";
            Form1 principal = (Form1)this.ParentForm; // Obtiene Form1
            Registro formRegistro = new Registro();
            formRegistro.SalaSeleccionada = Sala;
            principal.abrirFormHija(formRegistro); // Abre Form3
        }
    }
}
