using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour 
{
    float speed;
    Transform target;
     public bool act;
  
    public void attack(Transform Target, float Speed , bool Act)
    {      
       
        target = Target;
        speed = Speed;
        act = Act;
      
    }
    private void Update()
    {
        if(act)
        {
           
           transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

    }

}
