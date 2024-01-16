using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_green_system
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public Form1()
        {
            InitializeComponent();
            Instance = this;
        }

        private void old_client_Click(object sender, EventArgs e)
        {
            old_client_form client_old = new old_client_form();
            client_old.Show();
        }

        private void new_client_Click(object sender, EventArgs e)
        {
            new_client_form client_new = new new_client_form();
            client_new.Show();
        }

        private void client_Click(object sender, EventArgs e)
        {
            client_info info = new client_info();
            info.Show();
        }
    }
}
