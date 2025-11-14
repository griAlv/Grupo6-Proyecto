using MySql.Data.MySqlClient;
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
    public partial class Reservaciones : Form
    {
        public Reservaciones()
        {
            InitializeComponent();

            //Personalizacion de data grid view
            dgvTablaReserv.DefaultCellStyle.BackColor = Color.White;
            dgvTablaReserv.DefaultCellStyle.ForeColor = Color.Black;

            dgvTablaReserv.RowsDefaultCellStyle.BackColor = Color.White;
            dgvTablaReserv.RowsDefaultCellStyle.ForeColor = Color.Black;

            dgvTablaReserv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            CbSala.DropDownStyle = ComboBoxStyle.DropDownList; //No permite ingresar texto al combobox
        }

        //crear la conexion a la base de datos
        internal class ConexionDB
        {
            private static string conexion = "server=sql5.freesqldatabase.com; port=3306; database=sql5807318; uid=sql5807318; password=IjAcBHuLSu;";

            public static MySqlConnection ObtenerConexion()
            {
                MySqlConnection con = new MySqlConnection(conexion);
                con.Open();
                return con;
            }
        }
        internal class UsuariosDAO
        {
            public static DataTable ObtenerPorSala(string sala)
            {
                using (MySqlConnection con = ConexionDB.ObtenerConexion())
                {
                    string query = "SELECT * FROM reservaciones WHERE sala = @sala";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@sala", sala);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
            public static bool EliminarReservacion(int id)
            {
                using (MySqlConnection con = ConexionDB.ObtenerConexion())
                {
                    string query = "DELETE FROM reservaciones WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", id);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    return filasAfectadas > 0;
                }
            }
            public static DataTable ObtenerUsuarios()
            {
                using (MySqlConnection con = ConexionDB.ObtenerConexion())
                {
                    MessageBox.Show("Conexión exitosa");
                    string query = "SELECT * FROM reservaciones";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvTablaReserv.DataSource = UsuariosDAO.ObtenerUsuarios();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvTablaReserv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una reservación para eliminar.");
                return;
            }

            // Obtener el ID de la fila seleccionada
            int id = Convert.ToInt32(dgvTablaReserv.SelectedRows[0].Cells["id"].Value);

            // Confirmación
            var confirmacion = MessageBox.Show(
                "¿Seguro que deseas eliminar esta reservación?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                if (UsuariosDAO.EliminarReservacion(id))
                {
                    MessageBox.Show("Reservación eliminada correctamente.");

                    // Refrescar tabla
                    dgvTablaReserv.DataSource = UsuariosDAO.ObtenerUsuarios();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la reservación.");
                }
            }
        }

        private void CbSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sala = CbSala.SelectedItem.ToString();

            if (sala == "Todas")
            {
                dgvTablaReserv.DataSource = UsuariosDAO.ObtenerUsuarios();
            }
            else
            {
                dgvTablaReserv.DataSource = UsuariosDAO.ObtenerPorSala(sala);
            }
        }

    }
}


