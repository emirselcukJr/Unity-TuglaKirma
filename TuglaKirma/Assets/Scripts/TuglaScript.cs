using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuglaScript : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "ball")
        {
            Destroy(gameObject);
        }
    }

}
