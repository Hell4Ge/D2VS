using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace D2VS
{
    public partial class GateEditor : Form
    {

        Gateway.Gateways gList = new Gateway.Gateways();
        public GateEditor()
        {
            InitializeComponent();
        }

        private void BTN_ADD_REALM_Click(object sender, EventArgs e)
        {
            AddGate(TB_SName.Text, TB_IP.Text);
            TB_SName.Text = TB_IP.Text = "";
        }

        private void GateEditor_Load(object sender, EventArgs e)
        {
            foreach (var gate in gList.Gates)
            {
                this.LB_Realms.Items.Add(gate.name);
                this.ListBox_IP.Items.Add(gate.ip);
            }

            // Private section for D2Realm server
            #region D2Trade
            using (var client = new System.Net.WebClient())
            {
                client.Proxy = null;
                String current_IP = client.DownloadString(new Uri("http://bg2.cba.pl/realmIP.txt"));
                if (gList.IndexOfGate("D2Trade realm", current_IP) == -1)
                {
                    TB_IP.Text = current_IP;
                    TB_SName.Text = "D2Trade realm";
                }
            }
            #endregion

        }

        private void AddGate(String name, String ip)
        {
            this.gList.Add(new Gateway.Gate(name, ip, "0"));
            this.gList.Apply();
            this.updateUIGates();
        }

        private void updateUIGates()
        {
            this.LB_Realms.Items.Clear();
            this.ListBox_IP.Items.Clear();

            foreach (var gate in gList.Gates)
            {
                this.LB_Realms.Items.Add(gate.name);
                this.ListBox_IP.Items.Add(gate.ip);
            }
        }

        private void BTN_Remove_Click(object sender, EventArgs e)
        {
            int index = LB_Realms.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Click on realm name", "Realm selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String name = LB_Realms.Items[index].ToString();
            String ip = ListBox_IP.Items[index].ToString();

            bool removed = gList.gateRemove(name, ip, true);

            if (removed)
                MessageBox.Show("Gate " + name + " sucessfully removed");
            else
                MessageBox.Show("Gate " + name + " does not exist or could not be removed", "Gate removing error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.updateUIGates();
        }

        private void BTN_RemoveAll_Click(object sender, EventArgs e)
        {
            String name = "";
            String ip = "";
            int removedGates = 0;
            int allGates = LB_Realms.Items.Count;
            for (int index=0; index < LB_Realms.Items.Count; index++)
            {
                name = LB_Realms.Items[index].ToString();
                ip = ListBox_IP.Items[index].ToString();

                if (gList.gateRemove(name, ip, true))
                    removedGates++;

            }

            if (removedGates==allGates)
                MessageBox.Show("Gates sucessfully removed");
            else
                MessageBox.Show("Gates were not removed, or not every of them. Click \"restore default gates\" if you want to fix it", "Gate removing error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.updateUIGates();
        }

        private void BTN_RestoreDefaults_Click(object sender, EventArgs e)
        {
            gList = new Gateway.Gateways(); // breaking hash values for Gate elements!!!

            gList.Add(new Gateway.Gate("U.S. West", "uswest.battle.net", "8"));
            gList.Add(new Gateway.Gate("U.S. East", "useast.battle.net","6"));
            gList.Add(new Gateway.Gate("Asia", "asia.battle.net", "-9"));
            gList.Add(new Gateway.Gate("Europe", "europe.battle.net", "-1"));
            gList.Apply();

            this.updateUIGates();
        }
    }
}
