using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    public Decision myObj;
    private void Start()
    {
        myObj = GetComponent<Decision>(); // can store any object of a class that inherits class Decision, for example, an object of class SmallEnemy.
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myObj.Player = other.gameObject; 
        }
         myObj.myList.Add(other.gameObject.tag);
         myObj.myDecision(); // call overridden method myDecision
    }
    private void OnTriggerExit(Collider other)
    {
        myObj.myList.Remove(other.gameObject.tag);
      
    }   
}
