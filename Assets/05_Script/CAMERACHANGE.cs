﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMERACHANGE : MonoBehaviour
{
    public GameObject 相機1;
    public GameObject 相機2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.K))
        {
            相機2.SetActive(true); 
            相機1.SetActive(false);
        }

        else if (Input.GetKeyUp(KeyCode.J))
        {
            相機1.SetActive(true);
            相機2.SetActive(false);
        }
       
    }
}

