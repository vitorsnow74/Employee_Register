
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
            this.createContractButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.radioButtonPosition = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // createContractButton
            // 
            this.createContractButton.Location = new System.Drawing.Point(618, 218);
            this.createContractButton.Name = "createContractButton";
            this.createContractButton.Size = new System.Drawing.Size(147, 23);
            this.createContractButton.TabIndex = 0;
            this.createContractButton.Text = "Create Contract";
            this.createContractButton.UseVisualStyleBackColor = true;
            this.createContractButton.Click += new System.EventHandler(this.createContractButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(42, 218);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // radioButtonPosition
            // 
            this.radioButtonPosition.AutoSize = true;
            this.radioButtonPosition.Location = new System.Drawing.Point(248, 386);
            this.radioButtonPosition.Name = "radioButtonPosition";
            this.radioButtonPosition.Size = new System.Drawing.Size(31, 17);
            this.radioButtonPosition.TabIndex = 2;
            this.radioButtonPosition.TabStop = true;
            this.radioButtonPosition.Text = "1";
            this.radioButtonPosition.UseVisualStyleBackColor = true;
            // 
            // AddContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonPosition);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.createContractButton);
            this.Name = "AddContract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createContractButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.RadioButton radioButtonPosition;
    }
}