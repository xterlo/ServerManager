namespace ServerManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zabbixServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siteServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wsbotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServerNameInput = new System.Windows.Forms.TextBox();
            this.ServerIpInput = new System.Windows.Forms.TextBox();
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.ServerList = new System.Windows.Forms.ListBox();
            this.AddServerButton = new System.Windows.Forms.Button();
            this.RemoveServerButton = new System.Windows.Forms.Button();
            this.EditServerButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ServerManager";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zabbixServerToolStripMenuItem,
            this.siteServerToolStripMenuItem,
            this.wsbotToolStripMenuItem,
            this.test1ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 92);
            // 
            // zabbixServerToolStripMenuItem
            // 
            this.zabbixServerToolStripMenuItem.Name = "zabbixServerToolStripMenuItem";
            this.zabbixServerToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.zabbixServerToolStripMenuItem.Text = "Zabbix server";
            // 
            // siteServerToolStripMenuItem
            // 
            this.siteServerToolStripMenuItem.Name = "siteServerToolStripMenuItem";
            this.siteServerToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.siteServerToolStripMenuItem.Text = "site server";
            // 
            // wsbotToolStripMenuItem
            // 
            this.wsbotToolStripMenuItem.Name = "wsbotToolStripMenuItem";
            this.wsbotToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.wsbotToolStripMenuItem.Text = "ws_bot";
            // 
            // test1ToolStripMenuItem
            // 
            this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            this.test1ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.test1ToolStripMenuItem.Text = "test1";
            // 
            // ServerNameInput
            // 
            this.ServerNameInput.Location = new System.Drawing.Point(13, 13);
            this.ServerNameInput.Name = "ServerNameInput";
            this.ServerNameInput.Size = new System.Drawing.Size(100, 20);
            this.ServerNameInput.TabIndex = 1;
            // 
            // ServerIpInput
            // 
            this.ServerIpInput.Location = new System.Drawing.Point(12, 39);
            this.ServerIpInput.Name = "ServerIpInput";
            this.ServerIpInput.Size = new System.Drawing.Size(100, 20);
            this.ServerIpInput.TabIndex = 2;
            // 
            // UserNameInput
            // 
            this.UserNameInput.Location = new System.Drawing.Point(12, 65);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(100, 20);
            this.UserNameInput.TabIndex = 3;
            // 
            // ServerList
            // 
            this.ServerList.FormattingEnabled = true;
            this.ServerList.Location = new System.Drawing.Point(119, 12);
            this.ServerList.Name = "ServerList";
            this.ServerList.Size = new System.Drawing.Size(224, 199);
            this.ServerList.TabIndex = 4;
            // 
            // AddServerButton
            // 
            this.AddServerButton.Location = new System.Drawing.Point(12, 91);
            this.AddServerButton.Name = "AddServerButton";
            this.AddServerButton.Size = new System.Drawing.Size(101, 23);
            this.AddServerButton.TabIndex = 5;
            this.AddServerButton.Text = "Добавить";
            this.AddServerButton.UseVisualStyleBackColor = true;
            this.AddServerButton.Click += new System.EventHandler(this.AddServerButton_Click);
            // 
            // RemoveServerButton
            // 
            this.RemoveServerButton.Location = new System.Drawing.Point(238, 218);
            this.RemoveServerButton.Name = "RemoveServerButton";
            this.RemoveServerButton.Size = new System.Drawing.Size(105, 23);
            this.RemoveServerButton.TabIndex = 6;
            this.RemoveServerButton.Text = "Удалить";
            this.RemoveServerButton.UseVisualStyleBackColor = true;
            this.RemoveServerButton.Click += new System.EventHandler(this.RemoveServerButton_Click);
            // 
            // EditServerButton
            // 
            this.EditServerButton.Location = new System.Drawing.Point(119, 217);
            this.EditServerButton.Name = "EditServerButton";
            this.EditServerButton.Size = new System.Drawing.Size(113, 23);
            this.EditServerButton.TabIndex = 7;
            this.EditServerButton.Text = "Редактировать";
            this.EditServerButton.UseVisualStyleBackColor = true;
            this.EditServerButton.Click += new System.EventHandler(this.EditServerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 255);
            this.Controls.Add(this.EditServerButton);
            this.Controls.Add(this.RemoveServerButton);
            this.Controls.Add(this.AddServerButton);
            this.Controls.Add(this.ServerList);
            this.Controls.Add(this.UserNameInput);
            this.Controls.Add(this.ServerIpInput);
            this.Controls.Add(this.ServerNameInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(365, 294);
            this.MinimumSize = new System.Drawing.Size(365, 294);
            this.Name = "Form1";
            this.Text = "Server Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zabbixServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siteServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wsbotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem;
        private System.Windows.Forms.TextBox ServerNameInput;
        private System.Windows.Forms.TextBox ServerIpInput;
        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.ListBox ServerList;
        private System.Windows.Forms.Button AddServerButton;
        private System.Windows.Forms.Button RemoveServerButton;
        private System.Windows.Forms.Button EditServerButton;
    }
}

