using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Salão_Model.WinForm
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void serviçoToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void Inicial_Load(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClient addclient = new AddClient();
            addclient.ShowDialog();
        }
    }
}
