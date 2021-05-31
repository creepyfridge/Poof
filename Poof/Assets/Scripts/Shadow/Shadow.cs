using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class Shadow : MonoBehaviour
{
    [SerializeField, SerializeReference]
    public ShadowTarget target = null;

    int id = -1;
    public int ID
    {
        get
        {
            if (id == -1)
                id = ShadowManager.idCounter++;
            return id;
        }
    }

    [SerializeField]
    int TIME_OFFSET = 1500;

    // Start is called before the first frame update
    void Start()
    {
        target.registerShadow(ID);
    }

    // Update is called once per frame
    void Update()
    {
        if (!ShadowManager.Instance.containsKey(ID))
            return;

        Tuple<DateTime, Vector3> target = ShadowManager.Instance.peek(ID);

        if (target == null)
        {
            //TODO: ERROR
            return;
        }

        //update the position
        transform.position = target.Item2;

        //attempt
        ShadowManager.Instance.trim(ID, TIME_OFFSET + 1);
    }
}
