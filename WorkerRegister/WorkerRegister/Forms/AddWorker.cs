using System;
using System.Windows.Forms;
using WorkerRegister.Entities;
using WorkerRegister.Entities.Enum;
using WorkerRegister.Forms;

namespace WorkerRegister.Forms
{
    public partial class AddWorker : Form
    {
        public AddWorker()
        {
            InitializeComponent();
        }

        public string LevelStatus { get; set; }
        public string WorkerDepartment = AddDepartment.DText;

        private void workerDepartmentLabel_Click(object sender, System.EventArgs e)
        {                        
            workerDepartmentLabel.Text = AddDepartment.DText;
        }

        private void juniorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (juniorRadioButton.Checked)
            {
                LevelStatus = "Junior";
            }
        }

        private void midLevelRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            if (midLevelRadioButton.Checked)
            {
                LevelStatus = "MidLevel";
            }
        }

        private void seniorRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            if (seniorRadioButton.Checked)
            {
                LevelStatus = "Senior";
            }
        }

        private void createContractsButton_Click(object sender, System.EventArgs e)
        {                   
            AddContract addContract = new AddContract();
            addContract.Show();                                
        }

        private void removeContractsButton_Click(object sender, System.EventArgs e)
        {

        }

        private void discardChangesButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            Department department = new Department(WorkerDepartment);

            string workerName = nameTextBox.Text;

            WorkerLevel workerLevel;
            if (String.IsNullOrEmpty(LevelStatus))
            {
                MessageBox.Show("The worker level must be informated!\nIt is going to be Junior by default.");
                workerLevel = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), "Junior");
                this.Close();
            }
            else
            {
                workerLevel = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), LevelStatus);
            }

            double baseSalary = double.Parse(baseSalaryTextBox.Text);

            HourContract contract = new HourContract();

            Worker worker = new Worker();

            MessageBox.Show("Worker created sucessefully!");
            this.Close();
        }


    }
}
