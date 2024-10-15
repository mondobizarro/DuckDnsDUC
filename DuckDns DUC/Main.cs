using DuckDns_DUC.Common;
using DuckDns_DUC.Types;
using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace DuckDns_DUC
{
    public partial class Main : Form
    {
        Config _cfg;
        Config cfg
        {
            get
            {
               
               _cfg = Utils.LeerConfiguracionDesdeXml("Config.config"); 
                return _cfg;
            }
           
        }

        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenu;
        private System.Timers.Timer timer;

        public Main()
        {
            InitializeComponent();
            notifyIcon = new NotifyIcon();
            notifyIcon.Text = Application.ProductName;
            notifyIcon.Icon = new Icon(Properties.Resources.icon, 40, 40);

            contextMenu = new ContextMenuStrip();
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Salir",Properties.Resources.exit, OnExit);
            ToolStripMenuItem renovarMenuItem = new ToolStripMenuItem("Renovar", Properties.Resources.Renew, btnUpdateNow_Click);
            contextMenu.Items.Add(exitMenuItem);
            contextMenu.Items.Add(renovarMenuItem);

            notifyIcon.ContextMenuStrip = contextMenu;
            notifyIcon.Visible = true;
            notifyIcon.DoubleClick += new EventHandler(NotifyIcon_DoubleClick);            
            this.Resize += new EventHandler(Form_Resize);

            timer = new System.Timers.Timer();
            timer.Interval = cfg.RefreshInterval * 60000; // Intervalo en milisegundos (300000 ms = 5 minutos)
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;  // Repetir la ejecución del método
            timer.Enabled = true;    // Iniciar el temporizador
        }

        private void Form_Resize(object sender, EventArgs e)
        {            
            if (this.WindowState == FormWindowState.Minimized && cfg.chkMinimizeToTry)
            {
                Hide();
            }
            else if (this.WindowState == FormWindowState.Minimized && !cfg.chkMinimizeToTry)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private async void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
           OnRenew();
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {            
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void OnExit(object sender, EventArgs e)
        {
            if (cfg.chkCloseToTry)
            {                
                Hide();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnShowSettings_Click(object sender, EventArgs e)
        {
            var settings = new Settings();
            settings.ShowDialog(this);
        }

        private void btnUpdateNow_Click(object sender, EventArgs e)
        {
            OnRenew();
        }
        private void ShowNotification(string title, string message, ToolTipIcon iconType)
        {         
            notifyIcon.ShowBalloonTip(3000, title, message, iconType);
        }

        public async void OnRenew()
        {
            var renewer = new DuckDnsUpdater();
            var res = await renewer.UpdateAsync(cfg.txtDomain, cfg.txtToken, cfg.txtNetworkAdapterID);
            if (_cfg.cbShowNotificactions == 0)
            {
                ShowNotification("DuckDns DUC", res ? "Actualización correcta" : "Error al actualizar", res ? ToolTipIcon.Info : ToolTipIcon.Error);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (cfg.chkCloseToTry)
            {   
                e.Cancel = true;
                Hide();
            }
        }
    }
}
