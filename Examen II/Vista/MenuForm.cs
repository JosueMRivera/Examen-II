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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void NuevoTicketstoolStripButton_Click(object sender, EventArgs e)
        {
            TicketsForm ticketsForm = new TicketsForm();
            ticketsForm.MdiParent = this;
            ticketsForm.Show();
        }

        private void ConsultarTickettoolStripButton_Click(object sender, EventArgs e)
        {
            BuscarTicketForm buscarTicket  = new BuscarTicketForm();
            buscarTicket.MdiParent = this;
            buscarTicket.Show();
        }
    }
}
