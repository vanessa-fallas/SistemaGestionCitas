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
    public partial class FormCitas : Form
    {
        private int IndiceCitaSeleccionada = -1;
        private int IndiceCitaCancelar = -1;

        public FormCitas()
        {
            InitializeComponent();
            cmbServicio.Items.Clear();

            foreach (string[] Servicio in FormPrincipal.LServicios)
            {
                if (Servicio[3] == "Disponible")
                {
                    cmbServicio.Items.Add(Servicio[0]);
                }
            }

            cmbCliente.Items.Clear();

            foreach (string[] Cliente in FormPrincipal.LClientes)
            {
                cmbCliente.Items.Add(Cliente[1]);
            }
        }



        private void btnRegistrarCIta_Click(object sender, EventArgs e)
        {
            string Cliente = cmbCliente.Text;
            string Servicio = cmbServicio.Text;

            string Fecha = dtpFecha.Value.ToShortDateString();
            string Hora = dtpHora.Value.ToShortTimeString();

            if (Cliente == "" || Servicio == "")
            {
                MessageBox.Show("Debe seleccionar un cliente y un servicio.");
            }
            else
            {

                string[] DatosCita = { Cliente, Servicio, Fecha, Hora };

                FormPrincipal.LCitas.Add(DatosCita);

                MessageBox.Show("Cita registrada correctamente.");

            }
        }


        private void registrarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlInicioGestionCitas.Visible = false;
            pnlRegistrarCita.Visible = true;
            pnlConsultarCitas.Visible = false;
            pnlModificarCita.Visible = false;
            pnlCancelarCita.Visible = false;
        }



        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormPrincipal formulario = Application.OpenForms["FormPrincipal"] as FormPrincipal;

            if (formulario != null)
            {
                formulario.Show();
            }
        }



        private void CargarCitas()
        {
            dgvConsultaCitas.Rows.Clear();

            if (FormPrincipal.LCitas.Count == 0)
            {
                MessageBox.Show("No hay citas registradas.");
                return;
            }

            foreach (string[] Cita in FormPrincipal.LCitas)
            {
                dgvConsultaCitas.Rows.Add(Cita[0], Cita[1], Cita[2], Cita[3]);
            }
        }



        private void CargarFiltros()
        {
            cmbConsultaCliente.Items.Clear();
            cmbConsultaServicio.Items.Clear();

            cmbConsultaCliente.Items.Add("Todos");
            cmbConsultaServicio.Items.Add("Todos");

            foreach (string[] Cita in FormPrincipal.LCitas)
            {
                if (!cmbConsultaCliente.Items.Contains(Cita[0]))
                {
                    cmbConsultaCliente.Items.Add(Cita[0]);
                }

                if (!cmbConsultaServicio.Items.Contains(Cita[1]))
                {
                    cmbConsultaServicio.Items.Add(Cita[1]);
                }
            }
        }



        private void consultarCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlInicioGestionCitas.Visible = false;
            pnlRegistrarCita.Visible = false;
            pnlConsultarCitas.Visible = true;
            pnlModificarCita.Visible = false;
            pnlCancelarCita.Visible = false;
            CargarCitas();
            CargarFiltros();
        }



        private void btnConsultaBuscar_Click(object sender, EventArgs e)
        {
            dgvConsultaCitas.Rows.Clear();

            string ClienteSeleccionado = cmbConsultaCliente.Text;
            string ServicioSeleccionado = cmbConsultaServicio.Text;
            string FechaSeleccionada = dtpConsultaFecha.Value.ToShortDateString();

            int Contador = 0;

            foreach (string[] Cita in FormPrincipal.LCitas)
            {
                bool CoincideCliente = ClienteSeleccionado == "Todos" || Cita[0] == ClienteSeleccionado;

                bool CoincideServicio = ServicioSeleccionado == "Todos" || Cita[1] == ServicioSeleccionado;

                bool CoincideFecha = !dtpConsultaFecha.Checked || Cita[2] == FechaSeleccionada;

                if (CoincideCliente && CoincideServicio && CoincideFecha)
                {
                    dgvConsultaCitas.Rows.Add(Cita[0],Cita[1],Cita[2],Cita[3]);
                    Contador++;
                }
            }

            if (Contador == 0)
            {
                MessageBox.Show("No se encontraron citas con los filtros seleccionados.");
            }
        }

        private void CargarCitasModificar()
        {
            cmbSeleccionarCita.Items.Clear();
            cmbCancelarCita.Items.Clear();

            for (int i = 0; i < FormPrincipal.LCitas.Count; i++)
            {
                string[] Cita = FormPrincipal.LCitas[i];

                string DescripcionCita = Cita[0] + " - " +
                                         Cita[1] + " - " +
                                         Cita[2] + " - " +
                                         Cita[3];

                cmbSeleccionarCita.Items.Add(DescripcionCita);
                cmbCancelarCita.Items.Add(DescripcionCita);
            }
        }



        private void modificarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlInicioGestionCitas.Visible = false;
            pnlRegistrarCita.Visible = false;
            pnlConsultarCitas.Visible = false;
            pnlModificarCita.Visible = true;
            pnlCancelarCita.Visible = false;
            CargarCitasModificar();
        }



        private void cmbSeleccionarCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSeleccionarCita.SelectedIndex == -1)
            {
                return;
            }

            IndiceCitaSeleccionada = cmbSeleccionarCita.SelectedIndex;

            string[] Cita = FormPrincipal.LCitas[IndiceCitaSeleccionada];

            cmbModificarCliente.Items.Clear();
            cmbModificarServicio.Items.Clear();

            foreach (string[] Cliente in FormPrincipal.LClientes)
            {
                cmbModificarCliente.Items.Add(Cliente[1]);
            }

            foreach (string[] Servicio in FormPrincipal.LServicios)
            {
                if (Servicio[3] == "Disponible" || Servicio[0] == Cita[1])
                {
                    cmbModificarServicio.Items.Add(Servicio[0]);
                }
            }

            cmbModificarCliente.Text = Cita[0];
            cmbModificarServicio.Text = Cita[1];

            dtpModificarFecha.Value = DateTime.Parse(Cita[2]);
            dtpModificarHora.Value = DateTime.Parse(Cita[3]);
        }



        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (IndiceCitaSeleccionada == -1)
            {
                MessageBox.Show("Debe seleccionar una cita.");
                return;
            }

            string Cliente = cmbModificarCliente.Text;
            string Servicio = cmbModificarServicio.Text;
            string Fecha = dtpModificarFecha.Value.ToShortDateString();
            string Hora = dtpModificarHora.Value.ToShortTimeString();


            if (Cliente == "" || Servicio == "")
            {
                MessageBox.Show("Debe seleccionar un cliente y un servicio.");
                return;
            }

            string[] DatosCita = { Cliente, Servicio, Fecha, Hora };

            FormPrincipal.LCitas[IndiceCitaSeleccionada] = DatosCita;

            MessageBox.Show("Cita modificada correctamente.");

            CargarCitasModificar();
        }



        private void btnCancelarCita_Click(object sender, EventArgs e)
        {
            if (IndiceCitaCancelar == -1)
            {
                MessageBox.Show("Debe seleccionar una cita.");
                return;
            }

            FormPrincipal.LCitas.RemoveAt(IndiceCitaCancelar);

            MessageBox.Show("La cita se canceló correctamente.");

            CargarCitasModificar();
        }



        private void cancelarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlInicioGestionCitas.Visible = false;
            pnlRegistrarCita.Visible = false;
            pnlConsultarCitas.Visible = false;
            pnlModificarCita.Visible = false;
            pnlCancelarCita.Visible = true;

            CargarCitasModificar();
        }



        private void cmbCancelarCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndiceCitaCancelar = cmbCancelarCita.SelectedIndex;
        }

    }
}
