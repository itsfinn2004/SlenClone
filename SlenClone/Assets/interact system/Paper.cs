using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paper : MonoBehaviour, Iinteractable
{
    [SerializeField]GameObject gamemaster;
    [SerializeField] private string _prompt;
     WinCondition win;

    private void Awake()
    {
        gamemaster = GameObject.FindWithTag("GameMaster");
        win = gamemaster.GetComponent<WinCondition>();
       
    }

    public string InteractionPrompt => _prompt;
    public bool Interact(Interacter interacter)
    {
        Debug.Log("collecting paper");
        win.collectedPaper++;

        Debug.Log(win.collectedPaper);
        Destroy(gameObject);
        return true;
    }

    

}
