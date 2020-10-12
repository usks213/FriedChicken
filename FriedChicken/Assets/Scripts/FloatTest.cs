using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatTest : MonoBehaviour
{
    [SerializeField]
    FloatVariable test;

    // Start is called before the first frame update
    void Start()
    {
        test.Value = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
