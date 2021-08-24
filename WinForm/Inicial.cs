using Salão_Model.Common;
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
            ControllerSystem controller = ControllerSystem.GetInstance();
            for (int i = 0; i < 10; i++)
            {
                controller.CreateService("Teste Servico " + i, 10);
            }

            for (int i = 0; i < 10; i++)
            {
                controller.RegisterEmployee("Teste Prestador " + i, "teste" + i + "@teste.com", "brasil", "21 999");
            }

            var services = controller.GetServices();
            var providers = controller.ReadListProvider();
            for (int i = 0; i < services.Count; i++)
            {
                Random rnd = new Random();
                var provider = providers[rnd.Next(providers.Count)];
                controller.AddLincensedService(provider, services[i]);
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClient addclient = new AddClient();
            addclient.ShowDialog();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaClient consultaClient = new ConsultaClient();
            consultaClient.ShowDialog();
        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agendamento agendamento = new Agendamento();
            agendamento.ShowDialog();
        }
    }
}
