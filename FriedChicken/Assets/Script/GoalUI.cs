using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalUI : MonoBehaviour
{
    SpriteRenderer sr;
    Color color;
    bool bAlpha;

    // Start is called before the first frame update
    void Start()
    {
        sr = transform.GetComponent<SpriteRenderer>();

        bAlpha = false;
        color.a = 0;
        color.r = 1;
        color.g = 1;
        color.b = 1;
    }

    // Update is called once per frame
    void Update()
    {
       if(bAlpha)
        {
            color.a += 0.01f;
            sr.color = color;

            if(color.a > 3)
            {
                SceneManager.LoadScene("ResultScene");
            }
        }
    }

    public void StartGoal()
    {
        bAlpha = true;
    }
}
