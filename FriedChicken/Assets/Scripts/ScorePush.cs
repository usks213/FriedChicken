using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;


public class ScorePush : MonoBehaviour
{
    [SerializeField] FloatVariable scoreTime;
    [SerializeField] StringValue playerName;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushScore()
    {
        NCMBObject scoreClass = new NCMBObject("FCScoreClass");

        scoreClass["Score"] = scoreTime.Value;
        scoreClass["Name"] = playerName.Value;
        scoreClass.Save();
    }
}
