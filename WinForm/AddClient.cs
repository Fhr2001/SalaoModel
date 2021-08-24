using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Salão_Model.Common;

namespace Salão_Model.WinForm
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddClient_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            ControllerSystem controller = ControllerSystem.GetInstance();

            var client = controller.RegisterClient(tb_nome.Text, tb_email.Text, tb_senha.Text, cb_genero.Text, tb_senha.Text, tb_endereco.Text);
            if (client != null)
                MessageBox.Show("Sucesso!");
        }

        private void tb_endereco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
