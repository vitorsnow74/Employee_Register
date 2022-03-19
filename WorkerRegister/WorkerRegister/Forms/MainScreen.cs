using System;
using System.Windows.Forms;
using WorkerRegister.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace WorkerRegister
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
        
        private void createWorkerButton_Click(object sender, EventArgs e)
        {
                CreateDepartment addDepartment = new CreateDepartment();
                addDepartment.Show();
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
