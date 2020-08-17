namespace ProyectoGrelauGUI
{
    partial class FrmApartarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApartarCita));
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTratamiento = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.TxtCodigoCita = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.LblValorCita = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbHora = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtJornada = new System.Windows.Forms.TextBox();
            this.TxtCodigoA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtNombreMedico = new System.Windows.Forms.TextBox();
            this.DetalleCita = new System.Windows.Forms.DataGridView();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtGenero = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnBusqueda = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleCita)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(17, 468);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(141, 44);
            this.BtnGuardar.TabIndex = 154;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(786, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 44);
            this.button2.TabIndex = 153;
            this.button2.Text = "CONSULTAR TABLA";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(535, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(225, 93);
            this.dataGridView1.TabIndex = 152;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTratamiento);
            this.groupBox3.Controls.Add(this.DtpFecha);
            this.groupBox3.Controls.Add(this.TxtFecha);
            this.groupBox3.Controls.Add(this.TxtCodigoCita);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.LblValorCita);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.CmbHora);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(17, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 109);
            this.groupBox3.TabIndex = 151;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.Location = new System.Drawing.Point(330, 16);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.Size = new System.Drawing.Size(100, 23);
            this.lblTratamiento.TabIndex = 77;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(62, 19);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(110, 20);
            this.DtpFecha.TabIndex = 0;
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(62, 45);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(158, 20);
            this.TxtFecha.TabIndex = 2;
            // 
            // TxtCodigoCita
            // 
            this.TxtCodigoCita.Location = new System.Drawing.Point(330, 79);
            this.TxtCodigoCita.Name = "TxtCodigoCita";
            this.TxtCodigoCita.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigoCita.TabIndex = 74;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(239, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 75;
            this.label11.Text = "CODIGO CITA";
            // 
            // LblValorCita
            // 
            this.LblValorCita.Location = new System.Drawing.Point(336, 51);
            this.LblValorCita.Name = "LblValorCita";
            this.LblValorCita.Size = new System.Drawing.Size(100, 23);
            this.LblValorCita.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FECHA:";
            // 
            // CmbHora
            // 
            this.CmbHora.FormattingEnabled = true;
            this.CmbHora.Location = new System.Drawing.Point(62, 71);
            this.CmbHora.Name = "CmbHora";
            this.CmbHora.Size = new System.Drawing.Size(121, 21);
            this.CmbHora.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "HORA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "TRATAMIENTO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "VALOR CITA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TxtJornada);
            this.groupBox2.Controls.Add(this.TxtCodigoA);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TxtNombreMedico);
            this.groupBox2.Location = new System.Drawing.Point(535, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 133);
            this.groupBox2.TabIndex = 150;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(227, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 28);
            this.button1.TabIndex = 78;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 77;
            this.label12.Text = "JORNADA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 73;
            this.label10.Text = "CODIGO AGENDA";
            // 
            // TxtJornada
            // 
            this.TxtJornada.Location = new System.Drawing.Point(111, 83);
            this.TxtJornada.Name = "TxtJornada";
            this.TxtJornada.Size = new System.Drawing.Size(100, 20);
            this.TxtJornada.TabIndex = 76;
            // 
            // TxtCodigoA
            // 
            this.TxtCodigoA.Location = new System.Drawing.Point(111, 27);
            this.TxtCodigoA.Name = "TxtCodigoA";
            this.TxtCodigoA.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigoA.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 71;
            this.label9.Text = "NOMBRE:";
            // 
            // TxtNombreMedico
            // 
            this.TxtNombreMedico.Location = new System.Drawing.Point(111, 55);
            this.TxtNombreMedico.Name = "TxtNombreMedico";
            this.TxtNombreMedico.Size = new System.Drawing.Size(100, 20);
            this.TxtNombreMedico.TabIndex = 70;
            // 
            // DetalleCita
            // 
            this.DetalleCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleCita.Location = new System.Drawing.Point(26, 288);
            this.DetalleCita.Name = "DetalleCita";
            this.DetalleCita.Size = new System.Drawing.Size(734, 174);
            this.DetalleCita.TabIndex = 149;
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsulta.Image")));
            this.BtnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsulta.Location = new System.Drawing.Point(627, 468);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(153, 44);
            this.BtnConsulta.TabIndex = 148;
            this.BtnConsulta.Text = "CONSULTAR";
            this.BtnConsulta.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(189, 468);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(137, 44);
            this.BtnBuscar.TabIndex = 145;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.Location = new System.Drawing.Point(476, 468);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(145, 44);
            this.BtnModificar.TabIndex = 146;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(332, 468);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(138, 44);
            this.BtnEliminar.TabIndex = 147;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtGenero);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.TxtTelefono);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtnBusqueda);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtApellido);
            this.groupBox1.Controls.Add(this.TxtIdentificacion);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(28, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 133);
            this.groupBox1.TabIndex = 144;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS APARTAR CITA";
            // 
            // TxtGenero
            // 
            this.TxtGenero.Location = new System.Drawing.Point(371, 68);
            this.TxtGenero.Name = "TxtGenero";
            this.TxtGenero.Size = new System.Drawing.Size(112, 20);
            this.TxtGenero.TabIndex = 69;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(276, 71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 13);
            this.label20.TabIndex = 68;
            this.label20.Text = "GENERO";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(371, 26);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(112, 20);
            this.TxtTelefono.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "TELEFONO:";
            // 
            // BtnBusqueda
            // 
            this.BtnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBusqueda.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("BtnBusqueda.Image")));
            this.BtnBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBusqueda.Location = new System.Drawing.Point(229, 26);
            this.BtnBusqueda.Name = "BtnBusqueda";
            this.BtnBusqueda.Size = new System.Drawing.Size(33, 28);
            this.BtnBusqueda.TabIndex = 28;
            this.BtnBusqueda.UseVisualStyleBackColor = true;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(113, 64);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "IDENTIFICACION:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "NOMBRE:";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(113, 90);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(100, 20);
            this.TxtApellido.TabIndex = 23;
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Location = new System.Drawing.Point(113, 33);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.TxtIdentificacion.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "APELLIDO:";
            // 
            // FrmApartarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 551);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DetalleCita);
            this.Controls.Add(this.BtnConsulta);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmApartarCita";
            this.Text = "FrmApartarCita";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleCita)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTratamiento;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.TextBox TxtCodigoCita;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblValorCita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtJornada;
        private System.Windows.Forms.TextBox TxtCodigoA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtNombreMedico;
        private System.Windows.Forms.DataGridView DetalleCita;
        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtGenero;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnBusqueda;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.Label label14;
    }
}