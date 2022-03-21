using System;
using System.Collections.Generic;
using Employee_Register.Entities;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Employee_Register.Forms
{
    public partial class AddContract : MaterialForm
    {
        public AddContract()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public int ContractCount = 2;
        List<HourContract> Contracts = new List<HourContract>();

        private void createContractButton_Click(object sender, EventArgs e)
        {
            contractCountLabel.Text = $"Contract #{ContractCount}";
            ContractCount += 1;

            DateTime date = dateTimePicker.Value.Date;
            double valuePerHour = double.Parse(valuePerHourTextBox.Text);
            int hours = int.Parse(durationTextBox.Text);

            HourContract contract = new HourContract(date, valuePerHour, hours);
            Contracts.Add(contract);

            ClearInformation();
        }

        private void ClearInformation()
        {
            dateTimePicker.Value = DateTime.Now;
            valuePerHourTextBox.Text = "";
            durationTextBox.Text = "";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
