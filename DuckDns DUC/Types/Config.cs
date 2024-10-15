namespace DuckDns_DUC.Types
{
    public class Config
    {
        public string txtDomain { get; set; }
        public string txtToken { get; set; }
        public int cbRefresh { get; set; }
        public int cbShowNotificactions { get; set; }
        public bool chkCloseToTry { get; set; }
        public bool chkMinimizeToTry { get; set; }
        public int cbNetworkAdapter { get; set; }
        public string txtNetworkAdapterIpAddress { get; set; }
        public string txtNetworkAdapterDnsSufix { get; set; }
        public string txtNetworkAdapterID { get; set; }
        public int RefreshInterval { get; set; }
    }
}

