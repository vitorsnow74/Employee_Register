using System;
using System.Windows.Forms;
using System.Globalization;
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

        private string LevelStatus = "";

        private void workerDepartmentLabel_Click(object sender, System.EventArgs e)
        {                        
            workerDepartmentLabel.Text = MainScreen.dataController.Department;
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
            if (!String.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                if (!String.IsNullOrWhiteSpace(baseSalaryTextBox.Text))
                {
                    MainScreen.dataController.Name = nameTextBox.Text;

                    if (String.IsNullOrEmpty(LevelStatus))
                    {
                        MessageBox.Show("The worker level must be informated!\nAnd if it doesn't, it will be \"Junior\" by default.");
                        MainScreen.dataController.CreateLevel("Junior");
                        this.Close();
                    }
                    else
                    {
                        MainScreen.dataController.CreateLevel(LevelStatus);
                    }

                    MainScreen.dataController.BaseSalary = double.Parse(baseSalaryTextBox.Text, CultureInfo.InvariantCulture);

                    MessageBox.Show("Worker created sucessefully!");
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("The base Salary cannot be Empty!");
                }
            }
            else {
                MessageBox.Show("The name box cannot be Empty!");
            }
            MainScreen.dataController.Created = true;            
        }


    }
}
