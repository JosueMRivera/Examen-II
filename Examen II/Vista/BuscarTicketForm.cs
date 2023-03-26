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
    public partial class BuscarTicketForm : Form
    {
        public BuscarTicketForm()
        {
            InitializeComponent();
        }
        TicketDB ticketDB = new TicketDB();
        public Ticket ticket = new Ticket();

        private void BuscarTicketForm_Load(object sender, EventArgs e)
        {
            TicketsDGV.DataSource = ticketDB.DevolverTicketsPorIdentidad(identidadtxt.Text);
        }

        private void aceptarbt_Click(object sender, EventArgs e)
        {
            if (TicketsDGV.SelectedRows.Count > 0)
            {
                ticket.Fecha = Convert.ToDateTime(TicketsDGV.CurrentRow.Cells["Fecha"].Value);
                ticket.CodigoUsuario = TicketsDGV.CurrentRow.Cells["CodigoUsuario"].Value.ToString();
                ticket.IdentidadCliente = TicketsDGV.CurrentRow.Cells["IdentidadCliente"].Value.ToString();
                ticket.SubTotal = Convert.ToDecimal(TicketsDGV.CurrentRow.Cells["SubTotal"].Value);
                ticket.ISV = Convert.ToDecimal(TicketsDGV.CurrentRow.Cells["ISV"].Value);
                ticket.Descuento = Convert.ToDecimal(TicketsDGV.CurrentRow.Cells["Descuento"].Value);
                ticket.Total = Convert.ToDecimal(TicketsDGV.CurrentRow.Cells["Total"].Value);
                this.Close();

            }
        }

        private void cancelarbt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void identidadtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TicketsDGV.DataSource = ticketDB.DevolverTicketsPorIdentidad(identidadtxt.Text);
        }
    }
}
