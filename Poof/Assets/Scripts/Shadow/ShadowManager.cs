using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
public class ShadowManager
{
    static ShadowManager instance = null;
    private ShadowManager() { }
    public static ShadowManager Instance
    {
        get
        {
            if (instance == null)
                instance = new ShadowManager();
            return instance;
        }
    }

    //dictionary 
    Dictionary<int, Queue<Tuple<DateTime, Vector3>>> posData = new Dictionary<int, Queue<Tuple<DateTime, Vector3>>>();

    public static int idCounter = 0;

    public void record(int id, Tuple<DateTime, Vector3> data)
    {
        //initializing if needed
        if (!posData.ContainsKey(id))
            posData.Add(id, new Queue<Tuple<DateTime, Vector3>>());

        posData[id].Enqueue(data);
    }

    /// <summary>
    /// removes old recorded data
    /// </summary>
    /// <param name="id">the id of the shadow</param>
    /// <param name="maxAge">the maximum age of events to keep in miliseconds (1s = 1000ms)</param>
    public void trim(int id, int maxAge)
    {
        if (!posData.ContainsKey(id))
            return;

        DateTime now = DateTime.Now;

        while
            (
            //stop if we run out of stuff to trim
            posData[id].Count > 0 &&
            //compare the time stamps, we can stop once were under the threshold
            (int)(now - posData[id].Peek().Item1).TotalMilliseconds > maxAge
            )
        {
            posData[id].Dequeue();
        }
    }

    public Tuple<DateTime, Vector3> peek(int id)
    {
        if (!posData.ContainsKey(id))
            return null;

        if (posData[id].Count == 0)
            return null;

        return posData[id].Peek();
    }

    public Tuple<DateTime, Vector3> dequeue(int id)
    {
        if (!posData.ContainsKey(id))
            return null;

        if (posData[id].Count == 0)
            return null;

        return posData[id].Dequeue();
    }

    public bool containsKey(int id)
    {
        return posData.ContainsKey(id);
    }
}
