using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    private bool spin = false;
    private bool zoom = true;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        StartCoroutine(CameraRotate());
        StartCoroutine(Zoom());
    }

    private IEnumerator CameraRotate()
    {
        yield return new WaitForSeconds(Random.Range(4.5f, 6.5f));
        spin = true;
        yield return new WaitForSeconds(Random.Range(0.8f, 1.6f));
        spin = false;
        Camera.main.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        StartCoroutine(CameraRotate());
    }


    private IEnumerator Zoom()
    {
        yield return new WaitForSeconds(Random.Range(4.5f, 6.5f));
        zoom = true;
        yield return new WaitForSeconds(Random.Range(0.8f, 1.6f));
        zoom = false;
        Camera.main.transform.parent.transform.GetChild(1).transform.localScale = new Vector3(1.5f, 1.5f, 1);
        StartCoroutine(Zoom());
    }


    // Update is called once per frame
    void Update()
    {
        if (spin == true)
        {
            Camera.main.transform.rotation = Quaternion.Euler(new Vector3(0, 0, Camera.main.transform.rotation.z + 1200 * Time.deltaTime));
        }
        if (zoom == true)
        {
            float x = Random.Range(0.1f, 0.5f);
            Camera.main.transform.parent.transform.GetChild(1).transform.localScale = new Vector3(x + 0.7f, x + 0.7f, 1);
        }
    }
}
