using System;

public class StatChangedArgs : EventArgs {

    public int OldValue { get; set; }
    public int NewValue { get; set; }
}
