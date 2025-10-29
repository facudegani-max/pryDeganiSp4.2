using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace pryDeganiSp4._2
{
    public partial class frmMain : Form
    {
        //Carga de Nombres y Categorias (5 mozos y 4 categorías)
        private readonly string[] _mozos = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };
        private readonly string[] _categorias = { "Comidas", "Beb. s/ alcohol", "Beb. c/ alcohol", "Postres" };

        // Arreglo bidimensional solicitado
        private readonly float[,] ventas = new float[5, 4];

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Configuración de Grilla
            dgvVentas.AllowUserToAddRows = false; //Evita que el usuario agregue filas vacías al final
            dgvVentas.AllowUserToDeleteRows = false; //Evita que el usuario elimine filas
            dgvVentas.MultiSelect = false; //Solo una celda seleccionada a la vez
            dgvVentas.SelectionMode = DataGridViewSelectionMode.CellSelect; //Selección por celda
            dgvVentas.EditMode = DataGridViewEditMode.EditOnEnter; //Entra en modo edición al seleccionar una celda
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Las columnas ocupan todo el ancho disponible
            dgvVentas.RowHeadersVisible = false; //Oculta el encabezado de filas

            // Creacion de grilla para que la vea el usuario
            if (dgvVentas.Columns.Count == 0)
            {
                var colMozo = new DataGridViewTextBoxColumn
                {
                    Name = "Mozo",
                    HeaderText = "Mozo",
                    ReadOnly = true,
                    SortMode = DataGridViewColumnSortMode.NotSortable,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                };
                dgvVentas.Columns.Add(colMozo);

                foreach (var cat in _categorias)
                {
                    var col = new DataGridViewTextBoxColumn
                    {
                        Name = cat,
                        HeaderText = cat,
                        SortMode = DataGridViewColumnSortMode.NotSortable,
                        ValueType = typeof(string) // validamos a mano luego
                    };
                    dgvVentas.Columns.Add(col);
                }
            }

            // Limpio y cargo 5 filas, una por mozo, con el nombre en la col 0
            dgvVentas.Rows.Clear();
            dgvVentas.Rows.Add(_mozos.Length);
            for (int i = 0; i < _mozos.Length; i++)
            {
                dgvVentas.Rows[i].Cells[0].Value = _mozos[i];
                dgvVentas.Rows[i].Cells[0].Style.BackColor = Color.LightBlue; // tu estilo
            }

            // Estado inicial: consultas deshabilitadas hasta validar
            btnMozoDia.Enabled = false;
            btnTotal.Enabled = false;

            // Seleccion de celda inicial
            dgvVentas.CurrentCell = dgvVentas.Rows[0].Cells[1];

            // Enganchar eventos 
            btnValidar.Click += btnValidar_Click;
            btnMozoDia.Click += btnMozoDia_Click;
            btnTotal.Click += btnTotal_Click;
            btnSalir.Click += btnSalir_Click;

        }

        // ===================== VALIDACIÓN =====================
        private void btnValidar_Click(object sender, EventArgs e)
        {
            bool ok = true;
            errorProvider1.Clear();

            // Limpio colores de error previos
            foreach (DataGridViewRow r in dgvVentas.Rows)
                for (int c = 1; c <= _categorias.Length; c++)
                    r.Cells[c].Style.BackColor = Color.White;

            for (int fila = 0; fila < _mozos.Length; fila++)
            {
                for (int col = 1; col <= _categorias.Length; col++) // columnas 1..4 (editables)
                {
                    var cell = dgvVentas.Rows[fila].Cells[col];
                    var raw = cell.Value?.ToString()?.Trim();

                    if (string.IsNullOrWhiteSpace(raw))
                    {
                        ok = false;
                        MarcarErrorCelda(cell, "Campo vacío. Ingrese un número (0 válido).");
                        continue;
                    }

                    if (!TryParseFloatFlexible(raw, out float valor))
                    {
                        ok = false;
                        MarcarErrorCelda(cell, "Formato inválido. Use número (0 válido).");
                        continue;
                    }

                    // Guardo en el arreglo ventas[fila, categoria]
                    ventas[fila, col - 1] = valor;
                }
            }

            if (!ok)
            {
                btnMozoDia.Enabled = false;
                btnTotal.Enabled = false;
                MessageBox.Show("Hay errores de validación. Corrija los campos marcados.\n" +
                                "Las consultas seguirán deshabilitadas.",
                                "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnMozoDia.Enabled = true;
            btnTotal.Enabled = true;
            MessageBox.Show("Datos válidos. Ya podés hacer las consultas.", "OK",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MarcarErrorCelda(DataGridViewCell cell, string mensaje)
        {
            // Color de fondo en la celda y tooltip de error provider
            cell.Style.BackColor = Color.MistyRose;
            errorProvider1.SetIconAlignment(dgvVentas, ErrorIconAlignment.MiddleRight);
            errorProvider1.SetError(dgvVentas, mensaje);
        }

        private bool TryParseFloatFlexible(string input, out float result)
        {
            // Acepta coma o punto según cultura
            if (float.TryParse(input, NumberStyles.Float, CultureInfo.CurrentCulture, out result))
                return true;

            if (float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out result))
                return true;

            var decSep = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            var alt = decSep == "," ? input.Replace(".", ",") : input.Replace(",", ".");
            return float.TryParse(alt, NumberStyles.Float, CultureInfo.CurrentCulture, out result);
        }

        // ===================== MOZO DEL DÍA =====================
        private void btnMozoDia_Click(object sender, EventArgs e)
        {
            int posicion = -1;
            float maxTotal = float.MinValue;
            float suma = 0f;

            //Bucle para encontrar el mozo con mayor venta total
            for (int fila = 0; fila < _mozos.Length; fila++)
            {
                for (int col = 0; col < _categorias.Length; col++)
                    suma += ventas[fila, col];

                if (suma > maxTotal)
                {
                    maxTotal = suma;
                    posicion = fila;
                }
            }

            if (posicion >= 0)
            {
                txtMozoNombre.Text = _mozos[posicion];
                txtImporteTotal.Text = maxTotal.ToString("N2", CultureInfo.CurrentCulture);
            }
        }

        // ===================== TOTAL =====================
        private void btnTotal_Click(object sender, EventArgs e)
        {
            float totalGeneral = 0f; // of para que float no pase a double
            float totalComidas = 0f, totalBebidasSin = 0f, totalBebidasCon = 0f, totalPostres = 0f;

            for (int fila = 0; fila < _mozos.Length; fila++)
            {
                totalComidas += ventas[fila, 0];
                totalBebidasSin += ventas[fila, 1];
                totalBebidasCon += ventas[fila, 2];
                totalPostres += ventas[fila, 3];
            }

            totalGeneral = totalComidas + totalBebidasSin + totalBebidasCon + totalPostres;

            txtTotalGeneral.Text = totalGeneral.ToString("N2", CultureInfo.CurrentCulture);
            txtTotalComida.Text = totalComidas.ToString("N2", CultureInfo.CurrentCulture);
            txtTotalBebidasSinAlcohol.Text = totalBebidasSin.ToString("N2", CultureInfo.CurrentCulture);
            txtTotalBebidasConAlcohol.Text = totalBebidasCon.ToString("N2", CultureInfo.CurrentCulture);
            txtTotalPostre.Text = totalPostres.ToString("N2", CultureInfo.CurrentCulture);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
