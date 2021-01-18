using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OldMan : MonoBehaviour
{
    public Text oldGuyText;
    private float d;
    public GameObject guy;
    public GameObject Canvas2;
    private bool run;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("OldMan2", 0);
        d = 2.8f;
    }

    private void FixedUpdate()
    {
        if (PlayerPrefs.GetInt("OldMan2") == 1 && run == false)
        {
            StartCoroutine(textChange());
            Debug.Log("dfdf");
            guy.transform.GetComponent<AudioSource>().enabled = true;
            run = true;
            Canvas2.gameObject.SetActive(true);
            PlayerPrefs.SetInt("OldMan2", 0);
        }
    }

    private IEnumerator textChange()
    {
        oldGuyText.text = "Old Man: YOU MUST GET OUT of here before it’s too late.";
        yield return new WaitForSeconds(d);
        Canvas2.gameObject.transform.GetChild(0).GetComponent<Animator>().enabled = false;
        Canvas2.gameObject.transform.GetChild(0).GetComponent<Text>().color = new Color32(135, 10, 10, 255);
        oldGuyText.text = "The ghost of Hermia Crux will come for you, and if you aren’t";
        yield return new WaitForSeconds(3.0f);
        oldGuyText.text = "out by midnight, your soul is hers. It is in your best interest";
        yield return new WaitForSeconds(3.2f);
        oldGuyText.text = "to find what the others have gathered. Few have gotten close to.";
        yield return new WaitForSeconds(3.2f);
        oldGuyText.text = "escape, but they have all lost their mind before the end. ";
        yield return new WaitForSeconds(3.2f);
        oldGuyText.text = "You’ll see the possessed lying dead as you try to escape.  ";
        yield return new WaitForSeconds(3.0f);
        oldGuyText.text = " ";
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
