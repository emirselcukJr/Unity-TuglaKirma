using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class paddleController : MonoBehaviour
{
    [SerializeField]
    float speed;

    [SerializeField]
    float leftTarget, rightTarget;

    
    void Update()
    {
        //Hareket
        float h = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * h * Time.deltaTime * speed);

        //paddle sýnýrlarý
        Vector2 temp = transform.position;
        temp.x = Mathf.Clamp(temp.x, leftTarget, rightTarget);
        transform.position = temp;
    }
}
