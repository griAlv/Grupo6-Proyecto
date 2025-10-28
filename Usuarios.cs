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
        private double precio;
        private int combo1,combo2,combo3;
        private double totalPrecio;


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

       public string Sala
        {
            get { return sala; }
            set { sala = value; }
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

        public double Precios
        {
            get{ return precio; }
            set { precio = value; }
        }

        public int Combo1
        {
            get { return combo1; }
            set { combo1 = value; }
        }
        public int Combo2
        {
            get { return combo2;}
            set { combo2 = value; }
        }
        public int Combo3
        {
            get { return combo3; }
            set { combo3 = value; }
        }

        public double TotalCombo
        {
            get { return  totalPrecio; }
            set { totalPrecio = value; }
        }

        //metodo para calcularlo el precio segun el combo que elija
        public double Inscripciones(int Cant1,int Cant2,int Cant3)
        {
            combo1 = 10;
            combo2 = 20;
            combo3 = 25;

            totalPrecio = (combo1 * Cant1) + (combo2 * Cant2) + (combo3 * Cant3);
            return totalPrecio;

        }

    }
}
