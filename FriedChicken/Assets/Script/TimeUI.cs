using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeUI : MonoBehaviour
{
    TextMeshProUGUI text;
    float initTime;
    bool IsGoal;
    [SerializeField] FloatVariable goalTime;

    // Start is called before the first frame update
    void Start()
    {
        text = transform.GetComponent<TextMeshProUGUI>();
        initTime = Time.time;
        text.text = "TIME:" + initTime;
        IsGoal = false;
        goalTime.Value = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsGoal)
        {
            float time = Time.time - initTime;
            text.text = "TIME:" + time;
            goalTime.Value = Time.time - initTime;
        }
    }

    public void OnGoal()
    {
        IsGoal = true;
        goalTime.Value = Time.time - initTime;
    }
}
