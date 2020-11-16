using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;



public class PlayerMovement : MonoBehaviour
{
    public GameM gamem;
    public float jump = 50f;
    bool onGround = false;
    public Rigidbody2D rb;
    public GameObject Power1;
    public int score = 0;
    public Text scoreText, highScoreText;
  


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        scoreText.text = "SCORE: " + score.ToString();
        if (score == 5)
        {
            gamem.ShowPower1();
        }
        else if(score == 10)
        {
            gamem.ShowPower2();
        }
        else if (score == 15)
        {
            gamem.ShowPower3();
        }
        else if (score == 20)
        {
            gamem.ShowPower4();
        }
        else if (score == 25)
        {
            gamem.ShowPower5();
        }
        else if (score == 30)
        {
            gamem.ShowPower6();
        }
        else if (score == 35)
        {
            gamem.ShowPower7();
        }
        else if (score == 40)
        {
            gamem.ShowPower8();
        }

    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            rb.velocity = Vector2.up * jump;
        }
        
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            onGround = true;
        }

        if (collision.collider.tag == "brick")
        {
            gamem.GameOver();
            
        }
        
    }



    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            onGround = true;
        }
    }



    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            onGround = false;
        }
    }

   


    




}
