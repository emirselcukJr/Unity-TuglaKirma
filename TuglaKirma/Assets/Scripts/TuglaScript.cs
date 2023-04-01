using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuglaScript : MonoBehaviour
{


    [SerializeField]
    GameObject brickBrokenEff;

    GameManager gameManager;

    

    private void Awake()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D target)
    {
        int mTuglaSkor;

        if (target.gameObject.tag == "ball")
        {
            Instantiate(brickBrokenEff,transform.position,transform.rotation);

            Destroy(gameObject);

            mTuglaSkor = 5;

            gameManager.SkorUpdate(mTuglaSkor);

        }
    }

}
