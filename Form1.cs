using MetroFramework.Forms;
using Renci.SshNet;

namespace Aruba_802._1x_config
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Toekennen standaard aan
            apply_checkbox.Checked = true;

            // Status aangeven van sessie
            status_label.Text = "Niet bezig";

            // Timer starten om knoppen vrij te geven indien textboxen gevuld zijn
            apply_button_accept_timer.Start();

            // Variabelen toekennen
            string userName = Environment.UserName;
            string filepath = "C:/Users/"+userName+"/Documents/batch.txt";

            // Bestand aanmaken voor batch
            using (FileStream fs = File.Create(filepath))
            {
                // Deze haakjes zijn nodig... anders snapt visual studio het niet....
            }
        }

        private void reset_login_button_Click(object sender, EventArgs e) // Login gegevens leeg gooien
        {
            username_textbox.Text = "";
            password_textbox.Text = "";
        }

        private void reset_switchvalue_button_Click(object sender, EventArgs e) // Switch gegevens leeg gooien
        {
            switchip_textbox.Text = "";
            switchport_textbox.Text = "";
        }

        private void apply_checkbox_CheckedChanged(object sender, EventArgs e) // Verwijderen uitzetten wanneer toekennen is aangeklikt
        {
            if (apply_checkbox.Checked == true)
            {
                remove_checkbox.Checked = false;
            }
        }

        private void remove_checkbox_CheckedChanged(object sender, EventArgs e) // Toekennen uitzetten wanneer verwijderen is aangeklikt
        {
            if (remove_checkbox.Checked == true)
            {
                apply_checkbox.Checked = false;
            }
        }

        private void apply_button_Click(object sender, EventArgs e)
        {
            // Status aangeven van sessie
            status_label.Text = "Bezig...";

            if(apply_checkbox.Checked == true)
            {
                // Knoppen uitzetten om te voorkomen dat twee dingen door elkaar heen lopen
                apply_button.Enabled = false;
                apply_checkbox.Enabled = false;
                remove_checkbox.Enabled = false;
                reset_login_button.Enabled = false;
                reset_switchvalue_button.Enabled = false;

                // SSH sessie opbouwen, error teruggeven indien mislukt
                var ssh = new SshClient(switchip_textbox.Text, username_textbox.Text, password_textbox.Text);
                {
                    try
                    {
                        ssh.Connect();
                    }
                    catch (Exception ssh_fail)
                    {
                        MessageBox.Show("Er is een error opgetreden met de SSH sessie: \n " + ssh_fail.ToString(),"SSH error opgetreden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Interactieve sessie starten voor lees / schrijven
                var ssh_stream = ssh.CreateShellStream("putty", 80, 50, 1024, 1024, 1024);

                // Commando's:
                ssh_stream.WriteLine("conf t");
                Thread.Sleep(10);
                ssh_stream.WriteLine("aaa port-access authenticator " + switchport_textbox.Text);
                Thread.Sleep(10);
                ssh_stream.WriteLine("aaa port-access authenticator " + switchport_textbox.Text + " client-limit 8");
                Thread.Sleep(10);
                ssh_stream.WriteLine("aaa port-access authenticator " + switchport_textbox.Text + " logoff-period 604800");
                Thread.Sleep(10);
                ssh_stream.WriteLine("aaa port-access mac-based " + switchport_textbox.Text);
                Thread.Sleep(10);
                ssh_stream.WriteLine("aaa port-access mac-based " + switchport_textbox.Text + " addr-limit 8");
                Thread.Sleep(10);
                ssh_stream.WriteLine("aaa port-access mac-based " + switchport_textbox.Text + " logoff-period 604800");
                Thread.Sleep(10);
                ssh_stream.WriteLine("spanning-tree " + switchport_textbox.Text + " admin-edge-port");
                Thread.Sleep(10);
                ssh_stream.WriteLine("spanning-tree " + switchport_textbox.Text + " bpdu-protection");
                Thread.Sleep(10);
                ssh_stream.WriteLine("interface " + switchport_textbox.Text + " rate-limit mcast in percent 5");
                Thread.Sleep(10);
                ssh_stream.WriteLine("interface " + switchport_textbox.Text + " rate-limit bcast in percent 5");
                Thread.Sleep(10);
                ssh_stream.WriteLine("interface " + switchport_textbox.Text + " untagged vlan 1");
                Thread.Sleep(10);

                // Configuratie opslaan op switch
                ssh_stream.WriteLine("wr mem");
                Thread.Sleep(10);

                // Status laten zien aan de gebruiker
                MessageBox.Show("802.1x config is toegepast op poort: " + switchport_textbox.Text, "Aanpassing voltooid!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                status_label.Text = "Klaar";

                // Sessie afsluiten
                ssh.Disconnect();

                // Knoppen vrijgeven
                apply_button.Enabled = true;
                apply_checkbox.Enabled = true;
                remove_checkbox.Enabled = true;
                reset_login_button.Enabled = true;
                reset_switchvalue_button.Enabled = true;
            }
            if(remove_checkbox.Checked == true)
            {
                // Knoppen uitzetten om te voorkomen dat twee dingen door elkaar heen lopen
                apply_button.Enabled = false;
                apply_checkbox.Enabled = false;
                remove_checkbox.Enabled = false;
                reset_login_button.Enabled = false;
                reset_switchvalue_button.Enabled = false;

                // SSH sessie opbouwen, error teruggeven indien mislukt
                var ssh = new SshClient(switchip_textbox.Text, username_textbox.Text, password_textbox.Text);
                {
                    try
                    {
                        ssh.Connect();
                    }
                    catch (Exception ssh_fail)
                    {
                        MessageBox.Show("Er is een error opgetreden met de SSH sessie: \n " + ssh_fail.ToString(),"SSH error opgetreden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Interactieve sessie starten voor lees / schrijven
                var ssh_stream = ssh.CreateShellStream("ssh session", 80, 50, 1024, 1024, 1024);

                // Commando's:
                ssh_stream.WriteLine("conf t");
                Thread.Sleep(10);
                ssh_stream.WriteLine("no aaa port-access authenticator " + switchport_textbox.Text);
                Thread.Sleep(10);
                ssh_stream.WriteLine("no aaa port-access authenticator " + switchport_textbox.Text + " client-limit");
                Thread.Sleep(10);
                ssh_stream.WriteLine("aaa port-access authenticator " + switchport_textbox.Text + " logoff-period 300");
                Thread.Sleep(10);
                ssh_stream.WriteLine("no aaa port-access mac-based " + switchport_textbox.Text);
                Thread.Sleep(10);
                ssh_stream.WriteLine("aaa port-access mac-based " + switchport_textbox.Text + " addr-limit 1");
                Thread.Sleep(10);
                ssh_stream.WriteLine("aaa port-access mac-based " + switchport_textbox.Text + " logoff-period 300");
                Thread.Sleep(10);
                ssh_stream.WriteLine("no spanning-tree " + switchport_textbox.Text + " admin-edge-port");
                Thread.Sleep(10);
                ssh_stream.WriteLine("no spanning-tree " + switchport_textbox.Text + " bpdu-protection");
                Thread.Sleep(10);
                ssh_stream.WriteLine("no interface " + switchport_textbox.Text + " rate-limit mcast in");
                Thread.Sleep(10);
                ssh_stream.WriteLine("no interface " + switchport_textbox.Text + " rate-limit bcast in");
                Thread.Sleep(10);
                ssh_stream.WriteLine("interface " + switchport_textbox.Text + " untagged vlan 1");
                Thread.Sleep(10);

                // Configuratie opslaan op switch
                ssh_stream.WriteLine("wr mem");
                Thread.Sleep(10);

                // Sessie afsluiten
                ssh.Disconnect();

                // Knoppen weer toegankelijk maken voor gebruiker
                apply_button.Enabled = true;
                apply_checkbox.Enabled = true;
                remove_checkbox.Enabled = true;
                reset_login_button.Enabled = true;
                reset_switchvalue_button.Enabled = true;

                // Status laten zien aan de gebruiker
                MessageBox.Show("802.1x config is verwijderd op poort: " + switchport_textbox.Text, "Aanpassing voltooid!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                status_label.Text = "Klaar";
            }
        }

        private void apply_button_accept_timer_Tick(object sender, EventArgs e) // Timer om knoppen vrij te geven bij ingevulde velden
        {
            if (username_textbox.Text == "")
            {

            }
            if(password_textbox.Text == "")
            {

            }
            if(switchip_textbox.Text == "")
            {

            }
            else
            {
                batch_button.Enabled = true;
            }
            if(switchport_textbox.Text == "")
            {

            }
            else
            {
                apply_button.Enabled = true;
            }
        }

        private void batch_button_Click(object sender, EventArgs e)
        {
            // Variabelen toekennen.
            string userName = Environment.UserName;
            string filepath = "C:/Users/" + userName + "/Documents/batch.txt";
            int port_count = File.ReadAllLines("C:/Users/"+userName+"/Documents/batch.txt").Length;

            // Vragen of het aantal poorten klopt, indien ja dan uitvoeren.
            DialogResult apply_choice =  MessageBox.Show("Weet je zeker dat je " + port_count + " poorten aan wil aanpassen?", "Waarschuwing!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (apply_choice == DialogResult.Yes)
            {
                // Knoppen uitzetten om te voorkomen dat twee dingen door elkaar heen lopen
                apply_button.Enabled = false;
                apply_checkbox.Enabled = false;
                remove_checkbox.Enabled = false;
                reset_login_button.Enabled = false;
                reset_switchvalue_button.Enabled = false;

                // Status aanpassen
                status_label.Text = "Bezig...";

                // SSH sessie opbouwen, error teruggeven indien mislukt
                var ssh = new SshClient(switchip_textbox.Text, username_textbox.Text, password_textbox.Text);
                {
                    try
                    {
                        ssh.Connect();
                    }
                    catch (Exception ssh_fail)
                    {
                        MessageBox.Show("Er is een error opgetreden met de SSH sessie: \n " + ssh_fail.ToString(),"SSH error opgetreden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Interactieve sessie starten voor lees / schrijven
                var ssh_stream = ssh.CreateShellStream("ssh session", 80, 50, 1024, 1024, 1024);
                
                // Alle regels in textbestand uitlezen en commando's hiervoor uitvoeren
                foreach (string switchport_batch in File.ReadLines(filepath))
                {
                    if (apply_checkbox.Checked == true) // Toevoegen
                    {
                        // Commando's:
                        Thread.Sleep(10);
                        ssh_stream.WriteLine("conf t");
                        Thread.Sleep(10);
                        ssh_stream.WriteLine("aaa port-access authenticator " + switchport_batch);
                        Thread.Sleep(10);
                        ssh_stream.WriteLine("aaa port-access authenticator " + switchport_batch + " client-limit 8");
                        Thread.Sleep(10);
                        ssh_stream.WriteLine("aaa port-access authenticator " + switchport_batch + " logoff-period 604800");
                        Thread.Sleep(10);
                        ssh_stream.WriteLine("aaa port-access mac-based " + switchport_batch);
                        Thread.Sleep(10);
                        ssh_stream.WriteLine("aaa port-access mac-based " + switchport_batch + " addr-limit 8");
                        Thread.Sleep(10);
                        ssh_stream.WriteLine("aaa port-access mac-based " + switchport_batch + " logoff-period 604800");
                        Thread.Sleep(10);
                        ssh_stream.WriteLine("spanning-tree " + switchport_batch + " admin-edge-port");
                        Thread.Sleep(10);
                        ssh_stream.WriteLine("spanning-tree " + switchport_batch + " bpdu-protection");
                        Thread.Sleep(10);
                        ssh_stream.WriteLine("interface " + switchport_batch + " rate-limit mcast in percent 5");
                        Thread.Sleep(10);
                        ssh_stream.WriteLine("interface " + switchport_batch + " rate-limit bcast in percent 5");
                        Thread.Sleep(10);
                        ssh_stream.WriteLine("interface " + switchport_batch + " untagged vlan 1");
                    }
                    if (remove_checkbox.Checked == true) // Verwijderen
                    {
                        // Commando's:
                        ssh_stream.WriteLine("conf t");
                        Thread.Sleep(10);
                        ssh_stream.WriteLine("no aaa port-access authenticator " + switchport_batch);
                        Thread.Sleep(10);
                        ssh_stream.WriteLine("no aaa port-access authenticator " + switchport_batch + " client-limit");
                        Thread.Sleep(10);
                        ssh_stream.WriteLine("aaa port-access authenticator " + switchport_batch + " logoff-period 300");
                        Thread.Sleep(10);
                        ssh_stream.WriteLine("no aaa port-access mac-based " + switchport_batch);
                        Thread.Sleep(10);
                        ssh_stream.WriteLine("aaa port-access mac-based " + switchport_batch + " addr-limit 1");
                        Thread.Sleep(10);
                        ssh_stream.WriteLine("aaa port-access mac-based " + switchport_batch + " logoff-period 300");
                        Thread.Sleep(10);
                        ssh_stream.WriteLine("no spanning-tree " + switchport_batch + " admin-edge-port");
                        Thread.Sleep(10);
                        ssh_stream.WriteLine("no spanning-tree " + switchport_batch + " bpdu-protection");
                        Thread.Sleep(10);
                        ssh_stream.WriteLine("no interface " + switchport_batch + " rate-limit mcast in");
                        Thread.Sleep(10);
                        ssh_stream.WriteLine("no interface " + switchport_batch + " rate-limit bcast in");
                        Thread.Sleep(10);
                        ssh_stream.WriteLine("interface " + switchport_batch + " untagged vlan 1");
                    }
                }

                // Knoppen vrijgeven
                apply_button.Enabled = true;
                apply_checkbox.Enabled = true;
                remove_checkbox.Enabled = true;
                reset_login_button.Enabled = true;
                reset_switchvalue_button.Enabled = true;

                // Status laten zien aan de gebruiker
                MessageBox.Show("Poorten zijn succesvol aangepast", "Aanpassing voltooid!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                status_label.Text = "Klaar";

                // Configuratie opslaan op switch
                ssh_stream.WriteLine("wr mem");
                Thread.Sleep(10);

                // Sessie afsluiten
                ssh.Disconnect();
            }
            else if (apply_choice == DialogResult.No)
            {
                // Niks doen bij nee...
            }
        }
    }
}