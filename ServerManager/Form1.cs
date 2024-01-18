using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ServerManager
{
    public partial class Form1 : Form
    {
        public string CurrentPath = Path.Combine(System.Environment.GetFolderPath (System.Environment.SpecialFolder.MyDocuments),"ServerManager");
        public string CurrentConfig;
        public static SettingsFile SettingsFile = new SettingsFile() { settings = new List<Settings>()};
        public Form1()
        {
            InitializeComponent();
            ServerList.DisplayMember = "ServerName";
            ServerList.ValueMember = "data";
            ServerList.MouseDoubleClick += ConnectToServer;
            CurrentConfig = Path.Combine(CurrentPath, "config.json");

            ServerNameInput.Tag = "Название...";
            ServerIpInput.Tag = "IP сервера...";
            UserNameInput.Tag = "Логин...";

            ServerNameInput.Text = "Название...";
            ServerIpInput.Text = "IP сервера...";
            UserNameInput.Text = "Логин...";

            ServerNameInput.GotFocus += RemoveText;
            ServerIpInput.GotFocus += RemoveText;
            UserNameInput.GotFocus += RemoveText;

            ServerNameInput.LostFocus += AddText;
            ServerIpInput.LostFocus += AddText;
            UserNameInput.LostFocus += AddText;

            void RemoveText(object sender, EventArgs e)
            {
                if ((sender as System.Windows.Forms.TextBox).Text == (sender as System.Windows.Forms.TextBox).Tag as string)
                {
                    (sender as System.Windows.Forms.TextBox).Text = "";
                }
            }
            void AddText(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace((sender as System.Windows.Forms.TextBox).Text))
                    (sender as System.Windows.Forms.TextBox).Text = (sender as System.Windows.Forms.TextBox).Tag as string;
            }

            
        }

        private void UpdateSettings()
        {

            using (StreamWriter writer = new StreamWriter(CurrentConfig))
            {
                writer.Write(JsonConvert.SerializeObject(SettingsFile));
            }
        }

        private void CheckSettingsExist(bool update = false)
        {
            
            if (File.Exists(CurrentConfig))
            {
                if (update)
                {
                    UpdateSettings();
                }

                using (StreamReader reader = new StreamReader(CurrentConfig))
                {
                    SettingsFile = JsonConvert.DeserializeObject<SettingsFile>(reader.ReadToEnd());
                }
            }
            else
            {
                Directory.CreateDirectory(CurrentPath);
                File.Create(CurrentConfig).Close();
                UpdateSettings();
            }
        }

        private void UpdateData()
        {
            if (!(SettingsFile.settings is null))
            {
                contextMenuStrip1.Items.Clear();
                ServerList.Items.Clear();
                foreach (Settings settings in SettingsFile.settings)
                {
                    var item = new ToolStripMenuItem() { Text = settings.ServerName };
                    item.Click += ConnectToServer;
                    item.Tag = settings;
                    contextMenuStrip1.Items.Add(item);
                    ServerList.Items.Add(settings);
                }
            }
        }

        private void ConnectToServer(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            string username = (menuItem.Tag as Settings).data.UserLogin;
            string serverIp = (menuItem.Tag as Settings).data.ServerIp;
            ProcessStartInfo processInfo;
            processInfo = new ProcessStartInfo("cmd.exe", "/k " + $"ssh.exe {username}@{serverIp}");
            processInfo.CreateNoWindow = false;
            Process.Start(processInfo);
        }

        public void ConnectToServer(object sender, MouseEventArgs e)
        {
            int index = this.ServerList.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)

            {
                string username = (ServerList.Items[index] as Settings).data.UserLogin;
                string serverIp = (ServerList.Items[index] as Settings).data.ServerIp;
                ProcessStartInfo processInfo;
                processInfo = new ProcessStartInfo("cmd.exe", "/k " + $"ssh.exe {username}@{serverIp}");
                processInfo.CreateNoWindow = false;
                Process.Start(processInfo);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipText = "Спрятався в трее";
            notifyIcon1.BalloonTipTitle = "Server Manager";
            notifyIcon1.Text = "Server Manager";
            CheckSettingsExist();
            UpdateData();
            ActiveControl = ServerList;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(100);
            }
            else if(WindowState == FormWindowState.Normal)
            {
                notifyIcon1.Visible = false;
            }
            
        }

        private void AddServerButton_Click(object sender, EventArgs e)
        {
            if (ServerNameInput is null) { MessageBox.Show("Не введено имя сервера", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);return; };
            if(ServerIpInput is null) {MessageBox.Show("Не введено ip сервера","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); return; };
            if(UserNameInput is null) {MessageBox.Show("Не введено имя пользовтеля","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); return; };
            Settings data = new Settings()
            {
                ServerName = ServerNameInput.Text,
                data = new SettingsData()
                {
                    ServerIp = ServerIpInput.Text,
                    UserLogin = UserNameInput.Text
                }

            };
            SettingsFile.settings.Add(data);
            UpdateSettings();
            UpdateData();


        }

        private void EditServerButton_Click(object sender, EventArgs e)
        {
            Settings settings = SettingsFile.settings.Where(x => x.ServerName == (ServerList.SelectedItem as Settings).ServerName).First();
            using(Form2 form2 = new Form2(settings))
            {
                if(form2.ShowDialog() == DialogResult.OK)
                {
                    UpdateSettings();
                    UpdateData();
                }
            }
        }

        private void RemoveServerButton_Click(object sender, EventArgs e)
        {
            Settings settings = SettingsFile.settings.Where(x => x.ServerName == (ServerList.SelectedItem as Settings).ServerName).First();
            SettingsFile.settings.Remove(settings);
            UpdateSettings();
            UpdateData();
        }
    }

    public class SettingsFile
    {
        public List<Settings> settings { get; set; }
    }

    public class Settings
    {
        public string ServerName { get; set; }
        public SettingsData data { get; set; }

    }

    public class SettingsData
    {
        public string ServerIp { get; set; } = "";
        public string UserLogin { get; set; } = "";
    }
}
