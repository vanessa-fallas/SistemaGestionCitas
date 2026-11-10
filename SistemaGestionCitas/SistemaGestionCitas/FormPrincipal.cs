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

        List<string[]> LServicios = new List<string[]>();

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
            pnlServicios.Visible = false;
            pnlAgregarServicios.Visible = false;
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

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            pnlAgregarServicios.Visible = true;
            pnlServicios.Visible = false;
        }

        private void regristrarServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlServicios.Visible = true;
            pnlInicio.Visible = false;
            pnlClientes.Visible = false;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            pnlAgregarServicios.Visible=false;
            pnlServicios.Visible=true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string NombreTexto = txtNServicio.Text.Trim();
            string PrecioTexto = txtPServicio.Text.Trim();
            string DuracionTexto = txtDServicio.Text.Trim();

            bool NombreRepetido = false;

            foreach (string[] Servicio in LServicios)
            {
                if (Servicio[0].Equals(NombreTexto, StringComparison.OrdinalIgnoreCase))
                {
                    NombreRepetido = true;
                    break;
                }
            }

            if (NombreTexto == "" || NombreRepetido)
            {
                MessageBox.Show("Entrada no valida en 'Nombre del servicio: '");
            }
            else if (!decimal.TryParse(PrecioTexto, out decimal Precio) || Precio < 0)
            {
                MessageBox.Show("Entrada no valida en 'Precio: '");
            }
            else if (!int.TryParse(DuracionTexto, out int Duracion) || Duracion <= 0)
            {
                MessageBox.Show("Entrada no valida en 'Duración en minutos: '");
            }
            else
            {
                string Estado;

                if (chkDisponibilidad.Checked)
                {
                    Estado = "Disponible";
                }
                else
                {
                    Estado = "No disponible";
                }

                string[] DatosServicio = {NombreTexto, PrecioTexto, DuracionTexto, Estado};

                LServicios.Add(DatosServicio);
                ActualizarContadores();

                dgvServicios.Rows.Add(NombreTexto,PrecioTexto,DuracionTexto,Estado);

                MessageBox.Show("Servicio registrado correctamente.");

                txtNServicio.Clear();
                txtDServicio.Clear();
                txtPServicio.Clear();

                pnlAgregarServicios.Visible = false;
                pnlServicios.Visible = true;
            }
        }

        private void btnActualizarLista_Click(object sender, EventArgs e)
        {
            string Busqueda = txtBuscarServicio.Text.Trim();

            dgvServicios.Rows.Clear();

            foreach (string[] Servicio in LServicios)
            {
                if (Servicio[0].IndexOf(Busqueda, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    dgvServicios.Rows.Add(Servicio[0],Servicio[1],Servicio[2],Servicio[3]);
                }
            }

            if (dgvServicios.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron servicios.");
            }
        }

        private void ActualizarContadores()
        {
            int Total = LServicios.Count;
            int Disponibles = 0;

            foreach (string[] Servicio in LServicios)
            {
                if (Servicio[3] == "Disponible")
                {
                    Disponibles++;
                }
            }

            lblTotalServicios.Text = "Total: " + Total;
            lblDisponibles.Text = "Disponibles: " + Disponibles;
        }
    }
}
