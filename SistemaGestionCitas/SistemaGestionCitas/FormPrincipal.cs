using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionCitas
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        List<string[]> LClientes = new List<string[]>();
        private void registrarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void registrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;
            pnlClientes.Visible = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string CedulaTexto = txtCedula.Text.Trim();
            string NombreTexto = txtNombre.Text.Trim();
            string TelefonoTexto = txtTelefono.Text.Trim();

            if (!int.TryParse(CedulaTexto, out int CedulaNum) || CedulaTexto=="")
            {
                MessageBox.Show("Entrada no valida en 'Cédula:'");
            }
            else if (NombreTexto == "")
            {
                MessageBox.Show("Entrada no valida en 'Nombre Completo:'");
            }
            else if (!int.TryParse(TelefonoTexto, out int TelefonoNum) || TelefonoTexto == "")
            {
                MessageBox.Show("Entrada no valida en 'Teléfono:'");
            }
            else
            {
                string[] DatosCliente = { CedulaTexto, NombreTexto, TelefonoTexto };
                LClientes.Add(DatosCliente);
                dgvClientes.Rows.Add(CedulaTexto,NombreTexto,TelefonoTexto);

                MessageBox.Show("Cliente registrado correctamente");

                txtCedula.Clear();
                txtNombre.Clear();
                txtTelefono.Clear();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pnlClientes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
