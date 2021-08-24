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
    public partial class ConsultaClient : Form
    {
        private Client[] clients = new Client[500];
        public ConsultaClient()
        {
            InitializeComponent();
        }

        private void ConsultaClient_Load(object sender, EventArgs e)
        {
            PopulaListagem();
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            PreencheOsCampos();
        }

        private void PopulaListagem()
        {
            ControllerSystem controller = ControllerSystem.GetInstance();

            var clts = controller.ReadListClient();
            int i = 0;
            listView1.Items.Clear();

            foreach (var c in clts)
            {
                clients[i++] = c;
                var item = new ListViewItem(c.Name);
                listView1.Items.Add(item);
            }
        }

        private void PreencheOsCampos()
        {
            if (listView1.SelectedIndices.Count == 0)
            {
                return;
            }

            ControllerSystem controller = ControllerSystem.GetInstance();

            var client = controller.ReadClient(clients[listView1.SelectedIndices[0]].Email, clients[listView1.SelectedIndices[0]].Password);

            txtBoxName.Text = client.Name;
            txtBoxEmail.Text = client.Email;
            txtBoxPassword.Text = client.Password;
            txtBoxPhone.Text = client.Phone;
            txtBoxAddress.Text = client.Address;
            cb_genero.Text = client.Gender;
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0)
            {
                return;
            }

            ControllerSystem controller = ControllerSystem.GetInstance();

            controller.ReadClient(clients[listView1.SelectedIndices[0]].Email, clients[listView1.SelectedIndices[0]].Password);
            var client = controller.UpdateClient(txtBoxName.Text, txtBoxEmail.Text, txtBoxPassword.Text, cb_genero.SelectedItem.ToString(), txtBoxPhone.Text, txtBoxAddress.Text);
            if (client != null)
                MessageBox.Show("Sucesso!");
            PopulaListagem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0)
            {
                return;
            }

            ControllerSystem controller = ControllerSystem.GetInstance();

            controller.ReadClient(clients[listView1.SelectedIndices[0]].Email, clients[listView1.SelectedIndices[0]].Password);
            controller.DeleteClient();

            MessageBox.Show("Sucesso!");

            PopulaListagem();
        }
    }
}
