using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    private float speed;
    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {        
       PlayerPrefs.SetInt("Bob3", 0);
        PlayerPrefs.SetInt("Phone", 0);
        PlayerPrefs.SetInt("Mask", 0);
        PlayerPrefs.SetInt("Letter", 0);
        PlayerPrefs.SetInt("ladder", 0);

        speed = 2;
        rig = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rig.freezeRotation = true;

        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            float x = touch.position.x - Screen.width / 2;
            float y = touch.position.y - Screen.height / 2;
            Vector2 dir = new Vector2(x, y);
            dir.Normalize();
            //transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(dir.x * speed - rig.velocity.x, dir.y * speed - rig.velocity.y));
            transform.GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        else
        {
            transform.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }

        if (PlayerPrefs.GetInt("Orient") == 122 && SceneManager.GetActiveScene().buildIndex == 2)
        {
            PlayerPrefs.SetInt("Orient", 0);
            transform.position = new Vector2(-8.72f, 1.21f);
        }

        if (PlayerPrefs.GetInt("Orient") == 52 && SceneManager.GetActiveScene().buildIndex == 2)
        {
            PlayerPrefs.SetInt("Orient", 0);
            transform.position = new Vector2(-10.6f, 1.45f);
        }

        if (PlayerPrefs.GetInt("Orient") == 25 && SceneManager.GetActiveScene().buildIndex == 5)
        {
            PlayerPrefs.SetInt("Orient", 0);
            transform.position = new Vector2(-16.27f, 1.37f);
        }

        if (PlayerPrefs.GetInt("Orient") == 75 && SceneManager.GetActiveScene().buildIndex == 5)
        {
            PlayerPrefs.SetInt("Orient", 0);
            transform.position = new Vector2(3.25f, 4.58f);
        }

        if (PlayerPrefs.GetInt("Orient") == 35 && SceneManager.GetActiveScene().buildIndex == 5)
        {
            PlayerPrefs.SetInt("Orient", 0);
            transform.position = new Vector2(17.12f, 1.53f);
        }

        if (PlayerPrefs.GetInt("Orient") == 75 && SceneManager.GetActiveScene().buildIndex == 5)
        {
            PlayerPrefs.SetInt("Orient", 0);
            transform.position = new Vector2(3.25f, 4.58f);
        }

        if (PlayerPrefs.GetInt("Orient") == 43 && SceneManager.GetActiveScene().buildIndex == 3)
        {
            PlayerPrefs.SetInt("Orient", 0);
            transform.position = new Vector2(-2.19f, 6.69f);
        }

        if (PlayerPrefs.GetInt("Orient") == 93 && SceneManager.GetActiveScene().buildIndex == 3)
        {
            PlayerPrefs.SetInt("Orient", 0);
            transform.position = new Vector2(8.53f, 5.75f);
        }

        if (PlayerPrefs.GetInt("Orient") == 34 && SceneManager.GetActiveScene().buildIndex == 4)
        {
            PlayerPrefs.SetInt("Orient", 0);
            transform.position = new Vector2(-4.15f, -1.22f);
        }

        if (PlayerPrefs.GetInt("Orient") == 84 && SceneManager.GetActiveScene().buildIndex == 4)
        {
            PlayerPrefs.SetInt("Orient", 0);
            transform.position = new Vector2(1.16f, 6.59f);
        }

        if (PlayerPrefs.GetInt("Orient") == 41 && SceneManager.GetActiveScene().buildIndex == 1)
        {
            PlayerPrefs.SetInt("Orient", 0);
            transform.position = new Vector2(8.85f, 0.99f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 11)
        {
            if (PlayerPrefs.GetInt("Bob3") == 0)
            {
                PlayerPrefs.SetInt("OldMan2", 1);
                PlayerPrefs.SetInt("Bob3", 1);
            }
        }
    }

   

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.gameObject.layer == 10)
        {
            if (SceneManager.GetActiveScene().buildIndex == 12)
            {
                if (collision.collider.gameObject.name == "1")
                {
                    PlayerPrefs.SetInt("Orient", 122);
                    SceneManager.LoadScene(2);
                }
            }

            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                if (collision.collider.gameObject.name == "1")
                {
                    SceneManager.LoadScene(12);
                }

                if (collision.collider.gameObject.name == "2")
                {
                    PlayerPrefs.SetInt("Orient", 25);
                    SceneManager.LoadScene(5);
                }
            }

            if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                if (collision.collider.gameObject.name == "1")
                {
                    PlayerPrefs.SetInt("Orient", 52);
                    SceneManager.LoadScene(2);
                }

                if (collision.collider.gameObject.name == "2")
                {
                    PlayerPrefs.SetInt("Orient", 53);
                    SceneManager.LoadScene(3);
                }

                if (collision.collider.gameObject.name == "3")
                {
                    PlayerPrefs.SetInt("Orient", 57);
                    SceneManager.LoadScene(7);
                }

                if (collision.collider.gameObject.name == "4")
                {
                    PlayerPrefs.SetInt("Orient", 511);
                    SceneManager.LoadScene(11);
                }
            }

            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                if (collision.collider.gameObject.name == "1")
                {
                    PlayerPrefs.SetInt("Orient", 35);
                    SceneManager.LoadScene(5);
                }

                if (collision.collider.gameObject.name == "2")
                {
                    PlayerPrefs.SetInt("Orient", 34);
                    SceneManager.LoadScene(4);
                }

                if (collision.collider.gameObject.name == "3")
                {
                    PlayerPrefs.SetInt("Orient", 39);
                    SceneManager.LoadScene(9);
                }
            }

            if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                if (collision.collider.gameObject.name == "1")
                {
                    PlayerPrefs.SetInt("Orient", 43);
                    SceneManager.LoadScene(3);
                }

                if (collision.collider.gameObject.name == "2")
                {
                    PlayerPrefs.SetInt("Orient", 41);
                    SceneManager.LoadScene(1);

                }
                if (collision.collider.gameObject.name == "3")
                {
                    PlayerPrefs.SetInt("Orient", 48);
                    SceneManager.LoadScene(8);
                }
            }

                if (SceneManager.GetActiveScene().buildIndex == 1)
                {
                    if (collision.collider.gameObject.name == "1")
                    {
                        PlayerPrefs.SetInt("Orient", 110);
                        SceneManager.LoadScene(10);
                    }

                    if (collision.collider.gameObject.name == "2")
                    {
                        PlayerPrefs.SetInt("Orient", 14);
                        SceneManager.LoadScene(4);
                    }
                }

                if (SceneManager.GetActiveScene().buildIndex == 6)
                {
                    if (collision.collider.gameObject.name == "1")
                    {
                        PlayerPrefs.SetInt("Orient", 61);
                        SceneManager.LoadScene(1);
                    }
                }

                if (SceneManager.GetActiveScene().buildIndex == 7)
                {
                    if (collision.collider.gameObject.name == "1")
                    {
                        PlayerPrefs.SetInt("Orient", 75);
                        SceneManager.LoadScene(5);
                    }
                }

                if (SceneManager.GetActiveScene().buildIndex == 8)
                {
                    if (collision.collider.gameObject.name == "1")
                    {
                        PlayerPrefs.SetInt("Orient", 84);
                        SceneManager.LoadScene(4);
                    }
                }

                if (SceneManager.GetActiveScene().buildIndex == 9)
                {
                    if (collision.collider.gameObject.name == "1")
                    {
                        PlayerPrefs.SetInt("Orient", 93);
                        SceneManager.LoadScene(3);
                    }
                }

                if (SceneManager.GetActiveScene().buildIndex == 10)
                {
                    if (collision.collider.gameObject.name == "1")
                    {
                        PlayerPrefs.SetInt("Orient", 101);
                        SceneManager.LoadScene(1);
                    }
                }

                if (SceneManager.GetActiveScene().buildIndex == 11)
                {
                    if (collision.collider.gameObject.name == "1")
                    {
                        PlayerPrefs.SetInt("Orient", 115);
                        SceneManager.LoadScene(5);
                    }
                }
            }
        }
    }

