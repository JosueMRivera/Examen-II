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
    public partial class BuscarClienteForm : Form
    {
        public BuscarClienteForm()
        {
            InitializeComponent();
        }
        ClienteDB clienteDB = new ClienteDB();
        public Cliente cliente = new Cliente();

        private void BuscarClienteForm_Load(object sender, EventArgs e)
        {
            ClientesDGV.DataSource = clienteDB.DevolverClientes();
        }

        private void aceptarbt_Click(object sender, EventArgs e)
        {
            if (ClientesDGV.SelectedRows.Count > 0)
            {
                cliente.Identidad = ClientesDGV.CurrentRow.Cells["Identidad"].Value.ToString();
                cliente.Nombre = ClientesDGV.CurrentRow.Cells["Nombre"].Value.ToString();
                cliente.Telefono = ClientesDGV.CurrentRow.Cells["Telefono"].Value.ToString();
                cliente.Correo = ClientesDGV.CurrentRow.Cells["Correo"].Value.ToString();
                cliente.EstaActivo = Convert.ToBoolean(ClientesDGV.CurrentRow.Cells["EstaActivo"].Value);
                this.Close();

            }
        }

        private void cancelarbt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nombretxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClientesDGV.DataSource = clienteDB.DevolverClientesPorNombre(Nombretxt.Text);
        }
    }
}
