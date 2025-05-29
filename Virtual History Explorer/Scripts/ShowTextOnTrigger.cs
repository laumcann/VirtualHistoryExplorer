using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This class ensures that when a trigger object is collided with, 
a specific piece of text/UI object will be set active and appear on screen*/
public class ShowTextOnTrigger : MonoBehaviour

{
    public GameObject UI;

    void Start()
    {

        UI.SetActive(false);
        
    }

    void OnTriggerEnter (Collider other) 

    {
        if (other.tag == "Player")
            UI.SetActive(true);
            Destroy(gameObject);
        
    }
}
