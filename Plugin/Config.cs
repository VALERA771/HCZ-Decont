using Exiled.API.Interfaces;
using System.ComponentModel;

namespace HCZDecont
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        [Description("Heavy Contaiment Zone decontamination settings\nShould HCZ be decontaminated?")]
        public bool HczDecont { get; set; } = true;

        [Description("Lock all doors in HCZ?")]
        public bool LockAllHcz { get; set; } = true;

        [Description("Lock chekpoint EZ/HCZ?")]
        public bool LockCheckHcz { get; set; } = false;

        [Description("Should decont have CASSIE info?")]
        public bool CassieOnHcz { get; set; } = true;

        [Description("Time before decont in seconds")]
        public int BeforeDecontHcz { get; set; } = 1600;

        [Description("First CASSIE in beggining of the round. Replace {0} with time in minites")]
        public string CassieDecontHcz { get; set; } = "HCZ will be on decontamination in T-{0} minutes";

        [Description("CASSIE after 15 minutes of decontamination")]
        public string CassieAfter15Hcz { get; set; } = "Attention! HCZ wil be on decontamination T-15 minutes";

        [Description("CASSIE after 10 minutes of decontamination")]
        public string CassieAfter10Hcz { get; set; } = "Attention! HCZ wil be on decontamination T-10 minutes";

        [Description("CASSIE after 5 minutes of decontamination")]
        public string CassieAfter5Hcz { get; set; } = "Attention! HCZ wil be on decontamination T-5 minutes";

        [Description("CASSIE after decont start")]
        public string CassieDecontEndHcz { get; set; } = "HCZ has locked down and ready for decontamination";

        [Description("Enrance Zone decontamination settings\nShould EZ be decontaminated?")]
        public bool EzDecont { get; set; } = true;

        [Description("Lock all doors in EZ?")]
        public bool LockAllEz { get; set; } = true;

        [Description("Lock chekpoint EZ/HCZ?")]
        public bool LockCheckEz { get; set; } = false;

        [Description("Should decont have CASSIE info?")]
        public bool CassieOnEz { get; set; } = true;

        [Description("Time before decont in seconds")]
        public int BeforeDecontEz { get; set; } = 1900;

        [Description("First CASSIE in beggining of the round. Replace {0} with time in minites")]
        public string CassieDecontEz { get; set; } = "HCZ will be on decontamination in T-{0} minutes";

        [Description("CASSIE after 15 minutes of decontamination")]
        public string CassieAfter15Ez { get; set; } = "Attention! EZ wil be on decontamination T-15 minutes";

        [Description("CASSIE after 10 minutes of decontamination")]
        public string CassieAfter10Ez { get; set; } = "Attention! EZ wil be on decontamination T-10 minutes";

        [Description("CASSIE after 5 minutes of decontamination")]
        public string CassieAfter5Ez { get; set; } = "Attention! EZ wil be on decontamination T-5 minutes";

        [Description("CASSIE after decont start")]
        public string CassieDecontEndEz { get; set; } = "EZ has locked down and ready for decontamination";

        [Description("Surface decontamination settings\nShould Surface be decontaminated?")]
        public bool SurfDecont { get; set; } = true;

        [Description("Lock all doors in SZ?")]
        public bool LockAllSurf { get; set; } = true;

        [Description("Lock elevators?")]
        public bool LockCheckSurf { get; set; } = false;

        [Description("Should decont have CASSIE info?")]
        public bool CassieOnSurf { get; set; } = true;

        [Description("Time before decont in seconds")]
        public int BeforeDecontSurf { get; set; } = 2200;

        [Description("First CASSIE in beggining of the round. Replace {0} with time in minites")]
        public string CassieDecontSurf { get; set; } = "SZ will be on decontamination in T-{0} minutes";

        [Description("CASSIE after 15 minutes of decontamination")]
        public string CassieAfter15Surf { get; set; } = "Attention! SZ wil be on decontamination T-15 minutes";

        [Description("CASSIE after 10 minutes of decontamination")]
        public string CassieAfter10Surf { get; set; } = "Attention! SZ wil be on decontamination T-10 minutes";

        [Description("CASSIE after 5 minutes of decontamination")]
        public string CassieAfter5Surf { get; set; } = "Attention! SZ wil be on decontamination T-5 minutes";

        [Description("CASSIE after decont start")]
        public string CassieDecontEndSurf { get; set; } = "SZ has locked down and ready for decontamination";
    }
}
