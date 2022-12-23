using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text[] spaceList;
<<<<<<< HEAD
    
    public string GetSide = "X";

    public void SwitchSides() 
    {
        if (GetSide == "X")
        {
            GetSide = "0";
=======
    private int moves;
    public string side;
    
    void Start()
    {
        SetGameControllerReferenceForButtons();
        side = "X";
        moves = 0;
    }

    // Update is called once per frame
    void SetGameControllerReferenceForButtons()
    {
	for (int i = 0; i < spaceList.Length; i++)
    {
        spaceList[i].GetComponentInParent<GridSpace>().SetControllerReference(this);
    }
		
    }

    
    

    public void SwitchSides() 
    {
        if (side == "X")
        {
            side = "O";
>>>>>>> 00ee2f9 (Basic Logic)
        }
            
        else
        {
<<<<<<< HEAD
            GetSide = "X";
=======
            side = "X";
>>>>>>> 00ee2f9 (Basic Logic)
        }
    }

    public void EndTurn() 
    {
<<<<<<< HEAD

=======
        moves++;
        if (spaceList[0].text == side && spaceList[1].text == side && spaceList[2].text == side)
        {
            UnityEngine.Debug.Log("You Win");
        }
        else if (spaceList[3].text == side && spaceList[4].text == side && spaceList[5].text == side)
        {
        }
        else if  (spaceList[6].text == side && spaceList[7].text == side && spaceList[8].text == side)
        {

        }
        else if (spaceList[0].text == side && spaceList[3].text == side && spaceList[6].text == side)
        {

        }
        else if(spaceList[1].text == side && spaceList[4].text == side && spaceList[7].text == side)
        {

        }
        else if (spaceList[0].text == side && spaceList[4].text == side && spaceList[8].text == side)
        {

        }
        else if (spaceList[2].text == side && spaceList[4].text == side && spaceList[6].text == side)
        if (moves >= 9)
        {
            UnityEngine.Debug.Log("Too many moves");
        }
        SwitchSides();
    }
    public string GetSide()
    {   
        return side;
>>>>>>> 00ee2f9 (Basic Logic)
    }
}
