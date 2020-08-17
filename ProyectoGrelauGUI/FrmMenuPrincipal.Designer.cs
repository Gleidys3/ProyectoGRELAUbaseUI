namespace ProyectoGrelauGUI
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlDesktop = new System.Windows.Forms.Panel();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.IconMinimizar = new System.Windows.Forms.PictureBox();
            this.IconRestaurar = new System.Windows.Forms.PictureBox();
            this.IconMaximizar = new System.Windows.Forms.PictureBox();
            this.IconCerrar = new System.Windows.Forms.PictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlDesktop.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(346, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PnlDesktop
            // 
            this.PnlDesktop.BackColor = System.Drawing.Color.White;
            this.PnlDesktop.Controls.Add(this.panel2);
            this.PnlDesktop.Controls.Add(this.PnlMenu);
            this.PnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDesktop.Location = new System.Drawing.Point(0, 0);
            this.PnlDesktop.Name = "PnlDesktop";
            this.PnlDesktop.Size = new System.Drawing.Size(954, 506);
            this.PnlDesktop.TabIndex = 4;
            this.PnlDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlDesktop_Paint);
            // 
            // PnlMenu
            // 
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(0)))), ((int)(((byte)(149)))));
            this.PnlMenu.Controls.Add(this.iconButton5);
            this.PnlMenu.Controls.Add(this.iconButton4);
            this.PnlMenu.Controls.Add(this.iconButton3);
            this.PnlMenu.Controls.Add(this.iconButton2);
            this.PnlMenu.Controls.Add(this.iconButton1);
            this.PnlMenu.Controls.Add(this.panel1);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(220, 506);
            this.PnlMenu.TabIndex = 1;
            // 
            // iconButton5
            // 
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton5.ForeColor = System.Drawing.Color.White;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconSize = 36;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 353);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton5.Rotation = 0D;
            this.iconButton5.Size = new System.Drawing.Size(220, 56);
            this.iconButton5.TabIndex = 5;
            this.iconButton5.Text = "APARTAR CITA ";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconSize = 36;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 294);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton4.Rotation = 0D;
            this.iconButton4.Size = new System.Drawing.Size(220, 53);
            this.iconButton4.TabIndex = 4;
            this.iconButton4.Text = "AGENDA MEDICO";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconSize = 36;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 230);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(220, 58);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.Text = "MEDICO";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconSize = 36;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 171);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(220, 54);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "PACIENTE";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(220, 23);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 140);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(63, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(88, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(0)))), ((int)(((byte)(149)))));
            this.PnlTitulo.Controls.Add(this.iconCurrentChildForm);
            this.PnlTitulo.Controls.Add(this.IconMinimizar);
            this.PnlTitulo.Controls.Add(this.IconRestaurar);
            this.PnlTitulo.Controls.Add(this.IconMaximizar);
            this.PnlTitulo.Controls.Add(this.IconCerrar);
            this.PnlTitulo.Controls.Add(this.lblTitleChildForm);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(954, 35);
            this.PnlTitulo.TabIndex = 5;
            this.PnlTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlTitulo_Paint);
            this.PnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTitulo_MouseDown);
            // 
            // IconMinimizar
            // 
            this.IconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("IconMinimizar.Image")));
            this.IconMinimizar.Location = new System.Drawing.Point(844, 5);
            this.IconMinimizar.Name = "IconMinimizar";
            this.IconMinimizar.Size = new System.Drawing.Size(30, 30);
            this.IconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconMinimizar.TabIndex = 13;
            this.IconMinimizar.TabStop = false;
            this.IconMinimizar.Click += new System.EventHandler(this.IconMinimizar_Click);
            // 
            // IconRestaurar
            // 
            this.IconRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("IconRestaurar.Image")));
            this.IconRestaurar.Location = new System.Drawing.Point(880, 3);
            this.IconRestaurar.Name = "IconRestaurar";
            this.IconRestaurar.Size = new System.Drawing.Size(30, 30);
            this.IconRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconRestaurar.TabIndex = 12;
            this.IconRestaurar.TabStop = false;
            this.IconRestaurar.Visible = false;
            this.IconRestaurar.Click += new System.EventHandler(this.IconRestaurar_Click);
            // 
            // IconMaximizar
            // 
            this.IconMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("IconMaximizar.Image")));
            this.IconMaximizar.Location = new System.Drawing.Point(880, 2);
            this.IconMaximizar.Name = "IconMaximizar";
            this.IconMaximizar.Size = new System.Drawing.Size(30, 30);
            this.IconMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconMaximizar.TabIndex = 11;
            this.IconMaximizar.TabStop = false;
            this.IconMaximizar.Click += new System.EventHandler(this.IconMaximizar_Click);
            // 
            // IconCerrar
            // 
            this.IconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconCerrar.Image = ((System.Drawing.Image)(resources.GetObject("IconCerrar.Image")));
            this.IconCerrar.Location = new System.Drawing.Point(916, 5);
            this.IconCerrar.Name = "IconCerrar";
            this.IconCerrar.Size = new System.Drawing.Size(30, 30);
            this.IconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconCerrar.TabIndex = 10;
            this.IconCerrar.TabStop = false;
            this.IconCerrar.Click += new System.EventHandler(this.IconCerrar_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(280, 10);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(32, 13);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Inicio";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(0)))), ((int)(((byte)(149)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Hospital;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconSize = 29;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(237, 4);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(37, 29);
            this.iconCurrentChildForm.TabIndex = 2;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(220, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 506);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(240, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(367, 272);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 506);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.PnlDesktop);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuPrincipal";
            this.Text = "FrmMenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlDesktop.ResumeLayout(false);
            this.PnlMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.PnlTitulo.ResumeLayout(false);
            this.PnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnlDesktop;
        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.PictureBox IconMinimizar;
        private System.Windows.Forms.PictureBox IconRestaurar;
        private System.Windows.Forms.PictureBox IconMaximizar;
        private System.Windows.Forms.PictureBox IconCerrar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}