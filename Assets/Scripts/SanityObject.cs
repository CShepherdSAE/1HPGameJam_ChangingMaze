﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SanityObject : MonoBehaviour
{
    public int sanityLevel;
    // Start is called before the first frame update
    void Awake()
    {
        Camera.main.transform.parent.GetComponent<Sanity>().SanityMasterList.Add(gameObject);
    }

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
