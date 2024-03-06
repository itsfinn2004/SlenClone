using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
   [SerializeField] GameObject gamemaster;
    public GameObject paperobject;
    public int collectedPaper;
    public int winCount;
    Paper paper;
    GameMaster gm;


    private void Awake()
    {
        paperobject = GameObject.FindWithTag("paper");
        paper = paperobject.GetComponent<Paper>();
        gamemaster = GameObject.FindWithTag("GameMaster");
        gm = gamemaster.GetComponent<GameMaster>();
    }

    private void Update()
    {
        if(collectedPaper == winCount)
        {
            Debug.Log("gewonnen woohooo");
            
        }
    }
}
