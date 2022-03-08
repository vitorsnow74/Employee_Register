using System.Windows.Forms;
using WorkerRegister;
using WorkerRegister.Forms;
using WorkerRegister.Entities;

namespace WorkerRegister.Forms
{
    public partial class CreateDepartment : Form
    {
        public CreateDepartment()
        {
            InitializeComponent();
        }              

        private void createButton_Click(object sender, System.EventArgs e)
        {
            string text = departmentTextBox.Text;

            CreateWorker addWorker = new CreateWorker();

            if (!string.IsNullOrWhiteSpace(text))
            {
                if (text.Length >= 2)
                {
                    MainScreen.dataController.GetWorkerDepartment(text);
                    addWorker.Show();                                                         
                }
                else
                {
                    MessageBox.Show("Invalid Department!");
                }
            }
            else 
            {
                MessageBox.Show("You must type the Department's name!");
            }
            
            this.Close();
        }

        private void backButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }        
    }
}
