using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public int collectedPaper;


    private void Update()
    {
        if(collectedPaper == 7)
        {
            Debug.Log("gewonnen woohooo");
        }
    }
}
