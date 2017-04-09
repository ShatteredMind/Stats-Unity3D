using UnityEngine;
using System.Collections;

public class StatEntity {

    public string StatName { get; private set; }
    public int StatBaseValue { get; private set; }
    public int StatMaxValue { get; private set; }
    public int StatMinValue { get; private set; }
    public int StatCurrentValue { get; set; }
    public int StatOldValue { get; set; }

    public StatEntity(EntityStatType name)
    {
        StatName = name.ToString();
        StatBaseValue = 10;
        StatMaxValue = 100;
        StatMinValue = 0;
        StatCurrentValue = StatBaseValue;
    }

    public StatEntity(string StatName, int BaseValue, int MaxValue, int MinValue)
    {
        this.StatName = StatName;
        this.StatBaseValue = BaseValue;
        this.StatMaxValue = MaxValue;
        this.StatMinValue = MinValue;
    }

    public void ChangeStatValue(int amount)
    {
        StatOldValue = StatCurrentValue;
        StatCurrentValue += amount;
        if (StatCurrentValue >= StatMaxValue)
        {
            StatCurrentValue = StatMaxValue;
        }
        if (StatCurrentValue <= StatMinValue)
        {
            StatCurrentValue = StatMinValue;
        }
    }
	
}
