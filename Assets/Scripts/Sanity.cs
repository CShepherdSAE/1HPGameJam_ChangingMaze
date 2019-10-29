using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sanity : MonoBehaviour
{
    public List<GameObject> SanityMasterList = new List<GameObject>();

    public GameObject symbol;

    [SerializeField] private float sanityMax = 100;
    [SerializeField] private float sanityCurrent;
    [SerializeField] private int iSanityCurrent;
    [SerializeField] private float sanityPercent;
    private float sanityChange;



    RaycastHit clohit;
    private Vector3 rayhitInWorld;

    // Start is called before the first frame update
    void Start()
    {
        sanityCurrent = sanityMax;
        for (int i = 0; i < SanityMasterList.Count/5; i++)
        {
            int ranNum = Random.Range(1, 3);
            SanityMasterList[i].GetComponent<SanityObject>().sanityLevel = ranNum;
        }
        for (int i = SanityMasterList.Count/5; i < SanityMasterList.Count/4; i++)
        {
            int ranNum = Random.Range(2, 4);
            SanityMasterList[i].GetComponent<SanityObject>().sanityLevel = ranNum;
        }
        for (int i = 0; i < SanityMasterList.Count/3; i++)
        {
            int ranNum = Random.Range(3, 5);
            SanityMasterList[i].GetComponent<SanityObject>().sanityLevel = ranNum;
        }
        for (int i = 0; i < SanityMasterList.Count / 3; i++)
        {
            int ranNum = Random.Range(4, 6);
            SanityMasterList[i].GetComponent<SanityObject>().sanityLevel = ranNum;
        }
        for (int i = 0 / 4; i < SanityMasterList.Count / 3; i++)
        {
            SanityMasterList[i].GetComponent<SanityObject>().sanityLevel = 5;
        }
    }

    // Update is called once per frame
    void Update()
    {

        //sanity
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out clohit, 9f))
        {
            if (clohit.collider.tag == "Symbol")
            {
                rayhitInWorld = clohit.point;
                Debug.DrawLine(Camera.main.ScreenToWorldPoint(Input.mousePosition), rayhitInWorld);
                sanityCurrent -= Time.deltaTime;
                iSanityCurrent = (int)sanityCurrent;
                sanityPercent = sanityCurrent / sanityMax;
            }
        }



        //sanityEffects
        if (sanityChange != sanityCurrent)
        {
            SanityEffects();
            sanityChange = sanityCurrent;
        }
        
    }

    public void SanityEffects()
    {
        
        if (sanityPercent == 100)
        {
            // do nothing
        }
        else if (sanityPercent < 100 && sanityPercent >= 75)
        {
            
        }
        else if (sanityPercent < 75 && sanityPercent >= 50)
        {

        }
        else if (sanityPercent < 50 && sanityPercent >= 35)
        {

        }
        else if (sanityPercent < 50 && sanityPercent >= 35)
        {

        }
        else if (sanityPercent < 50 && sanityPercent >= 35)
        {

        }

    }
}
