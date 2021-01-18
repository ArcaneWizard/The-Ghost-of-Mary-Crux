using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ghost : MonoBehaviour
{
    public Text GoatText;
    private float d;
    private bool run;

    // Start is called before the first frame update
    void Start()
    {
        d = 2.75f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerPrefs.SetInt("ghost",PlayerPrefs.GetInt("ghost")+1);
        if (collision.collider.gameObject.layer==9 && PlayerPrefs.GetInt("ghost")==1)
        {
            StartCoroutine(textChange());
            run = true;            
        }
    }

    private IEnumerator textChange()
    {
        GoatText.text = "*Shreiking with laughter* You Really think you can escape?";
        yield return new WaitForSeconds(d);
        GoatText.text = "You're a smart one indeed, fitting all the peices together";
        yield return new WaitForSeconds(d);
        GoatText.text = "But ever since my uncle snuck into the house and murdered me in my room,";
        yield return new WaitForSeconds(d);
        GoatText.text = "I have never been able to leave this miserable prison";
        yield return new WaitForSeconds(d);
        GoatText.text = "AND NEITHER WILL YOU!";
        yield return new WaitForSeconds(d);
        GoatText.text = "*Maniacal Laughter*";
        yield return new WaitForSeconds(d);
        GoatText.text = " ";
    }
}
