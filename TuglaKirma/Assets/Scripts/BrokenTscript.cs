using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenTscript : MonoBehaviour
{

    [SerializeField]
    int count;

    [SerializeField]
    Sprite brokenBrick;

    void Start()
    {
        count = 0;  
    }

    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "ball")
        {
            GetComponent<SpriteRenderer>().sprite = brokenBrick;
            count++;

            if (count == 2)
            {
                Destroy(gameObject);
            }
        }
    }


}
