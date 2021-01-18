using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ladder : MonoBehaviour
{

    public Text text;


    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 4 && PlayerPrefs.GetInt("ladder") == 1)
        {
            GameObject.Find("ladder").gameObject.SetActive(false);
        }
        Debug.Log(PlayerPrefs.GetInt("ladder"));
    }

    private IEnumerator realization()
    {
        text.text = "Look, a ladder. This may be helpful later on";
        yield return new WaitForSeconds(2.5f);
        text.text = "";
        yield return new WaitForSeconds(2.5f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.layer == 14)
        {
            PlayerPrefs.SetInt("ladder", 1);
            Destroy(collision.gameObject);
            //StartCoroutine(foundtext());
            StartCoroutine(realization());

        }
        if (PlayerPrefs.GetInt("ladder") == 1)
        {
            if (collision.collider.gameObject.name == "Cube (30)" && SceneManager.GetActiveScene().buildIndex == 3)
            {
                collision.collider.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            }
        }
    }

    //private IEnumerator foundtext()
    //{
      //  ladderText.text = "Ladder Found...";
       // yield return new WaitForSeconds(3);
      //  ladderText.text = " ";
    //}
}
