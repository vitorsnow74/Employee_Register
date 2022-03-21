using System;
using System.Windows.Forms;
using System.Globalization;
using Employee_Register.Entities.Enum;
using Employee_Register.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Employee_Register.Forms
{
    public partial class GenerateEmployee : MaterialForm
    {
        public GenerateEmployee()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void workerDepartmentLabel_Click(object sender, System.EventArgs e)
        {
            employeeDepartmentLabel.Text = MainScreen.dataController.Department.Name;
        }

        private string LevelStatus = "";

        private void juniorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LevelStatus = "Junior";
        }

        private void midLevelRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            LevelStatus = "MidLevel";
        }

        private void seniorRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            LevelStatus = "Senior";
        }

        private void createContractsButton_Click(object sender, System.EventArgs e)
        {
            AddContract addContract = new AddContract();
            addContract.Show();
        }

        private void removeContractsButton_Click(object sender, System.EventArgs e)
        {
            RemoveContract removeContract = new RemoveContract();
            removeContract.Show();
        }

        private void discardChangesButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MainScreen.dataController.GetEmployeeName(nameTextBox.Text);

                if (!String.IsNullOrWhiteSpace(baseSalaryTextBox.Text))
                {
                    MainScreen.dataController.GetEmployeeBaseSalary(double.Parse(baseSalaryTextBox.Text, CultureInfo.InvariantCulture));

                    if (!String.IsNullOrEmpty(LevelStatus))
                    {
                        MainScreen.dataController.GetEmployeeLevel((EmployeeLevel)Enum.Parse(typeof(EmployeeLevel), LevelStatus));
                    }
                    else
                    {
                        MessageBox.Show("The employee level must be informated!\nBut do not worry, it will be \"Junior\" by default.");
                        MainScreen.dataController.GetEmployeeLevel((EmployeeLevel)Enum.Parse(typeof(EmployeeLevel), "Junior"));
                        this.Close();
                    }

                    MainScreen.dataController.CreateEmployee();
                    MessageBox.Show("Employee created sucessefully!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The base Salary cannot be Empty!");
                }
            }
            else
            {
                MessageBox.Show("The name box cannot be Empty!");
            }
        }
    }
}
