using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeZone : MonoBehaviour
{
    public LogicBlowPipe logic;
    public int scoreIncreaseRate = 1; 

    private Coroutine scoreCoroutine; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8) 
        {
            if (scoreCoroutine == null)
            {
                scoreCoroutine = StartCoroutine(IncreaseScoreOverTime());
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            if (scoreCoroutine != null)
            {
                StopCoroutine(scoreCoroutine);
                scoreCoroutine = null;
            }
        }
    }

    private IEnumerator IncreaseScoreOverTime()
    {
        while (true) 
        {
            logic.AddScore(scoreIncreaseRate); 
            yield return new WaitForSeconds(1f); 
        }
    }
}
