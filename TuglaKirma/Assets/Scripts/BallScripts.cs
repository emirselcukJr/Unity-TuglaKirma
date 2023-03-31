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

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
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
}
