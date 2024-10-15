using DuckDns_DUC.Common;
using DuckDns_DUC.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuckDns_DUC
{
    public partial class Settings : Form
    {
        Config _cfg;
        Config cfg 
        { 
            get 
            {                 
                if (_cfg == null)
                        _cfg = new Config();
                   return _cfg;
            } 
            set 
            {
                _cfg = value;
            } 
        }
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            try
            {
                ShowConfig();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void ShowConfig()
        {
            cbNetworkAdapter.DataSource = Utils.GetNetworkInterfaces();
            cbNetworkAdapter.DisplayMember = "Name";
            cbNetworkAdapter.ValueMember = "Id";

            cfg = Utils.LeerConfiguracionDesdeXml("Config.config");           

            txtDomain.Text = cfg.txtDomain;
            txtToken.Text = cfg.txtToken;
            cbRefresh.SelectedIndex = cfg.cbRefresh;
            cbShowNotificactions.SelectedIndex = cfg.cbShowNotificactions;
            chkCloseToTry.Checked = cfg.chkCloseToTry;
            chkMinimizeToTry .Checked = cfg.chkMinimizeToTry;
            cbNetworkAdapter.SelectedItem = cbNetworkAdapter.SelectedItem = ((List<NetworkInterfacesDTO>)cbNetworkAdapter.DataSource).Find(x => x.Id == cfg.txtNetworkAdapterID);
        }
        private void cbNetworkAdapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedNetworkInterface = (NetworkInterfacesDTO)cbNetworkAdapter.SelectedItem;

            if (selectedNetworkInterface!=null)
            {
                txtNetworkAdapterName.Text = selectedNetworkInterface.Name;
                txtNetworkAdapterDnsSufix.Text = selectedNetworkInterface.SufijoDNS;
                txtNetworkAdapterIpAddress.Text = selectedNetworkInterface.DireccionIPv4;
                cfg.txtNetworkAdapterID = selectedNetworkInterface.Id;
                cfg.cbNetworkAdapter = cbNetworkAdapter.SelectedIndex;
                cfg.txtNetworkAdapterIpAddress = txtNetworkAdapterIpAddress.Text;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Utils.EscribirConfiguracionEnXml("Config.config ", cfg);
            this.Close();
        }

        private void txtDomain_TextChanged(object sender, EventArgs e)
        {
            cfg.txtDomain = txtDomain.Text;
        }

        private void txtToken_TextChanged(object sender, EventArgs e)
        {
            cfg.txtToken = txtToken.Text;
        }

        private void cbRefresh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cfg.cbRefresh = cbRefresh.SelectedIndex;
            cfg.RefreshInterval = int.Parse(cbRefresh.SelectedText);
        }

        private void cbShowNotificactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            cfg.cbShowNotificactions = cbShowNotificactions.SelectedIndex;
        }

        private void OpenDuckDNS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {         
            Process.Start(new ProcessStartInfo
            {
                FileName = ((LinkLabel)sender).Text,
                UseShellExecute = true // Importante para abrir en el navegador
            });
        }

        private void chkMinimizeToTry_CheckedChanged(object sender, EventArgs e)
        {
            cfg.chkMinimizeToTry = chkMinimizeToTry.Checked;
        }

        private void chkCloseToTry_CheckedChanged(object sender, EventArgs e)
        {
            cfg.chkCloseToTry = chkCloseToTry.Checked;
        }
    }
}
