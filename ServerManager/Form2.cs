using System;
using System.Windows.Forms;

namespace ServerManager
{
    public partial class Form2 : Form
    {
        public Settings settings {  get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Settings settings)
        {
            InitializeComponent();
            this.settings = settings;
            ServerNameInput.Text = settings.ServerName;
            ServerIpInput.Text = settings.data.ServerIp;
            UserNameInput.Text = settings.data.UserLogin;
        }

        private void SaveServerButton_Click(object sender, EventArgs e)
        {
            settings.ServerName = ServerNameInput.Text;
            settings.data.ServerIp = ServerIpInput.Text;
            settings.data.UserLogin = UserNameInput.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
