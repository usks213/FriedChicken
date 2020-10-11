using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameMgr : MonoBehaviour
{
    float initTime;

    // Start is called before the first frame update
    void Start()
    {
        initTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public float GetResultTime()
    {
        return Time.time - initTime;
    }
}
