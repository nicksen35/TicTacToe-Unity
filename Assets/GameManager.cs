using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text[] spaceList;
    
    public string GetSide = "X";

    public void SwitchSides() 
    {
        if (GetSide == "X")
        {
            GetSide = "0";
        }
            
        else
        {
            GetSide = "X";
        }
    }

    public void EndTurn() 
    {

    }
}
