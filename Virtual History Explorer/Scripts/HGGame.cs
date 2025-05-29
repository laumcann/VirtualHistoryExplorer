using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

/* This class runs the huntergatherer minigame. It detects when a specific item has been collected and adds it to the item count in the UI. 
Once a maximum number of items has been reached, a game completed scene will appear on screen.
This is intended to educate the player on the hunter-gatherer diet and environment. */
public class HGGame : MonoBehaviour

{

    // Serialize field?
    
    // Create TMP variables references in order to access the specific UI textmesh component for each item to be collected
    
    public TextMeshProUGUI nutScore;

    public TextMeshProUGUI fishScore;

    public TextMeshProUGUI appleScore;

    public TextMeshProUGUI vegScore;

    public TextMeshProUGUI seedScore;

    // Create reference to item count
    
    private int nutCount;

    private int fishCount;

    private int appleCount;

    private int vegCount;

    private int seedCount;

    // Start is called before the first frame update
    void Start()
    {

        // This will assign the item count to 0 for each at the beginning of the game
        
        nutCount = 0;

        fishCount = 0;

        appleCount = 0;

        vegCount = 0;

        seedCount = 0;

    }

    void Update()
    {

    

        
    // Assign the text score of each item to item name + item count, the ToString() method is used to convert from an int to a string

        nutScore.text = "Nut:" + nutCount.ToString();

        fishScore.text = "Fish:" + fishCount.ToString();

        appleScore.text = "Apple:" + appleCount.ToString();

        vegScore.text = "Veg:" + vegCount.ToString();

        seedScore.text = "Seed:" + seedCount.ToString();

    }

       
    // When a specific object is collided with, the tag of the object is checked. If this matches then the object is destoryed (collected) and the item count is incremented by one
        
    public void CollectNut()
        
    {
        
    void OnCollisionEnter(Collision collider) 

    {
            
    if (collider.gameObject.tag == "Nut")

        {
            
            Destroy(collider.gameObject);
                nutCount++;
        } 
    }

    }

    public void CollectFish()
        
    {
        
    void OnCollisionEnter(Collision collider) 

    {
            
    if (collider.gameObject.tag == "Fish")

        {
        Destroy(collider.gameObject);
        fishCount++;
        } 
    }

    }

    public void CollectApple()
        
    {
        
    void OnCollisionEnter(Collision collider) 

    {
            
    if (collider.gameObject.tag == "Apple")

    {
        Destroy(collider.gameObject);
        appleCount++;
    } 
    }

    }

    public void CollectVeg()
        
    {
        
    void OnCollisionEnter(Collision collider) 

    {
            
    if (collider.gameObject.tag == "Vegetable")

    {
        Destroy(collider.gameObject);
        vegCount++;
    } 
    }

    }

    public void CollectSeed()
        
    {
        
    void OnCollisionEnter(Collision collider) 

    {
            
    if (collider.gameObject.tag == "Seed")

    {
    Destroy(collider.gameObject);
    seedCount++;
    } 
    }

    }

        // If the score of a certain item reaches maximum amount, then a game completed scene will appear on screen.
        
        //void LoadCongratsScene()

        //{

        //SceneManager.LoadSceneAsync(1);
        
        //}

}



