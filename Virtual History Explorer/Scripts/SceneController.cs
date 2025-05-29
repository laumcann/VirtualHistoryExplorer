using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* This class calls upon the UnityEngine.SceneManagement namespace, 
in order to call a load scene method for a specific location */
public class SceneController : MonoBehaviour

{
    public void LoadTimelineChoicesScene() 

    {
        // Load the Timeline Choices Scene
        SceneManager.LoadSceneAsync(1); 

    }

        public void LoadStoneAgeVillage() 

    {

        // Load Stone Age Village
        SceneManager.LoadSceneAsync(3); 

    }

       public void LoadVikingVillage() 

    {

        // Load Viking Village
        SceneManager.LoadSceneAsync(12); 

    }

        public void LoadMedievalVillage() 

    {

        // Load Medieval Village
        SceneManager.LoadSceneAsync(10); 

    }
  
}
