using UnityEngine;
using System.Collections;

public class PlayerStats : StatCollection {

    public override void ConfigureStats()
    {
        CreateStat(EntityStatType.Health);
        CreateStat(EntityStatType.Mana);
        CreateStat(EntityStatType.Strength);
    }
}
