using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo6Proyecto
{
    internal class Usuarios
    {
        private string nombre;
        private string apellidos;
        private string sala;
        private int identificacion;
        private DateTime fecha;
        private DateTime hora;
        


        public Usuarios() { }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public int Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public DateTime Horas
        {
            get { return hora; }
            set { hora = value; }
        }



    }
}
