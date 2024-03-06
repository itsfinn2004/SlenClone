using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    Paper paper;
    public GameObject paperObject;
    WinCondition win;

    private void Awake()
    {
        paper = GetComponent<Paper>();
        paper = paperObject.GetComponent<Paper>();
        win = GetComponent<WinCondition>();
    }


    public IEnumerator YouCollected()
    {
        switch(win.collectedPaper)
        {
            case 1:
                paper.youCollectedText.SetText($"you have collected: {win.collectedPaper} paper");
                break;
            default:
                if(win.collectedPaper == win.winCount)
                {
                    paper.youCollectedText.SetText("you have collected all the papers, you win!!");
                }
                else
                {
                paper.youCollectedText.SetText($"you have collected: {win.collectedPaper} papers");
                }
                break;
        }
        paper.youCollectedGameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        paper.youCollectedGameObject.SetActive(false);
    }
}
