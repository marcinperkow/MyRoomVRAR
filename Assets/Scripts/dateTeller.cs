﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dateTeller : MonoBehaviour
{
    public GameObject timeTextObject;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTime", 0f, 30f);
    }

    // Update is called once per frame
    void UpdateTime()
    {
        timeTextObject.GetComponent<TextMeshPro>().text = System.DateTime.Now.ToString("MM/dd/yyyy");
    }
}