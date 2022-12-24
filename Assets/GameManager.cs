using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public Text[] spaceList;
    private int moves;
    public string side; 
    public GameObject EndOverlay;
    public Text winner;
    private bool tie = false;
//Declaring all the variables

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    //Restarting Game by going back to the main menu

    public void QuitGame()
    {
        Application.Quit();
    }

    //Quits Application with the click of the quit button

    public void EndScreen(bool tie)
    {
        EndOverlay.SetActive(true);
        if (tie == true)
        {
            winner.text = "There was a tie";
        }
        else
        {
            winner.text = "The winner is " + side;
        }
        
    }
    //If there was a tie using the parameter, the text displays so

    void Start()
    {
        SetGameControllerReferenceForButtons();
        side = "X";
        moves = 0;
        EndOverlay.SetActive(false);
    }
    //Start commands setting the controller references for each button the side and moves

    // Update is called once per frame
    void SetGameControllerReferenceForButtons()
    {
	for (int i = 0; i < spaceList.Length; i++)
    {
        spaceList[i].GetComponentInParent<GridSpace>().SetControllerReference(this);
    }	
    }
    //Sets a reference from Gridspace to know what space you are clicking

    public void SwitchSides() 
    {
        if (side == "X")
        {
            side = "O";
        }
            
        else
        {   
            side = "X";
        }
    }
    //If the side is on X, make it O and vice versa.

    public void EndTurn() 
    {
        foreach (Text text in spaceList)
        {
            UnityEngine.Debug.Log(text);
        }
        

        moves++;
        if (spaceList[0].text == side && spaceList[1].text == side && spaceList[2].text == side)
        {
            EndScreen(tie = false);
        }
        else if (spaceList[3].text == side && spaceList[4].text == side && spaceList[5].text == side)
        {
            EndScreen(tie = false);
        }
        else if  (spaceList[6].text == side && spaceList[7].text == side && spaceList[8].text == side)
        {
            EndScreen(tie = false);
        }
        else if (spaceList[0].text == side && spaceList[3].text == side && spaceList[6].text == side)
        {
            EndScreen(tie = false);
        }
        else if(spaceList[1].text == side && spaceList[4].text == side && spaceList[7].text == side)
        {
            EndScreen(tie = false);
        }
        else if (spaceList[0].text == side && spaceList[4].text == side && spaceList[8].text == side)
        {
            EndScreen(tie = false);
        }
        else if (spaceList[2].text == side && spaceList[5].text == side && spaceList[8].text == side)
        {
            EndScreen(tie = false);
        }
        else if (spaceList[2].text == side && spaceList[4].text == side && spaceList[6].text == side)
        {
            EndScreen(tie = false);
        }
        if (moves >= 9)
        {
            EndScreen(tie = true);
        }
        SwitchSides();
    }
    //All the different scenarios in which a game could be won

    public string GetSide()
    {   
        return side;
    }
    //Return the side back on GetSide to the Gridspace Script
}
