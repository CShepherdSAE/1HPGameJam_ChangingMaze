using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SanityObject : Sanity
{
    public int sanityLevel;
    // Start is called before the first frame update
    void Start()
    {
        SanityMasterList.Add(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
