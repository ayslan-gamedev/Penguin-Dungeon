﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyScore : MonoBehaviour
{
    public GameObject gameobj;

    // Start is called before the first frame update
    void Start()
    {
        if(!GameObject.Find("Canvas 1(Clone)"))
        {
            Instantiate(gameobj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
