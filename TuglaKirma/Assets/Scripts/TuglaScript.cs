using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuglaScript : MonoBehaviour
{


    [SerializeField]
    GameObject brickBrokenEff;

    GameManager gameManager;

    [SerializeField]
    GameObject hakBall;




    private void Awake()
    {
        gameManager = Object.FindObjectOfType<GameManager>();

    }

    private void OnCollisionEnter2D(Collision2D target)
    {
        int mTuglaSkor;

        if (target.gameObject.tag == "ball")
        {
            //kýrýlma efekti
            Instantiate(brickBrokenEff, transform.position, transform.rotation);

            Destroy(gameObject);

            //tuðla skoru
            mTuglaSkor = 5;
            gameManager.SkorUpdate(mTuglaSkor);

            //rastgele hak topu

            int rastgele = Random.Range(0, 101);

            if (rastgele >= 70)
            {
                Instantiate(hakBall, transform.position, transform.rotation);
            }

        }
    }

}
