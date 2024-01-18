namespace ServerManager
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.SaveServerButton = new System.Windows.Forms.Button();
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.ServerIpInput = new System.Windows.Forms.TextBox();
            this.ServerNameInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveServerButton
            // 
            this.SaveServerButton.Location = new System.Drawing.Point(12, 87);
            this.SaveServerButton.Name = "SaveServerButton";
            this.SaveServerButton.Size = new System.Drawing.Size(200, 23);
            this.SaveServerButton.TabIndex = 9;
            this.SaveServerButton.Text = "Сохранить";
            this.SaveServerButton.UseVisualStyleBackColor = true;
            this.SaveServerButton.Click += new System.EventHandler(this.SaveServerButton_Click);
            // 
            // UserNameInput
            // 
            this.UserNameInput.Location = new System.Drawing.Point(12, 61);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(199, 20);
            this.UserNameInput.TabIndex = 8;
            // 
            // ServerIpInput
            // 
            this.ServerIpInput.Location = new System.Drawing.Point(12, 35);
            this.ServerIpInput.Name = "ServerIpInput";
            this.ServerIpInput.Size = new System.Drawing.Size(199, 20);
            this.ServerIpInput.TabIndex = 7;
            // 
            // ServerNameInput
            // 
            this.ServerNameInput.Location = new System.Drawing.Point(13, 9);
            this.ServerNameInput.Name = "ServerNameInput";
            this.ServerNameInput.Size = new System.Drawing.Size(199, 20);
            this.ServerNameInput.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 115);
            this.Controls.Add(this.SaveServerButton);
            this.Controls.Add(this.UserNameInput);
            this.Controls.Add(this.ServerIpInput);
            this.Controls.Add(this.ServerNameInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(240, 154);
            this.MinimumSize = new System.Drawing.Size(240, 154);
            this.Name = "Form2";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveServerButton;
        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.TextBox ServerIpInput;
        private System.Windows.Forms.TextBox ServerNameInput;
    }
}