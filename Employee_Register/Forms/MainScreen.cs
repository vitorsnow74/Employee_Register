using System;
using System.Windows.Forms;
using Employee_Register;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Employee_Register.Forms
{
    public partial class MainScreen : MaterialForm
    {
        public MainScreen()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public static DataController dataController { get; set; } = new DataController();

        private void generateWorkerButton_Click(object sender, EventArgs e)
        {
            CreateDepartment createDepartment = new CreateDepartment();
            createDepartment.Show();
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