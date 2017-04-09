using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class StatCollection  {

    public Dictionary<EntityStatType, StatEntity> stats;

    public StatCollection()
    {
        stats = new Dictionary<EntityStatType, StatEntity>();
        ConfigureStats();
    }

    public void AddStat<T>(EntityStatType statType) where T : StatEntity
    {
        T stat = (T)Activator.CreateInstance(typeof(T),statType);
        stats.Add(statType, (StatEntity)stat);
    }

    public T GetStat<T>(EntityStatType statType) where T : StatEntity
    {
        if (Contains(statType))
        {
            return stats[statType] as T;
        }
        return null;
    }

    public bool Contains(EntityStatType statType)
    {
        return stats.ContainsKey(statType);
    }

    public void CreateStat(EntityStatType statType)
    {
        var stat = GetStat<StatEntity>(statType);
        if (stat == null)
        {
           AddStat<StatEntity>(statType);
        }
    }

    public virtual void ConfigureStats()
    {

    }

}
