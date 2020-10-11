using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeUI : MonoBehaviour
{
    TextMeshProUGUI text;
    float initTime;


    // Start is called before the first frame update
    void Start()
    {
        text = transform.GetComponent<TextMeshProUGUI>();
        initTime = Time.time;
        text.text = "TIME:" + initTime;
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time - initTime;
        text.text = "TIME:" + time;
    }
}
