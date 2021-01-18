using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Letter : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Letter") == 1)
            gameObject.SetActive(false);
    }

    private IEnumerator realization()
    {
        text.gameObject.SetActive(true);
        yield return new WaitForSeconds(6.0f);
        text.text = "The only way to escape from this deathly hallow is the tunnel dug under the prison beds. Tomorrow, we'll make the big escape, but if the demon blocks it, our fate is sealed. -Jebadiah JongTree";
        yield return new WaitForSeconds(6.0f);
        text.text = "";
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.layer == 9)
        {
            PlayerPrefs.SetInt("Letter", 0);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            StartCoroutine(realization());
        }
    }
}
