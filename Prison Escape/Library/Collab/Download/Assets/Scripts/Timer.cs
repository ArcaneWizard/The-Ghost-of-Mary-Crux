using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject.transform.parent.gameObject);
        StartCoroutine(TimerStart());
        time = 645f;
    }

    private IEnumerator TimerStart()
    {
        yield return new WaitForSeconds(4f);
        time += 1;
        if (time % 100 >= 60)
            time = time + 40;
        if (time%100 > 9)
        gameObject.transform.GetComponent<Text>().text = (Mathf.Floor(time/100)).ToString() + ":" + (time % 100).ToString() + " pm";
        else
        {
            gameObject.transform.GetComponent<Text>().text = (Mathf.Floor(time / 100)).ToString() + ":0" + (time % 100).ToString() + " pm";
        }
        StartCoroutine(TimerStart());
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
