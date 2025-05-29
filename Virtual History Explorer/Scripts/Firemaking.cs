using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firemakinh : MonoBehaviour

{
    public GameObject finalProductFire;

    public ParticleSystem fireParticles;
    
    // Start is called before the first frame update
    void Start()
    {
        fireParticles.Stop();
        
    }

    // Update is called once per frame
    void Update()
    {

        void OnCollisionStay(Collider collider)

        {
            if (collider.tag == "firebase")

            {
                fireParticles.Play();
            }
        }

        void OnCollisionExit(Collision colliosion) 

        {
            fireParticles.Stop();
            finalProductFire.SetActive(true);
        }
        
    }
}
