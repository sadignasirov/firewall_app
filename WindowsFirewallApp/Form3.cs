using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFirewallApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            string command = "/c netsh firewall set opmode mode = enable";
            firewallManager(command);
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            string command = "/c netsh firewall set opmode mode = disable";
            firewallManager(command);
        }

        private void allow_all_btn_Click(object sender, EventArgs e)
        {
            string command = "/c netsh advFirewall Firewall add rule name=\"Rule PING IPv4 by SadigN\" protocol=icmpv4:8,any dir=in action=allow";
            firewallManager(command);
        }

        private void block_All_btn_Click(object sender, EventArgs e)
        {
            string command = "/c netsh advFirewall Firewall add rule name=\"Rule PING IPv4 by SadigN\" protocol=icmpv4:8,any dir=in action=block";
            firewallManager(command);
        }

        public void firewallManager(string command)
        {
            Process firewall = new Process();
            firewall.StartInfo.FileName = "cmd.exe";
            firewall.StartInfo.WorkingDirectory = @"\windows\system32\";
            firewall.StartInfo.Arguments = command;
            firewall.Start();
        }
    }
}
