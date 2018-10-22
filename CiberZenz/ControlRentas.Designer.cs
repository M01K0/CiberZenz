namespace CiberZenz
{
    partial class ControlRentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlRentas));
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.DGV_Rentas = new System.Windows.Forms.DataGridView();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.ColNumEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColHoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCerrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rentas)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Consolas", 20F);
            this.Lbl_Titulo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lbl_Titulo.Location = new System.Drawing.Point(256, 9);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(270, 32);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Control de Rentas";
            // 
            // DGV_Rentas
            // 
            this.DGV_Rentas.AllowUserToAddRows = false;
            this.DGV_Rentas.AllowUserToDeleteRows = false;
            this.DGV_Rentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Rentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DGV_Rentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Rentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNumEquipo,
            this.ColTipo,
            this.ColAccion,
            this.ColHoraInicio,
            this.ColTiempo,
            this.ColCerrar});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Rentas.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Rentas.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGV_Rentas.Location = new System.Drawing.Point(12, 44);
            this.DGV_Rentas.Name = "DGV_Rentas";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Rentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGV_Rentas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Rentas.Size = new System.Drawing.Size(760, 406);
            this.DGV_Rentas.TabIndex = 1;
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
            this.Btn_Cerrar.Location = new System.Drawing.Point(747, 2);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(35, 35);
            this.Btn_Cerrar.TabIndex = 2;
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            // 
            // ColNumEquipo
            // 
            this.ColNumEquipo.HeaderText = "#Equipo";
            this.ColNumEquipo.Name = "ColNumEquipo";
            // 
            // ColTipo
            // 
            this.ColTipo.HeaderText = "Tipo";
            this.ColTipo.Name = "ColTipo";
            // 
            // ColAccion
            // 
            this.ColAccion.HeaderText = "Accion";
            this.ColAccion.Name = "ColAccion";
            // 
            // ColHoraInicio
            // 
            this.ColHoraInicio.HeaderText = "Hora Inicio";
            this.ColHoraInicio.Name = "ColHoraInicio";
            // 
            // ColTiempo
            // 
            this.ColTiempo.HeaderText = "Tiempo";
            this.ColTiempo.Name = "ColTiempo";
            // 
            // ColCerrar
            // 
            this.ColCerrar.HeaderText = "Cerrar";
            this.ColCerrar.Name = "ColCerrar";
            // 
            // ControlRentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.DGV_Rentas);
            this.Controls.Add(this.Lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlRentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ControlRentas";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.DataGridView DGV_Rentas;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumEquipo;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColTipo;
        private System.Windows.Forms.DataGridViewButtonColumn ColAccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCerrar;
    }
}