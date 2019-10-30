using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{
    private bool beginscene;
    private float timePlayed;
    public AudioSource Wallchange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timePlayed += Time.deltaTime;
        if (timePlayed <= 2)
        {
            beginscene = true;

        }
        else
        {
            beginscene = false;
        }
    }

    private void OnEnable()
    {
        Wallchange = GetComponent<AudioSource>();
        if (beginscene == false)
        {
            StartCoroutine(Waiter());
        }
    }

    //stop being bad
    IEnumerator Waiter()
    {
        float wait_time = Random.Range (0, 1.0f);
        yield return new WaitForSeconds(wait_time);
        Wallchange.Play();
    }
    void Awake()
    {
        timePlayed = 0.0f;
        beginscene = true;

    }
}
