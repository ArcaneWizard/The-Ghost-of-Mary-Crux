using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireAlarm : MonoBehaviour
{
    public Text text;
    private bool counter;

    // Start is called before the first frame update
    void Start()
    {

    }

    private IEnumerator realization()
    {
        text.text = "An alarm? Hmm... it seems to have triggered as";
        yield return new WaitForSeconds(2.5f);
        text.text = "I went close to that door. Wait, that's the front door.";
        yield return new WaitForSeconds(2.5f);
        text.text = "Someone must have sealed it.";
        yield return new WaitForSeconds(2.5f);
        text.text = "";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            if (counter == false)
            {
                StartCoroutine(realization());
                counter = true;
            }
        }
    }
}
