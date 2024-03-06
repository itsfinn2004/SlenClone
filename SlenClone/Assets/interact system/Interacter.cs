using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Interacter : MonoBehaviour
{
    public GameObject gamemaster;
   [SerializeField] private Transform _interactionpoint;
    [SerializeField] private float _interactionPointRadius = 0.5f;
    [SerializeField] private LayerMask _interactableMask;
    WinCondition win;

    private readonly Collider[] _colliders = new Collider[3];
    [SerializeField] private int _numFound;

    public GameObject EToInteract;


    private void Awake()
    {
        gamemaster = GameObject.FindWithTag("GameMaster");
        win = gamemaster.GetComponent<WinCondition>();
    }

    private void Update()
    {
        _numFound = Physics.OverlapSphereNonAlloc(_interactionpoint.position, _interactionPointRadius, _colliders, _interactableMask);
  
        if(_numFound > 0)
        {
            var interactable = _colliders[0].GetComponent<Iinteractable>();

            if(interactable != null && Input.GetKeyDown("e") )
            {
                interactable.Interact(this);
            }
        }
        switch (_numFound)
        {
            case 0:
                EToInteract.SetActive(false);
                break;
            case 1:
                EToInteract.SetActive(true);
                break;
            case 2:
                EToInteract.SetActive(true);
                break;
            default:
                EToInteract.SetActive(false);
                break;
        }
        

    }

    


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_interactionpoint.position, _interactionPointRadius);
    }

}
