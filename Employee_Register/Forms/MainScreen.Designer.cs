 namespace Employee_Register.Forms
{
    partial class MainScreen
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
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateIncomeButton = new System.Windows.Forms.Button();
            this.generateEmployeeButton = new System.Windows.Forms.Button();
            this.mainTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(215, 252);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(365, 48);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateIncomeButton
            // 
            this.calculateIncomeButton.Location = new System.Drawing.Point(215, 198);
            this.calculateIncomeButton.Name = "calculateIncomeButton";
            this.calculateIncomeButton.Size = new System.Drawing.Size(365, 48);
            this.calculateIncomeButton.TabIndex = 10;
            this.calculateIncomeButton.Text = "Calculate Income";
            this.calculateIncomeButton.UseVisualStyleBackColor = true;
            this.calculateIncomeButton.Click += new System.EventHandler(this.calculateIncomeButton_Click);
            // 
            // generateEmployeeButton
            // 
            this.generateEmployeeButton.Location = new System.Drawing.Point(215, 144);
            this.generateEmployeeButton.Name = "generateEmployeeButton";
            this.generateEmployeeButton.Size = new System.Drawing.Size(365, 48);
            this.generateEmployeeButton.TabIndex = 9;
            this.generateEmployeeButton.Text = "Generate Employee";
            this.generateEmployeeButton.UseVisualStyleBackColor = true;
            this.generateEmployeeButton.Click += new System.EventHandler(this.generateWorkerButton_Click);
            // 
            // mainTextLabel
            // 
            this.mainTextLabel.AutoSize = true;
            this.mainTextLabel.Location = new System.Drawing.Point(337, 107);
            this.mainTextLabel.Name = "mainTextLabel";
            this.mainTextLabel.Size = new System.Drawing.Size(113, 13);
            this.mainTextLabel.TabIndex = 8;
            this.mainTextLabel.Text = "Select what you need:";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateIncomeButton);
            this.Controls.Add(this.generateEmployeeButton);
            this.Controls.Add(this.mainTextLabel);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Register 2016";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateIncomeButton;
        private System.Windows.Forms.Button generateEmployeeButton;
        private System.Windows.Forms.Label mainTextLabel;
    }
}

