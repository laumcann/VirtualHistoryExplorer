using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DropdownChoices : MonoBehaviour
{   

    // Create a reference to the Dropdown UI GameObject
    public TMPro.TMP_Dropdown dropdown;
    
    // Create a reference to the Snap Turn Provider Component (Action-Based)
    public ActionBasedSnapTurnProvider snapTurn;

    // Create a referencer to the Continuous Turn Provider Component (Action-Based)
    public ActionBasedContinuousTurnProvider continuousTurn;

    // Create a method that can be called which listens for the users choice within the dropdown and responds accordingly
    public void PlayerChoice()

    {
        // If the first dropdown value is chosen (value: integer 0), the snap turn component is enabled
        if (dropdown.value == 0)

        {

            snapTurn.enabled = true;

        }

        // If the second dropdown value is chosen (value: integer 1), the continuous turn component is enabled

        else if(dropdown.value == 1)
        
        {

            continuousTurn.enabled = true;

        }

        else 

        {

            Debug.Log("Error");

        }
    }
}
