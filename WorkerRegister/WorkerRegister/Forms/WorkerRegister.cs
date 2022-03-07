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

        public static DataController dataController { get; set; } = new DataController();
        
        private void createWorkerButton_Click(object sender, EventArgs e)
        {
            if (!dataController.Created)
            {
                AddDepartment addDepartment = new AddDepartment();
                addDepartment.Show();
            }
            else 
            {
                MessageBox.Show("User already exists!");
            }
        }

        private void calculateIncomeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon!");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
