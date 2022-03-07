using System;
using System.Windows.Forms;
using WorkerRegister.Forms;

namespace WorkerRegister
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void createWorkerButton_Click(object sender, EventArgs e)
        {
            AddDepartment addDepartment = new AddDepartment();
            addDepartment.Show();
        }

        private void calculateIncomeButton_Click(object sender, EventArgs e)
        {
           
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
