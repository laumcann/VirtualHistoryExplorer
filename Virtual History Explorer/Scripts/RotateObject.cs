using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This class calls upon Unity's rotation system, turning an object round the Y axis by 180 degrees. 
This is to be used within the Museum scenes to display specific historical information and facilitate learning. */
public class RotateObject : MonoBehaviour
{

    public AudioSource audio;


    public void RotateObjectByAmount()
    
    {

        audio.Play();
        gameObject.transform.localRotation *= Quaternion.Euler(0, 180, 0);
    }
}
