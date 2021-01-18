using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mask : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Mask") == 1)
            gameObject.SetActive(false);
    }

    private IEnumerator realization()
    {
        text.text = "There's a name on the mask's label. It spells...";
        yield return new WaitForSeconds(2.5f);
        text.text = "Bobafet Crux. That's not the same as the person on the phone";
        yield return new WaitForSeconds(2.5f);
        text.text = "Maybe he's Hernia's uncle or something.";
        yield return new WaitForSeconds(2.5f);
        text.text = "";
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.layer == 9)
        {
            PlayerPrefs.SetInt("Mask", 0);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<PolygonCollider2D>().enabled = false;
            StartCoroutine(realization());
        }
    }
}
