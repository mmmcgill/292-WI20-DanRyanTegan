﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SetPriority : MonoBehaviour
{
    public RectTransform pause;

    void Awake()
    {
        pause.SetAsLastSibling();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
