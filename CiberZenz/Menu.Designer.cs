namespace CiberZenz
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.Btn_Minimizar = new System.Windows.Forms.Button();
            this.Btn_Maximizar = new System.Windows.Forms.Button();
            this.Btn_Restaurar = new System.Windows.Forms.Button();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Pbx_Logo = new System.Windows.Forms.PictureBox();
            this.Btn_ControlRentas = new System.Windows.Forms.Button();
            this.Panel_Contenedor = new System.Windows.Forms.Panel();
            this.Panel_Principal = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Logo)).BeginInit();
            this.Panel_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(102)))));
            this.PanelMenu.Controls.Add(this.Btn_ControlRentas);
            this.PanelMenu.Controls.Add(this.Pbx_Logo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(200, 600);
            this.PanelMenu.TabIndex = 0;
            this.PanelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.Transparent;
            this.PanelTop.Controls.Add(this.Btn_Minimizar);
            this.PanelTop.Controls.Add(this.Btn_Restaurar);
            this.PanelTop.Controls.Add(this.Btn_Cerrar);
            this.PanelTop.Controls.Add(this.Btn_Maximizar);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(200, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(800, 40);
            this.PanelTop.TabIndex = 1;
            this.PanelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Minimizar.BackgroundImage")));
            this.Btn_Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_Minimizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.Btn_Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Btn_Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimizar.Location = new System.Drawing.Point(683, 2);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(35, 35);
            this.Btn_Minimizar.TabIndex = 3;
            this.Btn_Minimizar.UseVisualStyleBackColor = true;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // Btn_Maximizar
            // 
            this.Btn_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Maximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Maximizar.BackgroundImage")));
            this.Btn_Maximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Maximizar.FlatAppearance.BorderSize = 0;
            this.Btn_Maximizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.Btn_Maximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Btn_Maximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Btn_Maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Maximizar.Location = new System.Drawing.Point(724, 2);
            this.Btn_Maximizar.Name = "Btn_Maximizar";
            this.Btn_Maximizar.Size = new System.Drawing.Size(35, 35);
            this.Btn_Maximizar.TabIndex = 2;
            this.Btn_Maximizar.UseVisualStyleBackColor = true;
            this.Btn_Maximizar.Click += new System.EventHandler(this.Btn_Maximizar_Click);
            // 
            // Btn_Restaurar
            // 
            this.Btn_Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Restaurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Restaurar.BackgroundImage")));
            this.Btn_Restaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Restaurar.FlatAppearance.BorderSize = 0;
            this.Btn_Restaurar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.Btn_Restaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Btn_Restaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Btn_Restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Restaurar.Location = new System.Drawing.Point(724, 2);
            this.Btn_Restaurar.Name = "Btn_Restaurar";
            this.Btn_Restaurar.Size = new System.Drawing.Size(35, 35);
            this.Btn_Restaurar.TabIndex = 1;
            this.Btn_Restaurar.UseVisualStyleBackColor = true;
            this.Btn_Restaurar.Visible = false;
            this.Btn_Restaurar.Click += new System.EventHandler(this.Btn_Restaurar_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.BackgroundImage")));
            this.Btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Btn_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.Location = new System.Drawing.Point(765, 2);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(35, 35);
            this.Btn_Cerrar.TabIndex = 0;
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Pbx_Logo
            // 
            this.Pbx_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Pbx_Logo.Image")));
            this.Pbx_Logo.Location = new System.Drawing.Point(9, 9);
            this.Pbx_Logo.Name = "Pbx_Logo";
            this.Pbx_Logo.Size = new System.Drawing.Size(180, 90);
            this.Pbx_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbx_Logo.TabIndex = 2;
            this.Pbx_Logo.TabStop = false;
            this.Pbx_Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            // 
            // Btn_ControlRentas
            // 
            this.Btn_ControlRentas.FlatAppearance.BorderSize = 0;
            this.Btn_ControlRentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.Btn_ControlRentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.Btn_ControlRentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ControlRentas.Font = new System.Drawing.Font("Consolas", 15F);
            this.Btn_ControlRentas.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_ControlRentas.Location = new System.Drawing.Point(9, 130);
            this.Btn_ControlRentas.Name = "Btn_ControlRentas";
            this.Btn_ControlRentas.Size = new System.Drawing.Size(180, 90);
            this.Btn_ControlRentas.TabIndex = 2;
            this.Btn_ControlRentas.Text = "Control de Rentas";
            this.Btn_ControlRentas.UseVisualStyleBackColor = true;
            this.Btn_ControlRentas.Click += new System.EventHandler(this.Btn_Maquinas_Click);
            // 
            // Panel_Contenedor
            // 
            this.Panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Contenedor.Location = new System.Drawing.Point(200, 43);
            this.Panel_Contenedor.Name = "Panel_Contenedor";
            this.Panel_Contenedor.Size = new System.Drawing.Size(800, 557);
            this.Panel_Contenedor.TabIndex = 2;
            // 
            // Panel_Principal
            // 
            this.Panel_Principal.Controls.Add(this.PanelTop);
            this.Panel_Principal.Controls.Add(this.Panel_Contenedor);
            this.Panel_Principal.Controls.Add(this.PanelMenu);
            this.Panel_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Principal.Location = new System.Drawing.Point(0, 0);
            this.Panel_Principal.Name = "Panel_Principal";
            this.Panel_Principal.Size = new System.Drawing.Size(1000, 600);
            this.Panel_Principal.TabIndex = 3;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.Panel_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.PanelMenu.ResumeLayout(false);
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Logo)).EndInit();
            this.Panel_Principal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Button Btn_Minimizar;
        private System.Windows.Forms.Button Btn_Maximizar;
        private System.Windows.Forms.Button Btn_Restaurar;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.PictureBox Pbx_Logo;
        private System.Windows.Forms.Button Btn_ControlRentas;
        private System.Windows.Forms.Panel Panel_Contenedor;
        private System.Windows.Forms.Panel Panel_Principal;
    }
}