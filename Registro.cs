using MySql.Data.MySqlClient;
using System;
using System.Globalization;
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
    public partial class Registro : Form
    {
        List<Usuarios> usuarios = new List<Usuarios>();
        string nombre, apellidos, salas, fechatx,horatx;
        int identificacion,plan1,plan2,plan3,PrecioTotal;
        public string SalaSeleccionada { get; set; }

        public Registro()
        {
            InitializeComponent();
            this.Load += Registro_Load;
        }


        private void Registro_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SalaSeleccionada))
            {
                
                cbxSalas.SelectedItem = SalaSeleccionada;

            }
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            TxtFecha.Text = monthCalendar1.SelectionStart.ToString("dd/MM/yyyy");
        }


        private void btnReservacion_Click(object sender, EventArgs e)
        {

            nombre = TxtNombre.Text;
            apellidos = TxtApellido.Text;

            //validaciones numericas
            try
            {
                if (string.IsNullOrEmpty(TxtIdentificacion.Text) || string.IsNullOrWhiteSpace(TxtIdentificacion.Text)) 
                {
                    MessageBox.Show("No se puede dejar en blanco escriba una identificación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                identificacion = Convert.ToInt32(TxtIdentificacion.Text);

                if (identificacion < 0)
                {
                    MessageBox.Show("No se puede ingresar numeros menores por favor vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
            }catch (Exception)
            {
                MessageBox.Show("No se puede ingresar letras ni signos por favor vuelva a intentarlo","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            salas = cbxSalas.Text;

            if (string.IsNullOrEmpty(salas) || string.IsNullOrWhiteSpace(salas))
            {
              MessageBox.Show("No se puede dejar en blanco seleccione una opción en sala","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }


             fechatx = TxtFecha.Text;

            if(string.IsNullOrEmpty(fechatx) || string.IsNullOrWhiteSpace(fechatx))
            {
                MessageBox.Show("Ingrese una fecha por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            DateTime fecha;

            if (!DateTime.TryParse(fechatx, out fecha))
            {
                MessageBox.Show("Formato de fecha no válido. Use el formato: dd/mm/aaaa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (fecha.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("La fecha debe ser en el futuro. No se permiten fechas pasadas ni el día actual.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            horatx = TxtHora.Text.Trim();
            DateTime hora;

            // Validar formato de hora (24 horas)
            if (!DateTime.TryParseExact(horatx, "HH:mm",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out hora))
            {
                MessageBox.Show("Formato de hora inválido. Use el formato 24h (por ejemplo: 20:00).",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool esValida = DateTime.TryParseExact(
                horatx, "HH:mm",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out hora
            );

            if (esValida)
            {
                // Validar que los minutos sean 0
                if (hora.Minute != 0)
                {
                    MessageBox.Show("Solo se permiten horas exactas (por ejemplo: 8:00, 9:00, 10:00).");
                    return;
                }

                // Validar rango entre 08:00 (8 a. m.) y 22:00 (10 p. m.)
                if (hora.Hour < 8 || hora.Hour > 22)
                {
                    MessageBox.Show("La hora debe estar entre 8:00 a. m. y 10:00 p. m.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                MessageBox.Show("Hora válida: " + hora.ToString("HH:mm"));
            }
            else
            {
                MessageBox.Show("Formato de hora inválido. Use el formato HH:mm (por ejemplo: 20:00).");
                return;
            }

            Usuarios Nuevo = new Usuarios();
            plan1 = Convert.ToInt32(TxtPlan1.Text);
            plan2 = Convert.ToInt32(TxtPlan2.Text);
            plan3 = Convert.ToInt32(TxtPlan3.Text);

            
            Nuevo.Nombre = nombre;
            Nuevo.Apellidos = apellidos;
            Nuevo.Identificacion = identificacion;
            Nuevo.Sala = salas;
            Nuevo.Fecha = fecha;
            Nuevo.Horas = hora;
            Nuevo.Inscripciones(plan1, plan2, plan3);
            usuarios.Add(Nuevo);

            MessageBox.Show("Agregado con exito....");

            // Convertir la hora a formato compatible con MySQL
            string horaMySQL = hora.ToString("HH:mm:ss");
            // Convertir fecha a formato MySQL
            string fechaMySQL = fecha.ToString("yyyy-MM-dd");
            // Conexion para comunicarse con el servidor MySQL 
            string conexionsql = "server=localhost; database=grupo6proyecto; uid=root; pwd=;";

            try
            {
                //Conexion creada 
                using (MySqlConnection con = new MySqlConnection(conexionsql))
                {
                    con.Open();

                    //Introducir los datos a la base
                    string query = @"INSERT INTO reservaciones 
                        (nombre, apellido, identificacion, sala, fecha, hora, plan1, plan2, plan3, totalcombo)
                        VALUES (@nombre, @apellido, @id, @sala, @fecha, @hora, @p1, @p2, @p3, @total)";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        //enviar los datos hacia el SQL
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@apellido", apellidos);
                        cmd.Parameters.AddWithValue("@id", identificacion);
                        cmd.Parameters.AddWithValue("@sala", salas);
                        cmd.Parameters.AddWithValue("@fecha", fechaMySQL);
                        cmd.Parameters.AddWithValue("@hora", horaMySQL);
                        cmd.Parameters.AddWithValue("@p1", plan1);
                        cmd.Parameters.AddWithValue("@p2", plan2);
                        cmd.Parameters.AddWithValue("@p3", plan3);
                        cmd.Parameters.AddWithValue("@total", Nuevo.TotalCombo);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Reservación guardada en la base de datos correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en la base de datos:\n" + ex.Message);
            }
            if (usuarios.Count == 0)
            {
                MessageBox.Show("No hay usuarios registrados todavía.");
                return;
            }

            string mensaje = "";

            foreach (var u in usuarios)
            {
                mensaje += $"Nombre: {u.Nombre} {u.Apellidos}\n" +
                           $"ID: {u.Identificacion}\n" +
                           $"Sala: {u.Sala}\n" +
                           $"Fecha: {u.Fecha:dd/MM/yyyy}\n" +
                           $"Hora: {u.Horas:HH:mm}\n" +
                           $"Total a pagar: ${u.TotalCombo}\n" +
                           "--------------------------\n";
            }

            MessageBox.Show(mensaje, "Lista de Usuarios");

    }

        //validación para no ingresar numeros ni signos
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        //Validación para Nombre, no espacios en blanco 
        private void TxtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNombre.Text) || string.IsNullOrWhiteSpace(TxtNombre.Text))
            {

                MessageBox.Show("No se puede dejar vacio o escribir espacios en blancos vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }

        }

        private void TxtApellido_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtApellido.Text) || string.IsNullOrWhiteSpace(TxtApellido.Text))
            {

                MessageBox.Show("No se puede dejar vacio o escribir espacios en blancos vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //validación para la fecha solo permite formato numero D/M/A
        private void TxtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true; // Bloquea el carácter
            }
        }

        //solo permite los dos puntos de la hora y el formato es en 24 horas
        private void TxtHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ':' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea el carácter
                MessageBox.Show("Solo se permiten números y el símbolo ':' para la hora.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //validación para identificación solo permite ingresar numeros por medio del teclado
        private void TxtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true; // Bloquea la tecla
                MessageBox.Show("Solo se permiten números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //solo permitimos numeros en nuestro textbox de combos
        private void TxtPlan1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true; 
                MessageBox.Show("Solo se permiten números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtPlan2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true; 
                MessageBox.Show("Solo se permiten números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtPlan3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true; 
                MessageBox.Show("Solo se permiten números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
