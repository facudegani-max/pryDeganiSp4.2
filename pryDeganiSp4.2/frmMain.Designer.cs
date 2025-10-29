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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            dgvVentas = new DataGridView();
            Mozos = new DataGridViewTextBoxColumn();
            Comidas = new DataGridViewTextBoxColumn();
            BebidasSinAlcohol = new DataGridViewTextBoxColumn();
            BebidasConAlcohol = new DataGridViewTextBoxColumn();
            Postres = new DataGridViewTextBoxColumn();
            btnValidar = new Button();
            btnMozoDia = new Button();
            label1 = new Label();
            label2 = new Label();
            txtMozoNombre = new TextBox();
            txtImporteTotal = new TextBox();
            btnTotal = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtTotalGeneral = new TextBox();
            txtTotalBebidasSinAlcohol = new TextBox();
            txtTotalBebidasConAlcohol = new TextBox();
            txtTotalPostre = new TextBox();
            txtTotalComida = new TextBox();
            btnSalir = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { Mozos, Comidas, BebidasSinAlcohol, BebidasConAlcohol, Postres });
            dgvVentas.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvVentas.Location = new Point(22, 24);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvVentas.Size = new Size(537, 228);
            dgvVentas.TabIndex = 0;
            // 
            // Mozos
            // 
            Mozos.HeaderText = "Mozos";
            Mozos.MinimumWidth = 6;
            Mozos.Name = "Mozos";
            // 
            // Comidas
            // 
            Comidas.HeaderText = "Comidas";
            Comidas.MinimumWidth = 6;
            Comidas.Name = "Comidas";
            // 
            // BebidasSinAlcohol
            // 
            BebidasSinAlcohol.HeaderText = "Bebidas sin alcohol";
            BebidasSinAlcohol.MinimumWidth = 6;
            BebidasSinAlcohol.Name = "BebidasSinAlcohol";
            // 
            // BebidasConAlcohol
            // 
            BebidasConAlcohol.HeaderText = "Bebidas con Alcohol";
            BebidasConAlcohol.MinimumWidth = 6;
            BebidasConAlcohol.Name = "BebidasConAlcohol";
            // 
            // Postres
            // 
            Postres.HeaderText = "Postres";
            Postres.MinimumWidth = 6;
            Postres.Name = "Postres";
            // 
            // btnValidar
            // 
            btnValidar.BackColor = Color.IndianRed;
            btnValidar.Location = new Point(293, 579);
            btnValidar.Margin = new Padding(3, 2, 3, 2);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(128, 43);
            btnValidar.TabIndex = 1;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = false;
            // 
            // btnMozoDia
            // 
            btnMozoDia.BackColor = Color.IndianRed;
            btnMozoDia.Location = new Point(403, 79);
            btnMozoDia.Margin = new Padding(3, 2, 3, 2);
            btnMozoDia.Name = "btnMozoDia";
            btnMozoDia.Size = new Size(128, 43);
            btnMozoDia.TabIndex = 2;
            btnMozoDia.Text = "Mozo del dia";
            btnMozoDia.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 40);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 63);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 4;
            label2.Text = "Importe Total";
            // 
            // txtMozoNombre
            // 
            txtMozoNombre.Location = new Point(117, 35);
            txtMozoNombre.Margin = new Padding(3, 2, 3, 2);
            txtMozoNombre.Name = "txtMozoNombre";
            txtMozoNombre.Size = new Size(110, 23);
            txtMozoNombre.TabIndex = 5;
            // 
            // txtImporteTotal
            // 
            txtImporteTotal.Location = new Point(117, 60);
            txtImporteTotal.Margin = new Padding(3, 2, 3, 2);
            txtImporteTotal.Name = "txtImporteTotal";
            txtImporteTotal.Size = new Size(110, 23);
            txtImporteTotal.TabIndex = 6;
            // 
            // btnTotal
            // 
            btnTotal.BackColor = Color.IndianRed;
            btnTotal.Location = new Point(404, 129);
            btnTotal.Margin = new Padding(3, 2, 3, 2);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(128, 43);
            btnTotal.TabIndex = 7;
            btnTotal.Text = "Total";
            btnTotal.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 41);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 8;
            label3.Text = "Total General";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 65);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 9;
            label4.Text = "Total Comida";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 89);
            label5.Name = "label5";
            label5.Size = new Size(138, 15);
            label5.TabIndex = 10;
            label5.Text = "Total Bebidas sin Alcohol";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 113);
            label6.Name = "label6";
            label6.Size = new Size(143, 15);
            label6.TabIndex = 11;
            label6.Text = "Total Bebidas con Alcohol";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 137);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 12;
            label7.Text = "Total Postre";
            // 
            // txtTotalGeneral
            // 
            txtTotalGeneral.Location = new Point(217, 38);
            txtTotalGeneral.Margin = new Padding(3, 2, 3, 2);
            txtTotalGeneral.Name = "txtTotalGeneral";
            txtTotalGeneral.Size = new Size(110, 23);
            txtTotalGeneral.TabIndex = 13;
            // 
            // txtTotalBebidasSinAlcohol
            // 
            txtTotalBebidasSinAlcohol.Location = new Point(217, 87);
            txtTotalBebidasSinAlcohol.Margin = new Padding(3, 2, 3, 2);
            txtTotalBebidasSinAlcohol.Name = "txtTotalBebidasSinAlcohol";
            txtTotalBebidasSinAlcohol.Size = new Size(110, 23);
            txtTotalBebidasSinAlcohol.TabIndex = 14;
            // 
            // txtTotalBebidasConAlcohol
            // 
            txtTotalBebidasConAlcohol.Location = new Point(217, 112);
            txtTotalBebidasConAlcohol.Margin = new Padding(3, 2, 3, 2);
            txtTotalBebidasConAlcohol.Name = "txtTotalBebidasConAlcohol";
            txtTotalBebidasConAlcohol.Size = new Size(110, 23);
            txtTotalBebidasConAlcohol.TabIndex = 15;
            // 
            // txtTotalPostre
            // 
            txtTotalPostre.Location = new Point(217, 136);
            txtTotalPostre.Margin = new Padding(3, 2, 3, 2);
            txtTotalPostre.Name = "txtTotalPostre";
            txtTotalPostre.Size = new Size(110, 23);
            txtTotalPostre.TabIndex = 16;
            // 
            // txtTotalComida
            // 
            txtTotalComida.Location = new Point(217, 62);
            txtTotalComida.Margin = new Padding(3, 2, 3, 2);
            txtTotalComida.Name = "txtTotalComida";
            txtTotalComida.Size = new Size(110, 23);
            txtTotalComida.TabIndex = 17;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.IndianRed;
            btnSalir.Location = new Point(426, 579);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(128, 43);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnMozoDia);
            groupBox1.Controls.Add(txtMozoNombre);
            groupBox1.Controls.Add(txtImporteTotal);
            groupBox1.Location = new Point(22, 268);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(537, 126);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consulta Mozo";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.InactiveCaption;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtTotalComida);
            groupBox2.Controls.Add(btnTotal);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtTotalPostre);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtTotalBebidasConAlcohol);
            groupBox2.Controls.Add(txtTotalGeneral);
            groupBox2.Controls.Add(txtTotalBebidasSinAlcohol);
            groupBox2.Location = new Point(22, 398);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(537, 176);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Consulta Total";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 629);
            Controls.Add(groupBox2);
            Controls.Add(btnSalir);
            Controls.Add(groupBox1);
            Controls.Add(btnValidar);
            Controls.Add(dgvVentas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "La milanga - Registro de Ventas";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVentas;
        private DataGridViewTextBoxColumn Mozos;
        private DataGridViewTextBoxColumn Comidas;
        private DataGridViewTextBoxColumn BebidasSinAlcohol;
        private DataGridViewTextBoxColumn BebidasConAlcohol;
        private DataGridViewTextBoxColumn Postres;
        private Button btnValidar;
        private Button btnMozoDia;
        private Label label1;
        private Label label2;
        private TextBox txtMozoNombre;
        private TextBox txtImporteTotal;
        private Button btnTotal;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtTotalGeneral;
        private TextBox txtTotalBebidasSinAlcohol;
        private TextBox txtTotalBebidasConAlcohol;
        private TextBox txtTotalPostre;
        private TextBox txtTotalComida;
        private Button btnSalir;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ErrorProvider errorProvider1;
    }
}
