namespace ProyectoGrelauGUI
{
    partial class FrmMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMedico));
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbJornada = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtEducacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtCuidad = new System.Windows.Forms.TextBox();
            this.TxtMunicipio = new System.Windows.Forms.TextBox();
            this.TxtBarrio = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCalle = new System.Windows.Forms.TextBox();
            this.CmbGenero = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSgundoApellido = new System.Windows.Forms.TextBox();
            this.TxtPrimerApellido = new System.Windows.Forms.TextBox();
            this.TxtSegundoNombre = new System.Windows.Forms.TextBox();
            this.TxtPrimerNombre = new System.Windows.Forms.TextBox();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsulta.Image")));
            this.BtnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsulta.Location = new System.Drawing.Point(632, 429);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(145, 44);
            this.BtnConsulta.TabIndex = 77;
            this.BtnConsulta.Text = "CONSULTAR";
            this.BtnConsulta.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbJornada);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtEducacion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.CmbGenero);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtTelefono);
            this.groupBox1.Controls.Add(this.TxtEdad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtSgundoApellido);
            this.groupBox1.Controls.Add(this.TxtPrimerApellido);
            this.groupBox1.Controls.Add(this.TxtSegundoNombre);
            this.groupBox1.Controls.Add(this.TxtPrimerNombre);
            this.groupBox1.Controls.Add(this.TxtIdentificacion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(40, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 354);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS";
            // 
            // CmbJornada
            // 
            this.CmbJornada.FormattingEnabled = true;
            this.CmbJornada.Items.AddRange(new object[] {
            "MAÑANA",
            "TARDE"});
            this.CmbJornada.Location = new System.Drawing.Point(395, 86);
            this.CmbJornada.Name = "CmbJornada";
            this.CmbJornada.Size = new System.Drawing.Size(121, 21);
            this.CmbJornada.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "JORNADA";
            // 
            // TxtEducacion
            // 
            this.TxtEducacion.Location = new System.Drawing.Point(151, 246);
            this.TxtEducacion.Name = "TxtEducacion";
            this.TxtEducacion.Size = new System.Drawing.Size(100, 20);
            this.TxtEducacion.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "EDUCACION:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtCuidad);
            this.groupBox2.Controls.Add(this.TxtMunicipio);
            this.groupBox2.Controls.Add(this.TxtBarrio);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TxtCalle);
            this.groupBox2.Location = new System.Drawing.Point(312, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 203);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DIRECCION";
            // 
            // TxtCuidad
            // 
            this.TxtCuidad.Location = new System.Drawing.Point(74, 148);
            this.TxtCuidad.Name = "TxtCuidad";
            this.TxtCuidad.Size = new System.Drawing.Size(99, 20);
            this.TxtCuidad.TabIndex = 39;
            // 
            // TxtMunicipio
            // 
            this.TxtMunicipio.Location = new System.Drawing.Point(74, 110);
            this.TxtMunicipio.Name = "TxtMunicipio";
            this.TxtMunicipio.Size = new System.Drawing.Size(99, 20);
            this.TxtMunicipio.TabIndex = 38;
            // 
            // TxtBarrio
            // 
            this.TxtBarrio.Location = new System.Drawing.Point(74, 74);
            this.TxtBarrio.Name = "TxtBarrio";
            this.TxtBarrio.Size = new System.Drawing.Size(99, 20);
            this.TxtBarrio.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "CUIDAD:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "BARRIO:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "MUNICIPIO:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "CALLE:";
            // 
            // TxtCalle
            // 
            this.TxtCalle.Location = new System.Drawing.Point(74, 32);
            this.TxtCalle.Name = "TxtCalle";
            this.TxtCalle.Size = new System.Drawing.Size(99, 20);
            this.TxtCalle.TabIndex = 30;
            // 
            // CmbGenero
            // 
            this.CmbGenero.FormattingEnabled = true;
            this.CmbGenero.Items.AddRange(new object[] {
            "FEMENINO",
            "MASCULINO"});
            this.CmbGenero.Location = new System.Drawing.Point(395, 50);
            this.CmbGenero.Name = "CmbGenero";
            this.CmbGenero.Size = new System.Drawing.Size(121, 21);
            this.CmbGenero.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "GENERO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "EDAD:";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(395, 13);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(100, 20);
            this.TxtTelefono.TabIndex = 27;
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(151, 212);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(100, 20);
            this.TxtEdad.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "TELEFONO:";
            // 
            // TxtSgundoApellido
            // 
            this.TxtSgundoApellido.Location = new System.Drawing.Point(151, 172);
            this.TxtSgundoApellido.Name = "TxtSgundoApellido";
            this.TxtSgundoApellido.Size = new System.Drawing.Size(100, 20);
            this.TxtSgundoApellido.TabIndex = 23;
            // 
            // TxtPrimerApellido
            // 
            this.TxtPrimerApellido.Location = new System.Drawing.Point(151, 137);
            this.TxtPrimerApellido.Name = "TxtPrimerApellido";
            this.TxtPrimerApellido.Size = new System.Drawing.Size(100, 20);
            this.TxtPrimerApellido.TabIndex = 22;
            // 
            // TxtSegundoNombre
            // 
            this.TxtSegundoNombre.Location = new System.Drawing.Point(151, 98);
            this.TxtSegundoNombre.Name = "TxtSegundoNombre";
            this.TxtSegundoNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtSegundoNombre.TabIndex = 21;
            // 
            // TxtPrimerNombre
            // 
            this.TxtPrimerNombre.Location = new System.Drawing.Point(151, 58);
            this.TxtPrimerNombre.Name = "TxtPrimerNombre";
            this.TxtPrimerNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtPrimerNombre.TabIndex = 20;
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Location = new System.Drawing.Point(151, 21);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.TxtIdentificacion.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "SEGUNDO APELLIDO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "PRIMER APELLIDO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "SEGUNDO NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "PRIMER NOMBRE:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "IDENTIFICACION:";
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.Location = new System.Drawing.Point(481, 429);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(145, 44);
            this.BtnModificar.TabIndex = 74;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(179, 429);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(145, 44);
            this.BtnBuscar.TabIndex = 73;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(330, 429);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(145, 44);
            this.BtnEliminar.TabIndex = 75;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(28, 429);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(145, 44);
            this.BtnGuardar.TabIndex = 76;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 540);
            this.Controls.Add(this.BtnConsulta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMedico";
            this.Text = "FrmMedico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbJornada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtEducacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtCuidad;
        private System.Windows.Forms.TextBox TxtMunicipio;
        private System.Windows.Forms.TextBox TxtBarrio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtCalle;
        private System.Windows.Forms.ComboBox CmbGenero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSgundoApellido;
        private System.Windows.Forms.TextBox TxtPrimerApellido;
        private System.Windows.Forms.TextBox TxtSegundoNombre;
        private System.Windows.Forms.TextBox TxtPrimerNombre;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnGuardar;
    }
}