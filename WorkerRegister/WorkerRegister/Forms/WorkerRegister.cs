using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkerRegister.Forms;
using WorkerRegister.Entities;

namespace WorkerRegister
{
    public partial class WorkerRegister : Form
    {
        public WorkerRegister()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterScreen register = new RegisterScreen();
            register.Show();
        }
    }
}
