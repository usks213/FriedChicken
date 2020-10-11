using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float shakeOffset;
    int nShakeFrame;
    int nShakeCount;
    bool bShakeFlag;

    // Start is called before the first frame update
    void Start()
    {
        nShakeCount = 0;
        nShakeFrame = 0;
        bShakeFlag = false;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 pos = target.position;
        pos.x = 0;
        pos.z -= 10;
        if (pos.y < 0)
            pos.y = 0;
        transform.position = pos;

        // 画面揺れ
        if(bShakeFlag)
        {
            pos.x += Random.Range(-shakeOffset, shakeOffset);
            pos.y += Random.Range(-shakeOffset, shakeOffset);
            transform.position = pos;

            nShakeCount++;
            if(nShakeCount > nShakeFrame)
            {
                bShakeFlag = false;
                nShakeFrame = 0;
                nShakeCount = 0;
            }
        }
    }

    public void SetShake(int frame)
    {
        nShakeFrame = frame;
        bShakeFlag = true;
    }
}
