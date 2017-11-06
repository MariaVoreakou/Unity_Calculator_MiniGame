using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour {

    public bool gameover = false; //for the future
    int level = 1; //for the future

    // Use this for initialization
    void Start () {
		
	}
    // Update is called once per frame
    void Update() {
        RunGame();
        //for the future
        if (gameover == true)
        {
            Application.Quit();
        }
		
	}
    // start the calculetor game
    public void RunGame()
    {
        Debug.Log("Lets Start!\n");
       
        Debug.Log("Normal Calc!\n");
        
        GameObject.FindGameObjectWithTag("Player").GetComponent<CalcScript>().NormalCalculate();
        Debug.Log("------------------------\n");
        Debug.Log("Fake Calc!\n");
     
        GameObject.FindGameObjectWithTag("Player").GetComponent<CalcScript>().AbnormalCalculate();
    }

    //for future plan
    void nextLevel()
    {
        level++;
    }
}
