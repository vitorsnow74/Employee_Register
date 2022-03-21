
namespace Employee_Register.Forms
{
    partial class CalculateIncome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthAndYearTextBox = new System.Windows.Forms.TextBox();
            this.monthAndYearLabel = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.searchAndCalculateButton = new System.Windows.Forms.Button();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monthAndYearTextBox
            // 
            this.monthAndYearTextBox.Location = new System.Drawing.Point(92, 134);
            this.monthAndYearTextBox.Name = "monthAndYearTextBox";
            this.monthAndYearTextBox.Size = new System.Drawing.Size(148, 20);
            this.monthAndYearTextBox.TabIndex = 19;
            // 
            // monthAndYearLabel
            // 
            this.monthAndYearLabel.AutoSize = true;
            this.monthAndYearLabel.Location = new System.Drawing.Point(123, 118);
            this.monthAndYearLabel.Name = "monthAndYearLabel";
            this.monthAndYearLabel.Size = new System.Drawing.Size(86, 13);
            this.monthAndYearLabel.TabIndex = 18;
            this.monthAndYearLabel.Text = "Month and Year:";
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(123, 74);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(85, 13);
            this.EmployeeNameLabel.TabIndex = 17;
            this.EmployeeNameLabel.Text = "Employee name:";
            // 
            // searchAndCalculateButton
            // 
            this.searchAndCalculateButton.Location = new System.Drawing.Point(98, 178);
            this.searchAndCalculateButton.Name = "searchAndCalculateButton";
            this.searchAndCalculateButton.Size = new System.Drawing.Size(142, 23);
            this.searchAndCalculateButton.TabIndex = 16;
            this.searchAndCalculateButton.Text = "Search and Calculate";
            this.searchAndCalculateButton.UseVisualStyleBackColor = true;
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(92, 90);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(148, 20);
            this.employeeNameTextBox.TabIndex = 15;
            // 
            // CalculateIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 226);
            this.Controls.Add(this.monthAndYearTextBox);
            this.Controls.Add(this.monthAndYearLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.searchAndCalculateButton);
            this.Controls.Add(this.employeeNameTextBox);
            this.Name = "CalculateIncome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculating Income";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox monthAndYearTextBox;
        private System.Windows.Forms.Label monthAndYearLabel;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Button searchAndCalculateButton;
        private System.Windows.Forms.TextBox employeeNameTextBox;
    }
}