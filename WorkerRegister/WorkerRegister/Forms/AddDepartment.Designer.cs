
namespace WorkerRegister.Forms
{
    partial class AddDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDepartment));
            this.backButton = new System.Windows.Forms.Button();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.insertDepartmentLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(47, 155);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Location = new System.Drawing.Point(57, 88);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(181, 20);
            this.departmentTextBox.TabIndex = 9;
            // 
            // insertDepartmentLabel
            // 
            this.insertDepartmentLabel.AutoSize = true;
            this.insertDepartmentLabel.Location = new System.Drawing.Point(74, 62);
            this.insertDepartmentLabel.Name = "insertDepartmentLabel";
            this.insertDepartmentLabel.Size = new System.Drawing.Size(145, 13);
            this.insertDepartmentLabel.TabIndex = 8;
            this.insertDepartmentLabel.Text = "Enter the department\'s name:";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(173, 155);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 7;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 217);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(this.insertDepartmentLabel);
            this.Controls.Add(this.createButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create department";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.Label insertDepartmentLabel;
        private System.Windows.Forms.Button createButton;
    }
}