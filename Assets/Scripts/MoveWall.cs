using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{
    public AudioSource Wallchange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        Wallchange = GetComponent<AudioSource>();
        StartCoroutine(Waiter());
    }

    //stop being bad
    IEnumerator Waiter()
    {
        float wait_time = Random.Range (0, 2.5f);
        yield return new WaitForSeconds(wait_time);
        Wallchange.Play();
    }
}
