using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* This class calls upon the UnityEngine.SceneManagement namespace, 
in order to call a load scene method for a specific location */
public class TimelineController : MonoBehaviour

{

    public AudioSource audio;

    public void LoadStoneAgeMuseumScene() 

    {

        // Load Stone Age Museum Scene
        SceneManager.LoadSceneAsync(1); 

    }

    public void LoadBronzeAgeMuseumScene() 

    {

        // Load Bronze Age Museum Scene
        SceneManager.LoadSceneAsync(1);

    }

    public void LoadIronAgeMuseumScene() 

    {

        // Load Iron Age Museum Scene
        SceneManager.LoadSceneAsync(3); 

    }

    public void LoadEqyptMuseumScene() 

    {

        // Load Ancient Egypt Museum Scene
        SceneManager.LoadSceneAsync(5); 
    }

       public void LoadGreeceMuseumScene() 

    {

        // Load Ancient Greece Museum Scene
        SceneManager.LoadSceneAsync(6); 

    }

        public void LoadRomeMuseumScene() 

    {

        // Load Ancient Rome Museum Scene
        SceneManager.LoadSceneAsync(7); 

    }

        public void LoadMAMuseumScene() 

    {

        // Load Middle Ages Museum Scene
        SceneManager.LoadSceneAsync(8); 

    }

        public void LoadBlackDeathMuseumScene() 

    {

        // Load Black Death Museum Scene
        SceneManager.LoadSceneAsync(13); 

    }

        public void LoadVikingsMuseumScene() 

    {

        // Load Vikings Museum Scene
        SceneManager.LoadSceneAsync(9); 

    }

        public void LoadModernMuseumScene() 

    {

        // Load Modern Museum Scene
        SceneManager.LoadSceneAsync(18); 
    }

      public void LoadWWIMuseumScene() 

    {

        // Load WWI Museum Scene
        SceneManager.LoadSceneAsync(19); 

    }

      public void LoadWWIIMuseumScene() 

    {

        // Load WWII  Museum Scene
        SceneManager.LoadSceneAsync(20);

    }

    public void LoadColdWarScene() 

    {

        // Load WWII  Museum Scene
        SceneManager.LoadSceneAsync(20);

    }

    public void LoadDigitalAgeScene() 

    {

        // Load WWII  Museum Scene
        SceneManager.LoadSceneAsync(20);

    }

    public void LoadSpaceAgeScene() 

    {

        // Load WWII  Museum Scene
        SceneManager.LoadSceneAsync(20);

    }

}
