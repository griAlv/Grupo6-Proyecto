
namespace Grupo6Proyecto
{
    partial class Reservaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTablaReserv = new System.Windows.Forms.DataGridView();
            this.CbSala = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnReservacion = new System.Windows.Forms.Button();
            this.IdentificacionD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaReserv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTablaReserv
            // 
            this.dgvTablaReserv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaReserv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdentificacionD,
            this.NombreT,
            this.ApellidoD,
            this.SalaD,
            this.FechaD,
            this.HoraD,
            this.TotalCombo});
            this.dgvTablaReserv.Location = new System.Drawing.Point(-1, 106);
            this.dgvTablaReserv.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTablaReserv.Name = "dgvTablaReserv";
            this.dgvTablaReserv.RowHeadersWidth = 51;
            this.dgvTablaReserv.RowTemplate.Height = 24;
            this.dgvTablaReserv.Size = new System.Drawing.Size(754, 232);
            this.dgvTablaReserv.TabIndex = 1;
            this.dgvTablaReserv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaReserv_CellContentClick);
            // 
            // CbSala
            // 
            this.CbSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbSala.FormattingEnabled = true;
            this.CbSala.Location = new System.Drawing.Point(431, 72);
            this.CbSala.Margin = new System.Windows.Forms.Padding(2);
            this.CbSala.Name = "CbSala";
            this.CbSala.Size = new System.Drawing.Size(322, 30);
            this.CbSala.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnMostrar);
            this.panel1.Controls.Add(this.btnReservacion);
            this.panel1.Controls.Add(this.CbSala);
            this.panel1.Controls.Add(this.dgvTablaReserv);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 453);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "Seleccione la sala que quiere revisar:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 52);
            this.panel2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(539, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservaciones";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(454, 384);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.MaximumSize = new System.Drawing.Size(750, 812);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 58);
            this.button2.TabIndex = 21;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.Location = new System.Drawing.Point(126, 384);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrar.MaximumSize = new System.Drawing.Size(750, 812);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(121, 58);
            this.btnMostrar.TabIndex = 20;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnReservacion
            // 
            this.btnReservacion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReservacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnReservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservacion.ForeColor = System.Drawing.Color.White;
            this.btnReservacion.Location = new System.Drawing.Point(297, 384);
            this.btnReservacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnReservacion.MaximumSize = new System.Drawing.Size(750, 812);
            this.btnReservacion.Name = "btnReservacion";
            this.btnReservacion.Size = new System.Drawing.Size(121, 58);
            this.btnReservacion.TabIndex = 19;
            this.btnReservacion.Text = "Editar";
            this.btnReservacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReservacion.UseVisualStyleBackColor = false;
            // 
            // IdentificacionD
            // 
            this.IdentificacionD.HeaderText = "Identificación";
            this.IdentificacionD.Name = "IdentificacionD";
            // 
            // NombreT
            // 
            this.NombreT.HeaderText = "Nombre";
            this.NombreT.Name = "NombreT";
            // 
            // ApellidoD
            // 
            this.ApellidoD.HeaderText = "Apellido";
            this.ApellidoD.Name = "ApellidoD";
            // 
            // SalaD
            // 
            this.SalaD.HeaderText = "Sala";
            this.SalaD.Name = "SalaD";
            // 
            // FechaD
            // 
            this.FechaD.HeaderText = "Fecha";
            this.FechaD.Name = "FechaD";
            // 
            // HoraD
            // 
            this.HoraD.HeaderText = "Hora";
            this.HoraD.Name = "HoraD";
            // 
            // TotalCombo
            // 
            this.TotalCombo.HeaderText = "Total ";
            this.TotalCombo.Name = "TotalCombo";
            // 
            // Reservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 453);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reservaciones";
            this.Text = "Reservaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaReserv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTablaReserv;
        private System.Windows.Forms.ComboBox CbSala;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnReservacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentificacionD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaD;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaD;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCombo;
    }
}