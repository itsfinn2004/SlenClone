using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Paper : MonoBehaviour, Iinteractable
{
    [SerializeField]GameObject gamemaster;
    [SerializeField] private string _prompt;
     WinCondition win;
    GameMaster gm;
    public TextMeshProUGUI youCollectedText;
    public GameObject youCollectedGameObject;
    

    private void Awake()
    {
        gamemaster = GameObject.FindWithTag("GameMaster");
        win = gamemaster.GetComponent<WinCondition>();
        gm = gamemaster.GetComponent<GameMaster>();
       
    }

    public string InteractionPrompt => _prompt;
    public bool Interact(Interacter interacter)
    {
        Debug.Log("collecting paper");
        win.collectedPaper++;
        
        Debug.Log("test 1");
        gameObject.transform.position = new Vector3(-100, -100, -100);
        StartCoroutine(gm.YouCollected());




        Debug.Log(win.collectedPaper);
       
        return true;
    }

    

    

}
