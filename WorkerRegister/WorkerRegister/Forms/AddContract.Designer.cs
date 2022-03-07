
namespace WorkerRegister.Forms
{
    partial class AddContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContract));
            this.createContractButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.contractCountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.valuePerHourTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createContractButton
            // 
            this.createContractButton.Location = new System.Drawing.Point(456, 253);
            this.createContractButton.Name = "createContractButton";
            this.createContractButton.Size = new System.Drawing.Size(147, 23);
            this.createContractButton.TabIndex = 0;
            this.createContractButton.Text = "Create Contract";
            this.createContractButton.UseVisualStyleBackColor = true;
            this.createContractButton.Click += new System.EventHandler(this.createContractButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(84, 253);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(147, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // contractCountLabel
            // 
            this.contractCountLabel.AutoSize = true;
            this.contractCountLabel.Location = new System.Drawing.Point(300, 46);
            this.contractCountLabel.Name = "contractCountLabel";
            this.contractCountLabel.Size = new System.Drawing.Size(63, 13);
            this.contractCountLabel.TabIndex = 2;
            this.contractCountLabel.Text = "Contract #1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Value per Hour:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Duration:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(255, 97);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 6;
            // 
            // valuePerHourTextBox
            // 
            this.valuePerHourTextBox.Location = new System.Drawing.Point(255, 136);
            this.valuePerHourTextBox.Name = "valuePerHourTextBox";
            this.valuePerHourTextBox.Size = new System.Drawing.Size(200, 20);
            this.valuePerHourTextBox.TabIndex = 7;
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(255, 173);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(200, 20);
            this.durationTextBox.TabIndex = 8;
            // 
            // AddContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 357);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.valuePerHourTextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contractCountLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.createContractButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding contracts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createContractButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label contractCountLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox valuePerHourTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
    }
}