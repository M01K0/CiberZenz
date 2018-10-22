namespace CiberZenz
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.Pbx_Logo = new System.Windows.Forms.PictureBox();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.Btn_Entrar = new System.Windows.Forms.Button();
            this.Link_Contraseña = new System.Windows.Forms.LinkLabel();
            this.Lbl_Contraseña = new System.Windows.Forms.Label();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Txt_Contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.PanelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Logo)).BeginInit();
            this.PanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(102)))));
            this.PanelLateral.Controls.Add(this.Pbx_Logo);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(200, 300);
            this.PanelLateral.TabIndex = 0;
            // 
            // Pbx_Logo
            // 
            this.Pbx_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Pbx_Logo.Image")));
            this.Pbx_Logo.Location = new System.Drawing.Point(0, 0);
            this.Pbx_Logo.Name = "Pbx_Logo";
            this.Pbx_Logo.Size = new System.Drawing.Size(200, 234);
            this.Pbx_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbx_Logo.TabIndex = 0;
            this.Pbx_Logo.TabStop = false;
            this.Pbx_Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InicioSesion_MouseDown);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.Btn_Entrar);
            this.PanelPrincipal.Controls.Add(this.Link_Contraseña);
            this.PanelPrincipal.Controls.Add(this.Lbl_Contraseña);
            this.PanelPrincipal.Controls.Add(this.Lbl_Usuario);
            this.PanelPrincipal.Controls.Add(this.Btn_Cerrar);
            this.PanelPrincipal.Controls.Add(this.pictureBox3);
            this.PanelPrincipal.Controls.Add(this.Txt_Contraseña);
            this.PanelPrincipal.Controls.Add(this.label1);
            this.PanelPrincipal.Controls.Add(this.pictureBox2);
            this.PanelPrincipal.Controls.Add(this.Txt_Usuario);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(200, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(500, 300);
            this.PanelPrincipal.TabIndex = 1;
            this.PanelPrincipal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InicioSesion_MouseDown);
            // 
            // Btn_Entrar
            // 
            this.Btn_Entrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(102)))));
            this.Btn_Entrar.FlatAppearance.BorderSize = 0;
            this.Btn_Entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(35)))), ((int)(((byte)(102)))));
            this.Btn_Entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(70)))), ((int)(((byte)(102)))));
            this.Btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Entrar.Font = new System.Drawing.Font("Consolas", 20F);
            this.Btn_Entrar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Entrar.Location = new System.Drawing.Point(157, 191);
            this.Btn_Entrar.Name = "Btn_Entrar";
            this.Btn_Entrar.Size = new System.Drawing.Size(326, 40);
            this.Btn_Entrar.TabIndex = 3;
            this.Btn_Entrar.Text = "Entrar";
            this.Btn_Entrar.UseVisualStyleBackColor = false;
            this.Btn_Entrar.Click += new System.EventHandler(this.Btn_Entrar_Click);
            // 
            // Link_Contraseña
            // 
            this.Link_Contraseña.AutoSize = true;
            this.Link_Contraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Link_Contraseña.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_Contraseña.Location = new System.Drawing.Point(134, 272);
            this.Link_Contraseña.Name = "Link_Contraseña";
            this.Link_Contraseña.Size = new System.Drawing.Size(216, 19);
            this.Link_Contraseña.TabIndex = 4;
            this.Link_Contraseña.TabStop = true;
            this.Link_Contraseña.Text = "Olvide mi contraseña...";
            // 
            // Lbl_Contraseña
            // 
            this.Lbl_Contraseña.AutoSize = true;
            this.Lbl_Contraseña.Font = new System.Drawing.Font("Consolas", 15F);
            this.Lbl_Contraseña.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lbl_Contraseña.Location = new System.Drawing.Point(22, 132);
            this.Lbl_Contraseña.Name = "Lbl_Contraseña";
            this.Lbl_Contraseña.Size = new System.Drawing.Size(131, 23);
            this.Lbl_Contraseña.TabIndex = 7;
            this.Lbl_Contraseña.Text = "Contraseña:";
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Consolas", 15F);
            this.Lbl_Usuario.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lbl_Usuario.Location = new System.Drawing.Point(22, 78);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(98, 23);
            this.Lbl_Usuario.TabIndex = 6;
            this.Lbl_Usuario.Text = "Usuario:";
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(466, 0);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(34, 33);
            this.Btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Cerrar.TabIndex = 5;
            this.Btn_Cerrar.TabStop = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(24)))));
            this.pictureBox3.Location = new System.Drawing.Point(157, 168);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(326, 3);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // Txt_Contraseña
            // 
            this.Txt_Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Txt_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Contraseña.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Contraseña.Location = new System.Drawing.Point(157, 123);
            this.Txt_Contraseña.Name = "Txt_Contraseña";
            this.Txt_Contraseña.PasswordChar = '*';
            this.Txt_Contraseña.Size = new System.Drawing.Size(326, 32);
            this.Txt_Contraseña.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio de Sesion";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(24)))));
            this.pictureBox2.Location = new System.Drawing.Point(157, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(326, 3);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Usuario.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Usuario.Location = new System.Drawing.Point(157, 69);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(326, 32);
            this.Txt_Usuario.TabIndex = 1;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(700, 300);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.PanelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioSesion";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioSesion";
            this.PanelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Logo)).EndInit();
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.PictureBox Pbx_Logo;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.PictureBox Btn_Cerrar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox Txt_Contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label Lbl_Contraseña;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.LinkLabel Link_Contraseña;
        private System.Windows.Forms.Button Btn_Entrar;
    }
}