namespace DuckDns_DUC
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.cbRefresh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbShowNotificactions = new System.Windows.Forms.ComboBox();
            this.lnklblOpenDuckDns = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.chkCloseToTry = new System.Windows.Forms.CheckBox();
            this.chkMinimizeToTry = new System.Windows.Forms.CheckBox();
            this.tpNetwork = new System.Windows.Forms.TabPage();
            this.txtNetworkAdapterIpAddress = new System.Windows.Forms.TextBox();
            this.txtNetworkAdapterDnsSufix = new System.Windows.Forms.TextBox();
            this.txtNetworkAdapterName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbNetworkAdapter = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabSettings.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.tpNetwork.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(119, 9);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(299, 20);
            this.txtDomain.TabIndex = 0;
            this.txtDomain.TextChanged += new System.EventHandler(this.txtDomain_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dominio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Token";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(119, 35);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(299, 20);
            this.txtToken.TabIndex = 1;
            this.txtToken.TextChanged += new System.EventHandler(this.txtToken_TextChanged);
            // 
            // cbRefresh
            // 
            this.cbRefresh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbRefresh.FormattingEnabled = true;
            this.cbRefresh.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cbRefresh.Location = new System.Drawing.Point(119, 61);
            this.cbRefresh.Name = "cbRefresh";
            this.cbRefresh.Size = new System.Drawing.Size(299, 21);
            this.cbRefresh.TabIndex = 2;
            this.cbRefresh.SelectedIndexChanged += new System.EventHandler(this.cbRefresh_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Intervalo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mostrar notificaciones";
            // 
            // cbShowNotificactions
            // 
            this.cbShowNotificactions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShowNotificactions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbShowNotificactions.FormattingEnabled = true;
            this.cbShowNotificactions.Items.AddRange(new object[] {
            "SÍ",
            "NO"});
            this.cbShowNotificactions.Location = new System.Drawing.Point(119, 88);
            this.cbShowNotificactions.Name = "cbShowNotificactions";
            this.cbShowNotificactions.Size = new System.Drawing.Size(299, 21);
            this.cbShowNotificactions.TabIndex = 3;
            this.cbShowNotificactions.SelectedIndexChanged += new System.EventHandler(this.cbShowNotificactions_SelectedIndexChanged);
            // 
            // lnklblOpenDuckDns
            // 
            this.lnklblOpenDuckDns.AutoSize = true;
            this.lnklblOpenDuckDns.Location = new System.Drawing.Point(119, 116);
            this.lnklblOpenDuckDns.Name = "lnklblOpenDuckDns";
            this.lnklblOpenDuckDns.Size = new System.Drawing.Size(102, 13);
            this.lnklblOpenDuckDns.TabIndex = 4;
            this.lnklblOpenDuckDns.TabStop = true;
            this.lnklblOpenDuckDns.Text = "https://duckdns.org";
            this.lnklblOpenDuckDns.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenDuckDNS_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Obtener settings";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(287, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(368, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tpGeneral);
            this.tabSettings.Controls.Add(this.tpNetwork);
            this.tabSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSettings.Location = new System.Drawing.Point(3, 3);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(443, 196);
            this.tabSettings.TabIndex = 13;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.chkCloseToTry);
            this.tpGeneral.Controls.Add(this.chkMinimizeToTry);
            this.tpGeneral.Controls.Add(this.label1);
            this.tpGeneral.Controls.Add(this.txtDomain);
            this.tpGeneral.Controls.Add(this.txtToken);
            this.tpGeneral.Controls.Add(this.label5);
            this.tpGeneral.Controls.Add(this.label2);
            this.tpGeneral.Controls.Add(this.lnklblOpenDuckDns);
            this.tpGeneral.Controls.Add(this.cbRefresh);
            this.tpGeneral.Controls.Add(this.cbShowNotificactions);
            this.tpGeneral.Controls.Add(this.label3);
            this.tpGeneral.Controls.Add(this.label4);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(435, 170);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // chkCloseToTry
            // 
            this.chkCloseToTry.AutoSize = true;
            this.chkCloseToTry.Location = new System.Drawing.Point(178, 144);
            this.chkCloseToTry.Name = "chkCloseToTry";
            this.chkCloseToTry.Size = new System.Drawing.Size(148, 17);
            this.chkCloseToTry.TabIndex = 6;
            this.chkCloseToTry.Text = "Cerrar a la barra de tareas";
            this.chkCloseToTry.UseVisualStyleBackColor = true;
            this.chkCloseToTry.CheckedChanged += new System.EventHandler(this.chkCloseToTry_CheckedChanged);
            // 
            // chkMinimizeToTry
            // 
            this.chkMinimizeToTry.AutoSize = true;
            this.chkMinimizeToTry.Location = new System.Drawing.Point(9, 144);
            this.chkMinimizeToTry.Name = "chkMinimizeToTry";
            this.chkMinimizeToTry.Size = new System.Drawing.Size(163, 17);
            this.chkMinimizeToTry.TabIndex = 5;
            this.chkMinimizeToTry.Text = "Minimizar a la barra de tareas";
            this.chkMinimizeToTry.UseVisualStyleBackColor = true;
            this.chkMinimizeToTry.CheckedChanged += new System.EventHandler(this.chkMinimizeToTry_CheckedChanged);
            // 
            // tpNetwork
            // 
            this.tpNetwork.Controls.Add(this.txtNetworkAdapterIpAddress);
            this.tpNetwork.Controls.Add(this.txtNetworkAdapterDnsSufix);
            this.tpNetwork.Controls.Add(this.txtNetworkAdapterName);
            this.tpNetwork.Controls.Add(this.label9);
            this.tpNetwork.Controls.Add(this.label8);
            this.tpNetwork.Controls.Add(this.label7);
            this.tpNetwork.Controls.Add(this.label6);
            this.tpNetwork.Controls.Add(this.cbNetworkAdapter);
            this.tpNetwork.Location = new System.Drawing.Point(4, 22);
            this.tpNetwork.Name = "tpNetwork";
            this.tpNetwork.Padding = new System.Windows.Forms.Padding(3);
            this.tpNetwork.Size = new System.Drawing.Size(435, 170);
            this.tpNetwork.TabIndex = 1;
            this.tpNetwork.Text = "Red";
            this.tpNetwork.UseVisualStyleBackColor = true;
            // 
            // txtNetworkAdapterIpAddress
            // 
            this.txtNetworkAdapterIpAddress.Location = new System.Drawing.Point(101, 123);
            this.txtNetworkAdapterIpAddress.Name = "txtNetworkAdapterIpAddress";
            this.txtNetworkAdapterIpAddress.ReadOnly = true;
            this.txtNetworkAdapterIpAddress.Size = new System.Drawing.Size(328, 20);
            this.txtNetworkAdapterIpAddress.TabIndex = 3;
            // 
            // txtNetworkAdapterDnsSufix
            // 
            this.txtNetworkAdapterDnsSufix.Location = new System.Drawing.Point(101, 97);
            this.txtNetworkAdapterDnsSufix.Name = "txtNetworkAdapterDnsSufix";
            this.txtNetworkAdapterDnsSufix.ReadOnly = true;
            this.txtNetworkAdapterDnsSufix.Size = new System.Drawing.Size(328, 20);
            this.txtNetworkAdapterDnsSufix.TabIndex = 2;
            // 
            // txtNetworkAdapterName
            // 
            this.txtNetworkAdapterName.Location = new System.Drawing.Point(101, 71);
            this.txtNetworkAdapterName.Name = "txtNetworkAdapterName";
            this.txtNetworkAdapterName.ReadOnly = true;
            this.txtNetworkAdapterName.Size = new System.Drawing.Size(328, 20);
            this.txtNetworkAdapterName.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ip";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sufijo Dns";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adaptador de red";
            // 
            // cbNetworkAdapter
            // 
            this.cbNetworkAdapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNetworkAdapter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbNetworkAdapter.FormattingEnabled = true;
            this.cbNetworkAdapter.Location = new System.Drawing.Point(101, 34);
            this.cbNetworkAdapter.Name = "cbNetworkAdapter";
            this.cbNetworkAdapter.Size = new System.Drawing.Size(328, 21);
            this.cbNetworkAdapter.TabIndex = 0;
            this.cbNetworkAdapter.SelectedIndexChanged += new System.EventHandler(this.cbNetworkAdapter_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabSettings, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.16666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.83333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(449, 240);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 32);
            this.panel1.TabIndex = 0;
            // 
            // Settings
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(449, 240);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tabSettings.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            this.tpNetwork.ResumeLayout(false);
            this.tpNetwork.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.ComboBox cbRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbShowNotificactions;
        private System.Windows.Forms.LinkLabel lnklblOpenDuckDns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tpNetwork;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.CheckBox chkCloseToTry;
        private System.Windows.Forms.CheckBox chkMinimizeToTry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbNetworkAdapter;
        private System.Windows.Forms.TextBox txtNetworkAdapterIpAddress;
        private System.Windows.Forms.TextBox txtNetworkAdapterDnsSufix;
        private System.Windows.Forms.TextBox txtNetworkAdapterName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

