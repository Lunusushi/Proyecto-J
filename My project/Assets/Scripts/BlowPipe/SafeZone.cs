using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeZone : MonoBehaviour
{
    public LogicBlowPipe logic;
    public int scoreIncreaseRate = 1; 
    public int CurrentPlayer;

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
            if (CurrentPlayer == 1)
            {
                logic.AddScore1(scoreIncreaseRate); 
                yield return new WaitForSeconds(1f);
            }
            if (CurrentPlayer == 2)
            {
                logic.AddScore2(scoreIncreaseRate); 
                yield return new WaitForSeconds(1f);
            } 
        }
    }
}
