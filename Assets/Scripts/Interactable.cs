using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public float radius = 2f;
    public string interactText = "I'm text"; 

    public abstract void Interact();

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    //private void OnTriggerEnter(Collider collision)
    //{
        
    //}

    //private void OnTriggerExit(Collider collision)
    //{
        
    //}
}
