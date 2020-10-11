using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LifeUI : MonoBehaviour
{
    TextMeshProUGUI text;
    [SerializeField] PlayerLife playerLife;
    // Start is called before the first frame update
    void Start()
    {
        text = transform.GetComponent<TextMeshProUGUI>();
        text.text = "LIFE:" + playerLife.GetLife() + "/" + playerLife.GetMaxLife();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "LIFE:" + playerLife.GetLife() + "/" + playerLife.GetMaxLife();
    }
}
