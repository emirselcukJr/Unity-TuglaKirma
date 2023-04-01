using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuglaScript : MonoBehaviour
{

    [SerializeField]
    GameObject brickBrokenEff;

    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "ball")
        {
            Instantiate(brickBrokenEff,transform.position,transform.rotation);

            Destroy(gameObject);
        }
    }

}
