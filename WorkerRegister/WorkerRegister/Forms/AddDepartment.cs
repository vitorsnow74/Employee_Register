using System.Windows.Forms;
using WorkerRegister.Forms;
using WorkerRegister.Entities;

namespace WorkerRegister.Forms
{
    public partial class AddDepartment : Form
    {
        public AddDepartment()
        {
            InitializeComponent();
        }

        public static string DText { get; set; }      

        private void createButton_Click(object sender, System.EventArgs e)
        {
            string text = departmentTextBox.Text;

            AddWorker addWorker = new AddWorker();

            if (!string.IsNullOrWhiteSpace(text))
            {
                if (text.Length >= 2)
                {                    
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

            DText = text;
        }

        private void backButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
