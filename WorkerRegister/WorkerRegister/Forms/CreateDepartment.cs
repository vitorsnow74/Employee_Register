using System.Windows.Forms;
using WorkerRegister;
using WorkerRegister.Forms;
using WorkerRegister.Entities;
using MaterialSkin;
using MaterialSkin.Controls;

namespace WorkerRegister.Forms
{
    public partial class CreateDepartment : MaterialForm
    {
        public CreateDepartment()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
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
