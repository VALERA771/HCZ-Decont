using System;
using System.Linq;
using CommandSystem;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Permissions.Extensions;

namespace HCZDecont
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class Force : ICommand, IUsageProvider
    {
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!sender.CheckPermission(PlayerPermissions.RoundEvents, out response) || !sender.CheckPermission("hd.force"))
                return false;

            if (arguments.Count != 2)
            {
                response = this.DisplayCommandUsage();
                return false;
            }

            ZoneType zone = arguments.At(0).ToLower() switch
            {
                "hcz" => ZoneType.HeavyContainment,
                "ez" => ZoneType.Entrance,
                "surface" => ZoneType.Surface,
                _ => ZoneType.Other
            };
            
            foreach (Player player in Player.List.Where(x => x.Zone == zone))
            {
                player.EnableEffect(EffectType.Decontaminating, duration: 2400f);
            }

            if (arguments.At(1).ToLower() == "true")
            {
                Door.LockAll(float.MaxValue, zone, DoorLockType.DecontLockdown);
            }

            response = "HCZ decontamination forced";
            return true;
        }

        public string Command { get; } = "force";
        public string[] Aliases { get; } = new[]
        {
            "df",
        };
        public string Description { get; } = "Forcing decontamination in HCZ";
        public string[] Usage { get; } = new[]
        {
            "Zone",
            "Lock doors"
        };
    }
}