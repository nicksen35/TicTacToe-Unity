using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD

public class GridSpace : MonoBehaviour
{
    private static GameManager gm;


    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
=======
using UnityEngine.UI;

public class GridSpace : MonoBehaviour
{
    public Button button;
    public Text buttontext;
    private GameManager gm;

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
 
>>>>>>> 00ee2f9 (Basic Logic)
}
