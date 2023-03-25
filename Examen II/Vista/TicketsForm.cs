using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class TicketsForm : Form
    {
        public TicketsForm()
        {
            InitializeComponent();
        }
        Cliente miCliente = null;
        ClienteDB clienteDB = new ClienteDB();
        List<DetalleTicket> listaDetalles = new List<DetalleTicket>();
        TicketDB ticketDB = new TicketDB();
        decimal subTotal = 0;
        decimal isv = 0;
        decimal totalAPagar = 0;
        decimal descuento = 0;

        private void AparatocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (AparatocomboBox.Text == "Celular")
            {
                aparatotxt.Text = AparatocomboBox.Text;
                soportetxt.Text = SoportecomboBox.Text;
                SoportecomboBox.Items.Clear();
                string[] Soporte = new string[] { "Reparación de Hardware", "Actualización de Software", "Instalación y Configuración de Aplicaciones", "Mantenimiento preventivo" };
                SoportecomboBox.Items.AddRange(Soporte);
                
            }
            else if (AparatocomboBox.Text == "Equipo de Computo")
            {
                aparatotxt.Text = AparatocomboBox.Text;
                soportetxt.Text = SoportecomboBox.Text;
                SoportecomboBox.Items.Clear();
                string[] Soporte = new string[] { "Instalación y Configuración de Software y Hardware", "Actualización de Software", "Servicio y Reparación", "Configuración y Mantenimiento de Redes", "Soporte de Seguridad", "Mantenimiento preventivo" };
                SoportecomboBox.Items.AddRange(Soporte);
            }
            else
                SoportecomboBox.Items.Clear();
                soportetxt.Clear();
        }

        private void SoportecomboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(SoportecomboBox.Text))
            {
                soportetxt.Text = SoportecomboBox.Text;
            }
        }



        private void buscarclientebt_Click(object sender, EventArgs e)
        {
            BuscarClienteForm Form = new BuscarClienteForm();
            Form.ShowDialog();
            miCliente = new Cliente();
            miCliente = Form.cliente;
            Identidadtxt.Text = miCliente.Identidad;
            Nombreclientetxt.Text = miCliente.Nombre;
        }

        private void TicketsForm_Load(object sender, EventArgs e)
        {
            Usuariotxt.Text = System.Threading.Thread.CurrentPrincipal.Identity.Name;
        }

        private void Identidadtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(Identidadtxt.Text))
            {
                miCliente = new Cliente();
                miCliente = clienteDB.DevolverClientesPorIdentidad(Identidadtxt.Text);
                Nombreclientetxt.Text = miCliente.Nombre;
            }
            else
            {
                miCliente = null;
                Nombreclientetxt.Clear();
            }
        }

        private void preciotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                DetalleTicket detalle = new DetalleTicket();
                detalle.TipoSoporte = soportetxt.Text;
                detalle.DescripcionSolicitud = descripcionsolicitudtxt.Text;
                detalle.DescripcionRespuesta = descripcionrespuestatxt.Text;
                detalle.Precio = Convert.ToDecimal(preciotxt.Text);

                subTotal += detalle.Precio;
                isv = subTotal * 0.15M;
                totalAPagar = subTotal + isv;

                listaDetalles.Add(detalle);
                DetalleTicketDGV.DataSource = null;
                DetalleTicketDGV.DataSource = listaDetalles;

                subtotaltxt.Text = subTotal.ToString("N2");
                Isvtxt.Text = isv.ToString("N2");
                totalapagartxt.Text = totalAPagar.ToString("N2");

                preciotxt.Clear();

            }
        }

        private void Guardarbt_Click(object sender, EventArgs e)
        {
            Ticket miTicket = new Ticket();
            miTicket.Fecha = FechadateTimePicker.Value;
            miTicket.CodigoUsuario = System.Threading.Thread.CurrentPrincipal.Identity.Name;
            miTicket.IdentidadCliente = miCliente.Identidad;
            miTicket.SubTotal = subTotal;
            miTicket.ISV = isv;
            miTicket.Descuento = descuento;
            miTicket.Total = totalAPagar;

            bool inserto = ticketDB.Guardar(miTicket, listaDetalles);

            if (inserto)
            {
                LimpiarControles();
                Identidadtxt.Focus();
                MessageBox.Show("Factura Registrada Correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo registrar la factura");
            }
        }

        private void LimpiarControles()
        {
            miCliente = null;
            listaDetalles = null;
            FechadateTimePicker.Value = DateTime.Now;
            Identidadtxt.Clear();
            Nombreclientetxt.Clear();
            descripcionsolicitudtxt.Clear();
            descripcionrespuestatxt.Clear();
            AparatocomboBox = null;
            SoportecomboBox = null;
            DetalleTicketDGV.DataSource = null;
            subTotal = 0;
            subtotaltxt.Clear();
            isv = 0;
            Isvtxt.Clear();
            descuento = 0;
            Descuentotxt.Clear();
            totalAPagar = 0;
            totalapagartxt.Clear();
        }

        private void Descuentotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            if (e.KeyChar == (Char)Keys.Enter && !String.IsNullOrEmpty(Descuentotxt.Text))
            {
                descuento = Convert.ToDecimal(Descuentotxt.Text);
                totalAPagar = totalAPagar - descuento;
                totalapagartxt.Text = totalAPagar.ToString();
            }
        }

        private void Cancelarbt_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
    }
}
