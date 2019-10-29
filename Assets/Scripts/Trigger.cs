using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public int numOfDisappearWalls;
    public int numOfAppearWalls;
    public bool hasHappened = false;
    public GameObject wallAppear;
    public GameObject wallAppear1;
    public GameObject wallAppear2;
    public GameObject wallDisappear;
    public GameObject wallDisappear1;
    public GameObject wallDisappear2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider player)
    {
        if (hasHappened == false)
        {
            switch (numOfAppearWalls)
            {
                case 1:
                    wallAppear.SetActive(true);
                    break;
                case 2:
                    wallAppear.SetActive(true);
                    wallAppear1.SetActive(true);
                    break;
                case 3:
                    wallAppear.SetActive(true);
                    wallAppear1.SetActive(true);
                    wallAppear2.SetActive(true);
                    break;
            }
            switch (numOfDisappearWalls)
            {
                case 1:
                    wallDisappear.SetActive(false);
                    break;
                case 2:
                    wallDisappear.SetActive(false);
                    wallDisappear1.SetActive(false);
                    break;
                case 3:
                    wallDisappear.SetActive(false);
                    wallDisappear1.SetActive(false);
                    wallDisappear2.SetActive(false);
                    break;
            }
            hasHappened = true;
        }
    }
}
