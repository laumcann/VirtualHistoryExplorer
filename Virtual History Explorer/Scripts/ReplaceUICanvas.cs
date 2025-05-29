using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReplaceUICanvas : MonoBehaviour
{

    public GameObject itemOne;

    public GameObject itemTwo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReplaceUI() 

    {
        itemOne.SetActive(true);
        itemTwo.SetActive(false);
    }
}
