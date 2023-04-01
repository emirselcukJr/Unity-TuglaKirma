using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenTscript : MonoBehaviour
{

    [SerializeField]
    int count;

    [SerializeField]
    Sprite brokenBrick;

    [SerializeField]
    GameObject brickBrokenEff;

    GameManager gameManager;

    


    private void Awake()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
        
    }

    void Start()
    {
        count = 0;  
    }

    private void OnCollisionEnter2D(Collision2D target)
    {

        int yTuglaSkor;

        if (target.gameObject.tag == "ball")
        {
            GetComponent<SpriteRenderer>().sprite = brokenBrick;
            count++;

            if (count == 2)
            {
                Instantiate(brickBrokenEff,transform.position,transform.rotation);

                Destroy(gameObject);

                yTuglaSkor = 10;

                gameManager.SkorUpdate(yTuglaSkor);



            }
        }
    }


}
