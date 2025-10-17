namespace pryDeganiSp4._2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dgvVentas.Rows.Add("Julio");
            dgvVentas.Rows.Add("Esteban");
            dgvVentas.Rows.Add("Javier");
            dgvVentas.Rows.Add("Pablo");
            dgvVentas.Rows.Add("Ramon");

            dgvVentas.Rows[0].Cells[0].Style.BackColor = Color.LightBlue;
            dgvVentas.Rows[1].Cells[0].Style.BackColor = Color.LightBlue;
            dgvVentas.Rows[2].Cells[0].Style.BackColor = Color.LightBlue;
            dgvVentas.Rows[3].Cells[0].Style.BackColor = Color.LightBlue;
            dgvVentas.Rows[4].Cells[0].Style.BackColor = Color.LightBlue;

            dgvVentas.Rows[0].Cells[0].Selected = true;
            dgvVentas.Rows[0].Cells[1].Selected = false;


        }
    }
}
