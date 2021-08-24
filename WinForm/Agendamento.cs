using Salão_Model.Common;
using Salão_Model.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Salão_Model.WinForm
{
    public partial class Agendamento : Form
    {
        private Service[] Services = new Service[300];
        private Client[] Clients = new Client[300];
        private Provider[] Providers = new Provider[300];
        public Agendamento()
        {
            InitializeComponent();
        }

        private void Agendamento_Load(object sender, EventArgs e)
        {
            PopularCmbServices();
            PopularCmbClients();
        }

        private void PopularCmbServices()
        {
            ControllerSystem controller = ControllerSystem.GetInstance();

            var services = controller.GetServices();
            int i = 0;
            cmBoxService.Items.Clear();

            foreach (var service in services)
            {
                Services[i++] = service;            
                cmBoxService.Items.Add(service.Name);
            }
        }

        private void PopularCmbClients()
        {
            ControllerSystem controller = ControllerSystem.GetInstance();

            var clients = controller.ReadListClient();
            int i = 0;
            CmbClient.Items.Clear();

            foreach (var client in clients)
            {
                Clients[i++] = client;
                CmbClient.Items.Add(client.Name);
            }
        }

        private void cmBoxService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmBoxService.SelectedIndex == -1)
            {
                return;
            }
            cmBoxProvider.Items.Clear();
            cmBoxProvider.Text = String.Empty;
            ControllerSystem controller = ControllerSystem.GetInstance();
            int i = 0;

            var providers = controller.ReadListProvider(Services[cmBoxService.SelectedIndex]);

            foreach (var provider in providers)
            {
                Providers[i++] = provider;
                cmBoxProvider.Items.Add(provider.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControllerSystem controller = ControllerSystem.GetInstance();

            var agenda = controller.CreateAgenda(Services[cmBoxService.SelectedIndex], dTPicker.Value, Providers[cmBoxProvider.SelectedIndex]);

            if (agenda == null)
                MessageBox.Show("Falhou :(");
            else
                MessageBox.Show("Sucesso!");
        }

        private void CmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbClient.SelectedIndex == -1)
            {
                return;
            }

            ControllerSystem controller = ControllerSystem.GetInstance();

            controller.ReadClient(Clients[CmbClient.SelectedIndex].Email, Clients[CmbClient.SelectedIndex].Password);
        }
    }
}
