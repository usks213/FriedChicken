﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    [SerializeField] StringValue playername;
    [SerializeField] Text text;

    // Start is called before the first frame update
    void Start()
    {
		EventSystem.current.SetSelectedGameObject(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetName()
    {
        playername.Value = text.text;
    }
}
