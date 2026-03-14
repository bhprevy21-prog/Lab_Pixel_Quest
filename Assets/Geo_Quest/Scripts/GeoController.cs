using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GeoController : MonoBehaviour
{
    private Rigidbody2D rb;
    string jaroobed = "bankai";
    int counter = 1;
    public float Speed;
    public string NextLevel = "Level2";
    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("hasdasd");
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(horizontalInput * Speed  , rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            sr.color = Color.yellow; 
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            sr.color = Color.red; 
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            sr.color = Color.blue; 
        }
        /*
        Debug.Log(counter);
        counter++;
        if (Input.GetKeyDown(KeyCode.W)) ;
        transform.position += new Vector3(0, 1, 0);
        */
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hit");
        switch (collision.gameObject.tag)
        {
            case "Death":
                {
                    string levelName = SceneManager.GetActiveScene().name;
                    Debug.Log("player has reahed death");
                    SceneManager.LoadScene(levelName);
                    break;
                }

            case "Finish":
                {
                    SceneManager.LoadScene(NextLevel);
                    break;
                }
        }
    }
         
} 
    
          