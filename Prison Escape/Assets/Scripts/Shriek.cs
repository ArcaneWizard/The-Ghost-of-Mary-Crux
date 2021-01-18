using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shriek : MonoBehaviour
{
    private bool zoom;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Zoom());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Zoom()
    {
        yield return new WaitForSeconds(Random.Range(18.5f, 22.3f));
        gameObject.transform.GetComponent<AudioSource>().Play();
        StartCoroutine(Zoom());
    }
}
