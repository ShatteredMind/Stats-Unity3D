using UnityEngine;
using System.Collections.Generic;
using System;

public class StatTest : MonoBehaviour
{
    void Start()
    {
        PlayerStats stats = new PlayerStats();
        var defs = Enum.GetValues(typeof(EntityStatType));
        foreach (var def in defs)
        {
            StatEntity stat = stats.GetStat<StatEntity>((EntityStatType)def);
            if (stat != null)
            {
                Debug.Log(string.Format("{0}'s value is {1}", stat.StatName, stat.StatCurrentValue));
            }
            if (stat == null)
            {
                Debug.Log(defs.Length);
            }
        }      
    }
}
