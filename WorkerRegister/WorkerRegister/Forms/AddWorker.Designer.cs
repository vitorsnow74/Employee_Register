
namespace WorkerRegister.Forms
{
    partial class AddWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWorker));
            this.insertDataLabel = new System.Windows.Forms.Label();
            this.discardChangesButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.levelRegisterLabel = new System.Windows.Forms.Label();
            this.removeContractsButton = new System.Windows.Forms.Button();
            this.createContractsButton = new System.Windows.Forms.Button();
            this.ContractsLabel = new System.Windows.Forms.Label();
            this.baseSalaryTextBox = new System.Windows.Forms.TextBox();
            this.baseSalaryLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameRegisterLabel = new System.Windows.Forms.Label();
            this.currentDepartmentLabel = new System.Windows.Forms.Label();
            this.workerDepartmentLabel = new System.Windows.Forms.Label();
            this.juniorRadioButton = new System.Windows.Forms.RadioButton();
            this.midLevelRadioButton = new System.Windows.Forms.RadioButton();
            this.seniorRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // insertDataLabel
            // 
            this.insertDataLabel.AutoSize = true;
            this.insertDataLabel.Location = new System.Drawing.Point(222, 39);
            this.insertDataLabel.Name = "insertDataLabel";
            this.insertDataLabel.Size = new System.Drawing.Size(146, 13);
            this.insertDataLabel.TabIndex = 33;
            this.insertDataLabel.Text = "Insert the worker data bellow:";
            // 
            // discardChangesButton
            // 
            this.discardChangesButton.Location = new System.Drawing.Point(62, 294);
            this.discardChangesButton.Name = "discardChangesButton";
            this.discardChangesButton.Size = new System.Drawing.Size(103, 23);
            this.discardChangesButton.TabIndex = 32;
            this.discardChangesButton.Text = "Discard Changes";
            this.discardChangesButton.UseVisualStyleBackColor = true;
            this.discardChangesButton.Click += new System.EventHandler(this.discardChangesButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(487, 294);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 31;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // levelRegisterLabel
            // 
            this.levelRegisterLabel.AutoSize = true;
            this.levelRegisterLabel.Location = new System.Drawing.Point(59, 180);
            this.levelRegisterLabel.Name = "levelRegisterLabel";
            this.levelRegisterLabel.Size = new System.Drawing.Size(74, 13);
            this.levelRegisterLabel.TabIndex = 30;
            this.levelRegisterLabel.Text = "Worker Level:";
            // 
            // removeContractsButton
            // 
            this.removeContractsButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.removeContractsButton.Location = new System.Drawing.Point(291, 209);
            this.removeContractsButton.Name = "removeContractsButton";
            this.removeContractsButton.Size = new System.Drawing.Size(109, 23);
            this.removeContractsButton.TabIndex = 26;
            this.removeContractsButton.Text = "Remove Contracts";
            this.removeContractsButton.UseVisualStyleBackColor = false;
            this.removeContractsButton.Click += new System.EventHandler(this.removeContractsButton_Click);
            // 
            // createContractsButton
            // 
            this.createContractsButton.Location = new System.Drawing.Point(182, 209);
            this.createContractsButton.Name = "createContractsButton";
            this.createContractsButton.Size = new System.Drawing.Size(103, 23);
            this.createContractsButton.TabIndex = 25;
            this.createContractsButton.Text = "Create Contracts";
            this.createContractsButton.UseVisualStyleBackColor = true;
            this.createContractsButton.Click += new System.EventHandler(this.createContractsButton_Click);
            // 
            // ContractsLabel
            // 
            this.ContractsLabel.AutoSize = true;
            this.ContractsLabel.Location = new System.Drawing.Point(59, 214);
            this.ContractsLabel.Name = "ContractsLabel";
            this.ContractsLabel.Size = new System.Drawing.Size(55, 13);
            this.ContractsLabel.TabIndex = 23;
            this.ContractsLabel.Text = "Contracts:";
            // 
            // baseSalaryTextBox
            // 
            this.baseSalaryTextBox.Location = new System.Drawing.Point(182, 141);
            this.baseSalaryTextBox.Name = "baseSalaryTextBox";
            this.baseSalaryTextBox.Size = new System.Drawing.Size(103, 20);
            this.baseSalaryTextBox.TabIndex = 22;
            // 
            // baseSalaryLabel
            // 
            this.baseSalaryLabel.AutoSize = true;
            this.baseSalaryLabel.Location = new System.Drawing.Point(59, 144);
            this.baseSalaryLabel.Name = "baseSalaryLabel";
            this.baseSalaryLabel.Size = new System.Drawing.Size(66, 13);
            this.baseSalaryLabel.TabIndex = 21;
            this.baseSalaryLabel.Text = "Base Salary:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(182, 113);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 20;
            // 
            // nameRegisterLabel
            // 
            this.nameRegisterLabel.AutoSize = true;
            this.nameRegisterLabel.Location = new System.Drawing.Point(59, 113);
            this.nameRegisterLabel.Name = "nameRegisterLabel";
            this.nameRegisterLabel.Size = new System.Drawing.Size(38, 13);
            this.nameRegisterLabel.TabIndex = 19;
            this.nameRegisterLabel.Text = "Name:";
            // 
            // currentDepartmentLabel
            // 
            this.currentDepartmentLabel.AutoSize = true;
            this.currentDepartmentLabel.Location = new System.Drawing.Point(59, 83);
            this.currentDepartmentLabel.Name = "currentDepartmentLabel";
            this.currentDepartmentLabel.Size = new System.Drawing.Size(102, 13);
            this.currentDepartmentLabel.TabIndex = 34;
            this.currentDepartmentLabel.Text = "Current Department:";
            // 
            // workerDepartmentLabel
            // 
            this.workerDepartmentLabel.AutoSize = true;
            this.workerDepartmentLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.workerDepartmentLabel.Location = new System.Drawing.Point(182, 83);
            this.workerDepartmentLabel.Name = "workerDepartmentLabel";
            this.workerDepartmentLabel.Size = new System.Drawing.Size(97, 13);
            this.workerDepartmentLabel.TabIndex = 35;
            this.workerDepartmentLabel.Text = "click here to reveal";
            this.workerDepartmentLabel.Click += new System.EventHandler(this.workerDepartmentLabel_Click);
            // 
            // juniorRadioButton
            // 
            this.juniorRadioButton.AutoSize = true;
            this.juniorRadioButton.Location = new System.Drawing.Point(182, 178);
            this.juniorRadioButton.Name = "juniorRadioButton";
            this.juniorRadioButton.Size = new System.Drawing.Size(53, 17);
            this.juniorRadioButton.TabIndex = 36;
            this.juniorRadioButton.TabStop = true;
            this.juniorRadioButton.Text = "Junior";
            this.juniorRadioButton.UseVisualStyleBackColor = true;
            this.juniorRadioButton.CheckedChanged += new System.EventHandler(this.juniorRadioButton_CheckedChanged);
            // 
            // midLevelRadioButton
            // 
            this.midLevelRadioButton.AutoSize = true;
            this.midLevelRadioButton.Location = new System.Drawing.Point(245, 178);
            this.midLevelRadioButton.Name = "midLevelRadioButton";
            this.midLevelRadioButton.Size = new System.Drawing.Size(68, 17);
            this.midLevelRadioButton.TabIndex = 37;
            this.midLevelRadioButton.TabStop = true;
            this.midLevelRadioButton.Text = "MidLevel";
            this.midLevelRadioButton.UseVisualStyleBackColor = true;
            this.midLevelRadioButton.CheckedChanged += new System.EventHandler(this.midLevelRadioButton_CheckedChanged);
            // 
            // seniorRadioButton
            // 
            this.seniorRadioButton.AutoSize = true;
            this.seniorRadioButton.Location = new System.Drawing.Point(319, 178);
            this.seniorRadioButton.Name = "seniorRadioButton";
            this.seniorRadioButton.Size = new System.Drawing.Size(55, 17);
            this.seniorRadioButton.TabIndex = 38;
            this.seniorRadioButton.TabStop = true;
            this.seniorRadioButton.Text = "Senior";
            this.seniorRadioButton.UseVisualStyleBackColor = true;
            this.seniorRadioButton.CheckedChanged += new System.EventHandler(this.seniorRadioButton_CheckedChanged);
            // 
            // AddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 351);
            this.Controls.Add(this.seniorRadioButton);
            this.Controls.Add(this.midLevelRadioButton);
            this.Controls.Add(this.juniorRadioButton);
            this.Controls.Add(this.workerDepartmentLabel);
            this.Controls.Add(this.currentDepartmentLabel);
            this.Controls.Add(this.insertDataLabel);
            this.Controls.Add(this.discardChangesButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.levelRegisterLabel);
            this.Controls.Add(this.removeContractsButton);
            this.Controls.Add(this.createContractsButton);
            this.Controls.Add(this.ContractsLabel);
            this.Controls.Add(this.baseSalaryTextBox);
            this.Controls.Add(this.baseSalaryLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameRegisterLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creating Worker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label insertDataLabel;
        private System.Windows.Forms.Button discardChangesButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label levelRegisterLabel;
        private System.Windows.Forms.Button removeContractsButton;
        private System.Windows.Forms.Button createContractsButton;
        private System.Windows.Forms.Label ContractsLabel;
        private System.Windows.Forms.TextBox baseSalaryTextBox;
        private System.Windows.Forms.Label baseSalaryLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameRegisterLabel;
        private System.Windows.Forms.Label currentDepartmentLabel;
        private System.Windows.Forms.Label workerDepartmentLabel;
        private System.Windows.Forms.RadioButton juniorRadioButton;
        private System.Windows.Forms.RadioButton midLevelRadioButton;
        private System.Windows.Forms.RadioButton seniorRadioButton;
    }
}