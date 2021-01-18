using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Phone : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Phone") == 1)
            gameObject.SetActive(false);
    }

    private IEnumerator realization()
    {
        text.text = "Interesting, the name on the back says Caleton Crux.";
        yield return new WaitForSeconds(2.5f);
        text.text = "I guess that was Hermian's father.";
        yield return new WaitForSeconds(2.5f);
        text.text = "";
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.layer == 9)
        {
                PlayerPrefs.SetInt("Phone", 0);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<PolygonCollider2D>().enabled = false;
            StartCoroutine(realization());                
        }
    }
}
