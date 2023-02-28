using Exiled.API.Features;
using Exiled.API.Enums;
using MEC;

namespace HCZDecont
{
    internal class Handlers
    {
        public void OnRoundStart()
        {
            if (Plugin.Instance.Config.HczDecont) HCZDecont();
            if (Plugin.Instance.Config.SurfDecont) SurfaceDecont();
            if (Plugin.Instance.Config.EzDecont) EZDecont();
        }

        public void HCZDecont()
        {
            Timing.CallDelayed(10f, () =>
            {
                string temp = Plugin.Instance.Config.BeforeDecontHcz.ToString();
                Cassie.Message(Plugin.Instance.Config.CassieDecontHcz.Replace("{0}", temp));
            });
            int min = Plugin.Instance.Config.BeforeDecontHcz / 60;
            int temp1 = min - 15;
            int temp2 = min - 10;
            int temp3 = min - 5;
            float time1 = float.Parse(temp1.ToString());
            float time2 = float.Parse(temp2.ToString());
            float time3 = float.Parse(temp3.ToString());

            Timing.CallDelayed(time3, () =>
            {
                if (Plugin.Instance.Config.CassieOnHcz) Cassie.Message(Plugin.Instance.Config.CassieAfter5Hcz);
            });
            Timing.CallDelayed(time2, () =>
            {
                if (Plugin.Instance.Config.CassieOnHcz) Cassie.Message(Plugin.Instance.Config.CassieAfter10Hcz);
            });
            Timing.CallDelayed(time1, () =>
            {
                if (Plugin.Instance.Config.CassieOnHcz) Cassie.Message(Plugin.Instance.Config.CassieAfter15Hcz);
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

                if (Plugin.Instance.Config.LockAllHcz)
                {
                    Door.LockAll(zoneType: ZoneType.HeavyContainment, duration: 100000f);
                }
                if (Plugin.Instance.Config.LockCheckHcz)
                {
                    Door.Get(DoorType.CheckpointEzHczA).Lock(100000f, DoorLockType.DecontLockdown);
                    Door.Get(DoorType.CheckpointEzHczB).Lock(100000f, DoorLockType.DecontLockdown);
                }

                if (Plugin.Instance.Config.CassieOnHcz)  Cassie.Message(Plugin.Instance.Config.CassieDecontEndHcz);

            });
        }

        public void SurfaceDecont()
        {
            Timing.CallDelayed(10f, () =>
            {
                string temp = Plugin.Instance.Config.BeforeDecontSurf.ToString();
                Cassie.Message(Plugin.Instance.Config.CassieDecontSurf.Replace("{0}", temp));
            });
            int min = Plugin.Instance.Config.BeforeDecontSurf / 60;
            int temp1 = min - 15;
            int temp2 = min - 10;
            int temp3 = min - 5;
            float time1 = float.Parse(temp1.ToString());
            float time2 = float.Parse(temp2.ToString());
            float time3 = float.Parse(temp3.ToString());
            Timing.CallDelayed(time3, () =>
            {
                if (Plugin.Instance.Config.CassieOnSurf) Cassie.Message(Plugin.Instance.Config.CassieAfter5Surf);
            });
            Timing.CallDelayed(time2, () =>
            {
                if (Plugin.Instance.Config.CassieOnSurf) Cassie.Message(Plugin.Instance.Config.CassieAfter10Surf);
            });
            Timing.CallDelayed(time1, () =>
            {
                if (Plugin.Instance.Config.CassieOnSurf) Cassie.Message(Plugin.Instance.Config.CassieAfter15Surf);
            });
            Timing.CallDelayed(300, () =>
            {
                foreach (Player player in Player.List)
                {
                    if (player.Zone == ZoneType.Surface)
                    {
                        player.EnableEffect(EffectType.Decontaminating, duration: 2400f);
                    }
                }

                if (Plugin.Instance.Config.LockAllSurf)
                {
                    Door.LockAll(zoneType: ZoneType.HeavyContainment, duration: 100000f);
                }
                if (Plugin.Instance.Config.LockCheckSurf)
                {
                    Lift.Get(ElevatorType.GateA).ChangeLock(Interactables.Interobjects.DoorUtils.DoorLockReason.DecontLockdown);
                    Lift.Get(ElevatorType.GateB).ChangeLock(Interactables.Interobjects.DoorUtils.DoorLockReason.DecontLockdown);
                }

                if (Plugin.Instance.Config.CassieOnSurf) Cassie.Message(Plugin.Instance.Config.CassieDecontEndSurf);

            });
        }

        public void EZDecont()
        {
            Timing.CallDelayed(10f, () =>
            {
                string temp = Plugin.Instance.Config.BeforeDecontEz.ToString();
                Cassie.Message(Plugin.Instance.Config.CassieDecontEz.Replace("{0}", temp));
            });
            int min = Plugin.Instance.Config.BeforeDecontEz / 60;
            int temp1 = min - 15;
            int temp2 = min - 10;
            int temp3 = min - 5;
            float time1 = float.Parse(temp1.ToString());
            float time2 = float.Parse(temp2.ToString());
            float time3 = float.Parse(temp3.ToString());

            Timing.CallDelayed(time3, () =>
            {
                if (Plugin.Instance.Config.CassieOnEz) Cassie.Message(Plugin.Instance.Config.CassieAfter5Ez);
            });
            Timing.CallDelayed(time2, () =>
            {
                if (Plugin.Instance.Config.CassieOnEz) Cassie.Message(Plugin.Instance.Config.CassieAfter10Ez);
            });
            Timing.CallDelayed(time1, () =>
            {
                if (Plugin.Instance.Config.CassieOnEz) Cassie.Message(Plugin.Instance.Config.CassieAfter15Ez);
            });
            Timing.CallDelayed(300, () =>
            {
                foreach (Player player in Player.List)
                {
                    if (player.Zone == ZoneType.Entrance)
                    {
                        player.EnableEffect(EffectType.Decontaminating, duration: 2400f);
                    }
                }

                if (Plugin.Instance.Config.LockAllEz)
                {
                    Door.LockAll(zoneType: ZoneType.HeavyContainment, duration: 100000f);
                }
                if (Plugin.Instance.Config.LockCheckEz)
                {
                    Door.Get(DoorType.CheckpointEzHczA).Lock(100000f, DoorLockType.DecontLockdown);
                    Door.Get(DoorType.CheckpointEzHczB).Lock(100000f, DoorLockType.DecontLockdown);
                }

                if (Plugin.Instance.Config.CassieOnEz) Cassie.Message(Plugin.Instance.Config.CassieDecontEndEz);

            });
        }
    }
}
