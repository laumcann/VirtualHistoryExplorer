using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This class runs the flintknapping minigame. A method is called to detect if a specific object (hammersotne) has collided with the game object in question.
If this condition is true, a particle effect will be called, and once the objects are no longer colliding the final product (handaxe) will appear on screen.*/
public class DetectCollisionWithHammerstone : MonoBehaviour

{

    public GameObject congrats;

    // Create reference to the Handaxe 
    
    public GameObject handaxe;

    // Create reference to the particle system to be used 
    
    public GameObject particles;

    // Create reference to audio source

    public AudioSource audio;
    
    // Start is called before the first frame update
    void Start()
    {

        // At the beginning of the interaction the handaxe should not be present on screen, therefore the method SetActive() will be called and the parameter set to false
        handaxe.SetActive(false);

        particles.SetActive(false);
        
    }

    void Update() {


    }

        // On collision with an object, the script first checks that the object collided with is under the name of "Flint Core". If this condition is true then the particle system is called, along with the audio source.
        
        private void OnCollisionEnter(Collider collision)

        {
            if (collision.gameObject.name == "Flint Core")

            {
                particles.SetActive(true);
                audio.Play();
            }
        }

        // When the Hammerstone exits the collision zone of the object, it will be destroyed and the handaxe will appear in it's place
        
       void OnCollisionExit(Collision collision) 

        {
            particles.SetActive(false);
            Destroy(gameObject);
            Destroy(collision.gameObject);
            handaxe.SetActive(true);
            congrats.SetActive(true);
            
        }

        //private IEnumerator HandaxeDelayed(float delay)
        //{
        //yield return new WaitForSeconds(delay);
          //Destroy(gameObject, 2f);
            //Destroy(collision.gameObject, 2f);
            //handaxe.SetActive(true);
    //}
          
}
