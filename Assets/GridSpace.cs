using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GridSpace : MonoBehaviour
{
    private static GameManager gm;
    public Button button;
    public Text buttontext;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Start is called before the first frame update
       public void SetControllerReference(GameManager manager)
    {
	    gm = manager;
    }

    public void SpaceSet() 
    {
        UnityEngine.Debug.Log("Hello"); 
        buttontext.text = gm.GetSide(); 
        button.interactable = false;
        gm.EndTurn();
    }
 
}
