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
    public partial class ConsultaClient : Form
    {
        public ConsultaClient()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControllerSystem controller = ControllerSystem.GetInstance();
            controller.ReadListClient();
        }
    }
}
