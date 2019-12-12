using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Point : MonoBehaviour
{
    public Material myMat;
    public Color startColor;
    public Color ColorToChange;
    public float twinkleTime = 1;
    private void Update()
    {
        myMat.color = Color.Lerp(startColor, ColorToChange, Mathf.PingPong(Time.time, twinkleTime));
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("AgressiveEnemy"))
        {         
            float myDistance = Vector2.Distance(transform.position, other.gameObject.transform.position);           
            if (myDistance < 0.1f)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
