using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    Text scoreText;


    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();

        scoreText.text = "Scoreランキング" + "\n";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetScore(float fScore, string name)
    {
        scoreText.text += "["+name+"] "+ "Score:" + fScore + "\n";

    }
}
