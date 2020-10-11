using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudCreate : MonoBehaviour
{
    [SerializeField] GameObject cloud;

    [SerializeField] int nRangeLR;
    [SerializeField] int nRangeT;

    [SerializeField] int ObjNum;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos;

        for (int i = 0; i < ObjNum; i++)
        {
            //if(Random.Range(0,1) == 0)
            //{
            //    pos.x = nRangeLR;
            //}
            //else
            //{
            //    pos.x = -nRangeLR;
            //}
            pos.x = Random.Range(-nRangeLR, nRangeLR);
            pos.y = Random.Range(0, nRangeT);
            pos.z = 0;
            Instantiate(cloud, pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
