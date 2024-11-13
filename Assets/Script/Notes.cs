using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes
{
    private float StartBeat;
    private float EndBeat;
    private string KeyValue;
    private bool isPoked;

    public Notes(float StartBeat, float EndBeat, string KeyValue)
    {
        this.StartBeat = StartBeat;
        this.EndBeat = EndBeat;
        this.KeyValue = KeyValue;
    }
    public float getStartBeat()
    {
        return StartBeat;
    }
    public float getEndBeat()
    {
        return EndBeat;
    }
    public string getKeyValue()
    {
        return KeyValue;
    }
    public float setStartBeat(float StartBeat)
    {
        this.StartBeat = StartBeat;
        return this.StartBeat;
    }

    public float setEndBeat(float EndBeat)
    {
        this.EndBeat = EndBeat;
        return this.EndBeat;
    }
}
