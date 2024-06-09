using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarButNpc : MonoBehaviour
{
    private float default_Speed;

    private int laneNumber;
    Rigidbody2D rb;
    public int carSprite;
    public Sprite car1, car2, car3, car4, car5, car6, car7, car8, car9,
        car10, car11, car12, car13, car14, car15, car16, car17, car18;

    SpriteRenderer Sprite;


    //private bool isDead;

    void Start()
    {
        Sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        default_Speed = Random.Range(2.5f, 3.5f);
        laneNumber = Random.Range(1,5);
        carSprite = Random.Range(1, 19);
        if(laneNumber == 1)
        {
            transform.position = new Vector3(-1.44f, transform.position.y + 10, 0);
        }    //ÞERÝT NUMARALARI

        else if (laneNumber == 2)
        {
            transform.position = new Vector3(-0.5f, transform.position.y + 10, 0);
        }
        else if (laneNumber == 3)
        {
            transform.position = new Vector3(0.51f, transform.position.y + 10, 0);
        }
        else 
        {
            transform.position = new Vector3(1.46f, transform.position.y + 10, 0);
        }

        switch (carSprite)
        {
            case 1 :
                Sprite.sprite = car1;
                break;
            case 2:
                Sprite.sprite = car2;
                break;
            case 3:
                Sprite.sprite = car3;
                break;
            case 4:
                Sprite.sprite = car4;
                break;
            case 5:
                Sprite.sprite = car5;
                break;
            case 6:
                Sprite.sprite = car6;
                break;
            case 7:
                Sprite.sprite = car7;
                break;
            case 8:
                Sprite.sprite = car8;
                break;
            case 9:
                Sprite.sprite = car9;
                break;
            case 10:
                Sprite.sprite = car10;
                break;
            case 11:
                Sprite.sprite = car11;
                break;
            case 12:
                Sprite.sprite = car12;
                break;
            case 13:
                Sprite.sprite = car13;
                break;
            case 14:
                Sprite.sprite = car14;
                break;
            case 15:
                Sprite.sprite = car15;
                break;
            case 16:
                Sprite.sprite = car16;
                break;
            case 17:
                Sprite.sprite = car17;
                break;
            case 18:
                Sprite.sprite = car18;
                break;

        }  //ARABA SPRÝTELARI
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(rb.velocity.x, default_Speed*50*Time.deltaTime,0);
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "mainCar")
        {
            SceneManager.LoadScene(2);
            Debug.Log("Kaybettin");
        }
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Sollama")
        {
            ScoreManager.score += 50;
        }
    }
}
