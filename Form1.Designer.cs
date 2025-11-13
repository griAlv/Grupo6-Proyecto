
namespace Grupo6Proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarradTitulo = new System.Windows.Forms.Panel();
            this.Hora = new System.Windows.Forms.Label();
            this.BtnRestaurar = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.MenuVetical = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btReservaciones = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btPlanes = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btInscripcion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btHorarios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSalas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelContenido = new System.Windows.Forms.Panel();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.BarradTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.MenuVetical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarradTitulo
            // 
            this.BarradTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(26)))));
            this.BarradTitulo.Controls.Add(this.Hora);
            this.BarradTitulo.Controls.Add(this.BtnRestaurar);
            this.BarradTitulo.Controls.Add(this.BtnMaximizar);
            this.BarradTitulo.Controls.Add(this.BtnMinimizar);
            this.BarradTitulo.Controls.Add(this.BtnCerrar);
            this.BarradTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarradTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarradTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BarradTitulo.Name = "BarradTitulo";
            this.BarradTitulo.Size = new System.Drawing.Size(975, 37);
            this.BarradTitulo.TabIndex = 0;
            this.BarradTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarradTitulo_MouseDown);
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.ForeColor = System.Drawing.Color.Snow;
            this.Hora.Location = new System.Drawing.Point(9, 2);
            this.Hora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(36, 25);
            this.Hora.TabIndex = 15;
            this.Hora.Text = "}{}";
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRestaurar.Image")));
            this.BtnRestaurar.Location = new System.Drawing.Point(905, 3);
            this.BtnRestaurar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRestaurar.Name = "BtnRestaurar";
            this.BtnRestaurar.Size = new System.Drawing.Size(30, 30);
            this.BtnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnRestaurar.TabIndex = 3;
            this.BtnRestaurar.TabStop = false;
            this.BtnRestaurar.Visible = false;
            this.BtnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximizar.Image")));
            this.BtnMaximizar.Location = new System.Drawing.Point(905, 2);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(30, 30);
            this.BtnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMaximizar.TabIndex = 4;
            this.BtnMaximizar.TabStop = false;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(870, 3);
            this.BtnMinimizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimizar.TabIndex = 2;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(940, 3);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(30, 30);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // MenuVetical
            // 
            this.MenuVetical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(98)))), ((int)(((byte)(76)))));
            this.MenuVetical.Controls.Add(this.panel5);
            this.MenuVetical.Controls.Add(this.button5);
            this.MenuVetical.Controls.Add(this.panel6);
            this.MenuVetical.Controls.Add(this.btReservaciones);
            this.MenuVetical.Controls.Add(this.panel3);
            this.MenuVetical.Controls.Add(this.btPlanes);
            this.MenuVetical.Controls.Add(this.panel4);
            this.MenuVetical.Controls.Add(this.btInscripcion);
            this.MenuVetical.Controls.Add(this.panel2);
            this.MenuVetical.Controls.Add(this.btHorarios);
            this.MenuVetical.Controls.Add(this.panel1);
            this.MenuVetical.Controls.Add(this.btSalas);
            this.MenuVetical.Controls.Add(this.pictureBox1);
            this.MenuVetical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVetical.Location = new System.Drawing.Point(0, 37);
            this.MenuVetical.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MenuVetical.Name = "MenuVetical";
            this.MenuVetical.Size = new System.Drawing.Size(201, 491);
            this.MenuVetical.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(26)))));
            this.panel5.Location = new System.Drawing.Point(0, 346);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 37);
            this.panel5.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(98)))), ((int)(((byte)(76)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(26)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.button5.Location = new System.Drawing.Point(0, 346);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 37);
            this.button5.TabIndex = 11;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(26)))));
            this.panel6.Location = new System.Drawing.Point(0, 301);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 37);
            this.panel6.TabIndex = 8;
            // 
            // btReservaciones
            // 
            this.btReservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(98)))), ((int)(((byte)(76)))));
            this.btReservaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReservaciones.FlatAppearance.BorderSize = 0;
            this.btReservaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(26)))));
            this.btReservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReservaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.btReservaciones.Location = new System.Drawing.Point(0, 301);
            this.btReservaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btReservaciones.Name = "btReservaciones";
            this.btReservaciones.Size = new System.Drawing.Size(195, 37);
            this.btReservaciones.TabIndex = 9;
            this.btReservaciones.Text = "Reservaciones";
            this.btReservaciones.UseVisualStyleBackColor = false;
            this.btReservaciones.Click += new System.EventHandler(this.btReservaciones_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(26)))));
            this.panel3.Location = new System.Drawing.Point(0, 255);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 37);
            this.panel3.TabIndex = 6;
            // 
            // btPlanes
            // 
            this.btPlanes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(98)))), ((int)(((byte)(76)))));
            this.btPlanes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPlanes.FlatAppearance.BorderSize = 0;
            this.btPlanes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(26)))));
            this.btPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlanes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.btPlanes.Location = new System.Drawing.Point(0, 255);
            this.btPlanes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btPlanes.Name = "btPlanes";
            this.btPlanes.Size = new System.Drawing.Size(195, 37);
            this.btPlanes.TabIndex = 7;
            this.btPlanes.Text = "Planes";
            this.btPlanes.UseVisualStyleBackColor = false;
            this.btPlanes.Click += new System.EventHandler(this.btPlanes_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(26)))));
            this.panel4.Location = new System.Drawing.Point(0, 210);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 37);
            this.panel4.TabIndex = 4;
            // 
            // btInscripcion
            // 
            this.btInscripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(98)))), ((int)(((byte)(76)))));
            this.btInscripcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInscripcion.FlatAppearance.BorderSize = 0;
            this.btInscripcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(26)))));
            this.btInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInscripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.btInscripcion.Location = new System.Drawing.Point(0, 210);
            this.btInscripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btInscripcion.Name = "btInscripcion";
            this.btInscripcion.Size = new System.Drawing.Size(195, 37);
            this.btInscripcion.TabIndex = 5;
            this.btInscripcion.Text = "Registrarse";
            this.btInscripcion.UseVisualStyleBackColor = false;
            this.btInscripcion.Click += new System.EventHandler(this.btInscripcion_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(26)))));
            this.panel2.Location = new System.Drawing.Point(0, 161);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 37);
            this.panel2.TabIndex = 2;
            // 
            // btHorarios
            // 
            this.btHorarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(98)))), ((int)(((byte)(76)))));
            this.btHorarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHorarios.FlatAppearance.BorderSize = 0;
            this.btHorarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(26)))));
            this.btHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHorarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.btHorarios.Location = new System.Drawing.Point(0, 161);
            this.btHorarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btHorarios.Name = "btHorarios";
            this.btHorarios.Size = new System.Drawing.Size(195, 37);
            this.btHorarios.TabIndex = 3;
            this.btHorarios.Text = "Horarios";
            this.btHorarios.UseVisualStyleBackColor = false;
            this.btHorarios.Click += new System.EventHandler(this.btHorarios_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(26)))));
            this.panel1.Location = new System.Drawing.Point(0, 115);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 37);
            this.panel1.TabIndex = 0;
            // 
            // btSalas
            // 
            this.btSalas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(98)))), ((int)(((byte)(76)))));
            this.btSalas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalas.FlatAppearance.BorderSize = 0;
            this.btSalas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(26)))));
            this.btSalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.btSalas.Location = new System.Drawing.Point(0, 115);
            this.btSalas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSalas.Name = "btSalas";
            this.btSalas.Size = new System.Drawing.Size(195, 37);
            this.btSalas.TabIndex = 1;
            this.btSalas.Text = "Salas";
            this.btSalas.UseVisualStyleBackColor = false;
            this.btSalas.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PanelContenido
            // 
            this.PanelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenido.ForeColor = System.Drawing.Color.White;
            this.PanelContenido.Location = new System.Drawing.Point(201, 37);
            this.PanelContenido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelContenido.Name = "PanelContenido";
            this.PanelContenido.Size = new System.Drawing.Size(774, 491);
            this.PanelContenido.TabIndex = 2;
            this.PanelContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenido_Paint);
            // 
            // tiempo
            // 
            this.tiempo.Enabled = true;
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(975, 528);
            this.Controls.Add(this.PanelContenido);
            this.Controls.Add(this.MenuVetical);
            this.Controls.Add(this.BarradTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = " fomr";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.BarradTitulo.ResumeLayout(false);
            this.BarradTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.MenuVetical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarradTitulo;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.Panel MenuVetical;
        private System.Windows.Forms.Panel PanelContenido;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnRestaurar;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btSalas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btReservaciones;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btPlanes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btInscripcion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btHorarios;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.Timer tiempo;
    }
}

