using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Sanity : MonoBehaviour
{
    public List<GameObject> SanityMasterList = new List<GameObject>();

    public GameObject symbol;

    [SerializeField] private float sanityMax = 100;
    [SerializeField] private float sanityCurrent;
    [SerializeField] private int iSanityCurrent;
    [SerializeField] private float sanityPercent;
    [SerializeField] private float SanitySpeed;
    [SerializeField] private int masterListCount;
    private float listPercent;
    private float sanityChange;



    RaycastHit clohit;
    private Vector3 rayhitInWorld;

    // Start is called before the first frame update
    void Start()
    {
        listPercent = 0.1f;
        sanityCurrent = sanityMax;
        SanitySpeed = 1.0f;
        masterListCount = SanityMasterList.Count;
        SetSanity();
        
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
                sanityCurrent -= Time.deltaTime * SanitySpeed;
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
            SanitySpeed = 1.5f;
        }
        else if (sanityPercent < 75 && sanityPercent >= 50)
        {
            SanitySpeed = 2.0f;
        }
        else if (sanityPercent < 50 && sanityPercent >= 35)
        {
            SanitySpeed = 2.5f;
        }
        else if (sanityPercent < 35 && sanityPercent >= 25)
        {
            SanitySpeed = 3f;
        }
        else if (sanityPercent < 25 && sanityPercent >= 10)
        {
            SanitySpeed = 3.5f;
        }

    }

    void SetSanity()
    {
        for (int i = 0; i < SanityMasterList.Count * listPercent - 1; i++)
        {
            int ranNum = Random.Range(1, 3);
            SanityMasterList[i].GetComponent<SanityObject>().sanityLevel = ranNum;
        }

        //SanityMasterList.RemoveRange(0, SanityMasterList.Count*listPercent-1);
        listPercent += 0.1f;
        for (int i = 0; i < SanityMasterList.Count * listPercent - 1; i++)
        {
            int ranNum = Random.Range(3, 5);
            SanityMasterList[i].GetComponent<SanityObject>().sanityLevel = ranNum;
        }
    }
}
