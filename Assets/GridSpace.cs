using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GridSpace : MonoBehaviour
{
    private static GameManager gm;
    public Button button;
    public Text buttontext;
    //Calling all variables

    public void SetControllerReference(GameManager manager)
    {
	    gm = manager;
    }
    //Set the controller reference to reference our game manager
    public void SpaceSet() 
    {
        buttontext.text = gm.GetSide(); 
        button.interactable = false;
        gm.EndTurn();
    }
    //Set the space, get the side, then end the turn and make the button uninteractable
 
}
