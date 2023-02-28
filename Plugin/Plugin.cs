using Exiled.API.Features;
using System;

namespace HCZDecont
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "Heavy Contaiment Zone Decontamination";
        public override string Prefix => "HCZDecont";
        public override string Author => "VALERA771#1471";
        public override Version Version => new Version(2, 0, 0);
        public override Version RequiredExiledVersion => new Version(6, 0, 0);

        private Handlers han;

        public override void OnEnabled()
        {
            han = new Handlers();
            Exiled.Events.Handlers.Server.RoundStarted += han.OnRoundStart;

            Plugin.singleton = this;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Plugin.singleton = null;
            base.OnDisabled();

            Exiled.Events.Handlers.Server.RoundStarted += han.OnRoundStart;
            han = null;
        }

        public override void OnReloaded()
        {
            base.OnReloaded();
        }


        public static Plugin Instance => singleton;
        private static Plugin singleton;
    }
}
