namespace pryDeganiSp4._2
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvVentas = new DataGridView();
            Mozos = new DataGridViewTextBoxColumn();
            Comidas = new DataGridViewTextBoxColumn();
            BebidasSinAlcohol = new DataGridViewTextBoxColumn();
            BebidasConAlcohol = new DataGridViewTextBoxColumn();
            Postres = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { Mozos, Comidas, BebidasSinAlcohol, BebidasConAlcohol, Postres });
            dgvVentas.Location = new Point(22, 24);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.Size = new Size(537, 228);
            dgvVentas.TabIndex = 0;
            dgvVentas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Mozos
            // 
            Mozos.HeaderText = "Mozos";
            Mozos.Name = "Mozos";
            // 
            // Comidas
            // 
            Comidas.HeaderText = "Comidas";
            Comidas.Name = "Comidas";
            // 
            // BebidasSinAlcohol
            // 
            BebidasSinAlcohol.HeaderText = "Bebidas sin alcohol";
            BebidasSinAlcohol.Name = "BebidasSinAlcohol";
            // 
            // BebidasConAlcohol
            // 
            BebidasConAlcohol.HeaderText = "Bebidas con Alcohol";
            BebidasConAlcohol.Name = "BebidasConAlcohol";
            // 
            // Postres
            // 
            Postres.HeaderText = "Postres";
            Postres.Name = "Postres";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvVentas);
            Name = "frmMain";
            Text = "La milanga - Registro de Ventas";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVentas;
        private DataGridViewTextBoxColumn Mozos;
        private DataGridViewTextBoxColumn Comidas;
        private DataGridViewTextBoxColumn BebidasSinAlcohol;
        private DataGridViewTextBoxColumn BebidasConAlcohol;
        private DataGridViewTextBoxColumn Postres;
    }
}
