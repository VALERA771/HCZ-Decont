using Exiled.API.Interfaces;
using System.ComponentModel;

namespace HCZDecont
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        [Description("Lock all doors in HCZ?")]
        public bool LockAll { get; set; } = true;

        [Description("Lock chekpoint EZ/HCZ?")]
        public bool LockCheck { get; set; } = false;

        [Description("Should decont have CASSIE info?")]
        public bool CassieOn { get; set; } = true;

        [Description("Time before decont in seconds")]
        public int BeforeDecont { get; set; } = 300;

        [Description("First CASSIE in beggining of the round. Replace {0} with time in minites")]
        public string CassieDecont { get; set; } = "HCZ will be on decontamination in T-{0} minutes";

        [Description("CASSIE, when 15 left")]
        public string CassieAfter15 { get; set; } = "Attention! HCZ wil be on decontamination T-15 minutes";

        [Description("CASSIE when 10 minutes left")]
        public string CassieAfter10 { get; set; } = "Attention! HCZ wil be on decontamination T-10 minutes";

        [Description("CASSIE when 5 minutes left")]
        public string CassieAfter5 { get; set; } = "Attention! HCZ wil be on decontamination T-5 minutes";

        [Description("CASSIE after decont start")]
        public string CassieDecontEnd { get; set; } = "HCZ has locked down and ready for decontamination";
    }
}
