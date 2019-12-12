using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour 
{
    float speed;
    Transform target;
    public bool act;
    Vector3 moveDirection;

    public void run(Transform Target, float Speed, bool Act)
    {
        
        target = Target;
        speed = Speed;
        act = Act;

    }
    private void Update()
    {
        if (act)
        {
            moveDirection = transform.position - target.position;
            transform.Translate(moveDirection.normalized * speed * Time.deltaTime);
        }

    }
   
   
}
