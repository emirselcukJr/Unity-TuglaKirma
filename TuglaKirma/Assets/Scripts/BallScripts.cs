using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScripts : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField]
    float speed = 700f;

    [SerializeField]
    bool inGame;

    [SerializeField]
    Transform ballStartPos;

    GameManager gameManager;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        gameManager = Object.FindObjectOfType<GameManager>();
    }

    void Update()
    {
        if (inGame == false)
        {
            transform.position = ballStartPos.position;
        }




        //topun paddle daki hareketi
        if (Input.GetButtonDown("Jump") && !inGame)
        {
            inGame = true;
            rb.AddForce(Vector2.up * speed);
        }

    }


    private void OnTriggerEnter2D(Collider2D Target)
    {
        if (Target.tag == "floor")
        {
            rb.velocity = Vector2.zero;

            gameManager.HakUpdate(-1);
            
            inGame = false;
        }
    }
}
