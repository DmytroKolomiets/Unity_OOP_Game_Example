using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Decision : MonoBehaviour

{
    public GameObject Player;
    public delegate void Delegate();
    public List<string> myList;
    public abstract void myDecision();
    // This method can call any function in child class after waiting any seconds
    public void Wait(float time , Delegate @delegate)
    {     
        StartCoroutine(myWait(time , @delegate));
    }
    IEnumerator myWait(float TimeToWait , Delegate myDelegate)
    {
        yield return new WaitForSeconds(TimeToWait);
        myDelegate();
    }

}
