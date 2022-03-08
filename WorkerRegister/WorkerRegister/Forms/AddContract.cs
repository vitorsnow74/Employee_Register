using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WorkerRegister.Forms;
using WorkerRegister.Entities;

namespace WorkerRegister.Forms
{
    public partial class AddContract : Form
    {
        public AddContract()
        {
            InitializeComponent();
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
