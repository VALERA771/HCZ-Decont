using Exiled.API.Features;
using Exiled.API.Enums;
using MEC;

namespace HCZDecont
{
    internal class Handlers
    {
        public void OnRoundStart()
        {
            if (Plugin.Instance.Config.CassieOn)
            {
                Timing.CallDelayed(10f, () =>
                {
                    string temp = Plugin.Instance.Config.BeforeDecont.ToString();
                    Cassie.Message(Plugin.Instance.Config.CassieDecont.Replace("{0}", temp));
                });
                int min = Plugin.Instance.Config.BeforeDecont / 60;
                int temp1 = min - 15;
                int temp2 = min - 10;
                int temp3 = min - 5;
                float time1 = float.Parse(temp1.ToString());
                float time2 = float.Parse(temp2.ToString());
                float time3 = float.Parse(temp3.ToString());

                Timing.CallDelayed(time1, () =>
                {
                    Cassie.Message(Plugin.Instance.Config.CassieAfter15);
                });
                Timing.CallDelayed(300, () =>
                {
                    Cassie.Message(Plugin.Instance.Config.CassieAfter10);
                });
                Timing.CallDelayed(300, () =>
                {
                    Cassie.Message(Plugin.Instance.Config.CassieAfter5);
                });
                Timing.CallDelayed(300, () =>
                {
                    foreach (Player player in Player.List)
                    {
                        if (player.Zone == ZoneType.HeavyContainment)
                        {
                            player.EnableEffect(EffectType.Decontaminating, duration: 2400f);
                        }
                    }

                    if (Plugin.Instance.Config.LockAll)
                    {
                        Door.LockAll(zoneType: ZoneType.HeavyContainment, duration: 100000f);
                    }
                    if (Plugin.Instance.Config.LockCheck)
                    {
                        Door.Get(DoorType.CheckpointEntrance).Lock(100000f, DoorLockType.DecontLockdown);
                    }

                    Cassie.Message(Plugin.Instance.Config.CassieDecontEnd);
                        
                });
            }
        }
    }
}
