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
        int IndiceClienteEditando = -1;

        private void registrarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            SalirModoEdicion();
            LimpiarCamposCliente();
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
            string cedula = txtCedula.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();

            string error = ValidarCliente(cedula, nombre, telefono);
            if (error != "")
            {
                MessageBox.Show(error, "Datos no válidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] datos = { cedula, nombre, telefono };

            if (IndiceClienteEditando == -1)
            {
                LClientes.Add(datos);
                MessageBox.Show("Cliente registrado correctamente.");
            }
            else
            {
                LClientes[IndiceClienteEditando] = datos;
                MessageBox.Show("Cliente modificado correctamente.");
                SalirModoEdicion();
            }

            LimpiarCamposCliente();
            MostrarClientes("");
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

        private string ValidarCliente(string cedula, string nombre, string telefono)
        {
            if (cedula == "" || nombre == "" || telefono == "")
                return "Todos los campos son obligatorios.";

            if (cedula.Length != 9 || !cedula.All(char.IsDigit))
                return "La cédula debe tener 9 dígitos numéricos.";

            if (nombre.Length < 3 || nombre.Length > 60)
                return "El nombre debe tener entre 3 y 60 caracteres.";

            if (telefono.Length != 8 || !telefono.All(char.IsDigit))
                return "El teléfono debe tener 8 dígitos numéricos.";

            for (int i = 0; i < LClientes.Count; i++)
            {
                if (i == IndiceClienteEditando) continue;
                if (LClientes[i][0] == cedula)
                    return "Ya existe un cliente con esa cédula.";
            }
            return "";
        }

        private int BuscarIndiceCliente(string cedula)
        {
            for (int i = 0; i < LClientes.Count; i++)
                if (LClientes[i][0] == cedula) return i;
            return -1;
        }

        private void MostrarClientes(string filtro)
        {
            dgvClientes.Rows.Clear();
            foreach (string[] c in LClientes)
            {
                if (filtro == "" || c[0].Contains(filtro) ||
                    c[1].IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    dgvClientes.Rows.Add(c[0], c[1], c[2]);
                }
            }
        }

        private void SalirModoEdicion()
        {
            IndiceClienteEditando = -1;
            txtCedula.ReadOnly = false;
            btnRegistrar.Text = "Registrar";
        }

        private void LimpiarCamposCliente()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
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

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente de la tabla.");
                return;
            }
            string cedula = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            IndiceClienteEditando = BuscarIndiceCliente(cedula);

            string[] c = LClientes[IndiceClienteEditando];
            txtCedula.Text = c[0];
            txtNombre.Text = c[1];
            txtTelefono.Text = c[2];
            txtCedula.ReadOnly = true;
            btnRegistrar.Text = "Guardar cambios";

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBuscarcliente_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            MostrarClientes(txtBuscarCliente.Text.Trim());
            if (dgvClientes.Rows.Count == 0)
                MessageBox.Show("No se encontraron clientes.");
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            txtBuscarCliente.Clear();
            MostrarClientes("");
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente de la tabla.");
                return;
            }
            string cedula = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            string nombre = dgvClientes.CurrentRow.Cells[1].Value.ToString();

            DialogResult r = MessageBox.Show("¿Eliminar al cliente " + nombre + "?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                LClientes.RemoveAt(BuscarIndiceCliente(cedula));
                MostrarClientes(txtBuscarCliente.Text.Trim());
            }
        }
    }
}
