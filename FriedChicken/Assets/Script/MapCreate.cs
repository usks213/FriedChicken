using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreate : MonoBehaviour
{
    [SerializeField] GameObject Needl;
    [SerializeField] GameObject Heart;

    [SerializeField] int nRangeLR;
    [SerializeField] int nRangeT;

    [SerializeField] int ObjNum;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos;

        for (int i = 0; i < ObjNum; i++)
        {
            pos.x = Random.Range(-(float)nRangeLR, (float)nRangeLR);
            pos.y = Random.Range(0, nRangeT);
            pos.z = 0;
            Instantiate(Needl, pos, Quaternion.identity);

            pos.x = Random.Range(-nRangeLR, nRangeLR);
            pos.y = Random.Range(0, nRangeT);
            pos.z = 0;
          //  Instantiate(Heart, pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
